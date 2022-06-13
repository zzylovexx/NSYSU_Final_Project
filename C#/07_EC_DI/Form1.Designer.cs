namespace EtherCat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnInitialCard = new System.Windows.Forms.Button();
            this.LabCardNo = new System.Windows.Forms.Label();
            this.CmbCardNo = new System.Windows.Forms.ComboBox();
            this.LabInitialStatus = new System.Windows.Forms.Label();
            this.TxtInitialStatus = new System.Windows.Forms.TextBox();
            this.BtnFindSlave = new System.Windows.Forms.Button();
            this.LabSlaveNum = new System.Windows.Forms.Label();
            this.TxtSlaveNum = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpInitial = new System.Windows.Forms.GroupBox();
            this.ChkRealTimeUpdate = new System.Windows.Forms.CheckBox();
            this.CmbSlotID = new System.Windows.Forms.ComboBox();
            this.CmbNodeID = new System.Windows.Forms.ComboBox();
            this.LabSlotID = new System.Windows.Forms.Label();
            this.LabNodeID = new System.Windows.Forms.Label();
            this.GrpSetNode = new System.Windows.Forms.GroupBox();
            this.CmbNode = new System.Windows.Forms.ComboBox();
            this.LabNode = new System.Windows.Forms.Label();
            this.GrpErrorMsg = new System.Windows.Forms.GroupBox();
            this.LstErrMsg = new System.Windows.Forms.ListBox();
            this.TimCheckStatus = new System.Windows.Forms.Timer(this.components);
            this.GrpDIStatus = new System.Windows.Forms.GroupBox();
            this.LabBit15 = new System.Windows.Forms.Label();
            this.LabBit14 = new System.Windows.Forms.Label();
            this.LabBit13 = new System.Windows.Forms.Label();
            this.LabBit12 = new System.Windows.Forms.Label();
            this.LabBit11 = new System.Windows.Forms.Label();
            this.LabBit10 = new System.Windows.Forms.Label();
            this.LabBit09 = new System.Windows.Forms.Label();
            this.LabBit08 = new System.Windows.Forms.Label();
            this.LabBit07 = new System.Windows.Forms.Label();
            this.LabBit06 = new System.Windows.Forms.Label();
            this.LabBit05 = new System.Windows.Forms.Label();
            this.LabBit04 = new System.Windows.Forms.Label();
            this.LabBit03 = new System.Windows.Forms.Label();
            this.LabBit02 = new System.Windows.Forms.Label();
            this.LabBit01 = new System.Windows.Forms.Label();
            this.LabBit00 = new System.Windows.Forms.Label();
            this.GrpOutput = new System.Windows.Forms.GroupBox();
            this.BtnSendOutput = new System.Windows.Forms.Button();
            this.TxtOutputValue = new System.Windows.Forms.TextBox();
            this.LabValue = new System.Windows.Forms.Label();
            this.GrpInitial.SuspendLayout();
            this.GrpSetNode.SuspendLayout();
            this.GrpErrorMsg.SuspendLayout();
            this.GrpDIStatus.SuspendLayout();
            this.GrpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInitialCard
            // 
            this.BtnInitialCard.Location = new System.Drawing.Point(6, 22);
            this.BtnInitialCard.Name = "BtnInitialCard";
            this.BtnInitialCard.Size = new System.Drawing.Size(106, 33);
            this.BtnInitialCard.TabIndex = 0;
            this.BtnInitialCard.Text = "1-1. Initial Card";
            this.BtnInitialCard.UseVisualStyleBackColor = true;
            this.BtnInitialCard.Click += new System.EventHandler(this.BtnInitialCard_Click);
            // 
            // LabCardNo
            // 
            this.LabCardNo.AutoSize = true;
            this.LabCardNo.Location = new System.Drawing.Point(129, 31);
            this.LabCardNo.Name = "LabCardNo";
            this.LabCardNo.Size = new System.Drawing.Size(54, 13);
            this.LabCardNo.TabIndex = 1;
            this.LabCardNo.Text = "Card No :";
            // 
            // CmbCardNo
            // 
            this.CmbCardNo.FormattingEnabled = true;
            this.CmbCardNo.Location = new System.Drawing.Point(186, 28);
            this.CmbCardNo.Name = "CmbCardNo";
            this.CmbCardNo.Size = new System.Drawing.Size(88, 21);
            this.CmbCardNo.TabIndex = 2;
            this.CmbCardNo.SelectedIndexChanged += new System.EventHandler(this.CmbCardNo_SelectedIndexChanged);
            // 
            // LabInitialStatus
            // 
            this.LabInitialStatus.AutoSize = true;
            this.LabInitialStatus.Location = new System.Drawing.Point(287, 33);
            this.LabInitialStatus.Name = "LabInitialStatus";
            this.LabInitialStatus.Size = new System.Drawing.Size(72, 13);
            this.LabInitialStatus.TabIndex = 3;
            this.LabInitialStatus.Text = "Initial Status :";
            // 
            // TxtInitialStatus
            // 
            this.TxtInitialStatus.Location = new System.Drawing.Point(365, 28);
            this.TxtInitialStatus.Name = "TxtInitialStatus";
            this.TxtInitialStatus.ReadOnly = true;
            this.TxtInitialStatus.Size = new System.Drawing.Size(199, 23);
            this.TxtInitialStatus.TabIndex = 4;
            // 
            // BtnFindSlave
            // 
            this.BtnFindSlave.Enabled = false;
            this.BtnFindSlave.Location = new System.Drawing.Point(6, 61);
            this.BtnFindSlave.Name = "BtnFindSlave";
            this.BtnFindSlave.Size = new System.Drawing.Size(106, 33);
            this.BtnFindSlave.TabIndex = 5;
            this.BtnFindSlave.Text = "1-2. Find Slave";
            this.BtnFindSlave.UseVisualStyleBackColor = true;
            this.BtnFindSlave.Click += new System.EventHandler(this.BtnFindSlave_Click);
            // 
            // LabSlaveNum
            // 
            this.LabSlaveNum.AutoSize = true;
            this.LabSlaveNum.Location = new System.Drawing.Point(116, 71);
            this.LabSlaveNum.Name = "LabSlaveNum";
            this.LabSlaveNum.Size = new System.Drawing.Size(67, 13);
            this.LabSlaveNum.TabIndex = 6;
            this.LabSlaveNum.Text = "Slave Num :";
            // 
            // TxtSlaveNum
            // 
            this.TxtSlaveNum.Location = new System.Drawing.Point(186, 67);
            this.TxtSlaveNum.Name = "TxtSlaveNum";
            this.TxtSlaveNum.ReadOnly = true;
            this.TxtSlaveNum.Size = new System.Drawing.Size(88, 23);
            this.TxtSlaveNum.TabIndex = 7;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(234, 373);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(146, 53);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GrpInitial
            // 
            this.GrpInitial.Controls.Add(this.ChkRealTimeUpdate);
            this.GrpInitial.Controls.Add(this.BtnInitialCard);
            this.GrpInitial.Controls.Add(this.LabCardNo);
            this.GrpInitial.Controls.Add(this.TxtSlaveNum);
            this.GrpInitial.Controls.Add(this.CmbCardNo);
            this.GrpInitial.Controls.Add(this.LabSlaveNum);
            this.GrpInitial.Controls.Add(this.LabInitialStatus);
            this.GrpInitial.Controls.Add(this.BtnFindSlave);
            this.GrpInitial.Controls.Add(this.TxtInitialStatus);
            this.GrpInitial.Location = new System.Drawing.Point(12, 12);
            this.GrpInitial.Name = "GrpInitial";
            this.GrpInitial.Size = new System.Drawing.Size(568, 104);
            this.GrpInitial.TabIndex = 9;
            this.GrpInitial.TabStop = false;
            this.GrpInitial.Text = "1. Initial";
            // 
            // ChkRealTimeUpdate
            // 
            this.ChkRealTimeUpdate.Location = new System.Drawing.Point(290, 71);
            this.ChkRealTimeUpdate.Name = "ChkRealTimeUpdate";
            this.ChkRealTimeUpdate.Size = new System.Drawing.Size(112, 17);
            this.ChkRealTimeUpdate.TabIndex = 8;
            this.ChkRealTimeUpdate.Text = "Real Time Update";
            this.ChkRealTimeUpdate.UseVisualStyleBackColor = true;
            // 
            // CmbSlotID
            // 
            this.CmbSlotID.Enabled = false;
            this.CmbSlotID.FormattingEnabled = true;
            this.CmbSlotID.Location = new System.Drawing.Point(180, 16);
            this.CmbSlotID.Name = "CmbSlotID";
            this.CmbSlotID.Size = new System.Drawing.Size(60, 21);
            this.CmbSlotID.TabIndex = 12;
            this.CmbSlotID.Visible = false;
            // 
            // CmbNodeID
            // 
            this.CmbNodeID.Enabled = false;
            this.CmbNodeID.FormattingEnabled = true;
            this.CmbNodeID.Location = new System.Drawing.Point(63, 15);
            this.CmbNodeID.Name = "CmbNodeID";
            this.CmbNodeID.Size = new System.Drawing.Size(61, 21);
            this.CmbNodeID.TabIndex = 11;
            this.CmbNodeID.Visible = false;
            // 
            // LabSlotID
            // 
            this.LabSlotID.AutoSize = true;
            this.LabSlotID.Location = new System.Drawing.Point(129, 20);
            this.LabSlotID.Name = "LabSlotID";
            this.LabSlotID.Size = new System.Drawing.Size(48, 13);
            this.LabSlotID.TabIndex = 10;
            this.LabSlotID.Text = "Slot ID :";
            this.LabSlotID.Visible = false;
            // 
            // LabNodeID
            // 
            this.LabNodeID.AutoSize = true;
            this.LabNodeID.Location = new System.Drawing.Point(5, 20);
            this.LabNodeID.Name = "LabNodeID";
            this.LabNodeID.Size = new System.Drawing.Size(55, 13);
            this.LabNodeID.TabIndex = 8;
            this.LabNodeID.Text = "Node ID :";
            this.LabNodeID.Visible = false;
            // 
            // GrpSetNode
            // 
            this.GrpSetNode.Controls.Add(this.CmbNode);
            this.GrpSetNode.Controls.Add(this.LabNode);
            this.GrpSetNode.Controls.Add(this.CmbSlotID);
            this.GrpSetNode.Controls.Add(this.LabSlotID);
            this.GrpSetNode.Controls.Add(this.CmbNodeID);
            this.GrpSetNode.Controls.Add(this.LabNodeID);
            this.GrpSetNode.Location = new System.Drawing.Point(12, 122);
            this.GrpSetNode.Name = "GrpSetNode";
            this.GrpSetNode.Size = new System.Drawing.Size(246, 51);
            this.GrpSetNode.TabIndex = 10;
            this.GrpSetNode.TabStop = false;
            this.GrpSetNode.Text = "2. Set Node";
            // 
            // CmbNode
            // 
            this.CmbNode.FormattingEnabled = true;
            this.CmbNode.Location = new System.Drawing.Point(63, 20);
            this.CmbNode.Name = "CmbNode";
            this.CmbNode.Size = new System.Drawing.Size(121, 21);
            this.CmbNode.TabIndex = 14;
            this.CmbNode.SelectedIndexChanged += new System.EventHandler(this.CmbNode_SelectedIndexChanged);
            // 
            // LabNode
            // 
            this.LabNode.AutoSize = true;
            this.LabNode.Location = new System.Drawing.Point(8, 23);
            this.LabNode.Name = "LabNode";
            this.LabNode.Size = new System.Drawing.Size(39, 13);
            this.LabNode.TabIndex = 13;
            this.LabNode.Text = "Node :";
            // 
            // GrpErrorMsg
            // 
            this.GrpErrorMsg.Controls.Add(this.LstErrMsg);
            this.GrpErrorMsg.Location = new System.Drawing.Point(12, 299);
            this.GrpErrorMsg.Name = "GrpErrorMsg";
            this.GrpErrorMsg.Size = new System.Drawing.Size(568, 68);
            this.GrpErrorMsg.TabIndex = 15;
            this.GrpErrorMsg.TabStop = false;
            this.GrpErrorMsg.Text = "Error Message";
            // 
            // LstErrMsg
            // 
            this.LstErrMsg.FormattingEnabled = true;
            this.LstErrMsg.Location = new System.Drawing.Point(13, 18);
            this.LstErrMsg.Name = "LstErrMsg";
            this.LstErrMsg.Size = new System.Drawing.Size(543, 43);
            this.LstErrMsg.TabIndex = 0;
            // 
            // TimCheckStatus
            // 
            this.TimCheckStatus.Tick += new System.EventHandler(this.TimCheckStatus_Tick);
            // 
            // GrpDIStatus
            // 
            this.GrpDIStatus.Controls.Add(this.LabBit15);
            this.GrpDIStatus.Controls.Add(this.LabBit14);
            this.GrpDIStatus.Controls.Add(this.LabBit13);
            this.GrpDIStatus.Controls.Add(this.LabBit12);
            this.GrpDIStatus.Controls.Add(this.LabBit11);
            this.GrpDIStatus.Controls.Add(this.LabBit10);
            this.GrpDIStatus.Controls.Add(this.LabBit09);
            this.GrpDIStatus.Controls.Add(this.LabBit08);
            this.GrpDIStatus.Controls.Add(this.LabBit07);
            this.GrpDIStatus.Controls.Add(this.LabBit06);
            this.GrpDIStatus.Controls.Add(this.LabBit05);
            this.GrpDIStatus.Controls.Add(this.LabBit04);
            this.GrpDIStatus.Controls.Add(this.LabBit03);
            this.GrpDIStatus.Controls.Add(this.LabBit02);
            this.GrpDIStatus.Controls.Add(this.LabBit01);
            this.GrpDIStatus.Controls.Add(this.LabBit00);
            this.GrpDIStatus.Location = new System.Drawing.Point(12, 179);
            this.GrpDIStatus.Name = "GrpDIStatus";
            this.GrpDIStatus.Size = new System.Drawing.Size(568, 114);
            this.GrpDIStatus.TabIndex = 16;
            this.GrpDIStatus.TabStop = false;
            this.GrpDIStatus.Text = "Input Status";
            // 
            // LabBit15
            // 
            this.LabBit15.BackColor = System.Drawing.Color.Gray;
            this.LabBit15.Location = new System.Drawing.Point(484, 66);
            this.LabBit15.Name = "LabBit15";
            this.LabBit15.Size = new System.Drawing.Size(47, 33);
            this.LabBit15.TabIndex = 15;
            this.LabBit15.Text = "15";
            this.LabBit15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit14
            // 
            this.LabBit14.BackColor = System.Drawing.Color.Gray;
            this.LabBit14.Location = new System.Drawing.Point(420, 66);
            this.LabBit14.Name = "LabBit14";
            this.LabBit14.Size = new System.Drawing.Size(47, 33);
            this.LabBit14.TabIndex = 14;
            this.LabBit14.Text = "14";
            this.LabBit14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit13
            // 
            this.LabBit13.BackColor = System.Drawing.Color.Gray;
            this.LabBit13.Location = new System.Drawing.Point(356, 66);
            this.LabBit13.Name = "LabBit13";
            this.LabBit13.Size = new System.Drawing.Size(47, 33);
            this.LabBit13.TabIndex = 13;
            this.LabBit13.Text = "13";
            this.LabBit13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit12
            // 
            this.LabBit12.BackColor = System.Drawing.Color.Gray;
            this.LabBit12.Location = new System.Drawing.Point(292, 66);
            this.LabBit12.Name = "LabBit12";
            this.LabBit12.Size = new System.Drawing.Size(47, 33);
            this.LabBit12.TabIndex = 12;
            this.LabBit12.Text = "12";
            this.LabBit12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit11
            // 
            this.LabBit11.BackColor = System.Drawing.Color.Gray;
            this.LabBit11.Location = new System.Drawing.Point(228, 66);
            this.LabBit11.Name = "LabBit11";
            this.LabBit11.Size = new System.Drawing.Size(47, 33);
            this.LabBit11.TabIndex = 11;
            this.LabBit11.Text = "11";
            this.LabBit11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit10
            // 
            this.LabBit10.BackColor = System.Drawing.Color.Gray;
            this.LabBit10.Location = new System.Drawing.Point(164, 66);
            this.LabBit10.Name = "LabBit10";
            this.LabBit10.Size = new System.Drawing.Size(47, 33);
            this.LabBit10.TabIndex = 10;
            this.LabBit10.Text = "10";
            this.LabBit10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit09
            // 
            this.LabBit09.BackColor = System.Drawing.Color.Gray;
            this.LabBit09.Location = new System.Drawing.Point(100, 66);
            this.LabBit09.Name = "LabBit09";
            this.LabBit09.Size = new System.Drawing.Size(47, 33);
            this.LabBit09.TabIndex = 9;
            this.LabBit09.Text = "09";
            this.LabBit09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit08
            // 
            this.LabBit08.BackColor = System.Drawing.Color.Gray;
            this.LabBit08.Location = new System.Drawing.Point(36, 66);
            this.LabBit08.Name = "LabBit08";
            this.LabBit08.Size = new System.Drawing.Size(47, 33);
            this.LabBit08.TabIndex = 8;
            this.LabBit08.Text = "08";
            this.LabBit08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit07
            // 
            this.LabBit07.BackColor = System.Drawing.Color.Gray;
            this.LabBit07.Location = new System.Drawing.Point(484, 23);
            this.LabBit07.Name = "LabBit07";
            this.LabBit07.Size = new System.Drawing.Size(47, 33);
            this.LabBit07.TabIndex = 7;
            this.LabBit07.Text = "07";
            this.LabBit07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit06
            // 
            this.LabBit06.BackColor = System.Drawing.Color.Gray;
            this.LabBit06.Location = new System.Drawing.Point(420, 23);
            this.LabBit06.Name = "LabBit06";
            this.LabBit06.Size = new System.Drawing.Size(47, 33);
            this.LabBit06.TabIndex = 6;
            this.LabBit06.Text = "06";
            this.LabBit06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit05
            // 
            this.LabBit05.BackColor = System.Drawing.Color.Gray;
            this.LabBit05.Location = new System.Drawing.Point(356, 23);
            this.LabBit05.Name = "LabBit05";
            this.LabBit05.Size = new System.Drawing.Size(47, 33);
            this.LabBit05.TabIndex = 5;
            this.LabBit05.Text = "05";
            this.LabBit05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit04
            // 
            this.LabBit04.BackColor = System.Drawing.Color.Gray;
            this.LabBit04.Location = new System.Drawing.Point(292, 23);
            this.LabBit04.Name = "LabBit04";
            this.LabBit04.Size = new System.Drawing.Size(47, 33);
            this.LabBit04.TabIndex = 4;
            this.LabBit04.Text = "04";
            this.LabBit04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit03
            // 
            this.LabBit03.BackColor = System.Drawing.Color.Gray;
            this.LabBit03.Location = new System.Drawing.Point(228, 23);
            this.LabBit03.Name = "LabBit03";
            this.LabBit03.Size = new System.Drawing.Size(47, 33);
            this.LabBit03.TabIndex = 3;
            this.LabBit03.Text = "03";
            this.LabBit03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit02
            // 
            this.LabBit02.BackColor = System.Drawing.Color.Gray;
            this.LabBit02.Location = new System.Drawing.Point(164, 23);
            this.LabBit02.Name = "LabBit02";
            this.LabBit02.Size = new System.Drawing.Size(47, 33);
            this.LabBit02.TabIndex = 2;
            this.LabBit02.Text = "02";
            this.LabBit02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit01
            // 
            this.LabBit01.BackColor = System.Drawing.Color.Gray;
            this.LabBit01.Location = new System.Drawing.Point(100, 23);
            this.LabBit01.Name = "LabBit01";
            this.LabBit01.Size = new System.Drawing.Size(47, 33);
            this.LabBit01.TabIndex = 1;
            this.LabBit01.Text = "01";
            this.LabBit01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBit00
            // 
            this.LabBit00.BackColor = System.Drawing.Color.Gray;
            this.LabBit00.Location = new System.Drawing.Point(36, 23);
            this.LabBit00.Name = "LabBit00";
            this.LabBit00.Size = new System.Drawing.Size(47, 33);
            this.LabBit00.TabIndex = 0;
            this.LabBit00.Text = "00";
            this.LabBit00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrpOutput
            // 
            this.GrpOutput.Controls.Add(this.BtnSendOutput);
            this.GrpOutput.Controls.Add(this.TxtOutputValue);
            this.GrpOutput.Controls.Add(this.LabValue);
            this.GrpOutput.Location = new System.Drawing.Point(286, 122);
            this.GrpOutput.Name = "GrpOutput";
            this.GrpOutput.Size = new System.Drawing.Size(257, 51);
            this.GrpOutput.TabIndex = 17;
            this.GrpOutput.TabStop = false;
            this.GrpOutput.Text = "3. Output";
            // 
            // BtnSendOutput
            // 
            this.BtnSendOutput.Location = new System.Drawing.Point(170, 19);
            this.BtnSendOutput.Name = "BtnSendOutput";
            this.BtnSendOutput.Size = new System.Drawing.Size(75, 23);
            this.BtnSendOutput.TabIndex = 2;
            this.BtnSendOutput.Text = "Send";
            this.BtnSendOutput.UseVisualStyleBackColor = true;
            this.BtnSendOutput.Click += new System.EventHandler(this.BtnSendOutput_Click);
            // 
            // TxtOutputValue
            // 
            this.TxtOutputValue.Location = new System.Drawing.Point(64, 19);
            this.TxtOutputValue.Name = "TxtOutputValue";
            this.TxtOutputValue.Size = new System.Drawing.Size(100, 23);
            this.TxtOutputValue.TabIndex = 1;
            // 
            // LabValue
            // 
            this.LabValue.AutoSize = true;
            this.LabValue.Location = new System.Drawing.Point(16, 23);
            this.LabValue.Name = "LabValue";
            this.LabValue.Size = new System.Drawing.Size(41, 13);
            this.LabValue.TabIndex = 0;
            this.LabValue.Text = "Value :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 438);
            this.Controls.Add(this.GrpOutput);
            this.Controls.Add(this.GrpDIStatus);
            this.Controls.Add(this.GrpErrorMsg);
            this.Controls.Add(this.GrpSetNode);
            this.Controls.Add(this.GrpInitial);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "EtherCat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.GrpInitial.ResumeLayout(false);
            this.GrpInitial.PerformLayout();
            this.GrpSetNode.ResumeLayout(false);
            this.GrpSetNode.PerformLayout();
            this.GrpErrorMsg.ResumeLayout(false);
            this.GrpDIStatus.ResumeLayout(false);
            this.GrpOutput.ResumeLayout(false);
            this.GrpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInitialCard;
        private System.Windows.Forms.Label LabCardNo;
        private System.Windows.Forms.ComboBox CmbCardNo;
        private System.Windows.Forms.Label LabInitialStatus;
        private System.Windows.Forms.TextBox TxtInitialStatus;
        private System.Windows.Forms.Button BtnFindSlave;
        private System.Windows.Forms.Label LabSlaveNum;
        private System.Windows.Forms.TextBox TxtSlaveNum;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GrpInitial;
        private System.Windows.Forms.GroupBox GrpSetNode;
        private System.Windows.Forms.Label LabNodeID;
        private System.Windows.Forms.Label LabSlotID;
        private System.Windows.Forms.ComboBox CmbNodeID;
        private System.Windows.Forms.ComboBox CmbSlotID;
        private System.Windows.Forms.Label LabNode;
        private System.Windows.Forms.ComboBox CmbNode;
        private System.Windows.Forms.CheckBox ChkRealTimeUpdate;
        private System.Windows.Forms.GroupBox GrpErrorMsg;
        private System.Windows.Forms.ListBox LstErrMsg;
        private System.Windows.Forms.Timer TimCheckStatus;
        private System.Windows.Forms.GroupBox GrpDIStatus;
        private System.Windows.Forms.Label LabBit00;
        private System.Windows.Forms.Label LabBit15;
        private System.Windows.Forms.Label LabBit14;
        private System.Windows.Forms.Label LabBit13;
        private System.Windows.Forms.Label LabBit12;
        private System.Windows.Forms.Label LabBit11;
        private System.Windows.Forms.Label LabBit10;
        private System.Windows.Forms.Label LabBit09;
        private System.Windows.Forms.Label LabBit08;
        private System.Windows.Forms.Label LabBit07;
        private System.Windows.Forms.Label LabBit06;
        private System.Windows.Forms.Label LabBit05;
        private System.Windows.Forms.Label LabBit04;
        private System.Windows.Forms.Label LabBit03;
        private System.Windows.Forms.Label LabBit02;
        private System.Windows.Forms.Label LabBit01;
        private System.Windows.Forms.GroupBox GrpOutput;
        private System.Windows.Forms.Label LabValue;
        private System.Windows.Forms.TextBox TxtOutputValue;
        private System.Windows.Forms.Button BtnSendOutput;
    }
}

