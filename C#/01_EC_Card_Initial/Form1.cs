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
        ushort g_nESCExistCards = 0, g_uESCCardNo = 99;
        ushort[] g_uESCCardNoList = new ushort[32];
        bool     g_bInitialFlag = false;
        ushort    g_uRet = 0;

        public Form1()
        {
            InitializeComponent();
            // Set the Interval to 0.1 seconds (100 milliseconds).
            TimCheckStatus.Interval = 100;
            TimCheckStatus.Enabled = true;
        }

        private void BtnOpenCard_Click(object sender, EventArgs e)
        {
            g_uRet = 0;
            g_bInitialFlag = false;
            //CS_ECAT_Master_Open 偵測 EtherCAT軸卡數量，並建立EtherCAT 主站的記憶體區塊
            
            g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Open(ref g_nESCExistCards);

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR) //假如出錯的話
            {
                MessageBox.Show("CS_ECAT_Master_Open, rt =" + g_uRet.ToString());
            }
            else
            {
                if (g_nESCExistCards == 0) //代表偵測軸卡數量為0
                {
                    MessageBox.Show("No EtherCat can be found!");
                }
                else
                {
                    TxtCardNum.Text = g_nESCExistCards.ToString();//在lable顯示軸卡數量
                    BtnInitialCard.Enabled = true;//啟用initial按鈕
                }
            }
        }

        private void BtnInitialCard_Click(object sender, EventArgs e)
        {
            ushort nSeq = 0, nCardNo = 0;

            g_uRet = 0;
            for (nSeq = 0; nSeq < 32; nSeq++)//將g_uesccardnolist的值都變為0裡面有32組
            {
                g_uESCCardNoList[nSeq] = 0;
            }
            CmbCardNo.Items.Clear();//把card no裡的數值清掉
            g_bInitialFlag = false;
            for (nSeq = 0; nSeq < g_nESCExistCards; nSeq++)//將每個軸卡初始化
            {
                g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_CardSeq(nSeq, ref nCardNo);//取得第nSeq張的介面卡號 詢問ethercat主站的卡號
                g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Initial(nCardNo);//將其初始化
                if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                    MessageBox.Show("_ECAT_Master_Initial, ErrorCode = " + g_uRet.ToString());
                    g_uESCCardNoList[nSeq] = 99; //99好像是初始化失敗
                }
                else
                {
                    CmbCardNo.Items.Add(nCardNo);  //增加集合中的字串數值為ncardNo
                    g_bInitialFlag = true;
                    g_uESCCardNoList[nSeq] = nCardNo;
                }
            }
            CmbCardNo.SelectedIndex = 0; //看不懂
            g_uESCCardNo = Convert.ToUInt16(CmbCardNo.Text); //初始化的卡數存回去
            if (g_bInitialFlag)
            {
                CmbCardNo.Enabled = true; //啟用card numberlable
            }
        }

        private void BtnFindSlave_Click(object sender, EventArgs e)
        {
            ushort uSlaveNum = 0; //主站上找到的slavenum數

            g_uESCCardNo = Convert.ToUInt16(CmbCardNo.Text); //把initial的卡號轉乘ushort存入

            TxtSlaveNum.Text = ""; 

            g_uRet = CEtherCAT_DLL.CS_ECAT_Master_Get_SlaveNum(g_uESCCardNo, ref uSlaveNum); //顯示找到的slave於slave num欄位

            if (g_uRet != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                MessageBox.Show("_ECAT_Master_Get_SlaveNum, ErrorCode = " + g_uRet.ToString());//止從站錯誤顯示錯誤
            }
            else
            {
                if (uSlaveNum == 0)
                {
                    MessageBox.Show("Card NO: " + g_uESCCardNo.ToString() + " No slave found!");//代表地n張軸卡上找不到連接的只從站數量
                }
                else
                {
                    TxtSlaveNum.Text = uSlaveNum.ToString();//顯示止從站數量
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)//按離開離開
        {
            Application.Exit();
        }

        private void TimCheckStatus_Tick(object sender, EventArgs e)
        {
            ushort uInitialDone = 0;
            ushort uRet = 0;
            if (g_uESCCardNo != 99) //假設Innitial成功
            {
                uRet = CEtherCAT_DLL.CS_ECAT_Master_Check_Initial_Done(g_uESCCardNo, ref uInitialDone); //取得ethercat目前的初始化狀態
                if (uRet == 0)
                {
                    if (uInitialDone == 0)
                    {
                        TxtInitialStatus.Text = "Initial Done"; //顯示其初始化狀態為已完成
                        if (BtnFindSlave.Enabled == false)
                        {
                            BtnFindSlave.Text = "1-2. Find Slave"; //將not initial 啟用並顯示找slave
                            BtnFindSlave.Enabled = true;
                        }
                    }
                    else if (uInitialDone == 1)
                    {
                        BtnFindSlave.Text = "Wait Initial"; // 在not initial 顯示等待
                        TxtInitialStatus.Text = "Pre Initial";
                    }
                    else if (uInitialDone == 99) //99代表發生錯誤
                        
                    {
                        BtnFindSlave.Text = "Initial Fail";
                        TxtInitialStatus.Text = "Initial Error";
                    }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (g_nESCExistCards > 0)
            {
                for (int nSeq = 0; nSeq < 32; nSeq++)
                {
                    if (g_uESCCardNoList[nSeq] == 99) continue;
                    CEtherCAT_DLL.CS_ECAT_Master_Reset(g_uESCCardNoList[nSeq]);
                }
                CEtherCAT_DLL.CS_ECAT_Master_Close();
            }
        }
    }
}
