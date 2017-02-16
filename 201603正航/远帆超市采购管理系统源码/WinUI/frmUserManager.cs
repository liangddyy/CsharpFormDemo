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
    public partial class frmUserManager : Form
    {
        public frmUserManager()
        {
            InitializeComponent();
        }
        //private UserCortrol userCortrol = new UserCortrol();
        private void frmUserManager_Load(object sender, EventArgs e)
        {
            fillView();
            this.cobPru.Items.Add("管理员");
            this.cobPru.Items.Add("高级用户");
            this.cobPru.Items.Add("普通用户");
        }
        private void fillView()
        {
            this.lviUser.Items.Clear();
            foreach (UserData user in UserCortrol.selUser())
                addView(user);
        }
        private void addView(UserData user)
        {
            try
            {
                ListViewItem lvi = new ListViewItem(user.Name);
                lvi.Tag = user;
                ListViewItem.ListViewSubItem lvs = new ListViewItem.ListViewSubItem();
                UserData tempUser = UserCortrol.getUser(user.ID);
                switch (tempUser.Purview)
                {
                    case Set.Admin:
                        lvs.Text = "管理员";
                        lvs.Tag = tempUser;
                        break;
                    case Set.Super:
                        lvs.Text = "高级用户";
                        lvs.Tag = tempUser;
                        break;
                    case Set.Ordinarily:
                        lvs.Text = "普通用户";
                        lvs.Tag = tempUser;
                        break;
                }
                lvi.SubItems.Add(lvs);
                this.lviUser.Items.Add(lvi);
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lviUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lviUser.SelectedItems != null)
                {
                    ListViewItem lvi = this.lviUser.SelectedItems[0];
                    UserData user = (UserData)lvi.Tag;
                    this.txtName.Text = user.Name;
                    this.txtPwd.Text = user.Pwd;
                    switch (user.Purview)
                    {
                        case Set.Admin:
                            this.cobPru.Text = "管理员";
                            break;
                        case Set.Super:
                            this.cobPru.Text = "高级用户";
                            break;
                        case Set.Ordinarily:
                            this.cobPru.Text = "普通用户";
                            break;
                    }
                }
            }
            catch { }
        }

        private void clear()
        {
            this.txtName.Text = "";
            this.txtPwd.Text = "";
            this.cobPru.Text = "";
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lviUser.SelectedItems.Count == 0)
                    throw new MessageException("请选择要删除的项目！");
                DialogResult dr = MessageBox.Show("您确定要删除该项目吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                UserData us = (UserData)this.lviUser.SelectedItems[0].Tag;
                if (dr != DialogResult.No&&us.ID!=Set.User.ID)
                {
                    UserCortrol.delUser(us);
                    this.lviUser.Items.RemoveAt(this.lviUser.SelectedIndices[0]);
                    clear();
                }
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtName.Text == "")
                    throw new MessageException("请输入用户名");
                if (this.txtPwd.Text == "")
                    throw new MessageException("请输入密码");
                UserData user = new UserData();
                user.Name = this.txtName.Text;
                user.Pwd = this.txtPwd.Text;
                switch (this.cobPru.Text)
                {
                    case "管理员":
                        user.Purview = 0;
                        break;
                    case "高级用户":
                        user.Purview = 1;
                        break;
                    case "普通用户":
                        user.Purview = 2;
                        break;
                }
                int i =UserCortrol.insertUser(user);
                user.ID = i;
                addView(user);
                clear();
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtName.Text == "")
                    throw new MessageException("请输入用户名");
                if (this.txtPwd.Text == "")
                    throw new MessageException("请输入密码");

                if (this.lviUser.SelectedItems != null)
                {
                    ListViewItem lvi = this.lviUser.SelectedItems[0];
                    UserData user = (UserData)lvi.Tag;
                    user.Name = this.txtName.Text;
                    user.Pwd = this.txtPwd.Text;
                    switch (this.cobPru.Text)
                    {
                        case "管理员":
                            user.Purview = 0;
                            break;
                        case "高级用户":
                            user.Purview = 1;
                            break;
                        case "普通用户":
                            user.Purview = 2;
                            break;
                    }
                    UserCortrol.updateUser(user);
                    clear();
                    fillView();
                }
                else
                    throw new MessageException("请选择要更新的项目！");
            }
            catch (MessageException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnClean_Click(object sender, EventArgs e)
        {
            clear();
            fillView();
        }
    }
}