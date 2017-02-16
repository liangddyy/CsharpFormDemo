using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Mange_Teacher_Change : Form
    {
        Opreate op = new Opreate();
        public Mange_Teacher_Change()
        {
            InitializeComponent();
        }

        private void Mange_Teacher_Change_Load(object sender, EventArgs e)
        {
            skinTextBox1.ReadOnly = true;
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new Opreate().conn();//到sqlsever的连接  
            Conn.Open();
            string Sql = "select top 1 * from teacher order by tno";
            SqlCommand comm = new SqlCommand(Sql, Conn);                     //command对象          
            SqlDataReader dr = comm.ExecuteReader();                               //定义数据读取对象
            if (dr.Read())
            {
                skinTextBox1.Text = (string)dr.GetValue(0);
                skinTextBox2.Text = (string)dr.GetValue(1);
                skinComboBox1.Text = (string)dr.GetValue(2);
                skinComboBox2.Text = dr.GetValue(3).ToString();
               

            }
            Conn.Close();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new Opreate().conn();//到sqlsever的连接  
            Conn.Open();
            string Sql = "select top 1 * from teacher where tno<'" + skinTextBox1.Text + "' order by tno desc";
            SqlCommand comm = new SqlCommand(Sql, Conn);                     //command对象          
            SqlDataReader dr = comm.ExecuteReader();                               //定义数据读取对象
            if (dr.Read())
            {
                skinTextBox1.Text = (string)dr.GetValue(0);
                skinTextBox2.Text = (string)dr.GetValue(1);
                skinComboBox1.Text = (string)dr.GetValue(2);
                skinComboBox2.Text = dr.GetValue(3).ToString();

            }
            Conn.Close();
        }

        private void skinButton5_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new Opreate().conn();//到sqlsever的连接  
            Conn.Open();
            string Sql = "select top 1 * from teacher where tno>'" + skinTextBox1.Text + "' order by tno";
            SqlCommand comm = new SqlCommand(Sql, Conn);                     //command对象          
            SqlDataReader dr = comm.ExecuteReader();                               //定义数据读取对象
            if (dr.Read())
            {
                skinTextBox1.Text = (string)dr.GetValue(0);
                skinTextBox2.Text = (string)dr.GetValue(1);
                skinComboBox1.Text = (string)dr.GetValue(2);
                skinComboBox2.Text = dr.GetValue(3).ToString();

            }
            Conn.Close();
        }

        private void skinButton7_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new Opreate().conn();//到sqlsever的连接  
            Conn.Open();
            string Sql = "select top 1 * from teacher order by tno desc";
            SqlCommand comm = new SqlCommand(Sql, Conn);                     //command对象          
            SqlDataReader dr = comm.ExecuteReader();                               //定义数据读取对象
            if (dr.Read())
            {
                skinTextBox1.Text = (string)dr.GetValue(0);
                skinTextBox2.Text = (string)dr.GetValue(1);
                skinComboBox1.Text = (string)dr.GetValue(2);
                skinComboBox2.Text = dr.GetValue(3).ToString();

            }
            Conn.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (skinTextBox1.Text != "")
            {
                string sql = "UPDATE teacher SET tno = '" + skinTextBox1.Text + "',tname = '" + skinTextBox2.Text + "', tsex = '" + skinComboBox1.SelectedItem + "', tduties='" + skinComboBox2.SelectedItem + "' WHERE tno = '" + skinTextBox1.Text + "'";

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
                MessageBox.Show("请输入要修改的职工号");
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            string sql;

            sql = "delete from teacher where tno ='" + skinTextBox1.Text + "'";


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

        private void skinButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
