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
using System.Data.Sql;
namespace 学籍管理_demo
{
    public partial class delStudentFrm : Form
    {
        Opreate op = new Opreate();

        public object sqlDataAdapter1 { get; private set; }

        public delStudentFrm()
        {
            //Text = "Form3";
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“softDataSet.student”中。您可以根据需要移动或删除它。
           // this.studentTableAdapter1.Fill(this.softDataSet.student);
            // TODO: 这行代码将数据加载到表“stuMessageDataSet.student”中。您可以根据需要移动或删除它。
            //this.studentTableAdapter.Fill(this.stuMessageDataSet.student);
            // TODO: 这行代码将数据加载到表“cDataSet2.student”中。您可以根据需要移动或删除它。
            //this.studentTableAdapter2.Fill(this.softDataSet2.student);
            this.studentTableAdapter1.Fill(this.softDataSet.student);
            this.studentTableAdapter1.Fill(this.softDataSet.student);
            // TODO: 这行代码将数据加载到表“cDataSet1.student”中。您可以根据需要移动或删除它。
            //this.studentTableAdapter1.Fill(this.softDataSet1.student);
            this.dataGridView1.AllowUserToDeleteRows = true;

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
            //dtGrdViewSearch.DataSource = myDataSet.Tables["student"];

            dataGridView1.DataSource = myDataSet.Tables["student"];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchID_Click_1(object sender, EventArgs e)
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
            //dtGrdViewSearch.DataSource = myDataSet.Tables["student"];
            dataGridView1.DataSource = myDataSet.Tables["student"];


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "update student SET inschool=0 where Graduation_time<getdate()";
            if (op.OPSQL(sql))
            {
                //ClearText();
                MessageBox.Show("更改成功！");
            }
            else
            {
                MessageBox.Show("更改失败失败！请重试！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Response.Redirect(Request.Url.ToString());
            Form3_Load(null, null);

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
