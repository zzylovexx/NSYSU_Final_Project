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
        public Form1()
        {
            InitializeComponent();
            // Set the Interval to 0.1 seconds (100 milliseconds).
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

                        if (uVendorID == 0x1DD && uProductCode == 0x10305070) // A2E
                        {
                            nSID = 0;
                            CmbNode.Items.Add("NodeID:"+uNID+" - SlotID:"+nSID + "-A2E");
                            CmbNodeID.Items.Add(uNID.ToString());
                            CmbSlotID.Items.Add(nSID.ToString());
                            Cnt++;
                        }
                        else if (uVendorID == 0x539 && uProductCode == 0x2200001) //Yaskawa
                        {
                            nSID = 0;
                            CmbNode.Items.Add("NodeID:" + uNID + " - SlotID:" + nSID + "-Yaskawa");
                            CmbNodeID.Items.Add(uNID.ToString());
                            CmbSlotID.Items.Add(nSID.ToString());
                            Cnt++;
                        }
                        else if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x0624) //Ec4Axis
                        {
                            for (nSID = 0; nSID < 4; nSID++)
                            {
                                CmbNode.Items.Add("NodeID:" + uNID + " - SlotID:" + nSID + "Ec4Axis");
                                CmbNodeID.Items.Add(uNID.ToString());
                                CmbSlotID.Items.Add(nSID.ToString());
                                Cnt++;
                            }
                        }
                        else if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x5621) //EcAxis
                        {
                            nSID = 0;
                            CmbNode.Items.Add("NodeID:" + uNID + " - SlotID:" + nSID + "EcAxis");
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

                        BtnStop.Enabled = true;
                        RdoSVOFF.Enabled = true;
                        RdoSVON.Enabled = true;
                        BtnMoveLeft.Enabled = true;
                        BtnMoveRight.Enabled = true;
                        BtnResetAlarm.Enabled = true;
                        BtnResetStatus.Enabled = true;
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
            ushort uMCDone = 0, uStstus = 0;
            int nCmd = 0, nPos = 0;
            if (g_nESCExistCards > 0)
            {
                if (ChkRealTimeUpdate.Checked == true)
                {
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Command(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref nCmd);
                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("ECAT_Slave_Motion_Get_Command Fail, Error Code :" + uRet.ToString());
                        ChkRealTimeUpdate.Checked = false;
                        return;
                    }
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref nPos);
                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("ECAT_Slave_Motion_Get_Position Fail, Error Code :" + uRet.ToString());
                        ChkRealTimeUpdate.Checked = false;
                        return;
                    }
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_StatusWord(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref uStstus);
                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("ECAT_Slave_Motion_Get_StatusWord Fail, Error Code :" + uRet.ToString());
                        ChkRealTimeUpdate.Checked = false;
                        return;
                    }
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Mdone(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref uMCDone);
                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("ECAT_Slave_Motion_Get_Mdone Fail, Error Code :" + uRet.ToString());
                        ChkRealTimeUpdate.Checked = false;
                        return;
                    }
                    TxtCmdPos.Text = nCmd.ToString();
                    TxtFbkPos.Text = nPos.ToString();
                    TxtIOStatus.Text = String.Format("0x{0,8:X}", uStstus);
                    TxtMotionDown.Text = uMCDone.ToString();
                }

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

        private void RdoSVON_CheckedChanged(object sender, EventArgs e)
        {            
            ushort uCheckOnOff = 0;
            if (RdoSVON.Checked == true)
                uCheckOnOff = 1;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uCheckOnOff);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_Motion_Set_Svon, Error Code = "+ g_uRet.ToString(), true);
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            double dTdec;

            dTdec = Convert.ToDouble(TxtDeceleration.Text);
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, dTdec);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void BtnResetAlarm_Click(object sender, EventArgs e)
        {
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Ralm(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_Motion_Ralm, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void BtnResetStatus_Click(object sender, EventArgs e)
        {

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Position(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, 0);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_Motion_Set_Position, ErrorCode = " + g_uRet.ToString(), true);
            }
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Command(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, 0);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_Motion_Set_Command, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            AxisMove(0);
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            AxisMove(1);
        }

        private void AxisMove(int nDir)
        {
            int nTargetPos = 0;
            ushort uAbsMove = 0;
            uint uAcceleration = 0, uDeceleration = 0, uConstVel = 0;
            
            nTargetPos = Convert.ToInt32(TxtTargetPos.Text); // 目標速度，(0x60FF Sub 0) inc代表的是驅動器內部設定之單位值
            uConstVel = Convert.ToUInt32(TxtConstVel.Text); // 脈波數/秒 inc/s (0x6081 Sub 0)
            uAcceleration = Convert.ToUInt32(TxtAcceleration.Text); // 加速度 (0x6083 Sub 0)
            uDeceleration = Convert.ToUInt32(TxtDeceleration.Text); // 減速度 (0x6084 Sub 0)

            if (ChkAbsMove.Checked == true)
                uAbsMove = 1; // 0：相對位移(Default) 1：絕對位移

            if (nDir == 0)
                nTargetPos = 0 - nTargetPos;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_PP_Start_Move(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, nTargetPos, uConstVel, uAcceleration, uDeceleration, uAbsMove);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_PP_Start_Move, ErrorCode = " + g_uRet.ToString(), true);
            }
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
    }
}
