using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Mange_Student_Add : Form
    {
        Opreate op = new Opreate();
        public Mange_Student_Add()
        {
            InitializeComponent();
        }

        private void skinLabel8_Click(object sender, EventArgs e)
        {

        }

        private void skinTextBox3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (skinTextBox1.Text != "")
            {
                //string sql = "insert into student(sno,sname,ssex,sclass,zno,Admission_time,Graduation_time,inschool) values('" + skinTextBox1.Text.ToString() + "','" 
                //  + skinTextBox2.Text + "','" + skinComboBox1.SelectedItem + "','" + skinTextBox3.Text + "','" 
                //+ skinComboBox2.SelectedItem + "','" + dateTimePicker1.Value + "','" 
                //+ dateTimePicker2.Value + "'," + skinComboBox3.SelectedItem + ")";
                string sql = "insert into student(sno,sname,ssex,sclass,zno,Admission_time,Graduation_time,inschool) values('" + skinTextBox1.Text + "','"
                + skinTextBox2.Text + "','" + skinComboBox1.SelectedItem + "','" + skinTextBox3.Text + "','" 
                + skinComboBox2.SelectedItem + "','" + dateTimePicker1.Value + "','" 
                + dateTimePicker2.Value + "'," + skinComboBox3.SelectedItem + ")";


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

        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (skinTextBox1.Text != "")
            {
                string sql = "UPDATE student SET sname = '"
                + skinTextBox2.Text + "',ssex = '" 
                + skinComboBox1.SelectedItem + "',sclass = '" 
                + skinTextBox3.Text + "',zno = '"
                + skinComboBox2.SelectedItem + "',Admission_time = '" 
                + dateTimePicker1.Value + "',Graduation_time = '"
                + dateTimePicker2.Value + "',inschool = " 
                + skinComboBox3.SelectedItem + " WHERE sno = '" 
                + skinTextBox1.Text + "'";


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

        private void skinButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mange_Student_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
