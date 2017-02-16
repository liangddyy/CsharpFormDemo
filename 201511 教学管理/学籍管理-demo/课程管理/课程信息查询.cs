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

namespace 学籍管理_demo.课程管理
{
    public partial class 课程信息查询 : Form
    {
        
        Opreate op = new Opreate();
        public 课程信息查询()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new Opreate().conn();

            conn.Open();
            string strCmd;
            if (textBox1.Text.Equals("*"))
            {
                strCmd = "select * from course";
            }
            else
            {
                strCmd = "select * from course where " + comboBox1.Text + " = '" + textBox1.Text + " '";
            }
            //dataGridView1.Rows.Clear();
            //dtGrdViewSearch.Rows.Clear();

            SqlDataAdapter myDataAdapter;
            DataSet myDataSet = new DataSet();
            myDataAdapter = new SqlDataAdapter(strCmd, conn);
            myDataAdapter.Fill(myDataSet, "course");
            dataGridView1.DataSource = myDataSet.Tables["course"];

            conn.Close();
        }

        private void 课程信息查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stuMessageDataSet1.course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.stuMessageDataSet1.course);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
