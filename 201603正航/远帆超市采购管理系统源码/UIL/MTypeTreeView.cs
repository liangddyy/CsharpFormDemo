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
    public partial class MTypeTreeView : UserControl
    {
        public MTypeTreeView()
        {
            InitializeComponent();
        }

        private void MTypeTreeView_Load(object sender, EventArgs e)
        {
            TreeNode rn = new TreeNode("所有类别");
            rn.Tag = 1;
            this.tvMType.Nodes.Add(rn);
            MTypeCortrol.ls = MTypeCortrol.getPType();
            fillTreeViewOfPrenntID(rn);
            this.tvMType.ExpandAll();
        }

        /// <summary>
        /// 根据父项目下的所有子项目
        /// </summary>
        /// <param name="preentID">父项目</param>
        public void fillTreeViewOfPrenntID(TreeNode ptn)
        {
            //移除父项目下的所有子项目
            ptn.Nodes.Clear();
            //增加父项目下拥有的子项目
            foreach (MerchandiseTypeData mtd in MTypeCortrol.ls)
            {
                if (mtd.ParentID == Convert.ToInt32(ptn.Tag))
                {
                    TreeNode rn = new TreeNode(mtd.Name);
                    rn.Tag = mtd.ID;
                    ptn.Nodes.Add(rn);
                    //检查该子项目下是否拥有子项目，如果有添加一个临时，用于在TreeView该项目上增加一个加号
                    foreach (MerchandiseTypeData ctn in MTypeCortrol.ls)
                    {
                        if (ctn.ParentID == Convert.ToInt32(rn.Tag))
                        {
                            rn.Nodes.Add("临时");
                            break;
                        }
                    }
                }
            }
        }

        private void tvMType_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            fillTreeViewOfPrenntID(e.Node);
        }

    }
}
