using FrmPIE;
using FrmPIE._0API;
using PIE.Common;
using PIE.DBUtility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmPI
{
    public partial class frmPI2Report : Form
    {
        frmIDR _idr_show;
        Commfunction cf;
        DataSet vpi_report_ds;


        public frmPI2Report(frmIDR idr)
        {
            _idr_show = idr;
            cf = new Commfunction(idr);

            InitializeComponent();

            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;
            gb0PIReport.Resize += gb0PIReport_Resize;

            data0GVPiReport.RowEnter += data0GVPiReport_RowEnter;
            initWidth();
        }

        void data0GVPiReport_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data0GVPiReport, 3, e.RowIndex, Color.LightGreen, "pi_pallet_no", "pi_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }

        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            txt0PINum_piReport.Focus();
            _idr_show.AcceptButton = btn0_enquire_piReport;
        }

        void gb0PIReport_Resize(object sender, EventArgs e)
        {

            initWidth();
        }

        private void initWidth()
        {
            groupBox1.Width = gb0PIReport.Width - 10;
            groupBox2.Width = groupBox1.Width;

            groupBox2.Height = gb0PIReport.Height - groupBox2.Top;
        }

        private void btn_enquire_piReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt0PINum_piReport.Text.Trim()))
            {
                txt0PINum_piReport.Focus();
                lblMsg.Text = "Error: Please enter PI Num.";
                return;
            }
            string strsql = @"select * from vpi_report where ";
            string strwhere = @"PI_ID='" + txt0PINum_piReport.Text.Trim() + "'";
            string strorderby = @" ORDER BY PI_ID, pi_pallet_no, pi_LineID ";
            vpi_report_ds = DbHelperSQL.Query(strsql + strwhere + strorderby);

            if (vpi_report_ds.Tables[0].Rows.Count <= 0)
            {
                lblMsg.Text = txt0PINum_piReport.Text + " is not exist.";
                txt0PINum_piReport.Focus();
                return;
            }
            data0GVPiReport.DataSource = vpi_report_ds.Tables[0].DefaultView;
            cf.initHeaderTextPIDetGrr(data0GVPiReport);
            data0GVPiReport.Refresh();
        }

        private void frmPI2Report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cf.downLoadExcel(vpi_report_ds, lblMsg, cf.nameList0vpi_report_ds(), txt0PINum_piReport.Text.Trim());
        }

        private void txt0PINum_piReport_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0_enquire_piReport;
        }

        private void btn2UploadToHKPIDB_Click(object sender, EventArgs e)
        {

        }

    }
}
