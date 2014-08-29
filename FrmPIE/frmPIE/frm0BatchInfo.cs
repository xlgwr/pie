using FrmPIE._0API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FrmPIE.frmPIE
{
    public partial class frm0BatchInfo : Form
    {
        frmIDR _idr_show;
        commfunction cf;

        public frm0BatchInfo(frmIDR idr)
        {
            cf = new commfunction();
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
            var reobjdet = cf.initDataGVplr_mstr(ctftPlrMstr, true, "nothing");

            if (reobjmstr != null)
            {
                _idr_show._plr_batch_mstr_model = (PIE.Model.plr_batch_mstr)reobjmstr;
                initModelToTxtPlrBatchMast(_idr_show._plr_batch_mstr_model, true);
                var reobjCarton = cf.initDataGVplr_mstr_tran(ctftPlrMstrTran, true, "nothing");
            }

        }

        private void initDGVDelegate(object doWorkobj)
        {
            commfunction.dinitDataGVSource me = new commfunction.dinitDataGVSource(initDGV);
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




    }
}
