namespace UIL
{
    partial class PTypeListBox
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPType
            // 
            this.lbPType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPType.FormattingEnabled = true;
            this.lbPType.ItemHeight = 12;
            this.lbPType.Location = new System.Drawing.Point(0, 0);
            this.lbPType.Name = "lbPType";
            this.lbPType.Size = new System.Drawing.Size(158, 208);
            this.lbPType.TabIndex = 0;
            // 
            // PTypeListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPType);
            this.Name = "PTypeListBox";
            this.Size = new System.Drawing.Size(158, 213);
            this.Load += new System.EventHandler(this.PTypeListBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbPType;

    }
}
