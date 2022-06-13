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
        CheckBox[] g_pOutputLab = new CheckBox[16];
        public Form1()
        {
            InitializeComponent();

            // Set the Interval to 0.1 seconds (100 milliseconds).
            TimCheckStatus.Interval = 100;
            TimCheckStatus.Enabled = true;

            g_pOutputLab[0] = ChkBit00;
            g_pOutputLab[1] = ChkBit01;
            g_pOutputLab[2] = ChkBit02;
            g_pOutputLab[3] = ChkBit03;
            g_pOutputLab[4] = ChkBit04;
            g_pOutputLab[5] = ChkBit05;
            g_pOutputLab[6] = ChkBit06;
            g_pOutputLab[7] = ChkBit07;
            g_pOutputLab[8] = ChkBit08;
            g_pOutputLab[9] = ChkBit09;
            g_pOutputLab[10] = ChkBit10;
            g_pOutputLab[11] = ChkBit11;
            g_pOutputLab[12] = ChkBit12;
            g_pOutputLab[13] = ChkBit13;
            g_pOutputLab[14] = ChkBit14;
            g_pOutputLab[15] = ChkBit15;
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
            short nSID = 0, Cnt = 0;
            ushort uNID = 0, uSlaveNum = 0, uReMapNodeID = 0;
            uint uVendorID = 0, uProductCode = 0, uRevisionNo = 0, uSlaveDCTime = 0;

            TxtSlaveNum.Text = "0";
            CmbNode.Items.Clear();
            CmbNodeID.Items.Clear();
            CmbSlotID.Items.Clear();
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
                    CmbNodeID.Items.Clear();
                    CmbSlotID.Items.Clear();
                    TxtSlaveNum.Text = uSlaveNum.ToString();
                    for (uNID = 0; uNID < uSlaveNum; uNID++)
                    {
                        g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_Slave_Info(g_uESCCardNo, uNID, ref uReMapNodeID, ref uVendorID, ref uProductCode, ref uRevisionNo, ref uSlaveDCTime);

                        if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x7062) //Ec16Out
                        {
                            nSID = 0;
                            CmbNode.Items.Add("NodeID:" + uNID + " - SlotID:" + nSID + "-Ec16DI");
                            CmbNodeID.Items.Add(uNID.ToString());
                            CmbSlotID.Items.Add(nSID.ToString());
                            Cnt++;
                        }
                    }

                    if (Cnt > 0)
                    {
                        CmbNode.SelectedIndex = 0;
                        CmbNodeID.SelectedIndex = 0;
                        CmbSlotID.SelectedIndex = 0;
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
            ushort uInitialDone = 0, uRet = 0;
            if (g_nESCExistCards > 0)
            {
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
            int nSelectNode = 0;
            nSelectNode = CmbNode.SelectedIndex;
            CmbNodeID.SelectedIndex = nSelectNode;
            CmbSlotID.SelectedIndex = nSelectNode;
            string strNodeID, strSlotID;
            strNodeID = CmbNodeID.Text;
            if (strNodeID.Length > 0)
                g_uESCNodeID = Convert.ToUInt16(strNodeID);

            strSlotID = CmbSlotID.Text;
            if (strSlotID.Length > 0)
                g_uESCSlotID = Convert.ToUInt16(strSlotID);
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

        private void ChkBit_CheckedChanged(object sender, EventArgs e)
        {
            ushort uOutputStatus = 0;
            int nOutBit = 0, nStat = 0x0;
            for (nOutBit = 0; nOutBit < 16; nOutBit++)
            {
                if (g_pOutputLab[nOutBit].Checked == true)
                {
                    nStat = nStat + (0x1 << nOutBit);
                    g_pOutputLab[nOutBit].BackColor = Color.Green;
                }
                else
                {
                    g_pOutputLab[nOutBit].BackColor = Color.Red;
                }
            }
            uOutputStatus = (ushort)nStat;

            if (g_nESCExistCards > 0)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_DIO_Set_Output_Value(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uOutputStatus);

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    AddErrMsg("_ECAT_Slave_DIO_Set_Output, ErrorCode = " + g_uRet.ToString(), true);
                }
            }
        }

        private void AddErrMsg(string strMsg, bool bShowErr = false)
        {
            LstErrMsg.SelectedIndex = LstErrMsg.Items.Add(strMsg);

            if (bShowErr == true)
                MessageBox.Show(strMsg);
        }
    }
}
