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
    public partial class frmSelectMInfo : Form
    {
        public frmSelectMInfo()
        {
            InitializeComponent();
        }

        private void frmSelectMInfo_Load(object sender, EventArgs e)
        {
            fillListView();
        }
        /// <summary>
        /// Ìî³äÊý¾Ýµ½ListView
        /// </summary>
        private void fillListView()
        {
            this.lvMType.Items.Clear();
            foreach (PurveyData p in PurveyCortrol.ls)
                if (p.PInfoID == this.pid.ID)
                    addMIinfo(MInfoCortrol.getMInfoOfID(p.MInfoID));
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

        bool ok = false;
        PurveyInfoData pid = null;
        public Object ShowSelect(PurveyInfoData p)
        {
            this.pid = p;
            this.ShowDialog();
            if (this.lvMType.SelectedItems.Count == 0)
                throw new MessageException("");
            if (ok == false)
                throw new MessageException("");

            return this.lvMType.SelectedItems[0].Tag;
        }

        private void lvMType_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvMType.SelectedItems.Count == 0)
                return;
            ok = true;
            this.Close();
        }

    }
}