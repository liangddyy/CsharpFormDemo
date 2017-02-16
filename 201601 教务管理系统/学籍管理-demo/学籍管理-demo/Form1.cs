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
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }
        
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new addStudentFrm();
            frm2.Show();
            /* this.Hide();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                Show();
            }*/
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                
                Application.Exit();//退出整个应用程序
            }
            else
            {
                e.Cancel = true;  //取消关闭事件
            }
        }

        private void 学籍信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = new delStudentFrm();
            frm3.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
