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
            string strBatchID = _idr_show._plr_batch_mstr_model.batch_id;

            InitializeComponent();

            _idr_show._tuploadExcelInitGDV = new Thread(new ParameterizedThreadStart(initDGVDelegate));

            if (_idr_show._tuploadExcelInitGDV.ThreadState == ThreadState.Running)
            {
                _idr_show._tuploadExcelInitGDV.Abort();
            }

            if (_idr_show._tuploadExcelInitGDV.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tuploadExcelInitGDV.Start(strBatchID);
            }
            if (_idr_show._tuploadExcelInitGDV.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tuploadExcelInitGDV = new Thread(new ParameterizedThreadStart(initDGVDelegate));
                _idr_show._tuploadExcelInitGDV.Start(strBatchID);
            }

        }


        private void BatchInfo_Load(object sender, EventArgs e)
        {

        }
        private void initDatasetToTxt(PIE.Model.plr_batch_mstr model, bool breadonly)
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
        private void initDGV(object strBatchID)
        {
            CartonFromTo ctft = new CartonFromTo(data1GV1ePackingDet1_BatchInfo, (string)strBatchID, 0, "upload", _idr_show._custip, _idr_show._custip);
            var reobjmstr = cf.initDataGVPlrBatchMstr(ctft, false, "model");
            var reobjdet = cf.initDataGVplr_mstr(ctft, true, "nothing");
            if (reobjmstr != null)
            {
                _idr_show._plr_batch_mstr_model = (PIE.Model.plr_batch_mstr)reobjmstr;
                initDatasetToTxt(_idr_show._plr_batch_mstr_model, true);
            }
        }

        private void initDGVDelegate(object strBatchID)
        {
            commfunction.dinitDataGridViewSource me = new commfunction.dinitDataGridViewSource(initDGV);
            _idr_show.BeginInvoke(me, strBatchID);
        }
    }
}
