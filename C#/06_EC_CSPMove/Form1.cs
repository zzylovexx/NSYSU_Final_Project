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
        int g_nSelectMode = 0;
        ushort g_nESCExistCards = 0, g_uESCCardNo = 0;
        ushort [] g_uESCNodeID = new ushort [3];
        ushort [] g_uESCSlotID = new ushort [3];
        ushort[] g_uESCCardNoList = new ushort[32];
        TextBox[] g_pTxtParam = new TextBox[12];
        Label[] g_pLabParamTitle = new Label[12];
        Label[] g_pLabParamUnit = new Label[12];
        public Form1()
        {
            InitializeComponent();

            // Set the Interval to 0.1 seconds (100 milliseconds).
            TimCheckStatus.Interval = 100;
            TimCheckStatus.Enabled = true;

            g_pTxtParam[1] = TxtParam01;
            g_pTxtParam[2] = TxtParam02;
            g_pTxtParam[3] = TxtParam03;
            g_pTxtParam[4] = TxtParam04;
            g_pTxtParam[5] = TxtParam05;
            g_pTxtParam[6] = TxtParam06;
            g_pTxtParam[7] = TxtParam07;
            g_pTxtParam[8] = TxtParam08;
            g_pTxtParam[9] = TxtParam09;
            g_pTxtParam[10] = TxtParam10;
            g_pTxtParam[11] = TxtParam11;

            g_pLabParamTitle[1] = LabParam01;
            g_pLabParamTitle[2] = LabParam02;
            g_pLabParamTitle[3] = LabParam03;
            g_pLabParamTitle[4] = LabParam04;
            g_pLabParamTitle[5] = LabParam05;
            g_pLabParamTitle[6] = LabParam06;
            g_pLabParamTitle[7] = LabParam07;
            g_pLabParamTitle[8] = LabParam08;
            g_pLabParamTitle[9] = LabParam09;
            g_pLabParamTitle[10] = LabParam10;
            g_pLabParamTitle[11] = LabParam11;

            g_pLabParamUnit[1] = LabParamUnit01;
            g_pLabParamUnit[2] = LabParamUnit02;
            g_pLabParamUnit[3] = LabParamUnit03;
            g_pLabParamUnit[4] = LabParamUnit04;
            g_pLabParamUnit[5] = LabParamUnit05;
            g_pLabParamUnit[6] = LabParamUnit06;
            g_pLabParamUnit[7] = LabParamUnit07;
            g_pLabParamUnit[8] = LabParamUnit08;
            g_pLabParamUnit[9] = LabParamUnit09;
            g_pLabParamUnit[10] = LabParamUnit10;
            g_pLabParamUnit[11] = LabParamUnit11;

            RdoCSPMode01_CheckedChanged(null, null);

            TrcFeedrate.Maximum = 1000;
            TrcFeedrate.Minimum = 0;
            TrcFeedrate.Value = 100;
            TxtFeedrate.Text = "100";
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
            string strMsg;
            TxtSlaveNum.Text = "0";
            CmbNode1.Items.Clear();
            CmbNodeID1.Items.Clear();
            CmbSlotID1.Items.Clear();
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
                    CmbNode1.Items.Clear();
                    CmbNodeID1.Items.Clear();
                    CmbSlotID1.Items.Clear();
                    CmbNode2.Items.Clear();
                    CmbNodeID2.Items.Clear();
                    CmbSlotID2.Items.Clear();
                    CmbNode3.Items.Clear();
                    CmbNodeID3.Items.Clear();
                    CmbSlotID3.Items.Clear();
                    TxtSlaveNum.Text = uSlaveNum.ToString();
                    for (uNID = 0; uNID < uSlaveNum; uNID++)
                    {
                        g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_Slave_Info(g_uESCCardNo, uNID, ref uReMapNodeID, ref uVendorID, ref uProductCode, ref uRevisionNo, ref uSlaveDCTime);

                        if ( uVendorID == 0x1DD && uProductCode == 0x10305070) // A2E
                        {
                            nSID = 0;
                            strMsg = "NodeID:" + uNID + " - SlotID:" + nSID + "-A2E";
                            CmbNode1.Items.Add(strMsg);
                            CmbNodeID1.Items.Add(uNID.ToString());
                            CmbSlotID1.Items.Add(nSID.ToString());

                            CmbNode2.Items.Add(strMsg);
                            CmbNodeID2.Items.Add(uNID.ToString());
                            CmbSlotID2.Items.Add(nSID.ToString());

                            CmbNode3.Items.Add(strMsg);
                            CmbNodeID3.Items.Add(uNID.ToString());
                            CmbSlotID3.Items.Add(nSID.ToString());
                            Cnt++;
                        }
                        else if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x0624) //Ec4Axis
                        {
                            for (nSID = 0; nSID < 4; nSID++)
                            {
                                strMsg = "NodeID:" + uNID + " - SlotID:" + nSID + "-Ec4Axis";
                                CmbNode1.Items.Add(strMsg);
                                CmbNodeID1.Items.Add(uNID.ToString());
                                CmbSlotID1.Items.Add(nSID.ToString());

                                CmbNode2.Items.Add(strMsg);
                                CmbNodeID2.Items.Add(uNID.ToString());
                                CmbSlotID2.Items.Add(nSID.ToString());

                                CmbNode3.Items.Add(strMsg);
                                CmbNodeID3.Items.Add(uNID.ToString());
                                CmbSlotID3.Items.Add(nSID.ToString());
                                Cnt++;
                            }
                        }
                        else if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x5621) //EcAxis
                        {
                            nSID = 0;
                            strMsg = "NodeID:" + uNID + " - SlotID:" + nSID + "-EcAxis";
                            CmbNode1.Items.Add(strMsg);
                            CmbNodeID1.Items.Add(uNID.ToString());
                            CmbSlotID1.Items.Add(nSID.ToString());

                            CmbNode2.Items.Add(strMsg);
                            CmbNodeID2.Items.Add(uNID.ToString());
                            CmbSlotID2.Items.Add(nSID.ToString());

                            CmbNode3.Items.Add(strMsg);
                            CmbNodeID3.Items.Add(uNID.ToString());
                            CmbSlotID3.Items.Add(nSID.ToString());
                            Cnt++;
                        }
                        else if (uVendorID == 0x539 && uProductCode == 0x2200001) //Yaskawa
                        {
                            nSID = 0;
                            strMsg = "NodeID:" + uNID + " - SlotID:" + nSID + "-Yaskawa";
                            CmbNode1.Items.Add(strMsg);
                            CmbNodeID1.Items.Add(uNID.ToString());
                            CmbSlotID1.Items.Add(nSID.ToString());

                            CmbNode2.Items.Add(strMsg);
                            CmbNodeID2.Items.Add(uNID.ToString());
                            CmbSlotID2.Items.Add(nSID.ToString());

                            CmbNode3.Items.Add(strMsg);
                            CmbNodeID3.Items.Add(uNID.ToString());
                            CmbSlotID3.Items.Add(nSID.ToString());
                            Cnt++;
                        }
                    }

                    if (Cnt > 0)
                    {
                        CmbNode1.SelectedIndex = 0;
                        CmbNodeID1.SelectedIndex = 0;
                        CmbSlotID1.SelectedIndex = 0;

                        BtnStop.Enabled = true;
                        BtnMoveLeft.Enabled = true;
                        BtnMoveRight.Enabled = true;
                        RdoSVOFF.Enabled = true;
                        RdoSVON.Enabled = true;
                        BtnResetAlarm.Enabled = true;
                        BtnResetStatus.Enabled = true;
                        BtnChangeDist.Enabled = true;
                        BtnChangeVel.Enabled = true;
                        ChkSetLimit.Enabled = true;
                        ChkSetGear.Enabled = true;
                        TrcFeedrate.Enabled = true;
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

        private void CmbNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nSelectNode = 0;
            nSelectNode = CmbNode1.SelectedIndex;
            CmbNodeID1.SelectedIndex = nSelectNode;
            CmbSlotID1.SelectedIndex = nSelectNode;
            string strNodeID, strSlotID;
            strNodeID = CmbNodeID1.Text;
            if (strNodeID.Length > 0)
                g_uESCNodeID[0] = Convert.ToUInt16(strNodeID);

            strSlotID = CmbSlotID1.Text;
            if (strSlotID.Length > 0)
                g_uESCSlotID[0] = Convert.ToUInt16(strSlotID);
        }

        private void CmbNode2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nSelectNode = 0;
            nSelectNode = CmbNode2.SelectedIndex;
            CmbNodeID2.SelectedIndex = nSelectNode;
            CmbSlotID2.SelectedIndex = nSelectNode;
            string strNodeID, strSlotID;
            strNodeID = CmbNodeID2.Text;
            if (strNodeID.Length > 0)
                g_uESCNodeID[1] = Convert.ToUInt16(strNodeID);

            strSlotID = CmbSlotID2.Text;
            if (strSlotID.Length > 0)
                g_uESCSlotID[1] = Convert.ToUInt16(strSlotID);
        }

        private void CmbNode3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nSelectNode = 0;
            nSelectNode = CmbNode3.SelectedIndex;
            CmbNodeID3.SelectedIndex = nSelectNode;
            CmbSlotID3.SelectedIndex = nSelectNode;
            string strNodeID, strSlotID;
            strNodeID = CmbNodeID3.Text;
            if (strNodeID.Length > 0)
                g_uESCNodeID[2] = Convert.ToUInt16(strNodeID);

            strSlotID = CmbSlotID3.Text;
            if (strSlotID.Length > 0)
                g_uESCSlotID[2] = Convert.ToUInt16(strSlotID);
        }

        private void RdoSVON_CheckedChanged(object sender, EventArgs e)
        {            
            ushort uCheckOnOff = 0;
            string strMsg;
            if (RdoSVON.Checked == true)
                uCheckOnOff = 1;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], uCheckOnOff);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                strMsg = "CS_ECAT_Slave_Motion_Set_Svon, Error Code = "+ g_uRet.ToString();
                AddErrMsg(strMsg, true);
            }

            if (g_nSelectMode > 2)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(g_uESCCardNo, g_uESCNodeID[1], g_uESCSlotID[1], uCheckOnOff);

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    strMsg = "CS_ECAT_Slave_Motion_Set_Svon, Error Code = " + g_uRet.ToString();
                    AddErrMsg(strMsg, true);
                }
            }

            if (g_nSelectMode > 8)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(g_uESCCardNo, g_uESCNodeID[2], g_uESCSlotID[2], uCheckOnOff);

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    strMsg = "CS_ECAT_Slave_Motion_Set_Svon, Error Code = " + g_uRet.ToString();
                    AddErrMsg(strMsg, true);
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            string strMsg;
            double dTdec;

            dTdec = GetDeceleration();
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], dTdec);
            // 只需停止主軸
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                strMsg = "_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString();
                AddErrMsg(strMsg);
            }
        }

        private void BtnResetAlarm_Click(object sender, EventArgs e)
        {
            string strMsg;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Ralm(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0]);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                strMsg = "_ECAT_Slave_Motion_Ralm, ErrorCode = " + g_uRet.ToString();
                AddErrMsg(strMsg);
            }

            if (g_nSelectMode > 2)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Ralm(g_uESCCardNo, g_uESCNodeID[1], g_uESCSlotID[1]);

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    strMsg = "_ECAT_Slave_Motion_Ralm, ErrorCode = " + g_uRet.ToString();
                    AddErrMsg(strMsg);
                }
            }

            if (g_nSelectMode > 8)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Ralm(g_uESCCardNo, g_uESCNodeID[2], g_uESCSlotID[2]);

                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    strMsg = "_ECAT_Slave_Motion_Ralm, ErrorCode = " + g_uRet.ToString();
                    AddErrMsg(strMsg);
                }
            }
        }

        private void BtnResetStatus_Click(object sender, EventArgs e)
        {
            string strMsg;

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Position(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], 0);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                strMsg = "CS_ECAT_Slave_Motion_Set_Position, ErrorCode = " + g_uRet;
                AddErrMsg(strMsg);
            }
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Command(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], 0);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                strMsg = "CS_ECAT_Slave_Motion_Set_Command, ErrorCode = " + g_uRet;
                AddErrMsg(strMsg);
            }

            if (g_nSelectMode > 2)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Position(g_uESCCardNo, g_uESCNodeID[1], g_uESCSlotID[1], 0);
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    strMsg = "CS_ECAT_Slave_Motion_Set_Position, ErrorCode = " + g_uRet;
                    AddErrMsg(strMsg);
                }
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Command(g_uESCCardNo, g_uESCNodeID[1], g_uESCSlotID[1], 0);
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    strMsg = "CS_ECAT_Slave_Motion_Set_Command, ErrorCode = " + g_uRet;
                    AddErrMsg(strMsg);
                }
            }

            if (g_nSelectMode > 8)
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Position(g_uESCCardNo, g_uESCNodeID[2], g_uESCSlotID[2], 0);
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    strMsg = "CS_ECAT_Slave_Motion_Set_Position, ErrorCode = " + g_uRet;
                    AddErrMsg(strMsg);
                }
                g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Command(g_uESCCardNo, g_uESCNodeID[2], g_uESCSlotID[2], 0);
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    strMsg = "CS_ECAT_Slave_Motion_Set_Command, ErrorCode = " + g_uRet;
                    AddErrMsg(strMsg);
                }
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
	        ushort uDir = 0, uCycleNum = 0, uSCurve = 0, uAbsMove = 0;
	        int[] nCenPot = {0, 0};
            int[] nEndPot = { 0, 0 };
            int[] nDist = { 0, 0, 0 };
            int[] nDist2 = { 0, 0, 0 }; 
            int nDepth = 0, nPitch = 0, nStrVel = 0, nConstVel = 0, nEndVel = 0;
	        int nSpiralInterval = 0;
	        double dTAcc = 0, dTDec = 0, dAngle = 0;
            string strMsg = "";

            if (ChkSCurve.Checked == true)
                uSCurve = 1;

            if (ChkAbsMove.Checked == true)
                uAbsMove = 1;

            g_uRet = (ushort)CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR;

            if (nDir == 0)
                uDir = 1;
            
            if(g_nSelectMode > 2)
            {
                if (CmbNode1.SelectedIndex == CmbNode2.SelectedIndex)
                {
                    strMsg = "Node 2 select error";
                    AddErrMsg(strMsg, true);
                    return;
                }
            }
            if (g_nSelectMode > 8)
            {
                if ((CmbNode1.SelectedIndex == CmbNode3.SelectedIndex)
                || (CmbNode2.SelectedIndex == CmbNode3.SelectedIndex))
                {
                    strMsg = "Node 3 select error";
                    AddErrMsg(strMsg, true);
                    return;
                }
            }
            switch (g_nSelectMode)
            {
                case 1:
                    nDist[0] = (nDir == 1) ? Convert.ToInt32(TxtParam01.Text) : 0-Convert.ToInt32(TxtParam01.Text);
                    nStrVel = Convert.ToInt32(TxtParam02.Text);
                    nConstVel = Convert.ToInt32(TxtParam03.Text);
                    nEndVel = Convert.ToInt32(TxtParam04.Text);
                    dTAcc = Convert.ToDouble(TxtParam05.Text);
                    dTDec = Convert.ToDouble(TxtParam06.Text);
                    
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Move(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], nDist[0], nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if(g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
		                strMsg = "_ECAT_Slave_CSP_Start_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 2:
                    nStrVel = Convert.ToInt32(TxtParam01.Text);
                    nConstVel = Convert.ToInt32(TxtParam02.Text);
                    dTAcc = Convert.ToDouble(TxtParam03.Text);
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_V_Move(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], uDir, nStrVel, nConstVel, dTAcc, uSCurve);
                    if(g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_V_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 3:
                    nDist[0] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam01.Text)) : (Convert.ToInt32(TxtParam01.Text));
                    nDist[1] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam02.Text)) : (Convert.ToInt32(TxtParam02.Text));
                    nStrVel = Convert.ToInt32(TxtParam03.Text);
                    nConstVel = Convert.ToInt32(TxtParam04.Text);
                    nEndVel = Convert.ToInt32(TxtParam05.Text);
                    dTAcc = Convert.ToDouble(TxtParam06.Text);
                    dTDec = Convert.ToDouble(TxtParam07.Text);
		
		            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(g_uESCCardNo, 2, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nDist[0], nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Multiaxes_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 4:
                    nCenPot[0] = Convert.ToInt32(TxtParam01.Text);
                    nCenPot[1] = Convert.ToInt32(TxtParam02.Text);
                    dAngle = (nDir == 0) ? (0 - Convert.ToDouble(TxtParam03.Text)) : Convert.ToDouble(TxtParam03.Text);
                    nStrVel = Convert.ToInt32(TxtParam04.Text);
                    nConstVel = Convert.ToInt32(TxtParam05.Text);
                    nEndVel = Convert.ToInt32(TxtParam06.Text);
                    dTAcc = Convert.ToDouble(TxtParam07.Text);
                    dTDec = Convert.ToDouble(TxtParam08.Text);
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Arc_Move(g_uESCCardNo, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nCenPot[0], dAngle, nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Arc_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 5:
                    nEndPot[0] = Convert.ToInt32(TxtParam01.Text);
                    nEndPot[1] = Convert.ToInt32(TxtParam02.Text);
                    dAngle = (nDir == 0) ? (0 - Convert.ToDouble(TxtParam03.Text)) : Convert.ToDouble(TxtParam03.Text);
                    nStrVel = Convert.ToInt32(TxtParam04.Text);
                    nConstVel = Convert.ToInt32(TxtParam05.Text);
                    nEndVel = Convert.ToInt32(TxtParam06.Text);
                    dTAcc = Convert.ToDouble(TxtParam07.Text);
                    dTDec = Convert.ToDouble(TxtParam08.Text);
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Arc2_Move(g_uESCCardNo, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nEndPot[0], dAngle, nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Arc2_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 6:
                    nCenPot[0] = Convert.ToInt32(TxtParam01.Text);
                    nCenPot[1] = Convert.ToInt32(TxtParam02.Text);
                    nEndPot[0] = Convert.ToInt32(TxtParam03.Text);
                    nEndPot[1] = Convert.ToInt32(TxtParam04.Text);
                    nStrVel = Convert.ToInt32(TxtParam05.Text);
                    nConstVel = Convert.ToInt32(TxtParam06.Text);
                    nEndVel = Convert.ToInt32(TxtParam07.Text);
                    dTAcc = Convert.ToDouble(TxtParam08.Text);
                    dTDec = Convert.ToDouble(TxtParam09.Text);
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Arc3_Move(g_uESCCardNo, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nCenPot[0], ref nEndPot[0], uDir, nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Arc3_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 7:
                    nCenPot[0] = Convert.ToInt32(TxtParam01.Text);
                    nCenPot[1] = Convert.ToInt32(TxtParam02.Text);
                    nSpiralInterval = Convert.ToInt32(TxtParam03.Text);
                    dAngle = (nDir == 0) ? (0 - Convert.ToDouble(TxtParam04.Text)) : Convert.ToDouble(TxtParam04.Text);
                    nStrVel = Convert.ToInt32(TxtParam05.Text);
                    nConstVel = Convert.ToInt32(TxtParam06.Text);
                    nEndVel = Convert.ToInt32(TxtParam07.Text);
                    dTAcc = Convert.ToDouble(TxtParam08.Text);
                    dTDec = Convert.ToDouble(TxtParam09.Text);
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Spiral_Move(g_uESCCardNo, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nCenPot[0], nSpiralInterval, dAngle, nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Spiral_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 8:
                    nCenPot[0] = Convert.ToInt32(TxtParam01.Text);
                    nCenPot[1] = Convert.ToInt32(TxtParam02.Text);
                    nEndPot[0] = Convert.ToInt32(TxtParam03.Text);
                    nEndPot[1] = Convert.ToInt32(TxtParam04.Text);
                    uCycleNum = Convert.ToUInt16(TxtParam05.Text);
                    nStrVel = Convert.ToInt32(TxtParam06.Text);
                    nConstVel = Convert.ToInt32(TxtParam07.Text);
                    nEndVel = Convert.ToInt32(TxtParam08.Text);
                    dTAcc = Convert.ToDouble(TxtParam09.Text);
                    dTDec = Convert.ToDouble(TxtParam10.Text);
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Spiral2_Move(g_uESCCardNo, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nCenPot[0], ref nEndPot[0], uDir, uCycleNum, nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Spiral2_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 9:
                    nCenPot[0] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam01.Text)) : Convert.ToInt32(TxtParam01.Text);
                    nCenPot[1] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam02.Text)) : Convert.ToInt32(TxtParam02.Text);
                    nDepth = Convert.ToInt32(TxtParam03.Text);
                    nPitch = Convert.ToInt32(TxtParam04.Text);
                    nStrVel = Convert.ToInt32(TxtParam05.Text);
                    nConstVel = Convert.ToInt32(TxtParam06.Text);
                    nEndVel = Convert.ToInt32(TxtParam07.Text);
                    dTAcc = Convert.ToDouble(TxtParam08.Text);
                    dTDec = Convert.ToDouble(TxtParam09.Text);
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Heli_Move(g_uESCCardNo, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nCenPot[0], nDepth, nPitch, uDir, nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Heli_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 10:
                    nDist[0] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam01.Text)) : (Convert.ToInt32(TxtParam01.Text));
                    nDist[1] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam02.Text)) : (Convert.ToInt32(TxtParam02.Text));
                    nDist[2] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam03.Text)) : (Convert.ToInt32(TxtParam03.Text));
                    nStrVel = Convert.ToInt32(TxtParam04.Text);
                    nConstVel = Convert.ToInt32(TxtParam05.Text);
                    nEndVel = Convert.ToInt32(TxtParam06.Text);
                    dTAcc = Convert.ToDouble(TxtParam07.Text);
                    dTDec = Convert.ToDouble(TxtParam08.Text);

                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(g_uESCCardNo, 3, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nDist[0], nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Multiaxes_Move, ErrorCode = " + g_uRet.ToString();
                    break;
                case 11:
                    nDist[0] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam01.Text)) : (Convert.ToInt32(TxtParam01.Text));
                    nDist[1] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam02.Text)) : (Convert.ToInt32(TxtParam02.Text));
                    nDist[2] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam03.Text)) : (Convert.ToInt32(TxtParam03.Text));
                    nDist2[0] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam04.Text)) : (Convert.ToInt32(TxtParam04.Text));
                    nDist2[1] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam05.Text)) : (Convert.ToInt32(TxtParam05.Text));
                    nDist2[2] = (nDir == 0) ? (0 - Convert.ToInt32(TxtParam06.Text)) : (Convert.ToInt32(TxtParam06.Text));
                    nStrVel = Convert.ToInt32(TxtParam07.Text);
                    nConstVel = Convert.ToInt32(TxtParam08.Text);
                    nEndVel = Convert.ToInt32(TxtParam09.Text);
                    dTAcc = Convert.ToDouble(TxtParam10.Text);
                    dTDec = Convert.ToDouble(TxtParam11.Text);

                    g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Sphere_Move(g_uESCCardNo, ref g_uESCNodeID[0], ref g_uESCSlotID[0], ref nDist[0], ref nDist2[0], nStrVel, nConstVel, nEndVel, dTAcc, dTDec, uSCurve, uAbsMove);
                    if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        strMsg = "_ECAT_Slave_CSP_Start_Sphere_Move, ErrorCode = " + g_uRet.ToString();
                    break;
            }
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                AddErrMsg(strMsg);
        }

        private void HideAllParam()
        { // 隱藏所有參數欄 再一一開啟
            for (int nNo = 1; nNo < 12; nNo++ )
            {
                g_pTxtParam[nNo].Visible = false;
                g_pLabParamTitle[nNo].Visible = false;
                g_pLabParamUnit[nNo].Visible = false;
            }
        }

        private void SetParamInfo(int nParamNo, string strParamTitle, string strParamUnit, string strValue = "0")
        {
            if (nParamNo < 1 || nParamNo > 11) return;
            g_pLabParamTitle[nParamNo].Visible = true;
            g_pLabParamUnit[nParamNo].Visible = true;
            g_pTxtParam[nParamNo].Visible = true;
            
            g_pTxtParam[nParamNo].Text = strValue;
            g_pLabParamTitle[nParamNo].Text = strParamTitle;
            g_pLabParamUnit[nParamNo].Text = strParamUnit;
        }

        private void RdoCSPMode01_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 1;
            SetParamInfo(1, "Distance", "pluse");
            SetParamInfo(2, "StartVel", "pps");
            SetParamInfo(3, "MaxVel", "pps");
            SetParamInfo(4, "EndVel", "pps");
            SetParamInfo(5, "Acc.", "sec", "0.1");
            SetParamInfo(6, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, false);
            EnableAxis(3, false);
        }

        private void RdoCSPMode02_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 2;
            SetParamInfo(1, "StartVel", "pps");
            SetParamInfo(2, "MaxVel", "pps");
            SetParamInfo(3, "Acc.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, false);
            EnableAxis(3, false);
        }

        private void RdoCSPMode03_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 3;
            SetParamInfo(1, "Distance X", "pluse");
            SetParamInfo(2, "Distance Y", "pluse");
            SetParamInfo(3, "StartVel", "pps");
            SetParamInfo(4, "MaxVel", "pps");
            SetParamInfo(5, "EndVel", "pps");
            SetParamInfo(6, "Acc.", "sec", "0.1");
            SetParamInfo(7, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, false);
        }

        private void RdoCSPMode04_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 4;
            SetParamInfo(1, "Center X", "pluse");
            SetParamInfo(2, "Center Y", "pluse");
            SetParamInfo(3, "Angle", "360/cir");
            SetParamInfo(4, "StartVel", "pps");
            SetParamInfo(5, "MaxVel", "pps");
            SetParamInfo(6, "EndVel", "pps");
            SetParamInfo(7, "Acc.", "sec", "0.1");
            SetParamInfo(8, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, false);
        }

        private void RdoCSPMode05_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 5;
            SetParamInfo(1, "End X", "pluse");
            SetParamInfo(2, "End Y", "pluse");
            SetParamInfo(3, "Angle", "360/cir");
            SetParamInfo(4, "StartVel", "pps");
            SetParamInfo(5, "MaxVel", "pps");
            SetParamInfo(6, "EndVel", "pps");
            SetParamInfo(7, "Acc.", "sec", "0.1");
            SetParamInfo(8, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, false);
        }

        private void RdoCSPMode06_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 6;
            SetParamInfo(1, "Center X", "pluse");
            SetParamInfo(2, "Center Y", "pluse");
            SetParamInfo(3, "End X", "pluse");
            SetParamInfo(4, "End Y", "pluse");
            SetParamInfo(5, "StartVel", "pps");
            SetParamInfo(6, "MaxVel", "pps");
            SetParamInfo(7, "EndVel", "pps");
            SetParamInfo(8, "Acc.", "sec", "0.1");
            SetParamInfo(9, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, false);
        }

        private void RdoCSPMode07_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 7;
            SetParamInfo(1, "Center X", "pluse");
            SetParamInfo(2, "Center Y", "pluse");
            SetParamInfo(3, "Interval", "pluse");
            SetParamInfo(4, "Angle", "pluse");
            SetParamInfo(5, "StartVel", "pps");
            SetParamInfo(6, "MaxVel", "pps");
            SetParamInfo(7, "EndVel", "pps");
            SetParamInfo(8, "Acc.", "sec", "0.1");
            SetParamInfo(9, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, false);
        }

        private void RdoCSPMode08_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 8;
            SetParamInfo(1, "Center X", "pluse");
            SetParamInfo(2, "Center Y", "pluse");
            SetParamInfo(3, "End X", "pluse");
            SetParamInfo(4, "End Y", "pluse");
            SetParamInfo(5, "CycleNum", "cir.");
            SetParamInfo(6, "StartVel", "pps");
            SetParamInfo(7, "MaxVel", "pps");
            SetParamInfo(8, "EndVel", "pps");
            SetParamInfo(9, "Acc.", "sec", "0.1");
            SetParamInfo(10, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, false);
        }

        private void RdoCSPMode09_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 9;
            SetParamInfo(1, "Center X", "pluse");
            SetParamInfo(2, "Center Y", "pluse");
            SetParamInfo(3, "Depth", "pluse");
            SetParamInfo(4, "Pitch", "pluse");
            SetParamInfo(5, "StartVel", "pps");
            SetParamInfo(6, "MaxVel", "pps");
            SetParamInfo(7, "EndVel", "pps");
            SetParamInfo(8, "Acc.", "sec", "0.1");
            SetParamInfo(9, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, true);
        }

        private void RdoCSPMode10_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 10;
            SetParamInfo(1, "Distance X", "pluse");
            SetParamInfo(2, "Distance Y", "pluse");
            SetParamInfo(3, "Distance Z", "pluse");
            SetParamInfo(4, "StartVel", "pps");
            SetParamInfo(5, "MaxVel", "pps");
            SetParamInfo(6, "EndVel", "pps");
            SetParamInfo(7, "Acc.", "sec", "0.1");
            SetParamInfo(8, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, true);
        }

        private void RdoCSPMode11_CheckedChanged(object sender, EventArgs e)
        {
            HideAllParam();
            g_nSelectMode = 11;
            SetParamInfo(1, "Pos X1", "pluse");
            SetParamInfo(2, "Pos Y1", "pluse");
            SetParamInfo(3, "Pos Z1", "pluse");
            SetParamInfo(4, "Pos X2", "pluse");
            SetParamInfo(5, "Pos Y2", "pluse");
            SetParamInfo(6, "Pos Z2", "pluse");
            SetParamInfo(7, "StartVel", "pps");
            SetParamInfo(8, "MaxVel", "pps");
            SetParamInfo(9, "EndVel", "pps");
            SetParamInfo(10, "Acc.", "sec", "0.1");
            SetParamInfo(11, "Dec.", "sec", "0.1");

            EnableAxis(1, true);
            EnableAxis(2, true);
            EnableAxis(3, true);
        }

        private void EnableAxis(int nAxis, bool bEnable)
        {
            switch (nAxis)
            {
                case 1:
                    CmbNode1.Enabled = bEnable;
                    GrpAxis1.Visible = bEnable;
                    break;
                case 2:
                    CmbNode2.Enabled = bEnable;
                    GrpAxis2.Visible = bEnable;
                    if (bEnable == false)
                    {
                        g_uESCNodeID[1] = 0;
                        g_uESCSlotID[1] = 0;
                    }
                    break;
                case 3:
                    CmbNode3.Enabled = bEnable;
                    GrpAxis3.Visible = bEnable;
                    if (bEnable == false)
                    {
                        g_uESCNodeID[2] = 0;
                        g_uESCSlotID[2] = 0;
                    }
                    break;
            }
        }

        private double GetDeceleration()
        { // 取得減速度
            double dDec = 0;
            // 減速度固定在最後一個欄位
            for (int nParam = 1; nParam < 12; nParam++ )
            {
                if (g_pTxtParam[nParam].Visible == true)
                {
                    dDec = Convert.ToDouble(g_pTxtParam[nParam].Text);
                }
            }
            return dDec;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ushort uInitialDone = 0, uRet = 0;
            ushort uMCDone = 0, uStstus = 0, uBuffer = 0;
            int nCmd = 0, nPos = 0, nAxisNum = 0, nSpeed = 0;
            if (g_nESCExistCards > 0)
            {
                if (ChkRealTimeUpdate.Checked == true)
                {
                    if (g_nSelectMode > 0 && g_nSelectMode < 3)
                        nAxisNum = 1;
                    else if (g_nSelectMode > 2 && g_nSelectMode < 9)
                        nAxisNum = 2;
                    else if (g_nSelectMode > 8 && g_nSelectMode < 12)
                        nAxisNum = 3;

                    for (int nAxis = 0; nAxis < nAxisNum; nAxis++)
                    {
                        uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Command(g_uESCCardNo, g_uESCNodeID[nAxis], g_uESCSlotID[nAxis], ref nCmd);
                        if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        {
                            AddErrMsg("ECAT_Slave_Motion_Get_Command Fail, Error Code :" + uRet.ToString());
                            ChkRealTimeUpdate.Checked = false;
                            return;
                        }
                        // Pos
                        uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(g_uESCCardNo, g_uESCNodeID[nAxis], g_uESCSlotID[nAxis], ref nPos);
                        if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        {
                            AddErrMsg("ECAT_Slave_Motion_Get_Position Fail, Error Code :" + uRet.ToString());
                            ChkRealTimeUpdate.Checked = false;
                            return;
                        }
                        // Status
                        uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_StatusWord(g_uESCCardNo, g_uESCNodeID[nAxis], g_uESCSlotID[nAxis], ref uStstus);
                        if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        {
                            AddErrMsg("ECAT_Slave_Motion_Get_StatusWord Fail, Error Code :" + uRet.ToString());
                            ChkRealTimeUpdate.Checked = false;
                            return;
                        }
                        // Motion Down
                        uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Mdone(g_uESCCardNo, g_uESCNodeID[nAxis], g_uESCSlotID[nAxis], ref uMCDone);
                        if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        {
                            AddErrMsg("ECAT_Slave_Motion_Get_Mdone Fail, Error Code :" + uRet.ToString());
                            ChkRealTimeUpdate.Checked = false;
                            return;
                        }
                        // Speed
                        uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Current_Speed(g_uESCCardNo, g_uESCNodeID[nAxis], g_uESCSlotID[nAxis], ref nSpeed);
                        if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        {
                            AddErrMsg("ECAT_Slave_Motion_Get_Mdone Fail, Error Code :" + uRet.ToString());
                            ChkRealTimeUpdate.Checked = false;
                            return;
                        }
                        // Buffer
                        uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Buffer_Length(g_uESCCardNo, g_uESCNodeID[nAxis], g_uESCSlotID[nAxis], ref uBuffer);
                        if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                        {
                            AddErrMsg("ECAT_Slave_Motion_Get_Mdone Fail, Error Code :" + uRet.ToString());
                            ChkRealTimeUpdate.Checked = false;
                            return;
                        }
                        switch (nAxis+1)
                        {
                            case 1:
                                TxtCmdPos1.Text = nCmd.ToString();
                                TxtFbkPos1.Text = nPos.ToString();
                                TxtIOStatus1.Text = String.Format("0x{0,4:X}", uStstus);
                                TxtSpeed1.Text = nSpeed.ToString();
                                TxtMotionDown1.Text = uMCDone.ToString();
                                TxtBuffer1.Text = uBuffer.ToString();
                                break;
                            case 2:
                                TxtCmdPos2.Text = nCmd.ToString();
                                TxtFbkPos2.Text = nPos.ToString();
                                TxtIOStatus2.Text = String.Format("0x{0,4:X}", uStstus);
                                TxtSpeed2.Text = nSpeed.ToString();
                                TxtMotionDown2.Text = uMCDone.ToString();
                                TxtBuffer2.Text = uBuffer.ToString();
                                break;
                            case 3:
                                TxtCmdPos3.Text = nCmd.ToString();
                                TxtFbkPos3.Text = nPos.ToString();
                                TxtIOStatus3.Text = String.Format("0x{0,4:X}", uStstus);
                                TxtSpeed3.Text = nSpeed.ToString();
                                TxtMotionDown3.Text = uMCDone.ToString();
                                TxtBuffer3.Text = uBuffer.ToString();
                                break;
                        }
                    }//for (int nAxis = 0; nAxis < nAxisNum; nAxis++ )
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
            }//if(g_nESCExistCards > 0)
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChkRealTimeUpdate.Enabled = false;
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
            LstErrMsg.SelectedIndex =  LstErrMsg.Items.Add(strMsg);

            if(bShowErr == true)
                MessageBox.Show(strMsg);
        }

        private void BtnChangeDist_Click(object sender, EventArgs e)
        {
            int nNewPos;
            string strMsg;
            nNewPos = Convert.ToInt32(TxtNewDist.Text);
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_TargetPos_Change(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], nNewPos);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                strMsg = "_ECAT_Slave_CSP_TargetPos_Change, ErrorCode = " + g_uRet.ToString();
                AddErrMsg(strMsg, true);
            }
        }

        private void BtnChangeVel_Click(object sender, EventArgs e)
        {
            int nNewSpd;
            double dNewTDec;

            nNewSpd = Convert.ToInt32(TxtNewVel.Text);
            dNewTDec = Convert.ToDouble(TxtNewDec.Text);

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Velocity_Change(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], nNewSpd, dNewTDec);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_CSP_Velocity_Change, rt = %d" + g_uRet.ToString(), true);
            }
        }

        private void ChkSetGear_CheckedChanged(object sender, EventArgs e)
        {
            short nNumerator, nDenominator, nEnable;

            nNumerator = Convert.ToInt16(TxtNumerator.Text);
            nDenominator = Convert.ToInt16(TxtDenominator.Text);
            nEnable = Convert.ToInt16(ChkRealTimeUpdate.Checked);

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Set_Gear(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], nNumerator, nDenominator, nEnable);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_CSP_Set_Gear, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void ChkSetLimit_CheckedChanged(object sender, EventArgs e)
        {
            ushort uEnable;
            int nMLimit, nPLimit;

            nMLimit = Convert.ToInt32(TxtMLimit.Text);
            nPLimit = Convert.ToInt32(TxtPLimit.Text);
            uEnable = Convert.ToUInt16(ChkSetLimit.Checked);

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Set_Softlimit(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], nMLimit, nPLimit, uEnable);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_CSP_Set_Softlimit, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void TrcFeedrate_Scroll(object sender, EventArgs e)
        {
            int nNewSpd;

            nNewSpd = TrcFeedrate.Value;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Feedrate_Overwrite(g_uESCCardNo, g_uESCNodeID[0], g_uESCSlotID[0], 2, nNewSpd, 0.1);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_CSP_Feedrate_Overwrite, ErrorCode = " + g_uRet.ToString(), true);
            }
            else
            {
                TxtFeedrate.Text = nNewSpd.ToString();
            }
        }
    }
}
