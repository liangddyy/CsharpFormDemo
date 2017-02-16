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
    public partial class 公告栏 : Form
    {
        Opreate op = new Opreate();
        public 公告栏()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                //string sql = "insert into student(sno,sname,ssex,sclass,zno,Admission_time,Graduation_time,inschool) values('" + skinTextBox1.Text.ToString() + "','" 
                //  + skinTextBox2.Text + "','" + skinComboBox1.SelectedItem + "','" + skinTextBox3.Text + "','" 
                //+ skinComboBox2.SelectedItem + "','" + dateTimePicker1.Value + "','" 
                //+ dateTimePicker2.Value + "'," + skinComboBox3.SelectedItem + ")";

                string sql = "insert into Notice(datetime,text) values('"
                    + label1.Text + "','"
                    + richTextBox1.Text + "')";


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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
