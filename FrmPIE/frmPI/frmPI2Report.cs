using FrmPIE;
using FrmIDR._0API;
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
using System.Threading;

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
        public string currmsg = "";
        public string _retunUsd = "Error";
        public string errormsg = "";
        public string _piid = "";

        public string _clickCellname = "pi_pallet_no";

        public frmPI2Report(frmIDR idr)
        {
            _idr_show = idr;
            cf = new Commfunction(idr);

            InitializeComponent();

            data0GVPiReport.MultiSelect = false;

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
            _FrmForRefe.btn2OK.Click += button1_DoubleClick;
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
            // ThreadPool.QueueUserWorkItem(new WaitCallback(cf.cellSelectMethod), dwo);

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
            //            enquireData("dd");
            lblMsg.Text = "";
            ThreadPool.QueueUserWorkItem(new WaitCallback(enquireData), "dd");

        }

        private void enquireData(object o)
        {
            _idr_show.Invoke(new FrmIDR._0API.Commfunction.Action(delegate()
            {
                if (string.IsNullOrEmpty(txt0PINum_piReport.Text.Trim()) || txt0PINum_piReport.Text.Length > 12)
                {
                    txt0PINum_piReport.Focus();
                    currmsg = "Error: Please enter right PI Num (leng 12).";
                    cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                    return;
                }
                string strsql = @"select * from vpi_report where PI_ID='" + txt0PINum_piReport.Text.Trim() + "' ORDER BY PI_ID,plr_LineID_tran ";
                vpi_report_ds = DbHelperSQL.Query(strsql);

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
                btn2UploadToHKPIDB.Enabled = true;
                btn0RetryUpload.Enabled = true;
            }));


            //lblpino.Visible = true;
            //txt1Change.Visible = true;
            //btn3Change.Visible = true;
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
            try
            {
                btn2UploadToHKPIDB.Enabled = false;
                lblMsg.Text = "";
                DateTime dt = DbHelperSQL.getServerGetDate();

                string strwhereAll = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "'";
                string strwhereRiR = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and (pisr_rir='' or pisr_rir is null) ";
                string strwhereYes = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and pi_status='Yes'";
                string strwhereNo = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and pi_status='No'";

                int listcountAll = new PIE.DAL.vpi_report_ext().getCount(strwhereAll);
                int listcountRir = new PIE.DAL.vpi_report_ext().getCount(strwhereRiR);
                int listcountno = new PIE.DAL.vpi_report_ext().getCount(strwhereNo);
                int listcountYes = new PIE.DAL.vpi_report_ext().getCount(strwhereYes);

                if (listcountAll <= 0)
                {
                    lblMsg.Text = "Notice1: " + txt0PINum_piReport.Text.Trim() + " has not Data.";
                    return;
                }
                if (listcountYes == listcountAll)
                {
                    lblMsg.Text = "Notice3: " + txt0PINum_piReport.Text.Trim() + " has being Update Over.";
                    return;
                }
                if (listcountno <= 0)
                {
                    lblMsg.Text = "Notice2: " + strwhereNo + " has no Data to update.";
                    return;
                }
                if (listcountYes == listcountAll)
                {
                    lblMsg.Text = "Notice4: " + txt0PINum_piReport.Text.Trim() + " has being Update Over.";
                    return;
                }
                if (listcountYes != listcountAll && listcountYes > 0)
                {
                    lblMsg.Text = "Notice5: " + txt0PINum_piReport.Text.Trim() + " has some not update OK,Please retry Upload to HK. thank you.";
                    return;
                }
                if (listcountRir > 0)
                {
                    var msg = "Notice6: " + txt0PINum_piReport.Text.Trim() + " has some data are not RiR#. that will be open new tab to Refresh RiR#";
                    System.Windows.Forms.MessageBox.Show(msg);
                    var rire = new KeyEventArgs(Keys.Enter);
                    _idr_show.tabScanCartonLabel("Refresh RiR NO", txt0PINum_piReport.Text.Trim(), _idr_show, sender, rire);
                    return;
                }
                if (GetPriceOfUSD(txt0PINum_piReport.Text.Trim()).Equals("Error"))
                {
                    return;
                };
                var pi_mstr_remote_exit = new PI.BLL.PI_MSTR_Remote().Exists(txt0PINum_piReport.Text.Trim());

                if (pi_mstr_remote_exit)
                {
                    string msg = "Notice7: " + txt0PINum_piReport.Text.Trim() + " was exist in Remote HK Database(PI pi_mstr),\n If OK ,the HK Database（PI_NO):" + txt0PINum_piReport.Text.Trim() + " Will be Delete";

                    if (System.Windows.Forms.MessageBox.Show(msg + "\n Are you sure Continue to Upload " + txt0PINum_piReport.Text.Trim(), "Notice", MessageBoxButtons.YesNo) == DialogResult.No)
                    {

                        lblMsg.Text = msg;
                        return;
                    }
                    else
                    {
                        var delpimstremote = new PI.DAL.PI_MSTR_Remote().Delete(txt0PINum_piReport.Text.Trim());
                        var delpidetremote = new PI.DAL.PI_DET_Remote_ext().Delete(txt0PINum_piReport.Text.Trim(), true);
                    }

                }
                else
                {
                    PI.Model.PI_MSTR_Remote pI_MSTR_Remote_model = new PI.Model.PI_MSTR_Remote();

                    pI_MSTR_Remote_model.PI_NO = txt0PINum_piReport.Text.Trim();
                    pI_MSTR_Remote_model.PI_Date = dt;


                    var addRemoteMstr = new PI.DAL.PI_MSTR_Remote_ext().Add(pI_MSTR_Remote_model, true);
                    if (!addRemoteMstr)
                    {
                        lblMsg.Text = "Error: Upload PI:" + txt0PINum_piReport.Text + " to DataBase(HK) fails.";
                        return;
                    }
                }

                //satrt upload to HK db
                //UploadToHk(listcountno);

                ThreadPool.QueueUserWorkItem(new WaitCallback(UploadToHk), listcountno);

                //Thread tusb = new Thread(new ParameterizedThreadStart(UploadToHk));
                //tusb.Join(listcountno);
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: Upload PI:" + txt0PINum_piReport.Text + " fail,Please Retry Upload again";
                btn2UploadToHKPIDB.Enabled = false;
                btn0RetryUpload.Enabled = true;
                btn0RetryUpload.Focus();
            }


        }
        public void UploadToHk(object o)
        {

            DateTime dt = DbHelperSQL.getServerGetDate();
            int addRemoteD = 0;
            int allCount = 0;
            int currentItem = 0;
            //satrt upload to HK db
            #region satrt upload to HK db

            string strwherePalletCount = "PI_NO='" + txt0PINum_piReport.Text.Trim() + "' order by PI_NO,plr_LineID";
            List<PIE.Model.vpi_report_palletCount> vpi_report_palletCount_mode_list = new PIE.BLL.vpi_report_palletCount().GetModelList(strwherePalletCount);
            //add TTL for one row
            PI.Model.PI_DET_Remote pI_DET_Remote_model_one = new PI.Model.PI_DET_Remote();
            pI_DET_Remote_model_one.PI_NO = txt0PINum_piReport.Text.Trim();
            pI_DET_Remote_model_one.PI_DESC = "直上";
            var addflagone = new PI.BLL.PI_DET_Remote().Add(pI_DET_Remote_model_one);
            if (addflagone <= 0)
            {
                currmsg = "Error: add fails, please retry Upload.";
                cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                return;
            }
            //add TTL for pallet
            foreach (var itemPall in vpi_report_palletCount_mode_list)
            {
                currmsg = "Notice: Start Upload PI:" + itemPall.PI_NO + ",Pallet:" + itemPall.pi_pallet_no;
                cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                //add TTL for pallet
                PI.Model.PI_DET_Remote pI_DET_Remote_model_ttl = new PI.Model.PI_DET_Remote();

                if ((itemPall.pi_pallet_no == itemPall.PI_GW.ToString()) || itemPall.PI_GW == 0)
                {
                    currmsg = "Error: Please Add PI:" + txt0PINum_piReport.Text + " GW for Pallet " + itemPall.pi_pallet_no.ToString();
                    cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                    var de = new KeyEventArgs(Keys.Enter);
                    _idr_show.tabScanAddNwForPallet("Add NW for Pallet", txt0PINum_piReport.Text, _idr_show, new object(), de);
                    return;
                }
                pI_DET_Remote_model_ttl.PI_NO = itemPall.PI_NO;
                pI_DET_Remote_model_ttl.PI_CARTON_NO = itemPall.PI_CARTON_NO;
                pI_DET_Remote_model_ttl.PI_DESC = itemPall.PI_DESC;
                pI_DET_Remote_model_ttl.PI_GW = itemPall.PI_GW;

                var addflagttl = new PI.BLL.PI_DET_Remote().Add(pI_DET_Remote_model_ttl);
                if (addflagttl <= 0)
                {
                    return;
                }
                string strwherePalletNo = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and pi_status='No' and pi_pallet_no='" + itemPall.pi_pallet_no + "' order by plr_LineID_tran";
                List<PIE.Model.vpi_report> vpi_report_list_no = new PIE.BLL.vpi_report().GetModelList(strwherePalletNo);
                //allCount += vpi_report_list_no.Count;
                #region upload to Remote HK(PI)
                foreach (PIE.Model.vpi_report item in vpi_report_list_no)
                {
                    currentItem++;
                    currmsg = "Notice: Start Upload PI:" + itemPall.PI_NO + ",Pallet:" + itemPall.pi_pallet_no + ",Total:" + o.ToString() + ",At: " + currentItem + ",WecID " + item.pi_wec_ctn + ", LineID:" + item.plr_LineID_tran;
                    cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);

                    PI.Model.PI_DET_Remote pI_DET_Remote_model = new PI.Model.PI_DET_Remote();

                    pI_DET_Remote_model.PI_CARTON_NO = item.CartonID;
                    pI_DET_Remote_model.PI_CO = item.CoDesc;
                    pI_DET_Remote_model.PI_ConnCode = item.pisr_con_code;
                    pI_DET_Remote_model.PI_CONTRACT = item.Contract;
                    pI_DET_Remote_model.pi_cre_time = dt;
                    //
                    pI_DET_Remote_model.pi_curr_rate = null; //0;
                    pI_DET_Remote_model.PI_DESC = item.sq_name;
                    //pI_DET_Remote_model.PI_GW = item.GW;
                    pI_DET_Remote_model.PI_IQC = item.pisr_rec_type;
                    pI_DET_Remote_model.pi_Lic_req = string.IsNullOrEmpty(item.pisr_lic_req) ? " - " : item.pisr_lic_req;
                    pI_DET_Remote_model.PI_LINE = item.pi_LineID;
                    pI_DET_Remote_model.PI_LOT = item.pisr_rir;

                    pI_DET_Remote_model.pi_mfgr = item.MFGR;
                    pI_DET_Remote_model.pi_mfgr_name = item.MFGR_Name;

                    pI_DET_Remote_model.pi_mfgr_part = item.MFGR_Part;
                    pI_DET_Remote_model.PI_NO = item.PI_ID;
                    pI_DET_Remote_model.PI_NW = item.pisr_dec02;
                    pI_DET_Remote_model.PI_K200_NW = item.pisr_dec01;
                    //
                    pI_DET_Remote_model.pi_ori_PO_price = null;// 0;
                    pI_DET_Remote_model.PI_PALLET = item.pi_pallet_no.ToString();
                    pI_DET_Remote_model.PI_PART = item.pisr_part;
                    pI_DET_Remote_model.PI_PO = item.pisr_po_nbr;
                    pI_DET_Remote_model.pi_PO_curr = null;// item.pisr_curr;
                    //
                    pI_DET_Remote_model.PI_PO_price = 0;
                    pI_DET_Remote_model.PI_REC_NO = item.pisr_us_cost.ToString();//item.pisr_cost.ToString();
                    pI_DET_Remote_model.PI_QTY = item.pisr_qty;
                    //
                    //pI_DET_Remote_model.PI_REC_NO = item.REC_NO;
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
                    pI_DET_Remote_model.PI_GW = null;//(item.Pallet_TTL_NW.Equals(DBNull.Value) || string.IsNullOrEmpty(item.Pallet_TTL_NW)) ? 0 : Convert.ToDecimal(item.Pallet_TTL_NW);

                    pI_DET_Remote_model.pi_ver = 1;

                    //add
                    //pI_DET_Remote_model.pi_Lic_req = " - ";

                    var intresutl = new PI.BLL.PI_DET_Remote().Add(pI_DET_Remote_model);
                    if (intresutl > 0)
                    {

                        string strupdatesqldet = "update dbo.pi_det set pi_status='Yes' where PI_ID='" + txt0PINum_piReport.Text + "' and plr_LineID_tran='" + item.plr_LineID_tran + "'";
                        string strupdatesqlMstr = "update dbo.pi_mstr set pi_status='Yes' where PI_ID='" + txt0PINum_piReport.Text + "'";
                        var changeStatus = DbHelperSQL.ExecuteSql(strupdatesqldet);
                        var changeStatusMstr = DbHelperSQL.ExecuteSql(strupdatesqlMstr);
                        addRemoteD++;
                    }

                }
                if (addRemoteD > 0)
                {
                    if (addRemoteD >= (int)o)
                    {
                        currmsg = "Success: Upload PI:" + txt0PINum_piReport.Text + " to DataBase(HK)";
                        cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                    }
                    else
                    {


                        currmsg = "Error: Upload PI:" + txt0PINum_piReport.Text + " fail,Please Retry Upload again";
                        cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                    }
                }

                #endregion
            }
            EventArgs _e = new EventArgs();
            btn_enquire_piReport_Click(btn0_enquire_piReport, _e);
            currmsg = "Notie: Upload PI:" + txt0PINum_piReport.Text + " all success.";
            cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);

            ///end start upload HK db
            #endregion

        }
        private void downLoad1ToExceltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cf.downLoadExcel(vpi_report_ds, lblMsg, cf.nameList0vpi_report_ds(), "22PIReoprt" + txt0PINum_piReport.Text.Trim());
        }

        private void btn3Change_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt0PINum_piReport.Text.Trim()))
            {
                txt0PINum_piReport.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt1Change.Text.Trim()))
            {
                txt1Change.Focus();
                return;
            }
            string mbox = "Are you sure Change " + txt0PINum_piReport.Text + " to " + txt1Change.Text;
            if (System.Windows.Forms.MessageBox.Show(mbox, "Notice", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                lblMsg.Text = "";
                return;
            }
            string strwhereYes = "PI_ID='" + txt0PINum_piReport.Text.Trim() + "' and pi_status='Yes'";

            int listcountYes = new PIE.DAL.vpi_report_ext().getCount(strwhereYes);

            if (listcountYes < 0)
            {
                lblMsg.Text = "Notice: " + txt0PINum_piReport.Text.Trim() + " has not update to HK PI Database.";
                return;
            }

            var pi_mstr_remote_exit = new PI.BLL.PI_MSTR_Remote().Exists(txt1Change.Text.Trim());

            var pi_det_remote_exit = new PI.DAL.PI_DET_Remote_ext().Exists(txt1Change.Text.Trim());


            if (!pi_mstr_remote_exit)
            {
                lblMsg.Text = "Notice: " + txt1Change.Text.Trim() + " not exist in Remote HK Database(PI pi_mstr)";
                return;
            }

            if (!pi_det_remote_exit)
            {
                lblMsg.Text = "Notice: " + txt1Change.Text.Trim() + " not exist in Remote HK Database(PI pi_det)";
                return;
            }
            var pi_det_update_flag = new PI.DAL.PI_DET_Remote_ext().Update(txt0PINum_piReport.Text.Trim(), txt1Change.Text.Trim());
            if (pi_det_update_flag)
            {
                string flagms = "Success:  Change " + txt0PINum_piReport.Text + " to " + txt1Change.Text + " OK in Remote HK Database(PI pi_det)";
                lblMsg.Text = flagms;
                var exitpi_mstr = new PI.BLL.pi_mstr().Exists(txt1Change.Text, 1);
                var change_pi_mstr_flag = true;
                if (!exitpi_mstr)
                {
                    change_pi_mstr_flag = new PI.DAL.pi_mstr_ext().Update(txt0PINum_piReport.Text.Trim(), txt1Change.Text.Trim());
                }
                else
                {
                    var exitchange = new PI.BLL.pi_mstr().GetModel(txt0PINum_piReport.Text.Trim(), 1);
                    exitchange.pi_status_msg += "Change to " + txt1Change.Text;
                    exitchange.pi_remark += "Change to " + txt1Change.Text;
                    var updatNettoChange = new PI.BLL.pi_mstr().Update(exitchange);

                }
                if (change_pi_mstr_flag)
                {
                    var chage_pi_det_flag = new PI.DAL.pi_det_ext().Update(txt0PINum_piReport.Text.Trim(), txt1Change.Text.Trim());
                    if (chage_pi_det_flag)
                    {
                        txt0PINum_piReport.Text = txt1Change.Text;
                        btn_enquire_piReport_Click(sender, e);
                        lblMsg.Text = flagms + ",本地更新OK";
                    }
                }
            }
            else
            {
                lblMsg.Text = "Fail: " + txt1Change.Text.Trim() + " Change Fail in Remote HK Database(PI pi_det)";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (GetPriceOfUSD(txt0PINum_piReport.Text.Trim()).Equals("Error"))
            {
                return;
            };
        }
        public string GetPriceOfUSD(string piid)
        {
            //GetUSBPrice(ds);

            //Thread tusb = new Thread(new ParameterizedThreadStart(GetUSBPrice));
            //tusb.Start(ds);

            //tusb.Join();
            //return _retunUsd;
            _piid = piid;
            PI.Model.pi_mstr pi_mstr_model = new PI.BLL.pi_mstr().GetModel(piid, 1);


            if (pi_mstr_model == null)
            {
                currmsg = "Error1: get price fail.";
                cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                return "Error";
            }
            if (string.IsNullOrEmpty(pi_mstr_model.pi_chr01))
            {
                currmsg = "Error2: get price fail.";
                cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                return "Error";
            }

            var updateExit = new PI.DAL.pisr_grr_ext().Exists(piid);
            if (!updateExit)
            {
                return "OK";
            }

            try
            {
                FrmPIE.WebReferenceRTM99.Service server100 = new FrmPIE.WebReferenceRTM99.Service();
                server100.Timeout = 900000;
                //pi_chr01 is barchid
                var ds = server100.GetTable_n("WEC", "wsas019", pi_mstr_model.pi_chr01);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return GetUSBPrice(ds);
                    }
                }

                currmsg = "Error6: get price fail. please check wec(wsas019) data is exists bathcid: " + pi_mstr_model.pi_chr01;
                cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                return "Error";

            }
            catch (Exception ex)
            {

                currmsg = "Error7: get price fail. " + ex.Message;
                cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                return "Error";
            }

        }
        public string GetUSBPrice(object o)
        {
            DataSet ds = (DataSet)o;

            int dscount = ds.Tables[0].Rows.Count;
            for (int y = 0; y < ds.Tables[0].Rows.Count; y++)
            {
                string wsas019_wec_id = ds.Tables[0].Rows[y]["wsas019_wec_id"].ToString();
                string wsas019_rir = ds.Tables[0].Rows[y]["wsas019_rir"].ToString();
                string wsas019_us_cost = Convert.ToDecimal(ds.Tables[0].Rows[y]["wsas019_us_cost"]).ToString("#,#.0000");

                if (string.IsNullOrEmpty(wsas019_wec_id) || string.IsNullOrEmpty(wsas019_rir) || string.IsNullOrEmpty(wsas019_us_cost))
                {
                    currmsg = "Error3: get price fail. wec_id or rir# or us_cost is null ";
                    cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);
                    continue;
                }
                else
                {
                    currmsg = "Notice: update USD price for RiR#: " + wsas019_rir + ",Wecid:" + wsas019_wec_id;
                    cf.SetCtlTextdelegate(lblMsg, currmsg, true, true);

                    var updatePriceflag = new PI.DAL.pisr_grr_ext().Update(wsas019_wec_id, wsas019_rir, wsas019_us_cost, _piid);

                    if (!updatePriceflag)
                    {

                        errormsg = "Error5: update fail list: Wec_id:" + wsas019_wec_id + ",RiR#: " + wsas019_rir;

                    }
                }
            }
            if (!string.IsNullOrEmpty(errormsg))
            {
                cf.SetCtlTextdelegate(lblMsg, errormsg, true, true);
                return "Error";

            }
            return "OK";
        }
        private void btn0RetryUpload_Click(object sender, EventArgs e)
        {
            try
            {
                btn0RetryUpload.Enabled = false;
                if (!string.IsNullOrEmpty(txt0PINum_piReport.Text))
                {
                    var existpi = new PI.BLL.pi_mstr().Exists(txt0PINum_piReport.Text.Trim(), 1);
                    if (existpi)
                    {
                        if (System.Windows.Forms.MessageBox.Show("Are you sure Retry UpLoad PIID:[" + txt0PINum_piReport.Text + "] to[HK,PI_DB]", "Notice", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            string strupdatesqldet = "update dbo.pi_det set pi_status='No' where PI_ID='" + txt0PINum_piReport.Text.Trim() + "'";
                            string strupdatesqlMstr = "update dbo.pi_mstr set pi_status='No' where PI_ID='" + txt0PINum_piReport.Text.Trim() + "'";

                            var changeStatus = DbHelperSQL.ExecuteSql(strupdatesqldet);
                            var changeStatusMstr = DbHelperSQL.ExecuteSql(strupdatesqlMstr);

                            if (changeStatus >= 0 && changeStatusMstr >= 0)
                            {
                                var delpimstremote = new PI.DAL.PI_MSTR_Remote().Delete(txt0PINum_piReport.Text.Trim());
                                var delpidetremote = new PI.DAL.PI_DET_Remote_ext().Delete(txt0PINum_piReport.Text.Trim(), true);

                                btn2UploadToHKPIDB.Enabled = true;
                                btn2UploadToHKPIDB_Click(sender, e);
                            }
                            else
                            {
                                lblMsg.Text = "Please try again.";
                                btn0RetryUpload.Enabled = true;
                                return;
                            }
                        }
                    }
                    else
                    {
                        lblMsg.Text = "PIID: " + txt0PINum_piReport.Text + " is not exists";
                    }

                }
                else
                {

                    txt0PINum_piReport.Focus();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: Please try again. " + ex.Message;
                btn0RetryUpload.Enabled = true;
            }

        }
    }
}
