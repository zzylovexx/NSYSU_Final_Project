using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EtherCAT_DLL;
using EtherCAT_DLL_Err;

namespace EtherCat
{
    public partial class SingleMotorCT : UserControl
    {
        public static string errormessage;
        ushort cspcheckvariable;
        public static  int  motorno=1;
        public static  ushort umortorno=1;
             
        
        
        public SingleMotorCT()
        {
            InitializeComponent();
            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            ushort[] slavearray = new ushort[3];
            int[] sudu = { 0, 0, 0, 0 };

            int[] motordegree = new int[3];
            double[] accerlaration = new double[1];
            double[] decelration = new double[1];
            decelration[0] = Convert.ToDouble(dccbox.Text);
            accerlaration[0] = Convert.ToDouble(accbox.Text);
            if (radioButton1.Checked == true)
                
            {
                //comboBox1.SelectedIndex = 0;
                sudu[0] = Convert.ToInt32(sudubox.Text);
                motordegree[0] = Convert.ToInt32(degree1.Text) * parameter.ratio;
                //motordegree[2] = Convert.ToInt32(degree2.Text) * ratio;
                //motordegree[3] = Convert.ToInt32(degree3.Text) * ratio;              

                cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(Form1.cardno, 1, ref Motor.Driver[umortorno], ref Motor.motor[motorno], ref motordegree[0], 0, sudu[0], 0, accerlaration[0], decelration[0], 0, 1);
            }
            else if (radioButton2.Checked == true)
            {
                int  maibo = Convert.ToInt32(degree1.Text) * parameter.ratio;
                sudu[0] = Convert.ToInt32(sudubox.Text);
                cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Move(Form1.cardno, Motor.Driver[motorno], Motor.motor[motorno], maibo, 0, sudu[0], 0,accerlaration[0], decelration[0],0,0);
            }

            /*
            Func<bool> checkdegree = () =>
            {
                if (Convert.ToInt32(degree1.Text) > 80 || (Convert.ToInt32(degree2.Text) > 80) || (Convert.ToInt32(degree3.Text) > 80))
                    return false;
                else
                    return true;
            }; //怕角度超過轉不了
            */
            //if (checkdegree() == true)  //要確認driver跟motor的陣列 x還沒輸入

            //cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(Form1.cardno, 3, ref Motor.Driver[0], ref Motor.motor[0], ref motordegree[1], 0, sudu[0], 0, accerlaration[0], decelration[0], 0, 1);

            //cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[0], Motor.motor[0], 4, 6, 1);
            
            //CS_ECAT_Slave_CSP_Start_Move  
            //else errormessage = "角度超過限制";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //讓馬達停止 最後一個參數不確定
            for (int x=0;x<4;x++)
            { 
                
                cspcheckvariable= CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[x], Motor.motor[x], 4, 6, 0);
                cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[x], Motor.motor[x], 0);
            }
            /*
             cspcheckvariable= CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[0], Motor.motor[0], 4, 6, 0);
             cspcheckvariable= CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[1], Motor.motor[1], 4, 6, 0);
             cspcheckvariable= CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[2], Motor.motor[2], 4, 6, 0);
             cspcheckvariable= CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[3], Motor.motor[3], 4, 6, 0);
             
            cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[0], Motor.motor[0], 0);
            cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[1], Motor.motor[1], 0);
            cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[2], Motor.motor[2], 0);
            cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[3], Motor.motor[3], 0);
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //打開馬達激磁
            cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno ,Motor.Driver[umortorno], Motor.motor[motorno], 4, 6, 1);
            cspcheckvariable = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[umortorno], Motor.motor[motorno], 1);
        }

        private void SingleMotorCT_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            motorno = comboBox1.SelectedIndex;
            
            umortorno = (ushort)comboBox1.SelectedIndex;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
