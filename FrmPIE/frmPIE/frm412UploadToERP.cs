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

    public partial class frm412UploadToERP : Form
    {
        frmEnterTxt _frmET;
        frmEnterForReference _FrmForRefe;

        frmIDR _idr_show;
        Commfunction cf;
        DataSet _reobjdet;
        public string _strbatchid;


        public string _strCellColName;
        public string _sameColumnName;
        public string _deffCellName;
        public string _deffCellValue;

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

            data1GVUploadToERP.ContextMenuStrip = ctmenu0EnquireByPart;
            enquireByPartToolStripMenuItem.Click += enquireByPartToolStripMenuItem_Click;
            btn00More.Click += btn00More0_Click;
        }

        void btn00More0_Click(object sender, EventArgs e)
        {
            _FrmForRefe = new frmEnterForReference(_idr_show, this);

            _FrmForRefe.textBox1.Text = txt0BatchIDUploadToERP.Text;
            _FrmForRefe.textBox1.Focus();
            _FrmForRefe.lbl1SelectNotice.Text = "";
            _FrmForRefe.lbl2SelectValue.Text = "";
            //
            _FrmForRefe.data0GVForReference.RowEnter += data0GVForReference_RowEnter;
            _FrmForRefe.data0GVForReference.CellClick += data0GVForReference_Click;
            //
            _FrmForRefe.button1.Click += enquireByForReferenct;
            _FrmForRefe.data0GVForReference.CellDoubleClick += button1_DoubleClick;
            //
            _FrmForRefe.chkTop50.CheckedChanged += chkTop50_CheckedChanged;
            //
            _FrmForRefe.gb0ForReference.Text = "Enquire Result";
            //
            initSelectCondition();
            //
            init_FrmForRefeDGV("");

            _FrmForRefe.ShowDialog();
        }

        void chkTop50_CheckedChanged(object sender, EventArgs e)
        {

            _FrmForRefe.lbl1SelectNotice.Text = "";
            _FrmForRefe.lbl2SelectValue.Text = "";
            if (_FrmForRefe.chkTop50.Checked)
            {
                //
                initSelectCondition();
                //
                init_FrmForRefeDGV("");
            }
            else
            {
                enquireByForReferenct(sender, e);
            }
        }

        private void initSelectCondition()
        {
            _FrmForRefe.lblTitle.Text = "BatchID# OR IP:";
            _FrmForRefe.Text = "Enquire by BatchID";
            //
            _strCellColName = "batch_id";
            _sameColumnName = "batch_user_ip";
            _deffCellName = "batch_status";
            _deffCellValue = "Yes";

        }

        void button1_DoubleClick(object sender, EventArgs e)
        {
            _FrmForRefe.Close();
        }

        void data0GVForReference_Click(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(_FrmForRefe.data0GVForReference, e.RowIndex, e.ColumnIndex, _strCellColName);
            string strBatchID = cf.selectCellMethod(dwo);
            txt0BatchIDUploadToERP.Text = strBatchID;
        }

        void data0GVForReference_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(_FrmForRefe, _FrmForRefe.data0GVForReference, 3, e.RowIndex, Color.LightGreen, _strCellColName, "Current " + _strCellColName + "#:", _sameColumnName, _deffCellName, _deffCellValue, Color.LightGray);
            cf.initThreadDowrokColor(dwo);

        }
        void enquireByForReferenct(object sender, EventArgs e)
        {
            _FrmForRefe.chkTop50.Checked = false;
            if (string.IsNullOrEmpty(_FrmForRefe.textBox1.Text))
            {
                _FrmForRefe.textBox1.Focus();
                return;
            }
            init_FrmForRefeDGV(_FrmForRefe.textBox1.Text.Trim());
            //txt0SearchID.Text = _FrmForRefe.textBox1.Text.Trim();
            //cf.EnquireByPart(data0GVPiReport, "pisr_part", _FrmForRefe.textBox1.Text.Trim());
        }

        private void init_FrmForRefeDGV(string strwhere)
        {
            strwhere = _strCellColName + @" like '%" + strwhere + @"%' or " + _sameColumnName + @" like '%" + strwhere + @"%'";
            if (_strCellColName.Equals("batch_id"))
            {
                var batch_ds = new PIE.DAL.plr_batch_mstr_ext().GetList(50, strwhere, "batch_id desc", true);
                _FrmForRefe.data0GVForReference.DataSource = batch_ds.Tables[0].DefaultView;
                cf.initHeaderTextPlrBatchMstr1(_FrmForRefe.data0GVForReference);
            }
            else
            {
                _FrmForRefe.data0GVForReference.DataSource = null;
            }
            _FrmForRefe.data0GVForReference.Refresh();

        }

        void data1GVUploadToERP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GVUploadToERP, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo);
        }

        void data1GVUploadToERP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GVUploadToERP, 3, e.RowIndex, Color.LightGreen, "plr_status", "U", "CartonID", "plr_status", "Yes", Color.LightGray);
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
                _reobjdet = (DataSet)cf.initDataGVplr_mstr_tran(ctftPlrMstr, true, "all");
            }
            else
            {
                _reobjdet = (DataSet)cf.initDataGVplr_mstr_tran(ctftPlrMstr, true, "ds");
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
            cf.EnquireByPart(data1GVUploadToERP, "plr_partno", _frmET.textBox1.Text.Trim());
        }

        private void downLoad1ToExceltoolStripMenuItem2_Click(object sender, EventArgs e)
        {

            cf.downLoadExcel(_reobjdet, lbl0MsgUploadToERP, cf.nameList12UploadToERP(), "12UploadToERP");
        }
    }
}
