using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MessageBox = System.Windows.Forms.MessageBox;

using System.Data.Entity;
using IDR.Common;
using IDR.Common.DEncrypt;
using IDR.Frm.API;

using IDR.EF.PIE;
using IDR.EF.PIRemote;

using IDR.Frm.Logon;
using IDR.Frm.Properties;

using System.IO;
using System.Data.SqlClient;
using System.Threading;

using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace IDR.Frm.frmPIE
{
    public partial class frm111UploadExcel : Form
    {
        //attribute
        public DateTime oldtime { get; set; }
        public string _strext { get; set; }
        //for excel
        public ISheet sheet { get; set; }
        public IRow row { get; set; }
        public IList<plr_mstr> _plr_mstr_list_success { get; set; }
        //model
        public plr_batch_mstr _plr_batch_mstr_model { get; set; }
        //param
        public string _strBatchID;
        public bool _cellNullFlag { get; set; }

        //commonfunction
        CommonAPI cf;
        PIE _dbpie;

        ////frm win
        Default _frmDefault;

        public frm111UploadExcel()
        {
            InitializeComponent();
            /////////////
            initFrm();
        }
        public frm111UploadExcel(Default frmDefault)
        {
            InitializeComponent();
            //////////////
            initForDefault(frmDefault);
            //initfrm
            initFrm(frmDefault._dbpie);
        }
        #region init
        void initPara()
        {
            //function,db
            _dbpie = new PIE();
            cf = new CommonAPI(_frmDefault);
            //attribute
            _plr_batch_mstr_model = new plr_batch_mstr();
            _strBatchID = "";
            _strext = "";
            _cellNullFlag = false;
        }
        void initFrm()
        {
            this.FormClosing += Default_FormClosing;
            //init width
            this.gb0frmUploadExcel.Resize += gb0frmUploadExcel_Resize;
            //initpara
            initPara();
        }
        void initFrm(PIE dbpie)
        {
            initFrm();
            _dbpie = dbpie;
        }
        void initForDefault(Default frmDefault)
        {
            _frmDefault = frmDefault;
            _frmDefault.AcceptButton = btnSelectfileUploadExcel;
            _frmDefault.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;
        }
        private void initwidth()
        {
            groupBox2mstrUploadExcel.Width = gb0frmUploadExcel.Width - groupBox2mstrUploadExcel.Left - 5;
            groupBox3detUploadExcel.Width = groupBox2mstrUploadExcel.Width;

            groupBox3detUploadExcel.Height = gb0frmUploadExcel.Height - groupBox3detUploadExcel.Top - 10;

        }
        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            //btnSelectfileUploadExcel.Focus();
        }
        void gb0frmUploadExcel_Resize(object sender, EventArgs e)
        {
            initwidth();
        }
        void Default_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dbpie != null)
            {
                _dbpie.Dispose();
            }
        }
        #endregion


        private void btnSelectfileUploadExcel_Click(object sender, EventArgs e)
        {
            txt0ExcelFileUploadExcel.Text = "";
            btnSelectfileUploadExcel.Enabled = false;
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txt0ExcelFileUploadExcel.Text = ofd.FileName;
                    btn3QuickUploadExcel.Enabled = true;
                    _frmDefault.AcceptButton = btn3QuickUploadExcel;
                }
                else
                {
                    _frmDefault.AcceptButton = btnSelectfileUploadExcel;

                }
                btnSelectfileUploadExcel.Enabled = true;
            }
            catch (Exception ex)
            {
                btnSelectfileUploadExcel.Enabled = true;
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn3QuickUploadExcel_Click(object sender, EventArgs e)
        {
            btnEnable(false, true);
            cf.setControlText(lbl1UploadExcelThreadMsg, "Notiec: Load Excel File ......", true, true);
            cf.setControlText(_frmDefault.status15toolLabelstrResult, "Notiec: Load Excel File ......", true, true);

            if (txt0ExcelFileUploadExcel.Text.Trim() == "")
            {
                cf.setControlText(lbl1UploadExcelThreadMsg, "Error,没选择Excel， 不能完成上传操作,请选择正确的文件，谢谢！", true, true);
                btnEnable(true, true);
            }
            else
            {
                oldtime = DateTime.Now;
                //Init0ializeWorkbook(txt0ExcelFileUploadExcel.Text);
                ThreadPool.QueueUserWorkItem(new WaitCallback(Init0ializeWorkbook), txt0ExcelFileUploadExcel.Text);
            }
        }

        #region init excel for xls xlsx

        void Init0ializeWorkbook(object path)
        {
            //read xls
            using (FileStream file = new FileStream((string)path, FileMode.Open, FileAccess.Read))
            {
                if (Path.GetExtension((string)path).ToLower().Equals(".xls"))
                {
                    _strext = ".xls";
                    _frmDefault._hssfworkbook = new HSSFWorkbook(file);
                    sheet = _frmDefault._hssfworkbook.GetSheetAt(0);
                }
                else if (Path.GetExtension((string)path).ToLower().Equals(".xlsx"))
                {
                    _strext = ".xlsx";
                    _frmDefault._xssfworkbook = new XSSFWorkbook(file);
                    sheet = _frmDefault._xssfworkbook.GetSheetAt(0);
                }
                else
                {
                    btnEnable(true, true);
                    throw new Exception("Error0: this file is not the xls or xlsx file.0");
                }
            }

            var strmsg = Convert0ToDataTable();

            cf.setControlText(lbl1UploadExcelThreadMsg, "Start: Load Data to DataGridView.", true, true);
            _frmDefault.Invoke(new Action(delegate()
            {
                _plr_mstr_list_success = _dbpie.plr_mstr.Local.Where(m => m.Batch_ID.Equals(_strBatchID)).ToList();
                data1GV1ePackingDet1UploadExcel.DataSource = _plr_mstr_list_success;
                data1GV1ePackingDet1UploadExcel.Refresh();
            }));
            ///gen carton ID
            ///
            cf.setControlText(lbl1UploadExcelThreadMsg, "Start: Generate Carton No and Wec Ctn.", true, true);
            if (_plr_mstr_list_success.Count > 0)
            {

                ThreadPool.QueueUserWorkItem(new WaitCallback(doGenCarton), strmsg);
            }
        }
        void doGenCarton(object o)
        {
            int countsuccess = 0;
            int counterror = 0;
            string batchid = "";
            int rowCount = _plr_mstr_list_success.Count;
            foreach (var dr in _plr_mstr_list_success)
            {
                var currmsg = "Total:" + rowCount + ",Start Generate Carton ID For BatchID: " + dr.Batch_ID + ",LineID:" + dr.LineID;
                cf.setControlText(lbl1UploadExcelThreadMsg, currmsg, true, true);
                cf.setControlText(_frmDefault.status15toolLabelstrResult, currmsg, true, true);
                int intresutl = cf.GenCartonNo(dr);
                batchid = dr.Batch_ID;
                ///0: success 1:error 3:has upload to erp;
                if (intresutl == 1)
                {
                    counterror++;
                }
                else
                {
                    countsuccess++;
                }
            }
            var msgCarton = "\nGenerate Carton ID For BatchID " + batchid + " Success.";
            var currtime = DateTime.Now - oldtime;
            string difftime = "\t\tUse Time: " + currtime.Minutes + " Minutes " + currtime.Seconds + " Secconds " + currtime.Milliseconds + " Milliseconds";
            btnEnable(true, true);
            cf.setControlText(lbl1UploadExcelThreadMsg, "\t" + o.ToString() + msgCarton + difftime, true, true);
        }
        void btnEnable(bool enable, bool visual)
        {
            if (enable)
            {
                cf.setControlText(txt0ExcelFileUploadExcel, "", enable, true);
            }
            cf.setControlText(btnSelectfileUploadExcel, enable, visual);
            cf.setControlText(btn3QuickUploadExcel, enable, visual);
        }

        string Convert0ToDataTable()
        {
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

            if (!getNewBatchID(ref _strBatchID))
            {
                return "Error: BatchID is Error.";
            };

            int rows_success_count = 0;
            int rows_errs_count = 0;
            int rows_current = 0;
            int rows_countsum = sheet.LastRowNum;

            string strerrnullrows = "At ";

            var servedate = _frmDefault.getServerGetDate();


            while (rows.MoveNext())
            {
                if (rows_success_count == 0)
                {
                    //command.UpdateCommand = cmdb.GetUpdateCommand();
                    rows_success_count = 1;
                    continue;
                }
                //
                rows_current++;

                if (_strext.Equals(".xls"))
                {
                    row = (HSSFRow)rows.Current;
                }
                else if (_strext.Equals(".xlsx"))
                {
                    row = (XSSFRow)rows.Current;
                }
                else
                {
                    return "Error1: this file is not the xls or xlsx file .";
                }
                ///////////
                var tmp_plr_batch_mstr_model = new plr_mstr();

                tmp_plr_batch_mstr_model.Batch_ID = _strBatchID;
                tmp_plr_batch_mstr_model.LineID = rows_success_count;
                tmp_plr_batch_mstr_model.plr_status = "No";
                tmp_plr_batch_mstr_model.plr_doc_type = "e-Packing";
                tmp_plr_batch_mstr_model.plr_rcp_date = servedate;
                tmp_plr_batch_mstr_model.plr_deli_date = servedate;
                tmp_plr_batch_mstr_model.plr_cre_date = servedate; // DateTime.FromOADate(double型)    如果excel为日期时
                tmp_plr_batch_mstr_model.plr_update_date = servedate;
                tmp_plr_batch_mstr_model.plr_user_ip = _frmDefault._clientIP;

                cf.setControlText(lbl1UploadExcelThreadMsg, "Total: " + rows_countsum + ",Load Current Rows at:" + rows_current, true, true);
                cf.setControlText(_frmDefault.status15toolLabelstrResult, "Total: " + rows_countsum + ",Load Current Rows at:" + rows_current, true, true);

                #region inittmp
                tmp_plr_batch_mstr_model.packingListID = addCelltoData(row, 0) == null ? "" : addCelltoData(row, 0).ToString();
                tmp_plr_batch_mstr_model.InvoiceID = addCelltoData(row, 1) == null ? "" : addCelltoData(row, 1).ToString();
                tmp_plr_batch_mstr_model.plr_pallet_no = addCelltoData(row, 2) == null ? "" : addCelltoData(row, 2).ToString();
                tmp_plr_batch_mstr_model.CartonType = "0";// addCelltoData(row, 3).ToString();
                tmp_plr_batch_mstr_model.CartonID = addCelltoData(row, 4) == null ? "" : addCelltoData(row, 4).ToString();
                tmp_plr_batch_mstr_model.plr_po = addCelltoData(row, 5) == null ? "" : addCelltoData(row, 5).ToString();
                tmp_plr_batch_mstr_model.plr_co = addCelltoData(row, 6) == null ? "" : addCelltoData(row, 6).ToString();
                tmp_plr_batch_mstr_model.plr_partno = addCelltoData(row, 7) == null ? "" : addCelltoData(row, 7).ToString();
                tmp_plr_batch_mstr_model.plr_date_code = addCelltoData(row, 8) == null ? "" : addCelltoData(row, 8).ToString();
                tmp_plr_batch_mstr_model.plr_vend_mfgr = addCelltoData(row, 9) == null ? "" : addCelltoData(row, 9).ToString();
                tmp_plr_batch_mstr_model.Plr_vm_partno = addCelltoData(row, 10) == null ? "" : addCelltoData(row, 10).ToString();
                tmp_plr_batch_mstr_model.plr_carton_qty = addCelltoData(row, 11) == null ? 0 : Convert.ToDecimal(addCelltoData(row, 11).ToString());
                tmp_plr_batch_mstr_model.plr_qty = addCelltoData(row, 12) == null ? 0 : Convert.ToInt32(addCelltoData(row, 12).ToString());

                if (_cellNullFlag)
                {
                    _cellNullFlag = false;
                    rows_errs_count++;
                    strerrnullrows += rows_current - 1 + ",";
                    continue;

                }
                #endregion

                rows_success_count++;

                _dbpie.plr_mstr.Add(tmp_plr_batch_mstr_model);
            }
            //update batch_mstr count
            _plr_batch_mstr_model = _dbpie.plr_batch_mstr.Find(_strBatchID);
            _plr_batch_mstr_model.batch_dec01 = (rows_success_count - 1);

            //add and update

            cf.setControlText(lbl1UploadExcelThreadMsg, "Start: Save Data to DB System.", true, true);
            var updatebathccount = _dbpie.SaveChanges();

            if (updatebathccount > 0)
            {
                _frmDefault._plr_batch_mstr_model = _plr_batch_mstr_model;

                initDatasetToTxt(_frmDefault._plr_batch_mstr_model, true);
            }
            else
            {
                return "System Error,Please try Again.Thank you!";
            }
            return "Notice: Total: " + rows_countsum + " ,Update " + (rows_success_count - 1) + " Rows Success, Error:" + rows_errs_count + " Rows has null cell(" + strerrnullrows + ").";

        }
        public object addCelltoData(IRow row, int i)
        {
            if (_cellNullFlag)
            {
                return null;
            }
            ICell cell = row.GetCell(i);
            if (cell == null || string.IsNullOrEmpty(cell.ToString()))
            {
                _cellNullFlag = true;
                return null;
            }
            else
            {
                var tmpValue = new object();

                if (cell.CellType == CellType.Numeric)
                {
                    tmpValue = cell.NumericCellValue;
                }
                else if (cell.CellType == CellType.String)
                {

                    tmpValue = cell.ToString().Trim();
                }
                else
                {
                    tmpValue = cell.ToString();
                }
                return tmpValue;
            }
        }
        private bool getNewBatchID(ref string _strBatchID)
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@BatchID",SqlDbType.NVarChar,20)
                                        };
            parameters[0].Direction = ParameterDirection.Output;

            _dbpie.Database.SqlQuery<object>("exec sp_GetBatchID @BatchID output", parameters).SingleOrDefault();
            _strBatchID = parameters[0].Value != null ? parameters[0].Value.ToString() : "";

            if (string.IsNullOrEmpty(_strBatchID))
            {
                return false;
            }
            //batch master
            if (!insertNewplr_batch_mstr())
            {
                return false;
            }
            return true;
            //throw new NotImplementedException();
        }

        bool insertNewplr_batch_mstr()
        {
            //batch master
            _plr_batch_mstr_model = new plr_batch_mstr();
            _plr_batch_mstr_model.batch_id = _strBatchID;
            //_plr_batch_mstr_model.plr_suppliers_id = "";
            _plr_batch_mstr_model.batch_doc = "e-Packing";
            //plr_batch_mstr_model.batch_dec01 = row - 1;
            //_plr_batch_mstr_model.batch_void = 0;
            _plr_batch_mstr_model.batch_status = "No";
            _plr_batch_mstr_model.batch_cre_date = _frmDefault.getServerGetDate();
            _plr_batch_mstr_model.batch_update_date = _plr_batch_mstr_model.batch_cre_date;
            _plr_batch_mstr_model.batch_cre_date = _plr_batch_mstr_model.batch_cre_date;

            _plr_batch_mstr_model.batch_user_ip = _frmDefault._clientIP;

            _dbpie.plr_batch_mstr.Add(_plr_batch_mstr_model);
            var result_batch = _dbpie.SaveChanges();
            if (result_batch <= 0)
            {
                //MessageBox.Show("生成批号出错，请重新导入。谢谢", "Error");
                cf.setControlText(lbl1UploadExcelThreadMsg, "$UploadExcel: Error,生成批号出错，请重新导入。", true, true);
                //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: Error,生成批号出错，请重新导入。";
                return false;
            }
            _frmDefault._plr_batch_mstr_model = _plr_batch_mstr_model;
            initDatasetToTxt(_frmDefault._plr_batch_mstr_model, true);
            return true;
        }

        private void initDatasetToTxt(plr_batch_mstr model, bool breadonly)
        {
            _frmDefault.Invoke(new Action(delegate()
           {
               txt1batch_idUploadExcel.Text = model.batch_id;
               txt2batch_docUploadExcel.Text = model.batch_doc;
               txt3batch_statusUploadExcel.Text = model.batch_status;
               txt4batch_dec01UploadExcel.Text = model.batch_dec01.ToString();
               txt5batch_cre_dateUploadExcel.Text = model.batch_cre_date.ToString();

               txt1batch_idUploadExcel.ReadOnly = breadonly;
               txt2batch_docUploadExcel.ReadOnly = breadonly;
               txt3batch_statusUploadExcel.ReadOnly = breadonly;
               txt4batch_dec01UploadExcel.ReadOnly = breadonly;
               txt5batch_cre_dateUploadExcel.ReadOnly = breadonly;
               //throw new NotImplementedException();
           }));
        }

        #endregion
        //////////////
    }
}
