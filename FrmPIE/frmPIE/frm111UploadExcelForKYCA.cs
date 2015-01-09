﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FrmIDR._0API;
using PIE.DBUtility;
using System.Data.SqlClient;
using Excel;

//xls
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

//xlsx
using NPOI.XSSF.UserModel;




namespace FrmPIE
{
    public partial class frm111UploadExcelForKYCA : Form
    {
        frmEnterTxt _frmET;

        frmIDR _idr_show;
        Commfunction cf;
        SqlConnection connection;
        StringBuilder strsql;
        ISheet sheet;
        IRow row;
        System.Data.DataTable _dterr;

        bool _hasrun = false;
        bool _addHeadForDownExcel = false;
        bool _numCellVal = false;

        string _strBatchID = "";
        string _strext;
        string _strprefix = "";

        DateTime oldtime;

        string[] _cartonid;
        string strCartonID;
        int addrowscount = 0;

        System.Data.DataTable _dt_downToExela = new System.Data.DataTable();

        PIE.Model.plr_batch_mstr _plr_batch_mstr_model = new PIE.Model.plr_batch_mstr();
        public frm111UploadExcelForKYCA(frmIDR idr)
        {
            InitializeComponent();

            _idr_show = idr;
            _idr_show.tabCtlRight1.SelectedTab.Layout += SelectedTab_Layout;



            initwidthUploadExcel();

            cf = new Commfunction(idr);

            data1GV1ePackingDet1UploadExcel.ReadOnly = true;

            data1GV1ePackingDet1UploadExcel.CellClick += data1GV1ePackingDet1UploadExcel_CellClick;
            data1GV1ePackingDet1UploadExcel.RowEnter += data1GV1ePackingDet1UploadExcel_RowEnter;

        }
        void tableColumnsAdd(System.Data.DataTable dt, string strcolnumname)
        {
            dt.Columns.Add(strcolnumname);
        }
        public void addRowsToDownExcel(System.Data.DataTable dt, DataRow dr, string strflag, IRow row)
        {
            dr[0] = strflag;
            for (int i = 0; i < row.LastCellNum; i++)
            {
                try
                {
                    dr[i + 1] = row.GetCell(i);
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            dt.Rows.Add(dr);
        }
        void SelectedTab_Layout(object sender, LayoutEventArgs e)
        {
            //txt0ExcelFileUploadExcel.Focus();
            btnSelectfileUploadExcel.Focus();
            //_idr_show.AcceptButton = btnCmdUpdUploadExcel;
        }
        //xls
        DataSet data0set_npoi;
        SqlDataAdapter command;
        SqlCommandBuilder cmdb;
        void getDataGV()
        {
            connection = new SqlConnection(PubConstant.ConnectionString);

            string strwhere = " Batch_ID='xlgwr' ";
            strsql = new StringBuilder();
            strsql.Append("select ");
            strsql.Append(" Batch_ID,LineID,plr_status, ");
            strsql.Append(" packingListID,InvoiceID, ");

            strsql.Append(" Plr_vm_partno,plr_co,CartonID,plr_pallet_no, ");
            strsql.Append(" plr_partno,plr_qty,plr_vend_mfgr,plr_po, ");

            strsql.Append(" plr_carton_qty, ");
            strsql.Append(" CartonType,plr_date_code,carton_id_prifix, ");

            strsql.Append(" plr_doc_type,plr_rcp_date,plr_deli_date,plr_cre_date,plr_update_date,plr_user_ip ");
            strsql.Append(" from plr_mstr ");
            strsql.Append(" where ");
            strsql.Append(strwhere);
            data0set_npoi = new DataSet();
            try
            {
                connection.Open();
                command = new SqlDataAdapter(strsql.ToString(), connection);
                command.Fill(data0set_npoi);
                data0set_npoi.Tables[0].PrimaryKey = new DataColumn[] { data0set_npoi.Tables[0].Columns[0], data0set_npoi.Tables[0].Columns[1] };

                data1GV1ePackingDet1UploadExcel.DataSource = data0set_npoi.Tables[0].DefaultView;
                data1GV1ePackingDet1UploadExcel.Refresh();

                _dterr = new System.Data.DataTable();
                _dterr.Columns.Add("rowsNum", typeof(int));
                _dterr.Columns.Add("plr_partno");
                _dterr.Columns.Add("plr_qty", typeof(decimal));
                _dterr.Columns.Add("errorMsg");
                data2GV2ePackingDet1UploadExcelError.DataSource = _dterr.DefaultView;
                data2GV2ePackingDet1UploadExcelError.Refresh();
                data2GV2ePackingDet1UploadExcelError.Columns["rowsNum"].HeaderText = "At Excel Rows Num";
                data2GV2ePackingDet1UploadExcelError.Columns["plr_partno"].HeaderText = "Part";
                data2GV2ePackingDet1UploadExcelError.Columns["plr_qty"].HeaderText = "Total/Qty";
                data2GV2ePackingDet1UploadExcelError.Columns["errorMsg"].HeaderText = "Error Message";
                data0set_npoi.AcceptChanges();

                cf.initHeaderTextPlrMstr2ExcelUpload(data1GV1ePackingDet1UploadExcel);

                cmdb = new SqlCommandBuilder(command);

                //command.InsertCommand = cmdb.GetInsertCommand();
                //command.UpdateCommand = cmdb.GetUpdateCommand();
                //command.DeleteCommand = cmdb.GetDeleteCommand();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw new Exception(ex.Message);
            }


        }
        void data1GV1ePackingDet1UploadExcel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1ePackingDet1UploadExcel, 3, e.RowIndex, Color.Yellow, "CartonID", "plr_status", "Yes", Color.LightGray);
            cf.initThreadDowrokColor(dwo);
        }

        void data1GV1ePackingDet1UploadExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoWrokObject dwo = new DoWrokObject(data1GV1ePackingDet1UploadExcel, e.RowIndex, e.ColumnIndex);
            cf.selectCellMethod(dwo);
        }

        private void frmUpload_Load(object sender, EventArgs e)
        {
            _idr_show._tuploadExcel = new Thread(UploadExcelDelegate);
            _idr_show._tInitGDV = new Thread(new ParameterizedThreadStart(initExcelDGVDelegate));
            initwidthUploadExcel();
        }
        private void initwidthUploadExcel()
        {
            groupBox2mstrUploadExcel.Width = groupBox0frmUploadExcelForKYCA.Width - groupBox2mstrUploadExcel.Left - 5;
            groupBox3detUploadExcel.Width = groupBox2mstrUploadExcel.Width;

            groupBox3detUploadExcel.Height = groupBox0frmUploadExcelForKYCA.Height - groupBox3detUploadExcel.Top - 10;

        }
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
                }

                ///
                // initLoadExcelFile();
                ///
                btnSelectfileUploadExcel.Enabled = true;
                btn3QuickUploadExcel.Enabled = true;
            }
            catch (Exception ex)
            {

                btn3QuickUploadExcel.Enabled = true;
                btnSelectfileUploadExcel.Enabled = true;
                MessageBox.Show(ex.Message, "Error");
            }
        }


        private void btnCmdUpdUploadExcel_Click(object sender, EventArgs e)
        {

            if (txt0ExcelFileUploadExcel.Text.Trim() == "")
            {
                // MessageBox.Show("没选择Excel文件， 不能完成上传操作！", "Error");
                lbl1UploadExcelThreadMsg.Text = "Error,没选择Excel， 不能完成上传操作,请选择正确的文件，谢谢！";
                btnSelectfileUploadExcel.Focus();
            }
            else
            {
                oldtime = DateTime.Now;
                _idr_show._tuploadExcel = new Thread(UploadExcelDelegate);
                if (_idr_show._tuploadExcel.ThreadState == ThreadState.Running)
                {
                    _idr_show._tuploadExcel.Abort();
                }

                if (_idr_show._tuploadExcel.ThreadState == ThreadState.Unstarted)
                {
                    _idr_show._tuploadExcel.Start();
                }
                if (_idr_show._tuploadExcel.ThreadState == ThreadState.Stopped)
                {
                    _idr_show._tuploadExcel = new Thread(UploadExcelDelegate);
                    _idr_show._tuploadExcel.Start();
                }
                lbl1UploadExcelThreadMsg.Text = " Notice: 上传中。。。。";
            }
        }

        private void UploadExcel()
        {
            btnCmdUpdUploadExcel.Enabled = false;
            //cf.setControlText(btnCmdUpd, "Uploading...", false, true);
            try
            {
                Excel_Upload("");
            }
            catch (Exception ex)
            {

                _idr_show._tuploadExcel.Abort();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnCmdUpdUploadExcel.Enabled = true;
                //cf.setControlText(btnCmdUpd, "&Upload", true, true);
            }
        }

        private void UploadExcelDelegate()
        {
            Commfunction.dvoidMethod me = new Commfunction.dvoidMethod(UploadExcel);
            _idr_show.Invoke(me);
        }

        private void initExcelDGV(object strBatchID)
        {
            CartonFromTo ctft = new CartonFromTo(data1GV1ePackingDet1UploadExcel, (string)strBatchID, 0, "upload", _idr_show._custip, _idr_show._custip);
            var reobjmstr = cf.initDataGVPlrBatchMstr(ctft, false, "model");
            var reobjdet = cf.initDataGVplr_mstr(ctft, true, "nothing");
            if (reobjmstr != null)
            {
                _idr_show._plr_batch_mstr_model = (PIE.Model.plr_batch_mstr)reobjmstr;
                initDatasetToTxt(_idr_show._plr_batch_mstr_model, true);
            }
        }

        private void initExcelDGVDelegate(object strBatchID)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(initExcelDGV);
            _idr_show.Invoke(me, strBatchID);
        }
        public void SetCtlTextdelegate(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible)
        {
            Commfunction.dSafeSetCtlText objSet = new Commfunction.dSafeSetCtlText(cf.setControlText);

            _idr_show.Invoke(objSet, new object[] { ctl, strMsg, enable, visible });

        }

        private void Excel_Upload(string supplier)
        {
            //Cursor = Cursors.WaitCursor;

            int row = 2;
            int col = 1;
            int intNullCount = 0, intUploadSuccess = 0;

            string strCTNID = "999";

            string strresult = "", strUploadResult = "";

            string strpocheck = "", strpocheckErr = "";

            SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadExcel: 初始化Excel文件...", true, true);

            //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: 初始化Excel文件...";

            PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();

            if (!getNewBatchID(ref _strBatchID))
            {
                return;
            };

            if (string.IsNullOrEmpty(_strBatchID))
            {
                //MessageBox.Show("生成BatchID,出错，无法导入。");
                SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadExcel: Error,生成BatchID,出错，无法导入。", true, true);
                //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: Error,生成BatchID,出错，无法导入。";
                return;
            }
            object missing = System.Reflection.Missing.Value;

            Excel.Application excel;
            Excel.Workbook xBk;
            Excel.Worksheet xSt;
            excel = new Excel.Application();


            if (excel == null)
            {
                //MessageBox.Show("不能访问Excel", "Error");
                SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadExcel: Error,不能访问Excel。", true, true);
                //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: Error,不能访问Excel。";

                return;
            }
            excel.Visible = false;
            excel.UserControl = true;
            //只读的形工打开Excel文件
            xBk = excel.Application.Workbooks.Open(txt0ExcelFileUploadExcel.Text.Trim(), missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);

            xSt = (Worksheet)xBk.Worksheets.get_Item(1);
            //try
            //{

            //取得总记录行数
            row = xSt.UsedRange.Cells.Rows.Count;
            col = xSt.UsedRange.Cells.Columns.Count;

            //取得数据范围区域（不包标题列）
            Range rag1 = xSt.Cells.get_Range("A2", "N" + row); //Batch_ID
            object[,] arryItem = (object[,])rag1.Value2;


            //toolStripProgressBarUplad.Maximum = row - 1;
            //toolStripProgressBarUplad.Visible = true;
            //toolStripStatusLabelMessage.Text = "开始导入Excel文件...";
            SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadExcel: 开始导入Excel文件...", true, true);
            //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: 开始导入Excel文件... ";
            for (int i = 1; i < row; i++)
            {
                //toolStripProgressBarUplad.Value = i;
                plr_mstr_model.Batch_ID = _strBatchID;
                plr_mstr_model.plr_suppliers_id = supplier;

                plr_mstr_model.packingListID = arryItem[i, 1] != null ? arryItem[i, 1].ToString().Trim() : "";
                plr_mstr_model.InvoiceID = arryItem[i, 2] != null ? arryItem[i, 2].ToString().Trim() : "";

                //plr_mstr_model.plr_site = arryItem[i, 3] != null ? arryItem[i, 3].ToString().Trim() : "";
                plr_mstr_model.plr_pallet_no = arryItem[i, 3] != null ? arryItem[i, 3].ToString().Trim() : "";


                plr_mstr_model.CartonType = arryItem[i, 4] != null ? arryItem[i, 4].ToString().Trim() : "0";
                plr_mstr_model.CartonID = arryItem[i, 5] != null ? arryItem[i, 5].ToString().Trim() : "";

                plr_mstr_model.plr_po = arryItem[i, 6] != null ? arryItem[i, 6].ToString().Trim() : "";
                plr_mstr_model.plr_co = arryItem[i, 7] != null ? arryItem[i, 7].ToString().Trim() : "";
                plr_mstr_model.plr_partno = arryItem[i, 8] != null ? arryItem[i, 8].ToString().Trim() : "";

                plr_mstr_model.plr_date_code = arryItem[i, 9] != null ? arryItem[i, 9].ToString().Trim() : "";
                plr_mstr_model.plr_vend_mfgr = arryItem[i, 10] != null ? arryItem[i, 10].ToString().Trim() : "";
                plr_mstr_model.Plr_vm_partno = arryItem[i, 11] != null ? arryItem[i, 11].ToString().Trim() : "";

                plr_mstr_model.plr_carton_qty = arryItem[i, 12] != null ? Convert.ToDecimal(arryItem[i, 12].ToString().Trim()) : 0;
                plr_mstr_model.plr_qty = arryItem[i, 13] != null ? Convert.ToDecimal(arryItem[i, 13].ToString().Trim()) : 0;

                #region check right
                if (string.IsNullOrEmpty(plr_mstr_model.packingListID) && string.IsNullOrEmpty(plr_mstr_model.InvoiceID) && string.IsNullOrEmpty(plr_mstr_model.CartonID) && string.IsNullOrEmpty(plr_mstr_model.plr_po) && string.IsNullOrEmpty(plr_mstr_model.plr_partno))
                {
                    intNullCount++;
                    strresult += "第 " + i + " 行为空\t";
                    continue;
                }
                //if (string.IsNullOrEmpty(plr_mstr_model.packingListID) || string.IsNullOrEmpty(plr_mstr_model.InvoiceID))
                //{
                //    intNullCount++;
                //    strresult += "第 " + i + " 行: Supplier DN or packing list no. 与 Supplier Inv no. 至少要有一项。\n";
                //    continue;
                //}
                //if (string.IsNullOrEmpty(plr_mstr_model.CartonID))
                //{
                //    intNullCount++;
                //    strresult += "第 " + i + " 行: " + plr_mstr_model.packingListID + "@" + plr_mstr_model.InvoiceID + "@Error: CartonID为空\n";
                //    continue;

                //}
                //if (string.IsNullOrEmpty(plr_mstr_model.plr_po))
                //{
                //    intNullCount++;
                //    strresult += "第 " + i + " 行: " + plr_mstr_model.packingListID + "@" + plr_mstr_model.InvoiceID + "@Error: WEC PO No.为空\n";
                //    continue;

                //}
                //if (string.IsNullOrEmpty(plr_mstr_model.plr_co))
                //{
                //    intNullCount++;
                //    strresult += "第 " + i + " 行: " + plr_mstr_model.packingListID + "@" + plr_mstr_model.InvoiceID + "@Error: C.O 为空\n";
                //    continue;

                //}
                //if (string.IsNullOrEmpty(plr_mstr_model.plr_partno))
                //{
                //    intNullCount++;
                //    strresult += "第 " + i + " 行: " + plr_mstr_model.packingListID + "@" + plr_mstr_model.InvoiceID + "@Error: WEC Part No 为空\n";
                //    continue;

                //}
                //if (string.IsNullOrEmpty(plr_mstr_model.plr_qty))
                //{
                //    intNullCount++;
                //    strresult += "第 " + i + " 行: " + plr_mstr_model.packingListID + "@" + plr_mstr_model.InvoiceID + "@Error: Delivery Qty 为空\n";
                //    continue;

                //}
                #endregion
                plr_mstr_model.LineID = i - intNullCount;
                plr_mstr_model.plr_doc_type = "e-Packing";
                plr_mstr_model.plr_status = "No";
                plr_mstr_model.plr_void_status = 0;
                plr_mstr_model.plr_rcp_date = DbHelperSQL.getServerGetDate();
                plr_mstr_model.plr_deli_date = DateTime.Now;
                plr_mstr_model.plr_cre_date = DateTime.Now; // DateTime.FromOADate(double型)    如果excel为日期时
                plr_mstr_model.plr_update_date = DateTime.Now;
                plr_mstr_model.plr_user_ip = Program.getClientIP();

                var result = new PIE.BLL.plr_mstr().Add(plr_mstr_model);

                if (!result)
                {
                    intNullCount++;
                    if (intNullCount % 2 == 0)
                    {
                        strresult += plr_mstr_model.Batch_ID + "@" + plr_mstr_model.packingListID + "@" + plr_mstr_model.LineID + "@" + plr_mstr_model.CartonID + "未上传\n";
                    }
                    else
                    {
                        strresult += plr_mstr_model.Batch_ID + "@" + plr_mstr_model.packingListID + "@" + plr_mstr_model.LineID + "@" + plr_mstr_model.CartonID + "未上传\t";
                    }

                }
                else
                {
                    intUploadSuccess++;
                    SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadToERP: 第:" + intUploadSuccess + "条上传成功", true, true);
                    //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: 第:" + intUploadSuccess + "条上传成功";

                    _plr_batch_mstr_model.batch_dec01 = intUploadSuccess;
                    _plr_batch_mstr_model.batch_update_date = DateTime.Now;
                    _idr_show._plr_batch_mstr_model.batch_dec01 = intUploadSuccess;

                    var addRowCount = new PIE.BLL.plr_batch_mstr().Update(_plr_batch_mstr_model);

                    var intresutl = Program.GenCartonNo(plr_mstr_model);



                    //strpocheck = Program.POchecking(plr_mstr_model);
                    //if (strpocheck != "OK")
                    //{
                    //    strpocheckErr = strpocheckErr + strpocheck + ","+plr_mstr_model.LineID+ ",";
                    //}
                }

            }
            //toolStripProgressBarUplad.Visible = false;

            // strUploadResult = intNullCount > 0 ? "BatchID: " + strBatchID + "\n\n总记录: " + (row - 1) + " 条,\t上传:" + intUploadSuccess + "条成功，\t失败: " + intNullCount + " 条\n未上传记录：\n" + strresult + "\n取出未上的的记录，查看后重新上传。谢谢。\n" : "BatchID:  " + strBatchID + "\n 总记录:" + (row - 1) + "条,\t上传:" + intUploadSuccess + "条成功，\t失败:" + intNullCount + "条.\n";

            _plr_batch_mstr_model.batch_dec01 = intUploadSuccess;
            var updatresultBatch = new PIE.BLL.plr_batch_mstr().Update(_plr_batch_mstr_model);

            //toolStripStatusLabelMessage.Text = strUploadResult;
            // toolStripStatusLabelMessage.Text
            var currtime = DateTime.Now - oldtime;
            string difftime = " Use Time: " + currtime.Minutes + " Minutes " + currtime.Seconds + " Secconds " + currtime.Milliseconds + " Milliseconds";
            var msg = "$UploadToERP:\t BatchID: " + _strBatchID + ",\t 总记录: " + (row - 1) + " 条,\t 上传:" + intUploadSuccess + "条成功，\t 失败: " + intNullCount + "条. 生成 CartonNo Success." + strresult;
            msg += difftime;
            SetCtlTextdelegate(lbl1UploadExcelThreadMsg, msg, true, true);
            //lbl1UploadExcelThreadMsg.Text = msg;

            txt0ExcelFileUploadExcel.Text = "";
            //cf.setControlText(txtExcelFile, "", true, true);  

            //initDataGVBM0(strBatchID);
            //tab1AllPacklingList1.SelectedTab = tabPackingListDetailInfoEPacking2;
            //initDataGV_e_Packing3(strBatchID);

            //initExcelDGV(strBatchID);


            _idr_show._tInitGDV = new Thread(initExcelDGVDelegate);
            if (_idr_show._tInitGDV.ThreadState == ThreadState.Running)
            {
                _idr_show._tInitGDV.Abort();
            }

            if (_idr_show._tInitGDV.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tInitGDV.Start(_strBatchID);
            }
            if (_idr_show._tInitGDV.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tInitGDV = new Thread(initExcelDGVDelegate);
                _idr_show._tInitGDV.Start(_strBatchID);
            }

            //_initDataGVThread = new Thread(new ParameterizedThreadStart(initDGVdelegate));


            // Cursor = Cursors.Default;
            #region demo
            //取得数据范围区域（不包标题列）
            //Range rag1 = xSt.Cells.get_Range("A2", "A" + row); //Batch_ID
            //object[,] arryItem = (object[,])rag1.Value2;
            //将新值赋给一个数组
            //string[,] arry = new string[row - 1, 2];
            // for (int i = 1; i < row ; i++)
            //{
            // arry[i - 1, 0] = arryItem[i, 1].ToString();
            // MessageBox.Show(arryItem[i,1].ToString());
            //}

            #endregion

            //}
            //catch (Exception ex)
            //{
            //    //Cursor = Cursors.Default;
            //    MessageBox.Show(strUploadResult + "\nError:" + ex.Message);
            //}
            //finally
            //{
            //Cursor = Cursors.Default;
            #region  结束Excel进程

            //需要对Excel的DCOM对象进行配置:dcomcnfg


            //excel.Quit();
            //excel=null;            

            xBk.Close(null, null, null);
            excel.Workbooks.Close();
            excel.Quit();


            //注意：这里用到的所有Excel对象都要执行这个操作，否则结束不了Excel进程
            //			if(rng != null)
            //			{
            //				System.Runtime.InteropServices.Marshal.ReleaseComObject(rng);
            //				rng = null;
            //			}
            //			if(tb != null)
            //			{
            //				System.Runtime.InteropServices.Marshal.ReleaseComObject(tb);
            //				tb = null;
            //			}
            if (xSt != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xSt);
                xSt = null;
            }
            if (xBk != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xBk);
                xBk = null;
            }
            if (excel != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                excel = null;
            }
            GC.Collect();//垃圾回收
            #endregion
            //}

        }

        public bool getNewBatchID(ref string strBatchID)
        {
            int intOutAffected;
            SqlParameter[] parameters = {
                                            new SqlParameter("@BatchID",SqlDbType.NVarChar,20)
                                        };
            parameters[0].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_GetBatchID", parameters, out intOutAffected);
            strBatchID = parameters[0].Value != null ? parameters[0].Value.ToString() : "";

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
        }
        bool insertNewplr_batch_mstr()
        {
            //batch master

            _plr_batch_mstr_model.batch_id = _strBatchID;
            //_plr_batch_mstr_model.plr_suppliers_id = "";
            _plr_batch_mstr_model.batch_doc = "e-Packing-kyca";
            //plr_batch_mstr_model.batch_dec01 = row - 1;
            //_plr_batch_mstr_model.batch_void = 0;
            _plr_batch_mstr_model.batch_status = "No";
            _plr_batch_mstr_model.batch_cre_date = DbHelperSQL.getServerGetDate();
            _plr_batch_mstr_model.batch_update_date = _plr_batch_mstr_model.batch_cre_date;
            _plr_batch_mstr_model.batch_cre_date = _plr_batch_mstr_model.batch_cre_date;

            _plr_batch_mstr_model.batch_user_ip = _idr_show._custip;

            var result_batch = new PIE.BLL.plr_batch_mstr().Add(_plr_batch_mstr_model);

            if (!result_batch)
            {
                //MessageBox.Show("生成批号出错，请重新导入。谢谢", "Error");
                SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadExcel: Error,生成批号出错，请重新导入。", true, true);
                //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: Error,生成批号出错，请重新导入。";
                return false;
            }
            _idr_show._plr_batch_mstr_model = _plr_batch_mstr_model;
            initDatasetToTxt(_idr_show._plr_batch_mstr_model, true);
            return true;
        }

        private void initDatasetToTxt(DataSet ds)
        {
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txt1batch_idUploadExcel.Text = ds.Tables[0].Rows[0]["batch_id"].ToString();
                    txt2batch_docUploadExcel.Text = ds.Tables[0].Rows[0]["batch_doc"].ToString();
                    txt3batch_statusUploadExcel.Text = ds.Tables[0].Rows[0]["batch_status"].ToString();
                    txt4batch_dec01UploadExcel.Text = ds.Tables[0].Rows[0]["batch_dec01"].ToString();
                    txt5batch_cre_dateUploadExcel.Text = ds.Tables[0].Rows[0]["batch_cre_date"].ToString();
                }
            }
        }
        private void initDatasetToTxt(PIE.Model.plr_batch_mstr model, bool breadonly)
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
        }
        private void groupBox1frmUpload_Resize(object sender, EventArgs e)
        {
            initwidthUploadExcel();
        }

        private void btn2TempleFile_Click(object sender, EventArgs e)
        {
            string pathname = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"0temple\templesforKYCA.xlsx";
            Program.OpenFolderAndSelectFile(pathname);
        }
        void Init0ializeWorkbook(object path)
        {
            //read xls
            using (FileStream file = new FileStream((string)path, FileMode.Open, FileAccess.Read))
            {
                if (Path.GetExtension((string)path).ToLower().Equals(".xls"))
                {
                    _strext = ".xls";
                    _idr_show._hssfworkbook = new HSSFWorkbook(file);
                    sheet = _idr_show._hssfworkbook.GetSheetAt(0);
                }
                else if (Path.GetExtension((string)path).ToLower().Equals(".xlsx"))
                {
                    _strext = ".xlsx";
                    _idr_show._xssfworkbook = new XSSFWorkbook(file);
                    sheet = _idr_show._xssfworkbook.GetSheetAt(0);
                }
                else
                {
                    throw new Exception("Error0: this file is not the xls or xlsx file.0");
                }
            }

            var strmsg = Convert0ToDataTable();

            data1GV1ePackingDet1UploadExcel.DataSource = data0set_npoi.Tables[0];
            data1GV1ePackingDet1UploadExcel.Refresh();

            if (_dterr.Rows.Count > 0)
            {
                data2GV2ePackingDet1UploadExcelError.DataSource = _dterr.DefaultView;
                data2GV2ePackingDet1UploadExcelError.Refresh();
                tabControl1.SelectedIndex = 1;
            }
            if (data0set_npoi.Tables[0].Rows.Count > 0)
            {
                // command.InsertCommand = cmdb.GetInsertCommand();
                // command.DeleteCommand = cmdb.GetDeleteCommand();
                // command.UpdateCommand = cmdb.GetUpdateCommand();


                UpdateBatchToDB(strmsg);


                //for (int i = 0; i < data0set_npoi.Tables[0].Rows.Count; i++)
                //{
                //    DataRow dr = data0set_npoi.Tables[0].Rows[i];
                //    PIE.Model.plr_mstr plr_mstr_model = new PIE.DAL.plr_mstr().DataRowToModel(dr, true);
                //    var intresutl = Program.GenCartonNo(plr_mstr_model);
                //}
            }




        }
        void UpdateBatchToDB(object o)
        {

            var currmsg = "Start Upload DB For BatchID......";
            cf.SetCtlTextdelegate(lbl1UploadExcelThreadMsg, currmsg, true, true);
            command.Update(data0set_npoi);
            data0set_npoi.AcceptChanges();

            //var intresutl = Program.GenCartonNo(data0set_npoi);

            ThreadPool.QueueUserWorkItem(new WaitCallback(doGenCarton), o);
        }
        void doGenCarton(object o)
        {
            int countsuccess = 0;
            int counterror = 0;
            string batchid = "";
            foreach (DataRow dr in data0set_npoi.Tables[0].Rows)
            {
                PIE.Model.plr_mstr plr_mstr_model = new PIE.DAL.plr_mstr_ext().DataRowToModel(dr, true);
                var currmsg = "Start Generate Carton ID For BatchID: " + plr_mstr_model.Batch_ID + ",LineID:" + plr_mstr_model.LineID;
                cf.SetCtlTextdelegate(lbl1UploadExcelThreadMsg, currmsg, true, true);
                int intresutl = Program.GenCartonNo(plr_mstr_model);
                batchid = plr_mstr_model.Batch_ID;
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
            string tmpsql = "select sum(plr_carton_qty) from  [dbo].[plr_mstr_tran] where batch_id='" + batchid + "'";
            var ttlqty = DbHelperSQL.GetSingle(tmpsql);

            var msgCarton = "\nGenerate Carton ID For BatchID " + batchid + " Success.Carton of Total Qty:" + ttlqty.ToString();
            var currtime = DateTime.Now - oldtime;
            string difftime = ",\t\t Use Time: " + currtime.Minutes + " Minutes " + currtime.Seconds + " Secconds " + currtime.Milliseconds + " Milliseconds";
            if (_gblTTlQty.ToString().Equals(ttlqty.ToString()))
            {
                cf.SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "\t" + o.ToString() + msgCarton + difftime, true, true);
            }
            else
            {
                MessageBox.Show("Error:Excel file Total Qty:" + _gblTTlQty + " <> " + ttlqty.ToString() + " Carton of Total Qty,\n Can't be Upload to ERP. \nPlease check Excel file.");

                string strupdate_plr_batch_mstr = @"update [plr_batch_mstr] set batch_status='Yes' where batch_id='" + batchid + "'";
                string strupdateplr_mstr = @"update plr_mstr set plr_status='Yes' where batch_id='" + batchid + "'";
                string strupdateplr_mstr_tran = @"update plr_mstr_tran set plr_status='Yes',plr_status_msg='Void' where batch_id='" + batchid + "'";

                var resultmstrPlr = DbHelperSQL.ExecuteSql(strupdate_plr_batch_mstr);
                var resultmstr = DbHelperSQL.ExecuteSql(strupdateplr_mstr);
                var resultmstr_tran = DbHelperSQL.ExecuteSql(strupdateplr_mstr_tran);
            }
        }
        string Convert0ToDataTable()
        {
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();


            data0set_npoi.Tables[0].Clear();
            data0set_npoi.Tables[0].AcceptChanges();


            System.Data.DataTable dt = data0set_npoi.Tables[0];

            if (!getNewBatchID(ref _strBatchID))
            {
                return "Error: BatchID is Error";
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

            var servedate = DbHelperSQL.getServerGetDate();


            while (rows.MoveNext())
            {
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
                if (addrowscount == 0)
                {
                    command.UpdateCommand = cmdb.GetUpdateCommand();
                    addrowscount = 1;
                    rowscount = 1;

                    //errorDataTable
                    _dterr.Clear();
                    _dterr.AcceptChanges();

                    //Excel
                    _dt_downToExela.Clear();
                    _dt_downToExela.AcceptChanges();

                    if (!_addHeadForDownExcel)
                    {
                        tableColumnsAdd(_dt_downToExela, "flag");
                        for (int i = 0; i < row.LastCellNum; i++)
                        {
                            if (row == null)
                            {
                                continue;
                            }
                            tableColumnsAdd(_dt_downToExela, row.GetCell(i).ToString());
                        }
                        _addHeadForDownExcel = true;
                    }

                    //data2GV2ePackingDet1UploadExcelError.DataSource = _dt_downToExela.DefaultView;
                    //data2GV2ePackingDet1UploadExcelError.Refresh();
                    //cf.downLoadExcel(_dt_downToExela, lbl1UploadExcelThreadMsg, cf.nameList0vpi_report_ds(), "dd");
                    //break;
                    continue;
                }

                DataRow dr = dt.NewRow();
                DataRow dr_downexcel = _dt_downToExela.NewRow();

                _idr_show.status15toolLabelstrResult.Text = "Load Rows at:" + rowscount;


                for (int i = 0; i < 8; i++)
                {
                    dr[0] = _strBatchID;
                    dr[1] = addrowscount;
                    dr["plr_status"] = "No";

                    dr["plr_doc_type"] = "e-Packing-kyca";
                    dr["plr_rcp_date"] = servedate;
                    dr["plr_deli_date"] = servedate;
                    dr["plr_cre_date"] = servedate; // DateTime.FromOADate(double型)    如果excel为日期时
                    dr["plr_update_date"] = servedate;
                    dr["plr_user_ip"] = _idr_show._custip;

                    dr["plr_carton_qty"] = 0;
                    dr["CartonType"] = 0;

                    ICell cell = row.GetCell(i);

                    if (cell == null || string.IsNullOrEmpty(cell.ToString()))
                    {
                        if (rowscount == 1)
                        {

                            strerrnullrows += (rowscount + 1).ToString();
                        }
                        else
                        {
                            strerrnullrows += ",null row:" + (rowscount + 1).ToString();

                        }
                        rowscount++;
                        rowserrscount++;
                        nextrow = false;
                        break;
                        //dr[i] = null;
                    }
                    else
                    {

                        if (cell.CellType == CellType.Numeric)
                        {
                            dr[i + 4] = cell.NumericCellValue;
                        }
                        else if (cell.CellType == CellType.String)
                        {

                            dr[i + 4] = cell.ToString().Trim();
                        }
                        else
                        {
                            dr[i + 4] = cell.ToString();
                        }

                        if (i == 3)
                        {
                            _strprefix = "";
                            _cartonid = Program.initCartonFromTo(dr[i + 4].ToString(), "", out _strprefix);
                            _cartonid[0] = _cartonid[0].Trim();
                            _cartonid[1] = _cartonid[1].Trim();
                        }



                    }
                    nextrow = true;

                }
                if (nextrow)
                {

                    ICell cell5 = row.GetCell(5);
                    //qty
                    ICell cell6 = row.GetCell(6);

                    ICell cell9 = row.GetCell(9);
                    ICell cell11 = row.GetCell(11);
                    ICell cell13 = row.GetCell(13);
                    ICell cell15 = row.GetCell(15);
                    ICell cell17 = row.GetCell(17);

                    ICell cell19 = row.GetCell(19);
                    ICell cell21 = row.GetCell(21);
                    ICell cell23 = row.GetCell(23);
                    ICell cell25 = row.GetCell(25);
                    ICell cell27 = row.GetCell(27);

                    //po
                    ICell cell8 = row.GetCell(8);
                    ICell cell10 = row.GetCell(10);
                    ICell cell12 = row.GetCell(12);
                    ICell cell14 = row.GetCell(14);
                    ICell cell16 = row.GetCell(16);

                    ICell cell18 = row.GetCell(18);
                    ICell cell20 = row.GetCell(20);
                    ICell cell22 = row.GetCell(22);
                    ICell cell24 = row.GetCell(24);
                    ICell cell26 = row.GetCell(26);

                    _ttlQtyIntcell6 = getICellToDouble(cell6);
                    _gblTTlQty += _ttlQtyIntcell6;
                    _numCellVal = false;
                    _poCountnumCell = 0;
                    double intcell9 = getICellToDouble(cell9, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    double intcell11 = getICellToDouble(cell11, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    double intcell13 = getICellToDouble(cell13, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    double intcell15 = getICellToDouble(cell15, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    double intcell17 = getICellToDouble(cell17, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    //new 5
                    double intcell19 = getICellToDouble(cell19, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    double intcell21 = getICellToDouble(cell21, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    double intcell23 = getICellToDouble(cell23, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    double intcell25 = getICellToDouble(cell25, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }
                    double intcell27 = getICellToDouble(cell27, out _numCellVal);
                    if (_numCellVal)
                    {
                        _poCountnumCell++;
                    }


                    var ttl = intcell9 + intcell11 + intcell13 + intcell15 + intcell17 + intcell19 + intcell21 + intcell23 + intcell25 + intcell27;
                    if (_ttlQtyIntcell6 != ttl)
                    {
                        strerrnullrows += ",QtyError:" + rowscount.ToString();

                        DataRow drerr = _dterr.NewRow();
                        drerr[0] = rowscount;
                        drerr[1] = cell5.ToString();
                        drerr[2] = _ttlQtyIntcell6;

                        string strmsgint = "";
                        if (intcell9 != 0)
                        {
                            strmsgint = "TTL/Qty: [" + _ttlQtyIntcell6.ToString() + "] no Equal(<>) [" + ttl + "] PO:" + cell8 + ",Qty:" + intcell9.ToString();
                        }
                        if (intcell11 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell10 + ",Qty:" + intcell11.ToString();
                        }
                        if (intcell13 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell12 + ",Qty:" + intcell13.ToString();
                        }
                        if (intcell15 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell14 + ",Qty:" + intcell15.ToString();
                        }
                        if (intcell17 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell16 + ",Qty:" + intcell17.ToString();
                        }
                        //next 5
                        if (intcell19 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell18 + ",Qty:" + intcell19.ToString();
                        }
                        if (intcell21 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell10 + ",Qty:" + intcell21.ToString();
                        }
                        if (intcell23 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell12 + ",Qty:" + intcell23.ToString();
                        }
                        if (intcell25 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell14 + ",Qty:" + intcell25.ToString();
                        }
                        if (intcell27 != 0)
                        {
                            strmsgint += " +" + " PO:" + cell16 + ",Qty:" + intcell27.ToString();
                        }
                        drerr[3] = strmsgint;
                        _dterr.Rows.Add(drerr);

                        addRowsToDownExcel(_dt_downToExela, dr_downexcel, strmsgint, row);

                        rowserrscount++;
                        rowscount++;
                        continue;
                    }
                    else
                    {
                        addRowsToDownExcel(_dt_downToExela, dr_downexcel, "Upload Success", row);

                        double intfrom = Convert.ToInt32(_cartonid[0]);
                        double into = Convert.ToInt32(_cartonid[1]);

                        //count of carton
                        _cartonCount = into - intfrom + 1;
                        _tmpDiffQty = 0;
                        _tmpcurrCartonID = intfrom;

                        if (_ttlQtyIntcell6 < _cartonCount)
                        {
                            var tmpmsg = "Number error. TTL Qty:" + _ttlQtyIntcell6 + " < Carton Count:" + _cartonCount + "\t\n Please Check the Excel File of PO,TTLQty,CartonID.";
                            cf.SetCtlTextdelegate(lbl1UploadExcelThreadMsg, tmpmsg, true, true);
                            throw new Exception(tmpmsg);
                        }
                        else
                        {
                            _remainderCurrRow = _ttlQtyIntcell6 % _cartonCount;
                            _avgCurrRowQty = (_ttlQtyIntcell6 - _remainderCurrRow) / _cartonCount;
                        }
                        //


                        if (_cartonid[0].Equals(_cartonid[1]))
                        {
                            strCartonID = _strprefix + _cartonid[0];
                        }
                        else
                        {
                            strCartonID = _strprefix + _cartonid[0] + "-" + _cartonid[1];
                        }

                        //
                        dr["CartonType"] = 0;

                        if (intcell9 > 0)
                        {
                            //carton
                            //initCartonID(dt, dr, intcell9, cell8, 1, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell8.ToString(), intcell9));
                        }
                        if (intcell11 > 0)
                        {
                            //carton
                            //initCartonID(dt, dr, intcell11, cell10, 2, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell10.ToString(), intcell11));
                        }
                        if (intcell13 > 0)
                        {
                            //gen cartonid
                            //initCartonID(dt, dr, intcell13, cell12, 3, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell12.ToString(), intcell13));
                        }
                        if (intcell15 > 0)
                        {
                            //carton id
                            //initCartonID(dt, dr, intcell15, cell14, 4, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell14.ToString(), intcell15));
                        }
                        if (intcell17 > 0)
                        {
                            //carton id
                            //initCartonID(dt, dr, intcell17, cell16, 5, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell16.ToString(), intcell17));
                        }
                        //next 5
                        if (intcell19 > 0)
                        {
                            //carton id
                            //initCartonID(dt, dr, intcell19, cell18, 6, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell18.ToString(), intcell19));
                        }
                        if (intcell21 > 0)
                        {
                            //carton
                            //initCartonID(dt, dr, intcell21, cell20, 7, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell20.ToString(), intcell21));

                        }
                        if (intcell23 > 0)
                        {
                            //gen cartonid
                            //initCartonID(dt, dr, intcell23, cell22, 8, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell22.ToString(), intcell23));
                        }
                        if (intcell25 > 0)
                        {
                            //carton id
                            //initCartonID(dt, dr, intcell25, cell24, 9, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell24.ToString(), intcell25));
                        }
                        if (intcell27 > 0)
                        {
                            //carton id
                            //initCartonID(dt, dr, intcell27, cell26, 10, intfrom, into, _cartonCount);
                            _listPoQty.Add(new ListPoQty(cell26.ToString(), intcell27));

                        }
                        initCartonID(dt, dr, _listPoQty, intfrom, _cartonCount, _poCountnumCell, _avgCurrRowQty, _remainderCurrRow);
                        _listPoQty.Clear();
                        rowscount++;
                    }
                }
            }
            _plr_batch_mstr_model.batch_dec01 = (addrowscount - 1);
            _plr_batch_mstr_model.batch_cre_user = _gblTTlQty.ToString();

            var updatebathccount = new PIE.BLL.plr_batch_mstr().Update(_plr_batch_mstr_model);
            if (updatebathccount)
            {
                _idr_show._plr_batch_mstr_model = _plr_batch_mstr_model;
                initDatasetToTxt(_idr_show._plr_batch_mstr_model, true);
            }
            return "Notice:Excel file has Total Rows: " + rowscountsum + " and Total Qty: " + _gblTTlQty.ToString() + ",Total PO: " + (addrowscount - 1 + rowserrscount) + " ,Update " + (addrowscount - 1) + " items Success, Error: has " + rowserrscount + " Rows has Error (" + strerrnullrows + ").";

            //data0set_npoi.Tables.Add(dt);
        }
        private void addNewRowFromCarton(System.Data.DataTable dt, DataRow newdr, List<ListPoQty> listpoqty)
        {
            foreach (var item in listpoqty)
            {
                newRow(dt, newdr, item, 0);
            }

        }

        private void newRow(System.Data.DataTable dt, DataRow newdr, ListPoQty item, int pocount)
        {
            DataRow drnew = dt.NewRow();
            for (int i = 0; i < newdr.ItemArray.Length; i++)
            {
                drnew[i] = newdr[i];
            }
            drnew[1] = addrowscount;

            //carton
            if (pocount > 0)
            {

                drnew[7] = item._ctnPrefix + (item._ctn - pocount) + "-" + item._ctn;
            }
            else
            {

                drnew[7] = item._ctnPrefix + item._ctn;
            }

            //qty
            drnew[10] = item._ttlQty;

            drnew[12] = item._po;

            drnew[13] = item._qty;
            drnew[14] = 0;

            drnew[16] = strCartonID;
            dt.Rows.Add(drnew);
            addrowscount++;
        }
        private void addNewRowFromCarton(System.Data.DataTable dt, DataRow newdr, double intcellQty, ICell cellPO, string drnew7, double drnew13, double drnew14)
        {
            DataRow drnew = dt.NewRow();
            for (int i = 0; i < newdr.ItemArray.Length; i++)
            {
                drnew[i] = newdr[i];
            }

            drnew[1] = addrowscount;

            //carton

            drnew[7] = drnew7;

            //qty
            drnew[10] = intcellQty;

            drnew[12] = cellPO.ToString().Trim();

            drnew[13] = drnew13;
            drnew[14] = drnew14;

            drnew[16] = strCartonID;
            dt.Rows.Add(drnew);
            addrowscount++;
        }
        private void initCartonID(System.Data.DataTable dt, DataRow dr, List<ListPoQty> listpoqty, double ctnFrom, double CtnCount, double PoCount, double poQtyAvg, double remainQty)
        {
            double tmpRemain = 0;
            for (int j = 0; j < CtnCount; j++)
            {
                tmpRemain = poQtyAvg;

                for (int i = 0; i < listpoqty.Count; i++)
                {
                    if (listpoqty[i]._qty > 0)
                    {
                        ListPoQty tmplitpoqyt = new ListPoQty();

                        tmplitpoqyt._ctnIndex = j;
                        tmplitpoqyt._ctnFrom = ctnFrom;
                        tmplitpoqyt._ctnPrefix = _strprefix;
                        tmplitpoqyt._ctn = ctnFrom + j;
                        tmplitpoqyt._po = listpoqty[i]._po;
                        tmplitpoqyt._ttlQty = listpoqty[i]._ttlQty;

                        if (tmpRemain >= listpoqty[i]._qty)
                        {
                            tmplitpoqyt._qty = listpoqty[i]._qty;
                            tmpRemain = tmpRemain - listpoqty[i]._qty;
                            listpoqty[i]._qty = 0;
                        }
                        else
                        {
                            tmplitpoqyt._qty = tmpRemain;
                            listpoqty[i]._qty = listpoqty[i]._qty - tmpRemain;
                            tmpRemain = 0;
                        }
                        _listCtnPoQty.Add(tmplitpoqyt);
                        if (tmpRemain == 0)
                        {
                            break;
                        }
                    }
                }
            }
            _listCtnPoQty[_listCtnPoQty.Count - 1]._qty += remainQty;
            addNewRowFromCarton(dt, dr, _listCtnPoQty);
            _listCtnPoQty.Clear();
        }
        private void initCartonID(System.Data.DataTable dt, DataRow dr, double intcellQty, ICell cellPO, double currentnumber, double intfrom, double into, double countCTN)
        {

            //start 
            string drnew7 = "";

            if (_cartonid[0].Equals(_cartonid[1]))
            {
                drnew7 = _strprefix + intfrom.ToString();
                addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7, intcellQty, 0);
            }
            else if (intcellQty == _avgCurrRowQty)
            {
                if (_tmpDiffQty <= 0)
                {
                    drnew7 = _strprefix + _tmpcurrCartonID.ToString();
                    if (_tmpcurrCartonID >= into)
                    {
                        drnew7 = _strprefix + into.ToString();
                    }
                    addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7, intcellQty, 0);
                    _tmpcurrCartonID++;
                }
                else
                {
                    var drnew7Pre = _strprefix + (_tmpcurrCartonID - 1).ToString();
                    var drnew7Next = _strprefix + _tmpcurrCartonID.ToString();
                    if (_tmpcurrCartonID >= into)
                    {
                        drnew7 = _strprefix + into.ToString();
                        if (_poCountnumCell == currentnumber)
                        {
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7, intcellQty, 0);
                        }
                        else
                        {
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Pre, intcellQty - _tmpDiffQty, 0);
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Next, _tmpDiffQty, 0);
                        }
                    }
                    else
                    {
                        addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Pre, intcellQty - _tmpDiffQty, 0);
                        addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Next, _tmpDiffQty, 0);
                    }
                }
                _tmpcurrCartonID++;
                //add cartonNo
            }
            else if (intcellQty < _avgCurrRowQty)
            {
                if (_tmpDiffQty <= 0)
                {
                    drnew7 = _strprefix + _tmpcurrCartonID.ToString();
                    if (_tmpcurrCartonID >= into)
                    {
                        drnew7 = _strprefix + into.ToString();
                    }
                    addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7, intcellQty, 0);
                    _tmpDiffQty = intcellQty;
                    _tmpcurrCartonID++;
                }
                else
                {
                    var tmpnewsum = intcellQty + _tmpDiffQty;
                    double tmpPre = 0;
                    if (_tmpcurrCartonID >= into)
                    {
                        drnew7 = _strprefix + into.ToString();
                    }
                    if (tmpnewsum >= _avgCurrRowQty)
                    {
                        tmpPre = _avgCurrRowQty - _tmpDiffQty;
                        _tmpDiffQty = intcellQty - tmpPre;

                        var drnew7Pre = _strprefix + (_tmpcurrCartonID - 1).ToString();
                        var drnew7Next = _strprefix + _tmpcurrCartonID.ToString();
                        if (_tmpcurrCartonID >= into)
                        {
                            drnew7Next = _strprefix + into.ToString();

                        }
                        if (_poCountnumCell == currentnumber)
                        {
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Next, intcellQty, 0);
                        }
                        else
                        {

                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Pre, tmpPre, 0);
                            if (_tmpDiffQty > 0)
                            {
                                addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Next, _tmpDiffQty, 0);
                            }
                        }

                        _tmpcurrCartonID++;
                    }
                    else
                    {
                        var drnew7Pre = _strprefix + (_tmpcurrCartonID - 1).ToString();
                        addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Pre, intcellQty, 0);
                        _tmpDiffQty = _tmpDiffQty + intcellQty;
                    }

                }
                //change next Cartonno
            }
            else if (intcellQty > _avgCurrRowQty)
            {
                if (_tmpDiffQty <= 0)
                {
                    var tmpmod = intcellQty % _avgCurrRowQty;
                    var intDel = (intcellQty - tmpmod) / _avgCurrRowQty;
                    double currToCartonNo = _tmpcurrCartonID;

                    if (intDel > 0)
                    {
                        currToCartonNo = _tmpcurrCartonID + intDel - 1;
                        var drnew7avg = _strprefix + _tmpcurrCartonID.ToString() + '-' + currToCartonNo.ToString();
                        if (intDel == 1)
                        {
                            drnew7avg = _strprefix + _tmpcurrCartonID.ToString();
                        }

                        if (currToCartonNo >= into)
                        {
                            drnew7avg = _strprefix + _tmpcurrCartonID.ToString() + '-' + into.ToString();
                            if (_tmpcurrCartonID == into)
                            {
                                drnew7avg = _strprefix + _tmpcurrCartonID.ToString();
                            }
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7avg, _avgCurrRowQty, 0);
                            if (tmpmod > 0)
                            {
                                drnew7avg = _strprefix + into.ToString();
                                addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7avg, tmpmod, 0);
                                _tmpDiffQty = tmpmod;
                            }
                        }
                        else
                        {
                            var drnew7diff = _strprefix + (currToCartonNo + 1);
                            if (_tmpcurrCartonID == into)
                            {
                                drnew7avg = _strprefix + _tmpcurrCartonID.ToString();
                            }
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7avg, _avgCurrRowQty, 0);
                            if (tmpmod > 0)
                            {
                                addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7diff, tmpmod, 0);
                                _tmpDiffQty = tmpmod;
                            }

                        }
                        _tmpcurrCartonID = currToCartonNo + 2;
                    }
                    else
                    {
                        var drnew7avg = _strprefix + _tmpcurrCartonID.ToString();
                        if (_tmpcurrCartonID >= into)
                        {
                            drnew7avg = _strprefix + into.ToString();
                        }
                        var drnew7Pre = _strprefix + (_tmpcurrCartonID - 1).ToString();

                        _tmpDiffQty = intcellQty;

                        addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7avg, _tmpDiffQty, 0);

                        _tmpcurrCartonID++;
                    }
                }
                else
                {
                    var intcellQtyPre = _avgCurrRowQty - _tmpDiffQty;

                    var tmpintcellQty = intcellQty - intcellQtyPre;

                    var tmpmod = tmpintcellQty % _avgCurrRowQty;
                    var intDel = (tmpintcellQty - tmpmod) / _avgCurrRowQty;
                    double currToCartonNo = _tmpcurrCartonID;

                    if (intDel > 0)
                    {
                        currToCartonNo = _tmpcurrCartonID + intDel - 1;
                        var drnew7Pre = _strprefix + (_tmpcurrCartonID - 1).ToString();
                        var drnew7avg = _strprefix + _tmpcurrCartonID.ToString() + '-' + currToCartonNo.ToString();
                        if (intDel == 1)
                        {
                            drnew7avg = _strprefix + _tmpcurrCartonID.ToString();
                        }
                        if (currToCartonNo >= into)
                        {
                            drnew7avg = _strprefix + _tmpcurrCartonID.ToString() + '-' + into.ToString();
                            if (_tmpcurrCartonID == into)
                            {
                                drnew7avg = _strprefix + _tmpcurrCartonID.ToString("###");
                            }
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Pre, intcellQtyPre, 0);
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7avg, _avgCurrRowQty, 0);
                            if (tmpmod > 0)
                            {
                                drnew7avg = _strprefix + into.ToString();
                                addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7avg, tmpmod, 0);
                                _tmpDiffQty = tmpmod;
                            }
                        }
                        else
                        {
                            var drnew7diff = _strprefix + (currToCartonNo + 1);
                            if (_tmpcurrCartonID == into)
                            {
                                drnew7avg = _strprefix + _tmpcurrCartonID.ToString();
                            }
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Pre, intcellQtyPre, 0);
                            addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7avg, _avgCurrRowQty, 0);
                            if (tmpmod > 0)
                            {
                                addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7diff, tmpmod, 0);
                                _tmpDiffQty = tmpmod;

                            }

                        }
                        _tmpcurrCartonID = currToCartonNo + 2;
                    }
                    else
                    {
                        var drnew7avg = _strprefix + _tmpcurrCartonID.ToString();
                        if (_tmpcurrCartonID >= into)
                        {
                            drnew7avg = _strprefix + into.ToString();
                        }
                        var drnew7Pre = _strprefix + (_tmpcurrCartonID - 1).ToString();
                        _tmpDiffQty = intcellQty - intcellQtyPre;

                        addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7Pre, intcellQtyPre, 0);
                        addNewRowFromCarton(dt, dr, intcellQty, cellPO, drnew7avg, _tmpDiffQty, 0);

                        _tmpcurrCartonID++;
                    }
                }


            }



        }
        private void initCartonIDOld(System.Data.DataTable dt, DataRow dr, double intcell, ICell cell, double currentnumber, double intfrom, double into, double countCTN)
        {
            //po
            DataRow drnew = dt.NewRow();
            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                drnew[i] = dr[i];
            }

            drnew[1] = addrowscount;

            if (_cartonid[0].Equals(_cartonid[1]))
            {
                dr[7] = _strprefix + intfrom.ToString();
            }
            else if (_poCountnumCell == countCTN)
            {

                drnew[7] = _strprefix + (intfrom + currentnumber - 1).ToString();

            }
            else if (_poCountnumCell > countCTN)
            {

                if (countCTN > currentnumber)
                {
                    drnew[7] = _strprefix + (intfrom + currentnumber - 1).ToString();
                }
                else if (countCTN <= currentnumber)
                {
                    drnew[7] = _strprefix + (intfrom + countCTN - 1).ToString();
                    //getAvgCarton(intcell11, drnew, intfrom, into);
                }
            }
            else if (_poCountnumCell < countCTN)
            {

                if (_poCountnumCell > currentnumber)
                {
                    drnew[7] = _strprefix + (intfrom + currentnumber - 1).ToString();
                }
                else if (_poCountnumCell <= currentnumber)
                {
                    drnew[7] = _strprefix + (intfrom + _poCountnumCell - 1).ToString() + '-' + into.ToString();
                    getAvgCarton(intcell, drnew, intfrom, into);
                }
            }

            //qty
            drnew[10] = intcell;

            drnew[12] = cell.ToString().Trim();

            drnew[16] = strCartonID;
            dt.Rows.Add(drnew);
            addrowscount++;
        }

        private List<double> getAvgCarton(double intcellValue, double intfrom, double into)
        {
            List<double> tmplist = new List<double>();

            double tmpint = (into - intfrom - _poCountnumCell + 2);
            if (intcellValue < tmpint)
            {
                var tmpmsg = "Number error. PO Qty:" + intcellValue.ToString() + " < Carton Count:" + tmpint.ToString() + "\t\n Please Check the Excel File of PO and Qty,change PO position";
                cf.SetCtlTextdelegate(lbl1UploadExcelThreadMsg, tmpmsg, true, true);
                throw new Exception(tmpmsg);
                ////MessageBox.Show(tmpmsg);
                //drnew[13] = 0;
                //drnew[14] = 0;
            }
            else
            {
                double modevalue14 = intcellValue % tmpint;
                double avgList13 = (intcellValue - modevalue14) / tmpint;

                tmplist.Add(avgList13);
                tmplist.Add(modevalue14);

                return tmplist;
            }
            tmplist.Add(0);
            tmplist.Add(0);
            return tmplist;

        }
        private void getAvgCarton(double intcellValue, DataRow drnew, double intfrom, double into)
        {

            double tmpint = (into - intfrom - _poCountnumCell + 2);
            if (intcellValue < tmpint)
            {
                var tmpmsg = "Number error. PO Qty:" + intcellValue.ToString() + " < Carton Count:" + tmpint.ToString() + "\n\tCarton ID:" + drnew[7] + ",Part:" + drnew[9].ToString() + "\t\n Please Check the Excel File of PO and Qty,change PO position";
                cf.SetCtlTextdelegate(lbl1UploadExcelThreadMsg, tmpmsg, true, true);
                throw new Exception(tmpmsg);
                ////MessageBox.Show(tmpmsg);
                //drnew[13] = 0;
                //drnew[14] = 0;
            }
            else
            {
                double modevalue = intcellValue % tmpint;

                drnew[13] = (intcellValue - modevalue) / tmpint;
                drnew[14] = modevalue;
            }

        }

        public double getICellToDouble(ICell cell)
        {
            double tintcell6;
            if (cell == null)
            {
                return 0;
            }
            if (cell.CellType == CellType.String)
            {
                tintcell6 = (string.IsNullOrEmpty(cell.ToString())) ? 0 : Convert.ToDouble(cell.StringCellValue);
            }
            else if (cell.CellType == CellType.Numeric)
            {

                tintcell6 = cell.NumericCellValue;
            }
            else
            {
                return 0;
            }
            return tintcell6;
        }


        public double getICellToDouble(ICell cell, out bool num)
        {
            try
            {


                double tintcell6;
                if (cell == null)
                {
                    num = false;
                    return 0;
                }
                if (cell.CellType == CellType.String)
                {
                    tintcell6 = (string.IsNullOrEmpty(cell.ToString())) ? 0 : Convert.ToDouble(cell.StringCellValue);
                }
                else if (cell.CellType == CellType.Numeric)
                {

                    tintcell6 = cell.NumericCellValue;
                }
                else
                {
                    num = false;
                    return 0;
                }
                if (tintcell6 > 0.0)
                {
                    num = true;
                }
                else
                {
                    num = false;
                }
                return tintcell6;
            }
            catch (Exception ex)
            {
                num = false;
                return 0.0;
            }
        }


        void Init0ializeWorkbookdelegate(object objpath)
        {
            Commfunction.dinitDataGVSource me = new Commfunction.dinitDataGVSource(Init0ializeWorkbook);
            _idr_show.Invoke(me, objpath);
        }
        void initLoadExcelFile()
        {
            cf.SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "Notice: Load Excel File ......", true, true);
            _idr_show.status15toolLabelstrResult.Text = "Notice: Load Excel File ......";

            if (txt0ExcelFileUploadExcel.Text.Trim() == "")
            {
                // MessageBox.Show("没选择Excel文件， 不能完成上传操作！", "Error");
                lbl1UploadExcelThreadMsg.Text = "Error,没选择Excel， 不能完成上传操作,请选择正确的文件，谢谢！";

                btnSelectfileUploadExcel.Focus();
            }
            else
            {

                //Init0ializeWorkbook(txtExcelFileUploadExcel.Text);     
                oldtime = DateTime.Now;
                Init0ializeWorkbookdelegate(txt0ExcelFileUploadExcel.Text);
            }
        }
        private void btn3QuickUploadExcel_Click(object sender, EventArgs e)
        {
            btn3QuickUploadExcel.Enabled = false;
            addrowscount = 0;
            strCartonID = "";
            _strBatchID = "";
            _gblTTlQty = 0;
            _listPoQty = new List<ListPoQty>();
            _listCtnPoQty = new List<ListPoQty>();
            _listPoQty.Clear();
            _listCtnPoQty.Clear();

            if (!_hasrun)
            {
                getDataGV();
                _hasrun = true;

            }

            initLoadExcelFile();

            txt0ExcelFileUploadExcel.Text = "";
            btn2GoUploadToERP.Visible = true;
            btn3QuickUploadExcel.Enabled = true;
        }

        private void frmUploadExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data0set_npoi.Tables[0].Rows.Count > 0)
            {
                command.InsertCommand = cmdb.GetInsertCommand();
                command.UpdateCommand = cmdb.GetUpdateCommand();
                command.DeleteCommand = cmdb.GetDeleteCommand();
                command.Update(data0set_npoi);
                data0set_npoi.AcceptChanges();
            }
        }

        private void txt0ExcelFileUploadExcel_TextChanged(object sender, EventArgs e)
        {
            _idr_show.AcceptButton = btnCmdUpdUploadExcel;
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
            cf.EnquireByPart(data1GV1ePackingDet1UploadExcel, "plr_partno", _frmET.textBox1.Text.Trim());
        }
        void enquireByPart1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_frmET.textBox1.Text))
            {
                _frmET.textBox1.Focus();
                return;
            }
            cf.EnquireByPart(data2GV2ePackingDet1UploadExcelError, "plr_partno", _frmET.textBox1.Text.Trim());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _frmET = new frmEnterTxt(_idr_show, this);
            _frmET.button1.Click += enquireByPart1;
            _frmET.lblTitle.Text = "Part#:";
            _frmET.Text = "Enquire by Part:";
            _frmET.ShowDialog();
        }

        private void downLoad1ToExceltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cf.downLoadExcel(_dt_downToExela, lbl1UploadExcelThreadMsg, cf.nameList0vpi_report_ds(), "11DownloadExcelFlagKYCA" + _strBatchID);
        }

        private void downLoad2ToExceltoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cf.downLoadExcel(_dt_downToExela, lbl1UploadExcelThreadMsg, cf.nameList0vpi_report_ds(), "11DownloadExcelFlagKYCA" + _strBatchID);
        }

        private void btn2GoUploadToERP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt1batch_idUploadExcel.Text))
            {
                btn3QuickUploadExcel_Click(sender, e);
            }
            else
            {
                _idr_show.goToUploadToERP(txt1batch_idUploadExcel.Text.Trim());
            }
        }




        public double _cartonCount { get; set; }

        public double _ttlQtyIntcell6 { get; set; }

        public double _poCountnumCell { get; set; }

        public double _remainderCurrRow { get; set; }

        public double _avgCurrRowQty { get; set; }

        public double _tmpcurrCartonID { get; set; }

        public double _tmpDiffQty { get; set; }

        public double _gblTTlQty { get; set; }

        public List<ListPoQty> _listPoQty { get; set; }
        public List<ListPoQty> _listCtnPoQty { get; set; }
    }

}
public class ListPoQty
{
    public double _ctnIndex { get; set; }
    public string _ctnPrefix { get; set; }
    public double _ctnFrom { get; set; }
    public double _ctn { get; set; }
    public string _po { get; set; }
    public double _qty { get; set; }
    public double _ttlQty { get; set; }
    public ListPoQty()
    {

    }
    public ListPoQty(string po, double qty)
    {
        _po = po;
        _qty = qty;
        _ttlQty = qty;
    }

}
