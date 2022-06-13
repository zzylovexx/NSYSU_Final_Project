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
            this.GrpDOStatus = new System.Windows.Forms.GroupBox();
            this.ChkBit15 = new System.Windows.Forms.CheckBox();
            this.ChkBit14 = new System.Windows.Forms.CheckBox();
            this.ChkBit13 = new System.Windows.Forms.CheckBox();
            this.ChkBit12 = new System.Windows.Forms.CheckBox();
            this.ChkBit11 = new System.Windows.Forms.CheckBox();
            this.ChkBit10 = new System.Windows.Forms.CheckBox();
            this.ChkBit09 = new System.Windows.Forms.CheckBox();
            this.ChkBit08 = new System.Windows.Forms.CheckBox();
            this.ChkBit07 = new System.Windows.Forms.CheckBox();
            this.ChkBit06 = new System.Windows.Forms.CheckBox();
            this.ChkBit05 = new System.Windows.Forms.CheckBox();
            this.ChkBit04 = new System.Windows.Forms.CheckBox();
            this.ChkBit03 = new System.Windows.Forms.CheckBox();
            this.ChkBit02 = new System.Windows.Forms.CheckBox();
            this.ChkBit01 = new System.Windows.Forms.CheckBox();
            this.ChkBit00 = new System.Windows.Forms.CheckBox();
            this.GrpInitial.SuspendLayout();
            this.GrpSetNode.SuspendLayout();
            this.GrpErrorMsg.SuspendLayout();
            this.GrpDOStatus.SuspendLayout();
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
            // GrpDOStatus
            // 
            this.GrpDOStatus.Controls.Add(this.ChkBit15);
            this.GrpDOStatus.Controls.Add(this.ChkBit14);
            this.GrpDOStatus.Controls.Add(this.ChkBit13);
            this.GrpDOStatus.Controls.Add(this.ChkBit12);
            this.GrpDOStatus.Controls.Add(this.ChkBit11);
            this.GrpDOStatus.Controls.Add(this.ChkBit10);
            this.GrpDOStatus.Controls.Add(this.ChkBit09);
            this.GrpDOStatus.Controls.Add(this.ChkBit08);
            this.GrpDOStatus.Controls.Add(this.ChkBit07);
            this.GrpDOStatus.Controls.Add(this.ChkBit06);
            this.GrpDOStatus.Controls.Add(this.ChkBit05);
            this.GrpDOStatus.Controls.Add(this.ChkBit04);
            this.GrpDOStatus.Controls.Add(this.ChkBit03);
            this.GrpDOStatus.Controls.Add(this.ChkBit02);
            this.GrpDOStatus.Controls.Add(this.ChkBit01);
            this.GrpDOStatus.Controls.Add(this.ChkBit00);
            this.GrpDOStatus.Location = new System.Drawing.Point(12, 179);
            this.GrpDOStatus.Name = "GrpDOStatus";
            this.GrpDOStatus.Size = new System.Drawing.Size(568, 114);
            this.GrpDOStatus.TabIndex = 16;
            this.GrpDOStatus.TabStop = false;
            this.GrpDOStatus.Text = "Output Status";
            // 
            // ChkBit15
            // 
            this.ChkBit15.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit15.BackColor = System.Drawing.Color.Red;
            this.ChkBit15.Location = new System.Drawing.Point(503, 65);
            this.ChkBit15.Name = "ChkBit15";
            this.ChkBit15.Size = new System.Drawing.Size(47, 37);
            this.ChkBit15.TabIndex = 15;
            this.ChkBit15.Text = "15";
            this.ChkBit15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit15.UseVisualStyleBackColor = false;
            this.ChkBit15.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit14
            // 
            this.ChkBit14.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit14.BackColor = System.Drawing.Color.Red;
            this.ChkBit14.Location = new System.Drawing.Point(433, 65);
            this.ChkBit14.Name = "ChkBit14";
            this.ChkBit14.Size = new System.Drawing.Size(47, 37);
            this.ChkBit14.TabIndex = 14;
            this.ChkBit14.Text = "14";
            this.ChkBit14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit14.UseVisualStyleBackColor = false;
            this.ChkBit14.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit13
            // 
            this.ChkBit13.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit13.BackColor = System.Drawing.Color.Red;
            this.ChkBit13.Location = new System.Drawing.Point(363, 65);
            this.ChkBit13.Name = "ChkBit13";
            this.ChkBit13.Size = new System.Drawing.Size(47, 37);
            this.ChkBit13.TabIndex = 13;
            this.ChkBit13.Text = "13";
            this.ChkBit13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit13.UseVisualStyleBackColor = false;
            this.ChkBit13.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit12
            // 
            this.ChkBit12.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit12.BackColor = System.Drawing.Color.Red;
            this.ChkBit12.Location = new System.Drawing.Point(293, 65);
            this.ChkBit12.Name = "ChkBit12";
            this.ChkBit12.Size = new System.Drawing.Size(47, 37);
            this.ChkBit12.TabIndex = 12;
            this.ChkBit12.Text = "12";
            this.ChkBit12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit12.UseVisualStyleBackColor = false;
            this.ChkBit12.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit11
            // 
            this.ChkBit11.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit11.BackColor = System.Drawing.Color.Red;
            this.ChkBit11.Location = new System.Drawing.Point(223, 65);
            this.ChkBit11.Name = "ChkBit11";
            this.ChkBit11.Size = new System.Drawing.Size(47, 37);
            this.ChkBit11.TabIndex = 11;
            this.ChkBit11.Text = "11";
            this.ChkBit11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit11.UseVisualStyleBackColor = false;
            this.ChkBit11.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit10
            // 
            this.ChkBit10.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit10.BackColor = System.Drawing.Color.Red;
            this.ChkBit10.Location = new System.Drawing.Point(153, 65);
            this.ChkBit10.Name = "ChkBit10";
            this.ChkBit10.Size = new System.Drawing.Size(47, 37);
            this.ChkBit10.TabIndex = 10;
            this.ChkBit10.Text = "10";
            this.ChkBit10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit10.UseVisualStyleBackColor = false;
            this.ChkBit10.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit09
            // 
            this.ChkBit09.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit09.BackColor = System.Drawing.Color.Red;
            this.ChkBit09.Location = new System.Drawing.Point(83, 65);
            this.ChkBit09.Name = "ChkBit09";
            this.ChkBit09.Size = new System.Drawing.Size(47, 37);
            this.ChkBit09.TabIndex = 9;
            this.ChkBit09.Text = "09";
            this.ChkBit09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit09.UseVisualStyleBackColor = false;
            this.ChkBit09.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit08
            // 
            this.ChkBit08.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit08.BackColor = System.Drawing.Color.Red;
            this.ChkBit08.Location = new System.Drawing.Point(13, 65);
            this.ChkBit08.Name = "ChkBit08";
            this.ChkBit08.Size = new System.Drawing.Size(47, 37);
            this.ChkBit08.TabIndex = 8;
            this.ChkBit08.Text = "08";
            this.ChkBit08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit08.UseVisualStyleBackColor = false;
            this.ChkBit08.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit07
            // 
            this.ChkBit07.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit07.BackColor = System.Drawing.Color.Red;
            this.ChkBit07.Location = new System.Drawing.Point(503, 22);
            this.ChkBit07.Name = "ChkBit07";
            this.ChkBit07.Size = new System.Drawing.Size(47, 37);
            this.ChkBit07.TabIndex = 7;
            this.ChkBit07.Text = "07";
            this.ChkBit07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit07.UseVisualStyleBackColor = false;
            this.ChkBit07.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit06
            // 
            this.ChkBit06.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit06.BackColor = System.Drawing.Color.Red;
            this.ChkBit06.Location = new System.Drawing.Point(433, 22);
            this.ChkBit06.Name = "ChkBit06";
            this.ChkBit06.Size = new System.Drawing.Size(47, 37);
            this.ChkBit06.TabIndex = 6;
            this.ChkBit06.Text = "06";
            this.ChkBit06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit06.UseVisualStyleBackColor = false;
            this.ChkBit06.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit05
            // 
            this.ChkBit05.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit05.BackColor = System.Drawing.Color.Red;
            this.ChkBit05.Location = new System.Drawing.Point(363, 22);
            this.ChkBit05.Name = "ChkBit05";
            this.ChkBit05.Size = new System.Drawing.Size(47, 37);
            this.ChkBit05.TabIndex = 5;
            this.ChkBit05.Text = "05";
            this.ChkBit05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit05.UseVisualStyleBackColor = false;
            this.ChkBit05.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit04
            // 
            this.ChkBit04.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit04.BackColor = System.Drawing.Color.Red;
            this.ChkBit04.Location = new System.Drawing.Point(293, 22);
            this.ChkBit04.Name = "ChkBit04";
            this.ChkBit04.Size = new System.Drawing.Size(47, 37);
            this.ChkBit04.TabIndex = 4;
            this.ChkBit04.Text = "04";
            this.ChkBit04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit04.UseVisualStyleBackColor = false;
            this.ChkBit04.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit03
            // 
            this.ChkBit03.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit03.BackColor = System.Drawing.Color.Red;
            this.ChkBit03.Location = new System.Drawing.Point(223, 22);
            this.ChkBit03.Name = "ChkBit03";
            this.ChkBit03.Size = new System.Drawing.Size(47, 37);
            this.ChkBit03.TabIndex = 3;
            this.ChkBit03.Text = "03";
            this.ChkBit03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit03.UseVisualStyleBackColor = false;
            this.ChkBit03.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit02
            // 
            this.ChkBit02.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit02.BackColor = System.Drawing.Color.Red;
            this.ChkBit02.Location = new System.Drawing.Point(153, 22);
            this.ChkBit02.Name = "ChkBit02";
            this.ChkBit02.Size = new System.Drawing.Size(47, 37);
            this.ChkBit02.TabIndex = 2;
            this.ChkBit02.Text = "02";
            this.ChkBit02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit02.UseVisualStyleBackColor = false;
            this.ChkBit02.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit01
            // 
            this.ChkBit01.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit01.BackColor = System.Drawing.Color.Red;
            this.ChkBit01.Location = new System.Drawing.Point(83, 22);
            this.ChkBit01.Name = "ChkBit01";
            this.ChkBit01.Size = new System.Drawing.Size(47, 37);
            this.ChkBit01.TabIndex = 1;
            this.ChkBit01.Text = "01";
            this.ChkBit01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit01.UseVisualStyleBackColor = false;
            this.ChkBit01.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // ChkBit00
            // 
            this.ChkBit00.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkBit00.BackColor = System.Drawing.Color.Red;
            this.ChkBit00.Location = new System.Drawing.Point(13, 22);
            this.ChkBit00.Name = "ChkBit00";
            this.ChkBit00.Size = new System.Drawing.Size(47, 37);
            this.ChkBit00.TabIndex = 0;
            this.ChkBit00.Text = "00";
            this.ChkBit00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBit00.UseVisualStyleBackColor = false;
            this.ChkBit00.CheckedChanged += new System.EventHandler(this.ChkBit_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 438);
            this.Controls.Add(this.GrpDOStatus);
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
            this.GrpDOStatus.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox GrpDOStatus;
        private System.Windows.Forms.CheckBox ChkBit00;
        private System.Windows.Forms.CheckBox ChkBit15;
        private System.Windows.Forms.CheckBox ChkBit14;
        private System.Windows.Forms.CheckBox ChkBit13;
        private System.Windows.Forms.CheckBox ChkBit12;
        private System.Windows.Forms.CheckBox ChkBit11;
        private System.Windows.Forms.CheckBox ChkBit10;
        private System.Windows.Forms.CheckBox ChkBit09;
        private System.Windows.Forms.CheckBox ChkBit08;
        private System.Windows.Forms.CheckBox ChkBit07;
        private System.Windows.Forms.CheckBox ChkBit06;
        private System.Windows.Forms.CheckBox ChkBit05;
        private System.Windows.Forms.CheckBox ChkBit04;
        private System.Windows.Forms.CheckBox ChkBit03;
        private System.Windows.Forms.CheckBox ChkBit02;
        private System.Windows.Forms.CheckBox ChkBit01;
    }
}

