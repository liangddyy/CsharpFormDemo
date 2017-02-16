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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        

        private void frmAdd_Load(object sender, EventArgs e)
        {
            try
            {
                string year = DateTime.Now.Year.ToString();
                this.txtNo.Text = year.Substring(2, 2) + toLen(DateTime.Now.Month, 2) + toLen(DateTime.Now.Day, 2) + toLen(StockNoCortrol.No + 1, 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string toLen(int i,int len)
        {
            string no = i.ToString();
            while(no.Length != len)
            {
                    no = "0"+no;
            }
            return no;
        }

        private void btnPInfoID_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvSInfo.Items.Count > 0)
                    throw new MessageException("已经添加了商品，请先清除商品或点重置按钮！");
                frmSelectPInfo fspi = new frmSelectPInfo();
                PurveyInfoData pid = (PurveyInfoData)fspi.ShowSelect();
                this.txtPInfo.Text = pid.Name;
                this.txtPInfo.Tag = pid;
            }
            catch (MessageException ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi =this.lvSInfo.SelectedItems[0];
                if(lvi==null)
                    throw new MessageException("请选择要修改的项目！");
                frmSelectSInfo fss = new frmSelectSInfo();

                StockInfoData sid = fss.showSelect((PurveyInfoData)this.txtPInfo.Tag, 
                    (MerchandiseInfoData)lvi.Tag,lvi.SubItems[1].Text,lvi.SubItems[2].Text);
                addStoctInfo( sid,2);
            }
            catch (MessageException ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPInfo.Tag == null)
                    throw new MessageException("请先选择供应商！");
                frmSelectSInfo fss = new frmSelectSInfo();
                StockInfoData sid = fss.showSelect((PurveyInfoData)this.txtPInfo.Tag);
                addStoctInfo(sid,1);
            }
            catch (MessageException ex)
            {
                if(ex.Message!="")
                    MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 增加或修改一条商品信息
        /// </summary>
        /// <param name="sid">商品</param>
        /// <param name="cortrol">1增加，2修改</param>
        private void addStoctInfo(StockInfoData sid,int cortrol)
        {
            MerchandiseInfoData mid = ((MerchandiseInfoData)MInfoCortrol.getMInfoOfID(sid.MID));
            ListViewItem lvi = new ListViewItem(mid.Name);
            lvi.Tag = mid;
            lvi.SubItems.Add(sid.Quantity.ToString());
            lvi.SubItems.Add(sid.Price.ToString());
            lvi.SubItems.Add(Convert.ToString(sid.Quantity * (double)sid.Price));
            if(cortrol==1)
            this.lvSInfo.Items.Add(lvi);
            else if(cortrol == 2)

            this.lvSInfo.Items[this.lvSInfo.SelectedIndices[0]] = lvi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.lvSInfo.SelectedItems.Count == 0)
                return;
            this.lvSInfo.Items.Remove(this.lvSInfo.SelectedItems[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要清空订单商品信息吗？","询问",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.lvSInfo.Items.Clear();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要清空当前采购单吗？","询问",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
                clear();
        }

        private void clear()
        {
            try
            {
                string year = DateTime.Now.Year.ToString();
                this.txtNo.Text = year.Substring(2, 2) + toLen(DateTime.Now.Month, 2) + toLen(DateTime.Now.Day, 2) + toLen(StockNoCortrol.No + 1, 4);
                this.txtPInfo.Text = "";
                this.txtPInfo.Tag = "";
                this.lvSInfo.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvSInfo.Items.Count == 0)
                    throw new MessageException("该订单没有商品信息！");
                StockData sd = new StockData();
                sd.PInfoID = ((PurveyInfoData)this.txtPInfo.Tag).ID;
                sd.StockDate = Convert.ToDateTime(this.dtp.Value.ToString("d"));
                sd.StockNo = this.txtNo.Text;
                sd.UserID = Set.User.ID;
                List<StockInfoData> ls = new List<StockInfoData>();
                foreach(ListViewItem lvi in this.lvSInfo.Items)
                {
                    StockInfoData sid = new StockInfoData();
                    sid.MID=((MerchandiseInfoData)lvi.Tag).ID;
                    sid.Quantity=Convert.ToInt32(lvi.SubItems[1].Text);
                    sid.Price = Convert.ToDouble(lvi.SubItems[2].Text);
                    ls.Add(sid);
                }
                SotckCortrol.addStock(sd, ls);
                StockNoCortrol.No += 1;
                DialogResult dr = MessageBox.Show("定单已生成，正在等待审核！\n是否继续添加定单？","询问",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    clear();
                else
                    this.Close();
            }
            catch (MessageException ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("订单添加失败！\n错误信息\n" + ex.Message);
            }
        }
    }
}