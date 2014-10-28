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
        frmEnterTxt _frmET;

        frmEnterForReference _FrmForRefe;

        public string _strCellColName;
        public string _sameColumnName;
        public string _deffCellName;
        public string _deffCellValue;

        public string _clickCellname = "pi_pallet_no";

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
            btn00More.Click += btn00More0_Click;
        }

        void btn00More0_Click(object sender, EventArgs e)
        {
            _FrmForRefe = new frmEnterForReference(_idr_show, this);

            _FrmForRefe.textBox1.Text = txt0PINum_piReport.Text;
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
            _FrmForRefe.lblTitle.Text = "PI ID# OR IP:";
            _FrmForRefe.Text = "Enquire by PI ID";
            //
            _strCellColName = "PI_ID";
            _sameColumnName = "pi_user_ip";
            _clickCellname = "CartonID";
            _deffCellName = "pi_status";
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
            btn_enquire_piReport_Click(sender, e);
        }

        void data0GVForReference_Click(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(_FrmForRefe.data0GVForReference, e.RowIndex, e.ColumnIndex, _strCellColName);
            string strBatchID = cf.selectCellMethod(dwo);
            txt0PINum_piReport.Text = strBatchID;
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
            DoWrokObject dwo = new DoWrokObject(data0GVPiReport, 3, e.RowIndex, Color.LightGreen, _clickCellname, "pi_status", "Yes", Color.LightGray);
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

        public void btn_enquire_piReport_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
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
                data0GVPiReport.DataSource = null;
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

            string strwhereYes = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and pi_status='Yes'";
            string strwhereNo = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and pi_status='No'";

            int listcountno = new PIE.DAL.vpi_report_ext().getCount(strwhereNo);
            int listcountYes = new PIE.DAL.vpi_report_ext().getCount(strwhereYes);

            if (listcountno <= 0 && listcountYes > 0)
            {
                lblMsg.Text = "Notice: " + txt0PINum_piReport.Text.Trim() + " has being Update Over.";
                return;
            }
            if (listcountno <= 0)
            {
                lblMsg.Text = "Notice: " + strwhereNo + " has no Data.";
                return;
            }
            PI.Model.PI_MSTR_Remote pI_MSTR_Remote_model = new PI.Model.PI_MSTR_Remote();

            pI_MSTR_Remote_model.PI_NO = txt0PINum_piReport.Text.Trim();
            pI_MSTR_Remote_model.PI_Date = dt;

            var addRemoteMstr = new PI.DAL.PI_MSTR_Remote_ext().Add(pI_MSTR_Remote_model, true);
            if (!addRemoteMstr)
            {
                lblMsg.Text = "Error: Upload PI:" + txt0PINum_piReport.Text + " to DataBase(HK) fails.";
                return;
            }

            string strwherePalletCount = "PI_NO='" + txt0PINum_piReport.Text.Trim() + "'";
            List<PIE.Model.vpi_report_palletCount> vpi_report_palletCount_mode_list = new PIE.BLL.vpi_report_palletCount().GetModelList(strwherePalletCount);

            foreach (var itemPall in vpi_report_palletCount_mode_list)
            {
                //add TTL for pallet
                PI.Model.PI_DET_Remote pI_DET_Remote_model_ttl = new PI.Model.PI_DET_Remote();

                pI_DET_Remote_model_ttl.PI_NO = itemPall.PI_NO;
                pI_DET_Remote_model_ttl.PI_CARTON_NO = itemPall.PI_CARTON_NO;
                pI_DET_Remote_model_ttl.PI_DESC = itemPall.PI_DESC;
                pI_DET_Remote_model_ttl.PI_GW = itemPall.PI_GW;

                var addflagttl = new PI.BLL.PI_DET_Remote().Add(pI_DET_Remote_model_ttl);
                if (addflagttl<=0)
                {
                    return;
                }
                string strwherePalletNo = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and pi_status='No' and pi_pallet_no='" + itemPall.pi_pallet_no + "'";
                List<PIE.Model.vpi_report> vpi_report_list_no = new PIE.BLL.vpi_report().GetModelList(strwherePalletNo);
                #region upload to Remote HK(PI)
                foreach (PIE.Model.vpi_report item in vpi_report_list_no)
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
                    //pI_DET_Remote_model.PI_GW = item.GW;
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

                    //GW
                    pI_DET_Remote_model.PI_GW = (item.Pallet_TTL_NW.Equals(DBNull.Value) || string.IsNullOrEmpty(item.Pallet_TTL_NW)) ? 0 : Convert.ToDecimal(item.Pallet_TTL_NW);

                    pI_DET_Remote_model.pi_ver = 1;

                    var intresutl = new PI.BLL.PI_DET_Remote().Add(pI_DET_Remote_model);
                    if (intresutl > 0)
                    {
                        string strupdatesqldet = "update dbo.pi_det set pi_status='Yes' where PI_ID='" + item.PI_ID + "' and pi_LineID='" + item.pi_LineID + "' and pi_wec_ctn='" + item.pi_wec_ctn + "'";
                        string strupdatesqlMstr = "update dbo.pi_mstr set pi_status='Yes' where PI_ID='" + item.PI_ID + "'";

                        var changeStatus = DbHelperSQL.ExecuteSql(strupdatesqldet);
                        var changeStatusMstr = DbHelperSQL.ExecuteSql(strupdatesqlMstr);
                        addRemoteD++;
                    }

                }
                if (addRemoteD > 0)
                {
                    if (addRemoteD >= listcountno)
                    {
                        lblMsg.Text = "Success: Upload PI:" + txt0PINum_piReport.Text + " to DataBase(HK)";
                    }
                    else
                    {
                        lblMsg.Text = "Notice: Upload PI:" + txt0PINum_piReport.Text + " to  DataBase(HK) OK, but some is not";
                    }
                    btn_enquire_piReport_Click(sender, e);
                }

                #endregion
            }

        }

        private void downLoad1ToExceltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cf.downLoadExcel(vpi_report_ds, lblMsg, cf.nameList0vpi_report_ds(), "22PIReoprt" + txt0PINum_piReport.Text.Trim());
        }

    }
}
