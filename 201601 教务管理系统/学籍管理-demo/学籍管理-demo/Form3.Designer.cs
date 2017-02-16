namespace 学籍管理_demo
{
    partial class delStudentFrm
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuMessageDataSet = new 学籍管理_demo.stuMessageDataSet();
            this.studentTableAdapter = new 学籍管理_demo.stuMessageDataSetTableAdapters.studentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spswDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissiontimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graduationtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.softDataSet = new 学籍管理_demo.softDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchID = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentTableAdapter1 = new 学籍管理_demo.softDataSetTableAdapters.studentTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuMessageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.stuMessageDataSet;
            this.studentBindingSource.CurrentChanged += new System.EventHandler(this.studentBindingSource_CurrentChanged);
            // 
            // stuMessageDataSet
            // 
            this.stuMessageDataSet.DataSetName = "stuMessageDataSet";
            this.stuMessageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.ssexDataGridViewTextBoxColumn,
            this.sclassDataGridViewTextBoxColumn,
            this.znoDataGridViewTextBoxColumn,
            this.spswDataGridViewTextBoxColumn,
            this.admissiontimeDataGridViewTextBoxColumn,
            this.graduationtimeDataGridViewTextBoxColumn,
            this.inschoolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(955, 260);
            this.dataGridView1.TabIndex = 11;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // ssexDataGridViewTextBoxColumn
            // 
            this.ssexDataGridViewTextBoxColumn.DataPropertyName = "ssex";
            this.ssexDataGridViewTextBoxColumn.HeaderText = "ssex";
            this.ssexDataGridViewTextBoxColumn.Name = "ssexDataGridViewTextBoxColumn";
            // 
            // sclassDataGridViewTextBoxColumn
            // 
            this.sclassDataGridViewTextBoxColumn.DataPropertyName = "sclass";
            this.sclassDataGridViewTextBoxColumn.HeaderText = "sclass";
            this.sclassDataGridViewTextBoxColumn.Name = "sclassDataGridViewTextBoxColumn";
            // 
            // znoDataGridViewTextBoxColumn
            // 
            this.znoDataGridViewTextBoxColumn.DataPropertyName = "zno";
            this.znoDataGridViewTextBoxColumn.HeaderText = "zno";
            this.znoDataGridViewTextBoxColumn.Name = "znoDataGridViewTextBoxColumn";
            // 
            // spswDataGridViewTextBoxColumn
            // 
            this.spswDataGridViewTextBoxColumn.DataPropertyName = "spsw";
            this.spswDataGridViewTextBoxColumn.HeaderText = "spsw";
            this.spswDataGridViewTextBoxColumn.Name = "spswDataGridViewTextBoxColumn";
            // 
            // admissiontimeDataGridViewTextBoxColumn
            // 
            this.admissiontimeDataGridViewTextBoxColumn.DataPropertyName = "Admission_time";
            this.admissiontimeDataGridViewTextBoxColumn.HeaderText = "Admission_time";
            this.admissiontimeDataGridViewTextBoxColumn.Name = "admissiontimeDataGridViewTextBoxColumn";
            // 
            // graduationtimeDataGridViewTextBoxColumn
            // 
            this.graduationtimeDataGridViewTextBoxColumn.DataPropertyName = "Graduation_time";
            this.graduationtimeDataGridViewTextBoxColumn.HeaderText = "Graduation_time";
            this.graduationtimeDataGridViewTextBoxColumn.Name = "graduationtimeDataGridViewTextBoxColumn";
            // 
            // inschoolDataGridViewTextBoxColumn
            // 
            this.inschoolDataGridViewTextBoxColumn.DataPropertyName = "inschool";
            this.inschoolDataGridViewTextBoxColumn.HeaderText = "inschool";
            this.inschoolDataGridViewTextBoxColumn.Name = "inschoolDataGridViewTextBoxColumn";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.softDataSet;
            // 
            // softDataSet
            // 
            this.softDataSet.DataSetName = "softDataSet";
            this.softDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "输入";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sno",
            "sname",
            "ssex",
            "zno"});
            this.comboBox1.Location = new System.Drawing.Point(143, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 15;
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(328, 285);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(75, 23);
            this.searchID.TabIndex = 14;
            this.searchID.Text = "查询";
            this.searchID.UseVisualStyleBackColor = true;
            this.searchID.Click += new System.EventHandler(this.searchID_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "查询方式:";
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(328, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "一键更改毕业生在校状态";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "delStudentFrm";
            this.Text = "查询 | 删除";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuMessageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private stuMessageDataSet stuMessageDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private stuMessageDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private softDataSet softDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private softDataSetTableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spswDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiontimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graduationtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}