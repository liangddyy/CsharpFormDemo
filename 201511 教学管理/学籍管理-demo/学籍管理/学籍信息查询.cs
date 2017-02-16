using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理_demo
{
    public partial class delStudentFrm : Form
    {
        Opreate op = new Opreate();
        public delStudentFrm()
        {
            Text = "Form3";
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stuMessageDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.stuMessageDataSet.student);

        }

        private void searchID_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new Opreate().conn();

            conn.Open();
            string strCmd;
            if (textBox1.Text.Equals("*"))
            {
                strCmd = "select * from student";
            }
            else
            {
                strCmd = "select * from student where " + comboBox1.Text + " = '" + textBox1.Text + " '";
            }

            //dtGrdViewSearch.Rows.Clear();

            SqlDataAdapter myDataAdapter;
            DataSet myDataSet = new DataSet();
            myDataAdapter = new SqlDataAdapter(strCmd, conn);
            myDataAdapter.Fill(myDataSet, "student");
            
            dtGrdViewSearch.DataSource = myDataSet.Tables["student"];

            conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new addStudentFrm();
            frm2.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
