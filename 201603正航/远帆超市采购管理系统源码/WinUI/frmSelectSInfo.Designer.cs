namespace WinUI
{
    partial class frmSelectSInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectSInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btnPInfoID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnNo = new System.Windows.Forms.Button();
            this.btnNumQuantity = new System.Windows.Forms.Button();
            this.btnNumPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品：";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(49, 15);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(100, 21);
            this.txtM.TabIndex = 1;
            // 
            // btnPInfoID
            // 
            this.btnPInfoID.Location = new System.Drawing.Point(150, 16);
            this.btnPInfoID.Name = "btnPInfoID";
            this.btnPInfoID.Size = new System.Drawing.Size(31, 20);
            this.btnPInfoID.TabIndex = 2;
            this.btnPInfoID.Text = "...";
            this.btnPInfoID.UseVisualStyleBackColor = true;
            this.btnPInfoID.Click += new System.EventHandler(this.btnPInfoID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "单价：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(247, 15);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(81, 21);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数量：";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(49, 41);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "总额：";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(247, 41);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(113, 21);
            this.txtSum.TabIndex = 3;
            // 
            // btnYes
            // 
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.ImageIndex = 0;
            this.btnYes.ImageList = this.imageList2;
            this.btnYes.Location = new System.Drawing.Point(107, 76);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(71, 31);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "    加入";
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
            this.btnNo.Location = new System.Drawing.Point(206, 76);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(71, 31);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "    取消";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnNumQuantity
            // 
            this.btnNumQuantity.Enabled = false;
            this.btnNumQuantity.Location = new System.Drawing.Point(150, 42);
            this.btnNumQuantity.Name = "btnNumQuantity";
            this.btnNumQuantity.Size = new System.Drawing.Size(31, 20);
            this.btnNumQuantity.TabIndex = 6;
            this.btnNumQuantity.Text = "...";
            this.btnNumQuantity.UseVisualStyleBackColor = true;
            this.btnNumQuantity.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNumPrice
            // 
            this.btnNumPrice.Enabled = false;
            this.btnNumPrice.Location = new System.Drawing.Point(329, 15);
            this.btnNumPrice.Name = "btnNumPrice";
            this.btnNumPrice.Size = new System.Drawing.Size(31, 20);
            this.btnNumPrice.TabIndex = 7;
            this.btnNumPrice.Text = "...";
            this.btnNumPrice.UseVisualStyleBackColor = true;
            this.btnNumPrice.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmSelectSInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 115);
            this.Controls.Add(this.btnNumPrice);
            this.Controls.Add(this.btnNumQuantity);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnPInfoID);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectSInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请选择商品";
            this.Load += new System.EventHandler(this.frmSelectSInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Button btnPInfoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnNumQuantity;
        private System.Windows.Forms.Button btnNumPrice;
    }
}