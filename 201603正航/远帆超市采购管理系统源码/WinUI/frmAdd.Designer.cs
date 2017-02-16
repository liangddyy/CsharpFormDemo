namespace WinUI
{
    partial class frmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPInfoID = new System.Windows.Forms.Label();
            this.btnPInfoID = new System.Windows.Forms.Button();
            this.txtPInfo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvSInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnYes = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnNo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblPInfoID);
            this.groupBox1.Controls.Add(this.btnPInfoID);
            this.groupBox1.Controls.Add(this.txtPInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "定单信息";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(66, 22);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(100, 21);
            this.txtNo.TabIndex = 6;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(5, 27);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(65, 12);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "定单编号：";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(427, 22);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(111, 21);
            this.dtp.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(366, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 12);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "下单时间：";
            // 
            // lblPInfoID
            // 
            this.lblPInfoID.AutoSize = true;
            this.lblPInfoID.Location = new System.Drawing.Point(172, 26);
            this.lblPInfoID.Name = "lblPInfoID";
            this.lblPInfoID.Size = new System.Drawing.Size(53, 12);
            this.lblPInfoID.TabIndex = 3;
            this.lblPInfoID.Text = "供应商：";
            // 
            // btnPInfoID
            // 
            this.btnPInfoID.Location = new System.Drawing.Point(329, 22);
            this.btnPInfoID.Name = "btnPInfoID";
            this.btnPInfoID.Size = new System.Drawing.Size(31, 20);
            this.btnPInfoID.TabIndex = 1;
            this.btnPInfoID.Text = "...";
            this.btnPInfoID.UseVisualStyleBackColor = true;
            this.btnPInfoID.Click += new System.EventHandler(this.btnPInfoID_Click);
            // 
            // txtPInfo
            // 
            this.txtPInfo.Location = new System.Drawing.Point(226, 21);
            this.txtPInfo.Name = "txtPInfo";
            this.txtPInfo.ReadOnly = true;
            this.txtPInfo.Size = new System.Drawing.Size(101, 21);
            this.txtPInfo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lvSInfo);
            this.groupBox2.Location = new System.Drawing.Point(11, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "定单明细";
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 4;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(467, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "    清空";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "增.gif");
            this.imageList1.Images.SetKeyName(1, "修改.gif");
            this.imageList1.Images.SetKeyName(2, "删除.gif");
            this.imageList1.Images.SetKeyName(3, "搜索.gif");
            this.imageList1.Images.SetKeyName(4, "刷新.gif");
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 1;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(467, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "    修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(467, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "    删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(467, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "    添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvSInfo
            // 
            this.lvSInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSInfo.FullRowSelect = true;
            this.lvSInfo.GridLines = true;
            this.lvSInfo.Location = new System.Drawing.Point(7, 20);
            this.lvSInfo.Name = "lvSInfo";
            this.lvSInfo.Size = new System.Drawing.Size(455, 223);
            this.lvSInfo.TabIndex = 0;
            this.lvSInfo.UseCompatibleStateImageBehavior = false;
            this.lvSInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名称";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "数量";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "单价";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "总额";
            this.columnHeader4.Width = 85;
            // 
            // btnYes
            // 
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.ImageIndex = 0;
            this.btnYes.ImageList = this.imageList2;
            this.btnYes.Location = new System.Drawing.Point(131, 329);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(71, 31);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "    提交";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "ok.gif");
            this.imageList2.Images.SetKeyName(1, "exit.gif");
            // 
            // btnNo
            // 
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.ImageIndex = 1;
            this.btnNo.ImageList = this.imageList2;
            this.btnNo.Location = new System.Drawing.Point(314, 329);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(71, 31);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "    重置";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 364);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.Text = "增加定单";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvSInfo;
        private System.Windows.Forms.TextBox txtPInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblPInfoID;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnPInfoID;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button4;
    }
}