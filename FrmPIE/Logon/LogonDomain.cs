using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using PIE.DBUtility;

using System.Threading;

namespace FrmPIE
{
    public partial class LogonDomain : Form
    {
        frmNotice _frmNotice;
        Thread t;
        PIE.Model.sys_user system_user_model = new PIE.Model.sys_user();
        public static string _strUpdateURL;

        public LogonDomain()
        {
            InitializeComponent();
            Program.showNewVersion(linkLabel1);
            t = new Thread(initShowing);
        }
        public void initShowing()
        {
            this.BeginInvoke(new FrmIDR._0API.Commfunction.Action(delegate() { lblmsg.Visible = true; }));
            //lblmsg.Text = "load..";
            this.BeginInvoke(new FrmIDR._0API.Commfunction.Action(
                delegate()
                {
                    if (lblmsg.ForeColor == Color.Red)
                    {
                        lblmsg.ForeColor = Color.Green;
                        lblmsg.Text = "load..";

                    }
                    else
                    {
                        lblmsg.ForeColor = Color.Red;
                        lblmsg.Text = "load....";
                    }
                }));

        }
        private void initfrmShow()
        {
            this.Hide();

            //var FrmPIE = new FrmPIE(this, system_user_model);
            //FrmPIE.Text += Program.frmVersion;
            //FrmPIE.Show();

            var frmIDR = new frmIDR(this, system_user_model);
            frmIDR.Text += Program._frm0Version + "," + Program._OSVersion + "          Welcome to: " + txtUserName.Text;
            frmIDR.Show();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            string strdomain = combDomain.Text;

            if (string.IsNullOrEmpty(combDomain.Text))
            {
                txtIsNullOrEmpty("Error: Please Enter the User Name.", combDomain);
                return;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtIsNullOrEmpty("Error: Please Enter the User Name.", txtUserName);
                return;
            }
            string strUserName = txtUserName.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(txtPassword1.Text))
            {
                txtIsNullOrEmpty("Error: Please Enter the Password1.", txtPassword1);
                return;
            }
            if (string.IsNullOrEmpty(txtPassPhrase2.Text))
            {
                txtIsNullOrEmpty("Error: Please Enter the Pass Phrase2.", txtPassPhrase2);
                return;
            }
            try
            {
                this.btnSubmit.Enabled = false;
                this.btnSubmit.Text = "Submit...";

                var systemuserexists = new PIE.BLL.sys_user().GetModel(strUserName, strdomain);
                if (systemuserexists != null)
                {
                    if (systemuserexists.user_password.Equals(DESEncrypt.Encrypt(txtPassword1.Text + "," + txtPassPhrase2.Text)))
                    {
                        systemuserexists.update_time = DateTime.Now;
                        systemuserexists.re_mark = Program.getClientIP() + ",OS:" + Program._OSVersion;
                        systemuserexists.update_user_id = Program._frm0Version;

                        var updateuser = new PIE.BLL.sys_user().Update(systemuserexists);

                        if (!systemuserexists.flag_status.Equals("T"))
                        {
                            MessageBox.Show("User Name:[" + systemuserexists.user_name + "] not activated,Please ask for admin.Ths");
                            return;
                        }
                        if (!getrole())
                        {
                            MessageBox.Show(system_user_model.user_name + " 没有授权访问Packing Information Entry，请联系管理员。");

                        }
                        else
                        {
                            initfrmShow();
                        }

                        return;
                    }
                }


                var pkeyctl = new PIE.BLL.pkey_ctl().GetModel("LogonDomain", combDomain.Text.Trim());

                if (pkeyctl == null || string.IsNullOrEmpty(pkeyctl.t_desc))
                {
                    pkeyctl.t_desc = "LDAP://142.2.70.25/OU=ShaJin,DC=wongs-sj,DC=com";
                }

                string returntxt = Program.ADValidate(pkeyctl.t_desc, strUserName, txtPassword1.Text.Trim());
                string secondpasswdflag = Program.getSecondPasswrdflag(combDomain.Text, strUserName, txtPassPhrase2.Text);
                if (returntxt == "OK")
                {
                    if (secondpasswdflag == "0")
                    {
                        system_user_model.user_password = DESEncrypt.Encrypt(txtPassword1.Text + "," + txtPassPhrase2.Text);
                        if (systemuserexists == null)
                        {
                            system_user_model.user_name = strUserName;
                            system_user_model.user_comp = strdomain;
                            system_user_model.flag_status = "T";
                            system_user_model.create_time = DbHelperSQL.getServerGetDate();
                            system_user_model.update_time = DbHelperSQL.getServerGetDate();
                            system_user_model.client_ip = Program.getClientIP();

                            var systemuserNew = new PIE.BLL.sys_user().Add(system_user_model);

                            var sys_role_model = new PIE.BLL.sys_role().GetModelList("role_name='newuser'");
                            if (sys_role_model.Count <= 0)
                            {
                                var sys_role_model_new = new PIE.Model.sys_role();
                                sys_role_model_new.role_name = "newuser";
                                sys_role_model_new.role_desc = "New User";
                                sys_role_model_new.role_id = new PIE.BLL.sys_role().GetMaxId();
                                sys_role_model_new.create_time = DbHelperSQL.getServerGetDate();
                                sys_role_model_new.update_time = DbHelperSQL.getServerGetDate();
                                sys_role_model_new.create_user_id = system_user_model.user_name;
                                sys_role_model_new.update_user_id = system_user_model.user_name;
                                sys_role_model_new.client_ip = Program.getClientIP();

                                var addNewRole = new PIE.BLL.sys_role().Add(sys_role_model_new);
                                sys_role_model.Add(sys_role_model_new);

                            }
                            var sys_userInrole_model = new PIE.BLL.sys_userInrole().GetModel(system_user_model.user_name, sys_role_model[0].role_id);
                            if (sys_userInrole_model == null)
                            {
                                sys_userInrole_model = new PIE.Model.sys_userInrole();
                                sys_userInrole_model.role_id = sys_role_model[0].role_id;
                                sys_userInrole_model.user_name = system_user_model.user_name;
                                sys_userInrole_model.update_time = DbHelperSQL.getServerGetDate();
                                sys_userInrole_model.create_time = DbHelperSQL.getServerGetDate();
                                sys_userInrole_model.client_ip = Program.getClientIP();
                                sys_userInrole_model.flag_status = "T";
                                sys_userInrole_model.create_user_id = system_user_model.user_name;

                                var addUserInRoleofNew = new PIE.BLL.sys_userInrole().Add(sys_userInrole_model);
                            }


                        }

                        //system_user_model = new PIE.BLL.sys_user().GetModel(strUserName, combDomain.Text);

                        systemuserexists.update_time = DbHelperSQL.getServerGetDate();
                        systemuserexists.user_password = system_user_model.user_password;
                        systemuserexists.re_mark = Program.getClientIP() + ",OS:" + Program._OSVersion;
                        systemuserexists.update_user_id = Program._frm0Version;

                        var sysuserUpdate = new PIE.BLL.sys_user().Update(systemuserexists);

                        if (!systemuserexists.flag_status.Equals("T"))
                        {
                            MessageBox.Show("User Name:[" + systemuserexists.user_name + "] not activated,Please ask for admin.Ths");
                            return;
                        }
                        if (!getrole())
                        {
                            MessageBox.Show(systemuserexists.user_name + " 没有授权访问Packing Information Entry，请联系管理员。");
                        }
                        else
                        {


                            initfrmShow();

                        }






                    }
                    else if (secondpasswdflag == "1")
                    {
                        MessageBox.Show("Error1:Your have no second passwrd, Please go http://142.2.70.208/workflow initialize the Pass Phrase. Thank you!");

                    }
                    else if (secondpasswdflag == "2")
                    {
                        MessageBox.Show("Error2: Invalid Pass Phrase,Please try again.Thank you!");
                        txtPassPhrase2.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Error" + secondpasswdflag + ": System error please ask admin for help.");
                        txtUserName.Focus();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPassword1.Focus();
            }
            finally
            {
                this.btnSubmit.Enabled = true;
                this.btnSubmit.Text = "&Submit";
            }
        }


        private bool getrole()
        {
            var hasone = false;
            string strRolePackingWhere = "role_name='packing' or role_name='admin'";
            var rolePacking = new PIE.BLL.sys_role().GetModelList(strRolePackingWhere);
            if (rolePacking == null)
            {
                return false;
            }
            if (rolePacking.Count > 0)
            {

                for (int i = 0; i < rolePacking.Count; i++)
                {
                    var getRoleEnter = new PIE.BLL.sys_userInrole().GetModel(txtUserName.Text, rolePacking[i].role_id);
                    if (getRoleEnter != null)
                    {
                        hasone = true;
                        break;

                    }
                    else
                    {
                        hasone = false;
                    }
                }
                if (hasone)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                var sys_role_model_new = new PIE.Model.sys_role();
                sys_role_model_new.role_name = "packing";
                sys_role_model_new.role_desc = "Packing";
                sys_role_model_new.role_id = new PIE.BLL.sys_role().GetMaxId();
                sys_role_model_new.create_time = DbHelperSQL.getServerGetDate();
                sys_role_model_new.update_time = DbHelperSQL.getServerGetDate();
                sys_role_model_new.create_user_id = txtUserName.Text;
                sys_role_model_new.update_user_id = txtUserName.Text;
                sys_role_model_new.client_ip = Program.getClientIP();
                var addNewRole = new PIE.BLL.sys_role().Add(sys_role_model_new);
                return false;

            }
        }

        private void txtIsNullOrEmpty(string msg, TextBox tb)
        {
            MessageBox.Show(msg);
            tb.SelectAll();
            tb.Focus();
        }
        private void txtIsNullOrEmpty(string msg, ComboBox tb)
        {
            MessageBox.Show(msg);
            tb.SelectAll();
            tb.Focus();
        }
        private void LogonDomain_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F10)
            {

                EnterPassword pw = new EnterPassword();
                pw.ShowDialog();
            }
        }





        public System.Threading.ThreadExceptionEventHandler Application_ThreadException { get; set; }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.Links[0].LinkData = _strUpdateURL;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            initShowing();
        }

    }
}
