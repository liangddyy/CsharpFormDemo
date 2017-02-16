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
    public partial class 排课 : Form
    {
        public 排课()
        {
            InitializeComponent();
        }

        Opreate op = new Opreate();
        private void skinButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new Opreate().conn();

            conn.Open();
            string strCmd;
            if (textBox1.Text.Equals("*"))
            {
                strCmd = "select * from Teacher_teaching";
            }
            else
            {
                strCmd = "select * from Teacher_teaching where " + skinComboBox1.Text + " = '" + textBox1.Text + " '";
            }

            //dtGrdViewSearch.Rows.Clear();

            SqlDataAdapter myDataAdapter;
            DataSet myDataSet = new DataSet();
            myDataAdapter = new SqlDataAdapter(strCmd, conn);
            myDataAdapter.Fill(myDataSet, "Teacher_teaching");
            skinDataGridView1.DataSource = myDataSet.Tables["Teacher_teaching"];

            conn.Close();
        }

        private void 排课_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new Opreate().conn();

            conn.Open();
            string strCmd = "select * from Teacher_teaching";

            //dtGrdViewSearch.Rows.Clear();

            SqlDataAdapter myDataAdapter;
            DataSet myDataSet = new DataSet();
            myDataAdapter = new SqlDataAdapter(strCmd, conn);
            myDataAdapter.Fill(myDataSet, "Teacher_teaching");
            skinDataGridView1.DataSource = myDataSet.Tables["Teacher_teaching"];

            skinDataGridView1.Columns[0].ReadOnly = true;
            skinDataGridView1.Columns[1].ReadOnly = true;
            skinDataGridView1.Columns[2].ReadOnly = true;

            conn.Close();
        }

        private void skinDataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            //获取行号
            int rowindex = e.RowIndex;
            string value0 = skinDataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string value1 = skinDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            string value2 = skinDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            string value3 = skinDataGridView1.Rows[rowindex].Cells[3].Value.ToString();

            string sql = "UPDATE Teacher_teaching SET lesson_time = '" + value3 + "' WHERE tno = '" + value0 + "' and cno = '" + value1 + "'";

            //string sql = "update  grade  set grade='" + value3 + "' where sno='" + value0 + "'and cno='" + value1 + "'and tno='" + value2 + "'";
            if (op.OPSQL(sql))
            {
                //修改成功
                label1.Text = "更新课表信息成功!! 职工号：" + value0 + " 行号：" + rowindex;
                //MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("更新课表信息失败!!职工号：" + value0 + " 行号：" + rowindex);
                label1.Text = "更新课表信息失败!! 职工号：" + value0 + " 行号：" + rowindex;
            }
        }
    }
}
