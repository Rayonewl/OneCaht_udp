namespace OneChat
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_LocalPort = new System.Windows.Forms.TextBox();
            this.tB_LocalIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_RemotePort = new System.Windows.Forms.TextBox();
            this.tB_RemoteIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtB_RecvMsg = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtB_SendMsg = new System.Windows.Forms.RichTextBox();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lb_Statu = new System.Windows.Forms.Label();
            this.cB_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ClrSendMsg = new System.Windows.Forms.Button();
            this.btn_ClrRecvMsg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_LocalPort);
            this.groupBox1.Controls.Add(this.tB_LocalIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "本机信息";
            // 
            // tB_LocalPort
            // 
            this.tB_LocalPort.Location = new System.Drawing.Point(68, 60);
            this.tB_LocalPort.Name = "tB_LocalPort";
            this.tB_LocalPort.Size = new System.Drawing.Size(56, 25);
            this.tB_LocalPort.TabIndex = 3;
            this.tB_LocalPort.Text = "10000";
            // 
            // tB_LocalIp
            // 
            this.tB_LocalIp.Location = new System.Drawing.Point(68, 26);
            this.tB_LocalIp.Name = "tB_LocalIp";
            this.tB_LocalIp.Size = new System.Drawing.Size(112, 25);
            this.tB_LocalIp.TabIndex = 1;
            this.tB_LocalIp.Text = "192.168.0.110";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_RemotePort);
            this.groupBox2.Controls.Add(this.tB_RemoteIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(39, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "对方信息";
            // 
            // tB_RemotePort
            // 
            this.tB_RemotePort.Location = new System.Drawing.Point(68, 63);
            this.tB_RemotePort.Name = "tB_RemotePort";
            this.tB_RemotePort.Size = new System.Drawing.Size(54, 25);
            this.tB_RemotePort.TabIndex = 3;
            this.tB_RemotePort.Text = "10000";
            // 
            // tB_RemoteIp
            // 
            this.tB_RemoteIp.Location = new System.Drawing.Point(68, 30);
            this.tB_RemoteIp.Name = "tB_RemoteIp";
            this.tB_RemoteIp.Size = new System.Drawing.Size(116, 25);
            this.tB_RemoteIp.TabIndex = 1;
            this.tB_RemoteIp.Text = "192.168.0.110";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtB_RecvMsg);
            this.groupBox3.Location = new System.Drawing.Point(290, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 279);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RecvMessage";
            // 
            // rtB_RecvMsg
            // 
            this.rtB_RecvMsg.Location = new System.Drawing.Point(6, 24);
            this.rtB_RecvMsg.Name = "rtB_RecvMsg";
            this.rtB_RecvMsg.Size = new System.Drawing.Size(398, 249);
            this.rtB_RecvMsg.TabIndex = 0;
            this.rtB_RecvMsg.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtB_SendMsg);
            this.groupBox4.Location = new System.Drawing.Point(290, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 102);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SendMessage";
            // 
            // rtB_SendMsg
            // 
            this.rtB_SendMsg.Location = new System.Drawing.Point(6, 24);
            this.rtB_SendMsg.Name = "rtB_SendMsg";
            this.rtB_SendMsg.Size = new System.Drawing.Size(398, 72);
            this.rtB_SendMsg.TabIndex = 0;
            this.rtB_SendMsg.Text = "";
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(589, 493);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(105, 52);
            this.btn_SendMsg.TabIndex = 6;
            this.btn_SendMsg.Text = "Send";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.btn_SendMsg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Statu:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lb_Statu);
            this.groupBox5.Controls.Add(this.cB_type);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(39, 337);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(221, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mode";
            // 
            // lb_Statu
            // 
            this.lb_Statu.AutoSize = true;
            this.lb_Statu.BackColor = System.Drawing.Color.Red;
            this.lb_Statu.Location = new System.Drawing.Point(69, 64);
            this.lb_Statu.Name = "lb_Statu";
            this.lb_Statu.Size = new System.Drawing.Size(23, 15);
            this.lb_Statu.TabIndex = 9;
            this.lb_Statu.Text = "No";
            // 
            // cB_type
            // 
            this.cB_type.FormattingEnabled = true;
            this.cB_type.Items.AddRange(new object[] {
            "UDP",
            "TCP Client",
            "TCP Sever"});
            this.cB_type.Location = new System.Drawing.Point(68, 31);
            this.cB_type.Name = "cB_type";
            this.cB_type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cB_type.Size = new System.Drawing.Size(94, 23);
            this.cB_type.TabIndex = 1;
            this.cB_type.Text = "UDP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type:";
            // 
            // btn_ClrSendMsg
            // 
            this.btn_ClrSendMsg.Location = new System.Drawing.Point(296, 504);
            this.btn_ClrSendMsg.Name = "btn_ClrSendMsg";
            this.btn_ClrSendMsg.Size = new System.Drawing.Size(86, 41);
            this.btn_ClrSendMsg.TabIndex = 10;
            this.btn_ClrSendMsg.Text = "清除发送";
            this.btn_ClrSendMsg.UseVisualStyleBackColor = true;
            this.btn_ClrSendMsg.Click += new System.EventHandler(this.btn_ClrSendMsg_Click);
            // 
            // btn_ClrRecvMsg
            // 
            this.btn_ClrRecvMsg.Location = new System.Drawing.Point(408, 504);
            this.btn_ClrRecvMsg.Name = "btn_ClrRecvMsg";
            this.btn_ClrRecvMsg.Size = new System.Drawing.Size(86, 41);
            this.btn_ClrRecvMsg.TabIndex = 11;
            this.btn_ClrRecvMsg.Text = "清除接收";
            this.btn_ClrRecvMsg.UseVisualStyleBackColor = true;
            this.btn_ClrRecvMsg.Click += new System.EventHandler(this.btn_ClrRecvMsg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(738, 568);
            this.Controls.Add(this.btn_ClrRecvMsg);
            this.Controls.Add(this.btn_ClrSendMsg);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_SendMsg);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "OneChat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtB_RecvMsg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtB_SendMsg;
        private System.Windows.Forms.Button btn_SendMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cB_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ClrSendMsg;
        public System.Windows.Forms.TextBox tB_LocalPort;
        public System.Windows.Forms.TextBox tB_LocalIp;
        public System.Windows.Forms.TextBox tB_RemotePort;
        public System.Windows.Forms.TextBox tB_RemoteIp;
        private System.Windows.Forms.Label lb_Statu;
        private System.Windows.Forms.Button btn_ClrRecvMsg;
    }
}

