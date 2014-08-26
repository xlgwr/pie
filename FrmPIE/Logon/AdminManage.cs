using PIE.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE
{
    public partial class AdminManage : Form
    {
        public AdminManage()
        {
            InitializeComponent();

            initcmbUser();


            initcmbRole();

        }

        private void initcmbRole()
        {
            DataSet sys_role_ds;
            sys_role_ds = new PIE.BLL.sys_role().GetAllList();
            cmbRoles.DataSource = sys_role_ds.Tables[0].DefaultView;
            cmbRoles.DisplayMember = "role_name";
            cmbRoles.ValueMember = "role_id";
            cmbRoles.SelectedIndex = 0;
            cmbRoles.Refresh();
        }

        private void initcmbUser()
        {
            DataSet sys_user_ds;
            sys_user_ds = new PIE.BLL.sys_user().GetAllList();
            cmbUsers.DataSource = sys_user_ds.Tables[0].DefaultView;
            cmbUsers.DisplayMember = "user_name";
            cmbUsers.ValueMember = "user_comp";
            cmbUsers.SelectedIndex = 0;
            cmbUsers.Refresh();
        }


        private void AdminManage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtpwd.Text))
            {
                txtpwd.Focus();
                return;
            }
            var exist = new PIE.BLL.sys_user().Exists(txtUserName.Text, cmbcomp0.Text);
            if (!exist)
            {
                PIE.Model.sys_user sys_user_model = new PIE.Model.sys_user();
                sys_user_model.user_name = txtUserName.Text;
                sys_user_model.user_comp = cmbcomp0.Text;
                sys_user_model.user_password = PIE.DBUtility.DESEncrypt.Encrypt(txtUserName.Text + txtpwd.Text);
                sys_user_model.create_time = DateTime.Now;
                sys_user_model.update_time = DateTime.Now;
                sys_user_model.client_ip = Program.getClientIP();
                sys_user_model.flag_status = "T";
                var adduser = new PIE.BLL.sys_user().Add(sys_user_model);
                if (adduser)
                {
                    initcmbUser();
                    lblRoleMsg.Text = "Add User:" + txtUserName.Text + "," + cmbcomp0.Text + " Success.";
                }
                else
                {
                    lblRoleMsg.Text = "Add User:" + txtUserName.Text + "," + cmbcomp0.Text + " Fail.";
                }

            }

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            addOrRemoveRole("add");
        }

        private void addOrRemoveRole(string editp)
        {
            var username = cmbUsers.Text;
            var rolename = cmbRoles.Text;

            if (string.IsNullOrEmpty(rolename) || rolename.Contains("DataRowView"))
            {
                return;
            }
            if (!PageValidate.IsNumber(cmbRoles.SelectedValue.ToString()))
            {
                return;
            }
            var roleid = (int)cmbRoles.SelectedValue;

            PIE.Model.sys_userInrole userInrole_model = new PIE.Model.sys_userInrole();

            var userInRolep = new PIE.BLL.sys_userInrole().Exists(username, roleid);

            if (!userInRolep)
            {
                if (editp.Equals("add"))
                {
                    userInrole_model.user_name = username;
                    userInrole_model.role_id = roleid;
                    userInrole_model.client_ip = Program.getClientIP();
                    userInrole_model.create_time = DateTime.Now;
                    userInrole_model.update_time = DateTime.Now;

                    var addUserInRole = new PIE.BLL.sys_userInrole().Add(userInrole_model);
                    if (addUserInRole)
                    {
                        lblRoleMsg.Text = "Add " + username + " TO " + roleid + "：" + rolename + " OK.";
                    }
                    else
                    {
                        lblRoleMsg.Text = "Add " + username + " TO " + roleid + "：" + rolename + " Fail.";
                    }
                }
                else if (editp.Equals("remove"))
                {
                    lblRoleMsg.Text = "系统不存在 " + username + " TO " + roleid + "：" + rolename + " 的授权.";
                }
            }
            else
            {

                if (editp.Equals("add"))
                {
                    lblRoleMsg.Text = "系统早已存在 " + username + " TO " + roleid + "：" + rolename + " 的授权.";
                }
                else if (editp.Equals("remove"))
                {
                    var removeUserOfRole = new PIE.BLL.sys_userInrole().Delete(username, roleid);

                    if (removeUserOfRole)
                    {
                        lblRoleMsg.Text = "Remove " + username + " TO " + roleid + "：" + rolename + " OK.";
                    }
                    else
                    {
                        lblRoleMsg.Text = "Remove " + username + " TO " + roleid + "：" + rolename + " Fail.";
                    }

                }

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            addOrRemoveRole("remove");
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void cmbUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            var username = cmbUsers.Text;
            var rolename = cmbRoles.Text;

            if (string.IsNullOrEmpty(rolename) || rolename.Contains("DataRowView"))
            {
                return;
            }
            if (!PageValidate.IsNumber(cmbRoles.SelectedValue.ToString()))
            {
                return;
            }
            var roleid = cmbRoles.SelectedValue;

            string strWhere = "user_name='" + username + "'";
            var getrolelist = new PIE.BLL.sys_userInrole().GetList(strWhere);

            lblUserMsg.Text = username + " has Roles lists: ";
            if (getrolelist != null)
            {
                var count = getrolelist.Tables[0].Rows.Count;

                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        var strroleid = getrolelist.Tables[0].Rows[i]["role_id"].ToString();
                        string strwhere = "role_id='" + strroleid + "'";
                        var role_list = new PIE.BLL.sys_role().GetList(strwhere);
                        if (role_list != null)
                        {
                            lblUserMsg.Text = lblUserMsg.Text + "[" + strroleid + "," + role_list.Tables[0].Rows[0]["role_name"].ToString() + "]\t";
                        }

                    }
                }
            }

        }

        private void cmbRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            var username = cmbUsers.Text;
            var rolename = cmbRoles.Text;
            if (string.IsNullOrEmpty(rolename) || rolename.Contains("DataRowView"))
            {
                return;
            }
            if (!PageValidate.IsNumber(cmbRoles.SelectedValue.ToString()))
            {
                return;
            }

            var roleid = cmbRoles.SelectedValue;

            string strWhere = "role_id='" + roleid + "'";

            var getrolelist = new PIE.BLL.sys_userInrole().GetList(strWhere);

            lblRoleMsg.Text = rolename + " has Users lists: ";
            if (getrolelist != null)
            {
                var count = getrolelist.Tables[0].Rows.Count;

                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        var strroleid = getrolelist.Tables[0].Rows[i]["user_name"].ToString();
                        lblRoleMsg.Text = lblRoleMsg.Text + "[" + strroleid + "]\t";


                    }
                }
            }
        }
    }
}
