namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblShowInfo = new System.Windows.Forms.Label();
            this.txtShowInfo = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblShowText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCommand
            // 
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "系统重启",
            "立即更新",
            "更新IP:22222",
            "更新Wifi:3333",
            "更新ntp:33333"});
            this.cmbCommand.Location = new System.Drawing.Point(171, 24);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(121, 20);
            this.cmbCommand.TabIndex = 20;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(480, 83);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(102, 21);
            this.txtPort.TabIndex = 17;
            this.txtPort.Text = "8899";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(409, 86);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(65, 12);
            this.lblPort.TabIndex = 16;
            this.lblPort.Text = "接收方端口";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(65, 86);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(77, 12);
            this.lblAdress.TabIndex = 14;
            this.lblAdress.Text = "接收方IP地址";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(146, 83);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(257, 21);
            this.txtAdress.TabIndex = 15;
            this.txtAdress.Text = "127.0.0.1";
            // 
            // lblShowInfo
            // 
            this.lblShowInfo.AutoSize = true;
            this.lblShowInfo.Location = new System.Drawing.Point(66, 140);
            this.lblShowInfo.Name = "lblShowInfo";
            this.lblShowInfo.Size = new System.Drawing.Size(53, 12);
            this.lblShowInfo.TabIndex = 18;
            this.lblShowInfo.Text = "收到信息";
            // 
            // txtShowInfo
            // 
            this.txtShowInfo.Location = new System.Drawing.Point(146, 125);
            this.txtShowInfo.Multiline = true;
            this.txtShowInfo.Name = "txtShowInfo";
            this.txtShowInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShowInfo.Size = new System.Drawing.Size(357, 147);
            this.txtShowInfo.TabIndex = 19;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(66, 28);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 12);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "要发送信息";
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(499, 24);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 23);
            this.btnMessage.TabIndex = 13;
            this.btnMessage.Text = "发送";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblShowText
            // 
            this.lblShowText.AutoSize = true;
            this.lblShowText.Location = new System.Drawing.Point(119, 305);
            this.lblShowText.Name = "lblShowText";
            this.lblShowText.Size = new System.Drawing.Size(41, 12);
            this.lblShowText.TabIndex = 21;
            this.lblShowText.Text = "label1";
            this.lblShowText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 326);
            this.Controls.Add(this.lblShowText);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblShowInfo);
            this.Controls.Add(this.txtShowInfo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblShowInfo;
        private System.Windows.Forms.TextBox txtShowInfo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lblShowText;
    }
}

