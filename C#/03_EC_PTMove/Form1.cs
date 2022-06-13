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
            TimCheckStatus.Interval = 100;   //每100毫秒更新一次
            TimCheckStatus.Enabled = true;

            CmbRunMode.SelectedIndex = 0;
        }

        private void BtnInitialCard_Click(object sender, EventArgs e)
        {   
            ushort uCount = 0, uCardNo = 0;
            g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Open(ref g_nESCExistCards);  //將EtherCAT 核心數量或是軸卡數量存進g_ESCExistCards
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
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_CardSeq(uCount, ref uCardNo); //取得卡號
                    g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Initial(uCardNo);//將其初始化
                    if (g_uRet != 0) // 0應該是狀態好
                    {
                        AddErrMsg("_ECAT_Master_Initial, ErrorCode = " + g_uRet.ToString(), true);
                    }
                    else
                    {
                        g_uESCCardNoList[uCount] = uCardNo; //從0開始將卡號添加到一個 array裡
                        CmbCardNo.Items.Add(uCardNo.ToString());//將卡號存在一個cardno.list裡
                        g_bInitialFlag = true;
                    }
                }

                if (g_bInitialFlag == true)
                {
                    CmbCardNo.SelectedIndex = 0;
                    g_uESCCardNo = g_uESCCardNoList[0];//將第一個卡存到變數裡(應是假設只有一張卡)
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
            g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_SlaveNum(g_uESCCardNo, ref uSlaveNum); //尋找第一章軸卡上連接的只從站數目

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Master_Get_SlaveNum, ErrorCode = " + g_uRet.ToString(), true); //增加一串錯誤訊息 顯示錯誤狀態
            }
            else
            {
                if (uSlaveNum == 0)
                {
                    AddErrMsg("Card NO: " + g_uESCCardNo.ToString() + " No slave found!", true);  //找不到止從站
                }
                else //找到止從站,進行止從站的設定如下
                {
                    CmbNode.Items.Clear();
                    CmbNodeID.Items.Clear();
                    CmbSlotID.Items.Clear();
                    TxtSlaveNum.Text = uSlaveNum.ToString(); //將找到的止從站數存到此box裡
                    for (uNID = 0; uNID < uSlaveNum; uNID++)
                    {
                        g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_Slave_Info(g_uESCCardNo, uNID, ref uReMapNodeID, ref uVendorID, ref uProductCode, ref uRevisionNo, ref uSlaveDCTime);
                        //取得指定止從站資訊 UID不知道是幹嘛的
                        if (uVendorID == 0x1DD && uProductCode == 0x10305070) // A2E
                        {
                            nSID = 0; //nsid不知道是幹嘛的應該是幫止從站作編號
                            CmbNode.Items.Add("NodeID:"+uNID+" - SlotID:"+nSID + "-A2E");
                            CmbNodeID.Items.Add(uNID.ToString());  // 將模組物理id加進去
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
                                CmbNode.Items.Add("NodeID:" + uNID + " - SlotID:" + nSID + "-Ec4Axis");
                                CmbNodeID.Items.Add(uNID.ToString());
                                CmbSlotID.Items.Add(nSID.ToString());
                                Cnt++;
                            }
                        }
                        else if ((uVendorID == 0x1A05 || uVendorID == 0x1DD) && uProductCode == 0x5621) //EcAxis
                        {
                            nSID = 0;
                            CmbNode.Items.Add("NodeID:" + uNID + " - SlotID:" + nSID + "-EcAxis");
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
                        BtnResetStatus.Enabled = true; // 將止從站選項打開
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
                g_uESCNodeID = Convert.ToUInt16(strNodeID); // 將止從站主編號存進去

            strSlotID = CmbSlotID.Text;
            if (strSlotID.Length > 0)
                g_uESCSlotID = Convert.ToUInt16(strSlotID);  //將止從站子編號存進去
        }

        private void CmbCardNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCardNo;
            strCardNo = CmbCardNo.Text;
            if (strCardNo.Length > 0)
                g_uESCCardNo = Convert.ToUInt16(strCardNo); //將卡號存進去
        }

        private void TimCheckStatus_Tick(object sender, EventArgs e)
        {
            ushort uInitialDone = 0, uRet = 0;
            ushort uMCDone = 0, uStstus = 0;
            int nCmd = 0, nPos = 0;
            if (g_nESCExistCards > 0)
            {
                if (ChkRealTimeUpdate.Checked == true)                    //主站編號  //從站編號    //從站子編號  //取得當前運動命令資料
                {
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Command(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref nCmd); 
                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("ECAT_Slave_Motion_Get_Command Fail, Error Code :" + uRet.ToString());
                        ChkRealTimeUpdate.Checked = false;
                        return;
                    }
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref nPos);  //取得當前從站位置資料 不知道是從站子資料??

                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("ECAT_Slave_Motion_Get_Position Fail, Error Code :" + uRet.ToString());
                        ChkRealTimeUpdate.Checked = false;
                        return;
                    }
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_StatusWord(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref uStstus); //取得指定軸當前的狀態字元
                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("ECAT_Slave_Motion_Get_StatusWord Fail, Error Code :" + uRet.ToString());
                        ChkRealTimeUpdate.Checked = false;
                        return;
                    }
                    uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Mdone(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, ref uMCDone);  //取得指定軸當前的運動狀態 (Motion Done) 資料
                    if (uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                    {
                        AddErrMsg("ECAT_Slave_Motion_Get_Mdone Fail, Error Code :" + uRet.ToString());
                        ChkRealTimeUpdate.Checked = false;
                        return;
                    }
                    TxtCmdPos.Text = nCmd.ToString(); //將當前運動命令資料顯示
                    TxtFbkPos.Text = nPos.ToString(); //將當前從站位置資料顯示
                    TxtIOStatus.Text = String.Format("0x{0,8:X}", uStstus); //一種呈現方式
                    TxtMotionDown.Text = uMCDone.ToString(); //將當前狀態資料存入
                }

                uRet = CEtherCAT_DLL.CS_ECAT_Master_Check_Initial_Done(g_uESCCardNo, ref uInitialDone); //確認initial 的狀態
                if (uRet == 0)
                {
                    if (uInitialDone == 0) //已完成
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

        private void RdoSVON_CheckedChanged(object sender, EventArgs e)
        {            
            ushort uCheckOnOff = 0;//馬達激停
            if (RdoSVON.Checked == true) // 不知道這個checked是幹嘛
                uCheckOnOff = 1; //馬達停止
                                    //設定指定軸的伺服馬達激磁或停止
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, uCheckOnOff);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_Motion_Set_Svon, Error Code = "+ g_uRet.ToString(), true);
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Emg_Stop(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID); 
            //緊急停止指定軸當前的馬達運動，馬達會以最大的減速能力停止運動。


            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_Motion_Sd_Stop, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void BtnResetAlarm_Click(object sender, EventArgs e)
        {   //清除指定軸當前的警報狀態
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Ralm(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_Motion_Ralm, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void BtnResetStatus_Click(object sender, EventArgs e)
        {
            //設定指定軸當前的回授位置為零 最後一個為設定當前回逤位置
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Position(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, 0);
            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_Motion_Set_Position, ErrorCode = " + g_uRet.ToString(), true);
            }
            //設定指定軸當前的運動命令資料歸零 //零不知道是設定數度還是位置我猜是位置
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

        private void BtnMoveLeft_Click(object sender, EventArgs e) //
        {
            AxisMove(0);
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            AxisMove(1);
        }

        private void CmbNode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int nSelectNode = 0;
            nSelectNode = CmbNode.SelectedIndex;
            CmbNodeID.SelectedIndex = nSelectNode;// SELECTED INDEX不確定是神摸
            CmbSlotID.SelectedIndex = nSelectNode;
            string strNodeID, strSlotID;
            strNodeID = CmbNodeID.Text;
            if (strNodeID.Length > 0)
                g_uESCNodeID = Convert.ToUInt16(strNodeID);

            strSlotID = CmbSlotID.Text;
            if (strSlotID.Length > 0)
                g_uESCSlotID = Convert.ToUInt16(strSlotID);
        }

        private void AxisMove(int nDir)
        {
            short nTorque = 0, Torque_Profile = 0;
            uint uSlope = 0;
            ushort SetBit = 0x02; // Bit 0->Max_Current, Bit 1 → Troque_Profile
            ushort Max_Current = 0;

            uSlope = Convert.ToUInt32(TxtSlope.Text); //轉矩的上升斜率單位為每秒上升
            nTorque = Convert.ToInt16(TxtTorque.Text);  //扭力 為轉矩輸出值
            Torque_Profile = Convert.ToInt16(CmbRunMode.SelectedIndex); // 0: 線性變化, 1: Sin波變化

            uSlope = (uSlope > 1000) ? 1000 : uSlope;   //設輸入如果超過1000則把它設為1000
            nTorque = (nTorque > 1000) ? (short)1000 : nTorque;

            if(nDir == 0) //press left bottum
                nTorque = (short)(0 - nTorque);                                                              //以bit形式決定下面參數是否生效
                                                                                                             //max current 最大轉舉輸出值
                                                                                                         //Torque profile轉舉輸出方式前面設線性變化
                                            //PT模式進階設定                                                                 //這個要再問一下

            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_PT_Advance_Config(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, SetBit, Max_Current, Torque_Profile);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("CS_ECAT_Slave_PT_Advance_Config, ErrorCode = " + g_uRet.ToString(), true);
            }
            //PT模式的單軸定扭力運動                                                                     //轉矩輸出值 //轉矩上升斜率
            g_uRet = CEtherCAT_DLL.CS_ECAT_Slave_PT_Start_Move(g_uESCCardNo, g_uESCNodeID, g_uESCSlotID, nTorque, uSlope);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                AddErrMsg("_ECAT_Slave_Torque_Start_Move, ErrorCode = " + g_uRet.ToString(), true);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //關閉時執行
        {
            ChkRealTimeUpdate.Enabled = false; 
            if (g_nESCExistCards > 0)
            {
                for (int i = 0; i < g_nESCExistCards; i++)
                {
                    if (g_uESCCardNoList[i] != 99)
                        CEtherCAT_DLL.CS_ECAT_Master_Reset(g_uESCCardNoList[i]); //將軸卡重置
                }
                CEtherCAT_DLL.CS_ECAT_Master_Close();  //將軸卡關掉
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
