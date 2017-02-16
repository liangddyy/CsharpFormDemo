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
using 教务管理系统;

namespace 课程管理
{
    public partial class Form2 : Form
    {

        Opreate op = new Opreate();
        public object sqlDataAdapter1 { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new Opreate().conn();

            conn.Open();
            string strCmd="";
            if(textBox1.Text.Equals(""))
            {
               // strCmd = "";
                MessageBox.Show("请输入学号！");
            }
            else
            {
                strCmd = "select * from Teacher_teaching where tno ='" + textBox1.Text + "'";
                SqlDataAdapter myDataAdapter;
                DataSet myDataSet = new DataSet();
                myDataAdapter = new SqlDataAdapter(strCmd, conn);
                myDataAdapter.Fill(myDataSet, "Teacher_teaching");
                dataGridView1.DataSource = myDataSet.Tables["Teacher_teaching"];
            }


            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“softDataSet1.Teacher_teaching”中。您可以根据需要移动或删除它。
            this.teacher_teachingTableAdapter.Fill(this.softDataSet1.Teacher_teaching);

        }
    }
}
