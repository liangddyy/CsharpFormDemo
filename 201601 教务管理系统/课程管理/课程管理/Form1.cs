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
    public partial class Form1 : Form
    {
        Opreate op = new Opreate();
        public object sqlDataAdapter1 { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new Opreate().conn();

            conn.Open();
            string strCmd;
            if(comboBox1.Text.Equals(""))
            {
                MessageBox.Show("请选择查询条件！");
            }
            else if(textBox1.Text.Equals(""))
            {
                MessageBox.Show("请输入查询值！");
            }
            else if (textBox1.Text.Equals("*"))
            {
                strCmd = "select * from course";
            }
            else
            {
                strCmd = "select * from course where "+ comboBox1.Text +"= '" + textBox1.Text + "'";
                SqlDataAdapter myDataAdapter;
                DataSet myDataSet = new DataSet();
                myDataAdapter = new SqlDataAdapter(strCmd, conn);
                myDataAdapter.Fill(myDataSet, "course");
                dataGridView1.DataSource = myDataSet.Tables["course"];
            }

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“softDataSet.course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.softDataSet.course);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.ShowDialog(this);
        }
    }

}
