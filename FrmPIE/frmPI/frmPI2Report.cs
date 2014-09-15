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

            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;
            gb0PIReport.Resize += gb0PIReport_Resize;

            initWidth();
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
            vpi_report_ds = DbHelperSQL.Query(strsql + strwhere);

            if (vpi_report_ds.Tables[0].Rows.Count<=0)
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
            if (vpi_report_ds == null)
            {
                lblMsg.Text = "Error: no data.";
            }
            if (vpi_report_ds.Tables[0].Rows.Count > 0)
            {
                lblMsg.Text = "notice: start download excel.";
                string FilePath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"0DownLoadExcel";

                //生成列的中文对应表
                Hashtable nameList = new Hashtable();
                nameList.Add("PI_ID", "PI ID");
                nameList.Add("pi_LineID", "Line");

                nameList.Add("pi_wec_ctn", "Scan SN");

                nameList.Add("pi_pallet_no", "Pallet");
                nameList.Add("CartonNo", "CartonNo");

                nameList.Add("CartonID", "CartonID");

                nameList.Add("pi_chr01", "CO");

                nameList.Add("pisr_rir", "RIR #");
                nameList.Add("pisr_invoice", "Invoice");
                nameList.Add("pisr_part", "WEC-Part");
                nameList.Add("Pisr_receiver", "Receiver");
                nameList.Add("pisr_site", "MG");
                nameList.Add("pisr_po_nbr", "PO-Number");
                nameList.Add("pisr_curr", "Curr");
                nameList.Add("pisr_cost", "U/P");
                nameList.Add("pisr_base_cost", "U/P(Base)");
                nameList.Add("pisr_us_cost", "U/P(USD)");
                nameList.Add("pisr_seq", "Seq");

                nameList.Add("pisr_con_code", "Custom Conn");

                //nameList.Add("pisr_ch_desc","Description");
                nameList.Add("sq_name", "Description");

                nameList.Add("pisr_net_wt", "Net Weight");
                nameList.Add("pisr_rec_type", "STS/IQC/SI");
                nameList.Add("pisr_abc", "ABC");
                nameList.Add("pisr_code", "商检");
                //
                nameList.Add("pisr_lic_req", "Lic. Req");

                nameList.Add("pisr_sbu", "SBU");
                nameList.Add("pisr_vend", "Vend");
                nameList.Add("pisr_mfgr_name", "Mfgr Name");
                nameList.Add("pisr_dec01", "k200 NW");
                nameList.Add("pisr_dec02", "NW");
                //利用excel对象
                DataToExcel dte = new DataToExcel();
                string filename = "";
                try
                {
                    if (vpi_report_ds.Tables[0].Rows.Count > 0)
                    {
                        filename = dte.DataExcel(vpi_report_ds.Tables[0], "标题", FilePath, nameList, txt0PINum_piReport.Text.Trim());
                    }
                }
                catch
                {
                    dte.KillExcelProcess();
                }

                if (filename != "")
                {
                    _idr_show._strDownLoadExcel = FilePath + @"\" + filename;
                    lblMsg.Text = "Success: excel file is at " + _idr_show._strDownLoadExcel;
                    cf.OpenFolderAndSelectFile(_idr_show._strDownLoadExcel);
                }
            }
            else
            {
                lblMsg.Text = "Error: has 0 count data.";
            }
        }

        private void txt0PINum_piReport_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0_enquire_piReport;
        }
    }
}
