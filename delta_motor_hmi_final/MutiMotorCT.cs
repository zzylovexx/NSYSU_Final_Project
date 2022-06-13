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
    public partial class MutiMotorCT : UserControl
    {
        ushort check = 0;
        ushort status;
        public MutiMotorCT()
        {
            InitializeComponent();
            motor1.Text = motor2.Text = motor3.Text = numericUpDown1.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[0], Motor.motor[0], 4, 6, 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[1], Motor.motor[1], 4, 6, 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[2], Motor.motor[2], 4, 6, 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[3], Motor.motor[3], 4, 6, 1);

            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[0], Motor.motor[0], 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[1], Motor.motor[1], 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[2], Motor.motor[2], 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[3], Motor.motor[3], 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check = 0;
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[0], Motor.motor[0], 4, 6, 0);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[1], Motor.motor[1], 4, 6, 0);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[2], Motor.motor[2], 4, 6, 0);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[3], Motor.motor[3], 4, 6, 0);
            /*
            for (int i = 0; i < 3; i++)
            {
                status=CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[i], Motor.motor[i], check);
            }*/

            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[0], Motor.motor[0], 0);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[1], Motor.motor[1], 0);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[2], Motor.motor[2], 0);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[3], Motor.motor[3], 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sudu = { 0, 0, 0, 0 };
            int[] motordegree = new int[4];
            double  [] accerleration  = new double[1];
            double  [] deceleration = new double[1];

            
            sudu[0] = Convert.ToInt32(textBox6.Text);
            motordegree[0] = Convert.ToInt32(motor1.Text)*parameter.ratio;

            motordegree[1] = Convert.ToInt32(motor2.Text)*parameter.ratio;
            motordegree[2] = Convert.ToInt32(motor3.Text) * parameter.ratio;
            motordegree[3] = Convert.ToInt32(centermotor.Text)*parameter.ratio;

            accerleration[0] = Convert.ToDouble(textBox1.Text);
            deceleration[0] = Convert.ToDouble(textBox3.Text);

            status = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(Form1.cardno, 3, ref Motor.Driver[0],ref  Motor.motor[0],ref  motordegree[0], 0, sudu[0], 0, accerleration[0], deceleration[0], 0, 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(Form1.cardno, 1, ref Motor.Driver[3], ref Motor.motor[3], ref motordegree[3], 0, sudu[0], 0, accerleration[0], deceleration[0], 0, 1);
            //driver and mortor [0]-[2]為三軸  [3]為中央軸    


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            motor1.Text = motor2.Text = motor3.Text =  numericUpDown1.Value.ToString();
        }
    }
}
