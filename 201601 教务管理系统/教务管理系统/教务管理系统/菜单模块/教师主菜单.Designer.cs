namespace 教务管理系统.菜单模块
{
    partial class 教师主菜单
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
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.ButtonExam = new CCWin.SkinControl.SkinButton();
            this.ButtonInput = new CCWin.SkinControl.SkinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.skinPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.ButtonExam);
            this.skinPanel1.Controls.Add(this.ButtonInput);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(1, 12);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(109, 369);
            this.skinPanel1.TabIndex = 4;
            // 
            // ButtonExam
            // 
            this.ButtonExam.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExam.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonExam.DownBack = null;
            this.ButtonExam.Location = new System.Drawing.Point(0, 0);
            this.ButtonExam.MouseBack = null;
            this.ButtonExam.Name = "ButtonExam";
            this.ButtonExam.NormlBack = null;
            this.ButtonExam.Size = new System.Drawing.Size(109, 67);
            this.ButtonExam.TabIndex = 4;
            this.ButtonExam.Text = "考试安排";
            this.ButtonExam.UseVisualStyleBackColor = false;
            this.ButtonExam.Click += new System.EventHandler(this.ButtonExam_Click);
            // 
            // ButtonInput
            // 
            this.ButtonInput.BackColor = System.Drawing.Color.Transparent;
            this.ButtonInput.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonInput.DownBack = null;
            this.ButtonInput.Location = new System.Drawing.Point(0, 71);
            this.ButtonInput.MouseBack = null;
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.NormlBack = null;
            this.ButtonInput.Size = new System.Drawing.Size(109, 71);
            this.ButtonInput.TabIndex = 3;
            this.ButtonInput.Text = "成绩录入";
            this.ButtonInput.UseVisualStyleBackColor = false;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.skinComboBox1);
            this.panel1.Location = new System.Drawing.Point(116, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 273);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(99, 149);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 6;
            this.skinButton1.Text = "更新";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.Location = new System.Drawing.Point(99, 14);
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(114, 22);
            this.skinComboBox1.TabIndex = 5;
            this.skinComboBox1.WaterText = "";
            // 
            // 教师主菜单
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "教师主菜单";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师主菜单";
            this.Load += new System.EventHandler(this.教师主菜单_Load);
            this.skinPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton ButtonInput;
        private CCWin.SkinControl.SkinButton ButtonExam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinComboBox skinComboBox1;
    }
}