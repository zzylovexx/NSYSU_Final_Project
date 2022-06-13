using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

using EtherCAT_DLL;
using EtherCAT_DLL_Err;

namespace EtherCat
{
    public partial class Form1 : Form
    {
        bool g_bInitialFlag = false;
        ushort g_uRet = 0;
        ushort g_nESCExistCards = 0, g_uESCCardNo = 0, g_uESCNodeID = 0, g_uESCSlotID;
        ushort[] g_uESCCardNoList = new ushort[32];
        int[] g_nModeValue = new int[2];
        int[] g_nModeLength = new int[2];
        ushort[] g_uAvgTimes = new ushort[7];
        uint gRevisionNo;
        public Form1()
        {
            InitializeComponent();

            // Set the Interval to 0.1 seconds (100 milliseconds).
            TimCheckStatus.Interval = 100;
            TimCheckStatus.Enabled = true;

            g_nModeValue[0] = -5;
            g_nModeValue[1] = -10;

            g_nModeLength[0] = 10;
            g_nModeLength[1] = 20;

            for (int nCount = 0; nCount < 7; nCount++ )
                g_uAvgTimes[nCount] = (ushort)(0x1 << nCount);
        }

        private void BtnInitialCard_Click(object sender, EventArgs e)
        {   
            ushort uCount = 0, uCardNo = 0;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Open(ref g_nESCExistCards);
            g_bInitialFlag = false;
            CmbCardNo.Items.Clear();
            if (g_nESCExistCards == 0)
            {
                AddErrMsg("No EtherCat can be found!", true);
            }
            else
            {
                for (uCount = 0; uCount < 32; uCount++)
                {
                    g_uESCCardNoList[uCount] = 99;
                }

                for (uCount = 0; uCount < g_nESCExistCards; uCount++)
                {
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_CardSeq(uCount, ref uCardNo);
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Initial(uCardNo);
                    if (g_uRet != 0)
                    {
                        AddErrMsg("_ECAT_Master_Initial, ErrorCode = " + g_uRet.ToString(), true);
                    }
                    else
                    {
                        g_uESCCardNoList[uCount] = uCardNo;
                        CmbCardNo.Items.Add(uCardNo.ToString());
                        g_bInitialFlag = true;
                    }
                }

                if (g_bInitialFlag == true)
                {
                    CmbCardNo.SelectedIndex = 0;
                    g_uESCCardNo = g_uESCCardNoList[0];
                }
            }
        }

        private void BtnFindSlave_Click(object sender, EventArgs e)
        {
            short Cnt = 0;
            ushort uNID = 0, uSlaveNum = 0, uReMapNodeID = 0;
            uint uVendorID = 0, uProductCode = 0, uRevisionNo = 0, uSlaveDCTime = 0;

            TxtSlaveNum.Text = "0";
            CmbNode.Items.Clear();
            g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_SlaveNum(g_uESCCardNo, ref uSlaveNum);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Master_Get_SlaveNum, ErrorCode = " + g_uRet.ToString(), true);
            }
            else
            {
                if (uSlaveNum == 0)
                {
                    AddErrMsg("Card NO: " + g_uESCCardNo.ToString() + " No slave found!", true);
                }
                else
                {
                    CmbNode.Items.Clear();
                    TxtSlaveNum.Text = uSlaveNum.ToString();
                    for (uNID = 0; uNID < uSlaveNum; uNID++)
                    {
                        g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_Slave_Info(g_uESCCardNo, uNID, ref uReMapNodeID, ref uVendorID, ref uProductCode, ref uRevisionNo, ref uSlaveDCTime);

                        if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x8124) //EcAD
                        {
                            gRevisionNo = uRevisionNo;
                            CmbNode.Items.Add(uNID.ToString());
                            Cnt++;
                        }
                    }

                    if (Cnt > 0)
                    {
                        CmbNode.SelectedIndex = 0;

                        CmbADChannel.Enabled = true;
                        CmbADMode.Enabled = true;
                        CmbAvgRange.Enabled = true;
                        CmbConversionTime.Enabled = true;

                        CmbADChannel.SelectedIndex = 0;
                        CmbADMode.SelectedIndex = 0;
                        CmbAvgRange.SelectedIndex = 0;
                        CmbConversionTime.SelectedIndex = 0;
                    }
                }
            }
        }

        private void CmbCardNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCardNo;
            strCardNo = CmbCardNo.Text;
            if (strCardNo.Length > 0)
                g_uESCCardNo = Convert.ToUInt16(strCardNo);
        }

        private void TimCheckStatus_Tick(object sender, EventArgs e)
        {
            ushort uInitialDone = 0, uValue = 0, uRet = 0;
            int nIndexMode = 0;
            double dTempData = 0;
            if (g_nESCExistCards > 0)
            {
                if (ChkRealTimeUpdate.Checked == true)
                {
                    nIndexMode = CmbADMode.SelectedIndex;

                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_AIO_Get_Input_Value(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref uValue);
                    if (uRet == CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        if (gRevisionNo == 0x100000)
                        {
                            dTempData = uValue + 0x8000;

                            if (dTempData >= 0x10000)
                                dTempData -= 0x10000;
                        }

                        dTempData = g_nModeValue[nIndexMode] + (dTempData * g_nModeLength[nIndexMode] / 0xFFFF);
                        TxtData.Text = dTempData.ToString("0.###");
                    }
                }//if (ChkRealTimeUpdate.Checked == true)

                uRet = CEtherCAT_DLL.CS_ECAT_Master_Check_Initial_Done(g_uESCCardNo, ref uInitialDone);
                if (uRet == 0)
                {
                    if (uInitialDone == 0)
                    {
                        TxtInitialStatus.Text = "Initial Done";
                        if (BtnFindSlave.Enabled == false)
                        {
                            BtnFindSlave.Text = "1-2. Find Slave";
                            BtnFindSlave.Enabled = true;
                        }
                    }
                    else if (uInitialDone == 1)
                    {
                        BtnFindSlave.Text = "Wait Initial";
                        TxtInitialStatus.Text = "Pre Initial";
                    }
                    else if (uInitialDone == 99)
                    {
                        BtnFindSlave.Text = "Initial Fail";
                        TxtInitialStatus.Text = "Initial Error";
                    }
                }
            }
        }

        private void CmbNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strNodeID;
            strNodeID = CmbNode.Text;
            if (strNodeID.Length > 0)
                g_uESCNodeID = Convert.ToUInt16(strNodeID);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChkRealTimeUpdate.Checked = false;
            if (g_nESCExistCards > 0)
            {
                for (int i = 0; i < g_nESCExistCards; i++)
                {
                    if (g_uESCCardNoList[i] != 99)
                        CEtherCAT_DLL.CS_ECAT_Master_Reset(g_uESCCardNoList[i]);
                }
                CEtherCAT_DLL.CS_ECAT_Master_Close();
            }
        }

        private void AddErrMsg(string strMsg, bool bShowErr = false)
        {
            LstErrMsg.SelectedIndex = LstErrMsg.Items.Add(strMsg);

            if (bShowErr == true)
                MessageBox.Show(strMsg);
        }

        private void CmbADChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(g_nESCExistCards == 0) return;
            if (CmbADChannel.SelectedIndex < 0)
            {
                AddErrMsg("AD Channel no select", true);
                return;
            }
            g_uESCSlotID = (ushort)CmbADChannel.SelectedIndex;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_ESC8124_Set_Input_Enable(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, 1);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_ESC8124_Set_Input_Enable, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void CmbAvgRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            ushort uMode;
            uMode = g_uAvgTimes[CmbAvgRange.SelectedIndex];
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_ESC8124_Set_Input_AverageMode(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uMode);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_AIO_Set_Input_AverageMode, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void CmbADMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ushort uMode;

            uMode = (ushort)CmbADMode.SelectedIndex;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_ESC8124_Set_Input_RangeMode(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uMode);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_ESC8124_Set_Input_RangeMode, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void CmbConversionTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ushort uMode;

            uMode = (ushort)CmbConversionTime.SelectedIndex;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_ESC8124_Set_Input_ConvstFreq_Mode(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uMode);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_ESC8124_Set_Input_ConvstFreq_Mode, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

    }
}
