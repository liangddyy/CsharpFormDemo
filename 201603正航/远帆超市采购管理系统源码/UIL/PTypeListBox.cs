using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BIL;
using model;

namespace UIL
{
    public partial class PTypeListBox : UserControl
    {
        public PTypeListBox()
        {
            InitializeComponent();
        }

        private void PTypeListBox_Load(object sender, EventArgs e)
        {
            fillList("");
        }

        /// <summary>
        /// 刷新集合
        /// </summary>
        public void fillList(string str)
        {
            lbPType.Items.Clear();
            this.lbPType.Items.Clear();
            foreach (PurveyTypeData pd in PTypeCortrol.ls)
                if (str == "")
                    this.lbPType.Items.Add(pd);
                else if (pd.ToString().IndexOf(str) > -1)
                    this.lbPType.Items.Add(pd);
        }

    }
}