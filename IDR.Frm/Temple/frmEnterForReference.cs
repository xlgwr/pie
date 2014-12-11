using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MessageBox = System.Windows.Forms.MessageBox;

using System.Data.Entity;
using IDR.Common;
using IDR.Common.DEncrypt;
using IDR.Frm.API;

using IDR.EF.PIE;
using IDR.EF.PIRemote;

using System.Threading;
using System.Reflection;
using System.Linq.Expressions;

namespace IDR.Frm.Temple
{
    public partial class frmEnterForReference : Form
    {
        //commonfunction
        CommonAPI cf;
        PIE _dbpie;

        ////frm win
        Default _frmDefault;

        public frmEnterForReference()
        {
            InitializeComponent();
        }

        public frmEnterForReference(Default frmDefault)
        {
            InitializeComponent();
            //////////////
            initForDefault(frmDefault);
            //initfrm
            initFrm(frmDefault._dbpie);
            //initDGV
            //initDGV();
        }
        #region init
        void initPara()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point { X = Control.MousePosition.X - this.Width/3, Y = Control.MousePosition.Y + 25 };

            //function,db
            _dbpie = new PIE();
            cf = new CommonAPI(_frmDefault);
            //attribute

            //datagridview sort
            data0GVForReference.ColumnHeaderMouseClick += data1GV_plr_mstr_BatchInfo_ColumnHeaderMouseClick;
        }


        void initFrm()
        {
            this.FormClosing += Default_FormClosing;
            //init width
            this.groupBox1.Resize += gb0frmUploadExcel_Resize;

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
            gb0ForReference.Width = groupBox1.Width - gb0ForReference.Left - 5;
            gb0ForReference.Height = groupBox1.Height - gb0ForReference.Top - 10;
        }

        #region dgv cell click and row enter
        void data1GV_plr_mstr_BatchInfo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cf.DGV_ColumnHeaderMouseClick<plr_batch_mstr_ext>(sender, e, data0GVForReference, _frmDefault._list_plr_batch_mstr);
        }

        #endregion

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
            //if (_dbpie != null)
            //{
            //    _dbpie.Dispose();
            //}
        }
        #endregion
    }
}
