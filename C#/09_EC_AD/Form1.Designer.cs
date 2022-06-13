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
            this.LabNodeID = new System.Windows.Forms.Label();
            this.GrpSetNode = new System.Windows.Forms.GroupBox();
            this.CmbNode = new System.Windows.Forms.ComboBox();
            this.GrpErrorMsg = new System.Windows.Forms.GroupBox();
            this.LstErrMsg = new System.Windows.Forms.ListBox();
            this.TimCheckStatus = new System.Windows.Forms.Timer(this.components);
            this.GrpEcADStatus = new System.Windows.Forms.GroupBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.LabData = new System.Windows.Forms.Label();
            this.CmbConversionTime = new System.Windows.Forms.ComboBox();
            this.LabConversionTimes = new System.Windows.Forms.Label();
            this.CmbAvgRange = new System.Windows.Forms.ComboBox();
            this.LabAvgRange = new System.Windows.Forms.Label();
            this.CmbADMode = new System.Windows.Forms.ComboBox();
            this.LabADMode = new System.Windows.Forms.Label();
            this.CmbADChannel = new System.Windows.Forms.ComboBox();
            this.LabADChannel = new System.Windows.Forms.Label();
            this.GrpInitial.SuspendLayout();
            this.GrpSetNode.SuspendLayout();
            this.GrpErrorMsg.SuspendLayout();
            this.GrpEcADStatus.SuspendLayout();
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
            this.BtnFindSlave.Text = "Not Initial";
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
            // LabNodeID
            // 
            this.LabNodeID.AutoSize = true;
            this.LabNodeID.Location = new System.Drawing.Point(5, 24);
            this.LabNodeID.Name = "LabNodeID";
            this.LabNodeID.Size = new System.Drawing.Size(55, 13);
            this.LabNodeID.TabIndex = 8;
            this.LabNodeID.Text = "Node ID :";
            // 
            // GrpSetNode
            // 
            this.GrpSetNode.Controls.Add(this.CmbNode);
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
            // GrpEcADStatus
            // 
            this.GrpEcADStatus.Controls.Add(this.TxtData);
            this.GrpEcADStatus.Controls.Add(this.LabData);
            this.GrpEcADStatus.Controls.Add(this.CmbConversionTime);
            this.GrpEcADStatus.Controls.Add(this.LabConversionTimes);
            this.GrpEcADStatus.Controls.Add(this.CmbAvgRange);
            this.GrpEcADStatus.Controls.Add(this.LabAvgRange);
            this.GrpEcADStatus.Controls.Add(this.CmbADMode);
            this.GrpEcADStatus.Controls.Add(this.LabADMode);
            this.GrpEcADStatus.Controls.Add(this.CmbADChannel);
            this.GrpEcADStatus.Controls.Add(this.LabADChannel);
            this.GrpEcADStatus.Location = new System.Drawing.Point(12, 179);
            this.GrpEcADStatus.Name = "GrpEcADStatus";
            this.GrpEcADStatus.Size = new System.Drawing.Size(568, 114);
            this.GrpEcADStatus.TabIndex = 16;
            this.GrpEcADStatus.TabStop = false;
            this.GrpEcADStatus.Text = "EcAD Status";
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(457, 51);
            this.TxtData.Name = "TxtData";
            this.TxtData.ReadOnly = true;
            this.TxtData.Size = new System.Drawing.Size(100, 23);
            this.TxtData.TabIndex = 9;
            // 
            // LabData
            // 
            this.LabData.AutoSize = true;
            this.LabData.Location = new System.Drawing.Point(457, 35);
            this.LabData.Name = "LabData";
            this.LabData.Size = new System.Drawing.Size(35, 13);
            this.LabData.TabIndex = 8;
            this.LabData.Text = "Data :";
            // 
            // CmbConversionTime
            // 
            this.CmbConversionTime.Enabled = false;
            this.CmbConversionTime.FormattingEnabled = true;
            this.CmbConversionTime.Items.AddRange(new object[] {
            "0: 200 kHz",
            "1: 100 kHz",
            "2: 50 kHz",
            "3: 25 kHz",
            "4: 12.5 kHz",
            "5: 6.25 kHz",
            "6: 3.125 kHz"});
            this.CmbConversionTime.Location = new System.Drawing.Point(330, 65);
            this.CmbConversionTime.Name = "CmbConversionTime";
            this.CmbConversionTime.Size = new System.Drawing.Size(121, 21);
            this.CmbConversionTime.TabIndex = 7;
            this.CmbConversionTime.SelectedIndexChanged += new System.EventHandler(this.CmbConversionTime_SelectedIndexChanged);
            // 
            // LabConversionTimes
            // 
            this.LabConversionTimes.AutoSize = true;
            this.LabConversionTimes.Location = new System.Drawing.Point(233, 68);
            this.LabConversionTimes.Name = "LabConversionTimes";
            this.LabConversionTimes.Size = new System.Drawing.Size(93, 13);
            this.LabConversionTimes.TabIndex = 6;
            this.LabConversionTimes.Text = "Conversion Time:";
            // 
            // CmbAvgRange
            // 
            this.CmbAvgRange.Enabled = false;
            this.CmbAvgRange.FormattingEnabled = true;
            this.CmbAvgRange.Items.AddRange(new object[] {
            "0: Not Avg",
            "1: 2 times",
            "2: 4 times",
            "3: 8 times",
            "4: 16 times",
            "5: 32 times",
            "6: 64 times"});
            this.CmbAvgRange.Location = new System.Drawing.Point(330, 27);
            this.CmbAvgRange.Name = "CmbAvgRange";
            this.CmbAvgRange.Size = new System.Drawing.Size(121, 21);
            this.CmbAvgRange.TabIndex = 5;
            this.CmbAvgRange.SelectedIndexChanged += new System.EventHandler(this.CmbAvgRange_SelectedIndexChanged);
            // 
            // LabAvgRange
            // 
            this.LabAvgRange.AutoSize = true;
            this.LabAvgRange.Location = new System.Drawing.Point(259, 30);
            this.LabAvgRange.Name = "LabAvgRange";
            this.LabAvgRange.Size = new System.Drawing.Size(67, 13);
            this.LabAvgRange.TabIndex = 4;
            this.LabAvgRange.Text = "Avg Range :";
            // 
            // CmbADMode
            // 
            this.CmbADMode.Enabled = false;
            this.CmbADMode.FormattingEnabled = true;
            this.CmbADMode.Items.AddRange(new object[] {
            "-5 ~ 5V",
            "-10 ~ 10V"});
            this.CmbADMode.Location = new System.Drawing.Point(92, 65);
            this.CmbADMode.Name = "CmbADMode";
            this.CmbADMode.Size = new System.Drawing.Size(121, 21);
            this.CmbADMode.TabIndex = 3;
            this.CmbADMode.SelectedIndexChanged += new System.EventHandler(this.CmbADMode_SelectedIndexChanged);
            // 
            // LabADMode
            // 
            this.LabADMode.AutoSize = true;
            this.LabADMode.Location = new System.Drawing.Point(24, 68);
            this.LabADMode.Name = "LabADMode";
            this.LabADMode.Size = new System.Drawing.Size(62, 13);
            this.LabADMode.TabIndex = 2;
            this.LabADMode.Text = "AD Mode :";
            // 
            // CmbADChannel
            // 
            this.CmbADChannel.Enabled = false;
            this.CmbADChannel.FormattingEnabled = true;
            this.CmbADChannel.Items.AddRange(new object[] {
            "CH 0:",
            "CH 1:",
            "CH 2:",
            "CH 3:"});
            this.CmbADChannel.Location = new System.Drawing.Point(92, 27);
            this.CmbADChannel.Name = "CmbADChannel";
            this.CmbADChannel.Size = new System.Drawing.Size(121, 21);
            this.CmbADChannel.TabIndex = 1;
            this.CmbADChannel.SelectedIndexChanged += new System.EventHandler(this.CmbADChannel_SelectedIndexChanged);
            // 
            // LabADChannel
            // 
            this.LabADChannel.AutoSize = true;
            this.LabADChannel.Location = new System.Drawing.Point(13, 30);
            this.LabADChannel.Name = "LabADChannel";
            this.LabADChannel.Size = new System.Drawing.Size(73, 13);
            this.LabADChannel.TabIndex = 0;
            this.LabADChannel.Text = "AD Channel :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 438);
            this.Controls.Add(this.GrpEcADStatus);
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
            this.GrpEcADStatus.ResumeLayout(false);
            this.GrpEcADStatus.PerformLayout();
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
        private System.Windows.Forms.ComboBox CmbNode;
        private System.Windows.Forms.CheckBox ChkRealTimeUpdate;
        private System.Windows.Forms.GroupBox GrpErrorMsg;
        private System.Windows.Forms.ListBox LstErrMsg;
        private System.Windows.Forms.Timer TimCheckStatus;
        private System.Windows.Forms.GroupBox GrpEcADStatus;
        private System.Windows.Forms.Label LabADChannel;
        private System.Windows.Forms.ComboBox CmbADChannel;
        private System.Windows.Forms.Label LabADMode;
        private System.Windows.Forms.ComboBox CmbADMode;
        private System.Windows.Forms.Label LabAvgRange;
        private System.Windows.Forms.ComboBox CmbAvgRange;
        private System.Windows.Forms.ComboBox CmbConversionTime;
        private System.Windows.Forms.Label LabConversionTimes;
        private System.Windows.Forms.Label LabData;
        private System.Windows.Forms.TextBox TxtData;
    }
}

