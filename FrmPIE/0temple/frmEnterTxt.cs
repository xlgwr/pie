using FrmPIE._0API;
using frmPI;
using FrmPIE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE
{
    public partial class frmEnterTxt : Form
    {
        frmIDR _idr_show;

        frmEnterForReference _FrmForRefe;
        public string _strCellColName;
        public string _sameColumnName;
        public string _deffCellName;
        public string _deffCellValue;

        Commfunction cf;

        frm0BatchInfo _frm0BatchInfo;
        frm111UploadExcelForKYCA _frm111UploadExcelForKYCA;
        frmUploadExcel _frmUploadExcel;

        frm513PrintCartonLabel _frm513PrintCartonLabel;
        frm412UploadToERP _frm412UploadToERP;
        frm211AddNewBatchID _frm211AddNewBatchID;

        frmPI1ScanDataInquire _frmPI1ScanDataInquire;
        frmPI2Report _frmPI2Report;
        frmPI0ScanWECCtnLable _frmPI0ScanWECCtnLable;



        public frmEnterTxt(frmIDR idr)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;
            InitializeComponent();
        }
        public frmEnterTxt(frmIDR idr, frmPI2Report frmPI2Report)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmPI2Report = frmPI2Report;

            InitializeComponent();
        }
        public frmEnterTxt(frmIDR idr, frmPI0ScanWECCtnLable frmPI0ScanWECCtnLable)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmPI0ScanWECCtnLable = frmPI0ScanWECCtnLable;

            InitializeComponent();
            ///

            btn00More.Click += btn00More0_Click;
        }
        #region enquire by Batchid
        void btn00More0_Click(object sender, EventArgs e)
        {
            _FrmForRefe = new frmEnterForReference(_idr_show, this);

            _FrmForRefe.textBox1.Text = textBox1.Text;
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

        private void init_FrmForRefeDGV(string strwhere)
        {
            strwhere = _strCellColName + @" like '%" + strwhere + @"%' or " + _sameColumnName + @" like '%" + strwhere + @"%'";
            if (_strCellColName.Equals("batch_id"))
            {
                var batch_ds = new PIE.DAL.plr_batch_mstr_ext().GetList(50, strwhere, "batch_id desc", true);
                _FrmForRefe.data0GVForReference.DataSource = batch_ds.Tables[0].DefaultView;
                cf.initHeaderTextPlrBatchMstr1(_FrmForRefe.data0GVForReference);
            }
            else if (_strCellColName.Equals("PI_ID"))
            {
                var batch_ds = new PI.DAL.pi_mstr_ext().GetList(50, strwhere, "PI_ID desc", true);
                _FrmForRefe.data0GVForReference.DataSource = batch_ds.Tables[0].DefaultView;
                cf.initHeaderTextPIMstrForEquire(_FrmForRefe.data0GVForReference);
            }
            else
            {
                _FrmForRefe.data0GVForReference.DataSource = null;
            }
            _FrmForRefe.data0GVForReference.Refresh();

        }
        void button1_DoubleClick(object sender, EventArgs e)
        {
            _FrmForRefe.Close();
        }

        void data0GVForReference_Click(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(_FrmForRefe.data0GVForReference, e.RowIndex, e.ColumnIndex, _strCellColName);
            string strBatchID = cf.selectCellMethod(dwo);
            textBox1.Text = strBatchID;
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
        /********************************************************************/
        #endregion

        public frmEnterTxt(frmIDR idr, frmPI1ScanDataInquire frmPI1ScanDataInquire)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmPI1ScanDataInquire = frmPI1ScanDataInquire;

            InitializeComponent();
        }
        public frmEnterTxt(frmIDR idr, frm211AddNewBatchID frm211AddNewBatchID)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm211AddNewBatchID = frm211AddNewBatchID;

            InitializeComponent();
        }
        public frmEnterTxt(frmIDR idr, frm412UploadToERP frm412UploadToERP)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm412UploadToERP = frm412UploadToERP;

            InitializeComponent();
        }
        public frmEnterTxt(frmIDR idr, frm513PrintCartonLabel frm513PrintCartonLabel)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm513PrintCartonLabel = frm513PrintCartonLabel;

            InitializeComponent();
        }
        public frmEnterTxt(frmIDR idr, frm0BatchInfo frm0BatchInfo)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm0BatchInfo = frm0BatchInfo;

            InitializeComponent();
        }
        public frmEnterTxt(frmIDR idr, frm111UploadExcelForKYCA frm111UploadExcelForKYCA)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm111UploadExcelForKYCA = frm111UploadExcelForKYCA;

            InitializeComponent();
        }
        public frmEnterTxt(frmIDR idr, frmUploadExcel frmUploadExcel)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmUploadExcel = frmUploadExcel;

            InitializeComponent();
        }
        private void frmEnterTxt_Load(object sender, EventArgs e)
        {
            this.Location = new Point { X = Control.MousePosition.X - this.Width / 2, Y = Control.MousePosition.Y - this.Height };

        }

    }
}
