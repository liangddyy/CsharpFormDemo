namespace 教务管理系统.菜单模块
{
    partial class 教务员菜单
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonTeacher = new CCWin.SkinControl.SkinButton();
            this.ButtonStudent = new CCWin.SkinControl.SkinButton();
            this.ButtonStuGraduate = new CCWin.SkinControl.SkinButton();
            this.ButtonClass = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // ButtonTeacher
            // 
            this.ButtonTeacher.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTeacher.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonTeacher.DownBack = null;
            this.ButtonTeacher.Location = new System.Drawing.Point(3, 2);
            this.ButtonTeacher.MouseBack = null;
            this.ButtonTeacher.Name = "ButtonTeacher";
            this.ButtonTeacher.NormlBack = null;
            this.ButtonTeacher.Size = new System.Drawing.Size(109, 59);
            this.ButtonTeacher.TabIndex = 4;
            this.ButtonTeacher.Text = "教师信息管理";
            this.ButtonTeacher.UseVisualStyleBackColor = false;
            this.ButtonTeacher.Click += new System.EventHandler(this.ButtonTeacher_Click);
            // 
            // ButtonStudent
            // 
            this.ButtonStudent.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStudent.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonStudent.DownBack = null;
            this.ButtonStudent.Location = new System.Drawing.Point(3, 67);
            this.ButtonStudent.MouseBack = null;
            this.ButtonStudent.Name = "ButtonStudent";
            this.ButtonStudent.NormlBack = null;
            this.ButtonStudent.Size = new System.Drawing.Size(109, 59);
            this.ButtonStudent.TabIndex = 3;
            this.ButtonStudent.Text = "学生信息管理";
            this.ButtonStudent.UseVisualStyleBackColor = false;
            this.ButtonStudent.Click += new System.EventHandler(this.ButtonStudent_Click);
            // 
            // ButtonStuGraduate
            // 
            this.ButtonStuGraduate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStuGraduate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonStuGraduate.DownBack = null;
            this.ButtonStuGraduate.Location = new System.Drawing.Point(3, 202);
            this.ButtonStuGraduate.MouseBack = null;
            this.ButtonStuGraduate.Name = "ButtonStuGraduate";
            this.ButtonStuGraduate.NormlBack = null;
            this.ButtonStuGraduate.Size = new System.Drawing.Size(109, 59);
            this.ButtonStuGraduate.TabIndex = 2;
            this.ButtonStuGraduate.Text = "毕业生管理";
            this.ButtonStuGraduate.UseVisualStyleBackColor = false;
            this.ButtonStuGraduate.Click += new System.EventHandler(this.ButtonStuGraduate_Click);
            // 
            // ButtonClass
            // 
            this.ButtonClass.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClass.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonClass.DownBack = null;
            this.ButtonClass.Location = new System.Drawing.Point(3, 131);
            this.ButtonClass.MouseBack = null;
            this.ButtonClass.Name = "ButtonClass";
            this.ButtonClass.NormlBack = null;
            this.ButtonClass.Size = new System.Drawing.Size(109, 65);
            this.ButtonClass.TabIndex = 5;
            this.ButtonClass.Text = "排课";
            this.ButtonClass.UseVisualStyleBackColor = false;
            this.ButtonClass.Click += new System.EventHandler(this.ButtonClass_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(3, 267);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(109, 55);
            this.skinButton1.TabIndex = 6;
            this.skinButton1.Text = "公告栏";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // 教务员菜单
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 393);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.ButtonStuGraduate);
            this.Controls.Add(this.ButtonStudent);
            this.Controls.Add(this.ButtonTeacher);
            this.Controls.Add(this.ButtonClass);
            this.Name = "教务员菜单";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教务员菜单";
            this.Load += new System.EventHandler(this.教务员菜单_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton ButtonTeacher;
        private CCWin.SkinControl.SkinButton ButtonStudent;
        private CCWin.SkinControl.SkinButton ButtonStuGraduate;
        private CCWin.SkinControl.SkinButton ButtonClass;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}