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
using System.Reflection;
using System.Linq.Expressions;

namespace IDR.Frm.frmPIE
{
    public partial class frm0BatchInfo : Form
    {
        //attribute
        public IQueryable<plr_mstr_ext> _list_plr_mstr { get; set; }
        public IQueryable<plr_mstr_tran_ext> _list_plr_mstr_tran { get; set; }


        //commonfunction
        CommonAPI cf;
        PIE _dbpie;

        ////frm win
        Default _frmDefault;

        public frm0BatchInfo()
        {
            InitializeComponent();
        }
        public frm0BatchInfo(Default frmDefault)
        {
            InitializeComponent();
            //////////////
            initForDefault(frmDefault);
            //initfrm
            initFrm(frmDefault._dbpie);
            //initDGV
            initDGV();
        }
        #region init
        void initPara()
        {
            //function,db
            _dbpie = new PIE();
            cf = new CommonAPI(_frmDefault);
            //attribute

            //datagridview sort
            data1GV_plr_mstr_BatchInfo.ColumnHeaderMouseClick += data1GV_plr_mstr_BatchInfo_ColumnHeaderMouseClick;
            data2GV2_plr_mstr_tran.ColumnHeaderMouseClick += data2GV2_plr_mstr_tran_ColumnHeaderMouseClick;

            //datagridview row enter,cell click
            data1GV_plr_mstr_BatchInfo.RowEnter += data1GV_plr_mstr_BatchInfo_RowEnter;
            data1GV_plr_mstr_BatchInfo.CellClick += data1GV_plr_mstr_BatchInfo_CellClick;

            data2GV2_plr_mstr_tran.CellClick += data2GV2_plr_mstr_tran_CellClick;
            data2GV2_plr_mstr_tran.RowEnter += data2GV2_plr_mstr_tran_RowEnter;
        }


        void initFrm()
        {
            this.FormClosing += Default_FormClosing;
            //init width
            this.gb0BatchInfo0.Resize += gb0frmUploadExcel_Resize;
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
            gb1mstr_BatchInfo.Width = gb0BatchInfo0.Width - gb1mstr_BatchInfo.Left - 5;
            gb2det_BatchInfo.Width = gb1mstr_BatchInfo.Width;
            gb3CartonNo.Width = gb1mstr_BatchInfo.Width;

            gb3CartonNo.Height = gb0BatchInfo0.Height - gb3CartonNo.Top - 10;

        }

        #region dgv cell click and row enter
        void data2GV2_plr_mstr_tran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data2GV2_plr_mstr_tran, e.RowIndex, e.ColumnIndex);
            cf.dgv_cellClick(dwo);

        }
        void data2GV2_plr_mstr_tran_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data2GV2_plr_mstr_tran, 3, e.RowIndex, Color.LightGreen, "plr_status", "U", "CartonID", "plr_status", "Yes", Color.LightGray);
            cf.dgv_rowEnter_ThreadPool(dwo);
        }

        void data1GV_plr_mstr_BatchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data1GV_plr_mstr_BatchInfo, data2GV2_plr_mstr_tran, e.RowIndex, e.ColumnIndex);
            cf.dgv_cellClick(dwo, true);
        }

        void data1GV_plr_mstr_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWorkObject dwo = new DoWorkObject(data1GV_plr_mstr_BatchInfo, 3, e.RowIndex, Color.Yellow, "CartonID", "plr_status", "Yes", Color.LightGray);
            cf.dgv_rowEnter_ThreadPool(dwo);
        }
        void data1GV_plr_mstr_BatchInfo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cf.DGV_ColumnHeaderMouseClick<plr_mstr_ext>(sender, e, data1GV_plr_mstr_BatchInfo, _list_plr_mstr);
        }

        void data2GV2_plr_mstr_tran_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cf.DGV_ColumnHeaderMouseClick<plr_mstr_tran_ext>(sender, e, data2GV2_plr_mstr_tran, _list_plr_mstr_tran);
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
            if (_dbpie != null)
            {
                _dbpie.Dispose();
            }
        }
        #endregion

        void initDGV()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(initGVplr_batch_mstr), _frmDefault._plr_batch_mstr_model.batch_id);
            ThreadPool.QueueUserWorkItem(new WaitCallback(initGVplr_mstr), _frmDefault._plr_batch_mstr_model.batch_id);
            ThreadPool.QueueUserWorkItem(new WaitCallback(initGVplr_mstr_tran), _frmDefault._plr_batch_mstr_model.batch_id);

        }
        void initGVplr_batch_mstr(object o)
        {
            var tmpplr_batch_mstr = _dbpie.plr_batch_mstr.Find(o.ToString());
            init_plr_batch_mstrToTxt(tmpplr_batch_mstr, true);
        }
        void initGVplr_mstr(object o)
        {
            _frmDefault.Invoke(new Action(delegate()
               {
                   _list_plr_mstr = cf.getSelectList_plr_mstr(o.ToString());
                   data1GV_plr_mstr_BatchInfo.DataSource = _list_plr_mstr.ToList();
                   cf.initHeaderText_plr_mstr(data1GV_plr_mstr_BatchInfo);
                   data1GV_plr_mstr_BatchInfo.Refresh();
               }));
        }
        void initGVplr_mstr_tran(object o)
        {
            _frmDefault.Invoke(new Action(delegate()
               {
                   _list_plr_mstr_tran = cf.getSelectList_plr_mstr_tran(o.ToString());
                   data2GV2_plr_mstr_tran.DataSource = _list_plr_mstr_tran.ToList();
                   cf.initHeaderText_plr_mstr_tran(data2GV2_plr_mstr_tran);
                   data2GV2_plr_mstr_tran.Refresh();
               }));
        }
        private void init_plr_batch_mstrToTxt(plr_batch_mstr model, bool breadonly)
        {
            if (string.IsNullOrEmpty(model.batch_id))
            {
                return;
            }
            _frmDefault.Invoke(new Action(delegate()
            {
                txt1batch_id_BatchInfo.Text = model.batch_id;
                txt2batch_do_BatchInfo.Text = model.batch_doc;
                txt3batch_statu_BatchInfo.Text = model.batch_status;
                txt4batch_dec01_BatchInfo.Text = model.batch_dec01.ToString();
                txt5batch_cre_date_BatchInfo.Text = model.batch_cre_date.ToString();

                txt1batch_id_BatchInfo.ReadOnly = breadonly;
                txt2batch_do_BatchInfo.ReadOnly = breadonly;
                txt3batch_statu_BatchInfo.ReadOnly = breadonly;
                txt4batch_dec01_BatchInfo.ReadOnly = breadonly;
                txt5batch_cre_date_BatchInfo.ReadOnly = breadonly;
                //throw new NotImplementedException();
            }));
        }
        //
    }

}
