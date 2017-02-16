namespace _201604RFID
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置IPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置锚点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置距离文件路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startOrStop = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.HintMessage = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setIPToolStripMenuItem,
            this.startOrStop,
            this.保存ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // setIPToolStripMenuItem
            // 
            this.setIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置IPToolStripMenuItem,
            this.设置锚点ToolStripMenuItem,
            this.设置距离文件路径ToolStripMenuItem});
            this.setIPToolStripMenuItem.Name = "setIPToolStripMenuItem";
            this.setIPToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.setIPToolStripMenuItem.Text = "初始设置";
            this.setIPToolStripMenuItem.Click += new System.EventHandler(this.setIPToolStripMenuItem_Click);
            // 
            // 设置IPToolStripMenuItem
            // 
            this.设置IPToolStripMenuItem.Name = "设置IPToolStripMenuItem";
            this.设置IPToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.设置IPToolStripMenuItem.Text = "设置IP";
            this.设置IPToolStripMenuItem.Click += new System.EventHandler(this.设置IPToolStripMenuItem_Click);
            // 
            // 设置锚点ToolStripMenuItem
            // 
            this.设置锚点ToolStripMenuItem.Name = "设置锚点ToolStripMenuItem";
            this.设置锚点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.设置锚点ToolStripMenuItem.Text = "调整参考点";
            this.设置锚点ToolStripMenuItem.Click += new System.EventHandler(this.设置锚点ToolStripMenuItem_Click);
            // 
            // 设置距离文件路径ToolStripMenuItem
            // 
            this.设置距离文件路径ToolStripMenuItem.Name = "设置距离文件路径ToolStripMenuItem";
            this.设置距离文件路径ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.设置距离文件路径ToolStripMenuItem.Text = "选择距离文件路径";
            this.设置距离文件路径ToolStripMenuItem.Click += new System.EventHandler(this.设置距离文件路径ToolStripMenuItem_Click);
            // 
            // startOrStop
            // 
            this.startOrStop.Name = "startOrStop";
            this.startOrStop.Size = new System.Drawing.Size(44, 21);
            this.startOrStop.Text = "运行";
            this.startOrStop.Click += new System.EventHandler(this.运行ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // HintMessage
            // 
            this.HintMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HintMessage.Location = new System.Drawing.Point(14, 437);
            this.HintMessage.Multiline = true;
            this.HintMessage.Name = "HintMessage";
            this.HintMessage.Size = new System.Drawing.Size(880, 95);
            this.HintMessage.TabIndex = 4;
            this.HintMessage.Text = "日志信息";
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 358);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "载入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 409);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "标签号：";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HintMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置IPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置距离文件路径ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HintMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem startOrStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置锚点ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

