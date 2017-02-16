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

namespace 教务管理系统.学生模块
{
    public partial class 学生选课 : Form
    {
        public 学生选课()
        {
            InitializeComponent();
        }
        Opreate op = new Opreate();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cno = (comboBox1.Text.ToString()).Split('-')[0];
            SqlConnection Conn = op.conn();//到sqlsever的连接 
            Conn.Open();
            string strCmd = "select credit from course where cno = '" + cno + "'";


            SqlCommand cmd = new SqlCommand(strCmd, Conn);
            textBox1.Text = cmd.ExecuteScalar().ToString();//C# 如何把数据库的查询语句查出来的值赋给某一变量
            textBox1.ReadOnly = true;
            
        }

        private void 学生选课_Load(object sender, EventArgs e)
        {
            List<string> selectCnoAndCname = op.getCnoAndCnameStu();
            comboBox1.Items.Clear();
            for (int i = 0; i < selectCnoAndCname.Count; i++)
            {
                comboBox1.Items.Add(selectCnoAndCname[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("请选择课程！");
                return;
            }
            else
            {
                string sno = User.getuNo();
                string cno = (comboBox1.Text.ToString().Split('-'))[0];

                //获取该课程的授课老师编号
                string sql = "select tno from Teacher_teaching where cno ='" + cno + "'";
                string tno = op.FiledValue(sql);
                if (tno != "")
                {
                    sql= "insert into grade(sno,cno,tno)values ('" + sno + "','" + cno + "','" + tno + "');";
                    if (op.OPSQL(sql))
                    {
                        MessageBox.Show("选课成功");
                    }
                }
                else
                {
                    MessageBox.Show("该课程还未安排老师");
                }
            }
        }
    }
}
