namespace WinUI
{
    partial class frmPType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pTypeListBox = new UIL.PTypeListBox();
            this.btnAccession = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAmend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pTypeListBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类型名称";
            // 
            // pTypeListBox
            // 
            this.pTypeListBox.Location = new System.Drawing.Point(4, 15);
            this.pTypeListBox.Name = "pTypeListBox";
            this.pTypeListBox.Size = new System.Drawing.Size(145, 186);
            this.pTypeListBox.TabIndex = 1;
            // 
            // btnAccession
            // 
            this.btnAccession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccession.ImageIndex = 0;
            this.btnAccession.ImageList = this.imageList1;
            this.btnAccession.Location = new System.Drawing.Point(172, 21);
            this.btnAccession.Name = "btnAccession";
            this.btnAccession.Size = new System.Drawing.Size(66, 39);
            this.btnAccession.TabIndex = 2;
            this.btnAccession.Text = "    添加";
            this.btnAccession.UseVisualStyleBackColor = true;
            this.btnAccession.Click += new System.EventHandler(this.btnAccession_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "增.gif");
            this.imageList1.Images.SetKeyName(1, "修改.gif");
            this.imageList1.Images.SetKeyName(2, "删除.gif");
            this.imageList1.Images.SetKeyName(3, "退出.gif");
            // 
            // btnDelete
            // 
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(172, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "    删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAmend
            // 
            this.btnAmend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmend.ImageIndex = 1;
            this.btnAmend.ImageList = this.imageList1;
            this.btnAmend.Location = new System.Drawing.Point(172, 61);
            this.btnAmend.Name = "btnAmend";
            this.btnAmend.Size = new System.Drawing.Size(66, 39);
            this.btnAmend.TabIndex = 3;
            this.btnAmend.Text = "    修改";
            this.btnAmend.UseVisualStyleBackColor = true;
            this.btnAmend.Click += new System.EventHandler(this.btnAmend_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageIndex = 3;
            this.btnExit.ImageList = this.imageList1;
            this.btnExit.Location = new System.Drawing.Point(172, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "    退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 225);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAmend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAccession);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "供应商类型管理";
            this.Load += new System.EventHandler(this.frmPType_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAccession;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAmend;
        private System.Windows.Forms.Button btnExit;
        private UIL.PTypeListBox pTypeListBox;
        private System.Windows.Forms.ImageList imageList1;
    }
}