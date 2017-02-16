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
    public partial class frmPType : Form
    {
        public frmPType()
        {
            InitializeComponent();
        }
        
        private void btnAccession_Click(object sender, EventArgs e)
        {
            frmInput ipt = new frmInput("请输入类型名！");
            try
            {
                string str = ipt.ShowInput();
                int i = PTypeCortrol.addTypeName(new PurveyTypeData(0, str));
                PurveyTypeData ptd = new PurveyTypeData(i, str);
                this.pTypeListBox.lbPType.Items.Add(ptd);
            }
            catch (Exception ex)
            {
                if (ex.Message != "")
                    MessageBox.Show(ex.Message);
            }
        }

        private void frmPType_Load(object sender, EventArgs e)
        {
            
        }

       
        

        private void btnAmend_Click(object sender, EventArgs e)
        {
            frmInput ipt = new frmInput("请输入类型名！", this.pTypeListBox.lbPType.SelectedItem.ToString());
            try
            {
                string str = ipt.ShowInput();
                PurveyTypeData ptd = new PurveyTypeData(((PurveyTypeData)this.pTypeListBox.lbPType.SelectedItem).ID, str);
                int i = PTypeCortrol.updTypeName(ptd);
                this.pTypeListBox.lbPType.Items[i]=ptd;
            }
            catch(MessageException ex){
                if (ex.Message != "")
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
                PurveyTypeData ptd = new PurveyTypeData(((PurveyTypeData)this.pTypeListBox.lbPType.SelectedItem).ID, "");
                int i = PTypeCortrol.delTypeName(ptd);
                this.pTypeListBox.lbPType.Items.RemoveAt(i);

                if (this.pTypeListBox.lbPType.Items.Count >= i+1)
                    this.pTypeListBox.lbPType.SelectedIndex = i;
                else
                    if (this.pTypeListBox.lbPType.Items.Count >= i )
                        this.pTypeListBox.lbPType.SelectedIndex = i - 1;
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
    }
}