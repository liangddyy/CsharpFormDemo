using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理_demo
{
    public partial class addStudentFrm : Form
    {
        Opreate op = new Opreate();
        public addStudentFrm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /*
        private void addStudentFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }*/


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                string sql = "insert into student(sno,sname,ssex,date,nation,nativeplace,grade,profession,scholarship) values('" + txtID.Text + "','" + txtName.Text + "','" + comboSex.SelectedItem + "','" + dateTime.Value + "','" + txtNation.Text + "','" + txtNative.Text + "','" + txtScore.Text + "','" + comboMajor.SelectedItem + "','" + txtGrant.Text + "')";


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
                string sql = "UPDATE student SET sno = '" + txtID.Text + "',sname = '" + txtName.Text + "', ssex = '" + comboSex.SelectedItem + "',date='" + dateTime.Value + "',nation='" + txtNation.Text + "',nativeplace='" + txtNative.Text + "',grade='" + txtScore.Text + "',profession='" + comboMajor.SelectedItem + "',scholarship='" + txtGrant.Text + "' WHERE sno = '" + txtID.Text + "'";
                
                //string sql = "insert into student(sno,sname,ssex,date,nation,nativeplace,grade,profession,scholarship) values('" + txtID.Text + "','" + txtName.Text + "','" + comboSex.SelectedItem + "','" + dateTime.Value + "','" + txtNation.Text + "','" + txtNative.Text + "','" + txtScore.Text + "','" + comboMajor.SelectedItem + "','" + txtGrant.Text + "')";

                if (op.OPSQL(sql))
                {
                    //ClearText();
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            else
            {
                MessageBox.Show("请输入要修改的学号");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql;
            if (deleteTXT.Text.Equals("*"))
            {
                
                if (DialogResult.Yes != MessageBox.Show("你确定要删除所有内容吗？此操作不可恢复！ ", "确认删除？", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) return;
                else
                {
                   sql = "delete student";
                }
            }
            else
            {
                sql = "delete from student where " + deleteComboBox.Text + "='" + deleteTXT.Text + "'";
            }

            if (op.OPSQL(sql))
            {
                //ClearText();
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = new delStudentFrm();

            frm3.ShowDialog(this);
        }
    }
}
