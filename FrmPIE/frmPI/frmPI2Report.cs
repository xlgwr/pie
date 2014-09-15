using FrmPIE._0API;
using PIE.Common;
using PIE.DBUtility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE.frmPI
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

            gb0PIReport.Resize += gb0PIReport_Resize;

            initWidth();
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

        private void frmPI2Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btn_enquire_piReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt0PINum_piReport.Text.Trim()))
            {
                txt0PINum_piReport.Focus();
                lblMsg.Text = "Error: Please enter PI Num.";
                return;
            }
            string strsql = @"select * from vpi_report where ";
            string strwhere = @"PI_ID='" + txt0PINum_piReport.Text.Trim() + "'";
            vpi_report_ds = DbHelperSQL.Query(strsql + strwhere);

            //cf.initReportViewer(reportViewer1);

            cf.initReportViewerLoadXMLfromPath(reportViewer1, @"reports\frmPI\rpt_piReport.rdlc");

            cf.addDataSourceToReportViewer(reportViewer1, "piReport", vpi_report_ds);

            cf.ShowReportViewer(reportViewer1, txt0PINum_piReport.Text, true);


        }

        
    }
}
