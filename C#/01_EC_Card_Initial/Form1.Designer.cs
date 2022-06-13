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
            this.LabCardNum = new System.Windows.Forms.Label();
            this.TxtCardNum = new System.Windows.Forms.TextBox();
            this.BtnOpenCard = new System.Windows.Forms.Button();
            this.BtnInitialCard = new System.Windows.Forms.Button();
            this.LabCardNo = new System.Windows.Forms.Label();
            this.CmbCardNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInitialStatus = new System.Windows.Forms.TextBox();
            this.BtnFindSlave = new System.Windows.Forms.Button();
            this.LabSlaveNum = new System.Windows.Forms.Label();
            this.TxtSlaveNum = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TimCheckStatus = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabCardNum
            // 
            this.LabCardNum.AutoSize = true;
            this.LabCardNum.Location = new System.Drawing.Point(175, 27);
            this.LabCardNum.Name = "LabCardNum";
            this.LabCardNum.Size = new System.Drawing.Size(83, 17);
            this.LabCardNum.TabIndex = 0;
            this.LabCardNum.Text = "Card Num :";
            // 
            // TxtCardNum
            // 
            this.TxtCardNum.Location = new System.Drawing.Point(250, 22);
            this.TxtCardNum.Name = "TxtCardNum";
            this.TxtCardNum.ReadOnly = true;
            this.TxtCardNum.Size = new System.Drawing.Size(116, 27);
            this.TxtCardNum.TabIndex = 1;
            // 
            // BtnOpenCard
            // 
            this.BtnOpenCard.Location = new System.Drawing.Point(25, 15);
            this.BtnOpenCard.Name = "BtnOpenCard";
            this.BtnOpenCard.Size = new System.Drawing.Size(137, 33);
            this.BtnOpenCard.TabIndex = 2;
            this.BtnOpenCard.Text = "1. Open Card";
            this.BtnOpenCard.UseVisualStyleBackColor = true;
            this.BtnOpenCard.Click += new System.EventHandler(this.BtnOpenCard_Click);
            // 
            // BtnInitialCard
            // 
            this.BtnInitialCard.Enabled = false;
            this.BtnInitialCard.Location = new System.Drawing.Point(25, 67);
            this.BtnInitialCard.Name = "BtnInitialCard";
            this.BtnInitialCard.Size = new System.Drawing.Size(137, 33);
            this.BtnInitialCard.TabIndex = 3;
            this.BtnInitialCard.Text = "2. Initial Card";
            this.BtnInitialCard.UseVisualStyleBackColor = true;
            this.BtnInitialCard.Click += new System.EventHandler(this.BtnInitialCard_Click);
            // 
            // LabCardNo
            // 
            this.LabCardNo.AutoSize = true;
            this.LabCardNo.Location = new System.Drawing.Point(185, 64);
            this.LabCardNo.Name = "LabCardNo";
            this.LabCardNo.Size = new System.Drawing.Size(71, 17);
            this.LabCardNo.TabIndex = 4;
            this.LabCardNo.Text = "Card No :";
            // 
            // CmbCardNo
            // 
            this.CmbCardNo.Enabled = false;
            this.CmbCardNo.FormattingEnabled = true;
            this.CmbCardNo.Location = new System.Drawing.Point(250, 60);
            this.CmbCardNo.Name = "CmbCardNo";
            this.CmbCardNo.Size = new System.Drawing.Size(116, 24);
            this.CmbCardNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Initial Status :";
            // 
            // TxtInitialStatus
            // 
            this.TxtInitialStatus.Location = new System.Drawing.Point(250, 88);
            this.TxtInitialStatus.Name = "TxtInitialStatus";
            this.TxtInitialStatus.ReadOnly = true;
            this.TxtInitialStatus.Size = new System.Drawing.Size(190, 27);
            this.TxtInitialStatus.TabIndex = 7;
            // 
            // BtnFindSlave
            // 
            this.BtnFindSlave.Enabled = false;
            this.BtnFindSlave.Location = new System.Drawing.Point(25, 118);
            this.BtnFindSlave.Name = "BtnFindSlave";
            this.BtnFindSlave.Size = new System.Drawing.Size(137, 33);
            this.BtnFindSlave.TabIndex = 8;
            this.BtnFindSlave.Text = "Not Initial";
            this.BtnFindSlave.UseVisualStyleBackColor = true;
            this.BtnFindSlave.Click += new System.EventHandler(this.BtnFindSlave_Click);
            // 
            // LabSlaveNum
            // 
            this.LabSlaveNum.AutoSize = true;
            this.LabSlaveNum.Location = new System.Drawing.Point(172, 128);
            this.LabSlaveNum.Name = "LabSlaveNum";
            this.LabSlaveNum.Size = new System.Drawing.Size(87, 17);
            this.LabSlaveNum.TabIndex = 9;
            this.LabSlaveNum.Text = "Slave Num :";
            // 
            // TxtSlaveNum
            // 
            this.TxtSlaveNum.Location = new System.Drawing.Point(250, 123);
            this.TxtSlaveNum.Name = "TxtSlaveNum";
            this.TxtSlaveNum.ReadOnly = true;
            this.TxtSlaveNum.Size = new System.Drawing.Size(116, 27);
            this.TxtSlaveNum.TabIndex = 10;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(141, 175);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(154, 42);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TimCheckStatus
            // 
            this.TimCheckStatus.Tick += new System.EventHandler(this.TimCheckStatus_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 229);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtSlaveNum);
            this.Controls.Add(this.LabSlaveNum);
            this.Controls.Add(this.BtnFindSlave);
            this.Controls.Add(this.TxtInitialStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbCardNo);
            this.Controls.Add(this.LabCardNo);
            this.Controls.Add(this.BtnInitialCard);
            this.Controls.Add(this.BtnOpenCard);
            this.Controls.Add(this.TxtCardNum);
            this.Controls.Add(this.LabCardNum);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "EtherCat Card Initial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabCardNum;
        private System.Windows.Forms.TextBox TxtCardNum;
        private System.Windows.Forms.Button BtnOpenCard;
        private System.Windows.Forms.Button BtnInitialCard;
        private System.Windows.Forms.Label LabCardNo;
        private System.Windows.Forms.ComboBox CmbCardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInitialStatus;
        private System.Windows.Forms.Button BtnFindSlave;
        private System.Windows.Forms.Label LabSlaveNum;
        private System.Windows.Forms.TextBox TxtSlaveNum;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer TimCheckStatus;
    }
}

