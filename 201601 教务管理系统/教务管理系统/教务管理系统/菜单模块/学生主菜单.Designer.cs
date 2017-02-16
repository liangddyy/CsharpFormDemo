namespace 教务管理系统.菜单模块
{
    partial class 学生主菜单
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.ButtonLessonTime = new CCWin.SkinControl.SkinButton();
            this.ButtonExam = new CCWin.SkinControl.SkinButton();
            this.ButtonSelectCourse = new CCWin.SkinControl.SkinButton();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.panel_message = new System.Windows.Forms.Panel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.panel_grade = new System.Windows.Forms.Panel();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.panel_lesson = new System.Windows.Forms.Panel();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinDataGridView2 = new CCWin.SkinControl.SkinDataGridView();
            this.panel_selectlesson = new System.Windows.Forms.Panel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.softDataSet1 = new 教务管理系统.softDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.skinPanel1.SuspendLayout();
            this.panel_message.SuspendLayout();
            this.panel_grade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            this.panel_lesson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView2)).BeginInit();
            this.panel_selectlesson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinButton4);
            this.skinPanel1.Controls.Add(this.ButtonLessonTime);
            this.skinPanel1.Controls.Add(this.ButtonExam);
            this.skinPanel1.Controls.Add(this.ButtonSelectCourse);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(1, 12);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(109, 369);
            this.skinPanel1.TabIndex = 5;
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.Location = new System.Drawing.Point(0, 209);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Size = new System.Drawing.Size(109, 57);
            this.skinButton4.TabIndex = 6;
            this.skinButton4.Text = "刷新公告";
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // ButtonLessonTime
            // 
            this.ButtonLessonTime.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLessonTime.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonLessonTime.DownBack = null;
            this.ButtonLessonTime.Location = new System.Drawing.Point(0, 71);
            this.ButtonLessonTime.MouseBack = null;
            this.ButtonLessonTime.Name = "ButtonLessonTime";
            this.ButtonLessonTime.NormlBack = null;
            this.ButtonLessonTime.Size = new System.Drawing.Size(109, 59);
            this.ButtonLessonTime.TabIndex = 5;
            this.ButtonLessonTime.Text = "课表查询";
            this.ButtonLessonTime.UseVisualStyleBackColor = false;
            this.ButtonLessonTime.Click += new System.EventHandler(this.ButtonLessonTime_Click);
            // 
            // ButtonExam
            // 
            this.ButtonExam.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExam.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonExam.DownBack = null;
            this.ButtonExam.Location = new System.Drawing.Point(0, 136);
            this.ButtonExam.MouseBack = null;
            this.ButtonExam.Name = "ButtonExam";
            this.ButtonExam.NormlBack = null;
            this.ButtonExam.Size = new System.Drawing.Size(109, 67);
            this.ButtonExam.TabIndex = 4;
            this.ButtonExam.Text = "成绩查询";
            this.ButtonExam.UseVisualStyleBackColor = false;
            this.ButtonExam.Click += new System.EventHandler(this.ButtonExam_Click);
            // 
            // ButtonSelectCourse
            // 
            this.ButtonSelectCourse.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSelectCourse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ButtonSelectCourse.DownBack = null;
            this.ButtonSelectCourse.Location = new System.Drawing.Point(0, 3);
            this.ButtonSelectCourse.MouseBack = null;
            this.ButtonSelectCourse.Name = "ButtonSelectCourse";
            this.ButtonSelectCourse.NormlBack = null;
            this.ButtonSelectCourse.Size = new System.Drawing.Size(109, 59);
            this.ButtonSelectCourse.TabIndex = 3;
            this.ButtonSelectCourse.Text = "学生选课";
            this.ButtonSelectCourse.UseVisualStyleBackColor = false;
            this.ButtonSelectCourse.Click += new System.EventHandler(this.ButtonSelectCourse_Click);
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
            this.skinTextBox1.Location = new System.Drawing.Point(0, 38);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(336, 270);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(326, 260);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 6;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // panel_message
            // 
            this.panel_message.Controls.Add(this.skinLabel1);
            this.panel_message.Controls.Add(this.skinTextBox1);
            this.panel_message.Location = new System.Drawing.Point(116, 52);
            this.panel_message.Name = "panel_message";
            this.panel_message.Size = new System.Drawing.Size(374, 320);
            this.panel_message.TabIndex = 1;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 3);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "公告";
            // 
            // panel_grade
            // 
            this.panel_grade.Controls.Add(this.skinButton2);
            this.panel_grade.Controls.Add(this.skinDataGridView1);
            this.panel_grade.Controls.Add(this.skinLabel2);
            this.panel_grade.Location = new System.Drawing.Point(136, 38);
            this.panel_grade.Name = "panel_grade";
            this.panel_grade.Size = new System.Drawing.Size(436, 334);
            this.panel_grade.TabIndex = 1;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(358, 17);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 2;
            this.skinButton2.Text = "刷新成绩";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinDataGridView1
            // 
            this.skinDataGridView1.AllowUserToAddRows = false;
            this.skinDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView1.ColumnFont = null;
            this.skinDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridView1.EnableHeadersVisualStyles = false;
            this.skinDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.Location = new System.Drawing.Point(3, 51);
            this.skinDataGridView1.Name = "skinDataGridView1";
            this.skinDataGridView1.ReadOnly = true;
            this.skinDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView1.RowTemplate.Height = 23;
            this.skinDataGridView1.Size = new System.Drawing.Size(430, 263);
            this.skinDataGridView1.TabIndex = 1;
            this.skinDataGridView1.TitleBack = null;
            this.skinDataGridView1.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(13, 0);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "成绩查询";
            // 
            // panel_lesson
            // 
            this.panel_lesson.Controls.Add(this.skinButton3);
            this.panel_lesson.Controls.Add(this.skinLabel3);
            this.panel_lesson.Controls.Add(this.skinDataGridView2);
            this.panel_lesson.Location = new System.Drawing.Point(152, 16);
            this.panel_lesson.Name = "panel_lesson";
            this.panel_lesson.Size = new System.Drawing.Size(473, 344);
            this.panel_lesson.TabIndex = 6;
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(329, 10);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(75, 23);
            this.skinButton3.TabIndex = 2;
            this.skinButton3.Text = "刷新课表";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(10, 8);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 1;
            this.skinLabel3.Text = "课表查询";
            // 
            // skinDataGridView2
            // 
            this.skinDataGridView2.AllowUserToAddRows = false;
            this.skinDataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.skinDataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView2.ColumnFont = null;
            this.skinDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.skinDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView2.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.skinDataGridView2.EnableHeadersVisualStyles = false;
            this.skinDataGridView2.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView2.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView2.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView2.Location = new System.Drawing.Point(13, 43);
            this.skinDataGridView2.Name = "skinDataGridView2";
            this.skinDataGridView2.ReadOnly = true;
            this.skinDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.skinDataGridView2.RowTemplate.Height = 23;
            this.skinDataGridView2.Size = new System.Drawing.Size(445, 282);
            this.skinDataGridView2.TabIndex = 0;
            this.skinDataGridView2.TitleBack = null;
            this.skinDataGridView2.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView2.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // panel_selectlesson
            // 
            this.panel_selectlesson.Controls.Add(this.label2);
            this.panel_selectlesson.Controls.Add(this.skinButton1);
            this.panel_selectlesson.Controls.Add(this.label4);
            this.panel_selectlesson.Controls.Add(this.comboBox1);
            this.panel_selectlesson.Controls.Add(this.label1);
            this.panel_selectlesson.Controls.Add(this.textBox1);
            this.panel_selectlesson.Location = new System.Drawing.Point(182, 7);
            this.panel_selectlesson.Name = "panel_selectlesson";
            this.panel_selectlesson.Size = new System.Drawing.Size(474, 334);
            this.panel_selectlesson.TabIndex = 7;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(188, 175);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 38;
            this.skinButton1.Text = "选课";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "学分：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "课程：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 21);
            this.textBox1.TabIndex = 34;
            // 
            // softDataSet1
            // 
            this.softDataSet1.DataSetName = "softDataSet";
            this.softDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "label2";
            // 
            // 学生主菜单
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 393);
            this.Controls.Add(this.panel_selectlesson);
            this.Controls.Add(this.panel_lesson);
            this.Controls.Add(this.panel_grade);
            this.Controls.Add(this.panel_message);
            this.Controls.Add(this.skinPanel1);
            this.Name = "学生主菜单";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生主菜单";
            this.Load += new System.EventHandler(this.学生主菜单_Load);
            this.skinPanel1.ResumeLayout(false);
            this.panel_message.ResumeLayout(false);
            this.panel_message.PerformLayout();
            this.panel_grade.ResumeLayout(false);
            this.panel_grade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            this.panel_lesson.ResumeLayout(false);
            this.panel_lesson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView2)).EndInit();
            this.panel_selectlesson.ResumeLayout(false);
            this.panel_selectlesson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton ButtonExam;
        private CCWin.SkinControl.SkinButton ButtonSelectCourse;
        private CCWin.SkinControl.SkinButton ButtonLessonTime;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private System.Windows.Forms.Panel panel_message;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Panel panel_grade;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView1;
        private System.Windows.Forms.Panel panel_lesson;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView2;
        private System.Windows.Forms.Panel panel_selectlesson;
        private softDataSet softDataSet1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinButton skinButton4;
        private System.Windows.Forms.Label label2;
    }
}