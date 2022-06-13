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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbNode = new System.Windows.Forms.ComboBox();
            this.GrpSetVelProf = new System.Windows.Forms.GroupBox();
            this.CmbRunMode = new System.Windows.Forms.ComboBox();
            this.LabModeUnit = new System.Windows.Forms.Label();
            this.LabTorqueUnit = new System.Windows.Forms.Label();
            this.LabSlopUnit = new System.Windows.Forms.Label();
            this.TxtTorque = new System.Windows.Forms.TextBox();
            this.TxtSlope = new System.Windows.Forms.TextBox();
            this.LabTorque = new System.Windows.Forms.Label();
            this.LabSlop = new System.Windows.Forms.Label();
            this.GrpControl = new System.Windows.Forms.GroupBox();
            this.BtnMoveRight = new System.Windows.Forms.Button();
            this.BtnMoveLeft = new System.Windows.Forms.Button();
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
            this.LabCardNo.Size = new System.Drawing.Size(71, 17);
            this.LabCardNo.TabIndex = 1;
            this.LabCardNo.Text = "Card No :";
            // 
            // CmbCardNo
            // 
            this.CmbCardNo.FormattingEnabled = true;
            this.CmbCardNo.Location = new System.Drawing.Point(186, 28);
            this.CmbCardNo.Name = "CmbCardNo";
            this.CmbCardNo.Size = new System.Drawing.Size(88, 24);
            this.CmbCardNo.TabIndex = 2;
            this.CmbCardNo.SelectedIndexChanged += new System.EventHandler(this.CmbCardNo_SelectedIndexChanged);
            // 
            // LabInitialStatus
            // 
            this.LabInitialStatus.AutoSize = true;
            this.LabInitialStatus.Location = new System.Drawing.Point(287, 33);
            this.LabInitialStatus.Name = "LabInitialStatus";
            this.LabInitialStatus.Size = new System.Drawing.Size(94, 17);
            this.LabInitialStatus.TabIndex = 3;
            this.LabInitialStatus.Text = "Initial Status :";
            // 
            // TxtInitialStatus
            // 
            this.TxtInitialStatus.Location = new System.Drawing.Point(365, 28);
            this.TxtInitialStatus.Name = "TxtInitialStatus";
            this.TxtInitialStatus.ReadOnly = true;
            this.TxtInitialStatus.Size = new System.Drawing.Size(199, 27);
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
            this.LabSlaveNum.Size = new System.Drawing.Size(87, 17);
            this.LabSlaveNum.TabIndex = 6;
            this.LabSlaveNum.Text = "Slave Num :";
            // 
            // TxtSlaveNum
            // 
            this.TxtSlaveNum.Location = new System.Drawing.Point(186, 67);
            this.TxtSlaveNum.Name = "TxtSlaveNum";
            this.TxtSlaveNum.ReadOnly = true;
            this.TxtSlaveNum.Size = new System.Drawing.Size(88, 27);
            this.TxtSlaveNum.TabIndex = 7;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(225, 528);
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
            this.ChkRealTimeUpdate.Size = new System.Drawing.Size(146, 21);
            this.ChkRealTimeUpdate.TabIndex = 8;
            this.ChkRealTimeUpdate.Text = "Real Time Update";
            this.ChkRealTimeUpdate.UseVisualStyleBackColor = true;
            // 
            // CmbSlotID
            // 
            this.CmbSlotID.Enabled = false;
            this.CmbSlotID.FormattingEnabled = true;
            this.CmbSlotID.Location = new System.Drawing.Point(180, 19);
            this.CmbSlotID.Name = "CmbSlotID";
            this.CmbSlotID.Size = new System.Drawing.Size(60, 24);
            this.CmbSlotID.TabIndex = 12;
            this.CmbSlotID.Visible = false;
            // 
            // CmbNodeID
            // 
            this.CmbNodeID.Enabled = false;
            this.CmbNodeID.FormattingEnabled = true;
            this.CmbNodeID.Location = new System.Drawing.Point(74, 19);
            this.CmbNodeID.Name = "CmbNodeID";
            this.CmbNodeID.Size = new System.Drawing.Size(61, 24);
            this.CmbNodeID.TabIndex = 11;
            this.CmbNodeID.Visible = false;
            // 
            // LabSlotID
            // 
            this.LabSlotID.AutoSize = true;
            this.LabSlotID.Location = new System.Drawing.Point(129, 26);
            this.LabSlotID.Name = "LabSlotID";
            this.LabSlotID.Size = new System.Drawing.Size(62, 17);
            this.LabSlotID.TabIndex = 10;
            this.LabSlotID.Text = "Slot ID :";
            this.LabSlotID.Visible = false;
            // 
            // LabNodeID
            // 
            this.LabNodeID.AutoSize = true;
            this.LabNodeID.Location = new System.Drawing.Point(5, 26);
            this.LabNodeID.Name = "LabNodeID";
            this.LabNodeID.Size = new System.Drawing.Size(72, 17);
            this.LabNodeID.TabIndex = 8;
            this.LabNodeID.Text = "Node ID :";
            this.LabNodeID.Visible = false;
            // 
            // GrpSetNode
            // 
            this.GrpSetNode.Controls.Add(this.label1);
            this.GrpSetNode.Controls.Add(this.CmbNode);
            this.GrpSetNode.Controls.Add(this.CmbSlotID);
            this.GrpSetNode.Controls.Add(this.LabSlotID);
            this.GrpSetNode.Controls.Add(this.CmbNodeID);
            this.GrpSetNode.Controls.Add(this.LabNodeID);
            this.GrpSetNode.Location = new System.Drawing.Point(12, 135);
            this.GrpSetNode.Name = "GrpSetNode";
            this.GrpSetNode.Size = new System.Drawing.Size(246, 62);
            this.GrpSetNode.TabIndex = 10;
            this.GrpSetNode.TabStop = false;
            this.GrpSetNode.Text = "2. Set Node";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Node ID :";
            // 
            // CmbNode
            // 
            this.CmbNode.FormattingEnabled = true;
            this.CmbNode.Location = new System.Drawing.Point(82, 38);
            this.CmbNode.Name = "CmbNode";
            this.CmbNode.Size = new System.Drawing.Size(158, 24);
            this.CmbNode.TabIndex = 16;
            this.CmbNode.SelectedIndexChanged += new System.EventHandler(this.CmbNode_SelectedIndexChanged_1);
            // 
            // GrpSetVelProf
            // 
            this.GrpSetVelProf.Controls.Add(this.CmbRunMode);
            this.GrpSetVelProf.Controls.Add(this.LabModeUnit);
            this.GrpSetVelProf.Controls.Add(this.LabTorqueUnit);
            this.GrpSetVelProf.Controls.Add(this.LabSlopUnit);
            this.GrpSetVelProf.Controls.Add(this.TxtTorque);
            this.GrpSetVelProf.Controls.Add(this.TxtSlope);
            this.GrpSetVelProf.Controls.Add(this.LabTorque);
            this.GrpSetVelProf.Controls.Add(this.LabSlop);
            this.GrpSetVelProf.Location = new System.Drawing.Point(12, 203);
            this.GrpSetVelProf.Name = "GrpSetVelProf";
            this.GrpSetVelProf.Size = new System.Drawing.Size(246, 135);
            this.GrpSetVelProf.TabIndex = 11;
            this.GrpSetVelProf.TabStop = false;
            this.GrpSetVelProf.Text = "3. Set Vel. Prof.";
            // 
            // CmbRunMode
            // 
            this.CmbRunMode.FormattingEnabled = true;
            this.CmbRunMode.Items.AddRange(new object[] {
            "0: Liner",
            "1: Sin"});
            this.CmbRunMode.Location = new System.Drawing.Point(56, 95);
            this.CmbRunMode.Name = "CmbRunMode";
            this.CmbRunMode.Size = new System.Drawing.Size(121, 24);
            this.CmbRunMode.TabIndex = 10;
            // 
            // LabModeUnit
            // 
            this.LabModeUnit.AutoSize = true;
            this.LabModeUnit.Location = new System.Drawing.Point(5, 98);
            this.LabModeUnit.Name = "LabModeUnit";
            this.LabModeUnit.Size = new System.Drawing.Size(45, 17);
            this.LabModeUnit.TabIndex = 8;
            this.LabModeUnit.Text = "Mode";
            // 
            // LabTorqueUnit
            // 
            this.LabTorqueUnit.AutoSize = true;
            this.LabTorqueUnit.Location = new System.Drawing.Point(149, 66);
            this.LabTorqueUnit.Name = "LabTorqueUnit";
            this.LabTorqueUnit.Size = new System.Drawing.Size(51, 17);
            this.LabTorqueUnit.TabIndex = 7;
            this.LabTorqueUnit.Text = "0.1%/s";
            // 
            // LabSlopUnit
            // 
            this.LabSlopUnit.AutoSize = true;
            this.LabSlopUnit.Location = new System.Drawing.Point(149, 32);
            this.LabSlopUnit.Name = "LabSlopUnit";
            this.LabSlopUnit.Size = new System.Drawing.Size(51, 17);
            this.LabSlopUnit.TabIndex = 6;
            this.LabSlopUnit.Text = "0.1%/s";
            // 
            // TxtTorque
            // 
            this.TxtTorque.Location = new System.Drawing.Point(47, 62);
            this.TxtTorque.Name = "TxtTorque";
            this.TxtTorque.Size = new System.Drawing.Size(100, 27);
            this.TxtTorque.TabIndex = 4;
            this.TxtTorque.Text = "0";
            // 
            // TxtSlope
            // 
            this.TxtSlope.Location = new System.Drawing.Point(47, 28);
            this.TxtSlope.Name = "TxtSlope";
            this.TxtSlope.Size = new System.Drawing.Size(100, 27);
            this.TxtSlope.TabIndex = 3;
            this.TxtSlope.Text = "0";
            // 
            // LabTorque
            // 
            this.LabTorque.AutoSize = true;
            this.LabTorque.Location = new System.Drawing.Point(8, 67);
            this.LabTorque.Name = "LabTorque";
            this.LabTorque.Size = new System.Drawing.Size(54, 17);
            this.LabTorque.TabIndex = 1;
            this.LabTorque.Text = "Torque";
            // 
            // LabSlop
            // 
            this.LabSlop.AutoSize = true;
            this.LabSlop.Location = new System.Drawing.Point(11, 33);
            this.LabSlop.Name = "LabSlop";
            this.LabSlop.Size = new System.Drawing.Size(37, 17);
            this.LabSlop.TabIndex = 0;
            this.LabSlop.Text = "Slop";
            // 
            // GrpControl
            // 
            this.GrpControl.Controls.Add(this.BtnMoveRight);
            this.GrpControl.Controls.Add(this.BtnMoveLeft);
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
            // BtnMoveRight
            // 
            this.BtnMoveRight.Enabled = false;
            this.BtnMoveRight.Location = new System.Drawing.Point(241, 19);
            this.BtnMoveRight.Name = "BtnMoveRight";
            this.BtnMoveRight.Size = new System.Drawing.Size(61, 43);
            this.BtnMoveRight.TabIndex = 6;
            this.BtnMoveRight.Text = "--->";
            this.BtnMoveRight.UseVisualStyleBackColor = true;
            this.BtnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // BtnMoveLeft
            // 
            this.BtnMoveLeft.Enabled = false;
            this.BtnMoveLeft.Location = new System.Drawing.Point(91, 19);
            this.BtnMoveLeft.Name = "BtnMoveLeft";
            this.BtnMoveLeft.Size = new System.Drawing.Size(61, 43);
            this.BtnMoveLeft.TabIndex = 5;
            this.BtnMoveLeft.Text = "<---";
            this.BtnMoveLeft.UseVisualStyleBackColor = true;
            this.BtnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(158, 19);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(78, 43);
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
            this.BtnResetStatus.Size = new System.Drawing.Size(78, 43);
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
            this.RdoSVOFF.Size = new System.Drawing.Size(78, 43);
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
            this.RdoSVON.Size = new System.Drawing.Size(78, 43);
            this.RdoSVON.TabIndex = 1;
            this.RdoSVON.TabStop = true;
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
            this.BtnResetAlarm.Size = new System.Drawing.Size(78, 43);
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
            this.TxtMotionDown.Location = new System.Drawing.Point(112, 132);
            this.TxtMotionDown.Name = "TxtMotionDown";
            this.TxtMotionDown.ReadOnly = true;
            this.TxtMotionDown.Size = new System.Drawing.Size(140, 27);
            this.TxtMotionDown.TabIndex = 9;
            // 
            // TxtIOStatus
            // 
            this.TxtIOStatus.Location = new System.Drawing.Point(113, 95);
            this.TxtIOStatus.Name = "TxtIOStatus";
            this.TxtIOStatus.ReadOnly = true;
            this.TxtIOStatus.Size = new System.Drawing.Size(139, 27);
            this.TxtIOStatus.TabIndex = 8;
            // 
            // LabFbkPls
            // 
            this.LabFbkPls.AutoSize = true;
            this.LabFbkPls.Location = new System.Drawing.Point(236, 68);
            this.LabFbkPls.Name = "LabFbkPls";
            this.LabFbkPls.Size = new System.Drawing.Size(41, 17);
            this.LabFbkPls.TabIndex = 7;
            this.LabFbkPls.Text = "pluse";
            // 
            // TxtFbkPos
            // 
            this.TxtFbkPos.Location = new System.Drawing.Point(116, 63);
            this.TxtFbkPos.Name = "TxtFbkPos";
            this.TxtFbkPos.ReadOnly = true;
            this.TxtFbkPos.Size = new System.Drawing.Size(139, 27);
            this.TxtFbkPos.TabIndex = 6;
            // 
            // LabCmdPls
            // 
            this.LabCmdPls.AutoSize = true;
            this.LabCmdPls.Location = new System.Drawing.Point(236, 31);
            this.LabCmdPls.Name = "LabCmdPls";
            this.LabCmdPls.Size = new System.Drawing.Size(41, 17);
            this.LabCmdPls.TabIndex = 5;
            this.LabCmdPls.Text = "pluse";
            // 
            // TxtCmdPos
            // 
            this.TxtCmdPos.Location = new System.Drawing.Point(115, 30);
            this.TxtCmdPos.Name = "TxtCmdPos";
            this.TxtCmdPos.ReadOnly = true;
            this.TxtCmdPos.Size = new System.Drawing.Size(139, 27);
            this.TxtCmdPos.TabIndex = 4;
            // 
            // LabMotionDown
            // 
            this.LabMotionDown.AutoSize = true;
            this.LabMotionDown.Location = new System.Drawing.Point(15, 142);
            this.LabMotionDown.Name = "LabMotionDown";
            this.LabMotionDown.Size = new System.Drawing.Size(94, 17);
            this.LabMotionDown.TabIndex = 3;
            this.LabMotionDown.Text = "MotionDown";
            // 
            // LabIOStatus
            // 
            this.LabIOStatus.AutoSize = true;
            this.LabIOStatus.Location = new System.Drawing.Point(35, 105);
            this.LabIOStatus.Name = "LabIOStatus";
            this.LabIOStatus.Size = new System.Drawing.Size(67, 17);
            this.LabIOStatus.TabIndex = 2;
            this.LabIOStatus.Text = "IO Status";
            // 
            // LabFeedbackPos
            // 
            this.LabFeedbackPos.AutoSize = true;
            this.LabFeedbackPos.Location = new System.Drawing.Point(14, 68);
            this.LabFeedbackPos.Name = "LabFeedbackPos";
            this.LabFeedbackPos.Size = new System.Drawing.Size(96, 17);
            this.LabFeedbackPos.TabIndex = 1;
            this.LabFeedbackPos.Text = "Feedback Pos";
            // 
            // LabCommandPos
            // 
            this.LabCommandPos.AutoSize = true;
            this.LabCommandPos.Location = new System.Drawing.Point(8, 31);
            this.LabCommandPos.Name = "LabCommandPos";
            this.LabCommandPos.Size = new System.Drawing.Size(101, 17);
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
            this.LstErrMsg.ItemHeight = 16;
            this.LstErrMsg.Location = new System.Drawing.Point(13, 18);
            this.LstErrMsg.Name = "LstErrMsg";
            this.LstErrMsg.Size = new System.Drawing.Size(543, 36);
            this.LstErrMsg.TabIndex = 0;
            // 
            // TimCheckStatus
            // 
            this.TimCheckStatus.Tick += new System.EventHandler(this.TimCheckStatus_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 582);
            this.Controls.Add(this.GrpErrorMsg);
            this.Controls.Add(this.GrpStatus);
            this.Controls.Add(this.GrpControl);
            this.Controls.Add(this.GrpSetVelProf);
            this.Controls.Add(this.GrpSetNode);
            this.Controls.Add(this.GrpInitial);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "EtherCatSample";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.GrpInitial.ResumeLayout(false);
            this.GrpInitial.PerformLayout();
            this.GrpSetNode.ResumeLayout(false);
            this.GrpSetNode.PerformLayout();
            this.GrpSetVelProf.ResumeLayout(false);
            this.GrpSetVelProf.PerformLayout();
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
        private System.Windows.Forms.Label LabSlop;
        private System.Windows.Forms.Label LabTorque;
        private System.Windows.Forms.TextBox TxtSlope;
        private System.Windows.Forms.TextBox TxtTorque;
        private System.Windows.Forms.Label LabSlopUnit;
        private System.Windows.Forms.Label LabTorqueUnit;
        private System.Windows.Forms.Label LabModeUnit;
        private System.Windows.Forms.GroupBox GrpControl;
        private System.Windows.Forms.Button BtnResetAlarm;
        private System.Windows.Forms.RadioButton RdoSVON;
        private System.Windows.Forms.RadioButton RdoSVOFF;
        private System.Windows.Forms.Button BtnResetStatus;
        private System.Windows.Forms.Button BtnStop;
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
        private System.Windows.Forms.CheckBox ChkRealTimeUpdate;
        private System.Windows.Forms.GroupBox GrpErrorMsg;
        private System.Windows.Forms.ListBox LstErrMsg;
        private System.Windows.Forms.Button BtnMoveLeft;
        private System.Windows.Forms.Button BtnMoveRight;
        private System.Windows.Forms.Timer TimCheckStatus;
        private System.Windows.Forms.ComboBox CmbRunMode;
        private System.Windows.Forms.ComboBox CmbNode;
        private System.Windows.Forms.Label label1;
    }
}

