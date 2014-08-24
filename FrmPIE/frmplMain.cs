using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

using System.Runtime.InteropServices;


using PIE.DBUtility;
using PIE.Common;
using System.Data.SqlClient;

namespace FrmPIE
{
    public partial class frmplMain : Form
    {
        //[DllImport("user32.dll")]
        // private static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);

        PIE.Model.OCR_mstr ocr_mstr_model = new PIE.Model.OCR_mstr();
        PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();


        string packingdoc = "";
        string clientip = "";
        int intCartonGen = 0;
        FrmPIE FrmPIE_visit;

        public frmplMain(PIE.Model.OCR_mstr ocr_mstr_model, FrmPIE _form)
        {
            this.ocr_mstr_model = ocr_mstr_model;
            this.packingdoc = "OCR";
            clientip = Program.getClientIP();
            FrmPIE_visit = _form;
            InitializeComponent();

        }
        public frmplMain(PIE.Model.plr_mstr plr_mstr_model, FrmPIE _form)
        {
            this.plr_mstr_model = plr_mstr_model;
            this.packingdoc = "ePacking";
            clientip = Program.getClientIP();
            FrmPIE_visit = _form;
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //GC.Collect();
        }

        private void frmplMain_Load(object sender, EventArgs e)
        {
            this.txtplr_suppliers_id.Focus();
            if (this.packingdoc == "ePacking")
            {
                initModelForTextBox(this.plr_mstr_model);

                //if (string.IsNullOrEmpty(plr_mstr_model.plr_chr01))
                //{
                //    this.lblPoCheckResult.Text = "";

                //}
                //else
                //{
                //    this.lblPoCheckResult.Text = "POChecking: " + plr_mstr_model.plr_chr01;
                //    if (plr_mstr_model.plr_chr01.Equals("OK"))
                //    {
                //        //this.btnGenCartonNo2.Enabled = true;
                //    }
                //    else
                //    {
                //        //this.btnGenCartonNo2.Enabled = false;
                //    }

                //}



            }
            else if (this.packingdoc == "OCR")
            {
                this.txtBatchID.Text = ocr_mstr_model.Ocr_BatchID;
                this.txtLineID.Text = ocr_mstr_model.Ocr_lineID;
                this.txtCartonID.Text = ocr_mstr_model.Ocr_ctnID;
                //this.txtInvoiceID.Text = ocr_mstr_model.invoiceId;

                this.txtPackingListID.Text = ocr_mstr_model.Ocr_PackinglistID;
                this.txtPO.Text = ocr_mstr_model.Ocr_po;
                this.txtQTY.Text = ocr_mstr_model.Ocr_qty;
                this.txtPart.Text = ocr_mstr_model.Ocr_partno;
            }

            string strwhere = "Batch_ID='" + this.txtBatchID.Text + "' and LineID='" + this.txtLineID.Text + "'";
            intCartonGen = new PIE.BLL.plr_mstr_tran().GetRecordCount(strwhere);
            if (intCartonGen > 0)
            {
                this.lbl_CartonGen.Visible = true;
            }
            initCartonFromTo();
        }

        private void initModelForTextBox(PIE.Model.plr_mstr plr_mstr_model)
        {
            this.txtBatchID.Text = plr_mstr_model.Batch_ID;
            this.txtLineID.Text = plr_mstr_model.LineID.ToString();

            this.txtPalletNo.Text = plr_mstr_model.plr_pallet_no == null ? "" : plr_mstr_model.plr_pallet_no.ToString().Trim();

            //this.txtplr_suppliers_id.Text = plr_mstr_model.plr_suppliers_id;
            this.txtCartonType.Text = plr_mstr_model.CartonType;
            this.txtCartonID.Text = plr_mstr_model.CartonID;
            this.txtCartonQty.Text = plr_mstr_model.plr_carton_qty.ToString();
            this.txtInvoiceID.Text = plr_mstr_model.InvoiceID;

            this.txtPackingListID.Text = plr_mstr_model.packingListID;
            this.txtPO.Text = plr_mstr_model.plr_po;

            this.txtQTY.Text = plr_mstr_model.plr_qty.ToString().ToString();
            this.txtPart.Text = plr_mstr_model.plr_partno;
            this.dateTimeDeliDate.Text = plr_mstr_model.plr_deli_date.ToString();

            this.dateTimeRecDate.Text = plr_mstr_model.plr_rcp_date.ToString();


            this.txtCartonprifix.Text = plr_mstr_model.carton_id_prifix;
            this.txtCartonIDFrom.Text = plr_mstr_model.carton_id_from.ToString();
            this.txtCartonIDTo.Text = plr_mstr_model.carton_id_to.ToString();

            this.txtRemark.Text = plr_mstr_model.re_mark;
        }




        private void txtCartonIDFrom_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCartonIDFrom.TextLength == 0)
            {
                this.txtCartonIDFrom.BackColor = Color.Red;
                this.txtCartonIDFrom.Text = "0";
            }
            else
            {
                this.txtCartonIDFrom.BackColor = Color.White;
            }
        }

        private void txtCartonIDTo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCartonIDTo.TextLength == 0)
            {
                this.txtCartonIDTo.BackColor = Color.Red;
                this.txtCartonIDTo.Text = "0";
            }
            else
            {
                this.txtCartonIDTo.BackColor = Color.White;
            }
        }

        private bool isnulltxt()
        {
            if (string.IsNullOrEmpty(txtPalletNo.Text.Trim()))
            {
                lblShowMsg("PalletNo must has one", "Error");
                txtPalletNo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtInvoiceID.Text.Trim()))
            {
                lblShowMsg("InvoiceID must has one", "Error");
                txtInvoiceID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPO.Text.Trim()))
            {
                lblShowMsg("PO must be has.", "Error");
                txtPO.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPackingListID.Text.Trim()))
            {
                lblShowMsg(" PackingListID  must has one", "Error");
                txtPackingListID.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(txtPart.Text.Trim()))
            {
                lblShowMsg("Part must be has.", "Error");
                txtPart.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCartonQty.Text.Trim()))
            {
                lblShowMsg("CartonQty must be has.", "Error");
                txtCartonQty.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtQTY.Text.Trim()))
            {
                lblShowMsg("QTY must be has.", "Error");
                txtQTY.Focus();
                return false;
            } if (string.IsNullOrEmpty(txtCartonID.Text.Trim()))
            {
                lblShowMsg("CartonID must be has.", "Error");
                txtCartonID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtCartonType.Text.Trim()))
            {
                lblShowMsg("Number of Carton must be has.", "Error");
                txtCartonType.Focus();
                return false;
            }


            //number 
            isNumber(txtQTY);
            isNumber(txtCartonType);
            isNumber(txtCartonQty);
            if (!PageValidate.IsNumber(txtCartonIDFrom.Text) || !PageValidate.IsNumber(txtCartonIDTo.Text))
            {
                lblShowMsg("Carton ID must like Numert or NumA-NumB,example C1-10 or 10 or 1-10.", "Error");
                txtCartonID.SelectAll();
                txtCartonID.Focus();
                return false;
            }
            var cartonfrom = Convert.ToInt32(txtCartonIDFrom.Text);
            var cartonto = Convert.ToInt32(txtCartonIDTo.Text);

            if (cartonfrom > cartonto)
            {
                lblShowMsg("Carton ID must like 10 or 1-10", "Error");
                txtCartonID.Focus();
                txtCartonID.SelectAll();
                return false;
            }
            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                initCartonFromTo();
                #region null text
                //if (string.IsNullOrEmpty(txtplr_suppliers_id.Text.Trim()))
                //{
                //    lblShowMsg("suppliers_id must has one", "Error");
                //    txtplr_suppliers_id.Focus();
                //    return;
                //} 
                if (!isnulltxt())
                {
                    return;
                };
                #endregion
                if (btnUpadeAdd.Text == "&Update")
                {

                    plr_mstr_model = new PIE.DAL.plr_mstr().GetModel(txtBatchID.Text.Trim(), Convert.ToInt32(txtLineID.Text.Trim()));


                    initTxtToModel(plr_mstr_model);


                    plr_mstr_model.plr_update_date = DbHelperSQL.getServerGetDate();
                    plr_mstr_model.plr_user_ip = clientip;
                    //plr_mstr_model.plr_status = "";

                    var result_plr_mstr = new PIE.DAL.plr_mstr().Update(plr_mstr_model);

                    if (result_plr_mstr)
                    {

                        FrmPIE_visit.initDataGV_e_Packing3(plr_mstr_model.Batch_ID);
                        FrmPIE_visit.initDataGV_Tran4(plr_mstr_model.Batch_ID, plr_mstr_model.CartonID);
                        //if (plr_mstr_model.plr_doc_type == "PDF")
                        //{

                        //    FrmPIE_visit.initDataGV_PDF3(plr_mstr_model.Batch_ID);
                        //}
                        //else if (plr_mstr_model.plr_doc_type == "e-Packing")
                        //{

                        //    FrmPIE_visit.initDataGV_e_Packing3(plr_mstr_model.Batch_ID);
                        //}
                        //else
                        //{
                        //    FrmPIE_visit.initDataGV_e_Packing3(plr_mstr_model.Batch_ID);
                        //}
                        //this.btnPoCheck.Enabled = true;
                        lblShowMsg("Update success", "Success");
                        //this.txtplr_suppliers_id.Focus();

                    }
                    else
                    {
                        lblShowMsg("Update fail", "Error");
                    }
                }
                else if (btnUpadeAdd.Text == "&Add")
                {
                    string strBatchID = "";
                    int intOutAffected;


                    PIE.Model.plr_batch_mstr plr_bathmstr_model = new PIE.Model.plr_batch_mstr();
                    plr_mstr_model = new PIE.Model.plr_mstr();

                    initTxtToModel(plr_mstr_model);


                    plr_mstr_model.plr_doc_type = "New";
                    plr_mstr_model.plr_cre_date = DbHelperSQL.getServerGetDate();
                    plr_mstr_model.plr_user_ip = clientip;
                    plr_mstr_model.plr_status = "No";


                    SqlParameter[] parameters = {
                                            new SqlParameter("@BatchID",SqlDbType.NVarChar,11)
                                        };
                    parameters[0].Direction = ParameterDirection.Output;

                    DbHelperSQL.RunProcedure("sp_GetBatchID", parameters, out intOutAffected);
                    strBatchID = parameters[0].Value != null ? parameters[0].Value.ToString() : "";
                    if (string.IsNullOrEmpty(strBatchID))
                    {
                        lblShowMsg("生成BatchID,出错，无法新增。", "Error");
                        return;
                    }

                    plr_mstr_model.Batch_ID = strBatchID;
                    plr_mstr_model.LineID = 1;

                    plr_bathmstr_model.batch_id = strBatchID;
                    plr_bathmstr_model.plr_suppliers_id = txtplr_suppliers_id.Text.Trim();
                    plr_bathmstr_model.batch_doc = "New";
                    plr_bathmstr_model.batch_dec01 = 1;
                    plr_bathmstr_model.batch_cre_date = plr_mstr_model.plr_cre_date;
                    plr_bathmstr_model.batch_update_date = plr_mstr_model.plr_cre_date;
                    plr_bathmstr_model.batch_user_ip = clientip;
                    plr_bathmstr_model.batch_status = "No";
                    plr_bathmstr_model.batch_void = 1;

                    var result_plr_batch = new PIE.DAL.plr_batch_mstr().Add(plr_bathmstr_model);
                    if (!result_plr_batch)
                    {
                        lblShowMsg("Add Batch Mstr info fail", "Error");
                        return;
                    }
                    var result_plr_mstr = new PIE.DAL.plr_mstr().Add(plr_mstr_model);
                    if (result_plr_mstr)
                    {

                        Program.GenCartonNo(plr_mstr_model);
                        MessageBox.Show("Add BatchID:" + strBatchID + " success,", "Success");
                        //this.txtplr_suppliers_id.Focus();
                        //this.txtInvoiceID.Focus();
                        this.txtPalletNo.Focus();


                        FrmPIE_visit.initDataGVBM0("");
                        FrmPIE_visit.initDataGV_e_Packing3(plr_mstr_model.Batch_ID);
                        FrmPIE_visit.initDataGV_Tran4(plr_mstr_model.Batch_ID);

                        btnNew_Click(sender, e);

                        if (string.IsNullOrEmpty(plr_mstr_model.Batch_ID))
                        {

                            lblShowMsg("新增新的BatchID", "Notice");
                        }
                        else
                        {
                            lblShowMsg("新增新的BatchID,\t上次新增的为：" + plr_mstr_model.Batch_ID, "Notice");
                        }




                    }
                    else
                    {
                        lblShowMsg("Add fail", "Error");
                    }

                }


            }
            catch (Exception ex)
            {

                lblShowMsg(ex.Message, "Error");
            }


        }

        private void lblShowMsg(string msg, string title)
        {
            this.lblMsg.Visible = false;
            //this.lblMsg.Text = title + ":" + msg;
            this.toolStripStatusLabel1.Text = title + ": " + msg;
        }
        private void initTxtToModel(PIE.Model.plr_mstr plr_mstr_model)
        {
            //plr_mstr_model.plr_suppliers_id = txtplr_suppliers_id.Text.Trim();
            plr_mstr_model.plr_pallet_no = txtPalletNo.Text.Trim();
            plr_mstr_model.InvoiceID = txtInvoiceID.Text.Trim();
            plr_mstr_model.packingListID = txtPackingListID.Text.Trim();
            plr_mstr_model.plr_po = txtPO.Text.Trim();
            plr_mstr_model.CartonType = txtCartonType.Text.Trim();

            plr_mstr_model.plr_partno = txtPart.Text.Trim();
            plr_mstr_model.plr_qty = Convert.ToDecimal(txtQTY.Text.Trim());
            plr_mstr_model.plr_carton_qty = Convert.ToDecimal(txtCartonQty.Text.Trim());
            plr_mstr_model.CartonID = txtCartonID.Text.Trim();
            plr_mstr_model.plr_rcp_date = Convert.ToDateTime(dateTimeRecDate.Text);

            plr_mstr_model.plr_deli_date = Convert.ToDateTime(dateTimeDeliDate.Text);

            plr_mstr_model.carton_id_prifix = this.txtCartonprifix.Text.Trim();
            plr_mstr_model.carton_id_from = Convert.ToDecimal(txtCartonIDFrom.Text.Trim());
            plr_mstr_model.carton_id_to = Convert.ToDecimal(txtCartonIDTo.Text.Trim());


            plr_mstr_model.re_mark = txtRemark.Text.Trim();

        }
        private void genCartonNo(object sender, EventArgs e)
        {
            string outresult;
            string strwhere;
            DataSet ocr_mstr_ds2;
            DataSet plr_mstr_ds3;

            try
            {
                PIE.Model.plr_mstr plr_mstr_model = new PIE.DAL.plr_mstr().GetModel(txtBatchID.Text.Trim(), Convert.ToInt32(txtLineID.Text.Trim()));
                PIE.Model.plr_mstr_log plr_mstr_log_model = new PIE.Model.plr_mstr_log();

                plr_mstr_log_model.Batch_ID = txtBatchID.Text.Trim();
                // plr_mstr_model.InvoiceID = plr_mstr_log_model.InvoiceID =  txtInvoiceID.Text.Trim();
                plr_mstr_model.packingListID = plr_mstr_log_model.packingListID = txtPackingListID.Text.Trim();
                plr_mstr_model.LineID = Convert.ToInt32(txtLineID.Text.Trim());
                plr_mstr_log_model.LineID = Convert.ToInt32(txtLineID.Text.Trim());
                plr_mstr_model.plr_po = plr_mstr_log_model.plr_po = txtPO.Text.Trim();

                plr_mstr_model.plr_partno = plr_mstr_log_model.plr_partno = txtPart.Text.Trim();
                plr_mstr_model.plr_qty = Convert.ToDecimal(txtQTY.Text.Trim());


                plr_mstr_log_model.CartonID = plr_mstr_model.CartonID;

                plr_mstr_model.CartonID = txtCartonID.Text.Trim();

                plr_mstr_model.plr_cre_date = DbHelperSQL.getServerGetDate();
                plr_mstr_log_model.plr_cre_date = DbHelperSQL.getServerGetDate();

                plr_mstr_model.plr_status = "M";

                var pocheckflag = Program.POchecking(txtPO.Text.Trim(), txtPart.Text.Trim(), txtQTY.Text.Trim());
                if (pocheckflag == "1")
                {
                    if (plr_mstr_log_model.CartonID == plr_mstr_model.CartonID)
                    {
                        var result_plr_mstr = new PIE.DAL.plr_mstr().Update(plr_mstr_model);

                    }
                    else
                    {
                        var result_plr_mstr_log = new PIE.DAL.plr_mstr_log().Add(plr_mstr_log_model);
                    }

                    outresult = genCartonID();
                    if (outresult == "0")
                    {

                        lblShowMsg("Update success.", "Success");
                    }
                    else
                    {
                        lblShowMsg("Update fail.", "Error");
                    }
                }
                else if (pocheckflag != "Nothing" && pocheckflag != "Error" && pocheckflag == "0")
                {
                    lblShowMsg(pocheckflag, "Error1");
                }
                else
                {
                    lblShowMsg(pocheckflag, "Error2");
                }
            }
            catch (Exception ex)
            {

                lblShowMsg(ex.Message, "Error");
            }

            this.Visible = false;

            ocr_mstr_ds2 = new PIE.BLL.OCR_mstr().GetList(500, "", "Ocr_cre_date desc");

            strwhere = "Batch_ID='" + ocr_mstr_model.Ocr_BatchID + "' and LineID='" + ocr_mstr_model.Ocr_lineID + "' " +
                        "and PackinglistID='" + ocr_mstr_model.Ocr_PackinglistID + "' and CartonID = '" + ocr_mstr_model.Ocr_ctnID + "' " +
                        "and plr_po='" + ocr_mstr_model.Ocr_po + "'";
            plr_mstr_ds3 = new PIE.DAL.plr_mstr().GetList(strwhere);

            FrmPIE_visit.dataGVPackingListDetailInfo2.DataSource = ocr_mstr_ds2.Tables[0].DefaultView;
            FrmPIE_visit.data1GV2PackingListDetailTransferInfo2.DataSource = plr_mstr_ds3.Tables[0].DefaultView;
            //FrmPIE_visit.dataGVPackingListDetailInfo2.DataSource = null;
            //FrmPIE_visit.dataGVPackingListDetailTransferInfo3.DataSource = null;


        }

        private string genCartonID()
        {
            int outRefpro;
            string result;
            SqlParameter[] parameters = { 
                                                    new SqlParameter("@BatchID",SqlDbType.VarChar,20),
                                                    new SqlParameter("@OriLineID",SqlDbType.VarChar,20),
                                                    new SqlParameter("@OriPONbr",SqlDbType.VarChar,50),
                                                    new SqlParameter("@OriLineID",SqlDbType.VarChar,20),

                                                    new SqlParameter("@LineID",SqlDbType.VarChar,20),
                                                    new SqlParameter("@PONbr",SqlDbType.VarChar,50),
                                                    new SqlParameter("@ctnID",SqlDbType.VarChar,20),
                                                    new SqlParameter("@ctnPre",SqlDbType.VarChar,20),
                                                    new SqlParameter("@ctnFr",SqlDbType.VarChar,20),
                                                    new SqlParameter("@ctnTo",SqlDbType.VarChar,20),

                                                    new SqlParameter("@result",SqlDbType.Int),

                                                };
            parameters[0].Value = txtBatchID.Text.Trim();
            parameters[1].Value = txtLineID.Text.Trim();
            parameters[2].Value = txtPO.Text.Trim();
            parameters[3].Value = txtCartonID.Text.Trim();

            parameters[4].Value = txtLineID.Text.Trim();
            parameters[5].Value = txtPO.Text.Trim();
            parameters[6].Value = txtCartonID.Text.Trim();
            parameters[7].Value = txtCartonprifix.Text.Trim();
            parameters[8].Value = txtCartonIDFrom.Text.Trim();
            parameters[9].Value = txtCartonIDTo.Text.Trim();

            parameters[10].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_ManuCtn_Tran", parameters, out outRefpro);

            result = parameters[10].Value.ToString();
            return result;
        }

        private void txtOriCartonID_TextChanged(object sender, EventArgs e)
        {
            initCartonFromTo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCartonID.Text))
            {
                lblShowMsg("CartonID must be has.", "Notice");
                txtCartonID.Focus();
                return;
            }
            //if (txtCartonType.Text.Equals("0"))
            //{
            //    labShowMsg("CartonType = 0 ,Can't Generate CartonNo.");
            //    return;
            //}

            button1_Click(sender, e);

            var intresutl = Program.GenCartonNo(plr_mstr_model);

            if (intresutl == 0)
            {
                FrmPIE_visit.initDataGV_Tran4(txtBatchID.Text, txtCartonID.Text);
                lbl_CartonGen.Visible = true;

                lblShowMsg("CartonID gen Success.", "Success");

            }
            else
            {
                lbl_CartonGen.Visible = false;
                lblShowMsg("CartonID gen fails.", "Error");
            }
        }



        private void txtCartonType_TextChanged(object sender, EventArgs e)
        {
            initCartonFromTo();
        }

        private void initCartonFromTo()
        {
            string strprefix;
            var strCtnIdArr = Program.initCartonFromTo(txtCartonID.Text, txtCartonQty.Text, out strprefix);

            txtCartonprifix.Text = strprefix;
            txtCartonIDFrom.Text = strCtnIdArr[0].ToString().Trim();
            txtCartonIDTo.Text = strCtnIdArr[1].ToString().Trim();
        }


        private void btnPoCheck_Click(object sender, EventArgs e)
        {
            try
            {
                //this.btnPoCheck.Enabled = false;
                this.lblPoCheckResult.Text = "POChecking...";
                this.Cursor = Cursors.WaitCursor;
                char ckey = '@';
                if (this.packingdoc == "ePacking")
                {
                    plr_mstr_model.plr_po = txtPO.Text.Trim();
                    plr_mstr_model.plr_partno = txtPart.Text.Trim();

                    plr_mstr_model.plr_qty = Convert.ToDecimal(txtQTY.Text.Trim());


                    var checkresult = Program.POchecking(plr_mstr_model);
                    if (checkresult.IndexOf(ckey) > 0)
                    {
                        string[] strArr = checkresult.Split(ckey);
                        this.lblPoCheckResult.Text = "POChecking: " + strArr[1];
                        //this.btnGenCartonNo2.Enabled = false;
                        this.txtPO.Focus();

                    }
                    else if (checkresult.Equals("OK"))
                    {
                        this.lblPoCheckResult.Text = "POChecking: OK";
                        //this.btnGenCartonNo2.Enabled = true;
                    }
                    else
                    {
                        this.lblPoCheckResult.Text = "POChecking: " + checkresult;
                        //this.btnGenCartonNo2.Enabled = false;
                        this.txtPO.Focus();
                    }

                }
                this.Cursor = Cursors.Default;
                FrmPIE_visit.initDataGV_Error5("", 0);
            }
            catch (Exception ex)
            {
                //this.btnPoCheck.Enabled = false;
                //this.btnGenCartonNo2.Enabled = false;
                this.Cursor = Cursors.Default;
                FrmPIE_visit.initDataGV_Error5("", 0);
                lblShowMsg(ex.Message, "Error");
            }



        }



        private void txtPO_Leave(object sender, EventArgs e)
        {
            //if (txtPO.Text != plr_mstr_model.plr_po)
            //{
            //    if (labShowMsg("修改了PO,确认后将PO Checking", "提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //    {
            //        button1_Click(sender, e);
            //        btnPoCheck_Click(sender, e);
            //    }
            //    else
            //    {
            //        txtPO.Text = plr_mstr_model.plr_po;
            //    }
            //}

        }

        private void txtPart_Leave(object sender, EventArgs e)
        {
            //if (txtPart.Text != plr_mstr_model.plr_partno)
            //{
            //    if (labShowMsg("修改了 Part No,确认后将PO Checking", "提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //    {
            //        button1_Click(sender, e);
            //        btnPoCheck_Click(sender, e);
            //    }
            //    else
            //    {
            //        txtPart.Text = plr_mstr_model.plr_partno;
            //    }
            //}

        }

        private void txtQTY_Leave(object sender, EventArgs e)
        {
            //if (txtQTY.Text != plr_mstr_model.plr_qty.ToString())
            //{
            //    if (labShowMsg("修改了 QTY,确认后将PO Checking", "提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //    {
            //        button1_Click(sender, e);
            //        btnPoCheck_Click(sender, e);
            //    }
            //    else
            //    {
            //        txtQTY.Text = plr_mstr_model.plr_qty.ToString();
            //    }
            //}
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //this.txtplr_suppliers_id.Focus();
            //            this.txtInvoiceID.Focus();
            this.txtPalletNo.Focus();

            this.plr_mstr_model = new PIE.Model.plr_mstr();

            this.toolStripStatusLabel1.Text = "Notice: Add a New Batch ID Packing List info";

            initModelForTextBox(this.plr_mstr_model);
            this.btnUpadeAdd.Text = "&Add";
            this.lblPoCheckResult.Visible = false;
            this.lbl_CartonGen.Visible = false;
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.plr_mstr_model = new PIE.Model.plr_mstr();
            initModelForTextBox(this.plr_mstr_model);
            this.btnUpadeAdd.Text = "&Add";
            this.lblPoCheckResult.Visible = false;
            this.lbl_CartonGen.Visible = false;
        }

        public bool isNumber(TextBox tb)
        {
            if (!PageValidate.IsNumber(tb.Text))
            {
                tb.Focus();
                tb.SelectAll();
                lblShowMsg("请输入正确的数字，谢谢.", "Notice");
                return false;
            }
            return true;
        }

        private void txtQTY_Leave_1(object sender, EventArgs e)
        {
            isNumber(txtQTY);
        }

        private void txtCartonType_Leave(object sender, EventArgs e)
        {
            isNumber(txtCartonType);
        }

        private void txtCartonQty_Leave(object sender, EventArgs e)
        {
            isNumber(txtCartonQty);
        }

        private void txtCartonID_Leave(object sender, EventArgs e)
        {
            initCartonFromTo();
        }

        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            if (keyData == Keys.Down)
            {
                if (isnulltxt())
                {
                    //keybd_event(9, 0, 0, 0);
                    SendKeys.Send("{TAB}");
                }
            }
            if (keyData == Keys.Up)
            {
                if (isnulltxt())
                {
                    SendKeys.Send("+{TAB}");
                }

            }
            return base.ProcessCmdKey(ref msg, keyData);

        }


    }
}
