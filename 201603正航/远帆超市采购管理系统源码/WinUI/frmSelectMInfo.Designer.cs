namespace WinUI
{
    partial class frmSelectMInfo
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
            this.lvMType = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvMType
            // 
            this.lvMType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMType.FullRowSelect = true;
            this.lvMType.GridLines = true;
            this.lvMType.HideSelection = false;
            this.lvMType.Location = new System.Drawing.Point(0, 0);
            this.lvMType.MultiSelect = false;
            this.lvMType.Name = "lvMType";
            this.lvMType.Size = new System.Drawing.Size(478, 333);
            this.lvMType.TabIndex = 10;
            this.lvMType.UseCompatibleStateImageBehavior = false;
            this.lvMType.View = System.Windows.Forms.View.Details;
            this.lvMType.DoubleClick += new System.EventHandler(this.lvMType_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名称";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品类型";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "日销售量";
            this.columnHeader3.Width = 84;
            // 
            // frmSelectMInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 333);
            this.Controls.Add(this.lvMType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectMInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSelectMInfo";
            this.Load += new System.EventHandler(this.frmSelectMInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}