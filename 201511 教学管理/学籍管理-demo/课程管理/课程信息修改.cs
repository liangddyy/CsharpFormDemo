using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理_demo.课程管理
{
    public partial class 课程信息修改 : Form
    {
        Opreate op = new Opreate();

        public 课程信息修改()
        {
            InitializeComponent();
        }

        

        public void ClearText()//清空数据
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void Settxt(DataTable dt) //从数据库获得数据
        {
            textBox1.Text = dt.Rows[0]["cno"].ToString();
            textBox2.Text = dt.Rows[0]["cname"].ToString();
            //textBox4.Text = dt.Rows[0]["ccategory"].ToString();
            comboBox1.Text = dt.Rows[0]["ccategory"].ToString();
            textBox3.Text = dt.Rows[0]["credit"].ToString();
        }

        ArrayList arrLstID;
        int pos = 0;
        private void 课程信息修改_Load(object sender, EventArgs e)
        {
            DataTable dt = op.GetDataTable("select cno from course", "course");
            string[] arrID;

            arrID = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
                arrID[i] = dt.Rows[i]["cno"].ToString();

            arrLstID = new ArrayList(arrID);  // array changes to arrayList
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "update  course  set cname='" + textBox2.Text + "',ccategory='" + comboBox1.SelectedItem + "',credit='" + textBox3.Text + "' where cno='" + textBox1.Text+"'";
            if (op.OPSQL(sql))
            {
                ClearText();
                MessageBox.Show("修改成功！");

            }
            else { MessageBox.Show("修改失败！"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            DataTable dt = op.GetDataTable("select * from course where cno='" + arrLstID[0] + "'", "course");
            pos = 0;
            Settxt(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (pos > 0)
                    pos--;
                else
                {
                    MessageBox.Show("数据超出操作范围");
                    return;
                }

                DataTable dt = op.GetDataTable("select  * from course where cno='" + arrLstID[pos]+"'", "course");
                Settxt(dt);
            }
            else
            {
                MessageBox.Show("操作有误！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3
            if (textBox1.Text != "")
            {
                if (pos < arrLstID.Count - 1)
                    pos++;
                else
                {
                    MessageBox.Show("数据超出操作范围");
                    return;
                }

                DataTable dt = op.GetDataTable("select * from course where cno='" + arrLstID[pos]+"'", "course");
                Settxt(dt);
            }
            else
            {
                MessageBox.Show("操作有误！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4
            DataTable dt = op.GetDataTable("select * from course where cno='" + arrLstID[arrLstID.Count - 1] + "'", "course");
            pos = arrLstID.Count - 1;
            Settxt(dt);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "delete from course  where cno='" + arrLstID[pos] + "'";
            arrLstID.RemoveAt(pos);

            if (op.OPSQL(sql))
            {
                ClearText();
                MessageBox.Show("删除成功！");
            }
            else { MessageBox.Show("删除失败！"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
