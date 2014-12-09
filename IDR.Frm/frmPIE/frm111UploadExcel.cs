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
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data.SqlClient;

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
        public DataSet data0set_npoi { get; set; }
        //model
        public plr_batch_mstr _plr_batch_mstr_model { get; set; }
        //param
        public string _strBatchID;

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
            cf.setControlText(lbl1UploadExcelThreadMsg, "Notiec: Load Excel File ......", true, true);
            cf.setControlText(_frmDefault.status15toolLabelstrResult, "Notiec: Load Excel File ......", true, true);

            if (txt0ExcelFileUploadExcel.Text.Trim() == "")
            {
                cf.setControlText(lbl1UploadExcelThreadMsg, "Error,没选择Excel， 不能完成上传操作,请选择正确的文件，谢谢！", true, true);
                btnSelectfileUploadExcel.Focus();
            }
            else
            {
                oldtime = DateTime.Now;
                //Init0ializeWorkbookdelegate(txt0ExcelFileUploadExcel.Text);
                Init0ializeWorkbook(txt0ExcelFileUploadExcel.Text);
            }
        }


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
                    throw new Exception("Error0: this file is not the xls or xlsx file.0");
                }
            }

            var strmsg = Convert0ToDataTable();

            data1GV1ePackingDet1UploadExcel.DataSource = _dbpie.plr_mstr.Local.Where(m => m.Batch_ID.Equals(_strBatchID)).ToList();
            data1GV1ePackingDet1UploadExcel.Refresh();

            var currtime = DateTime.Now - oldtime;
            string difftime = "\tUse Time: " + currtime.Minutes + " Minutes " + currtime.Seconds + " Secconds " + currtime.Milliseconds + " Milliseconds";
            cf.setControlText(lbl1UploadExcelThreadMsg, strmsg + difftime, true, true);
        }


        string Convert0ToDataTable()
        {
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

            if (!getNewBatchID(ref _strBatchID))
            {
                return "Error: BatchID is Error.";
            };

            //for (int j = 0; j < 13; j++)
            //{
            //    dt.Columns.Add(Convert.ToChar(((int)'A') + j).ToString());
            //}
            int rowscount = 0;
            int rowserrscount = 0;
            int rowscountsum = sheet.LastRowNum;
            bool nextrow = true;
            string strerrnullrows = "At ";

            var servedate = _frmDefault.getServerGetDate();


            while (rows.MoveNext())
            {
                if (rowscount == 0)
                {
                    //command.UpdateCommand = cmdb.GetUpdateCommand();
                    rowscount = 1;
                    continue;
                }
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
                    throw new Exception("Error1: this file is not the xls or xlsx file .");
                }
                var tmp_plr_batch_mstr_model = new plr_mstr();

                tmp_plr_batch_mstr_model.Batch_ID = _strBatchID;
                tmp_plr_batch_mstr_model.LineID = rowscount;
                tmp_plr_batch_mstr_model.plr_status = "No";
                tmp_plr_batch_mstr_model.plr_doc_type = "e-Packing";
                tmp_plr_batch_mstr_model.plr_rcp_date = servedate;
                tmp_plr_batch_mstr_model.plr_deli_date = servedate;
                tmp_plr_batch_mstr_model.plr_cre_date = servedate; // DateTime.FromOADate(double型)    如果excel为日期时
                tmp_plr_batch_mstr_model.plr_update_date = servedate;
                tmp_plr_batch_mstr_model.plr_user_ip = _frmDefault._clientIP;

                cf.setControlText(_frmDefault.status15toolLabelstrResult, "Load Rows at:" + rowscount, true, true);
                for (int i = 0; i < 13; i++)
                {

                    ICell cell = row.GetCell(i);

                    if (cell == null || string.IsNullOrEmpty(cell.ToString()))
                    {
                        if (rowserrscount == 0)
                        {

                            strerrnullrows += rowscount.ToString();
                        }
                        else
                        {
                            strerrnullrows += "," + rowscount.ToString();

                        }
                        rowserrscount++;
                        nextrow = false;
                        break;
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
                        #region inittmp
                        if (i == 0)
                        {
                            tmp_plr_batch_mstr_model.packingListID = tmpValue.ToString();
                        }
                        else if (i == 1)
                        {
                            tmp_plr_batch_mstr_model.InvoiceID = tmpValue.ToString();
                        }
                        else if (i == 2)
                        {
                            tmp_plr_batch_mstr_model.plr_pallet_no = tmpValue.ToString();
                        }
                        else if (i == 3)
                        {
                            tmp_plr_batch_mstr_model.CartonType = tmpValue.ToString();
                        }
                        else if (i == 4)
                        {
                            tmp_plr_batch_mstr_model.CartonID = tmpValue.ToString();
                        }
                        else if (i == 5)
                        {
                            tmp_plr_batch_mstr_model.plr_po = tmpValue.ToString();
                        }
                        else if (i == 6)
                        {
                            tmp_plr_batch_mstr_model.plr_co = tmpValue.ToString();
                        }
                        else if (i == 7)
                        {
                            tmp_plr_batch_mstr_model.plr_partno = tmpValue.ToString();
                        }
                        else if (i == 8)
                        {
                            tmp_plr_batch_mstr_model.plr_date_code = tmpValue.ToString();
                        }
                        else if (i == 9)
                        {
                            tmp_plr_batch_mstr_model.plr_vend_mfgr = tmpValue.ToString();
                        }
                        else if (i == 10)
                        {
                            tmp_plr_batch_mstr_model.Plr_vm_partno = tmpValue.ToString();
                        }
                        else if (i == 11)
                        {
                            tmp_plr_batch_mstr_model.plr_carton_qty = Convert.ToDecimal(tmpValue);
                        }
                        else if (i == 12)
                        {
                            tmp_plr_batch_mstr_model.plr_qty = Convert.ToInt32(tmpValue);
                        }
                        #endregion

                    }
                    nextrow = true;

                }
                if (nextrow)
                {

                    rowscount++;
                    tmp_plr_batch_mstr_model.CartonType = "0";
                }
                _dbpie.plr_mstr.Add(tmp_plr_batch_mstr_model);
            }
            _plr_batch_mstr_model = _dbpie.plr_batch_mstr.Find(_strBatchID);
            _plr_batch_mstr_model.batch_dec01 = (rowscount - 1);
            var updatebathccount = _dbpie.SaveChanges();
            if (updatebathccount > 0)
            {
                _frmDefault._plr_batch_mstr_model = _plr_batch_mstr_model;
                initDatasetToTxt(_frmDefault._plr_batch_mstr_model, true);
            }
            return "Notice: Total: " + rowscountsum + " ,Update " + (rowscount - 1) + " Rows Success, Error: has " + rowserrscount + " Rows has null cell (" + strerrnullrows + ").";

        }

        private bool getNewBatchID(ref string _strBatchID)
        {
            SqlParameter[] parameters = {
                                            new SqlParameter("@BatchID",SqlDbType.NVarChar,20)
                                        };
            parameters[0].Direction = ParameterDirection.Output;

            _dbpie.Database.SqlQuery<object>("exec sp_GetBatchID @BatchID output", parameters[0]).SingleOrDefault();
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
        }
    }
}
