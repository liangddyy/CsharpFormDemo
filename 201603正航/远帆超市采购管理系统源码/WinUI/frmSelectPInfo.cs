using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BIL;
using model;

namespace WinUI
{
    public partial class frmSelectPInfo : Form
    {
        public frmSelectPInfo()
        {
            InitializeComponent();
        }

        private void frmSelectPInfo_Load(object sender, EventArgs e)
        {

            fillListView();
        }
        /// <summary>
        /// 填充数据到ListView
        /// </summary>
        private void fillListView()
        {
            this.lvPureves.Items.Clear();
            foreach (PurveyInfoData pid in PInfoCortrol.ls)
                addPurevey(pid);
        }
        /// <summary>
        /// 向ListView里插入一条记录
        /// </summary>
        /// <param name="pid"></param>
        private void addPurevey(PurveyInfoData pid)
        {
            try
            {
                ListViewItem lvi = new ListViewItem(pid.Name);
                lvi.Tag = pid;
                ListViewItem.ListViewSubItem lvs = new ListViewItem.ListViewSubItem();
                PurveyTypeData ptd = PTypeCortrol.getPTypeOfID(pid.PTypeID);
                lvs.Text = ptd.TypeName;
                lvs.Tag = ptd;
                lvi.SubItems.Add(lvs);
                lvi.SubItems.Add(pid.Days.ToString());
                lvi.SubItems.Add(pid.LinkMan);
                lvi.SubItems.Add(pid.Tel);
                lvi.SubItems.Add(pid.Fox);
                lvi.SubItems.Add(pid.Email);
                
                lvi.SubItems.Add(pid.Address);
                this.lvPureves.Items.Add(lvi);
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        bool ok = false;
        public Object ShowSelect()
        {
            this.ShowDialog();
            if (this.lvPureves.SelectedItems.Count == 0)
                throw new MessageException("");
            if (ok == false)
                throw new MessageException("");

            return this.lvPureves.SelectedItems[0].Tag;
        }

        private void lvPureves_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvPureves.SelectedItems.Count == 0)
                return;
            ok = true;
            this.Close();
        }
    }
}