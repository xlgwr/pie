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

        //
        public bool _logonUserBool { get; set; }
        public DateTime _startDateTime { get; set; }
        public int _logonCount { get; set; }

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

            //init param
            _logonCount = 0;
            _logonUserBool = false;
            _system_user_exists = null;

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
            _startDateTime = DateTime.Now;
            _logonUserBool = true;

            ThreadPool.QueueUserWorkItem(new WaitCallback(existUser), tmpuser);

            ThreadPool.QueueUserWorkItem(new WaitCallback(initLbl0Msg), "Logon...");

        }
        void initLbl0Msg(object o)
        {
            while (_logonUserBool)
            {
                var tmpDateNow = DateTime.Now - _startDateTime;
                initBtn(o.ToString() + tmpDateNow.Minutes + ":" + tmpDateNow.Seconds + "," + tmpDateNow.Milliseconds, lbl0Msg);
            }
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
            try
            {
                sys_user tmpuser = (sys_user)o;
                initBtn("Start Check User is exist...", false);
                _system_user_exists = _dbpie.sys_user.Where(u => (u.user_name == tmpuser.user_name && u.user_comp == tmpuser.user_comp)).SingleOrDefault();
                if (_system_user_exists != null)
                {
                    initBtn("Start Check User PassWord...", false);
                    if (_system_user_exists.user_password.Equals(DESEncrypt.Encrypt(tmpuser.user_password + "," + tmpuser.user_desc)))
                    {

                        _system_user_exists.update_time = DateTime.Now;
                        _system_user_exists.re_mark = GetClientIP.getClientIP();
                        _system_user_exists.update_user_id = Program._frm0Version;

                    }
                    else
                    {
                        if (_logonCount > 3)
                        {
                            this.Invoke(new Action(delegate()
                            {
                                MessageBox.Show("Enter password more than 3, windows will be close.");
                                this.Close();
                            }));
                        }
                        initBtn("User Name:[" + _system_user_exists.user_name + "],Please enter a right password or Pass Phrase.Ths", true, txtPassword1);

                        _logonCount++;

                        //return false;
                        return;
                    }
                    initBtn("Start Save Logon Log...", false);
                    var updateuser = _dbpie.SaveChanges();

                    initBtn("Start Check User is activated?", false);
                    if (!_system_user_exists.flag_status.Equals("T"))
                    {
                        initBtn("User Name:[" + _system_user_exists.user_name + "] not activated,Please ask for admin.Ths", true);
                        //return false;
                        return;

                    }
                    initBtn("Start Check User has Role to Visit it...", false);
                    if (!getrole())
                    {
                        initBtn(_system_user_exists.user_name + " 没有授权访问Packing Information Entry，请联系管理员。", true);
                        return;
                    }
                    else
                    {
                        initBtn("Start Show Main Windows for User...", true);
                        initfrmShow();
                        //return;
                    }

                    //return false;

                }
                else
                {
                    initBtn("User Name:[" + _system_user_exists.user_name + "] is not exist,Please enter a right user", true, txtUserName);
                }

            }
            catch (Exception ex)
            {
                initBtn(ex.Message, lk0Msg);
            }

            //throw new NotImplementedException();
        }
        public void initBtn(string msg, bool bl)
        {
            this.Invoke(new Action(delegate()
                {
                    lk0Msg.Text = msg;
                    lk0Msg.Visible = true;
                    if (bl)
                    {
                        _logonUserBool = false;
                    }
                    btnSubmit.Enabled = bl;
                }));
        }
        public void initBtn(string msg, bool bl, Control cl)
        {
            initBtn(msg, bl);
            this.Invoke(new Action(delegate()
                {
                    cl.Focus();
                }));
        }
        public void initBtn(string msg, Control cl)
        {
            this.Invoke(new Action(delegate()
                {
                    cl.Text = msg;
                    cl.Visible = true;
                }));
        }
        private bool getrole()
        {
            return true;
            //throw new NotImplementedException();
        }

        private void initfrmShow()
        {
            this.Invoke(new Action(delegate()
               {
                   this.Hide();
                   //var FrmPIE = new FrmPIE(this, system_user_model);
                   //FrmPIE.Text += Program.frmVersion;
                   //FrmPIE.Show();

                   var _default = new Default(this, _system_user_exists);

                   _default.Text += Program._frm0Version + "    Welcome : " + txtUserName.Text;
                   _logonUserBool = false;
                   _default.Show();
               }));
        }




    }
}
