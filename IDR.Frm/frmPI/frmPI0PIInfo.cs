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

namespace IDR.Frm.frmPI
{
    public partial class frmPI0PIInfo : Form
    {
        //commonfunction
        CommonAPI cf;
        PIE _dbpie;

        ////frm win
        Default _frmDefault;

        public frmPI0PIInfo()
        {
            InitializeComponent();
        }
        public frmPI0PIInfo(Default frmDefault)
        {
            InitializeComponent();
            //////////////
            initForDefault(frmDefault);
            //initfrm
            initFrm(frmDefault._dbpie);
        }
        #region init
        void initPara()
        {
            //function,db
            _dbpie = new PIE();
            cf = new CommonAPI(_frmDefault);
            //attribute
        }
        void initFrm()
        {
            this.FormClosing += Default_FormClosing;
            //init width
            this.gb00PIScanPIDataitemInquire.Resize += gb0frmUploadExcel_Resize;
            //initpara
            initPara();
        }
        void initFrm(PIE dbpie)
        {
            initFrm();
            _dbpie = dbpie;
        }
        void initForDefault(Default frmDefault)
        {
            _frmDefault = frmDefault;
            _frmDefault.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;
        }
        private void initwidth()
        {
            gb1mstr_PIMstr.Width = gb00PIScanPIDataitemInquire.Width - gb1mstr_PIMstr.Left - 5;
            gb2det_PIdet.Width = gb1mstr_PIMstr.Width;
            gb3PIMstr.Width = gb1mstr_PIMstr.Width;

            gb3PIMstr.Height = gb1mstr_PIMstr.Height - gb3PIMstr.Top - 10;

        }
        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            //btnSelectfileUploadExcel.Focus();
        }
        void gb0frmUploadExcel_Resize(object sender, EventArgs e)
        {
            initwidth();
        }
        void Default_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dbpie != null)
            {
                _dbpie.Dispose();
            }
        }
        #endregion
    }
}
