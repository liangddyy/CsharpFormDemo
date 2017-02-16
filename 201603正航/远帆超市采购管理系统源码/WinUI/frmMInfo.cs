using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using model;
using BIL;
using System.Data.SqlClient;

namespace WinUI
{
    public partial class frmMInfo : Form
    {
        public frmMInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectMType frmSM = new frmSelectMType();
                MerchandiseTypeData mtd = (MerchandiseTypeData)frmSM.ShowSelect();
                this.txtGenre.Tag = mtd;
                this.txtGenre.Text = mtd.Name;
            }
            catch (MessageException ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
        }

       

        private void frmMInfo_Load(object sender, EventArgs e)
        {
            fillListView();
        }
        /// <summary>
        /// 填充数据到ListView
        /// </summary>
        private void fillListView()
        {
            this.lvMType.Items.Clear();
            foreach (MerchandiseInfoData mid in MInfoCortrol.ls)
                addMIinfo(mid);
        }

        private void addMIinfo(MerchandiseInfoData mid)
        {
            try
            {
                ListViewItem lvi = new ListViewItem(mid.Name);
                lvi.Tag = mid;
                ListViewItem.ListViewSubItem lvs = new ListViewItem.ListViewSubItem();

                MerchandiseTypeData mtd = MTypeCortrol.getMTypeOfID(mid.TypeID);
                lvs.Text = mtd.Name;
                lvs.Tag = mtd;

                lvi.SubItems.Add(lvs);
                lvi.SubItems.Add(mid.Quantity.ToString());
                this.lvMType.Items.Add(lvi);
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvMType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvMType.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.lvMType.SelectedItems[0];
                MerchandiseInfoData mid = (MerchandiseInfoData)lvi.Tag;
                this.txtName.Text = mid.Name;
                this.txtGenre.Tag = lvi.SubItems[1].Tag;
                this.txtGenre.Text = lvi.SubItems[1].Text;
                this.txtQuantity.Text = mid.Quantity.ToString();
            }
        }
        /// <summary>
        /// 检测用户输入
        /// </summary>
        private void checkText()
        {
            if (this.txtName.Text.Length == 0)
                throw new MessageException("请输入商品名！");
            else if (this.txtGenre.Tag == null)
                throw new MessageException("请选择企业类型！");
            else if (this.txtQuantity.Text.Length == 0)
                throw new MessageException("请输入日销售量！");
        }
        /// <summary>
        /// 清除用户输入
        /// </summary>
        private void clear()
        {
            this.txtName.Text = "";
            this.txtGenre.Text = "";
            this.txtGenre.Tag = null;
            this.txtQuantity.Text = "";
        }
        private void buttobtnAccessionn2_Click(object sender, EventArgs e)
        {
            try
            {
                checkText();
                MerchandiseInfoData mid = new MerchandiseInfoData();
                mid.Name = this.txtName.Text;
                mid.TypeID = ((MerchandiseTypeData)this.txtGenre.Tag).ID;
                mid.Quantity = Convert.ToInt32(this.txtQuantity.Text);
                mid.ID = MInfoCortrol.addMnfo(mid);
                addMIinfo(mid);
                clear();
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 根据用户的输入组成新类
        /// </summary>
        /// <returns></returns>
        private MerchandiseInfoData getMInfo()
        {
            MerchandiseInfoData mid = new MerchandiseInfoData();
            mid.Name = this.txtName.Text;
            mid.TypeID = ((MerchandiseTypeData)this.txtGenre.Tag).ID;
            mid.Quantity=Convert.ToInt32(this.txtQuantity.Text);
            return mid;
        }

        private void btnAmend_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvMType.SelectedItems.Count == 0)
                    throw new MessageException("请选择要修改的项目！");

                checkText();

                MerchandiseInfoData mid = getMInfo();
                mid.ID = ((MerchandiseInfoData)this.lvMType.SelectedItems[0].Tag).ID;

                MInfoCortrol.updMInfo(mid);

                ListViewItem lvi = new ListViewItem(mid.Name);
                lvi.Tag = mid;
                ListViewItem.ListViewSubItem lvs = new ListViewItem.ListViewSubItem();

                MerchandiseTypeData ptd = MTypeCortrol.getMTypeOfID(mid.TypeID);
                lvs.Text = ptd.Name;
                lvs.Tag = ptd;

                lvi.SubItems.Add(lvs);
                lvi.SubItems.Add(mid.Quantity.ToString());

                this.lvMType.Items[this.lvMType.SelectedIndices[0]] = lvi;
                clear();
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvMType.SelectedItems.Count == 0)
                    throw new MessageException("请选择要删除的项目！");
                DialogResult dr = MessageBox.Show("您确定要删除该项目吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.No)
                {
                    MInfoCortrol.delMInfo((MerchandiseInfoData)this.lvMType.SelectedItems[0].Tag);
                    this.lvMType.Items.RemoveAt(this.lvMType.SelectedIndices[0]);
                }
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException)
            {
                MessageBox.Show("该项目正在被使用，无法删除！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmInput fipt = new frmInput("请输入任意关键字进行搜索");
                string str = fipt.ShowInput();
                foreach (ListViewItem lvi in this.lvMType.Items)
                {
                    bool ok = false;
                    foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                    {
                        if (lvs.Text.IndexOf(str) != -1)
                        {
                            ok = true;
                            break; ;
                        }
                    }
                    if (ok == false)
                        this.lvMType.Items.Remove(lvi);
                }
                clear();
            }
            catch (MessageException ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MTypeCortrol.ls = MTypeCortrol.getPType();
            fillListView();
            clear();
        }
    }
}