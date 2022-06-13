using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EtherCAT_DLL_Err;
using EtherCAT_DLL;

namespace EtherCat
{
    public partial class HPRPanel : UserControl
    {
        public HPRPanel()
        {
            InitializeComponent();
        }
        int type = 0;

        ushort Alejandro = 0;
        int k = 0;
        int j = 11;

        double timemer = 0.1;
        double vin = 0;
        double[,] arrayH = new double[2, 41];

        double[,] arrayR2 = new double[2, 41];
        double[,] arrayR3 = new double[2, 41];

        double[,] arrayP1 = new double[2, 41];
        double[,] arrayP23 = new double[2, 41];

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (type == 1)
            { 
                int count = 0;

                do
                {
                    if (j > 10)
                    {
                        arrayH[0, k] = vin;

                        vin += timemer;

                        //周期˙4s
                        arrayH[1, k] = -0.7039 * Math.Pow(arrayH[0, k], 5) + 6.7341 * Math.Pow(arrayH[0, k], 4) - 17.821 * Math.Pow(arrayH[0, k], 3) + 2.586 * Math.Pow(arrayH[0, k], 2) + 23.98 * Math.Pow(arrayH[0, k], 1) + 49.841;

                        //切100點  --  42.36 ~ 58.51 Heave  -->   y = -0.0044x5 + 0.1076x4 - 0.7359x3 + 0.4903x2 + 5.3274x + 49.721

                        // arrayH[1, k] = -0.0044 * Math.Pow(arrayH[0, k], 5) + 0.1076 * Math.Pow(arrayH[0, k], 4) - 0.7359 * Math.Pow(arrayH[0, k], 3) + 0.4903 * Math.Pow(arrayH[0, k], 2) + 5.3274 * Math.Pow(arrayH[0, k], 1) + 49.721;

                        textBox1.Text = arrayH[1, k].ToString();

                        k++;
                        if (k > 39)
                        {
                            j = 4;
                        }
                    }
                    else if (j < 5)
                    {
                        k = 0;
                        vin = 0;
                        j = 11;
                    }
                    count++;
                } while (count > 10000);
                //===========================
                int[] maibuo = { 0, 0, 0 };   //脈波

                int sudu = 0;

                double jiasu = 0, jiensu = 0;  //加減速     

                double lexie = Math.Truncate(Convert.ToDouble(textBox1.Text));   //

                maibuo[0] = (-50 + (90 - Convert.ToInt32(lexie))) * parameter.ratio;

                maibuo[1] = (-50 + (90 - Convert.ToInt32(lexie))) * parameter.ratio;

                maibuo[2] = (-50 + (90 - Convert.ToInt32(lexie))) * parameter.ratio;

                Alejandro = (ushort)CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR;

                sudu = Convert.ToInt32(100000);

                jiasu = Convert.ToDouble(1);

                jiensu = Convert.ToDouble(1);

                Alejandro = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(Form1.cardno, 3, ref Motor.Driver[0], ref Motor.motor[0], ref maibuo[0], 0, sudu, 0, jiasu, jiensu, 2, 1);

                if (Alejandro != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                }

            }
            else if (type == 2)
            {
                int count = 0;

                do
                {
                    if (j > 10)
                    {
                        arrayP1[0, k] = vin;
                        arrayP23[0, k] = vin;

                        vin += timemer;

                        //切100點
                        //arrayP1[1, k] = -0.005 * Math.Pow(arrayP1[0, k], 5) + 0.1224 * Math.Pow(arrayP1[0, k], 4) - 0.8426 * Math.Pow(arrayP1[0, k], 3) + 0.6105 * Math.Pow(arrayP1[0, k], 2) + 5.9127 * Math.Pow(arrayP1[0, k], 1) + 49.723;
                        //arrayP23[1, k] = 0.0025 * Math.Pow(arrayP23[0, k], 5) - 0.0625 * Math.Pow(arrayP23[0, k], 4) + 0.4589 * Math.Pow(arrayP23[0, k], 3) - 0.5858 * Math.Pow(arrayP23[0, k], 2) - 2.2479 * Math.Pow(arrayP23[0, k], 1) + 49.775;

                        //切40點
                        arrayP1[1, k] = -0.7498 * Math.Pow(arrayP1[0, k], 5) + 7.2262 * Math.Pow(arrayP1[0, k], 4) - 19.41 * Math.Pow(arrayP1[0, k], 3) + 3.8852 * Math.Pow(arrayP1[0, k], 2) + 24.488 * Math.Pow(arrayP1[0, k], 1) + 49.887;
                        arrayP23[1, k] = 0.3596 * Math.Pow(arrayP23[0, k], 5) - 3.6553 * Math.Pow(arrayP23[0, k], 4) + 10.809 * Math.Pow(arrayP23[0, k], 3) - 5.7022 * Math.Pow(arrayP23[0, k], 2) - 8.2166 * Math.Pow(arrayP23[0, k], 1) + 50.192;


                        textBox1.Text = arrayP1[1, k].ToString();

                        textBox2.Text = arrayP23[1, k].ToString();

                        textBox3.Text = arrayP23[1, k].ToString();

                        k++;

                        if (k > 39)
                        {
                            j = 4;
                        }

                    }
                    else if (j < 5)
                    {
                        k = 0;
                        vin = 0;
                        j = 11;
                    }
                    count++;
                } while (count > 10000);
                //================================
                int[] maibuo = { 0, 0, 0 };

                int sudu = 0;

                double jiasu = 0, jiensu = 0;  //加減速     

                double Bossin1 = Math.Truncate(Convert.ToDouble(textBox1.Text));


                double Bossin2 = Math.Truncate(Convert.ToDouble(textBox2.Text));//這邊原始碼是textbox1=2
                double Bossin3 = Math.Truncate(Convert.ToDouble(textBox3.Text));

                maibuo[0] = (-55 + (90 - Convert.ToInt32(Bossin1))) * parameter.ratio;

                maibuo[1] = (-55 + (90 - Convert.ToInt32(Bossin2))) * parameter.ratio;

                maibuo[2] = (-55 + (90 - Convert.ToInt32(Bossin3))) * parameter.ratio;

                Alejandro = (ushort)CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR;

                sudu = Convert.ToInt32(100000);

                jiasu = Convert.ToDouble(1);

                jiensu = Convert.ToDouble(1);

                Alejandro = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(Form1.cardno, 3, ref Motor.Driver[0], ref Motor.motor[0], ref maibuo[0], 0, sudu, 0, jiasu, jiensu, 2, 1);

                if (Alejandro != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {
                }
            }
            else if (type == 3)
            {
                int count = 0;

                do
                {
                    if (j > 10)
                    {
                        arrayR2[0, k] = vin;

                        arrayR3[0, k] = vin;

                        vin += timemer;
                        //切100點
                        //arrayR2[1, k] = 0.0000000000002 * Math.Pow(arrayR3[0, k], 5) - 0.0293 * Math.Pow(arrayR3[0, k], 4) + 0.5863 * Math.Pow(arrayR3[0, k], 3) - 3.0471 * Math.Pow(arrayR2[0, k], 2) + 1.154 * Math.Pow(arrayR2[0, k], 1) + 57.938;

                        //arrayR3[1, k] = -0.0000000000001 * Math.Pow(arrayR3[0, k], 5) + 0.0338 * Math.Pow(arrayR2[0, k], 4) - 0.6761 * Math.Pow(arrayR2[0, k], 3) + 3.632 * Math.Pow(arrayR2[0, k], 2) - 2.5165 * Math.Pow(arrayR2[0, k], 1) + 43.006;

                        //切40點
                        arrayR2[1, k] = -0.00000000003 * Math.Pow(arrayR3[0, k], 5) + 2.0329 * Math.Pow(arrayR3[0, k], 4) - 16.263 * Math.Pow(arrayR3[0, k], 3) + 35.04 * Math.Pow(arrayR2[0, k], 2) + -10.051 * Math.Pow(arrayR2[0, k], 1) + 40.156;

                        arrayR3[1, k] = 0.00000000004 * Math.Pow(arrayR3[0, k], 5) + -1.6322 * Math.Pow(arrayR2[0, k], 4) + 13.058 * Math.Pow(arrayR2[0, k], 3) - 26.695 * Math.Pow(arrayR2[0, k], 2) + 2.3167 * Math.Pow(arrayR2[0, k], 1) + 63.217;


                        textBox1.Text = Convert.ToString(49.887);

                        textBox2.Text = arrayR2[1, k].ToString();

                        textBox3.Text = arrayR3[1, k].ToString();

                        k++;
                        if (k > 39)
                        {
                            j = 4;
                        }

                    }
                    else if (j < 5)
                    {
                        k = 0;
                        vin = 0;
                        j = 11;
                    }
                    count++;
                } while (count > 10000);
                int[] maibuo = { 0, 0, 0 };

                int sudu = 0;

                double jiasu = 0, jiensu = 0;  //加減速     

                double ErChole1 = Math.Truncate(Convert.ToDouble(textBox1.Text));

                double ErChole2 = Math.Truncate(Convert.ToDouble(textBox2.Text));

                double ErChole3 = Math.Truncate(Convert.ToDouble(textBox3.Text));
                //    上三角度 轉換為 下三 脈波數    
                maibuo[0] = (-50 + (90 - Convert.ToInt32(ErChole1))) * parameter.ratio;

                maibuo[1] = (-50 + (90 - Convert.ToInt32(ErChole2))) * parameter.ratio;

                maibuo[2] = (-50 + (90 - Convert.ToInt32(ErChole3))) * parameter.ratio;

                Alejandro = (ushort)CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR;

                sudu = Convert.ToInt32(100000);

                jiasu = Convert.ToDouble(1);

                jiensu = Convert.ToDouble(1);

                Alejandro = CEtherCAT_DLL.CS_ECAT_Slave_CSP_Start_Multiaxes_Move(Form1.cardno, 3, ref Motor.Driver[0], ref Motor.motor[0], ref maibuo[0], 0, sudu, 0, jiasu, jiensu, 2, 1);

                if (Alejandro != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                {

                }
            }
            else { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type = 1;  // heave  //按下去就會依直往復上下動
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            type = 2;   //pitch
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            type = 3;   //roll
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dTdec;

            dTdec = Convert.ToDouble(1);  //減速度

            Alejandro = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(Form1.cardno , Motor.Driver[0],Motor.motor[0], dTdec);
            Alejandro = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(Form1.cardno, Motor.Driver[1], Motor.motor[1], dTdec);
            Alejandro = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(Form1.cardno, Motor.Driver[2], Motor.motor[2], dTdec);
            Alejandro = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Sd_Stop(Form1.cardno, Motor.Driver[3], Motor.motor[3], dTdec);
            timer1.Stop();
        }

        private void HPRPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ushort status;
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[0], Motor.motor[0], 4, 6, 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[1], Motor.motor[1], 4, 6, 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[2], Motor.motor[2], 4, 6, 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_DeltaServo_Write_Parameter(Form1.cardno, Motor.Driver[3], Motor.motor[3], 4, 6, 1);

            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[0], Motor.motor[0], 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[1], Motor.motor[1], 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[2], Motor.motor[2], 1);
            status = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Set_Svon(Form1.cardno, Motor.Driver[3], Motor.motor[3], 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ushort status;
            
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
    }
}
