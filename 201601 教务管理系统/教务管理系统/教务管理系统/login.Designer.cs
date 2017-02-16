namespace 教务管理系统
{
    partial class Login
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
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioTeacher = new System.Windows.Forms.RadioButton();
            this.radioAdministrator = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinButtonLogin = new CCWin.SkinControl.SkinButton();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelName = new CCWin.SkinControl.SkinLabel();
            this.skinLabelPwd = new CCWin.SkinControl.SkinLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Checked = true;
            this.radioStudent.Location = new System.Drawing.Point(42, 15);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(47, 16);
            this.radioStudent.TabIndex = 4;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "学生";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // radioTeacher
            // 
            this.radioTeacher.AutoSize = true;
            this.radioTeacher.Location = new System.Drawing.Point(120, 15);
            this.radioTeacher.Name = "radioTeacher";
            this.radioTeacher.Size = new System.Drawing.Size(47, 16);
            this.radioTeacher.TabIndex = 5;
            this.radioTeacher.Text = "教师";
            this.radioTeacher.UseVisualStyleBackColor = true;
            // 
            // radioAdministrator
            // 
            this.radioAdministrator.AutoSize = true;
            this.radioAdministrator.Location = new System.Drawing.Point(202, 15);
            this.radioAdministrator.Name = "radioAdministrator";
            this.radioAdministrator.Size = new System.Drawing.Size(107, 16);
            this.radioAdministrator.TabIndex = 6;
            this.radioAdministrator.Text = "教务员、管理员";
            this.radioAdministrator.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioStudent);
            this.panel1.Controls.Add(this.skinButtonLogin);
            this.panel1.Controls.Add(this.radioTeacher);
            this.panel1.Controls.Add(this.radioAdministrator);
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 103);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // skinButtonLogin
            // 
            this.skinButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonLogin.CausesValidation = false;
            this.skinButtonLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonLogin.DownBack = null;
            this.skinButtonLogin.Location = new System.Drawing.Point(142, 55);
            this.skinButtonLogin.MouseBack = null;
            this.skinButtonLogin.Name = "skinButtonLogin";
            this.skinButtonLogin.NormlBack = null;
            this.skinButtonLogin.Size = new System.Drawing.Size(127, 35);
            this.skinButtonLogin.TabIndex = 13;
            this.skinButtonLogin.Text = "登陆";
            this.skinButtonLogin.UseVisualStyleBackColor = false;
            this.skinButtonLogin.Click += new System.EventHandler(this.skinButton1_Click);
            this.skinButtonLogin.Enter += new System.EventHandler(this.skinButtonLogin_Enter);
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '●';
            this.skinTextBox2.IsSystemPasswordChar = false;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(124, 163);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = false;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.PasswordChar = '●';
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 12;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.WaterText = "";
            this.skinTextBox2.WordWrap = true;
            this.skinTextBox2.Leave += new System.EventHandler(this.skinTextBox2_Leave);
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[0];
            this.skinTextBox1.Location = new System.Drawing.Point(124, 115);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 11;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            this.skinTextBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.skinTextBox1_Paint);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackgroundImage = global::教务管理系统.Properties.Resources.btn_close_disable;
            this.ButtonExit.Location = new System.Drawing.Point(395, -1);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(37, 23);
            this.ButtonExit.TabIndex = 13;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(12, 42);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(313, 29);
            this.skinLabel1.TabIndex = 14;
            this.skinLabel1.Text = "福建工程学院教务系统";
            // 
            // skinLabelName
            // 
            this.skinLabelName.AutoSize = true;
            this.skinLabelName.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelName.BorderColor = System.Drawing.Color.White;
            this.skinLabelName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelName.Location = new System.Drawing.Point(64, 120);
            this.skinLabelName.Name = "skinLabelName";
            this.skinLabelName.Size = new System.Drawing.Size(48, 16);
            this.skinLabelName.TabIndex = 14;
            this.skinLabelName.Text = "账号:";
            // 
            // skinLabelPwd
            // 
            this.skinLabelPwd.AutoSize = true;
            this.skinLabelPwd.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelPwd.BorderColor = System.Drawing.Color.White;
            this.skinLabelPwd.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelPwd.Location = new System.Drawing.Point(64, 168);
            this.skinLabelPwd.Name = "skinLabelPwd";
            this.skinLabelPwd.Size = new System.Drawing.Size(48, 16);
            this.skinLabelPwd.TabIndex = 16;
            this.skinLabelPwd.Text = "密码:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::教务管理系统.Properties.Resources._001;
            this.ClientSize = new System.Drawing.Size(430, 310);
            this.Controls.Add(this.skinLabelPwd);
            this.Controls.Add(this.skinLabelName);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.skinTextBox2);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆 - 教务系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioTeacher;
        private System.Windows.Forms.RadioButton radioAdministrator;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinButton skinButtonLogin;
        private System.Windows.Forms.Button ButtonExit;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabelName;
        private CCWin.SkinControl.SkinLabel skinLabelPwd;
    }
}

