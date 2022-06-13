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
        int[] g_nModeValue = new int[7];
        int[] g_nModeLength = new int[7];
        public Form1()
        {
            InitializeComponent();

            // Set the Interval to 0.1 seconds (100 milliseconds).

            g_nModeValue[0] = 0;
            g_nModeValue[1] = 0;
            g_nModeValue[2] = -5;
            g_nModeValue[3] = -10;
            g_nModeValue[4] = 4;
            g_nModeValue[5] = 0;
            g_nModeValue[6] = 0;

            g_nModeLength[0] = 5;
            g_nModeLength[1] = 10;
            g_nModeLength[2] = 10;
            g_nModeLength[3] = 20;
            g_nModeLength[4] = 16;
            g_nModeLength[5] = 20;
            g_nModeLength[6] = 24;

            TrcValue.SetRange(0x0, 0xFFFF);
            TrcValue.TickFrequency = 100;

            TimCheckStatus.Interval = 100;
            TimCheckStatus.Enabled = true;
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

                        if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x9144) //EcDA
                        {
                            CmbNode.Items.Add(uNID.ToString());
                            Cnt++;
                        }
                    }

                    if (Cnt > 0)
                    {
                        CmbDAChannel.Enabled = true;
                        CmbDAMode.Enabled = true;

                        CmbNode.SelectedIndex = 0;
                        CmbDAChannel.SelectedIndex = 0;
                        CmbDAMode.SelectedIndex = 0;

                        BtnApply.Enabled = true;
                        BtnGetCode.Enabled = true;
                        ChkChannel.Enabled = true;
                        TrcValue.Enabled = true;
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
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_AIO_Get_Output_Value(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref uValue);
                    if (uRet == 0)
                    {
                        dTempData = uValue;

                        nIndexMode = CmbDAMode.SelectedIndex;
                        dTempData = g_nModeValue[nIndexMode] + (dTempData * g_nModeLength[nIndexMode] / 0xFFFF);

                        TxtOutValue.Text = dTempData.ToString("0.###");
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
            ChkChannel.Checked = false;
            g_uESCSlotID = (ushort)CmbDAChannel.SelectedIndex;
        }

        private void CmbADMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ushort uMode;

            uMode = (ushort)CmbDAMode.SelectedIndex;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_ESC9144_Set_Output_RangeMode(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uMode);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_ESC9144_Set_Output_RangeMode, ErrorCode = " + g_uRet.ToString(), true);
            }

            ChkChannel.Checked = false;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            ushort uValue = 0;
            uValue = (ushort)TrcValue.Value;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_AIO_Set_Output_Value(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uValue);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_AIO_Set_Output_Value, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void BtnGetCode_Click(object sender, EventArgs e)
        {
            ushort uRtCode = 0;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_R1_EC9144_Get_Output_ReturnCode(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref uRtCode);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_AIO_Set_Output_OverRange_Enable, ErrorCode = " + g_uRet.ToString(), true);
            }
            else
            {
                TxtReturnCode.Text = String.Format("0x{0:X}", uRtCode); 
            }
        }

        private void TrcValue_Scroll(object sender, EventArgs e)
        {
            int nIndexMode = 0;
            double dTempValue;
            nIndexMode = CmbDAMode.SelectedIndex;
            dTempValue = TrcValue.Value;
            dTempValue = g_nModeValue[nIndexMode] + (dTempValue * g_nModeLength[nIndexMode] / 0xFFFF);
            TxtValue.Text = dTempValue.ToString("0.###");
        }

        private void ChkChannel_CheckedChanged(object sender, EventArgs e)
        {
            ushort uEnable = 0;

            if(ChkChannel.Checked == true)
                uEnable = 1;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_ESC9144_Set_Output_Enable(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uEnable);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_ESC9144_Set_Output_Enable, ErrorCode = " + g_uRet.ToString(), true);
            }
        }
    }
}
