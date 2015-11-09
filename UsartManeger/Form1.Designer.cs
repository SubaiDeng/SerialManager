namespace UsartManeger
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.option1 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.PortCom = new System.Windows.Forms.ComboBox();
            this.BauCom = new System.Windows.Forms.ComboBox();
            this.CheckCom = new System.Windows.Forms.ComboBox();
            this.DataCom = new System.Windows.Forms.ComboBox();
            this.StopCom = new System.Windows.Forms.ComboBox();
            this.option5 = new System.Windows.Forms.Label();
            this.option4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.SendBox = new System.Windows.Forms.RichTextBox();
            this.RecieveBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SendClean = new System.Windows.Forms.Button();
            this.RecieveClean = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.EmptyBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EnterBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Location = new System.Drawing.Point(21, 25);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(41, 12);
            this.option1.TabIndex = 0;
            this.option1.Text = "端口：";
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(9, 51);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(53, 12);
            this.option2.TabIndex = 1;
            this.option2.Text = "波特率：";
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Location = new System.Drawing.Point(9, 78);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(53, 12);
            this.option3.TabIndex = 2;
            this.option3.Text = "校验位：";
            // 
            // PortCom
            // 
            this.PortCom.FormattingEnabled = true;
            this.PortCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.PortCom.Location = new System.Drawing.Point(59, 22);
            this.PortCom.Name = "PortCom";
            this.PortCom.Size = new System.Drawing.Size(88, 20);
            this.PortCom.TabIndex = 3;
            this.PortCom.DropDown += new System.EventHandler(this.PortCom_DropDown);
            this.PortCom.TextChanged += new System.EventHandler(this.ComboBox1_TextChanged);
            // 
            // BauCom
            // 
            this.BauCom.FormattingEnabled = true;
            this.BauCom.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200",
            "128000",
            "230400",
            "256000",
            "460800"});
            this.BauCom.Location = new System.Drawing.Point(59, 48);
            this.BauCom.Name = "BauCom";
            this.BauCom.Size = new System.Drawing.Size(88, 20);
            this.BauCom.TabIndex = 4;
            this.BauCom.Text = "115200";
            this.BauCom.TextChanged += new System.EventHandler(this.BauCom_TextChanged);
            // 
            // CheckCom
            // 
            this.CheckCom.FormattingEnabled = true;
            this.CheckCom.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CheckCom.Location = new System.Drawing.Point(59, 74);
            this.CheckCom.Name = "CheckCom";
            this.CheckCom.Size = new System.Drawing.Size(88, 20);
            this.CheckCom.TabIndex = 5;
            this.CheckCom.Text = "None";
            this.CheckCom.SelectedIndexChanged += new System.EventHandler(this.CheckCom_SelectedIndexChanged);
            this.CheckCom.TextChanged += new System.EventHandler(this.CheckCom_TextChanged);
            // 
            // DataCom
            // 
            this.DataCom.FormattingEnabled = true;
            this.DataCom.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.DataCom.Location = new System.Drawing.Point(59, 100);
            this.DataCom.Name = "DataCom";
            this.DataCom.Size = new System.Drawing.Size(88, 20);
            this.DataCom.TabIndex = 6;
            this.DataCom.Text = "8";
            this.DataCom.SelectedIndexChanged += new System.EventHandler(this.DataCom_SelectedIndexChanged);
            this.DataCom.TextChanged += new System.EventHandler(this.DataCom_TextChanged);
            // 
            // StopCom
            // 
            this.StopCom.FormattingEnabled = true;
            this.StopCom.Items.AddRange(new object[] {
            "1",
            "2"});
            this.StopCom.Location = new System.Drawing.Point(59, 126);
            this.StopCom.Name = "StopCom";
            this.StopCom.Size = new System.Drawing.Size(88, 20);
            this.StopCom.TabIndex = 7;
            this.StopCom.Text = "1";
            this.StopCom.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // option5
            // 
            this.option5.AutoSize = true;
            this.option5.Location = new System.Drawing.Point(9, 129);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(53, 12);
            this.option5.TabIndex = 9;
            this.option5.Text = "停止位：";
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Location = new System.Drawing.Point(9, 103);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(53, 12);
            this.option4.TabIndex = 8;
            this.option4.Text = "数据位：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "串口";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "未打开";
            // 
            // InputBox
            // 
            this.InputBox.DetectUrls = false;
            this.InputBox.Location = new System.Drawing.Point(161, 292);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(461, 81);
            this.InputBox.TabIndex = 14;
            this.InputBox.Text = "";
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(160, 47);
            this.SendBox.Name = "SendBox";
            this.SendBox.ReadOnly = true;
            this.SendBox.Size = new System.Drawing.Size(222, 228);
            this.SendBox.TabIndex = 15;
            this.SendBox.Text = "";
            this.SendBox.TextChanged += new System.EventHandler(this.SendBox_TextChanged);
            // 
            // RecieveBox
            // 
            this.RecieveBox.Location = new System.Drawing.Point(400, 48);
            this.RecieveBox.Name = "RecieveBox";
            this.RecieveBox.ReadOnly = true;
            this.RecieveBox.Size = new System.Drawing.Size(222, 228);
            this.RecieveBox.TabIndex = 16;
            this.RecieveBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "发送区：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "接收区：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "数据发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SendClean
            // 
            this.SendClean.Location = new System.Drawing.Point(327, 22);
            this.SendClean.Name = "SendClean";
            this.SendClean.Size = new System.Drawing.Size(56, 21);
            this.SendClean.TabIndex = 20;
            this.SendClean.Text = "清空";
            this.SendClean.UseVisualStyleBackColor = true;
            this.SendClean.Click += new System.EventHandler(this.SendClean_Click);
            // 
            // RecieveClean
            // 
            this.RecieveClean.Location = new System.Drawing.Point(566, 22);
            this.RecieveClean.Name = "RecieveClean";
            this.RecieveClean.Size = new System.Drawing.Size(56, 21);
            this.RecieveClean.TabIndex = 21;
            this.RecieveClean.Text = "清空";
            this.RecieveClean.UseVisualStyleBackColor = true;
            this.RecieveClean.Click += new System.EventHandler(this.RecieveClean_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(94, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 21);
            this.button5.TabIndex = 22;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 329);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 16);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "HEX发送";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EmptyBox
            // 
            this.EmptyBox.AutoSize = true;
            this.EmptyBox.Checked = true;
            this.EmptyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EmptyBox.Location = new System.Drawing.Point(10, 354);
            this.EmptyBox.Name = "EmptyBox";
            this.EmptyBox.Size = new System.Drawing.Size(72, 16);
            this.EmptyBox.TabIndex = 24;
            this.EmptyBox.Text = "自动清空";
            this.EmptyBox.UseVisualStyleBackColor = true;
            this.EmptyBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 27;
            // 
            // EnterBox
            // 
            this.EnterBox.AutoSize = true;
            this.EnterBox.Location = new System.Drawing.Point(10, 303);
            this.EnterBox.Name = "EnterBox";
            this.EnterBox.Size = new System.Drawing.Size(72, 16);
            this.EnterBox.TabIndex = 28;
            this.EnterBox.Text = "回车发送";
            this.EnterBox.UseVisualStyleBackColor = true;
            this.EnterBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(75, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 31);
            this.button3.TabIndex = 29;
            this.button3.Text = "关闭串口";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "已发送";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "已接收";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 12);
            this.label12.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 385);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EnterBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmptyBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RecieveClean);
            this.Controls.Add(this.SendClean);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecieveBox);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.PortCom);
            this.Controls.Add(this.option5);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.StopCom);
            this.Controls.Add(this.DataCom);
            this.Controls.Add(this.CheckCom);
            this.Controls.Add(this.BauCom);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.ComboBox PortCom;
        private System.Windows.Forms.ComboBox BauCom;
        private System.Windows.Forms.ComboBox CheckCom;
        private System.Windows.Forms.ComboBox DataCom;
        private System.Windows.Forms.ComboBox StopCom;
        private System.Windows.Forms.Label option5;
        private System.Windows.Forms.Label option4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.RichTextBox SendBox;
        private System.Windows.Forms.RichTextBox RecieveBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SendClean;
        private System.Windows.Forms.Button RecieveClean;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox EmptyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox EnterBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

