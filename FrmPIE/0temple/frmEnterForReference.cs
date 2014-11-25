using FrmIDR._0API;
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
    public partial class frmEnterForReference : Form
    {
        frmIDR _idr_show;
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

        frmEnterTxt _frmEnterTxt;

        public frmEnterForReference()
        {
            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;
            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frmEnterTxt frmEnterTxt)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmEnterTxt = frmEnterTxt;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frmPI2Report frmPI2Report)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmPI2Report = frmPI2Report;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frmPI0ScanWECCtnLable frmPI0ScanWECCtnLable)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmPI0ScanWECCtnLable = frmPI0ScanWECCtnLable;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frmPI1ScanDataInquire frmPI1ScanDataInquire)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmPI1ScanDataInquire = frmPI1ScanDataInquire;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frm211AddNewBatchID frm211AddNewBatchID)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm211AddNewBatchID = frm211AddNewBatchID;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frm412UploadToERP frm412UploadToERP)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm412UploadToERP = frm412UploadToERP;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frm513PrintCartonLabel frm513PrintCartonLabel)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm513PrintCartonLabel = frm513PrintCartonLabel;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frm0BatchInfo frm0BatchInfo)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm0BatchInfo = frm0BatchInfo;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frm111UploadExcelForKYCA frm111UploadExcelForKYCA)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frm111UploadExcelForKYCA = frm111UploadExcelForKYCA;

            InitializeComponent();
        }
        public frmEnterForReference(frmIDR idr, frmUploadExcel frmUploadExcel)
        {
            cf = new Commfunction(idr);
            _idr_show = idr;

            _frmUploadExcel = frmUploadExcel;

            InitializeComponent();
        }
        private void frmEnterForReference_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Resize(object sender, EventArgs e)
        {
            gb0ForReference.Width = groupBox1.Width - gb0ForReference.Left - 5;
            gb0ForReference.Height = groupBox1.Height - gb0ForReference.Top - 5;
        }

       
    }
}
