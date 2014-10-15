using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FrmPIE._0API;
using PIE.DBUtility;
using System.Data.SqlClient;
using System.Threading;

namespace FrmPIE
{
    public partial class frm513PrintCartonLabel : Form
    {
        frmEnterTxt _frmET;

        frmIDR _idr_show;
        Commfunction cf;
        DataSet reobjdet;
        public frm513PrintCartonLabel(frmIDR idr)
        {
            InitializeComponent();
            initwith();

            _idr_show = idr;
            cf = new Commfunction(idr);

            data1GV1ePackingMstr_PrintCtnLbl.ReadOnly = true;
            data2GV2CartonNO_PrintCtnLbl.ReadOnly = true;

            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Resize;
            _idr_show.tabCtlRight1.SelectedTab.Resize += SelectedTab_Resize;


            data1GV1ePackingMstr_PrintCtnLbl.RowEnter += data1GV1ePackingDet1_BatchInfo_RowEnter;
            data1GV1ePackingMstr_PrintCtnLbl.CellClick += data1GV1ePackingDet1_BatchInfo_CellClick;

            data2GV2CartonNO_PrintCtnLbl.RowEnter += data2GV2CartonNO_RowEnter;
            data2GV2CartonNO_PrintCtnLbl.CellClick += data2GV2CartonNO_CellClick;

        }

        void data2GV2CartonNO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data2GV2CartonNO_PrintCtnLbl, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo);
            txt0CartonIDFrom_PrintCartonLabel.Text = _idr_show._intFrom.ToString();
            txt1CartonIDTo_PrintCartonLabel.Text = _idr_show._intTo.ToString();

        }

        void data2GV2CartonNO_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(_idr_show, data2GV2CartonNO_PrintCtnLbl, 3, e.RowIndex, Color.LightGreen, "plr_status", "U", "CartonID", "plr_status", "Yes", Color.LightGray, "Wec_Ctn");
            cf.initThreadDowrokColor(dwo);
        }


        void data1GV1ePackingDet1_BatchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1ePackingMstr_PrintCtnLbl, e.RowIndex, e.ColumnIndex);
            string strBatchID = cf.selectCellMethod(dwo);
            if (!String.IsNullOrEmpty(strBatchID))
            {
                CartonFromTo ctftPlrMstrTran = new CartonFromTo(data2GV2CartonNO_PrintCtnLbl, strBatchID, 0, "refresh", _idr_show._custip, _idr_show._custip);
                var reobjCarton = cf.initDataGVplr_mstr_tran(ctftPlrMstrTran, true, "nothing");

                //CartonNo from To
                DataSet ds = (DataSet)reobjCarton;
                CartonFromTo cfo = new CartonFromTo(ds, txt0CartonIDFrom_PrintCartonLabel, txt1CartonIDTo_PrintCartonLabel);
                cf.initWECPrintFromToDeleteaget(cfo);

            }

        }

        void data1GV1ePackingDet1_BatchInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1ePackingMstr_PrintCtnLbl, 3, e.RowIndex, Color.Yellow, "batch_user_ip", "batch_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }

        void SelectedTab_Resize(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0Print_PrintCartonLabel;
            initwith();
        }
        public void initwith()
        {
            groupBox1.Width = gb0PrintCartonLabel.Width - groupBox1.Left;
            groupBox2.Width = groupBox1.Width;
            gb2det_PrintCartonLabel.Width = groupBox1.Width;
            gb3CartonNo_PrintCartonLabel.Width = groupBox1.Width;

            gb3CartonNo_PrintCartonLabel.Height = gb0PrintCartonLabel.Height - gb3CartonNo_PrintCartonLabel.Top;

        }
        private void frm513PrintCartonLabel_Load(object sender, EventArgs e)
        {

        }
        private void initDGV(object doWorkobj)
        {
            DoWrokObject obj = (DoWrokObject)doWorkobj;

            CartonFromTo ctftPlrMstr = new CartonFromTo(obj._dgv, obj._strBatchId, 0, "refresh", _idr_show._custip, _idr_show._custip);
            var reobjmstr = cf.initDataGVPlrBatchMstr(ctftPlrMstr, true, "nothing");

            CartonFromTo ctftPlrMstrTran = new CartonFromTo(obj._dgv1, obj._strBatchId, 0, "refresh", _idr_show._custip, _idr_show._custip);
            var reobjCarton = cf.initDataGVplr_mstr_tran(ctftPlrMstrTran, true, "nothing");


        }

        private void initDGVDelegate(object doWorkobj)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(initDGV);
            _idr_show.BeginInvoke(me, doWorkobj);
        }
        private void btn8Search_Click(object sender, EventArgs e)
        {
            var strbatchid = txt88Batchid_PrintCtnLbl.Text;
            if (!string.IsNullOrEmpty(strbatchid))
            {
                var existBatchid = new PIE.BLL.plr_batch_mstr().Exists(strbatchid);
                if (!existBatchid)
                {
                    lbl0SearchMsg.Text = "Error: " + strbatchid + " is not exist.";
                }
                DoWrokObject obj = new DoWrokObject(data1GV1ePackingMstr_PrintCtnLbl, data2GV2CartonNO_PrintCtnLbl, strbatchid);
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
            else
            {
                chkTop100.Checked = true;
                CartonFromTo ctftPlrMstr = new CartonFromTo(data1GV1ePackingMstr_PrintCtnLbl, "", 0, "refresh", _idr_show._custip, _idr_show._custip);
                var reobjmstr = cf.initDataGVPlrBatchMstr(ctftPlrMstr, true, "all");

                lbl0SearchMsg.Text = "BatchID is  Nothing. this will be Search Top 100 items";
            }
        }

        private void txt88Batchid_PrintCtnLbl_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn8SearchPrintCtnLbl;
            if (txt88Batchid_PrintCtnLbl.Text.Length > 0)
            {
                chkTop100.Checked = false;
                lbl0SearchMsg.Text = "";
            }
            else
            {
                chkTop100.Checked = true;
                lbl0SearchMsg.Text = "BatchID is  Nothing. this will be Search Top 100 items";
            }
        }

        private void chkTop100_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTop100.Checked)
            {
                txt88Batchid_PrintCtnLbl.Text = "";
                btn8Search_Click(sender, e);
                lbl0SearchMsg.Text = "This will be Search Top 100 items";
            }
            else
            {
                lbl0SearchMsg.Text = "Please Enter Batch ID,Thank you.";
            }
        }

        private void btn0Print_PrintCartonLabel_Click(object sender, EventArgs e)
        {
            Decimal wec_ctn_Fr = 0, wec_ctn_To = 0;

            if (!cf.isNumber(txt0CartonIDFrom_PrintCartonLabel, lbl0PrintMsg))
            {
                return;
            }
            if (!cf.isNumber(txt1CartonIDTo_PrintCartonLabel, lbl0PrintMsg))
            {
                return;
            }

            wec_ctn_Fr = Convert.ToDecimal(txt0CartonIDFrom_PrintCartonLabel.Text.Trim());

            wec_ctn_To = Convert.ToDecimal(txt1CartonIDTo_PrintCartonLabel.Text.Trim());

            if (wec_ctn_Fr > wec_ctn_To)
            {
                MessageBox.Show("Wongs CartonID From must be less than To.");
                txt0CartonIDFrom_PrintCartonLabel.Focus();
                return;
            }

            CartonFromTo cft = new CartonFromTo(this, wec_ctn_Fr, wec_ctn_To, cmb0Printer_PrintCartonLabel.Text, cmb1Port_PrintCartonLabel.Text);

            _idr_show._tprintCtn = new Thread(new ParameterizedThreadStart(cf.PrinTXTFile));
            if (_idr_show._tprintCtn.ThreadState == ThreadState.Running)
            {
                _idr_show._tprintCtn.Abort();
            }

            if (_idr_show._tprintCtn.ThreadState == ThreadState.Unstarted)
            {

                _idr_show._tprintCtn.Start(cft);
            }

            if (_idr_show._tprintCtn.ThreadState == ThreadState.Stopped)
            {
                //
                _idr_show._tprintCtn = new Thread(new ParameterizedThreadStart(cf.PrinTXTFile));
                _idr_show._tprintCtn.Start(cft);
            }

        }

        private void txt0CartonIDFrom_PrintCartonLabel_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0Print_PrintCartonLabel;
        }

        private void enquireByPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmET = new frmEnterTxt(_idr_show, this);
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
            cf.EnquireByPart(data2GV2CartonNO_PrintCtnLbl, "plr_partno", _frmET.textBox1.Text.Trim());
        }
    }
}
