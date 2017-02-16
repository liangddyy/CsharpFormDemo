namespace HookTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInstallHook = new System.Windows.Forms.Button();
            this.btnUnInstall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKeyState = new System.Windows.Forms.Label();
            this.lbMouseState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInstallHook
            // 
            resources.ApplyResources(this.btnInstallHook, "btnInstallHook");
            this.btnInstallHook.Name = "btnInstallHook";
            this.btnInstallHook.UseVisualStyleBackColor = true;
            this.btnInstallHook.Click += new System.EventHandler(this.btnInstallHook_Click);
            // 
            // btnUnInstall
            // 
            resources.ApplyResources(this.btnUnInstall, "btnUnInstall");
            this.btnUnInstall.Name = "btnUnInstall";
            this.btnUnInstall.UseVisualStyleBackColor = true;
            this.btnUnInstall.Click += new System.EventHandler(this.btnUnInstall_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbKeyState
            // 
            resources.ApplyResources(this.lbKeyState, "lbKeyState");
            this.lbKeyState.Name = "lbKeyState";
            // 
            // lbMouseState
            // 
            resources.ApplyResources(this.lbMouseState, "lbMouseState");
            this.lbMouseState.Name = "lbMouseState";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMouseState);
            this.Controls.Add(this.lbKeyState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnInstall);
            this.Controls.Add(this.btnInstallHook);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstallHook;
        private System.Windows.Forms.Button btnUnInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKeyState;
        private System.Windows.Forms.Label lbMouseState;
    }
}

