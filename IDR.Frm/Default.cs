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
using IDR.Frm.Logon;

namespace IDR.Frm
{
    public partial class Default : Form
    {
        CommonAPI _comm;
        PIE _dbpie;
        sys_user _system_user_exists;

        //frm win
        LogonDomain _logonDomain;

        public Default()
        {
            InitializeComponent();

            initFrm();
        }
        public Default(LogonDomain logonDomain, sys_user system_user_exists)
        {
            _logonDomain = logonDomain;
            _system_user_exists = system_user_exists;

            /////////////////init
            InitializeComponent();
            //////////////////////

            initFrm(logonDomain._dbpie);
            //////end
        }
        void initFrm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += Default_FormClosing;

            _comm = new CommonAPI();
            _dbpie = new PIE();
        }
        void initFrm(PIE dbpie)
        {
            initFrm();
            _dbpie = dbpie;
        }
        void Default_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_logonDomain != null)
            {
                _logonDomain.Close();
                _logonDomain.Dispose();

            }
            if (_dbpie != null)
            {
                _dbpie.Dispose();
            }
            GC.Collect();
        }
    }
}
