﻿using FrmPIE;
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
        frmEnterTxt _frmET;

        public frmPI2Report(frmIDR idr)
        {
            _idr_show = idr;
            cf = new Commfunction(idr);

            InitializeComponent();

            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;
            gb0PIReport.Resize += gb0PIReport_Resize;

            data0GVPiReport.CellClick += data0GVPiReport_CellClick;
            data0GVPiReport.RowEnter += data0GVPiReport_RowEnter;
            initWidth();

            data0GVPiReport.ContextMenuStrip = ctmenu0EnquireByPart;
            enquireByPartToolStripMenuItem.Click += enquireByPartToolStripMenuItem_Click;
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
            cf.EnquireByPart(data0GVPiReport, "pisr_part", _frmET.textBox1.Text.Trim());
        }
        void data0GVPiReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data0GVPiReport, e.RowIndex, e.ColumnIndex, "PI_ID");
            cf.selectCellMethod(dwo);
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
            if (string.IsNullOrEmpty(txt0PINum_piReport.Text.Trim()) || txt0PINum_piReport.Text.Length > 12)
            {
                txt0PINum_piReport.Focus();
                lblMsg.Text = "Error: Please enter right PI Num (leng 12).";
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
            cf.downLoadExcel(vpi_report_ds, lblMsg, cf.nameList0vpi_report_ds(), "2PIReoprt" + txt0PINum_piReport.Text.Trim());
        }

        private void txt0PINum_piReport_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btn0_enquire_piReport;
        }

        private void btn2UploadToHKPIDB_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            DateTime dt = DbHelperSQL.getServerGetDate();
            int addRemoteD = 0;
            string strwhere = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and pi_status='No'";
            List<PIE.Model.vpi_report> vpi_report_list = new PIE.BLL.vpi_report().GetModelList(strwhere);
            int listcount = vpi_report_list.Count;

            if (listcount <= 0)
            {
                lblMsg.Text = "Notice: " + strwhere + " has no Data.";
                return;
            }
            PI.Model.PI_MSTR_Remote pI_MSTR_Remote_model = new PI.Model.PI_MSTR_Remote();
            pI_MSTR_Remote_model.PI_NO = txt0PINum_piReport.Text.Trim();
            pI_MSTR_Remote_model.PI_Date = dt;
            var addRemoteMstr = new PI.DAL.PI_MSTR_Remote_ext().Add(pI_MSTR_Remote_model, true);
            if (!addRemoteMstr)
            {
                lblMsg.Text = "Error: Upload to PI DataBase(HK) fails.";
                return;
            }

            foreach (PIE.Model.vpi_report item in vpi_report_list)
            {
                PI.Model.PI_DET_Remote pI_DET_Remote_model = new PI.Model.PI_DET_Remote();

                pI_DET_Remote_model.PI_CARTON_NO = item.CartonNo;
                pI_DET_Remote_model.PI_CO = item.CoDesc;
                pI_DET_Remote_model.PI_ConnCode = item.pisr_con_code;
                pI_DET_Remote_model.PI_CONTRACT = item.Contract;
                pI_DET_Remote_model.pi_cre_time = dt;
                //
                pI_DET_Remote_model.pi_curr_rate = 0;
                pI_DET_Remote_model.PI_DESC = item.sq_name;
                pI_DET_Remote_model.PI_GW = item.GW;
                pI_DET_Remote_model.PI_IQC = item.pisr_rec_type;
                pI_DET_Remote_model.PI_K200_NW = item.pisr_dec01;
                pI_DET_Remote_model.pi_Lic_req = item.pisr_lic_req;
                pI_DET_Remote_model.PI_LINE = item.pi_LineID;
                pI_DET_Remote_model.PI_LOT = item.pisr_rir;
                pI_DET_Remote_model.pi_mfgr = item.MFGR;
                pI_DET_Remote_model.pi_mfgr_name = item.MFGR_Name;
                pI_DET_Remote_model.pi_mfgr_part = item.MFGR_Part;
                pI_DET_Remote_model.PI_NO = item.PI_ID;
                pI_DET_Remote_model.PI_NW = item.pisr_dec02;
                //
                pI_DET_Remote_model.pi_ori_PO_price = 0;
                pI_DET_Remote_model.PI_PALLET = item.pi_pallet_no.ToString();
                pI_DET_Remote_model.PI_PART = item.pisr_part;
                pI_DET_Remote_model.PI_PO = item.pisr_po_nbr;
                pI_DET_Remote_model.pi_PO_curr = item.pisr_curr;
                //
                pI_DET_Remote_model.PI_PO_price = 0;
                pI_DET_Remote_model.PI_PRICE = 0;
                pI_DET_Remote_model.PI_QTY = item.pisr_qty;
                //
                pI_DET_Remote_model.PI_REC_NO = item.REC_NO;
                pI_DET_Remote_model.PI_SBU = item.pisr_sbu;
                pI_DET_Remote_model.PI_SEQ = (item.pisr_seq.Equals(DBNull.Value) || string.IsNullOrEmpty(item.pisr_seq)) ? 0 : Convert.ToInt32(item.pisr_seq);

                pI_DET_Remote_model.PI_SEQ_CL = pI_DET_Remote_model.PI_SEQ;

                pI_DET_Remote_model.PI_SITE = item.pisr_site;
                //
                pI_DET_Remote_model.PI_Taxcode = null;
                pI_DET_Remote_model.pi_us_rate = null;
                pI_DET_Remote_model.pi_user = _idr_show._sys_user_model.user_name;
                pI_DET_Remote_model.pi_vend = item.pisr_vend;
                pI_DET_Remote_model.pi_ver = 1;

                var intresutl = new PI.BLL.PI_DET_Remote().Add(pI_DET_Remote_model);
                if (intresutl > 0)
                {
                    string strupdatesql = "update dbo.pi_det set pi_status='Yes' where PI_ID='" + item.PI_ID + "' and pi_LineID='" + item.pi_LineID + "' and pi_wec_ctn='" + item.pi_wec_ctn + "'";

                    var changeStatus = DbHelperSQL.ExecuteSql(strupdatesql);
                    addRemoteD++;
                }

            }
            if (addRemoteD > 0)
            {
                if (addRemoteD >= listcount)
                {
                    lblMsg.Text = "Success: Upload to PI DataBase(HK)";
                }
                else
                {
                    lblMsg.Text = "Notice: Upload to PI DataBase(HK) OK, but some is not";
                }
            }
        }

        private void downLoad1ToExceltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cf.downLoadExcel(vpi_report_ds, lblMsg, cf.nameList0vpi_report_ds(), "2PIReoprt" + txt0PINum_piReport.Text.Trim());
        }

    }
}
