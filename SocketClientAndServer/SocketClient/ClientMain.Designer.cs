namespace SocketClient
{
    partial class ClientMain
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
            this.btnMessage = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtShowInfo = new System.Windows.Forms.TextBox();
            this.lblShowInfo = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblShowText = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(445, 51);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 23);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "发送";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 55);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 12);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "要发送信息";
            // 
            // txtShowInfo
            // 
            this.txtShowInfo.Location = new System.Drawing.Point(92, 152);
            this.txtShowInfo.Multiline = true;
            this.txtShowInfo.Name = "txtShowInfo";
            this.txtShowInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShowInfo.Size = new System.Drawing.Size(357, 177);
            this.txtShowInfo.TabIndex = 8;
            // 
            // lblShowInfo
            // 
            this.lblShowInfo.AutoSize = true;
            this.lblShowInfo.Location = new System.Drawing.Point(12, 167);
            this.lblShowInfo.Name = "lblShowInfo";
            this.lblShowInfo.Size = new System.Drawing.Size(53, 12);
            this.lblShowInfo.TabIndex = 7;
            this.lblShowInfo.Text = "收到信息";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(92, 110);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(257, 21);
            this.txtAdress.TabIndex = 4;
            this.txtAdress.Text = "127.0.0.1";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(11, 113);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(77, 12);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "接收方IP地址";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(355, 113);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(65, 12);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "接收方端口";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(426, 110);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(102, 21);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "8899";
            // 
            // lblShowText
            // 
            this.lblShowText.AutoSize = true;
            this.lblShowText.Location = new System.Drawing.Point(14, 350);
            this.lblShowText.Name = "lblShowText";
            this.lblShowText.Size = new System.Drawing.Size(0, 12);
            this.lblShowText.TabIndex = 9;
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
            this.cmbCommand.Location = new System.Drawing.Point(117, 51);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(121, 20);
            this.cmbCommand.TabIndex = 11;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 390);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.lblShowText);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblShowInfo);
            this.Controls.Add(this.txtShowInfo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnMessage);
            this.Name = "ClientMain";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtShowInfo;
        private System.Windows.Forms.Label lblShowInfo;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblShowText;
        private System.Windows.Forms.ComboBox cmbCommand;
    }
}

