using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace ManageAddress
{   
    public partial class FrmMain : Form
    {
        Opreate op = new Opreate();

        public FrmMain()
        {
            InitializeComponent();
        }
  
        private void btnCreate_Click(object sender, EventArgs e)
        {//新建数据
            string id = op.FiledValue("select top 1 id from Friendtbl order by id desc ");
            txtID.Text = (int.Parse(id) + 1) + "";  //此时ID为要添加的数据记录的ID
            txtID.Enabled = false;//设置txtId为不可输入状态
            txtName.Text = "";//清空输入项
            txtAge.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
        }
        public void ClearText()//清空数据
        {
            txtID.Text = "";
            txtName.Text = ""; 
            txtAge.Text = "";
            txtTel.Text = ""; 
            txtMail.Text = "";
        }
    

        private void btnAdd_Click(object sender, EventArgs e)//向通讯录添加数据
        {  //输入项控制，检输入项是否为空，必须全部不为空，允许空格
            if (txtName.Text != "" && txtAge.Text != "" && txtTel.Text != "" && txtMail.Text != "")
            {   //邮件输入项简单的正则验证
                if ((!this.txtMail.Text.Contains("@")) || (!this.txtMail.Text.Contains(".")))
                {
                    MessageBox.Show("输入正确的邮箱地址!", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    string sql = "insert into Friendtbl(name,age,tel,mail) values('" + txtName.Text + "'," + txtAge.Text + ",'" + txtTel.Text + "','" + txtMail.Text + "')";
                    if (op.OPSQL(sql))
                    {
                        ClearText();
                        MessageBox.Show("新建成功！");
                    }
                    else
                    {
                        MessageBox.Show("创建失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请填写详细信息！");
            }
        }

        private void btnAdit_Click(object sender, EventArgs e)//修改数据
        {            
            string sql = "update  Friendtbl  set name='"+txtName.Text+"',age="+txtAge.Text+",tel='"+txtTel.Text+"',mail='"+txtMail.Text+"' where id="+txtID.Text;
            if (op.OPSQL(sql))
            {
                ClearText();
                MessageBox.Show("修改成功！");

            }
            else { MessageBox.Show("修改失败！"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)//删除数据
        {
            string sql = "delete from Friendtbl  where id='" + arrLstID[pos] + "'";
            arrLstID.RemoveAt(pos);
                       
            if (op.OPSQL(sql))
            {
                ClearText();
                MessageBox.Show("删除成功！");
            }
            else { MessageBox.Show("删除失败！"); }
        }
        private void Settxt(DataTable dt) //从数据库获得数据
        {  
            txtName.Text = dt.Rows[0]["name"].ToString();
            txtID.Text = dt.Rows[0]["id"].ToString();
            txtAge.Text = dt.Rows[0]["age"].ToString();
            txtTel.Text = dt.Rows[0]["tel"].ToString();
            txtMail.Text = dt.Rows[0]["mail"].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)//显示最前面的一条数据
        {   
            // DataTable dt = op.GetDataTable("select top 1 * from Friendtbl order by id asc", "Friendtbl");
            DataTable dt = op.GetDataTable("select * from Friendtbl where id='"+ arrLstID[0] +"'", "Friendtbl");
            pos = 0;
            Settxt(dt);
        }

        private void btnEnd_Click(object sender, EventArgs e)//最后一条数据
        {
            DataTable dt = op.GetDataTable("select * from Friendtbl where id='" + arrLstID[arrLstID.Count-1] + "'", "Friendtbl");
            pos = arrLstID.Count - 1;
            Settxt(dt);
        }

        private void btnBack_Click(object sender, EventArgs e) //前一条数据
        {
            if (txtID.Text != "")
            {
                if (pos > 0)
                    pos--;
                else
                {
                    MessageBox.Show("数据超出操作范围");
                    return;
                }

                DataTable dt = op.GetDataTable("select  * from Friendtbl where id=" + arrLstID[pos], "Friendtbl");
                Settxt(dt);
            }
            else
            {
                MessageBox.Show("操作有误！");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)//后一条数据
        {  
            if (txtID.Text != "")
            {
                if (pos < arrLstID.Count - 1)
                    pos++;
                else
                {
                    MessageBox.Show("数据超出操作范围");
                    return;
                }

                DataTable dt = op.GetDataTable("select  * from Friendtbl where id=" + arrLstID[pos], "Friendtbl");
                Settxt(dt);
            }
            else
            {
                MessageBox.Show("操作有误！");
            }
        }

        ArrayList arrLstID;
        int pos = 0;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DataTable dt = op.GetDataTable("select id from Friendtbl", "Friendtbl");
            string[] arrID;
             
            arrID = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
                arrID[i] = dt.Rows[i]["ID"].ToString();

            arrLstID = new ArrayList(arrID);  // array changes to arrayList
        }

        private void group_Enter(object sender, EventArgs e)
        {

        }
    }
}