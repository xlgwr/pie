using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FrmPIE._0API;
using PIE.DBUtility;
using System.Data.SqlClient;
using Excel;



namespace FrmPIE.frmPIE
{
    public partial class frmUploadExcel : Form
    {
        frmIDR _idr_show;
        commfunction cf;
        public frmUploadExcel(frmIDR idr)
        {
            InitializeComponent();
            _idr_show = idr;
            txtExcelFileUploadExcel.Focus();
            initwidthUploadExcel();
            cf = new commfunction();
        }

        private void frmUpload_Load(object sender, EventArgs e)
        {
            _idr_show._tuploadExcel = new Thread(UploadExcelDelegate);
            _idr_show._tuploadExcelInitGDV = new Thread(new ParameterizedThreadStart(initExcelDGVDelegate));
            initwidthUploadExcel();
        }
        private void initwidthUploadExcel()
        {
            groupBox2mstrUploadExcel.Width = groupBox0frmUploadExcel.Width - groupBox2mstrUploadExcel.Left - 5;
            groupBox3detUploadExcel.Width = groupBox2mstrUploadExcel.Width;

            groupBox3detUploadExcel.Height = groupBox0frmUploadExcel.Height - groupBox3detUploadExcel.Top - 10;

        }
        private void btnSelectfileUploadExcel_Click(object sender, EventArgs e)
        {
            txtExcelFileUploadExcel.Text = "";
            btnSelectfileUploadExcel.Enabled = false;
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                ofd.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtExcelFileUploadExcel.Text = ofd.FileName;
                }
                btnSelectfileUploadExcel.Enabled = true;
            }
            catch (Exception ex)
            {
                btnSelectfileUploadExcel.Enabled = true;
                MessageBox.Show(ex.Message, "Error");
            }
        }


        private void btnCmdUpdUploadExcel_Click(object sender, EventArgs e)
        {
            if (txtExcelFileUploadExcel.Text.Trim() == "")
            {
                // MessageBox.Show("没选择Excel文件， 不能完成上传操作！", "Error");
                lbl1UploadExcelThreadMsg.Text = "Error,没选择Excel， 不能完成上传操作,请选择正确的文件，谢谢！";
                btnSelectfileUploadExcel.Focus();
            }
            else
            {
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
            _idr_show.BeginInvoke(new MethodInvoker(UploadExcel));
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
            commfunction.dinitDataGridViewSource me = new commfunction.dinitDataGridViewSource(initExcelDGV);
            _idr_show.BeginInvoke(me, strBatchID);
        }
        public void SetCtlTextdelegate(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible)
        {
            commfunction.dSafeSetCtlText objSet = new commfunction.dSafeSetCtlText(cf.setControlText);

            _idr_show.BeginInvoke(objSet, new object[] { ctl, strMsg, enable, visible });

        }

        private void Excel_Upload(string supplier)
        {
            //Cursor = Cursors.WaitCursor;

            int row = 2;
            int col = 1;
            int intNullCount = 0, intUploadSuccess = 0;
            int intOutAffected;
            string strCTNID = "999";
            string strBatchID = "";

            string strresult = "", strUploadResult = "";

            string strpocheck = "", strpocheckErr = "";

            SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadExcel: 初始化Excel文件...", true, true);

            //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: 初始化Excel文件...";

            PIE.Model.plr_batch_mstr plr_batch_mstr_model = new PIE.Model.plr_batch_mstr();
            PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();

            SqlParameter[] parameters = {
                                            new SqlParameter("@BatchID",SqlDbType.NVarChar,11)
                                        };
            parameters[0].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_GetBatchID", parameters, out intOutAffected);
            strBatchID = parameters[0].Value != null ? parameters[0].Value.ToString() : "";
            if (string.IsNullOrEmpty(strBatchID))
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
            xBk = excel.Application.Workbooks.Open(txtExcelFileUploadExcel.Text.Trim(), missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);

            xSt = (Worksheet)xBk.Worksheets.get_Item(1);
            //try
            //{

            //取得总记录行数
            row = xSt.UsedRange.Cells.Rows.Count;
            col = xSt.UsedRange.Cells.Columns.Count;

            //取得数据范围区域（不包标题列）
            Range rag1 = xSt.Cells.get_Range("A2", "N" + row); //Batch_ID
            object[,] arryItem = (object[,])rag1.Value2;

            //batch master
            plr_batch_mstr_model.batch_id = strBatchID;
            plr_batch_mstr_model.plr_suppliers_id = supplier;
            plr_batch_mstr_model.batch_doc = "e-Packing";
            //plr_batch_mstr_model.batch_dec01 = row - 1;
            plr_batch_mstr_model.batch_void = 0;
            plr_batch_mstr_model.batch_status = "No";
            plr_batch_mstr_model.batch_cre_date = DbHelperSQL.getServerGetDate();
            plr_batch_mstr_model.batch_update_date = plr_batch_mstr_model.batch_cre_date;

            plr_batch_mstr_model.batch_user_ip = _idr_show._custip;

            var result_batch = new PIE.BLL.plr_batch_mstr().Add(plr_batch_mstr_model);

            if (!result_batch)
            {
                //MessageBox.Show("生成批号出错，请重新导入。谢谢", "Error");
                SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadExcel: Error,生成批号出错，请重新导入。", true, true);
                //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: Error,生成批号出错，请重新导入。";
                return;
            }
            //toolStripProgressBarUplad.Maximum = row - 1;
            //toolStripProgressBarUplad.Visible = true;
            //toolStripStatusLabelMessage.Text = "开始导入Excel文件...";
            SetCtlTextdelegate(lbl1UploadExcelThreadMsg, "$UploadExcel: 开始导入Excel文件...", true, true);
            //lbl1UploadExcelThreadMsg.Text = "$UploadExcel: 开始导入Excel文件... ";
            for (int i = 1; i < row; i++)
            {
                //toolStripProgressBarUplad.Value = i;
                plr_mstr_model.Batch_ID = strBatchID;
                plr_mstr_model.plr_suppliers_id = supplier;

                plr_mstr_model.packingListID = arryItem[i, 1] != null ? arryItem[i, 1].ToString().Trim() : "";
                plr_mstr_model.InvoiceID = arryItem[i, 2] != null ? arryItem[i, 2].ToString().Trim() : "";

                plr_mstr_model.plr_site = arryItem[i, 3] != null ? arryItem[i, 3].ToString().Trim() : "";
                plr_mstr_model.plr_pallet_no = arryItem[i, 4] != null ? arryItem[i, 4].ToString().Trim() : "";


                plr_mstr_model.CartonType = arryItem[i, 5] != null ? arryItem[i, 5].ToString().Trim() : "0";
                plr_mstr_model.CartonID = arryItem[i, 6] != null ? arryItem[i, 6].ToString().Trim() : "";

                plr_mstr_model.plr_po = arryItem[i, 7] != null ? arryItem[i, 7].ToString().Trim() : "";
                plr_mstr_model.plr_co = arryItem[i, 8] != null ? arryItem[i, 8].ToString().Trim() : "";
                plr_mstr_model.plr_partno = arryItem[i, 9] != null ? arryItem[i, 9].ToString().Trim() : "";

                plr_mstr_model.plr_date_code = arryItem[i, 10] != null ? arryItem[i, 10].ToString().Trim() : "";
                plr_mstr_model.plr_vend_mfgr = arryItem[i, 11] != null ? arryItem[i, 11].ToString().Trim() : "";
                plr_mstr_model.Plr_vm_partno = arryItem[i, 12] != null ? arryItem[i, 12].ToString().Trim() : "";

                plr_mstr_model.plr_carton_qty = arryItem[i, 13] != null ? Convert.ToDecimal(arryItem[i, 13].ToString().Trim()) : 0;
                plr_mstr_model.plr_qty = arryItem[i, 14] != null ? Convert.ToDecimal(arryItem[i, 14].ToString().Trim()) : 0;

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

                    plr_batch_mstr_model.batch_dec01 = intUploadSuccess;
                    plr_batch_mstr_model.batch_update_date = DateTime.Now;

                    var addRowCount = new PIE.BLL.plr_batch_mstr().Update(plr_batch_mstr_model);

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

            plr_batch_mstr_model.batch_dec01 = intUploadSuccess;
            var updatresultBatch = new PIE.BLL.plr_batch_mstr().Update(plr_batch_mstr_model);

            //toolStripStatusLabelMessage.Text = strUploadResult;
            // toolStripStatusLabelMessage.Text
            var msg = "$UploadToERP:\t BatchID: " + strBatchID + ",\t 总记录: " + (row - 1) + " 条,\t 上传:" + intUploadSuccess + "条成功，\t 失败: " + intNullCount + "条. 生成 CartonNo Success." + strresult;

            SetCtlTextdelegate(lbl1UploadExcelThreadMsg, msg, true, true);
             //lbl1UploadExcelThreadMsg.Text = msg;

            txtExcelFileUploadExcel.Text = "";
            //cf.setControlText(txtExcelFile, "", true, true);  

            //initDataGVBM0(strBatchID);
            //tab1AllPacklingList1.SelectedTab = tabPackingListDetailInfoEPacking2;
            //initDataGV_e_Packing3(strBatchID);

            //initExcelDGV(strBatchID);


            _idr_show._tuploadExcelInitGDV = new Thread(initExcelDGVDelegate);
            if (_idr_show._tuploadExcelInitGDV.ThreadState == ThreadState.Running)
            {
                _idr_show._tuploadExcelInitGDV.Abort();
            }

            if (_idr_show._tuploadExcelInitGDV.ThreadState == ThreadState.Unstarted)
            {
                _idr_show._tuploadExcelInitGDV.Start(strBatchID);
            }
            if (_idr_show._tuploadExcelInitGDV.ThreadState == ThreadState.Stopped)
            {
                _idr_show._tuploadExcelInitGDV = new Thread(initExcelDGVDelegate);
                _idr_show._tuploadExcelInitGDV.Start(strBatchID);
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
            string pathname = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"0temple\temples.xls";
            Program.OpenFolderAndSelectFile(pathname);
        }

    }
}
