namespace UIL
{
    partial class MTypeTreeView
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
            this.tvMType = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvMType
            // 
            this.tvMType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMType.HideSelection = false;
            this.tvMType.Location = new System.Drawing.Point(0, 0);
            this.tvMType.Name = "tvMType";
            this.tvMType.Size = new System.Drawing.Size(206, 265);
            this.tvMType.TabIndex = 1;
            this.tvMType.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvMType_BeforeExpand);
            // 
            // MTypeTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvMType);
            this.Name = "MTypeTreeView";
            this.Size = new System.Drawing.Size(206, 265);
            this.Load += new System.EventHandler(this.MTypeTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView tvMType;

    }
}
