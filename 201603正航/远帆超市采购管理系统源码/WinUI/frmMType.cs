using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BIL;
using model;
using System.Data.SqlClient;

namespace WinUI
{
    public partial class frmMType : Form
    {
        public frmMType()
        {
            InitializeComponent();
        }

        private void btnAccession_Click(object sender, EventArgs e)
        {

            try
            {

                if (this.mTypeTreeView1.tvMType.SelectedNode == null)
                    throw new MessageException("请选择父项目！");
                frmInput ipt = new frmInput("请输入商品类型：");
                string str = ipt.ShowInput();
                MerchandiseTypeData mtd = new MerchandiseTypeData();
                mtd.Name = str;
                mtd.ParentID = Convert.ToInt32(this.mTypeTreeView1.tvMType.SelectedNode.Tag);
                int i = MTypeCortrol.addTypeName(mtd);
                TreeNode tn = new TreeNode(str);
                tn.Tag = i;
                this.mTypeTreeView1.tvMType.SelectedNode.Nodes.Add(tn);

            }

            catch (MessageException ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMType_Load(object sender, EventArgs e)
        {
           
        }

        private void tvMType_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
           // 
        }

        private void btnAmend_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode tn = this.mTypeTreeView1.tvMType.SelectedNode;
                if (tn == null)
                    throw new MessageException("请选择要修改的项目！");
                else if (Convert.ToInt32(tn.Tag) == 1)
                    throw new MessageException("该项目不能修改！");
                frmInput ipt = new frmInput("请输入新类型名：",tn.Text);
                string str = ipt.ShowInput();
                MerchandiseTypeData mtd = new MerchandiseTypeData();
                mtd.ID=Convert.ToInt32(tn.Tag);
                mtd.Name=str;
                mtd.ParentID=Convert.ToInt32(tn.Parent.Tag);
                MTypeCortrol.updTypeName(mtd);
                
                tn.Text = str;
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode tn = this.mTypeTreeView1.tvMType.SelectedNode;
                if (tn == null)
                    throw new MessageException("请选择要删除的项目！");
                else if (Convert.ToInt32(tn.Tag) == 1)
                    throw new MessageException("该项目不能删除！");
                else if (MTypeCortrol.checkChild(Convert.ToInt32(tn.Tag)))
                    throw new MessageException("该项目下有子项目不能删除！");
                MerchandiseTypeData mtd = new MerchandiseTypeData();
                mtd.ID = Convert.ToInt32(tn.Tag);
                mtd.Name = tn.Text;
                mtd.ParentID = Convert.ToInt32(tn.Parent.Tag);
                MTypeCortrol.delTypeName(mtd);
                this.mTypeTreeView1.tvMType.Nodes.Remove(tn);
            }
            catch (SqlException)
            {
                MessageBox.Show("该类型正在被使用，不能删除！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvMType_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}