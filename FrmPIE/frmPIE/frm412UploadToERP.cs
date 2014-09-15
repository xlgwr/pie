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

namespace FrmPIE.frmPIE
{

    public partial class frm412UploadToERP : Form
    {
        frmIDR _idr_show;
        Commfunction cf;
        DataSet reobjdet;
        public string _strbatchid;
        public frm412UploadToERP(frmIDR idr)
        {
            InitializeComponent();
            initwith();

            _idr_show = idr;
            cf = new Commfunction(idr);

            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Resize;
            _idr_show.tabCtlRight1.SelectedTab.Resize += SelectedTab_Resize;
            data1GVUploadToERP.CellClick += data1GVUploadToERP_CellClick;
            data1GVUploadToERP.RowEnter += data1GVUploadToERP_RowEnter;
        }

        void data1GVUploadToERP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GVUploadToERP, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo);
        }

        void data1GVUploadToERP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GVUploadToERP, 3, e.RowIndex, Color.LightGreen, "CartonID", "plr_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }
        void SelectedTab_Resize(object sender, EventArgs e)
        {
            txt0BatchIDUploadToERP.Focus();
            _idr_show.AcceptButton = btn1UploadToERP;
            initwith();
        }
        public void initwith()
        {
            gb1UploadToERP.Width = gb0UploadToERP.Width - gb1UploadToERP.Left;

            gb1UploadToERP.Height = gb0UploadToERP.Height - gb1UploadToERP.Top;
        }
        private void frm4UploadToERP_Load(object sender, EventArgs e)
        {

        }

        private void chk0UploadToERP_CheckedChanged(object sender, EventArgs e)
        {

            _idr_show.AcceptButton = btn1UploadToERP;
            if (chk0UploadToERP.Checked)
            {
                _strbatchid = "";
                txt0BatchIDUploadToERP.Enabled = false;
            }
            else
            {
                txt0BatchIDUploadToERP.Enabled = true;
            }
        }

        public void SetToolTextdelegate(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible)
        {
            Commfunction.dSafeSetToolText objSet = new Commfunction.dSafeSetToolText(cf.setToolText);

            _idr_show.BeginInvoke(objSet, new object[] { ctl, strMsg, enable, visible });
        }
        public void SetCtlTextdelegate(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible)
        {
            Commfunction.dSafeSetCtlText objSet = new Commfunction.dSafeSetCtlText(cf.setControlText);

            _idr_show.BeginInvoke(objSet, new object[] { ctl, strMsg, enable, visible });
        }
        private void initDGV(object doWorkobj)
        {
            DoWrokObject obj = (DoWrokObject)doWorkobj;

            CartonFromTo ctftPlrMstr = new CartonFromTo(obj._dgv, txt0BatchIDUploadToERP.Text, 0, "upload", _idr_show._custip, _idr_show._custip);
            if (chk0UploadToERP.Checked)
            {
                reobjdet = (DataSet)cf.initDataGVplr_mstr_tran(ctftPlrMstr, true, "all");
            }
            else
            {
                reobjdet = (DataSet)cf.initDataGVplr_mstr_tran(ctftPlrMstr, true, "ds");
            }

        }

        private void initDGVDelegate(object doWorkobj)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(initDGV);
            _idr_show.BeginInvoke(me, doWorkobj);
        }
        private void UploadERP()
        {
            try
            {

                //toolStripStatusLabelMessage.Text = "Notice: Uploading to ERP Start";
                //btnUploadtoERP.Text = "Uploading...";
                //btnUploadtoERP.Enabled = false;
                //SetToolTextdelegate(lbl0MsgUploadToERP, "$UploadExcel: Notice: Uploading to ERP Start", true, true);

                SetCtlTextdelegate(lbl0MsgUploadToERP, "$UploadExcel: Notice: Uploading to ERP Start", true, true);
                SetCtlTextdelegate(btn1UploadToERP, "&Upload...", false, true);

                string strresult;

                cf.UploadtoERP(this);

                strresult = Commfunction._uploaderpmsg;

                //initDataGV_Tran4(_strbatchidSelect);

                //MessageBox.Show(strresult);
                //toolStripStatusLabelMessage.Text = "Notice: Uploading to ERP END";
                SetCtlTextdelegate(lbl0MsgUploadToERP, strresult, true, true);

                DoWrokObject obj = new DoWrokObject(data1GVUploadToERP, txt0BatchIDUploadToERP.Text);

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
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                SetCtlTextdelegate(lbl0MsgUploadToERP, "$UploadExcel: " + ex.Message, true, true);
            }
            finally
            {
                SetCtlTextdelegate(btn1UploadToERP, "&UploadToERP", true, true);

            }
        }
        private void btn0UploadToERP_Click(object sender, EventArgs e)
        {
            if (!chk0UploadToERP.Checked)
            {
                var existbatchid = new PIE.BLL.plr_batch_mstr().Exists(txt0BatchIDUploadToERP.Text.Trim());
                if (!existbatchid)
                {

                    lbl0MsgUploadToERP.Text = "Error:" + txt0BatchIDUploadToERP.Text + " is no exist.";
                    return;
                }
                else
                {
                    _strbatchid = txt0BatchIDUploadToERP.Text.Trim();
                }
            }


            _idr_show._tuploadERP = new Thread(UploadERP);
            if (_idr_show._tuploadERP.ThreadState == ThreadState.Running)
            {
                _idr_show._tuploadERP.Abort();
            }
            if (_idr_show._tuploadERP.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tuploadERP.Start();
            }
            else if (_idr_show._tuploadERP.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tuploadERP = new Thread(UploadERP);
                _idr_show._tuploadERP.Start();
            }
        }

        private void txt0BatchIDUploadToERP_TextChanged(object sender, EventArgs e)
        {

            _idr_show.AcceptButton = btn1UploadToERP;
        }
    }
}
