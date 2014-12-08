using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

using System.Data.Entity;
using IDR.Common;
using IDR.Common.DEncrypt;
using IDR.Frm.API;
using IDR.EF.PIE;
using IDR.EF.PIRemote;
using System.Threading;


namespace IDR.Frm.Logon
{
    public partial class LogonDomain : Form
    {
        CommonAPI _comm;
        PIE _dbpie;
        sys_user _system_user_exists;

        public LogonDomain()
        {
            InitializeComponent();

            initFrm();
        }
        void initFrm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnSubmit;

            _comm = new CommonAPI();
            _dbpie = new PIE();

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_comm.ControlIsNullOrEmpty("Error: Please Enter the Domain Name.", combDomain))
            {
                return;
            }
            if (_comm.ControlIsNullOrEmpty("Error: Please Enter the User Name.", txtUserName))
            {
                return;
            }
            if (_comm.ControlIsNullOrEmpty("Error: Please Enter the Password1.", txtPassword1))
            {
                return;
            }
            if (_comm.ControlIsNullOrEmpty("Error: Please Enter the Pass Phrase2.", txtPassPhrase2))
            {
                return;
            }
            string strdomain = combDomain.Text.Trim();
            string strUserName = txtUserName.Text.Trim().ToLower();

            string strPassword1 = txtPassword1.Text.Trim();
            string strPass2 = txtPassPhrase2.Text.Trim();

            sys_user tmpuser = new sys_user()
            {
                user_comp = strdomain,
                user_name = strUserName,
                user_password = strPassword1,
                user_desc = strPass2
            };
            // existUser(tmpuser);
            btnSubmit.Enabled = false;
            lbl0Msg.Text = "Logon ...";
            ThreadPool.QueueUserWorkItem(new WaitCallback(existUser), tmpuser);

        }

        /// <summary>
        /// string strUserName, string strdomain, string strPassword1, string strPass2
        /// sys_user tmpuser = new sys_user()
        ///   {
        ///       user_comp = strdomain,
        ///       user_name = strUserName,
        ///       user_password = strPassword1,
        ///       user_desc = strPass2
        ///   };
        ///  existUser(tmpuser);
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strdomain"></param>
        /// <param name="strPassword1"></param>
        /// <param name="strPass2"></param>
        private void existUser(object o)
        {

            sys_user tmpuser = (sys_user)o;
            _system_user_exists = _dbpie.sys_user.Where(u => (u.user_name == tmpuser.user_name && u.user_comp == tmpuser.user_comp)).SingleOrDefault();
            if (_system_user_exists != null)
            {
                if (_system_user_exists.user_password.Equals(DESEncrypt.Encrypt(tmpuser.user_password + "," + tmpuser.user_desc)))
                {
                    _system_user_exists.update_time = DateTime.Now;
                    _system_user_exists.re_mark = GetClientIP.getClientIP();
                    _system_user_exists.update_user_id = Program._frm0Version;
                }
                var updateuser = _dbpie.SaveChanges();

                if (!_system_user_exists.flag_status.Equals("T"))
                {
                    MessageBox.Show("User Name:[" + _system_user_exists.user_name + "] not activated,Please ask for admin.Ths");
                    //return false;
                    initBtn("", true);
                    return;

                }
                if (!getrole())
                {
                    MessageBox.Show(_system_user_exists.user_name + " 没有授权访问Packing Information Entry，请联系管理员。");
                    initBtn("", true);
                    return;
                }
                else
                {
                    initfrmShow();
                    //return;
                }

                //return false;

            }
            else
            {
                initBtn("System Error,Please retry.", true);
            }
            //throw new NotImplementedException();
        }
        public void initBtn(string msg, bool bl)
        {
            lbl0Msg.Text = msg;
            btnSubmit.Enabled = bl;
        }
        private bool getrole()
        {
            return true;
            //throw new NotImplementedException();
        }

        private void initfrmShow()
        {
            this.Hide();

            //var FrmPIE = new FrmPIE(this, system_user_model);
            //FrmPIE.Text += Program.frmVersion;
            //FrmPIE.Show();

            var _default = new Default(this, _system_user_exists);
            _default.Text += Program._frm0Version + "    Welcome : " + txtUserName.Text;
            _default.Show();
        }



    }
}
