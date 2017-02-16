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

namespace 教务管理系统.教师模块
{
    public partial class 成绩录入 : Form
    {
        public 成绩录入()
        {
            InitializeComponent();
        }

        Opreate op = new Opreate();
        private void 成绩录入_Load(object sender, EventArgs e)
        {
            this.Text = "成绩录入 - " + User.getuName();

            DataTable dt = op.GetDataTable("SELECT sno, cno, tno, grade FROM dbo.grade where tno='"+User.getuNo()+"'", "grade");
            skinDataGridView1.DataSource = dt;

            skinDataGridView1.Columns[0].ReadOnly = true;
            skinDataGridView1.Columns[1].ReadOnly = true;
            skinDataGridView1.Columns[2].ReadOnly = true;

            // TODO: 这行代码将数据加载到表“softDataSet.grade”中。您可以根据需要移动或删除它。
            //this.gradeTableAdapter.Fill(this.softDataSet.grade);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gradeTableAdapter.FillBy(this.softDataSet.grade);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void skinDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //获取行号
            int rowindex = e.RowIndex;
            string value0 = skinDataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string value1 = skinDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            string value2 = skinDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            string value3 = skinDataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            

            string sql = "update  grade  set grade='" + value3 + "' where sno='" + value0 + "'and cno='"+value1+"'and tno='"+value2+"'";
            if (op.OPSQL(sql))
            {
                //修改成功
                skinLabel1.Text = "更新成绩成功!! 学号：" +value0 +" 行号："+rowindex;
                //MessageBox.Show("修改成功！");

            }
            else {
                MessageBox.Show("更新成绩成功!!学号：" +value0 +" 行号："+rowindex);
                skinLabel1.Text = "更新成绩失败!! 学号：" + value0 + " 行号：" + rowindex;                
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gradeTableAdapter.FillBy1(this.softDataSet.grade);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void skinDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
