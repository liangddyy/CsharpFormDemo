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

    public partial class Mange_Teacher_Look : Form
    {
        Opreate op = new Opreate();

        public Mange_Teacher_Look()
        {
            InitializeComponent();
        }

        private void Mange_Teacher_Look_Load(object sender, EventArgs e)
        {
           // DataTable dt = op.GetDataTable("SELECT tno, tname, tsex, tduties FROM teacher", "teacher");
           // skinDataGridView1.DataSource = dt;


            // TODO: 这行代码将数据加载到表“softDataSet2.teacher”中。您可以根据需要移动或删除它。
            this.teacherTableAdapter1.Fill(this.softDataSet2.teacher);
            // TODO: 这行代码将数据加载到表“softDataSet1.teacher”中。您可以根据需要移动或删除它。
            this.teacherTableAdapter.Fill(this.softDataSet1.teacher);

        }

        private void skinDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //获取行号
            int rowindex = e.RowIndex;
            string value0 = skinDataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string value1 = skinDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            string value2 = skinDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            string value3 = skinDataGridView1.Rows[rowindex].Cells[3].Value.ToString();



            string sql = "UPDATE teacher SET tno = '" + value0 + "',tname = '" + value1 + "', tsex = '" + value2 + "', tduties='" + value3 + "' WHERE tno = '" +value0 + "'";

            //string sql = "update  grade  set grade='" + value3 + "' where sno='" + value0 + "'and cno='" + value1 + "'and tno='" + value2 + "'";
            if (op.OPSQL(sql))
            {
                //修改成功
                label1.Text = "更新教师信息成功!! 职工号：" + value0 + " 行号：" + rowindex;
                //MessageBox.Show("修改成功！");

            }
            else
            {
                MessageBox.Show("更新教师信息成功!!职工号：" + value0 + " 行号：" + rowindex);
                label1.Text = "更新教师信息失败!! 职工号：" + value0 + " 行号：" + rowindex;
            }
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
           
        }

        

        private void skinDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void skinDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
