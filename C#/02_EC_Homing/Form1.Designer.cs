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
            this.GrpSetVelProf = new System.Windows.Forms.GroupBox();
            this.LabDecUnit = new System.Windows.Forms.Label();
            this.LabSecondVelUnit = new System.Windows.Forms.Label();
            this.LabFirstVelUnit = new System.Windows.Forms.Label();
            this.TxtDec = new System.Windows.Forms.TextBox();
            this.TxtSecondVel = new System.Windows.Forms.TextBox();
            this.TxtFirstVel = new System.Windows.Forms.TextBox();
            this.LabDec = new System.Windows.Forms.Label();
            this.LabSecondVel = new System.Windows.Forms.Label();
            this.LabFirstVel = new System.Windows.Forms.Label();
            this.GrpHomingSetting = new System.Windows.Forms.GroupBox();
            this.LabInc = new System.Windows.Forms.Label();
            this.TxtOffset = new System.Windows.Forms.TextBox();
            this.LabOffset = new System.Windows.Forms.Label();
            this.LabModeUnit = new System.Windows.Forms.Label();
            this.TxtMode = new System.Windows.Forms.TextBox();
            this.LabModel = new System.Windows.Forms.Label();
            this.GrpControl = new System.Windows.Forms.GroupBox();
            this.BtnHoming = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnResetStatus = new System.Windows.Forms.Button();
            this.RdoSVOFF = new System.Windows.Forms.RadioButton();
            this.RdoSVON = new System.Windows.Forms.RadioButton();
            this.BtnResetAlarm = new System.Windows.Forms.Button();
            this.GrpStatus = new System.Windows.Forms.GroupBox();
            this.TxtMotionDown = new System.Windows.Forms.TextBox();
            this.TxtIOStatus = new System.Windows.Forms.TextBox();
            this.LabFbkPls = new System.Windows.Forms.Label();
            this.TxtFbkPos = new System.Windows.Forms.TextBox();
            this.LabCmdPls = new System.Windows.Forms.Label();
            this.TxtCmdPos = new System.Windows.Forms.TextBox();
            this.LabMotionDown = new System.Windows.Forms.Label();
            this.LabIOStatus = new System.Windows.Forms.Label();
            this.LabFeedbackPos = new System.Windows.Forms.Label();
            this.LabCommandPos = new System.Windows.Forms.Label();
            this.GrpErrorMsg = new System.Windows.Forms.GroupBox();
            this.LstErrMsg = new System.Windows.Forms.ListBox();
            this.TimCheckStatus = new System.Windows.Forms.Timer(this.components);
            this.GrpInitial.SuspendLayout();
            this.GrpSetNode.SuspendLayout();
            this.GrpSetVelProf.SuspendLayout();
            this.GrpHomingSetting.SuspendLayout();
            this.GrpControl.SuspendLayout();
            this.GrpStatus.SuspendLayout();
            this.GrpErrorMsg.SuspendLayout();
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
            this.BtnExit.Location = new System.Drawing.Point(228, 529);
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
            this.ChkRealTimeUpdate.AutoSize = true;
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
            this.GrpSetNode.Location = new System.Drawing.Point(12, 135);
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
            // GrpSetVelProf
            // 
            this.GrpSetVelProf.Controls.Add(this.LabDecUnit);
            this.GrpSetVelProf.Controls.Add(this.LabSecondVelUnit);
            this.GrpSetVelProf.Controls.Add(this.LabFirstVelUnit);
            this.GrpSetVelProf.Controls.Add(this.TxtDec);
            this.GrpSetVelProf.Controls.Add(this.TxtSecondVel);
            this.GrpSetVelProf.Controls.Add(this.TxtFirstVel);
            this.GrpSetVelProf.Controls.Add(this.LabDec);
            this.GrpSetVelProf.Controls.Add(this.LabSecondVel);
            this.GrpSetVelProf.Controls.Add(this.LabFirstVel);
            this.GrpSetVelProf.Location = new System.Drawing.Point(12, 192);
            this.GrpSetVelProf.Name = "GrpSetVelProf";
            this.GrpSetVelProf.Size = new System.Drawing.Size(246, 135);
            this.GrpSetVelProf.TabIndex = 11;
            this.GrpSetVelProf.TabStop = false;
            this.GrpSetVelProf.Text = "3. Set Vel. Prof.";
            // 
            // LabDecUnit
            // 
            this.LabDecUnit.AutoSize = true;
            this.LabDecUnit.Location = new System.Drawing.Point(174, 97);
            this.LabDecUnit.Name = "LabDecUnit";
            this.LabDecUnit.Size = new System.Drawing.Size(41, 13);
            this.LabDecUnit.TabIndex = 8;
            this.LabDecUnit.Text = "inc/s^2";
            // 
            // LabSecondVelUnit
            // 
            this.LabSecondVelUnit.AutoSize = true;
            this.LabSecondVelUnit.Location = new System.Drawing.Point(174, 66);
            this.LabSecondVelUnit.Name = "LabSecondVelUnit";
            this.LabSecondVelUnit.Size = new System.Drawing.Size(29, 13);
            this.LabSecondVelUnit.TabIndex = 7;
            this.LabSecondVelUnit.Text = "inc/s";
            // 
            // LabFirstVelUnit
            // 
            this.LabFirstVelUnit.AutoSize = true;
            this.LabFirstVelUnit.Location = new System.Drawing.Point(174, 32);
            this.LabFirstVelUnit.Name = "LabFirstVelUnit";
            this.LabFirstVelUnit.Size = new System.Drawing.Size(29, 13);
            this.LabFirstVelUnit.TabIndex = 6;
            this.LabFirstVelUnit.Text = "inc/s";
            // 
            // TxtDec
            // 
            this.TxtDec.Location = new System.Drawing.Point(72, 93);
            this.TxtDec.Name = "TxtDec";
            this.TxtDec.Size = new System.Drawing.Size(100, 23);
            this.TxtDec.TabIndex = 5;
            this.TxtDec.Text = "0.1";
            // 
            // TxtSecondVel
            // 
            this.TxtSecondVel.Location = new System.Drawing.Point(72, 62);
            this.TxtSecondVel.Name = "TxtSecondVel";
            this.TxtSecondVel.Size = new System.Drawing.Size(100, 23);
            this.TxtSecondVel.TabIndex = 4;
            this.TxtSecondVel.Text = "0";
            // 
            // TxtFirstVel
            // 
            this.TxtFirstVel.Location = new System.Drawing.Point(72, 28);
            this.TxtFirstVel.Name = "TxtFirstVel";
            this.TxtFirstVel.Size = new System.Drawing.Size(100, 23);
            this.TxtFirstVel.TabIndex = 3;
            this.TxtFirstVel.Text = "0";
            // 
            // LabDec
            // 
            this.LabDec.AutoSize = true;
            this.LabDec.Location = new System.Drawing.Point(40, 97);
            this.LabDec.Name = "LabDec";
            this.LabDec.Size = new System.Drawing.Size(29, 13);
            this.LabDec.TabIndex = 2;
            this.LabDec.Text = "Dec.";
            // 
            // LabSecondVel
            // 
            this.LabSecondVel.AutoSize = true;
            this.LabSecondVel.Location = new System.Drawing.Point(4, 66);
            this.LabSecondVel.Name = "LabSecondVel";
            this.LabSecondVel.Size = new System.Drawing.Size(65, 13);
            this.LabSecondVel.TabIndex = 1;
            this.LabSecondVel.Text = "Second Vel.";
            // 
            // LabFirstVel
            // 
            this.LabFirstVel.AutoSize = true;
            this.LabFirstVel.Location = new System.Drawing.Point(17, 32);
            this.LabFirstVel.Name = "LabFirstVel";
            this.LabFirstVel.Size = new System.Drawing.Size(52, 13);
            this.LabFirstVel.TabIndex = 0;
            this.LabFirstVel.Text = "First Vel.";
            // 
            // GrpHomingSetting
            // 
            this.GrpHomingSetting.Controls.Add(this.LabInc);
            this.GrpHomingSetting.Controls.Add(this.TxtOffset);
            this.GrpHomingSetting.Controls.Add(this.LabOffset);
            this.GrpHomingSetting.Controls.Add(this.LabModeUnit);
            this.GrpHomingSetting.Controls.Add(this.TxtMode);
            this.GrpHomingSetting.Controls.Add(this.LabModel);
            this.GrpHomingSetting.Location = new System.Drawing.Point(12, 341);
            this.GrpHomingSetting.Name = "GrpHomingSetting";
            this.GrpHomingSetting.Size = new System.Drawing.Size(246, 100);
            this.GrpHomingSetting.TabIndex = 12;
            this.GrpHomingSetting.TabStop = false;
            this.GrpHomingSetting.Text = "4. Homing Setting";
            // 
            // LabInc
            // 
            this.LabInc.AutoSize = true;
            this.LabInc.Location = new System.Drawing.Point(163, 70);
            this.LabInc.Name = "LabInc";
            this.LabInc.Size = new System.Drawing.Size(21, 13);
            this.LabInc.TabIndex = 5;
            this.LabInc.Text = "inc";
            // 
            // TxtOffset
            // 
            this.TxtOffset.Location = new System.Drawing.Point(56, 67);
            this.TxtOffset.Name = "TxtOffset";
            this.TxtOffset.Size = new System.Drawing.Size(100, 23);
            this.TxtOffset.TabIndex = 4;
            this.TxtOffset.Text = "0";
            // 
            // LabOffset
            // 
            this.LabOffset.AutoSize = true;
            this.LabOffset.Location = new System.Drawing.Point(10, 71);
            this.LabOffset.Name = "LabOffset";
            this.LabOffset.Size = new System.Drawing.Size(43, 13);
            this.LabOffset.TabIndex = 3;
            this.LabOffset.Text = "Offset :";
            // 
            // LabModeUnit
            // 
            this.LabModeUnit.AutoSize = true;
            this.LabModeUnit.Location = new System.Drawing.Point(163, 35);
            this.LabModeUnit.Name = "LabModeUnit";
            this.LabModeUnit.Size = new System.Drawing.Size(49, 13);
            this.LabModeUnit.TabIndex = 2;
            this.LabModeUnit.Text = "( 1 - 35 )";
            // 
            // TxtMode
            // 
            this.TxtMode.Location = new System.Drawing.Point(56, 32);
            this.TxtMode.Name = "TxtMode";
            this.TxtMode.Size = new System.Drawing.Size(100, 23);
            this.TxtMode.TabIndex = 1;
            this.TxtMode.Text = "1";
            // 
            // LabModel
            // 
            this.LabModel.AutoSize = true;
            this.LabModel.Location = new System.Drawing.Point(12, 35);
            this.LabModel.Name = "LabModel";
            this.LabModel.Size = new System.Drawing.Size(41, 13);
            this.LabModel.TabIndex = 0;
            this.LabModel.Text = "Mode :";
            // 
            // GrpControl
            // 
            this.GrpControl.Controls.Add(this.BtnHoming);
            this.GrpControl.Controls.Add(this.BtnStop);
            this.GrpControl.Controls.Add(this.BtnResetStatus);
            this.GrpControl.Controls.Add(this.RdoSVOFF);
            this.GrpControl.Controls.Add(this.RdoSVON);
            this.GrpControl.Controls.Add(this.BtnResetAlarm);
            this.GrpControl.Location = new System.Drawing.Point(264, 135);
            this.GrpControl.Name = "GrpControl";
            this.GrpControl.Size = new System.Drawing.Size(316, 117);
            this.GrpControl.TabIndex = 13;
            this.GrpControl.TabStop = false;
            this.GrpControl.Text = "Control";
            // 
            // BtnHoming
            // 
            this.BtnHoming.Enabled = false;
            this.BtnHoming.Location = new System.Drawing.Point(90, 19);
            this.BtnHoming.Name = "BtnHoming";
            this.BtnHoming.Size = new System.Drawing.Size(136, 44);
            this.BtnHoming.TabIndex = 14;
            this.BtnHoming.Text = "Homing";
            this.BtnHoming.UseVisualStyleBackColor = true;
            this.BtnHoming.Click += new System.EventHandler(this.BtnHoming_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(232, 19);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(78, 44);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnResetStatus
            // 
            this.BtnResetStatus.Enabled = false;
            this.BtnResetStatus.Location = new System.Drawing.Point(174, 67);
            this.BtnResetStatus.Name = "BtnResetStatus";
            this.BtnResetStatus.Size = new System.Drawing.Size(78, 44);
            this.BtnResetStatus.TabIndex = 3;
            this.BtnResetStatus.Text = "ResetStatus";
            this.BtnResetStatus.UseVisualStyleBackColor = true;
            this.BtnResetStatus.Click += new System.EventHandler(this.BtnResetStatus_Click);
            // 
            // RdoSVOFF
            // 
            this.RdoSVOFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.RdoSVOFF.Checked = true;
            this.RdoSVOFF.Enabled = false;
            this.RdoSVOFF.Location = new System.Drawing.Point(6, 67);
            this.RdoSVOFF.Name = "RdoSVOFF";
            this.RdoSVOFF.Size = new System.Drawing.Size(78, 44);
            this.RdoSVOFF.TabIndex = 2;
            this.RdoSVOFF.TabStop = true;
            this.RdoSVOFF.Text = "SVOFF";
            this.RdoSVOFF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdoSVOFF.UseVisualStyleBackColor = true;
            this.RdoSVOFF.CheckedChanged += new System.EventHandler(this.RdoSVON_CheckedChanged);
            // 
            // RdoSVON
            // 
            this.RdoSVON.Appearance = System.Windows.Forms.Appearance.Button;
            this.RdoSVON.Enabled = false;
            this.RdoSVON.Location = new System.Drawing.Point(6, 19);
            this.RdoSVON.Name = "RdoSVON";
            this.RdoSVON.Size = new System.Drawing.Size(78, 44);
            this.RdoSVON.TabIndex = 1;
            this.RdoSVON.Text = "SVON";
            this.RdoSVON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdoSVON.UseVisualStyleBackColor = true;
            this.RdoSVON.CheckedChanged += new System.EventHandler(this.RdoSVON_CheckedChanged);
            // 
            // BtnResetAlarm
            // 
            this.BtnResetAlarm.Enabled = false;
            this.BtnResetAlarm.Location = new System.Drawing.Point(90, 67);
            this.BtnResetAlarm.Name = "BtnResetAlarm";
            this.BtnResetAlarm.Size = new System.Drawing.Size(78, 44);
            this.BtnResetAlarm.TabIndex = 1;
            this.BtnResetAlarm.Text = "ResetAlarm";
            this.BtnResetAlarm.UseVisualStyleBackColor = true;
            this.BtnResetAlarm.Click += new System.EventHandler(this.BtnResetAlarm_Click);
            // 
            // GrpStatus
            // 
            this.GrpStatus.Controls.Add(this.TxtMotionDown);
            this.GrpStatus.Controls.Add(this.TxtIOStatus);
            this.GrpStatus.Controls.Add(this.LabFbkPls);
            this.GrpStatus.Controls.Add(this.TxtFbkPos);
            this.GrpStatus.Controls.Add(this.LabCmdPls);
            this.GrpStatus.Controls.Add(this.TxtCmdPos);
            this.GrpStatus.Controls.Add(this.LabMotionDown);
            this.GrpStatus.Controls.Add(this.LabIOStatus);
            this.GrpStatus.Controls.Add(this.LabFeedbackPos);
            this.GrpStatus.Controls.Add(this.LabCommandPos);
            this.GrpStatus.Location = new System.Drawing.Point(264, 258);
            this.GrpStatus.Name = "GrpStatus";
            this.GrpStatus.Size = new System.Drawing.Size(312, 190);
            this.GrpStatus.TabIndex = 14;
            this.GrpStatus.TabStop = false;
            this.GrpStatus.Text = "Status";
            // 
            // TxtMotionDown
            // 
            this.TxtMotionDown.Location = new System.Drawing.Point(90, 139);
            this.TxtMotionDown.Name = "TxtMotionDown";
            this.TxtMotionDown.ReadOnly = true;
            this.TxtMotionDown.Size = new System.Drawing.Size(140, 23);
            this.TxtMotionDown.TabIndex = 9;
            // 
            // TxtIOStatus
            // 
            this.TxtIOStatus.Location = new System.Drawing.Point(91, 102);
            this.TxtIOStatus.Name = "TxtIOStatus";
            this.TxtIOStatus.ReadOnly = true;
            this.TxtIOStatus.Size = new System.Drawing.Size(139, 23);
            this.TxtIOStatus.TabIndex = 8;
            // 
            // LabFbkPls
            // 
            this.LabFbkPls.AutoSize = true;
            this.LabFbkPls.Location = new System.Drawing.Point(236, 68);
            this.LabFbkPls.Name = "LabFbkPls";
            this.LabFbkPls.Size = new System.Drawing.Size(32, 13);
            this.LabFbkPls.TabIndex = 7;
            this.LabFbkPls.Text = "pluse";
            // 
            // TxtFbkPos
            // 
            this.TxtFbkPos.Location = new System.Drawing.Point(91, 63);
            this.TxtFbkPos.Name = "TxtFbkPos";
            this.TxtFbkPos.ReadOnly = true;
            this.TxtFbkPos.Size = new System.Drawing.Size(139, 23);
            this.TxtFbkPos.TabIndex = 6;
            // 
            // LabCmdPls
            // 
            this.LabCmdPls.AutoSize = true;
            this.LabCmdPls.Location = new System.Drawing.Point(236, 31);
            this.LabCmdPls.Name = "LabCmdPls";
            this.LabCmdPls.Size = new System.Drawing.Size(32, 13);
            this.LabCmdPls.TabIndex = 5;
            this.LabCmdPls.Text = "pluse";
            // 
            // TxtCmdPos
            // 
            this.TxtCmdPos.Location = new System.Drawing.Point(91, 27);
            this.TxtCmdPos.Name = "TxtCmdPos";
            this.TxtCmdPos.ReadOnly = true;
            this.TxtCmdPos.Size = new System.Drawing.Size(139, 23);
            this.TxtCmdPos.TabIndex = 4;
            // 
            // LabMotionDown
            // 
            this.LabMotionDown.AutoSize = true;
            this.LabMotionDown.Location = new System.Drawing.Point(15, 142);
            this.LabMotionDown.Name = "LabMotionDown";
            this.LabMotionDown.Size = new System.Drawing.Size(72, 13);
            this.LabMotionDown.TabIndex = 3;
            this.LabMotionDown.Text = "MotionDown";
            // 
            // LabIOStatus
            // 
            this.LabIOStatus.AutoSize = true;
            this.LabIOStatus.Location = new System.Drawing.Point(35, 105);
            this.LabIOStatus.Name = "LabIOStatus";
            this.LabIOStatus.Size = new System.Drawing.Size(52, 13);
            this.LabIOStatus.TabIndex = 2;
            this.LabIOStatus.Text = "IO Status";
            // 
            // LabFeedbackPos
            // 
            this.LabFeedbackPos.AutoSize = true;
            this.LabFeedbackPos.Location = new System.Drawing.Point(14, 68);
            this.LabFeedbackPos.Name = "LabFeedbackPos";
            this.LabFeedbackPos.Size = new System.Drawing.Size(73, 13);
            this.LabFeedbackPos.TabIndex = 1;
            this.LabFeedbackPos.Text = "Feedback Pos";
            // 
            // LabCommandPos
            // 
            this.LabCommandPos.AutoSize = true;
            this.LabCommandPos.Location = new System.Drawing.Point(8, 31);
            this.LabCommandPos.Name = "LabCommandPos";
            this.LabCommandPos.Size = new System.Drawing.Size(79, 13);
            this.LabCommandPos.TabIndex = 0;
            this.LabCommandPos.Text = "Command Pos";
            // 
            // GrpErrorMsg
            // 
            this.GrpErrorMsg.Controls.Add(this.LstErrMsg);
            this.GrpErrorMsg.Location = new System.Drawing.Point(12, 454);
            this.GrpErrorMsg.Name = "GrpErrorMsg";
            this.GrpErrorMsg.Size = new System.Drawing.Size(562, 68);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 588);
            this.Controls.Add(this.GrpErrorMsg);
            this.Controls.Add(this.GrpStatus);
            this.Controls.Add(this.GrpControl);
            this.Controls.Add(this.GrpHomingSetting);
            this.Controls.Add(this.GrpSetVelProf);
            this.Controls.Add(this.GrpSetNode);
            this.Controls.Add(this.GrpInitial);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "EtherCat Homing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.GrpInitial.ResumeLayout(false);
            this.GrpInitial.PerformLayout();
            this.GrpSetNode.ResumeLayout(false);
            this.GrpSetNode.PerformLayout();
            this.GrpSetVelProf.ResumeLayout(false);
            this.GrpSetVelProf.PerformLayout();
            this.GrpHomingSetting.ResumeLayout(false);
            this.GrpHomingSetting.PerformLayout();
            this.GrpControl.ResumeLayout(false);
            this.GrpStatus.ResumeLayout(false);
            this.GrpStatus.PerformLayout();
            this.GrpErrorMsg.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox GrpSetVelProf;
        private System.Windows.Forms.Label LabFirstVel;
        private System.Windows.Forms.Label LabSecondVel;
        private System.Windows.Forms.Label LabDec;
        private System.Windows.Forms.TextBox TxtFirstVel;
        private System.Windows.Forms.TextBox TxtSecondVel;
        private System.Windows.Forms.TextBox TxtDec;
        private System.Windows.Forms.Label LabFirstVelUnit;
        private System.Windows.Forms.Label LabSecondVelUnit;
        private System.Windows.Forms.Label LabDecUnit;
        private System.Windows.Forms.GroupBox GrpHomingSetting;
        private System.Windows.Forms.Label LabModel;
        private System.Windows.Forms.TextBox TxtMode;
        private System.Windows.Forms.Label LabModeUnit;
        private System.Windows.Forms.Label LabOffset;
        private System.Windows.Forms.TextBox TxtOffset;
        private System.Windows.Forms.Label LabInc;
        private System.Windows.Forms.GroupBox GrpControl;
        private System.Windows.Forms.Button BtnResetAlarm;
        private System.Windows.Forms.RadioButton RdoSVON;
        private System.Windows.Forms.RadioButton RdoSVOFF;
        private System.Windows.Forms.Button BtnResetStatus;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnHoming;
        private System.Windows.Forms.GroupBox GrpStatus;
        private System.Windows.Forms.Label LabCommandPos;
        private System.Windows.Forms.Label LabFeedbackPos;
        private System.Windows.Forms.Label LabIOStatus;
        private System.Windows.Forms.Label LabMotionDown;
        private System.Windows.Forms.TextBox TxtCmdPos;
        private System.Windows.Forms.Label LabCmdPls;
        private System.Windows.Forms.TextBox TxtFbkPos;
        private System.Windows.Forms.Label LabFbkPls;
        private System.Windows.Forms.TextBox TxtIOStatus;
        private System.Windows.Forms.TextBox TxtMotionDown;
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
    }
}

