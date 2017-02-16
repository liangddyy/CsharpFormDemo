using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理_demo.课程管理
{
    public partial class 课程信息添加 : Form
    {
        Opreate op = new Opreate();
        public 课程信息添加()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                string sql = "insert into course(cno,cname,ccategory,credit) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem + "','" + textBox1.Text + "')";

                if (op.OPSQL(sql))
                {
                    MessageBox.Show("课程添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            else
            {
                MessageBox.Show("信息输入不全！");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
