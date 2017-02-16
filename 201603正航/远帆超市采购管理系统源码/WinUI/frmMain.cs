using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BIL;


namespace WinUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        
        private void 商品类型管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Set.User.Purview == Set.Ordinarily)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }

            foreach(Form f in this.MdiChildren)
            {
                if (f is frmMType)
                {
                    f.Activate();
                    return;
                }
            }
            frmMType frm = new frmMType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 商品信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Set.User.Purview == Set.Ordinarily)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }

            foreach (Form f in this.MdiChildren)
            {
                if (f is frmMInfo)
                {
                    f.Activate();
                    return;
                }
            }
            frmMInfo frm = new frmMInfo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 商品供给管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Set.User.Purview == Set.Ordinarily)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmPurvey)
                {
                    f.Activate();
                    return;
                }
            }

            frmPurvey frm = new frmPurvey();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void 供应商类型管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Set.User.Purview == Set.Ordinarily)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }

            foreach (Form f in this.MdiChildren)
            {
                if (f is frmPType)
                {
                    f.Activate();
                    return;
                }
            }
            frmPType frm = new frmPType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 供应商信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Set.User.Purview == Set.Ordinarily)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }

            foreach (Form f in this.MdiChildren)
            {
                if (f is frmPInfo)
                {
                    f.Activate();
                    return;
                }
            }
            frmPInfo frm = new frmPInfo();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 增加定单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmAdd)
                {
                    f.Activate();
                    return;
                }
            }
            frmAdd frm = new frmAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 定单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Set.User.Purview != Set.Admin)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmManage)
                {
                    f.Activate();
                    return;
                }
            }
            frmManage frm = new frmManage();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 库存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Set.User.Purview == Set.Ordinarily)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmRepertory)
                {
                    f.Activate();
                    return;
                }
            }
            frmRepertory frm = new frmRepertory();
            frm.MdiParent = this;
            frm.Show();
        }

        
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripUser.Text = Set.User.Name;
            switch(Set.User.Purview)
            {
                case Set.Admin:
                    toolStripQuanXian.Text ="管理员";
                    break;
                case Set.Super:
                    toolStripQuanXian.Text = "高级用户";
                    break;
                case Set.Ordinarily:
                    toolStripQuanXian.Text = "普通用户";
                    break;
            }
        }
        

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Set.User.Purview != Set.Admin)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmSet)
                {
                    f.Activate();
                    return;
                }
            }
            frmSet frm = new frmSet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Set.User.Purview != Set.Admin)
            {
                MessageBox.Show("您的权限不够！");
                return;
            }
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmUserManager)
                {
                    f.Activate();
                    return;
                }
            }
            frmUserManager frm = new frmUserManager();
            frm.MdiParent = this;
            frm.Show(); 
        }

        private void 商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}