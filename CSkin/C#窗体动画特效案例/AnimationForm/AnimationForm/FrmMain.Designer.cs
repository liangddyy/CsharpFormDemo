namespace AnimationForm
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnJb = new System.Windows.Forms.Button();
            this.btnYdz = new System.Windows.Forms.Button();
            this.btnZdy = new System.Windows.Forms.Button();
            this.btnKz = new System.Windows.Forms.Button();
            this.btnSx = new System.Windows.Forms.Button();
            this.btnXs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJb
            // 
            this.btnJb.Location = new System.Drawing.Point(78, 149);
            this.btnJb.Name = "btnJb";
            this.btnJb.Size = new System.Drawing.Size(75, 23);
            this.btnJb.TabIndex = 0;
            this.btnJb.Text = "渐变";
            this.btnJb.UseVisualStyleBackColor = true;
            this.btnJb.Click += new System.EventHandler(this.btnJb_Click);
            // 
            // btnYdz
            // 
            this.btnYdz.Location = new System.Drawing.Point(215, 83);
            this.btnYdz.Name = "btnYdz";
            this.btnYdz.Size = new System.Drawing.Size(75, 23);
            this.btnYdz.TabIndex = 0;
            this.btnYdz.Text = "右到左";
            this.btnYdz.UseVisualStyleBackColor = true;
            this.btnYdz.Click += new System.EventHandler(this.btnYdz_Click);
            // 
            // btnZdy
            // 
            this.btnZdy.Location = new System.Drawing.Point(78, 83);
            this.btnZdy.Name = "btnZdy";
            this.btnZdy.Size = new System.Drawing.Size(75, 23);
            this.btnZdy.TabIndex = 0;
            this.btnZdy.Text = "左到右";
            this.btnZdy.UseVisualStyleBackColor = true;
            this.btnZdy.Click += new System.EventHandler(this.btnZdy_Click);
            // 
            // btnKz
            // 
            this.btnKz.Location = new System.Drawing.Point(215, 149);
            this.btnKz.Name = "btnKz";
            this.btnKz.Size = new System.Drawing.Size(75, 23);
            this.btnKz.TabIndex = 0;
            this.btnKz.Text = "收缩扩张";
            this.btnKz.UseVisualStyleBackColor = true;
            this.btnKz.Click += new System.EventHandler(this.btnKz_Click);
            // 
            // btnSx
            // 
            this.btnSx.Location = new System.Drawing.Point(78, 208);
            this.btnSx.Name = "btnSx";
            this.btnSx.Size = new System.Drawing.Size(75, 23);
            this.btnSx.TabIndex = 0;
            this.btnSx.Text = "上到下";
            this.btnSx.UseVisualStyleBackColor = true;
            this.btnSx.Click += new System.EventHandler(this.btnSx_Click);
            // 
            // btnXs
            // 
            this.btnXs.Location = new System.Drawing.Point(215, 208);
            this.btnXs.Name = "btnXs";
            this.btnXs.Size = new System.Drawing.Size(75, 23);
            this.btnXs.TabIndex = 0;
            this.btnXs.Text = "下到上";
            this.btnXs.UseVisualStyleBackColor = true;
            this.btnXs.Click += new System.EventHandler(this.btnXs_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(369, 314);
            this.Controls.Add(this.btnKz);
            this.Controls.Add(this.btnXs);
            this.Controls.Add(this.btnSx);
            this.Controls.Add(this.btnZdy);
            this.Controls.Add(this.btnYdz);
            this.Controls.Add(this.btnJb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "窗体特效";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJb;
        private System.Windows.Forms.Button btnYdz;
        private System.Windows.Forms.Button btnZdy;
        private System.Windows.Forms.Button btnKz;
        private System.Windows.Forms.Button btnSx;
        private System.Windows.Forms.Button btnXs;
    }
}

