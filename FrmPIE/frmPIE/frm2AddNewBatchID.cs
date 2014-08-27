using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

using FrmPIE._0API;
using PIE.DBUtility;
using System.Data.SqlClient;
using PIE.Common;

namespace FrmPIE.frmPIE
{
    public partial class frm2AddNewBatchID : Form
    {
        frmIDR _idr_show;
        commfunction cf;

        PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();

        public frm2AddNewBatchID(frmIDR idr)
        {
            _idr_show = idr;
            cf = new commfunction();

            InitializeComponent();

            btn1UpadeAddAddNewBatchID.Focus();

            initWithHeight();
        }

        private void initWithHeight()
        {
            // groupBox2AddNewBatchID.Width = groupBox0AddNewBatchID.Width - groupBox2AddNewBatchID.Left - 5;

            // groupBox2AddNewBatchID.Height = groupBox0AddNewBatchID.Height - groupBox2AddNewBatchID.Top - 5;
        }
        private void groupBox0AddNewBatchID_Resize(object sender, EventArgs e)
        {
            initWithHeight();
        }
        private void lblShowMsg(string msg, string title)
        {
            this.lblMsg.Visible = true;
            this.lblMsg.Text = title + ":" + msg;
        }
        public bool isNumber(TextBox tb)
        {
            if (!PageValidate.IsNumber(tb.Text))
            {
                tb.Focus();
                tb.SelectAll();
                lblShowMsg("请输入正确的数字，谢谢.", "Notice");

                return true;
            }
            return false;
        }
        public bool isnullempty(TextBox tb, string msg, string title)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                lblShowMsg(msg, title);
                tb.Focus();
                return true;
            }
            return false;
        }
        private bool isnulltxt()
        {
            if (isnullempty(txt3PalletNoAddNewBatchID, "PalletNo must has one", "Error"))
            {
                return false;
            }
            if (isnullempty(txt4InvoiceIDAddNewBatchID, "InvoiceID must has one", "Error"))
            {
                return false;
            }
            if (isnullempty(txt5POAddNewBatchID, "PO must be has.", "Error"))
            {
                return false;
            }
            if (isnullempty(txt6PackingListIDAddNewBatchID, " PackingListID  must has one", "Error"))
            {
                return false;
            }
            if (isnullempty(txt7PartAddNewBatchID, "Part must be has.", "Error"))
            {
                return false;
            }
            if (isnullempty(txt8CartonQtyAddNewBatchID, "CartonQty must be has.", "Error"))
            {
                return false;
            }
            //number
            if (isNumber(txt8CartonQtyAddNewBatchID))
            {
                return false;
            }
            if (isnullempty(txt9QTYAddNewBatchID, "QTY must be has.", "Error"))
            {
                return false;
            }
            //number 
            if (isNumber(txt9QTYAddNewBatchID))
            {
                return false;
            }
            if (isnullempty(txt10CartonIDAddNewBatchID, "CartonID must be has.", "Error"))
            {
                return false;
            }
            if (isnullempty(txt11CartonTypeAddNewBatchID, "Number of Carton must be has.", "Error"))
            {
                return false;
            }
            //number
            if (isNumber(txt11CartonTypeAddNewBatchID))
            {
                return false;
            }


            if (!PageValidate.IsNumber(txt14CartonIDFromAddNewBatchID.Text) || !PageValidate.IsNumber(txt15CartonIDToAddNewBatchID.Text))
            {
                lblShowMsg("Carton ID must like Numert or NumA-NumB,example C1-10 or 10 or 1-10.", "Error");
                txt10CartonIDAddNewBatchID.SelectAll();
                txt10CartonIDAddNewBatchID.Focus();
                return false;
            }
            var cartonfrom = Convert.ToInt32(txt14CartonIDFromAddNewBatchID.Text);
            var cartonto = Convert.ToInt32(txt15CartonIDToAddNewBatchID.Text);

            if (cartonfrom > cartonto)
            {
                lblShowMsg("Carton ID must like 10 or 1-10", "Error");
                txt10CartonIDAddNewBatchID.SelectAll();
                txt10CartonIDAddNewBatchID.Focus();
                return false;
            }
            return true;

        }
        private void initCartonFromTo()
        {
            string strprefix;
            var strCtnIdArr = CartonFromTo.initCartonFromTo(txt10CartonIDAddNewBatchID.Text, txt11CartonTypeAddNewBatchID.Text, out strprefix);

            txt12CartonprifixAddNewBatchID.Text = strprefix;
            txt14CartonIDFromAddNewBatchID.Text = strCtnIdArr[0].ToString().Trim();
            txt15CartonIDToAddNewBatchID.Text = strCtnIdArr[1].ToString().Trim();
        }
        private void initTxtToModel(PIE.Model.plr_mstr plr_mstr_model)
        {
            //plr_mstr_model.plr_suppliers_id = txtplr_suppliers_id.Text.Trim();
            plr_mstr_model.plr_pallet_no = txt3PalletNoAddNewBatchID.Text.Trim();
            plr_mstr_model.InvoiceID = txt4InvoiceIDAddNewBatchID.Text.Trim();
            plr_mstr_model.plr_po = txt5POAddNewBatchID.Text.Trim();
            plr_mstr_model.packingListID = txt6PackingListIDAddNewBatchID.Text.Trim();

            plr_mstr_model.plr_partno = txt7PartAddNewBatchID.Text.Trim();
            plr_mstr_model.plr_carton_qty = Convert.ToDecimal(txt8CartonQtyAddNewBatchID.Text.Trim());
            plr_mstr_model.plr_qty = Convert.ToDecimal(txt9QTYAddNewBatchID.Text.Trim());
            plr_mstr_model.CartonID = txt10CartonIDAddNewBatchID.Text.Trim();
            plr_mstr_model.CartonType = txt11CartonTypeAddNewBatchID.Text.Trim();

            plr_mstr_model.plr_rcp_date = Convert.ToDateTime(dateTime1RecDateAddNewBatchID.Text);

            plr_mstr_model.plr_deli_date = Convert.ToDateTime(dateTime2DeliDateAddNewBatchID.Text);

            plr_mstr_model.carton_id_prifix = this.txt12CartonprifixAddNewBatchID.Text.Trim();
            plr_mstr_model.carton_id_from = Convert.ToDecimal(txt14CartonIDFromAddNewBatchID.Text.Trim());
            plr_mstr_model.carton_id_to = Convert.ToDecimal(txt15CartonIDToAddNewBatchID.Text.Trim());


            plr_mstr_model.re_mark = txt16RemarkAddNewBatchID.Text.Trim();

        }
        private void initModelForTextBox(PIE.Model.plr_mstr plr_mstr_model)
        {
            txt3PalletNoAddNewBatchID.Text = plr_mstr_model.plr_pallet_no;
            txt4InvoiceIDAddNewBatchID.Text = plr_mstr_model.InvoiceID;
            txt5POAddNewBatchID.Text = plr_mstr_model.plr_po;
            txt6PackingListIDAddNewBatchID.Text = plr_mstr_model.packingListID;

            txt7PartAddNewBatchID.Text = plr_mstr_model.plr_partno;
            txt8CartonQtyAddNewBatchID.Text = plr_mstr_model.plr_carton_qty.ToString();
            txt9QTYAddNewBatchID.Text = plr_mstr_model.plr_qty.ToString();
            txt10CartonIDAddNewBatchID.Text = plr_mstr_model.CartonID;
            txt11CartonTypeAddNewBatchID.Text = plr_mstr_model.CartonType;

            dateTime1RecDateAddNewBatchID.Text = plr_mstr_model.plr_rcp_date.ToString();

            dateTime2DeliDateAddNewBatchID.Text = plr_mstr_model.plr_deli_date.ToString();

            this.txt12CartonprifixAddNewBatchID.Text = plr_mstr_model.carton_id_prifix;
            txt14CartonIDFromAddNewBatchID.Text = plr_mstr_model.carton_id_from.ToString();
            txt15CartonIDToAddNewBatchID.Text = plr_mstr_model.carton_id_to.ToString();

            plr_mstr_model.re_mark = txt16RemarkAddNewBatchID.Text.Trim();

            //initCartonFromTo();
        }


        private void btn1UpadeAddAddNewBatchID_Click(object sender, EventArgs e)
        {
            initCartonFromTo();
            if (!isnulltxt())
            {
                return;
            };
            #region update
            if (btn1UpadeAddAddNewBatchID.Text == "&Update")
            {

                plr_mstr_model = new PIE.DAL.plr_mstr().GetModel(txt1BatchIDAddNewBatchID.Text.Trim(), Convert.ToInt32(txt2LineIDAddNewBatchID.Text.Trim()));


                initTxtToModel(plr_mstr_model);


                plr_mstr_model.plr_update_date = DbHelperSQL.getServerGetDate();
                plr_mstr_model.plr_user_ip = _idr_show._custip;
                //plr_mstr_model.plr_status = "";

                var result_plr_mstr = new PIE.DAL.plr_mstr().Update(plr_mstr_model);

                if (result_plr_mstr)
                {

                    lblShowMsg("Update success", "Success");

                }
                else
                {
                    lblShowMsg("Update fail", "Error");
                }
            }
            #endregion
            #region add
            if (btn1UpadeAddAddNewBatchID.Text == "&Add")
            {
                string strBatchID = "";
                int intOutAffected;


                PIE.Model.plr_batch_mstr plr_bathmstr_model = new PIE.Model.plr_batch_mstr();

                plr_mstr_model = new PIE.Model.plr_mstr();

                initTxtToModel(plr_mstr_model);

                plr_mstr_model.plr_doc_type = "New";
                plr_mstr_model.plr_cre_date = DbHelperSQL.getServerGetDate();
                plr_mstr_model.plr_user_ip = _idr_show._custip;
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
                plr_bathmstr_model.plr_suppliers_id = txt13plr_suppliers_id.Text.Trim();
                plr_bathmstr_model.batch_doc = "New";
                plr_bathmstr_model.batch_dec01 = 1;
                plr_bathmstr_model.batch_cre_date = plr_mstr_model.plr_cre_date;
                plr_bathmstr_model.batch_update_date = plr_mstr_model.plr_cre_date;
                plr_bathmstr_model.batch_user_ip = _idr_show._custip;
                plr_bathmstr_model.batch_status = "No";
                plr_bathmstr_model.batch_void = 1;


                var result_plr_batch = new PIE.DAL.plr_batch_mstr().Add(plr_bathmstr_model);
                if (!result_plr_batch)
                {
                    lblShowMsg("Add Batch Mstr info fail", "Error");
                    return;
                }
                var result_plr_mstr = new PIE.DAL.plr_mstr().Add(plr_mstr_model);

                _idr_show._plr_batch_mstr_model = plr_bathmstr_model;

                //frm0BatchInfo fbi = new frm0BatchInfo(_idr_show);
                //_idr_show.addGBToTC(_idr_show.tabCtlRight1, fbi.groupBox0BatchInfo0);

                if (result_plr_mstr)
                {

                    _idr_show.addBatchInfotoTabCurr(plr_bathmstr_model);

                    Program.GenCartonNo(plr_mstr_model);
                    //MessageBox.Show("Add BatchID:" + strBatchID + " success,", "Success");

                    this.txt3PalletNoAddNewBatchID.Focus();


                    if (string.IsNullOrEmpty(plr_mstr_model.Batch_ID))
                    {

                        lblShowMsg("新增新的BatchID", "Notice");
                    }
                    else
                    {
                        PIE.Model.plr_mstr plr_mstr_new = new PIE.Model.plr_mstr();
                        initModelForTextBox(plr_mstr_new);
                        lblShowMsg("新增新的BatchID,\t上次新增的为：" + plr_mstr_model.Batch_ID, "Notice");
                    }

                }
                else
                {
                    lblShowMsg("Add fail", "Error");
                }
            }
            #endregion
        }

        private void AddNewBatchID_Load(object sender, EventArgs e)
        {

        }

        private void btn3NewAddNewBatchID_Click(object sender, EventArgs e)
        {
            List<PIE.Model.plr_batch_mstr> lis = new PIE.BLL.plr_batch_mstr().GetModelList("batch_id like '%7'");
            _idr_show.addBatchInfotoTabCurr(lis[0]);
        }

        private void btn5PoCheckAddNewBatchID_Click(object sender, EventArgs e)
        {

        }


    }
}
