using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务管理系统.教务员模块
{
    public partial class 学生信息管理 : Form
    {
        Opreate op = new Opreate();
        public 学生信息管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                //string sql = "insert into student(sno,sname,ssex,sclass,zno,spsw,Admission_time,Graduation_time,inschool) values('" + txtID.Text + "','" + txtName.Text + "','" + comboSex.SelectedItem + "','" + txtclass.Text + "','" + txtzno.Text + "','123','" + dateTime.Value + "','" + dateTime1.Value + "','" + comboBox1.SelectedItem + "')";
                string sql = "insert into student(sno,sname,ssex,sclass,zno,spsw,Admission_time,Graduation_time,inschool)values ('" + txtID.Text + "','" + txtName.Text + "','" + comboSex.SelectedItem + "','" + txtclass.Text + "','" + txtzno.Text + "','123','" + dateTime.Value + "','" + dateTime1.Value + "','" + comboBox1.SelectedItem + "')";

                if (op.OPSQL(sql))
                {
                    //ClearText();
                    MessageBox.Show("新建成功！");
                }
                else
                {
                    MessageBox.Show("创建失败！");
                }
            }
            else
            {
                MessageBox.Show("信息输入不全！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                string sql = "UPDATE student SET sno = '" + txtID.Text + "',sname = '" + txtName.Text + "', ssex = '" + comboSex.SelectedItem + "',sclass='" + txtclass.Text + "',zno='" + txtzno.Text + "',spsw='123',Admission_time='" + dateTime.Value + "',Graduation_time='" + dateTime1.Value + "',inschool='" + comboBox1.SelectedItem + "' WHERE sno = '" + txtID.Text + "'";

                //string sql = "insert into student(sno,sname,ssex,date,nation,nativeplace,grade,profession,scholarship) values('" + txtID.Text + "','" + txtName.Text + "','" + comboSex.SelectedItem + "','" + dateTime.Value + "','" + txtNation.Text + "','" + txtNative.Text + "','" + txtScore.Text + "','" + comboMajor.SelectedItem + "','" + txtGrant.Text + "')";

                if (op.OPSQL(sql))
                {
                    //ClearText();
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    MessageBox.Show("更新失败！该生为毕业生，无法修改！");
                }
            }
            else
            {
                MessageBox.Show("请输入要修改的学号");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string sql = "DELETE from student where sno= '" + txtID.Text + "'";


            if (op.OPSQL(sql))
            {
                //ClearText();
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！该生为毕业生，无法删除！");
            }
        }

        private void 学生信息管理_Load(object sender, EventArgs e)
        {
            DataTable dt = op.GetDataTable("SELECT sno,sname,ssex,sclass,zno,Admission_time,Graduation_time,inschool FROM student;", "student");
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            
            panel1.Hide();
        }

        private void 可视化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //获取行号
            int rowindex = e.RowIndex;
            string sno = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string sname = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            string ssex = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            string sclass = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            string zno= dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            string admission= dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            string guaduate= dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
            string inschool= dataGridView1.Rows[rowindex].Cells[7].Value.ToString();

            string sql = "update student set sname='"+sname+"',ssex = '"+ssex+"',sclass='"+sclass+"',zno='"+zno+ "',Admission_time = '"+admission+"',Graduation_time = '"+guaduate+"',inschool='"+inschool+"'WHERE sno = '"+sno+"'";

            //
            if (op.OPSQL(sql))
            {
                //修改成功
                skinLabel1.Text = "更新成绩成功!! 学号：" + sno + " 行号：" + rowindex;
                //MessageBox.Show("修改成功！");

            }
            else
            {
                MessageBox.Show("更新成绩失败!!学号：" + sno + " 行号：" + rowindex);
                skinLabel1.Text = "更新成绩失败!! 学号：" + sno + " 行号：" + rowindex;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
