using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理_demo.成绩管理
{
    public partial class 成绩信息修改 : Form
    {
        Opreate op = new Opreate();
        public 成绩信息修改()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sno = (comboBox2.Text.ToString()).Split('-')[0];
            SqlConnection Conn = op.conn();//到sqlsever的连接 
            Conn.Open();
            string gradeString = "select grade from score where sno = '" + sno + "'";


            SqlCommand cmd = new SqlCommand(gradeString, Conn);
            textBox1.Text = cmd.ExecuteScalar().ToString();//C# 如何把数据库的查询语句查出来的值赋给某一变量

           /* if (!Regex.IsMatch(textBox1.Text, "^[1-9]"))
            {
                MessageBox.Show("输入正确的学分!", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string sno = (comboBox2.Text.ToString()).Split('-')[0];
                string cno = (selectCourse.Text.ToString().Split('-'))[0];
                string sql = "insert into score(sno,cno,grade) values('" + sno + " ','" + cno + " '," + textBox1.Text.ToString() + ")";
                //insert into course(cno, cname, ccategory, credit)
                if (op.OPSQL(sql))
                {
                    ClearText();
                    MessageBox.Show("新建成功！");
                }
                else
                {
                    MessageBox.Show("创建失败！");
                }
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> selectSnoAndName = op.retSnoAndNameFromMajor(comboBox1.Text.ToString());
            comboBox2.Items.Clear();
            for (int i = 0; i < selectSnoAndName.Count; i++)
            {
                comboBox2.Items.Add(selectSnoAndName[i]);
            }
            comboBox2.Text = "";
            selectCourse.Text = "";
            textBox1.Text = "";
        }

        private void 成绩信息修改_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] snoAndName = (comboBox2.Text.ToString()).Split('-');
            List<string> selectCnoAndCname = op.retSelectCnoAndCname(snoAndName[0]);
            selectCourse.Items.Clear();
            for (int i = 0; i < selectCnoAndCname.Count; i++)
            {
                selectCourse.Items.Add(selectCnoAndCname[i]);
            }
            selectCourse.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, "^[1-9]"))
            {
                MessageBox.Show("输入正确的学分!", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string sno = (comboBox2.Text.ToString()).Split('-')[0];
                string cno = (selectCourse.Text.ToString().Split('-'))[0];
               // string sql = "insert into score(sno,cno,grade) values('" + sno + " ','" + cno + " '," + textBox1.Text.ToString() + ")";

                string sql = "update score set grade = '"+ textBox1.Text +"' where sno = '"+sno+ "' and cno = '" + cno +"';";
                //insert into course(cno, cname, ccategory, credit)
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
        }
        public void ClearText()//清空数据
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            selectCourse.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sno = (comboBox2.Text.ToString()).Split('-')[0];
            string cno = (selectCourse.Text.ToString().Split('-'))[0];
            string sql = "delete from score where sno='" + sno + "' and cno = '" + cno + "';";

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
    }
}
