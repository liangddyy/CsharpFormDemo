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
    public partial class frmSelectSInfo : Form
    {
        public frmSelectSInfo()
        {
            InitializeComponent();
        }

        private void frmSelectSInfo_Load(object sender, EventArgs e)
        {

        }
        PurveyInfoData pid = null;
        bool ok = false;


        public StockInfoData showSelect(PurveyInfoData p)
        {
            this.pid = p;
            this.ShowDialog();
            if (ok == false)
                throw new MessageException("");

            StockInfoData sid = new StockInfoData();
            sid.MID = ((MerchandiseInfoData)this.txtM.Tag).ID;
            sid.Quantity = Convert.ToInt32(this.txtQuantity.Text);
            sid.Price = Convert.ToDouble(this.txtPrice.Text);
            return sid;
        }

        public StockInfoData showSelect(PurveyInfoData p, MerchandiseInfoData mid, string quantity, string price)
        {
            this.pid = p;
            this.btnYes.Text = "    修改";
            this.txtM.Text = mid.Name;
            this.txtM.Tag = mid;
            this.txtPrice.Text = price;
            this.txtQuantity.Text = quantity;

            this.ShowDialog();
            if (ok == false)
                throw new MessageException("");

            StockInfoData sid = new StockInfoData();
            sid.MID = ((MerchandiseInfoData)this.txtM.Tag).ID;
            sid.Quantity = Convert.ToInt32(this.txtQuantity.Text);
            sid.Price = Convert.ToDouble(this.txtPrice.Text);
            return sid;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtSum.Text = Convert.ToString(Convert.ToInt32(this.txtPrice.Text) * Convert.ToDouble(this.txtQuantity.Text));
            }
            catch (FormatException)
            {
            }
        }

        private void btnPInfoID_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectMInfo fsm = new frmSelectMInfo();
                MerchandiseInfoData mid = (MerchandiseInfoData)fsm.ShowSelect(pid);
                this.txtM.Text = mid.Name;
                this.txtM.Tag = mid;
                foreach (PurveyData pd in PurveyCortrol.ls)
                {
                    if (pd.PInfoID == pid.ID && pd.MInfoID == mid.ID)
                    {
                        this.txtPrice.Text = pd.Price.ToString();
                        this.txtQuantity.ReadOnly = false;
                        this.txtPrice.ReadOnly = false;
                        this.btnNumQuantity.Enabled = true;
                        this.btnNumPrice.Enabled = true;
                        break;
                    }
                }
            }
            catch (MessageException ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtM.Tag == null)
                    throw new MessageException("请选择商品！");
                if (this.txtPrice.Text.Length == 0)
                    throw new MessageException("请输入单价！");
                if (this.txtQuantity.Text.Length == 0)
                    throw new MessageException("请输入数量！");
                ok = true;
                this.Close();
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tx = (TextBox)sender;
            e.Handled = !(tx.Text.IndexOf('.') == -1 || e.KeyChar >= 48 && e.KeyChar <= 57);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tx = (TextBox)sender;
            e.Handled = !(e.KeyChar >= 48 && e.KeyChar <= 57);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Point p = new Point(this.Left+btn.Left,this.Top+btn.Top);
            frmInputNum fin = new frmInputNum(false,p);
            fin.OnInput += new InputNum(fin_OnInput);
            fin.Show();
        }

        void fin_OnInput(char num)
        {
            try
            {
                if (num.ToString() == "B")
                {
                    this.txtQuantity.Text = this.txtQuantity.Text.Substring(0, this.txtQuantity.Text.Length - 1);
                    return;
                }
                
                this.txtQuantity.Text += num.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Point p = new Point(this.Left + btn.Left, this.Top + btn.Top);
            frmInputNum fin = new frmInputNum(true, p);
            fin.OnInput += new InputNum(fin_OnInput1);
            fin.Show();
        }

        void fin_OnInput1(char num)
        {
            try
            {
                if (num.ToString() == "B")
                {
                    this.txtPrice.Text = this.txtPrice.Text.Substring(0, this.txtPrice.Text.Length - 1);
                    return;
                }
                else if (num.ToString() == "." && this.txtPrice.Text.IndexOf(".") > -1)
                    return;
                this.txtPrice.Text += num.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

    }
}