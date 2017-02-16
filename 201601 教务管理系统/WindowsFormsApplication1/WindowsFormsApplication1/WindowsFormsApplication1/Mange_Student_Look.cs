using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Mange_Student_Look : Form
    {
        Opreate op = new Opreate();
        public Mange_Student_Look()
        {
            InitializeComponent();
        }

        private void Mange_Student_Look_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“softDataSet3.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter1.Fill(this.softDataSet3.student);
            // TODO: 这行代码将数据加载到表“softDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.softDataSet.student);

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new Opreate().conn();

            conn.Open();
            string strCmd;
            if (skinTextBox1.Text.Equals("*"))
            {
                strCmd = "select * from student";
            }
            else
            {
                strCmd = "select * from student where " + skinComboBox1.Text + " = '" + skinTextBox1.Text + " '";
            }

            //dtGrdViewSearch.Rows.Clear();

            SqlDataAdapter myDataAdapter;
            DataSet myDataSet = new DataSet();
            myDataAdapter = new SqlDataAdapter(strCmd, conn);
            myDataAdapter.Fill(myDataSet, "student");
            skinDataGridView1.DataSource = myDataSet.Tables["student"];

            conn.Close();
        }

        private void skinDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //获取行号
            int rowindex = e.RowIndex;
            string value0 = skinDataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string value1 = skinDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            string value2 = skinDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            string value3 = skinDataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            string value4 = skinDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            string value5 = skinDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            string value6 = skinDataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            string value7 = skinDataGridView1.Rows[rowindex].Cells[3].Value.ToString();
           // int value7 = int.Parse(skinDataGridView1.Rows[rowindex].Cells[3].Value.ToString());

            string sql = "UPDATE student SET sno='"+ value0 +"',sname = '"
                            + value1 + "',ssex = '"
                            + value2 + "',sclass = '"
                            + value3 + "',zno = '"
                            + value4 + "',Admission_time = '"
                            + value5 + "',Graduation_time = '"
                            + value6 + "',inschool = "
                            + value7 + " WHERE sno = '"
                            + value0 + "'";
            //string sql = "update  grade  set grade='" + value3 + "' where sno='" + value0 + "'and cno='" + value1 + "'and tno='" + value2 + "'";
            if (op.OPSQL(sql))
            {
                //修改成功
                label1.Text = "更新学生信息成功!! 学号：" + value0 + " 行号：" + rowindex;
                //MessageBox.Show("修改成功！");

            }
            else
            {
                MessageBox.Show("更新学生信息成功!!学号：" + value0 + " 行号：" + rowindex);
                label1.Text = "更新学生信息失败!! 学号：" + value0 + " 行号：" + rowindex;
            }

        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
