namespace 教务管理系统.教务员模块
{
    partial class 毕业生查询
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
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchID = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softDataSet1 = new 教务管理系统.softDataSet1();
            this.studentTableAdapter = new 教务管理系统.softDataSet1TableAdapters.studentTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "一键更改毕业生在校状态";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 38;
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
            this.comboBox1.Location = new System.Drawing.Point(128, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 37;
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(313, 347);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(75, 23);
            this.searchID.TabIndex = 36;
            this.searchID.Text = "查询";
            this.searchID.UseVisualStyleBackColor = true;
            this.searchID.Click += new System.EventHandler(this.searchID_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "查询方式:";
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
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(955, 260);
            this.dataGridView1.TabIndex = 33;
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
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.softDataSet1;
            // 
            // softDataSet1
            // 
            this.softDataSet1.DataSetName = "softDataSet1";
            this.softDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "0表示毕业，1表示在校生";
            // 
            // 毕业生查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "毕业生查询";
            this.Text = "毕业生查询";
            this.Load += new System.EventHandler(this.毕业生查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private softDataSet1 softDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private softDataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spswDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiontimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graduationtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}