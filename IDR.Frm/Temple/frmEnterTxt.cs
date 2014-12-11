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
using IDR.Frm.frmPIE;
using System.Reflection;

namespace IDR.Frm.Temple
{
    public partial class frmEnterTxt : Form
    {
        //commonfunction
        CommonAPI cf;
        PIE _dbpie;

        //attri
        public string _title { get; set; }

        ////frm win
        Default _frmDefault { get; set; }
        //
        public frm0BatchInfo _frm0BatchInfo { get; set; }


        public frmEnterTxt()
        {
            InitializeComponent();
            initFrm();
        }
        public frmEnterTxt(Default frmDefault)
        {
            InitializeComponent();
            //////////////
            initFrmDefault(frmDefault);
            //initfrm
            initFrm();
            //initDGV
            //initDGV();
        }
        #region init
        void initFrmDefault(Default frmDefault)
        {
            _frmDefault = frmDefault;
            _frmDefault.AcceptButton = button1;
            _frmDefault.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;
            //init db
            _dbpie = frmDefault._dbpie;
        }
        void initFrm()
        {
            this.AcceptButton = button1;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point { X = Control.MousePosition.X - this.Width / 2, Y = Control.MousePosition.Y - this.Height };
            this.FormClosing += Default_FormClosing;

            this.comb0TextValue.SelectedIndexChanged += comb0TextValue_SelectedIndexChanged;

            //init width
            //this.groupBox1.Resize += gb0frmUploadExcel_Resize;

            //initpara
            initPara();
        }
        void initPara()
        {
            //function,db
            if (_dbpie == null)
            {
                _dbpie = new PIE();
            }
            cf = new CommonAPI(_frmDefault);
            //attribute

            //datagridview sort
            //data0GVForReference.ColumnHeaderMouseClick += data1GV_plr_mstr_BatchInfo_ColumnHeaderMouseClick;
        }

        void comb0TextValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = _title + comb0TextValue.Text;
            this.textBox1.SelectAll();
            lblMsg.Text = "";
            //throw new NotImplementedException();
        }
        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            //btnSelectfileUploadExcel.Focus();
        }
        void Default_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (_dbpie != null)
            //{
            //    _dbpie.Dispose();
            //}
            //throw new NotImplementedException();
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

    }
}
