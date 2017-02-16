using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

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

        private void comboMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "update student SET inschool=0 where Graduation_time<getdate()";
            if (op.OPSQL(sql))
            {
                //ClearText();
                MessageBox.Show("更改成功！");
            }
            else
            {
                MessageBox.Show("更改失败失败！请重试！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
