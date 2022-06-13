using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EtherCAT_DLL;
using EtherCAT_DLL_Err;

namespace EtherCat
{
    public partial class realstatus : Form
    {
        public realstatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public  int []mdd = new int[3];
        public  int []poss = new int [3];

        private void timer1_Tick(object sender, EventArgs e)
        {
            ushort RET;
            
            int[] md = new int[4];
            for (int i = 0; i < 4; i++)
                md[i] = 0;
            for(int j=0;j<4;j++)
                RET = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Command(0, Motor.Driver[j], Motor.motor[j], ref md[j]);
            COM1.Text = md[0].ToString();
            COM2.Text = md[1].ToString();
            COM3.Text = md[2].ToString();
            COM4.Text = md[3].ToString();
            mdd[0] = md[0];
            mdd[1] = md[1];
            mdd[2] = md[2];
            int[] pos= new int[4];
            for (int i = 0; i < 4; i++)
                pos[i] = 0;
            for(int j=0;j<4;j++)
                RET=CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(0, Motor.Driver[j], Motor.motor[j], ref pos[j]);
            FED1.Text = pos[0].ToString();
            FED2.Text = pos[1].ToString();
            FED3.Text = pos[2].ToString();
            FED4.Text = pos[3].ToString();
            poss[0] = pos[0];
            poss[1] = pos[1];
            poss[2] = pos[2];

            int[] speed = new int[4];
            for (int i = 0; i < 4; i++)
                speed[i] = 0;

            for(int j=0;j<4;j++)
                RET=CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Current_Speed(0, Motor.Driver[j], Motor.motor[j], ref speed[j]);

            SPD1.Text = speed[0].ToString();
            SPD2.Text = speed[1].ToString();
            SPD3.Text = speed[2].ToString();
            SPD4.Text = speed[3].ToString();


            ushort[] statusword = new ushort[4];
            for (int i = 0; i < 4; i++)
                statusword[i] = 0;

            for (int j=0;j<4;j++)
                RET= CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_StatusWord(0, Motor.Driver[j], Motor.motor[j], ref statusword[j]);
            MOT1.Text = statusword[0].ToString();
            MOT2.Text = statusword[1].ToString();
            MOT3.Text = statusword[2].ToString();
            MOT4.Text = statusword[3].ToString();

            byte[] umode = new byte[4];
            for (int i = 0; i < 4; i++)
                umode[i]= 0;

            for (int j=0;j<4; j++)
                RET= CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_MoveMode(0, Motor.Driver[j], Motor.motor[j], ref umode[j]);
            SW1.Text = umode[0].ToString();
            SW2.Text = umode[1].ToString();
            SW3.Text = umode[2].ToString();
            SW4.Text = umode[3].ToString();





        }

        public int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 1) {
                
            timer1.Enabled=true;
            button2.Text = "STOP";
        }
            else if (count % 2 == 0)
            {
                timer1.Enabled=false;
                button2.Text="run all";
            }


               
        }
    }
}
