using FrmIDR._0API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FrmPIE
{
    public partial class frm0BatchInfo : Form
    {
        frmEnterTxt _frmET;
        frmIDR _idr_show;
        Commfunction cf;
        DataSet _reobjdet;

        //定义一个DateTimePicker控件
        private DateTimePicker dTimePicker = new DateTimePicker();
        public frm0BatchInfo(frmIDR idr)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;
            InitializeComponent();

            initWidth();

            data1GV1ePackingDet1_BatchInfo.ReadOnly = true;
            data2GV2CartonNO.ReadOnly = true;

            DoWrokObject obj = new DoWrokObject(data1GV1ePackingDet1_BatchInfo, data2GV2CartonNO, _idr_show._plr_batch_mstr_model.batch_id);
            _idr_show._tInitGDV = new Thread(new ParameterizedThreadStart(initDGVDelegate));

            if (_idr_show._tInitGDV.ThreadState == ThreadState.Running)
            {
                _idr_show._tInitGDV.Abort();
            }

            if (_idr_show._tInitGDV.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tInitGDV.Start(obj);
            }
            if (_idr_show._tInitGDV.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tInitGDV = new Thread(new ParameterizedThreadStart(initDGVDelegate));
                _idr_show._tInitGDV.Start(obj);
            }

            data1GV1ePackingDet1_BatchInfo.RowEnter += data1GV1ePackingDet1_BatchInfo_RowEnter;
            data1GV1ePackingDet1_BatchInfo.CellClick += data1GV1ePackingDet1_BatchInfo_CellClick;

            data2GV2CartonNO.RowEnter += data2GV2CartonNO_RowEnter;
            data2GV2CartonNO.CellClick += data2GV2CartonNO_CellClick;


            data2GV2CartonNO.ContextMenuStrip = ctmenu0EnquireByPart;
            enquireByPartToolStripMenuItem.Click += enquireByPartToolStripMenuItem_Click;
        }

        void data2GV2CartonNO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data2GV2CartonNO, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo);
        }

        void data2GV2CartonNO_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data2GV2CartonNO, 3, e.RowIndex, Color.LightGreen, "plr_status", "U", "CartonID", "plr_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }
        

        void data1GV1ePackingDet1_BatchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1ePackingDet1_BatchInfo, data2GV2CartonNO, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo, true);
        }

        void data1GV1ePackingDet1_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1ePackingDet1_BatchInfo, 3, e.RowIndex, Color.Yellow, "CartonID", "plr_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }



        private void initWidth()
        {
            gb3CartonNo.Width = groupBox0BatchInfo0.Width - gb3CartonNo.Left;
            gb1mstr_BatchInfo.Width = gb3CartonNo.Width;
            gb2det_BatchInfo.Width = gb3CartonNo.Width;

            gb3CartonNo.Height = groupBox0BatchInfo0.Height - gb3CartonNo.Top;
        }


        private void BatchInfo_Load(object sender, EventArgs e)
        {

        }
        #region PlrBatchMast Plr_mstr

        private void initDGV(object doWorkobj)
        {
            DoWrokObject obj = (DoWrokObject)doWorkobj;

            CartonFromTo ctftPlrMstr = new CartonFromTo(obj._dgv, obj._strBatchId, 0, "upload", _idr_show._custip, _idr_show._custip);

            CartonFromTo ctftPlrMstrTran = new CartonFromTo(obj._dgv1, obj._strBatchId, 0, "upload", _idr_show._custip, _idr_show._custip);

            var reobjmstr = cf.initDataGVPlrBatchMstr(ctftPlrMstr, false, "model");
            var reobjmstrDet = (DataSet)cf.initDataGVplr_mstr(ctftPlrMstr, true, "nothing");

            if (reobjmstr != null)
            {
                _idr_show._plr_batch_mstr_model = (PIE.Model.plr_batch_mstr)reobjmstr;
                initModelToTxtPlrBatchMast(_idr_show._plr_batch_mstr_model, true);
                _reobjdet = (DataSet)cf.initDataGVplr_mstr_tran(ctftPlrMstrTran, true, "nothing");
            }

        }

        private void initDGVDelegate(object doWorkobj)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(initDGV);
            _idr_show.BeginInvoke(me, doWorkobj);
        }

        private void initModelToTxtPlrBatchMast(PIE.Model.plr_batch_mstr model, bool breadonly)
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
        }
        #endregion

        private void groupBox0BatchInfo0_Resize(object sender, EventArgs e)
        {
            initWidth();
        }
        private void enquireByPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmET = new frmEnterTxt(_idr_show,this);
            _frmET.button1.Click += enquireByPart;
            _frmET.lblTitle.Text = "Part#:";
            _frmET.Text = "Enquire by Part:";
            _frmET.ShowDialog();
        }

        void enquireByPart(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_frmET.textBox1.Text))
            {
                _frmET.textBox1.Focus();
                return;
            }
            cf.EnquireByPart(data2GV2CartonNO, "plr_partno", _frmET.textBox1.Text.Trim());
        }

        private void downLoad1ToExceltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cf.downLoadExcel(_reobjdet, _idr_show.status15toolLabelstrResult, cf.nameList12UploadToERP(), "10BatchInfo" + _idr_show._plr_batch_mstr_model.batch_id);
        }





    }
}
