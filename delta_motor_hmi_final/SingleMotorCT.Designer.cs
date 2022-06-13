namespace EtherCat
{
    partial class SingleMotorCT
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sudubox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.degree1 = new System.Windows.Forms.TextBox();
            this.dccbox = new System.Windows.Forms.TextBox();
            this.accbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.motoroff = new System.Windows.Forms.Button();
            this.mortoron = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // sudubox
            // 
            this.sudubox.Location = new System.Drawing.Point(229, 109);
            this.sudubox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sudubox.Name = "sudubox";
            this.sudubox.Size = new System.Drawing.Size(100, 25);
            this.sudubox.TabIndex = 41;
            this.sudubox.Text = "500000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "PULSE VELOCITY";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NO.1 MOTOR",
            "NO.2 MOTOR",
            "NO.3 MOTOR",
            "CENTER MOTOR"});
            this.comboBox1.Location = new System.Drawing.Point(51, 64);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 28);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // degree1
            // 
            this.degree1.Location = new System.Drawing.Point(229, 210);
            this.degree1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degree1.Name = "degree1";
            this.degree1.Size = new System.Drawing.Size(100, 25);
            this.degree1.TabIndex = 37;
            // 
            // dccbox
            // 
            this.dccbox.Location = new System.Drawing.Point(229, 174);
            this.dccbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dccbox.Name = "dccbox";
            this.dccbox.Size = new System.Drawing.Size(100, 25);
            this.dccbox.TabIndex = 36;
            this.dccbox.Text = "0.1";
            // 
            // accbox
            // 
            this.accbox.Location = new System.Drawing.Point(229, 142);
            this.accbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accbox.Name = "accbox";
            this.accbox.Size = new System.Drawing.Size(100, 25);
            this.accbox.TabIndex = 34;
            this.accbox.Text = "0.1";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 33;
            this.button1.Text = "go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Degree/position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "DECELRATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "ACCELERATION";
            // 
            // motoroff
            // 
            this.motoroff.Cursor = System.Windows.Forms.Cursors.Default;
            this.motoroff.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.motoroff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motoroff.Location = new System.Drawing.Point(249, 269);
            this.motoroff.Margin = new System.Windows.Forms.Padding(4);
            this.motoroff.Name = "motoroff";
            this.motoroff.Size = new System.Drawing.Size(108, 35);
            this.motoroff.TabIndex = 42;
            this.motoroff.Text = "off";
            this.motoroff.UseVisualStyleBackColor = true;
            this.motoroff.Click += new System.EventHandler(this.button2_Click);
            // 
            // mortoron
            // 
            this.mortoron.Cursor = System.Windows.Forms.Cursors.Default;
            this.mortoron.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mortoron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mortoron.Location = new System.Drawing.Point(19, 269);
            this.mortoron.Margin = new System.Windows.Forms.Padding(4);
            this.mortoron.Name = "mortoron";
            this.mortoron.Size = new System.Drawing.Size(108, 35);
            this.mortoron.TabIndex = 43;
            this.mortoron.Text = "on";
            this.mortoron.UseVisualStyleBackColor = true;
            this.mortoron.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(215, 51);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 24);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "LOCATION";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(215, 76);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 24);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DISTANCE";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SingleMotorCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.mortoron);
            this.Controls.Add(this.motoroff);
            this.Controls.Add(this.sudubox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.degree1);
            this.Controls.Add(this.dccbox);
            this.Controls.Add(this.accbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SingleMotorCT";
            this.Size = new System.Drawing.Size(559, 450);
            this.Load += new System.EventHandler(this.SingleMotorCT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sudubox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox degree1;
        private System.Windows.Forms.TextBox dccbox;
        private System.Windows.Forms.TextBox accbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button motoroff;
        private System.Windows.Forms.Button mortoron;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}
