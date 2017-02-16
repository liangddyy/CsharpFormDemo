namespace 打字游戏
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMenuItemMain = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemPause = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemLife = new System.Windows.Forms.ToolStripMenuItem();
            this.timerrate = new System.Windows.Forms.Timer(this.components);
            this.timerlab = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItemMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMenuItemMain
            // 
            this.TSMenuItemMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItemStart,
            this.TSMenuItemPause,
            this.TSMenuItemLife});
            this.TSMenuItemMain.Name = "TSMenuItemMain";
            this.TSMenuItemMain.Size = new System.Drawing.Size(68, 21);
            this.TSMenuItemMain.Text = "游戏控制";
            // 
            // TSMenuItemStart
            // 
            this.TSMenuItemStart.Name = "TSMenuItemStart";
            this.TSMenuItemStart.Size = new System.Drawing.Size(169, 22);
            this.TSMenuItemStart.Text = "开始";
            this.TSMenuItemStart.Click += new System.EventHandler(this.TSMenuItemStart_Click);
            // 
            // TSMenuItemPause
            // 
            this.TSMenuItemPause.Name = "TSMenuItemPause";
            this.TSMenuItemPause.Size = new System.Drawing.Size(169, 22);
            this.TSMenuItemPause.Text = "暂停";
            this.TSMenuItemPause.Click += new System.EventHandler(this.TSMenuItemPause_Click);
            // 
            // TSMenuItemLife
            // 
            this.TSMenuItemLife.Name = "TSMenuItemLife";
            this.TSMenuItemLife.Size = new System.Drawing.Size(169, 22);
            this.TSMenuItemLife.Text = "积分10换1个生命";
            this.TSMenuItemLife.Click += new System.EventHandler(this.TSMenuItemLife_Click);
            // 
            // timerrate
            // 
            this.timerrate.Enabled = true;
            this.timerrate.Tick += new System.EventHandler(this.timerrate_Tick);
            // 
            // timerlab
            // 
            this.timerlab.Enabled = true;
            this.timerlab.Tick += new System.EventHandler(this.timerlab_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(631, 384);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "打字游戏1.0 6-20";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainFrm_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemMain;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemPause;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemLife;
        private System.Windows.Forms.Timer timerrate;
        private System.Windows.Forms.Timer timerlab;
    }
}

