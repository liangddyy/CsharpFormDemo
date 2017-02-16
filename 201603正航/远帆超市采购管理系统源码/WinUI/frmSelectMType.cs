using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using model;
using BIL;

namespace WinUI
{
    public partial class frmSelectMType : Form
    {
        public frmSelectMType()
        {
            InitializeComponent();
        }

        private void frmSelectMType_Load(object sender, EventArgs e)
        {

        }

        void tvMType_DoubleClick(object sender, EventArgs e)
        {

        }
        bool ok = false;
        /// <summary>
        /// 显示类型选择窗口，如果选择空抛出MessageException异常
        /// </summary>
        /// <returns>返回商品类型类</returns>
        public Object ShowSelect()
        {
            this.ShowDialog();
            if (ok == false)
                throw new MessageException("");
            MerchandiseTypeData mtd = new MerchandiseTypeData();
            mtd.ID = Convert.ToInt32(this.mTypeTreeView.tvMType.SelectedNode.Tag);
            mtd.Name = this.mTypeTreeView.tvMType.SelectedNode.Text;
            mtd.ParentID = Convert.ToInt32(this.mTypeTreeView.tvMType.SelectedNode.Parent.Tag);
            return mtd;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.mTypeTreeView.tvMType.SelectedNode.Tag) == 1)
                MessageBox.Show("不能选择这个项目！");
            else
            {
                ok = true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }
    }
}