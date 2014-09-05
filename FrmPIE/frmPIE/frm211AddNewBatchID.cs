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
    public partial class frm211AddNewBatchID : Form
    {
        frmIDR _idr_show;
        Commfunction cf;

        PIE.Model.plr_mstr _plr_mstr_model = new PIE.Model.plr_mstr();
        string _strbatch = "";
        string _lineid = "";
        bool _addNewFalg = false;
        bool _updateflag = false;
        int _nextlineid;
        int _currRowIndex = 0;
        int _currColIndex = 0;
        public frm211AddNewBatchID(frmIDR idr)
        {
            _idr_show = idr;
            cf = new Commfunction(idr);

            InitializeComponent();

            btn1UpadeAddAddNewBatchID.Focus();

            _idr_show.tabCtlRight1.SelectedTab.Resize += SelectedTab_Resize;
            _idr_show.tabCtlRight1.SelectedTab.Layout += _idr_show_Layout;
            data1GV1ePackingDet1_AddNewBatchID.RowEnter += data1GV1ePackingDet1UploadExcel_RowEnter;
            data1GV1ePackingDet1_AddNewBatchID.ContextMenuStrip = _idr_show.c11MenuStripVoid;
            data1GV1ePackingDet1_AddNewBatchID.CellContextMenuStripNeeded += data1GV1ePackingDet1_AddNewBatchID_CellContextMenuStripNeeded;
        }

        void data1GV1ePackingDet1_AddNewBatchID_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < data1GV1ePackingDet1_AddNewBatchID.RowCount - 1)
            {
                _strbatch = data1GV1ePackingDet1_AddNewBatchID.Rows[e.RowIndex].Cells["Batch_ID"].Value == DBNull.Value ? "" : data1GV1ePackingDet1_AddNewBatchID.Rows[e.RowIndex].Cells["Batch_ID"].Value.ToString();
                _idr_show._voidDGV = data1GV1ePackingDet1_AddNewBatchID;
                _idr_show._voideX = e.RowIndex;
                _idr_show._voideY = e.ColumnIndex;
                _idr_show._voidhasLineID = true;

            }

        }

        void data1GV1ePackingDet1UploadExcel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            DoWrokObject dwo = new DoWrokObject(data1GV1ePackingDet1_AddNewBatchID, 3, e.RowIndex, Color.Yellow, "CartonID", "plr_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }

        void _idr_show_Layout(object sender, LayoutEventArgs e)
        {
            txt3PalletNoAddNewBatchID.Focus();
            initWithHeight();
        }

        void SelectedTab_Resize(object sender, EventArgs e)
        {
            initWithHeight();
        }
        private void AddNewBatchID_Load(object sender, EventArgs e)
        {

            _idr_show._tInitGDV = new Thread(new ParameterizedThreadStart(initDGVDelegate));
        }

        private void initWithHeight()
        {
            groupBox0AddNewBatchID.Width = _idr_show.tabCtlRight1.SelectedTab.Width - groupBox0AddNewBatchID.Left - 10;

            groupBox1.Width = groupBox0AddNewBatchID.Width - groupBox1.Left - 5;
            groupBox2.Width = groupBox1.Width;
            groupBox3.Width = groupBox1.Width;
            groupBox3mstr_addnewbatch.Width = groupBox1.Width;
            groupBox4det_addnewbatch.Width = groupBox1.Width;


            groupBox4det_addnewbatch.Height = groupBox0AddNewBatchID.Height - groupBox4det_addnewbatch.Top;
        }
        private void groupBox0AddNewBatchID_Resize(object sender, EventArgs e)
        {
            initWithHeight();
        }
        private void ShowMsg(string msg, string title)
        {
            this.lblMsg.Visible = true;
            this.lblMsg.Text = title + ":" + msg;
        }
        private void ShowMsg(Control ct, string msg, string title)
        {
            ct.Visible = true;
            ct.Text = title + ":" + msg;
        }
        public bool isNumber(TextBox tb)
        {
            if (!PageValidate.IsNumber(tb.Text))
            {
                tb.Focus();
                tb.SelectAll();
                ShowMsg("请输入正确的数字，谢谢.", "Notice");

                return true;
            }
            return false;
        }
        public bool isnullempty(TextBox tb, string msg, string title)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                ShowMsg(msg, title);
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
                ShowMsg("Carton ID must like Numert or NumA-NumB,example C1-10 or 10 or 1-10.", "Error");
                txt10CartonIDAddNewBatchID.SelectAll();
                txt10CartonIDAddNewBatchID.Focus();
                return false;
            }
            var cartonfrom = Convert.ToInt32(txt14CartonIDFromAddNewBatchID.Text);
            var cartonto = Convert.ToInt32(txt15CartonIDToAddNewBatchID.Text);

            if (cartonfrom > cartonto)
            {
                ShowMsg("Carton ID must like 10 or 1-10", "Error");
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

            if (_addNewFalg)
            {
                plr_mstr_model.Batch_ID = txt1BatchIDAddNewBatchID.Text.Trim();

                plr_mstr_model.LineID = Convert.ToInt32(txt2LineIDAddNewBatchID.Text.Trim());
            }

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
            txt1BatchIDAddNewBatchID.Text = plr_mstr_model.Batch_ID;
            txt2LineIDAddNewBatchID.Text = plr_mstr_model.LineID.ToString();
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

            initCartonFromTo();
        }

        private void initDatasetToTxt(PIE.Model.plr_batch_mstr model, bool breadonly)
        {
            txtb1batch_id_AddNewBatchID.Text = model.batch_id;
            txtb2batch_do_AddNewBatchID.Text = model.batch_doc;
            txtb3batch_statu_AddNewBatchID.Text = model.batch_status;
            txtb4batch_dec01_AddNewBatchID.Text = model.batch_dec01.ToString();
            txtb5batch_cre_date_AddNewBatchID.Text = model.batch_cre_date.ToString();

            txtb1batch_id_AddNewBatchID.ReadOnly = breadonly;
            txtb2batch_do_AddNewBatchID.ReadOnly = breadonly;
            txtb3batch_statu_AddNewBatchID.ReadOnly = breadonly;
            txtb4batch_dec01_AddNewBatchID.ReadOnly = breadonly;
            txtb5batch_cre_date_AddNewBatchID.ReadOnly = breadonly;
        }
        private void initDGV(object strBatchID)
        {
            CartonFromTo ctft = new CartonFromTo(data1GV1ePackingDet1_AddNewBatchID, (string)strBatchID, 0, "add", _idr_show._custip, _idr_show._custip);
            var reobjmstr = cf.initDataGVPlrBatchMstr(ctft, false, "model");
            var reobjdet = cf.initDataGVplr_mstr(ctft, true, "nothing");
            if (reobjmstr != null)
            {
                _idr_show._plr_batch_mstr_model = (PIE.Model.plr_batch_mstr)reobjmstr;
                initDatasetToTxt(_idr_show._plr_batch_mstr_model, true);
            }
        }

        private void initDGVDelegate(object strBatchID)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(initDGV);
            _idr_show.BeginInvoke(me, strBatchID);
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
                string msg = txt1BatchIDAddNewBatchID.Text + "," + txt2LineIDAddNewBatchID.Text;
                _plr_mstr_model = new PIE.DAL.plr_mstr().GetModel(txt1BatchIDAddNewBatchID.Text.Trim(), Convert.ToInt32(txt2LineIDAddNewBatchID.Text.Trim()));

                if (_plr_mstr_model.plr_status.Equals("Yes"))
                {
                    ShowMsg(msg + " is void, Update fail", "Error");
                    return;
                }
                initTxtToModel(_plr_mstr_model);


                _plr_mstr_model.plr_update_date = DbHelperSQL.getServerGetDate();
                _plr_mstr_model.plr_user_ip = _idr_show._custip;
                //plr_mstr_model.plr_status = "";

                var result_plr_mstr = new PIE.DAL.plr_mstr().Update(_plr_mstr_model);

                if (result_plr_mstr)
                {
                    _updateflag = true;
                    threadinitDVdelegate();
                    ShowMsg("Update success", "Success");

                }
                else
                {
                    ShowMsg("Update fail", "Error");
                }
            }
            #endregion
            #region add
            if (btn1UpadeAddAddNewBatchID.Text == "&Add")
            {

                int intOutAffected;

                if (!_addNewFalg || _plr_mstr_model.LineID <= 0)
                {
                    #region add New BatchID

                    string strBatchID = "";
                    PIE.Model.plr_batch_mstr plr_bathmstr_model = new PIE.Model.plr_batch_mstr();
                    SqlParameter[] parameters = {
                                            new SqlParameter("@BatchID",SqlDbType.NVarChar,11)
                                        };
                    parameters[0].Direction = ParameterDirection.Output;

                    DbHelperSQL.RunProcedure("sp_GetBatchID", parameters, out intOutAffected);
                    strBatchID = parameters[0].Value != null ? parameters[0].Value.ToString() : "";
                    if (string.IsNullOrEmpty(strBatchID))
                    {
                        ShowMsg("生成BatchID,出错，无法新增。", "Error");
                        return;
                    }
                    plr_bathmstr_model.batch_id = strBatchID;
                    plr_bathmstr_model.plr_suppliers_id = txt13plr_suppliers_id.Text.Trim();
                    plr_bathmstr_model.batch_doc = "New";
                    plr_bathmstr_model.batch_dec01 = 1;
                    plr_bathmstr_model.batch_cre_date = DbHelperSQL.getServerGetDate();
                    plr_bathmstr_model.batch_update_date = plr_bathmstr_model.batch_cre_date;
                    plr_bathmstr_model.batch_user_ip = _idr_show._custip;
                    plr_bathmstr_model.batch_status = "No";
                    plr_bathmstr_model.batch_void = 1;

                    var result_plr_batch = new PIE.DAL.plr_batch_mstr().Add(plr_bathmstr_model);
                    if (!result_plr_batch)
                    {
                        ShowMsg("Add Batch Mstr info fail", "Error");
                        return;
                    }
                    _plr_mstr_model.Batch_ID = strBatchID;
                    _plr_mstr_model.LineID = 1;
                    #endregion

                    _idr_show._plr_batch_mstr_model = plr_bathmstr_model;
                }


                //plr_mstr_model = new PIE.Model.plr_mstr();


                initTxtToModel(_plr_mstr_model);

                _plr_mstr_model.plr_doc_type = "New";
                _plr_mstr_model.plr_cre_date = DbHelperSQL.getServerGetDate();
                _plr_mstr_model.plr_user_ip = _idr_show._custip;
                _plr_mstr_model.plr_status = "No";

                var existBatchidLine = true;
                while (existBatchidLine)
                {
                    existBatchidLine = new PIE.BLL.plr_mstr().Exists(_plr_mstr_model.Batch_ID, _plr_mstr_model.LineID);
                    if (existBatchidLine)
                    {
                        ShowMsg("系统中已存在BatchID：" + _plr_mstr_model.Batch_ID + ",LineID:" + _plr_mstr_model.LineID.ToString() + "，将修改LineID+1.", "Notice");

                        _plr_mstr_model.LineID += 1;
                        txt2LineIDAddNewBatchID.Text = _plr_mstr_model.LineID.ToString();
                    }


                }

                var result_plr_mstr = new PIE.DAL.plr_mstr().Add(_plr_mstr_model);

                if (result_plr_mstr)
                {
                    _strbatch = _plr_mstr_model.Batch_ID;

                    threadinitDVdelegate();

                    Program.GenCartonNo(_plr_mstr_model);
                    //MessageBox.Show("Add BatchID:" + strBatchID + " success,", "Success");

                    this.txt3PalletNoAddNewBatchID.Focus();


                    if (string.IsNullOrEmpty(_plr_mstr_model.Batch_ID))
                    {

                        ShowMsg("Add New BatchID", "Notice");
                    }
                    else
                    {
                        PIE.Model.plr_mstr plr_mstr_new = new PIE.Model.plr_mstr();
                        plr_mstr_new.Batch_ID = _plr_mstr_model.Batch_ID;
                        plr_mstr_new.LineID = _plr_mstr_model.LineID + 1;
                        _nextlineid = plr_mstr_new.LineID;

                        initModelForTextBox(plr_mstr_new);
                        _addNewFalg = true;
                        ShowMsg("Add the Same BatchID,\t上次新增的为：" + _plr_mstr_model.Batch_ID + ",LineID:" + _plr_mstr_model.LineID.ToString(), "Notice");
                    }

                }
                else
                {
                    ShowMsg("Add fail", "Error");
                }
            }
            #endregion
        }
        private void btn2GenCartonNo2AddNewBatchID_Click(object sender, EventArgs e)
        {
            if (txtb3batch_statu_AddNewBatchID.Text.Equals("Yes"))
            {

                ShowMsg("Error: All BatchID is void, Cant't Generate CartonNO.", "");
                return;
            }
            initCartonFromTo();
            if (!isnulltxt())
            {
                return;
            };
            btn2GenCartonNo2AddNewBatchID.Enabled = false;
            int intresult = Program.GenCartonNo(_plr_mstr_model);
            if (intresult == 0)
            {
                lbl0GenCenResult.Text = "Success:" + _plr_mstr_model.Batch_ID + "," + _plr_mstr_model.LineID + " Generate Wec CartonNo Success.";
            }
            else if (intresult == 1)
            {
                lbl0GenCenResult.Text = "Fail:" + _plr_mstr_model.Batch_ID + "," + _plr_mstr_model.LineID + " Generate Wec CartonNo Fail.";
            }
            else if (intresult == 3)
            {
                lbl0GenCenResult.Text = "Fail:" + _plr_mstr_model.Batch_ID + "," + _plr_mstr_model.LineID + " Generate Wec CartonNo has upload to ERP Success,can't reGenerate.";
            }
            btn2GenCartonNo2AddNewBatchID.Enabled = true;

        }
        private void threadinitDVdelegate()
        {
            _idr_show._tInitGDV = new Thread(initDGVDelegate);
            if (_idr_show._tInitGDV.ThreadState == ThreadState.Running)
            {
                _idr_show._tInitGDV.Abort();
            }

            if (_idr_show._tInitGDV.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tInitGDV.Start(_plr_mstr_model.Batch_ID);
            }
            if (_idr_show._tInitGDV.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tInitGDV = new Thread(initDGVDelegate);
                _idr_show._tInitGDV.Start(_plr_mstr_model.Batch_ID);
            }
        }

        private void btn3NewAddNewBatchID_Click(object sender, EventArgs e)
        {
            ShowMsg("新增新的BatchID,LineID 从1开始计算.", "Notice");
            btn1UpadeAddAddNewBatchID.Text = "&Add";
            _addNewFalg = false;
            _plr_mstr_model = new PIE.Model.plr_mstr();
            _plr_mstr_model.LineID = 1;
            initModelForTextBox(_plr_mstr_model);
            txt3PalletNoAddNewBatchID.Focus();
        }

        private void data1GV1ePackingDet1_AddNewBatchID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1ePackingDet1_AddNewBatchID, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo);

            if (e.RowIndex >= 0 && e.RowIndex < data1GV1ePackingDet1_AddNewBatchID.RowCount - 1)
            {
                _currRowIndex = e.RowIndex;
                _currColIndex = e.ColumnIndex;
                if (_idr_show._voidRefresh)
                {
                    _idr_show._voidRefresh = false;
                    init0Update(_strbatch);
                }
                var strvoid = data1GV1ePackingDet1_AddNewBatchID.Rows[e.RowIndex].Cells["plr_status"].Value == DBNull.Value ? "" : data1GV1ePackingDet1_AddNewBatchID.Rows[e.RowIndex].Cells["plr_status"].Value.ToString();
                _strbatch = data1GV1ePackingDet1_AddNewBatchID.Rows[e.RowIndex].Cells["Batch_ID"].Value == DBNull.Value ? "" : data1GV1ePackingDet1_AddNewBatchID.Rows[e.RowIndex].Cells["Batch_ID"].Value.ToString();
                _lineid = data1GV1ePackingDet1_AddNewBatchID.Rows[e.RowIndex].Cells["LineID"].Value == DBNull.Value ? "" : data1GV1ePackingDet1_AddNewBatchID.Rows[e.RowIndex].Cells["LineID"].Value.ToString();

                if (strvoid.Equals("Yes"))
                {
                    string msg = "BatchID:" + _strbatch + ", LineID:" + _lineid + " is Void.";
                    ShowMsg(msg, "Error: ");
                    _idr_show.status15toolLabelstrResult.Text = msg;
                    return;
                }
                init0Update(e.RowIndex);

            }


        }

        private void init0Update(int eIndex)
        {
            if (eIndex >= 0 && eIndex < data1GV1ePackingDet1_AddNewBatchID.Rows.Count - 1)
            {


                btn1UpadeAddAddNewBatchID.Text = "&Update";
                string strbatchid = data1GV1ePackingDet1_AddNewBatchID.Rows[eIndex].Cells["Batch_ID"].Value.ToString();
                int lineid = Convert.ToInt32(data1GV1ePackingDet1_AddNewBatchID.Rows[eIndex].Cells["LineID"].Value);

                _plr_mstr_model = new PIE.BLL.plr_mstr().GetModel(strbatchid, lineid);

                initModelForTextBox(_plr_mstr_model);
                //txt3PalletNoAddNewBatchID.Focus();
                ShowMsg("修改BatchID:" + strbatchid + "," + lineid + ".", "Notice");


            }
        }
        private void init0Update(string strbatchid)
        {

            PIE.Model.plr_batch_mstr plr_barch_mast_model = new PIE.BLL.plr_batch_mstr().GetModel(strbatchid);
            if (plr_barch_mast_model != null)
            {

                initDatasetToTxt(plr_barch_mast_model, true);


                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                strSql.Append("Batch_ID,LineID,plr_status,plr_pallet_no,InvoiceID,plr_po,packingListID,plr_partno,CartonType,");
                strSql.Append("CartonID,plr_carton_qty,plr_qty,plr_rcp_date,plr_deli_date,carton_id_prifix,carton_id_from,carton_id_to,");
                strSql.Append("re_mark,plr_site,plr_co,plr_date_code,plr_vend_mfgr,");
                strSql.Append("Plr_vm_partno,plr_doc_type,plr_ttl,plr_um,plr_nw,plr_gw,");
                strSql.Append("plr_msm,plr_cre_date,");
                strSql.Append("plr_update_date");
                strSql.Append(" FROM plr_mstr ");
                strSql.Append(" where ");
                strSql.Append("Batch_ID='" + strbatchid + "'");

                var _plr_mstr_model_ds = DbHelperSQL.Query(strSql.ToString());

                var dst = _plr_mstr_model_ds.Tables[0];

                _plr_mstr_model.Batch_ID = strbatchid;
                _nextlineid = cf.getMaxOrMinColumnFromDataTable(dst, "LineID", true) + 1;

                data1GV1ePackingDet1_AddNewBatchID.DataSource = dst.DefaultView;
                data1GV1ePackingDet1_AddNewBatchID.Refresh();

                data1GV1ePackingDet1_AddNewBatchID.Rows[_currRowIndex].Cells[0].Selected = true;
                init0Update(_currRowIndex);
            }
            else
            {
                lblPosition_AddNewBatchID.Text = "Error: BatchID " + strbatchid + " is not exist.";
            }


        }
        private void init0Update(int eIndex, bool updatetypeEindex)
        {
            if (updatetypeEindex)
            {
                btn1UpadeAddAddNewBatchID.Text = "&Update";
                //txt3PalletNoAddNewBatchID.Focus();
            }

        }
        private void btn2AddContinue_Click(object sender, EventArgs e)
        {
            if (txtb3batch_statu_AddNewBatchID.Text.Equals("Yes"))
            {

                ShowMsg("Error: All BatchID is void, Cant't Continue Add.", "");
                return;
            }
            if (_nextlineid > 1)
            {
                _addNewFalg = true;
                btn1UpadeAddAddNewBatchID.Text = "&Add";

                string nextBatchid = _plr_mstr_model.Batch_ID;
                _plr_mstr_model = new PIE.Model.plr_mstr();

                _plr_mstr_model.Batch_ID = nextBatchid;
                _plr_mstr_model.LineID = _nextlineid;

                initModelForTextBox(_plr_mstr_model);

                txt3PalletNoAddNewBatchID.Focus();

                ShowMsg("Notice: Add Continue,Batchid:" + nextBatchid, "");
            }
        }
        private void currRowCol(PIE.Model.plr_mstr currmodel, int initcurrindex, DataGridView dgv)
        {

            _currRowIndex = initcurrindex;
            dgv.Rows[_currRowIndex].Cells[_currColIndex].Selected = true;
            var msg = "\t当前 BatchID: " + currmodel.Batch_ID + " ,LineID: " + currmodel.LineID + ", 在第 " + (_currRowIndex + 1) + " 行," + (_currColIndex + 1) + " 列.";
            ShowMsg(lblPosition_AddNewBatchID, msg, "Notice");
            init0Update(_currColIndex, true);

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            var currindex = _currRowIndex + 1;
            var countrow = data1GV1ePackingDet1_AddNewBatchID.RowCount - 1;
            if (currindex >= 0 && currindex < countrow)
            {

                var plr_mstr_model_temp = new PIE.Model.plr_mstr();
                Commfunction.getBatchiLineId(data1GV1ePackingDet1_AddNewBatchID, currindex, plr_mstr_model_temp);
                plr_mstr_model_temp = new PIE.BLL.plr_mstr().GetModel(plr_mstr_model_temp.Batch_ID, plr_mstr_model_temp.LineID);
                initModelForTextBox(plr_mstr_model_temp);
                currRowCol(plr_mstr_model_temp, currindex, data1GV1ePackingDet1_AddNewBatchID);
            }


        }


        private void btnPre_Click(object sender, EventArgs e)
        {
            var currindex = _currRowIndex - 1;
            var countrow = data1GV1ePackingDet1_AddNewBatchID.RowCount - 1;
            if (currindex >= 0 && currindex < countrow)
            {
                var plr_mstr_model_temp = new PIE.Model.plr_mstr();
                Commfunction.getBatchiLineId(data1GV1ePackingDet1_AddNewBatchID, currindex, plr_mstr_model_temp);
                plr_mstr_model_temp = new PIE.BLL.plr_mstr().GetModel(plr_mstr_model_temp.Batch_ID, plr_mstr_model_temp.LineID);
                initModelForTextBox(plr_mstr_model_temp);
                currRowCol(plr_mstr_model_temp, currindex, data1GV1ePackingDet1_AddNewBatchID);
            }
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            var countrow = data1GV1ePackingDet1_AddNewBatchID.RowCount - 1;

            if (!isNumber(txtGorow))
            {
                var currindex = Convert.ToInt32(txtGorow.Text) - 1;
                if (currindex >= 0 && currindex < countrow)
                {
                    var plr_mstr_model_temp = new PIE.Model.plr_mstr();
                    Commfunction.getBatchiLineId(data1GV1ePackingDet1_AddNewBatchID, currindex, plr_mstr_model_temp);
                    plr_mstr_model_temp = new PIE.BLL.plr_mstr().GetModel(plr_mstr_model_temp.Batch_ID, plr_mstr_model_temp.LineID);
                    initModelForTextBox(plr_mstr_model_temp);
                    currRowCol(plr_mstr_model_temp, currindex, data1GV1ePackingDet1_AddNewBatchID);
                }
                else
                {
                    txtGorow.Focus();
                    txtGorow.Text = countrow.ToString();
                    lblPosition_AddNewBatchID.Text = "more then " + countrow;
                }
            }
            else
            {
                txtGorow.Focus();
                txtGorow.Text = countrow.ToString();
                ShowMsg(lblPosition_AddNewBatchID, "请输入正确的数据字", "Error");
            }
        }

        private void btn8Search_Click(object sender, EventArgs e)
        {
            _strbatch = txt88Batchid.Text;
            if (!string.IsNullOrEmpty(_strbatch))
            {
                init0Update(_strbatch);
            }
        }

        private void data1GV1ePackingDet1_AddNewBatchID_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_idr_show._voidRefresh)
            {
                _idr_show._voidRefresh = false;
                init0Update(_strbatch);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg;
            if (!string.IsNullOrEmpty(txtb3batch_statu_AddNewBatchID.Text))
            {
                if (txtb3batch_statu_AddNewBatchID.Text.Equals("Yes"))
                {
                    msg = txtb1batch_id_AddNewBatchID.Text + " has being void.";
                    ShowMsg(msg, "Error");
                    return;
                }
                else
                {
                    _strbatch = txtb1batch_id_AddNewBatchID.Text;
                    DoWrokObject dwo = new DoWrokObject(data1GV1ePackingDet1_AddNewBatchID, 0, 0, false, "plr_status");
                    cf.initVoid(dwo);
                    init0Update(_strbatch);
                }
            }
        }







    }
}
