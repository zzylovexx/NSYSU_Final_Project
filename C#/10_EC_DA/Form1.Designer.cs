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
            this.GrpEcDAStatus = new System.Windows.Forms.GroupBox();
            this.TrcValue = new System.Windows.Forms.TrackBar();
            this.BtnGetCode = new System.Windows.Forms.Button();
            this.TxtOutValue = new System.Windows.Forms.TextBox();
            this.LabOutValue = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.LabValue = new System.Windows.Forms.Label();
            this.BtnApply = new System.Windows.Forms.Button();
            this.LabReturnCode = new System.Windows.Forms.Label();
            this.CmbDAMode = new System.Windows.Forms.ComboBox();
            this.TxtReturnCode = new System.Windows.Forms.TextBox();
            this.LabDAMode = new System.Windows.Forms.Label();
            this.CmbDAChannel = new System.Windows.Forms.ComboBox();
            this.LabDAChannel = new System.Windows.Forms.Label();
            this.ChkChannel = new System.Windows.Forms.CheckBox();
            this.GrpInitial.SuspendLayout();
            this.GrpSetNode.SuspendLayout();
            this.GrpErrorMsg.SuspendLayout();
            this.GrpEcDAStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrcValue)).BeginInit();
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
            this.BtnExit.Location = new System.Drawing.Point(234, 418);
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
            this.GrpErrorMsg.Location = new System.Drawing.Point(12, 344);
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
            // GrpEcDAStatus
            // 
            this.GrpEcDAStatus.Controls.Add(this.ChkChannel);
            this.GrpEcDAStatus.Controls.Add(this.TrcValue);
            this.GrpEcDAStatus.Controls.Add(this.BtnGetCode);
            this.GrpEcDAStatus.Controls.Add(this.TxtOutValue);
            this.GrpEcDAStatus.Controls.Add(this.LabOutValue);
            this.GrpEcDAStatus.Controls.Add(this.TxtValue);
            this.GrpEcDAStatus.Controls.Add(this.LabValue);
            this.GrpEcDAStatus.Controls.Add(this.BtnApply);
            this.GrpEcDAStatus.Controls.Add(this.LabReturnCode);
            this.GrpEcDAStatus.Controls.Add(this.CmbDAMode);
            this.GrpEcDAStatus.Controls.Add(this.TxtReturnCode);
            this.GrpEcDAStatus.Controls.Add(this.LabDAMode);
            this.GrpEcDAStatus.Controls.Add(this.CmbDAChannel);
            this.GrpEcDAStatus.Controls.Add(this.LabDAChannel);
            this.GrpEcDAStatus.Location = new System.Drawing.Point(12, 179);
            this.GrpEcDAStatus.Name = "GrpEcDAStatus";
            this.GrpEcDAStatus.Size = new System.Drawing.Size(568, 159);
            this.GrpEcDAStatus.TabIndex = 16;
            this.GrpEcDAStatus.TabStop = false;
            this.GrpEcDAStatus.Text = "EcDA Status";
            // 
            // TrcValue
            // 
            this.TrcValue.Enabled = false;
            this.TrcValue.Location = new System.Drawing.Point(11, 111);
            this.TrcValue.Name = "TrcValue";
            this.TrcValue.Size = new System.Drawing.Size(321, 45);
            this.TrcValue.TabIndex = 16;
            this.TrcValue.Scroll += new System.EventHandler(this.TrcValue_Scroll);
            // 
            // BtnGetCode
            // 
            this.BtnGetCode.Enabled = false;
            this.BtnGetCode.Location = new System.Drawing.Point(421, 54);
            this.BtnGetCode.Name = "BtnGetCode";
            this.BtnGetCode.Size = new System.Drawing.Size(75, 23);
            this.BtnGetCode.TabIndex = 15;
            this.BtnGetCode.Text = "Get";
            this.BtnGetCode.UseVisualStyleBackColor = true;
            this.BtnGetCode.Click += new System.EventHandler(this.BtnGetCode_Click);
            // 
            // TxtOutValue
            // 
            this.TxtOutValue.Location = new System.Drawing.Point(232, 80);
            this.TxtOutValue.Name = "TxtOutValue";
            this.TxtOutValue.ReadOnly = true;
            this.TxtOutValue.Size = new System.Drawing.Size(100, 23);
            this.TxtOutValue.TabIndex = 14;
            // 
            // LabOutValue
            // 
            this.LabOutValue.AutoSize = true;
            this.LabOutValue.Location = new System.Drawing.Point(167, 85);
            this.LabOutValue.Name = "LabOutValue";
            this.LabOutValue.Size = new System.Drawing.Size(62, 13);
            this.LabOutValue.TabIndex = 13;
            this.LabOutValue.Text = "Out Value :";
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(53, 80);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.ReadOnly = true;
            this.TxtValue.Size = new System.Drawing.Size(100, 23);
            this.TxtValue.TabIndex = 12;
            // 
            // LabValue
            // 
            this.LabValue.AutoSize = true;
            this.LabValue.Location = new System.Drawing.Point(8, 85);
            this.LabValue.Name = "LabValue";
            this.LabValue.Size = new System.Drawing.Size(41, 13);
            this.LabValue.TabIndex = 11;
            this.LabValue.Text = "Value :";
            // 
            // BtnApply
            // 
            this.BtnApply.Enabled = false;
            this.BtnApply.Location = new System.Drawing.Point(349, 111);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(100, 35);
            this.BtnApply.TabIndex = 10;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // LabReturnCode
            // 
            this.LabReturnCode.AutoSize = true;
            this.LabReturnCode.Location = new System.Drawing.Point(379, 28);
            this.LabReturnCode.Name = "LabReturnCode";
            this.LabReturnCode.Size = new System.Drawing.Size(73, 13);
            this.LabReturnCode.TabIndex = 8;
            this.LabReturnCode.Text = "Return Code :";
            // 
            // CmbDAMode
            // 
            this.CmbDAMode.Enabled = false;
            this.CmbDAMode.FormattingEnabled = true;
            this.CmbDAMode.Items.AddRange(new object[] {
            "0 ~ 5V",
            "0 ~ 10V",
            "-5 ~ 5V",
            "-10 ~ 10V",
            "4 ~ 20mA",
            "0 ~ 20mA",
            "0 ~ 24mA"});
            this.CmbDAMode.Location = new System.Drawing.Point(88, 51);
            this.CmbDAMode.Name = "CmbDAMode";
            this.CmbDAMode.Size = new System.Drawing.Size(121, 21);
            this.CmbDAMode.TabIndex = 3;
            this.CmbDAMode.SelectedIndexChanged += new System.EventHandler(this.CmbADMode_SelectedIndexChanged);
            // 
            // TxtReturnCode
            // 
            this.TxtReturnCode.Location = new System.Drawing.Point(454, 24);
            this.TxtReturnCode.Name = "TxtReturnCode";
            this.TxtReturnCode.ReadOnly = true;
            this.TxtReturnCode.Size = new System.Drawing.Size(100, 23);
            this.TxtReturnCode.TabIndex = 9;
            // 
            // LabDAMode
            // 
            this.LabDAMode.AutoSize = true;
            this.LabDAMode.Location = new System.Drawing.Point(20, 54);
            this.LabDAMode.Name = "LabDAMode";
            this.LabDAMode.Size = new System.Drawing.Size(62, 13);
            this.LabDAMode.TabIndex = 2;
            this.LabDAMode.Text = "AD Mode :";
            // 
            // CmbDAChannel
            // 
            this.CmbDAChannel.Enabled = false;
            this.CmbDAChannel.FormattingEnabled = true;
            this.CmbDAChannel.Items.AddRange(new object[] {
            "CH 0:",
            "CH 1:",
            "CH 2:",
            "CH 3:"});
            this.CmbDAChannel.Location = new System.Drawing.Point(88, 24);
            this.CmbDAChannel.Name = "CmbDAChannel";
            this.CmbDAChannel.Size = new System.Drawing.Size(121, 21);
            this.CmbDAChannel.TabIndex = 1;
            this.CmbDAChannel.SelectedIndexChanged += new System.EventHandler(this.CmbADChannel_SelectedIndexChanged);
            // 
            // LabDAChannel
            // 
            this.LabDAChannel.AutoSize = true;
            this.LabDAChannel.Location = new System.Drawing.Point(9, 27);
            this.LabDAChannel.Name = "LabDAChannel";
            this.LabDAChannel.Size = new System.Drawing.Size(73, 13);
            this.LabDAChannel.TabIndex = 0;
            this.LabDAChannel.Text = "DA Channel :";
            // 
            // ChkChannel
            // 
            this.ChkChannel.AutoSize = true;
            this.ChkChannel.Enabled = false;
            this.ChkChannel.Location = new System.Drawing.Point(216, 27);
            this.ChkChannel.Name = "ChkChannel";
            this.ChkChannel.Size = new System.Drawing.Size(100, 17);
            this.ChkChannel.TabIndex = 17;
            this.ChkChannel.Text = "Enable Channel";
            this.ChkChannel.UseVisualStyleBackColor = true;
            this.ChkChannel.CheckedChanged += new System.EventHandler(this.ChkChannel_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 484);
            this.Controls.Add(this.GrpEcDAStatus);
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
            this.GrpEcDAStatus.ResumeLayout(false);
            this.GrpEcDAStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrcValue)).EndInit();
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
        private System.Windows.Forms.GroupBox GrpEcDAStatus;
        private System.Windows.Forms.Label LabDAChannel;
        private System.Windows.Forms.ComboBox CmbDAChannel;
        private System.Windows.Forms.Label LabDAMode;
        private System.Windows.Forms.ComboBox CmbDAMode;
        private System.Windows.Forms.Label LabReturnCode;
        private System.Windows.Forms.TextBox TxtReturnCode;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Label LabValue;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.TextBox TxtOutValue;
        private System.Windows.Forms.Label LabOutValue;
        private System.Windows.Forms.Button BtnGetCode;
        private System.Windows.Forms.TrackBar TrcValue;
        private System.Windows.Forms.CheckBox ChkChannel;
    }
}

