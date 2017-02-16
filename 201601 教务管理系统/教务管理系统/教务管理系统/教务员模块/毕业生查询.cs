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

namespace 教务管理系统.教务员模块
{
    public partial class 毕业生查询 : Form
    {
        Opreate op = new Opreate();
        public 毕业生查询()
        {
            InitializeComponent();
        }

        private void 毕业生查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“softDataSet1.student”中。您可以根据需要移动或删除它。
            //this.studentTableAdapter.Fill(this.softDataSet1.student);
            DataTable dt = op.GetDataTable("select * from student", "student");
            dataGridView1.DataSource = dt;
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

            conn.Close();
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
            毕业生查询_Load(null, null);
        }
    }
}
