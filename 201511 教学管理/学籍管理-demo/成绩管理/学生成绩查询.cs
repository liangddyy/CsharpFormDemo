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

namespace 学籍管理_demo.成绩管理
{
    public partial class 学生成绩查询 : Form
    {
        Opreate op = new Opreate();
        public 学生成绩查询()
        {
            InitializeComponent();
        }

        private void 学生成绩查询_Load(object sender, EventArgs e)
        {
           
            DataTable dt = op.GetDataTable("select score.sno,sname,course.cno,cname,ccategory,score.grade from score,student,course where student.sno=score.sno and score.cno=course.cno","student");
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new Opreate().conn();

            conn.Open();
            string strCmd;
            if (textBox1.Text.Equals("*"))
            {
                strCmd = "select score.sno,sname,course.cno,cname,ccategory,score.grade from student, score, course where student.sno =score.sno  and score.cno = course.cno";
            }
            else
            {
                strCmd = "select score.sno,sname,course.cno,cname,ccategory,score.grade from student,score,course where score." + comboBox1.Text + " = '" + textBox1.Text + " ' and student.sno = score.sno  and score.cno = course.cno";
            }

            //dtGrdViewSearch.Rows.Clear();

            SqlDataAdapter myDataAdapter;
            DataSet myDataSet = new DataSet();
            myDataAdapter = new SqlDataAdapter(strCmd, conn);
            myDataAdapter.Fill(myDataSet, "student");
            dataGridView1.DataSource = myDataSet.Tables["student"];
            //textBox1.Text = myDataSet.Tables["student"].;

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
