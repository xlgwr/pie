using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;

using PIE.Model;
using PIE.BLL;
using PIE.DAL;
using PIE.DBUtility;
using System.Data.SqlClient;
using Excel;

using MessageBox = System.Windows.Forms.MessageBox;
using PIE.Common;
using System.Runtime.InteropServices;
using System.Threading;
using FrmPIE._0API;




namespace FrmPIE
{
    public partial class FrmPIE : Form
    {


        LogonDomain _logonDomain = new LogonDomain();
        PIE.Model.sys_user _sys_user_model = new PIE.Model.sys_user();

        public MaximunSizeFrm _maximunfrm = null;

        public bool _maxactive = false;
        public int _maxsizeToDataGridView = -1;

        public int _intVoidRightMenu1row = -1;
        public int _intVoidRightMenu2row = -1;
        public int _intVoidRightMenu3row = -1;

        public int _intVoidRightMenu1col = -1;
        public int _intVoidRightMenu2col = -1;
        public int _intVoidRightMenu3col = -1;

        int _strcurrTab = 1;
        int _strcurrMax = 1;
        int _intMeKeysDown = 0;

        string _custip = "";

        public string _strbatchidSelect = "";
        public int _strLineIDSelect = 0;
        string strSaveLabelFile = "";

        string _strsuppliers = "";

        string _strCartonID = "";

        int intPackMainSelect = 0;
        int intePackselectRowIndex = 0;


        string _newBatchid = "";
        string _newCartonid = "";

        DataSet _ds_plr_mstr3 = null;
        DataSet _dsbatch1 = null;
        DataSet _dsePacking2 = null;
        DataSet _dsCarton3 = null;


        public Thread _tuploadERP;
        public Thread _tuploadExcel;
        public Thread _tprintCtn;
        public Thread _tinitDataGVThread;
        public Thread _tDoWorkBackClorThread;
        public Thread _tinitStateVoidColorThread;



        public FrmPIE()
        {

            InitializeComponent();
        }
        public FrmPIE(LogonDomain logonDomain, PIE.Model.sys_user sys_user_model)
        {
            _logonDomain = logonDomain;
            _sys_user_model = sys_user_model;

            InitializeComponent();

        }



        //[DllImport("user32.dll")]
        //private static extern void keybd_event(byte bVk, byte bScan, long dwFlags, long dwExtraInfo);
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            if (_intMeKeysDown == 0)
            {
                if (keyData == Keys.Down)
                {

                    //keybd_event(9, 0, 0, 0);
                    SendKeys.Send("{TAB}");

                }
                if (keyData == Keys.Up)
                {
                    SendKeys.Send("+{TAB}");
                }
            }


            return base.ProcessCmdKey(ref msg, keyData);

        }
        //定义一个DateTimePicker控件
        private DateTimePicker dTimePicker = new DateTimePicker();


        private void FrmPIE_Load(object sender, EventArgs e)
        {

            try
            {
                //隐藏dTimePicker
                dTimePicker.Visible = false;

                _custip = Program.getClientIP();

                tab1AllPacklingList1.Controls.Remove(tabPackingListDetailInfoPDF3);
                tab1AllPacklingList1.Controls.Remove(tabPackingListOCR4);
                tab2AllCartonDetail2.Controls.Remove(tab2PoCheckPackingListError2);

                //定义控件dTimePicker当Text变更时委托于事件dTimePicker_TextChanged
                dTimePicker.TextChanged += new EventHandler(dTimePicker_TextChanged);

                //dataGVPackingListDetailTransferInfo3添加控件dTimePicker
                data1GV2PackingListDetailTransferInfo2.Controls.Add(dTimePicker);
                txtBatchID.Focus();


                _tuploadExcel = new Thread(UploadExcel);

                _tuploadERP = new Thread(UploadERP);

                _tprintCtn = new Thread(new ParameterizedThreadStart(PrinTXTFile));

                _tinitDataGVThread = new Thread(new ParameterizedThreadStart(initDGVdelegate));

                _tDoWorkBackClorThread = new Thread(new ParameterizedThreadStart(DoWorkdelegate));

                _tinitStateVoidColorThread = new Thread(new ParameterizedThreadStart(initStateVoidColorDelegate));


                // initDataGV();

                if (_tinitDataGVThread.ThreadState == ThreadState.Stopped || _tinitDataGVThread.ThreadState == ThreadState.Unstarted)
                {
                    CartonFromTo ctft = new CartonFromTo(0, 0, "", 1, "", 0, "");
                    _tinitDataGVThread.Start(ctft);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //事件dTimePicker_TextChanged,当dTimePicker当Text变更时触发
        private void dTimePicker_TextChanged(object sender, EventArgs e)
        {
            //把dTimePicker的Text值赋给dataGridView1选中的单元格值
            data1GV2PackingListDetailTransferInfo2.CurrentCell.Value = dTimePicker.Text;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            //当dataGridView1滚动条移动时dTimePicker控件隐藏
            dTimePicker.Visible = false;
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //当dataGridView1的列宽改变时dTimePicker控件隐藏
            dTimePicker.Visible = false;

        }

        public void initDataGV()
        {
            initDataGVBM0("");
            //initDataGV_Error5("", 1);
        }
        public void initDataGVBM0(string batchid)
        {
            try
            {
                string strwhere;
                DataSet plr_batch_mstr_ds1;
                if (string.IsNullOrEmpty(batchid))
                {
                    strwhere = "select top 50 batch_id,batch_doc,batch_status,batch_cre_date,batch_dec01,batch_user_ip FROM plr_batch_mstr";
                    plr_batch_mstr_ds1 = DbHelperSQL.Query(strwhere);

                }
                else
                {
                    strwhere = "select top 50 batch_id,batch_doc,batch_status,batch_cre_date," +
                    "batch_dec01,batch_user_ip FROM plr_batch_mstr where Batch_ID='" + batchid + "'";
                    plr_batch_mstr_ds1 = DbHelperSQL.Query(strwhere);
                    if (plr_batch_mstr_ds1 != null)
                    {
                        if (plr_batch_mstr_ds1.Tables[0].Rows.Count > 0)
                        {
                            if (plr_batch_mstr_ds1.Tables[0].Rows[0]["batch_status"].ToString().Equals("No"))
                            {
                                _strbatchidSelect = batchid;
                            }
                            else
                            {
                                _strbatchidSelect = "";
                            }
                        }
                        else
                        {
                            _strbatchidSelect = "";
                        }
                    }
                    else
                    {
                        _strbatchidSelect = "";
                    }

                }
                data1GV1PackingListMasterInfo1.DataSource = plr_batch_mstr_ds1.Tables[0].DefaultView;

                initHeaderTextPlrBatchMstr1(data1GV1PackingListMasterInfo1);

                data1GV1PackingListMasterInfo1.Refresh();
                //MessageBox.Show(dataGVPackingListMasterInfo1.Columns["Batch_ID"].HeaderText); 

                if (_intVoidRightMenu1row > 0 && data1GV1PackingListMasterInfo1.DataSource != null)
                {
                    data1GV1PackingListMasterInfo1.Rows[_intVoidRightMenu1row].Cells[0].Selected = true;
                }

                _dsbatch1 = plr_batch_mstr_ds1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //intPackMainSelect = 0;
                //dataGVPackingListMasterInfo1.Rows[intPackMainSelect].Cells[0].Selected = true;
            }

        }

        private void initHeaderTextPlrBatchMstr1(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgv.Columns[0].Frozen = true;
            dgv.Columns["Batch_ID"].HeaderText = "Batch ID";
            //dataGVPackingListMasterInfo1.Columns["plr_suppliers_id"].HeaderText = "Suppliers";
            dgv.Columns["batch_doc"].HeaderText = "Batch Type";
            dgv.Columns["batch_status"].HeaderText = "Void";//"Status";
            //dataGVPackingListMasterInfo1.Columns["batch_void"].HeaderText = "Void";

            dgv.Columns["batch_cre_date"].HeaderText = "Create Date";
            //dataGVPackingListMasterInfo1.Columns["batch_update_date"].HeaderText = "Update Date";
            //dataGVPackingListMasterInfo1.Columns["batch_cre_user"].HeaderText = "User Id";
            //dataGVPackingListMasterInfo1.Columns["batch_user_ip"].HeaderText = "Client IP";
            //dataGVPackingListMasterInfo1.Columns["batch_chr01"].HeaderText = "other";
            dgv.Columns["batch_dec01"].HeaderText = "Items Count";
            dgv.Columns["batch_user_ip"].HeaderText = "Create IP";
        }
        public void initDataGVOCR1()
        {
            DataSet ocr_mstr_ds2;

            ocr_mstr_ds2 = new PIE.BLL.OCR_mstr().GetList(100, "", "Ocr_cre_date desc");
            dataGVPackingListDetailInfo2.DataSource = ocr_mstr_ds2.Tables[0].DefaultView;


        }
        public void initDataGV_e_Packing3(string batchid)
        {
            try
            {
                string strwhere;

                if (string.IsNullOrEmpty(batchid))
                {
                    _dsePacking2 = null;
                    data1GV2PackingListDetailTransferInfo2.DataSource = null;
                    data1GV2PackingListDetailTransferInfo2.Refresh();
                    return;
                }
                else
                {
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("Batch_ID,LineID,plr_status,plr_pallet_no,InvoiceID,plr_po,packingListID,plr_partno,CartonType,");
                    strSql.Append("CartonID,plr_carton_qty,plr_qty,plr_rcp_date,plr_deli_date,carton_id_prifix,carton_id_from,carton_id_to,");
                    strSql.Append("re_mark,plr_site,plr_co,plr_date_code,plr_vend_mfgr,");
                    strSql.Append("Plr_vm_partno,plr_doc_type,plr_ttl,plr_um,plr_nw,plr_gw,");
                    strSql.Append("plr_msm,plr_cre_date,");
                    strSql.Append("plr_update_date");
                    strSql.Append(" FROM plr_mstr ");
                    strSql.Append(" where Batch_ID='" + batchid + "'");

                    _ds_plr_mstr3 = DbHelperSQL.Query(strSql.ToString());

                }
                _ds_plr_mstr3.Tables[0].AcceptChanges();
                _dsePacking2 = _ds_plr_mstr3;

                data1GV2PackingListDetailTransferInfo2.DataSource = _ds_plr_mstr3.Tables[0].DefaultView;
                initHeaderTextPlrMstr2(data1GV2PackingListDetailTransferInfo2);
                data1GV2PackingListDetailTransferInfo2.Refresh();

                if (_intVoidRightMenu2row > 0)
                {
                    data1GV2PackingListDetailTransferInfo2.Rows[_intVoidRightMenu2row].Cells[0].Selected = true;
                }
                if (_maxactive)
                {

                    _maximunfrm.dataGVMax.DataSource = _dsePacking2.Tables[0].DefaultView;
                    _maximunfrm.dataGVMax.Rows[_maximunfrm._selectedindexrow].Cells[0].Selected = true;
                    _maximunfrm.dataGVMax.Refresh();
                }



            }
            catch (Exception)
            {
                intePackselectRowIndex = 0;
                _intVoidRightMenu2row = -1;
                //dataGVPackingListDetailTransferInfo3.Rows[intePackselect].Cells[0].Selected = true;
            }



        }

        private void initHeaderTextPlrMstr2(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgv.Columns[0].Frozen = true;
            dgv.Columns[1].Frozen = true;
            dgv.Columns["Batch_ID"].HeaderText = "Batch ID";
            dgv.Columns["LineID"].HeaderText = "Line";

            dgv.Columns["plr_status"].HeaderText = "Void";

            //dgv.Columns["plr_suppliers_id"].HeaderText = "Suppliers";
            dgv.Columns["InvoiceID"].HeaderText = "Invoice ID";
            dgv.Columns["plr_po"].HeaderText = "PO#";
            dgv.Columns["packingListID"].HeaderText = "PackingListID";
            dgv.Columns["plr_partno"].HeaderText = "Part";
            dgv.Columns["plr_qty"].HeaderText = "Total/Qty";
            dgv.Columns["CartonType"].HeaderText = "Number Carton";
            dgv.Columns["CartonID"].HeaderText = "Carton ID";
            dgv.Columns["plr_carton_qty"].HeaderText = "Qty/Carton";
            dgv.Columns["carton_id_prifix"].HeaderText = "Carton Prefix";
            dgv.Columns["carton_id_from"].HeaderText = "Carton No From";
            dgv.Columns["carton_id_to"].HeaderText = "To";

            dgv.Columns["Plr_vm_partno"].HeaderText = "MFGR-Part";
            dgv.Columns["plr_site"].HeaderText = "MG";
            dgv.Columns["plr_ttl"].HeaderText = "Total";
            dgv.Columns["plr_pallet_no"].HeaderText = "Pallet No";
            dgv.Columns["plr_co"].HeaderText = "CO";
            dgv.Columns["plr_date_code"].HeaderText = "Date Code";
            dgv.Columns["plr_um"].HeaderText = "UM";
            dgv.Columns["plr_nw"].HeaderText = "Net-Wt (KG)";
            dgv.Columns["plr_gw"].HeaderText = "Gross-Wt (KG)";
            dgv.Columns["plr_msm"].HeaderText = "Measurement";



            dgv.Columns["plr_vend_mfgr"].HeaderText = "MFGR";
            dgv.Columns["plr_doc_type"].HeaderText = "Batch Type";

            dgv.Columns["re_mark"].HeaderText = "Remark";

            dgv.Columns["plr_cre_date"].HeaderText = "Create Date";
            dgv.Columns["plr_update_date"].HeaderText = "Update Date";
            //dgv.Columns["plr_cre_userid"].HeaderText = "User Id";
            //dgv.Columns["plr_user_ip"].HeaderText = "Client IP";

            dgv.Columns["plr_rcp_date"].HeaderText = "Rcp Date";
            dgv.Columns["plr_deli_date"].HeaderText = "Deli Date";


            dgv.Columns["Batch_ID"].ReadOnly = true;
            dgv.Columns["LineID"].ReadOnly = true;
            dgv.Columns["plr_status"].ReadOnly = true;

            //dgv.Columns["LineID"].Width = 20;
            dgv.Columns["plr_status"].Width = 50;
            dgv.Columns["plr_pallet_no"].Width = 50;

            dgv.Columns["plr_rcp_date"].ValueType = Type.GetType("System.DateTime");
            dgv.Columns["plr_deli_date"].ValueType = Type.GetType("System.DateTime");
        }
        public int getMaxOrMinColumnFromDataTable(System.Data.DataTable dt, string columnname, bool getmax)
        {
            int count = dt.Rows.Count;
            int max = 0;
            int min = 0;
            int result = 0;

            if (count > 0)
            {
                var dtvalueinit = dt.Rows[0][columnname];
                if (dtvalueinit != DBNull.Value)
                {
                    max = Convert.ToInt32(dtvalueinit);
                    min = max;
                }
                else
                {
                    min = 10000000;
                }

                if (getmax)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var dtvalue = dt.Rows[i][columnname];
                        if (dtvalue == DBNull.Value)
                        {
                            continue;
                        }
                        result = Convert.ToInt32(dtvalue);
                        if (result - max > 1)
                        {
                            break;
                        }
                        if (result > max)
                        {
                            max = result;
                        }
                    }
                    return max;
                }
                else
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var dtvalue = dt.Rows[i][columnname];
                        if (dtvalue == DBNull.Value)
                        {
                            continue;
                        }
                        result = Convert.ToInt32(dtvalue);
                        if (result < min)
                        {
                            min = result;
                        }
                    }
                    return min;
                }

            }
            return 0;

        }
        public void initDataGV_PDF3(string batchid)
        {
            string strwhere;
            DataSet plr_mstr_ds3;
            if (string.IsNullOrEmpty(batchid))
            {
                strwhere = "plr_doc_type='PDF'";
                plr_mstr_ds3 = new PIE.BLL.plr_mstr().GetList(100, strwhere, "Batch_ID desc, LineID, plr_cre_date desc");
            }
            else
            {
                strwhere = "Batch_ID='" + batchid + "' and plr_doc_type='PDF'";
                plr_mstr_ds3 = new PIE.BLL.plr_mstr().GetList(strwhere);
            }


            dataGVPackingListDetailPDFInfo5.DataSource = plr_mstr_ds3.Tables[0].DefaultView;
            dataGVPackingListDetailPDFInfo5.Refresh();


        }

        public void initDataGV_Tran4(string Batch_ID, int lineID)
        {
            string strwhere;
            DataSet plr_mstr_tran4;
            if (!string.IsNullOrEmpty(Batch_ID) && lineID > 0)
            {
                strwhere = "Batch_ID='" + Batch_ID + "' and LineID='" + lineID + "'";

                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                strSql.Append("Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,plr_pallet_no,CartonNo,CartonID,plr_wec_ctn,plr_po,");
                strSql.Append("plr_partno,CartonType,plr_carton_qty,plr_qty,packingListID,InvoiceID,");
                strSql.Append("plr_rcp_date,plr_deli_date,");
                strSql.Append("Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date");
                strSql.Append(" FROM plr_mstr_tran");
                if (strwhere.Trim() != "")
                {
                    strSql.Append(" where " + strwhere);
                }
                strSql.Append("  order by Wec_Ctn asc");
                plr_mstr_tran4 = DbHelperSQL.Query(strSql.ToString());//new PIE.BLL.plr_mstr_tran().GetList(strwhere);

                _dsCarton3 = plr_mstr_tran4;

                data2GV1CartonDetailInfo3.DataSource = plr_mstr_tran4.Tables[0].DefaultView;
                initHeaderTextCartonDetails3(data2GV1CartonDetailInfo3);
                data2GV1CartonDetailInfo3.Refresh();
                initWECPrintFromTo(plr_mstr_tran4);

            }
            else
            {
                initDataGV_Tran4(Batch_ID);
            }


        }
        public void initDataGV_Tran4(string Batch_ID, string CartonID)
        {
            string strwhere;
            DataSet plr_mstr_tran4;
            if (!string.IsNullOrEmpty(Batch_ID) && !string.IsNullOrEmpty(CartonID))
            {
                strwhere = "Batch_ID='" + Batch_ID + "' and CartonID='" + CartonID + "'";
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                strSql.Append("Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,plr_pallet_no,CartonNo,CartonID,plr_wec_ctn,plr_po,");
                strSql.Append("plr_partno,CartonType,plr_carton_qty,plr_qty,packingListID,InvoiceID,");
                strSql.Append("plr_rcp_date,plr_deli_date,");
                strSql.Append("Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date");
                strSql.Append(" FROM plr_mstr_tran");
                if (strwhere.Trim() != "")
                {
                    strSql.Append(" where " + strwhere);
                }

                strSql.Append(" order by Wec_Ctn asc");

                plr_mstr_tran4 = DbHelperSQL.Query(strSql.ToString());
                //plr_mstr_tran4 = new PIE.BLL.plr_mstr_tran().GetList(strwhere);
                _dsCarton3 = plr_mstr_tran4;


                data2GV1CartonDetailInfo3.DataSource = plr_mstr_tran4.Tables[0].DefaultView;
                initHeaderTextCartonDetails3(data2GV1CartonDetailInfo3);
                data2GV1CartonDetailInfo3.Refresh();
                initWECPrintFromTo(plr_mstr_tran4);
            }



        }
        public void initDataGV_Tran4(string Batch_ID)
        {
            string strwhere;
            DataSet plr_mstr_tran4 = null;

            if (!string.IsNullOrEmpty(Batch_ID))
            {
                strwhere = "Batch_ID='" + Batch_ID + "'";

                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                strSql.Append("Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,plr_pallet_no,CartonNo,CartonID,plr_wec_ctn,plr_po,");
                strSql.Append("plr_partno,CartonType,plr_carton_qty,plr_qty,packingListID,InvoiceID,");
                strSql.Append("plr_rcp_date,plr_deli_date,");
                strSql.Append("Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date");
                strSql.Append(" FROM plr_mstr_tran");
                if (strwhere.Trim() != "")
                {
                    strSql.Append(" where " + strwhere);
                }

                strSql.Append("  order by Wec_Ctn asc");
                plr_mstr_tran4 = DbHelperSQL.Query(strSql.ToString());

                data2GV1CartonDetailInfo3.DataSource = plr_mstr_tran4.Tables[0].DefaultView;

                initHeaderTextCartonDetails3(data2GV1CartonDetailInfo3);

                data2GV1CartonDetailInfo3.Refresh();
            }
            else
            {
                data2GV1CartonDetailInfo3.DataSource = plr_mstr_tran4;
                data2GV1CartonDetailInfo3.Refresh();
            }
            _dsCarton3 = plr_mstr_tran4;
            //if (_maximunfrm != null)
            //{
            //    _maximunfrm.dataGVMax.DataSource = dsCarton3.Tables[0].DefaultView;
            //    _maximunfrm.dataGVMax.Refresh();
            //    _maximunfrm.dataGVMax.Rows[_maximunfrm._selectedindex].Cells[0].Selected = true;
            //}
            initWECPrintFromTo(plr_mstr_tran4);

        }
        private void initWECPrintFromTo(DataSet ds)
        {
            if (ds != null)
            {
                var count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    txtCartonIDFrom.Text = getMaxOrMinColumnFromDataTable(ds.Tables[0], "Wec_Ctn", false).ToString();

                    txtCartonIDTo.Text = getMaxOrMinColumnFromDataTable(ds.Tables[0], "Wec_Ctn", true).ToString();

                }
            }
            else
            {
                txtCartonIDFrom.Text = "";
                txtCartonIDTo.Text = "";
            }
        }
        private void initHeaderTextCartonDetails3(DataGridView dgv)
        {
            if (dgv.Rows.Count < 0)
            {
                return;
            }
            dgv.Columns[0].Frozen = true;
            dgv.Columns[1].Frozen = true;
            dgv.Columns["Batch_ID"].HeaderText = "Batch ID";
            dgv.Columns["LineID"].HeaderText = "Line";

            dgv.Columns["Wec_Ctn"].HeaderText = "WEC Ctn ID";
            dgv.Columns["plr_status"].HeaderText = "Status";
            dgv.Columns["plr_status_msg"].HeaderText = "Msg";
            dgv.Columns["plr_wec_ctn"].HeaderText = "WEC CTN";

            dgv.Columns["plr_pallet_no"].HeaderText = "Pallet No";

            //dgv.Columns["plr_suppliers_id"].HeaderText = "Suppliers ID";
            dgv.Columns["InvoiceID"].HeaderText = "Invoice ID";
            dgv.Columns["plr_po"].HeaderText = "PO#";
            dgv.Columns["packingListID"].HeaderText = "PackingListID";
            dgv.Columns["plr_partno"].HeaderText = "Part";
            dgv.Columns["plr_qty"].HeaderText = "Total/QTY";
            dgv.Columns["CartonType"].HeaderText = "Number Carton";
            dgv.Columns["CartonID"].HeaderText = "Carton ID";
            dgv.Columns["plr_carton_qty"].HeaderText = "Qty/Carton";
            dgv.Columns["carton_id_prifix"].HeaderText = "Carton Prefix";


            dgv.Columns["re_mark"].HeaderText = "Remark";
            dgv.Columns["Plr_vm_partno"].HeaderText = "MFGR-Part";
            dgv.Columns["plr_rcp_date"].HeaderText = "Rcp Date";
            dgv.Columns["plr_deli_date"].HeaderText = "Deli Date";

            dgv.Columns["plr_cre_date"].HeaderText = "Create Date";
            //dgv.Columns["plr_update_date"].HeaderText = "Update Date";
            //dgv.Columns["plr_cre_userid"].HeaderText = "User Id";
            //dgv.Columns["plr_user_ip"].HeaderText = "Client IP";

            //dgv.Columns["LineID"].Width = 20;
            dgv.Columns["plr_status"].Width = 50;
            dgv.Columns["plr_pallet_no"].Width = 50;
        }
        public void initDataGV_Error5(string batchid, int lineID)
        {
            string strwhere;
            DataSet plr_mstr_error5;
            if (!string.IsNullOrEmpty(batchid) && lineID > 0)
            {
                strwhere = "Batch_ID='" + batchid + "' and LineID='" + lineID + "'";
                plr_mstr_error5 = new PIE.BLL.plr_mstr_err().GetList(strwhere);
                data2GV1CartonDetailInfo3.DataSource = plr_mstr_error5.Tables[0].DefaultView;
                data2GV1CartonDetailInfo3.Refresh();
            }
            else
            {
                plr_mstr_error5 = new PIE.BLL.plr_mstr_err().GetAllList();
                dataGVPOCheckPackingListError7.DataSource = plr_mstr_error5.Tables[0].DefaultView;
                dataGVPOCheckPackingListError7.Refresh();
            }


        }
        private void initWidth()
        {
            tab1AllPacklingList1.Width = Width - tab1AllPacklingList1.Left - 28;
            tab2AllCartonDetail2.Width = tab1AllPacklingList1.Width;

            groupBox1.Width = tab1AllPacklingList1.Width - groupBox1.Left - 10;

            groupBox2.Width = groupBox1.Width;
            groupBox3.Width = groupBox1.Width;
            groupBox4.Width = groupBox1.Width;
            groupBox5.Width = groupBox1.Width;
            groupBox6.Width = groupBox1.Width;
            groupBox7.Width = groupBox1.Width;

            data2GV1CartonDetailInfo3.Width = groupBox1.Width - data2GV1CartonDetailInfo3.Left - 5;
            dataGVPackingListDetailInfo2.Width = data2GV1CartonDetailInfo3.Width;
            data1GV2PackingListDetailTransferInfo2.Width = data2GV1CartonDetailInfo3.Width;
            data1GV1PackingListMasterInfo1.Width = data2GV1CartonDetailInfo3.Width;
            dataGVPackingListDetailPDFInfo5.Width = data2GV1CartonDetailInfo3.Width;
            dataGVPOCheckPackingListError7.Width = data2GV1CartonDetailInfo3.Width;

            tab2AllCartonDetail2.Height = Height - tab2AllCartonDetail2.Top - 50;
            groupBox4.Height = tab2AllCartonDetail2.Height - groupBox4.Top - 30;
            data2GV1CartonDetailInfo3.Height = groupBox4.Height - data2GV1CartonDetailInfo3.Top - 10;
            groupBox7.Height = groupBox4.Height;
            dataGVPOCheckPackingListError7.Height = data2GV1CartonDetailInfo3.Height;

            // toolStripProgressBarUplad.Width = statusStrip1.Width;// toolStripStatusLabelMessage.Width;

        }

        private void FrmPIE_SizeChanged(object sender, EventArgs e)
        {
            initWidth();
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            intPackMainSelect = 0;
            _intVoidRightMenu1row = -1;
            _intVoidRightMenu2row = -1;
            _intVoidRightMenu3col = -1;
            try
            {
                if (string.IsNullOrEmpty(txtBatchID.Text.Trim()))
                {
                    toolStripStatusLabelMessage.Text = "Error1: BatchID 为空";
                    txtBatchID.Focus();
                    return;

                }

                _strsuppliers = txtBatchID.Text.Trim();

                initDataGVBM0(txtBatchID.Text.Trim());
                initDataGV_Tran4(_strbatchidSelect);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGVPackingListDetailInfo2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PIE.Model.OCR_mstr ocr_mstr_model = new PIE.Model.OCR_mstr();
                DataSet plr_mstr_ds;
                DataSet get_pl_info_Specify_proc_ds = new DataSet();
                var wherestr = "";
                if (e.RowIndex >= 0)
                {

                    ocr_mstr_model.Ocr_BatchID = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_BatchID"].Value.ToString().Trim();
                    ocr_mstr_model.Ocr_PackinglistID = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_PackinglistID"].Value.ToString().Trim();
                    ocr_mstr_model.Ocr_lineID = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_lineID"].Value.ToString().Trim();
                    ocr_mstr_model.Ocr_ctnID = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_ctnID"].Value.ToString().Trim();
                    ocr_mstr_model.Ocr_po = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_po"].Value.ToString().Trim();
                    //MessageBox.Show(ocr_mstr_model.Ocr_BatchID+","+ocr_mstr_model.Ocr_lineID+","+ ocr_mstr_model.Ocr_ctnID+","+ocr_mstr_model.Ocr_po);
                    wherestr = "Batch_ID='" + ocr_mstr_model.Ocr_BatchID + "' and LineID='" + ocr_mstr_model.Ocr_lineID + "' " +
                        "and PackinglistID='" + ocr_mstr_model.Ocr_PackinglistID + "' and CartonID = '" + ocr_mstr_model.Ocr_ctnID + "' " +
                        "and plr_po='" + ocr_mstr_model.Ocr_po + "'";

                    plr_mstr_ds = new PIE.BLL.plr_mstr().GetList(wherestr);
                    data1GV2PackingListDetailTransferInfo2.DataSource = plr_mstr_ds.Tables[0].DefaultView;

                    SqlParameter[] parameters = {
                                                new SqlParameter("@BatchID",SqlDbType.VarChar,20),
                                                new SqlParameter("@InvoiceID",SqlDbType.VarChar,20),
                                                new SqlParameter("@po_nbr",SqlDbType.VarChar,50)

                                            };
                    parameters[0].Value = ocr_mstr_model.Ocr_BatchID;
                    parameters[1].Value = ocr_mstr_model.Ocr_PackinglistID;
                    parameters[2].Value = ocr_mstr_model.Ocr_po;
                    get_pl_info_Specify_proc_ds = DbHelperSQL.RunProcedure("gen_pl_info_Specify", parameters, "Plr_collect_mstr");

                    data2GV1CartonDetailInfo3.DataSource = get_pl_info_Specify_proc_ds.Tables["Plr_collect_mstr"].DefaultView;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void dataGVPackingListDetailInfo2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PIE.Model.OCR_mstr ocr_mstr_model = new PIE.Model.OCR_mstr();
                ocr_mstr_model.Ocr_BatchID = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_BatchID"].Value.ToString().Trim();
                ocr_mstr_model.Ocr_PackinglistID = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["ocr_mstr_model.Ocr_PackinglistID"].Value.ToString().Trim();

                ocr_mstr_model.Ocr_lineID = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_lineID"].Value.ToString().Trim();
                ocr_mstr_model.Ocr_ctnID = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_ctnID"].Value.ToString().Trim();
                ocr_mstr_model.Ocr_po = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_po"].Value.ToString().Trim();
                ocr_mstr_model.Ocr_partno = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_partno"].Value.ToString().Trim();
                ocr_mstr_model.Ocr_qty = dataGVPackingListDetailInfo2.Rows[e.RowIndex].Cells["Ocr_qty"].Value.ToString().Trim();

                var frmplMain_show = new frmplMain(ocr_mstr_model, this);

                frmplMain_show.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCmdGenPlrInfo_Click(object sender, EventArgs e)
        {
            //if (Plrmstr_proc() == 0)
            //{
            //    MessageBox.Show("packing list info transference success.", "Success");
            //}

            //Gen_plrctnInfo();
            //ctnlabel_print();
        }


        private int Plrmstr_proc()
        {
            try
            {
                int rowsAffected;
                SqlParameter[] parameters = {
                                                new SqlParameter("@result",SqlDbType.Int)
                                            };
                parameters[0].Direction = ParameterDirection.Output;
                DbHelperSQL.RunProcedure("sp_plr_mstr_tran", parameters, out rowsAffected);
                return Convert.ToInt16(parameters[0].Value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
                return 1;
            }
        }
        private void Gen_plrctnInfo()
        {

            DataSet plr_mstr_ds3;
            DataSet pl_info_ds4;
            DataSet plr_batch_mstr_ds1;
            DataSet ocr_mstr_ds2;


            var strwhere_plr_mstr = "plr_cre_date>=dateadd(day, -1, getdate())";
            var strwhere_plr_batch_mstr_ds = "batch_cre_date >=dateadd(day, -1, getdate())";

            plr_mstr_ds3 = new PIE.BLL.plr_mstr().GetList(strwhere_plr_mstr);
            SqlParameter[] parameters = { };
            pl_info_ds4 = DbHelperSQL.RunProcedure("gen_pl_info", parameters, "pl_info");

            data1GV2PackingListDetailTransferInfo2.DataSource = plr_mstr_ds3.Tables[0].DefaultView;
            data2GV1CartonDetailInfo3.DataSource = pl_info_ds4.Tables["pl_info"].DefaultView;

            plr_batch_mstr_ds1 = new PIE.BLL.plr_batch_mstr().GetList(strwhere_plr_batch_mstr_ds);
            data1GV1PackingListMasterInfo1.DataSource = plr_batch_mstr_ds1.Tables[0].DefaultView;

            ocr_mstr_ds2 = new PIE.BLL.OCR_mstr().GetList(500, "", "Ocr_cre_date desc");
            dataGVPackingListDetailInfo2.DataSource = ocr_mstr_ds2.Tables[0].DefaultView;


        }

        private void btnSelectfile_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtSuppliersID.Text))
            //{
            //    //MessageBox.Show("Please Enter the Suppliers Id", "Notice");
            //    toolStripStatusLabelMessage.Text = "Notice: Please Enter the Suppliers Id";
            //    txtSuppliersID.Focus();
            //    txtSuppliersID.BackColor = Color.Yellow;
            //    return;
            //}
            _strsuppliers = txtSuppliersID.Text.Trim();

            txtExcelFile.Text = "";
            btnSelectfile.Enabled = false;
            try
            {
                openFileDialog1.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtExcelFile.Text = openFileDialog1.FileName;
                }
                btnSelectfile.Enabled = true;
            }
            catch (Exception ex)
            {
                btnSelectfile.Enabled = true;
                MessageBox.Show(ex.Message, "Error");
            }

        }
        public void setControlText(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible)
        {
            ctl.Text = strMsg;
            ctl.Enabled = enable;
            ctl.Visible = visible;


        }
        public void setDataGVds(System.Windows.Forms.DataGridView ctl, DataSet ds, int selectIndexRow, int intselectIndexCol)
        {
            ctl.DataSource = ds.Tables[0].DefaultView;
            ctl.Refresh();
            ctl.Rows[selectIndexRow].Cells[intselectIndexCol].Selected = true;

        }
        public void setToolText(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible)
        {
            ctl.Text = strMsg;
            ctl.Enabled = enable;
            ctl.Visible = visible;
        }
        public void InitDGV(object ctftobj)
        {
            CartonFromTo ctft = (CartonFromTo)ctftobj;
            var dgvIndex = ctft._dgvNumber;
            var dgv = ctft._dgv;
            var batchid = ctft._batchID;
            var lineid = ctft._lineID;
            var cartonid = ctft._cartonID;

            if (dgvIndex == 1)
            {
                initDataGVBM0(batchid);
            }
            else if (dgvIndex == 2)
            {
                initDataGV_e_Packing3(batchid);
            }
            else if (dgvIndex == 3)
            {
                initDataGV_Tran4(batchid);
            }
            else if (dgvIndex == 4)
            {
                initDataGV_Tran4(batchid, lineid);
            }
            else if (dgvIndex == 5)
            {
                initDataGV_Tran4(batchid, cartonid);
            }
        }
        public delegate void SafeSetCtlText(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible);
        public delegate void SafeSetDataGVds(System.Windows.Forms.DataGridView ctl, DataSet ds, int selectIndexRow, int intselectIndexCol);
        public delegate void SafeSetToolText(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible);
        public delegate void initDataGridViewSource(object ctftobj);

        public void initDGVdelegate(object ctftobj)
        {
            CartonFromTo ctft = (CartonFromTo)ctftobj;
            initDataGridViewSource initdgv = new initDataGridViewSource(InitDGV);
            BeginInvoke(initdgv, ctft);

        }
        public void SetToolTextdelegate(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible)
        {
            SafeSetToolText objSet = new SafeSetToolText(setToolText);

            BeginInvoke(objSet, new object[] { ctl, strMsg, enable, visible });
        }


        public void SetCtlTextdelegate(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible)
        {
            SafeSetCtlText objSet = new SafeSetCtlText(setControlText);

            BeginInvoke(objSet, new object[] { ctl, strMsg, enable, visible });
        }
        public void SetDataGridViewdelegate(System.Windows.Forms.DataGridView ctl, DataSet ds, int selectIndexRow, int intselectIndexCol)
        {
            SafeSetDataGVds objSet = new SafeSetDataGVds(setDataGVds);

            BeginInvoke(objSet, new object[] { ctl, ds, selectIndexRow, intselectIndexCol });
        }
        private void UploadExcel()
        {
            // btnCmdUpd.Enabled = false;
            SetCtlTextdelegate(btnCmdUpd, "Uploading...", false, true);
            try
            {
                Excel_Upload(_strsuppliers);
            }
            catch (Exception ex)
            {

                // _tuploadExcel.Abort();
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                SetCtlTextdelegate(btnCmdUpd, "&Upload", true, true);
            }
        }
        private void btnCmdUpd_Click(object sender, EventArgs e)
        {
            //

            if (txtExcelFile.Text.Trim() == "")
            {
                // MessageBox.Show("没选择Excel文件， 不能完成上传操作！", "Error");
                toolLabel2ThreadMsg.Text = "Error,没选择Excel文件， 不能完成上传操作！";
                btnSelectfile.Focus();
            }
            else
            {
                if (_tuploadExcel.ThreadState == ThreadState.Running)
                {
                    _tuploadExcel.Abort();
                }

                if (_tuploadExcel.ThreadState == ThreadState.Unstarted)
                {
                    _tuploadExcel.Start();
                }
                if (_tuploadExcel.ThreadState == ThreadState.Stopped)
                {
                    _tuploadExcel = new Thread(UploadExcel);
                    _tuploadExcel.Start();
                }
            }


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

            //toolStripStatusLabelMessage.Text = "初始化Excel文件...";
            SetToolTextdelegate(toolLabel2ThreadMsg, "$UploadExcel: 初始化Excel文件...", true, true);

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
                //toolStripStatusLabelMessage.Text = "Error,生成BatchID,出错，无法导入。";
                SetToolTextdelegate(toolLabel2ThreadMsg, "$UploadExcel: Error,生成BatchID,出错，无法导入。", true, true);
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
                //toolStripStatusLabelMessage.Text = "Error,不能访问Excel";
                SetToolTextdelegate(toolLabel2ThreadMsg, "$UploadExcel: Error,不能访问Excel。", true, true);
                return;
            }
            excel.Visible = false;
            excel.UserControl = true;
            //只读的形工打开Excel文件
            xBk = excel.Application.Workbooks.Open(txtExcelFile.Text.Trim(), missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);

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

            plr_batch_mstr_model.batch_user_ip = _custip;

            var result_batch = new PIE.BLL.plr_batch_mstr().Add(plr_batch_mstr_model);

            if (!result_batch)
            {
                //MessageBox.Show("生成批号出错，请重新导入。谢谢", "Error");
                //toolStripStatusLabelMessage.Text = "Error,生成批号出错，请重新导入。谢谢";
                SetToolTextdelegate(toolLabel2ThreadMsg, "$UploadExcel: Error,生成批号出错，请重新导入。", true, true);
                return;
            }
            //toolStripProgressBarUplad.Maximum = row - 1;
            //toolStripProgressBarUplad.Visible = true;
            //toolStripStatusLabelMessage.Text = "开始导入Excel文件...";
            SetToolTextdelegate(toolLabel2ThreadMsg, "$UploadExcel: 开始导入Excel文件...", true, true);
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
                plr_mstr_model.plr_user_ip = _custip;

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
                    SetToolTextdelegate(toolLabel2ThreadMsg, "$UploadToERP: 第:" + intUploadSuccess + "条上传成功", true, true);

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

            strUploadResult = intNullCount > 0 ? "BatchID: " + strBatchID + "\n\n总记录: " + (row - 1) + " 条,\t上传:" + intUploadSuccess + "条成功，\t失败: " + intNullCount + " 条\n未上传记录：\n" + strresult + "\n取出未上的的记录，查看后重新上传。谢谢。\n" : "BatchID:  " + strBatchID + "\n 总记录:" + (row - 1) + "条,\t上传:" + intUploadSuccess + "条成功，\t失败:" + intNullCount + "条.\n";

            plr_batch_mstr_model.batch_dec01 = intUploadSuccess;
            var updatresultBatch = new PIE.BLL.plr_batch_mstr().Update(plr_batch_mstr_model);

            //toolStripStatusLabelMessage.Text = strUploadResult;
            // toolStripStatusLabelMessage.Text
            var msg = "$UploadToERP:\t BatchID: " + strBatchID + ",\t 总记录: " + (row - 1) + " 条,\t 上传:" + intUploadSuccess + "条成功，\t 失败: " + intNullCount + "条," + strresult;

            SetToolTextdelegate(toolLabel2ThreadMsg, msg, true, true);

            SetCtlTextdelegate(txtExcelFile, "", true, true);

            //txtExcelFile.Text = "";
            //initDataGVBM0(strBatchID);
            //tab1AllPacklingList1.SelectedTab = tabPackingListDetailInfoEPacking2;
            //initDataGV_e_Packing3(strBatchID);
            CartonFromTo ctft = new CartonFromTo(0, 0, "", 1, "", 0, "");
            InitDGV(ctft);
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
        private bool isNumber(System.Windows.Forms.TextBox tb)
        {
            if (!PageValidate.IsNumber(tb.Text))
            {
                tb.Focus();
                tb.SelectAll();
                toolStripStatusLabelMessage.Text = "Notice:请输入正确的数字，谢谢.";
                return false;
            }
            return true;
        }

        public void PrinTXTFile(object cartonfromto)
        {
            CartonFromTo _cartonfromto = (CartonFromTo)cartonfromto;

            int intPrintCount = 0;
            int intPrintErrorCount = 0;
            int limitCount = 5;

            string strWhere = "";
            string resultmsg = "";
            string messageBox = "";
            string messageBoxError = "";

            decimal wec_ctn_Fr = _cartonfromto._wec_ctn_Fr;
            decimal wec_ctn_To = _cartonfromto._wec_ctn_To;
            string print_Type = _cartonfromto._print_Type;
            string print_port = _cartonfromto._print_port;

            StringBuilder strtxt = new StringBuilder();


            //btnPrint.Enabled = false;
            SetCtlTextdelegate(btnPrint, "Print...", false, true);
            SetToolTextdelegate(toolLabel2ThreadMsg, "Printing ......", true, true);

            while (wec_ctn_Fr <= wec_ctn_To)
            {

                strWhere = "Wec_Ctn='" + wec_ctn_Fr + "'";

                List<PIE.Model.plr_mstr_tran> plr_mstr_tran_list = new PIE.BLL.plr_mstr_tran().GetModelList(strWhere);
                int listcount = plr_mstr_tran_list.Count;
                if (listcount > 0)
                {

                    if (print_Type.Equals("ZPL"))
                    {
                        int x = 13;
                        int y = 34;
                        int xoff = 0;
                        int yoff = 31;

                        #region zpl 2824
                        strtxt.AppendLine(@"^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR2,2~SD15^JUS^LRN^CI0^XZ");

                        strtxt.AppendLine("^XA");
                        strtxt.AppendLine("^MMT");
                        strtxt.AppendLine("^LL0406");
                        strtxt.AppendLine("^PW448");
                        strtxt.AppendLine("^LS0");

                        int totoal = 0;
                        string strSJ = "";

                        for (int i = 0; i < listcount; i++)
                        {
                            totoal = totoal + Convert.ToInt32(plr_mstr_tran_list[i].plr_qty);
                            if (plr_mstr_tran_list[i].plr_chr02.ToString().ToLower().Equals("yes"))
                            {
                                strSJ = plr_mstr_tran_list[i].plr_chr02.ToString();
                            }
                            if (i >= limitCount)
                            {
                                continue;
                            }

                            if (plr_mstr_tran_list[i].plr_chr01.Equals("A"))
                            {
                                //partno
                                strtxt.AppendLine(@"^FT13," + (y + (i * yoff)).ToString() + @"^A0N,20,19^FH\^FD" + plr_mstr_tran_list[i].plr_partno + "  " + plr_mstr_tran_list[i].plr_carton_qty.ToString() + "  A^FS");
                            }
                            else
                            {
                                strtxt.AppendLine(@"^FT13," + (y + (i * yoff)).ToString() + @"^A0N,20,19^FH\^FD" + plr_mstr_tran_list[i].plr_partno + "  " + plr_mstr_tran_list[i].plr_carton_qty.ToString() + " ^FS");

                            }


                        }
                        if (listcount > limitCount)
                        {
                            strtxt.AppendLine(@"^FT13,189^A0N,21,33^FH\^FD.........^FS");
                        }
                        strtxt.AppendLine(@"^FT13,224^A0N,23,24^FH\^FDCnt: " + listcount.ToString() + "/ TTL: " + totoal.ToString() + "^FS");


                        strtxt.AppendLine(@"^FT309,81^A0N,56,55^FH\^FD" + plr_mstr_tran_list[0].CartonID + "^FS");
                        strtxt.AppendLine(@"^FT316,139^A0N,28,28^FH\^FD" + plr_mstr_tran_list[0].plr_vend_mfgr + "^FS");

                        if (!string.IsNullOrEmpty(strSJ))
                        {
                            strtxt.AppendLine(@"^FT309,81^A0N,56,55^FH\^FD * " + plr_mstr_tran_list[0].plr_co + "^FS");
                        }
                        else
                        {
                            strtxt.AppendLine(@"^FT309,81^A0N,56,55^FH\^FD" + plr_mstr_tran_list[0].plr_co + "^FS");

                        }
                        strtxt.AppendLine(@"^BY4,3,103^FT25,351^BCN,,Y,N");
                        strtxt.AppendLine(@"^FD>;" + plr_mstr_tran_list[0].plr_wec_ctn + "^FS");

                        strtxt.AppendLine("^PQ1,0,1,Y^XZ");
                        #endregion
                    }
                    else if (print_Type.Equals("TEC"))
                    {
                        int x = 0;
                        int y = 60;
                        int xoff = 0;
                        int yoff = 35;
                        #region TEC
                        strtxt.AppendLine("{D0410,0762,0380|}");
                        strtxt.AppendLine("{C|}");
                        strtxt.AppendLine("{U2;0030|}");
                        strtxt.AppendLine("{AX;+000,+000,+00|}");
                        strtxt.AppendLine("{AY;+10,0|}");
                        int totoal = 0;
                        string strSJ = "";
                        for (int i = 0; i < listcount; i++)
                        {
                            totoal = totoal + Convert.ToInt32(plr_mstr_tran_list[i].plr_qty);
                            if (plr_mstr_tran_list[i].plr_chr02.ToString().ToLower().Equals("yes"))
                            {
                                strSJ = plr_mstr_tran_list[i].plr_chr02.ToString();
                            }
                            if (i >= limitCount)
                            {
                                continue;
                            }
                            //partno
                            strtxt.AppendLine(@"{PC" + i.ToString("000") + ";0063," + (y + yoff * i).ToString("0000") + ",05,05,B,00,B|}");
                            strtxt.AppendLine(@"{RC" + i.ToString("000") + ";" + plr_mstr_tran_list[i].plr_partno + "|}");
                            //number/qty
                            strtxt.AppendLine(@"{PC" + (i + 50).ToString("000") + ";0365," + (y + yoff * i).ToString("0000") + ",05,05,B,00,B|}");
                            strtxt.AppendLine(@"{RC" + (i + 50).ToString("000") + ";" + Convert.ToInt32(plr_mstr_tran_list[i].plr_carton_qty).ToString() + "|}");
                            //ABC/
                            strtxt.AppendLine(@"{PC" + (i + 100).ToString("000") + ";0480," + (y + yoff * i).ToString("0000") + ",05,05,B,00,B|}");
                            if (plr_mstr_tran_list[i].plr_chr01.Equals("A"))
                            {
                                strtxt.AppendLine(@"{RC" + (i + 100).ToString("000") + ";" + plr_mstr_tran_list[i].plr_chr01 + "|}");
                            }
                            else
                            {
                                strtxt.AppendLine(@"{RC" + (i + 100).ToString("000") + "; |}");
                            }


                        }
                        if (listcount > limitCount)
                        {
                            strtxt.AppendLine(@"{PC005;0065,0300,07,07,D,00,B|}");
                            // strtxt.AppendLine(@"{RC005;more " + limitCount + " to ..............|}");
                            strtxt.AppendLine(@"{RC005;.......................|}");
                        }

                        strtxt.AppendLine(@"{PC" + (listcount + 1).ToString("000") + ";0063,0355,05,05,B,00,B|}");
                        strtxt.AppendLine(@"{RC" + (listcount + 1).ToString("000") + ";CNT:" + listcount.ToString() + ", TTL: " + totoal.ToString() + "|}");


                        strtxt.AppendLine(@"{PC" + (listcount + 10).ToString("000") + ";0560,0080,05,05,M,00,B|}");
                        strtxt.AppendLine(@"{RC" + (listcount + 10).ToString("000") + ";" + plr_mstr_tran_list[0].CartonID + "|}");
                        strtxt.AppendLine(@"{PC" + (listcount + 20).ToString("000") + ";0560,0140,05,05,D,00,B|}");
                        strtxt.AppendLine(@"{RC" + (listcount + 20).ToString("000") + ";" + plr_mstr_tran_list[0].plr_vend_mfgr + "|}");


                        if (!string.IsNullOrEmpty(strSJ))
                        {
                            strtxt.AppendLine(@"{PC" + (listcount + 30).ToString("000") + ";0520,0200,05,05,D,00,B|}");
                            strtxt.AppendLine(@"{RC" + (listcount + 30).ToString("000") + "; * |}");
                            strtxt.AppendLine(@"{PC" + (listcount + 35).ToString("000") + ";0560,0200,05,05,D,00,B|}");
                            strtxt.AppendLine(@"{RC" + (listcount + 35).ToString("000") + "; " + plr_mstr_tran_list[0].plr_co + "|}");
                        }
                        else
                        {
                            strtxt.AppendLine(@"{PC" + (listcount + 30).ToString("000") + ";0560,0200,05,05,D,00,B|}");
                            strtxt.AppendLine(@"{RC" + (listcount + 30).ToString("000") + ";" + plr_mstr_tran_list[0].plr_co + "|}");

                        }
                        strtxt.AppendLine("{XB01;0450,0230,9,3,02,0,0105,+0000000000,000,1,00|}");
                        strtxt.AppendLine("{RB01;>8" + plr_mstr_tran_list[0].plr_wec_ctn + "|}");

                        strtxt.AppendLine("{XS;I,0001,0002C3200|}");
                        strtxt.AppendLine("{U1;0030|}");
                        #endregion
                    }
                    SetToolTextdelegate(toolLabel2ThreadMsg, "$Print 生成第" + wec_ctn_Fr.ToString() + "条打印文件Success.", true, true);
                }
                else
                {
                    intPrintErrorCount++;
                    messageBoxError = messageBoxError + wec_ctn_Fr.ToString() + ",\t";

                }
                wec_ctn_Fr++;
                intPrintCount++;
            }
            string strfromto = txtCartonIDFrom.Text + "-" + txtCartonIDTo.Text;
            if (intPrintErrorCount == intPrintCount)
            {
                SetToolTextdelegate(toolStripStatusLabelMessage, "$Print: 无" + strfromto + "的记录。", true, true);
                SetCtlTextdelegate(btnPrint, "&Print", true, true);
                SetToolTextdelegate(toolLabel2ThreadMsg, "$Print: Printing End", true, true);
                return;
            }
            else if (intPrintErrorCount > 0)
            {

                SetToolTextdelegate(toolStripStatusLabelMessage, "$Print: 无" + messageBoxError + "的记录。", true, true);
            }
            string strprefix = print_Type;
            if (checkBox1.Checked)
            {

                strSaveLabelFile = strprefix + txtCartonIDFrom.Text.Trim() + "-" + wec_ctn_To + ".txt";
                var returnresult = Xprint.XPrint.WriteTxT(strSaveLabelFile, strtxt);

                messageBox = "\tSuccess: 总打印：" + intPrintCount + "条记录。TXT文件存于: \n" + returnresult;

                if (!string.IsNullOrEmpty(returnresult))
                {

                    resultmsg = "Notice: 打印 " + strprefix + txtCartonIDFrom.Text.Trim() + "-" + wec_ctn_To;
                    var dialogbutton = MessageBox.Show(messageBox + " Success.\n\t是否打印些文件？", "Notice:Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dialogbutton == DialogResult.Yes)
                    {
                        if (Xprint.XPrint.Print(strtxt.ToString(), print_port))
                        {
                            //toolStripStatusLabelMessage.Text = resultmsg + " 成功。";
                            SetToolTextdelegate(toolLabel2ThreadMsg, resultmsg + " 成功。", true, true);
                        }
                        else
                        {
                            //toolStripStatusLabelMessage.Text = resultmsg + " 。";
                            SetToolTextdelegate(toolLabel2ThreadMsg, resultmsg + " 失败,本地打印端口:" + print_port + "打开失败或打印机未就绪。", true, true);
                        }
                    }
                    else
                    {

                        SetToolTextdelegate(toolLabel2ThreadMsg, messageBox + " 成功。", true, true);

                    }
                }
                else
                {
                    MessageBox.Show(messageBox + " Fail.");
                }

            }
            else
            {
                resultmsg = "Notice: 打印 " + strprefix + txtCartonIDFrom.Text.Trim() + "-" + wec_ctn_To;

                if (Xprint.XPrint.Print(strtxt.ToString(), print_port))
                {
                    //toolStripStatusLabelMessage.Text = resultmsg + " 成功。";
                    SetToolTextdelegate(toolLabel2ThreadMsg, resultmsg + " 成功。", true, true);
                }
                else
                {
                    //toolStripStatusLabelMessage.Text = resultmsg + " 。";
                    SetToolTextdelegate(toolLabel2ThreadMsg, resultmsg + " 失败,本地打印端口:" + print_port + "打开失败或打印机未就绪。", true, true);
                }
            }

            //btnPrint.Enabled = true;
            SetCtlTextdelegate(btnPrint, "&Print", true, true);

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {


            Decimal wec_ctn_Fr = 0, wec_ctn_To = 0;

            if (!isNumber(txtCartonIDFrom))
            {
                return;
            }
            if (!isNumber(txtCartonIDTo))
            {
                return;
            }

            wec_ctn_Fr = Convert.ToDecimal(txtCartonIDFrom.Text.Trim());

            wec_ctn_To = Convert.ToDecimal(txtCartonIDTo.Text.Trim());

            if (wec_ctn_Fr > wec_ctn_To)
            {
                MessageBox.Show("Wongs CartonID From must be less than To.");
                txtCartonIDFrom.Focus();
                return;
            }

            CartonFromTo cft = new CartonFromTo(wec_ctn_Fr, wec_ctn_To, cmbPrinter.Text, cmbPort.Text);
            if (_tprintCtn.ThreadState == ThreadState.Running)
            {
                _tprintCtn.Abort();
            }

            if (_tprintCtn.ThreadState == ThreadState.Unstarted)
            {

                _tprintCtn.Start(cft);
            }

            if (_tprintCtn.ThreadState == ThreadState.Stopped)
            {
                //
                _tprintCtn = new Thread(new ParameterizedThreadStart(PrinTXTFile));
                _tprintCtn.Start(cft);
            }


        }

        private void dataGVPackingListDetailInfo2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tab1AllPacklingList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabDataGVinit();
        }

        private void Reflash_Click(object sender, EventArgs e)
        {
            tabDataGVinit();
        }

        private void tabDataGVinit()
        {
            if (!_maxactive)
            {
                if (data1GV2PackingListDetailTransferInfo2.DataSource != null)
                {
                    dataNewRow(data1GV2PackingListDetailTransferInfo2, _ds_plr_mstr3);

                }
                if (tab1AllPacklingList1.SelectedTab == tabPackingListMasterInfo1)
                {

                    initDataGVBM0("");
                }
                else if (tab1AllPacklingList1.SelectedTab == tabPackingListDetailInfoEPacking2)
                {
                    initDataGV_e_Packing3(_strbatchidSelect);
                }
                else if (tab1AllPacklingList1.SelectedTab == tabPackingListOCR4)
                {
                    initDataGVOCR1();
                }
                else if (tab2AllCartonDetail2.SelectedTab == tab2PoCheckPackingListError2)
                {
                    initDataGV_Error5("", 0);
                }
                if (tab2AllCartonDetail2.SelectedTab == tab2CartonDetailInfo1)
                {
                    initDataGV_Tran4(_strbatchidSelect, _strCartonID);
                }
            }
            else
            {
                _maximunfrm.dataGVMax.Refresh();
            }

        }

        private void dataGVPackingListDetailTransferInfo3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            initprocds(e, data1GV2PackingListDetailTransferInfo2, "e");

        }

        private void initprocds(DataGridViewCellEventArgs e, DataGridView dgv, string dgvflag)
        {
            toolLabelPointXY.Text = "总计:" + (dgv.Rows.Count - 1) + ",当前行:" + (e.RowIndex + 1) + ",列:" + (e.ColumnIndex + 1);
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv.RowCount - 1)
                {

                    _intVoidRightMenu2row = e.RowIndex;
                    //判断选中行时日期类型
                    //dt = ds.Tables[0];
                    Type t = dgv[dgv.CurrentCell.ColumnIndex, e.RowIndex].ValueType;
                    DateTime d = DateTime.Now;
                    if (t == d.GetType())
                    {
                        //获得dataGridView1选中单元格显示区域的矩形
                        System.Drawing.Rectangle Rect = dgv.GetCellDisplayRectangle(dgv.CurrentCell.ColumnIndex, dgv.CurrentCell.RowIndex, false);
                        //显示dTimePicker在dataGridView1选中单元格显示区域的矩形里面,即选中单元格内
                        dTimePicker.Visible = true;
                        dTimePicker.Top = Rect.Top;
                        dTimePicker.Left = Rect.Left;
                        dTimePicker.Height = Rect.Height;
                        dTimePicker.Width = Rect.Width;
                        //dTimePicker控件获取初始值为dataGridView1选中单元格值
                        dTimePicker.Text = dgv.CurrentCell.Value.ToString();

                    }

                    PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();

                    DataSet get_pl_info_Specify_proc_ds = new DataSet();


                    if (dgvflag == "e")
                    {

                        intePackselectRowIndex = e.RowIndex;
                    }
                    plr_mstr_model.Batch_ID = dgv.Rows[e.RowIndex].Cells["Batch_ID"].Value.ToString().Trim();

                    plr_mstr_model.LineID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["LineID"].Value);
                    plr_mstr_model.CartonID = dgv.Rows[e.RowIndex].Cells["CartonID"].Value.ToString().Trim();

                    _strbatchidSelect = plr_mstr_model.Batch_ID;
                    _strCartonID = plr_mstr_model.CartonID;
                    if (!string.IsNullOrEmpty(plr_mstr_model.CartonID))
                    {
                        initDataGV_Tran4(plr_mstr_model.Batch_ID, plr_mstr_model.CartonID);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGVPackingListDetailTransferInfo3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            initfrmplMainShow(e, data1GV2PackingListDetailTransferInfo2, "e-Packing list Maintenance");
        }

        private void initfrmplMainShow(DataGridViewCellEventArgs e, DataGridView dgv, string strText)
        {
            try
            {

                PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();

                if (e.RowIndex >= 0 && e.RowIndex < dgv.RowCount - 1)
                {
                    _intVoidRightMenu2row = e.RowIndex;
                    _intVoidRightMenu2col = e.ColumnIndex;

                    plr_mstr_model.Batch_ID = dgv.Rows[e.RowIndex].Cells["Batch_ID"].Value.ToString().Trim();
                    plr_mstr_model.LineID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["LineID"].Value);

                    _strbatchidSelect = plr_mstr_model.Batch_ID;
                    _strLineIDSelect = plr_mstr_model.LineID;

                    plr_mstr_model = new PIE.BLL.plr_mstr().GetModel(plr_mstr_model.Batch_ID, plr_mstr_model.LineID);
                    var frmplMain_show = new frmplMain(plr_mstr_model, this);
                    frmplMain_show.Text = strText;
                    frmplMain_show.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGVPackingListMasterInfo1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolLabelPointXY.Text = "总计:" + (data1GV1PackingListMasterInfo1.Rows.Count - 1) + ",当前行:" + (e.RowIndex + 1) + ",列:" + (e.ColumnIndex + 1);

            try
            {
                string batchdoc = "";
                string batch_status;
                string batch_id;
                if (e.RowIndex >= 0 && e.RowIndex < data1GV1PackingListMasterInfo1.RowCount - 1)
                {
                    _intVoidRightMenu1row = e.RowIndex;
                    batch_status = data1GV1PackingListMasterInfo1.Rows[e.RowIndex].Cells["batch_status"].Value.ToString().Trim();
                    batch_id = data1GV1PackingListMasterInfo1.Rows[e.RowIndex].Cells["batch_id"].Value.ToString().Trim();
                    if (batch_status == "No")
                    {
                        intPackMainSelect = e.RowIndex;
                        _strbatchidSelect = batch_id;
                        _strCartonID = "";

                    }
                    else
                    {
                        //MessageBox.Show(strbatchidSelect + " has Void.");
                        toolStripStatusLabelMessage.Text = batch_id + " has Void.";
                        _strbatchidSelect = "";
                        //initDataGV_e_Packing3(strbatchidSelect);
                        //initDataGV_Tran4(_strbatchidSelect);
                    }

                    //
                    if (_tinitDataGVThread.ThreadState == ThreadState.Running)
                    {
                        _tinitDataGVThread.Abort();
                    }

                    // initDataGV();
                    if (_tinitDataGVThread.ThreadState == ThreadState.Unstarted)
                    {
                        CartonFromTo ctft = new CartonFromTo(0, 0, "", 3, _strbatchidSelect, 0, "");
                        _tinitDataGVThread.Start(ctft);
                    }
                    if (_tinitDataGVThread.ThreadState == ThreadState.Stopped)
                    {
                        _tinitDataGVThread = new Thread(new ParameterizedThreadStart(initDGVdelegate));
                        CartonFromTo ctft = new CartonFromTo(0, 0, "", 3, _strbatchidSelect, 0, "");
                        _tinitDataGVThread.Start(ctft);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGVPackingListMasterInfo1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                EditMastrInfo(data1GV1PackingListMasterInfo1, tab1AllPacklingList1, tabPackingListDetailInfoEPacking2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditMastrInfo(DataGridView dgv, TabControl tabcontrlFrom, TabPage totabpage)
        {

            int eindex = dgv.CurrentRow.Index;
            intePackselectRowIndex = eindex;
            if (eindex >= 0 && eindex < dgv.RowCount - 1)
            {
                string batchdoc = "";
                string batch_status;
                string batch_id;

                batch_status = dgv.Rows[eindex].Cells["batch_status"].Value.ToString().Trim();
                batch_id = dgv.Rows[eindex].Cells["batch_id"].Value.ToString().Trim();
                if (batch_status == "No")
                {
                    intPackMainSelect = eindex;
                    _strbatchidSelect = batch_id;
                    batchdoc = dgv.Rows[eindex].Cells["batch_doc"].Value.ToString().Trim();

                    //

                    if (_tinitDataGVThread.ThreadState == ThreadState.Running)
                    {
                        _tinitDataGVThread.Abort();

                    }
                    if (_tinitDataGVThread.ThreadState == ThreadState.Unstarted)
                    {
                        CartonFromTo ctfo = new CartonFromTo(0, 0, "", 2, _strbatchidSelect, 0, "");
                        _tinitDataGVThread.Start(ctfo);
                    }
                    if (_tinitDataGVThread.ThreadState == ThreadState.Stopped)
                    {
                        _tinitDataGVThread = new Thread(new ParameterizedThreadStart(initDGVdelegate));
                        CartonFromTo ctfo = new CartonFromTo(0, 0, "", 2, _strbatchidSelect, 0, "");
                        _tinitDataGVThread.Start(ctfo);
                    }
                    //initDataGV_e_Packing3(_strbatchidSelect);

                    tabcontrlFrom.SelectedTab = totabpage;

                    //switch (batchdoc)
                    //{
                    //    case "e-Packing":
                    //        initDataGV_e_Packing3(strbatchidSelect);
                    //        tab1AllPacklingList1.SelectedTab = tabPackingListDetailInfoEPacking4;
                    //        break;
                    //    case "PDF":
                    //        initDataGV_PDF3(strbatchidSelect);
                    //        tab1AllPacklingList1.SelectedTab = tabPackingListDetailInfoPDF3;
                    //        break;
                    //    case "OCR":
                    //        break;
                    //    default:
                    //        break;
                    //}
                }
                else
                {
                    //MessageBox.Show(strbatchidSelect + " has Void.");
                    toolStripStatusLabelMessage.Text = batch_id + " has Void.";
                }

            }
        }

        private void ContextMenuDataGV_Opening(object sender, CancelEventArgs e)
        {
            //if (tab1AllPacklingList1.SelectedTab == tabPackingListMasterInfo1)
            //{
            //    voidToolStripMenuItem.Visible = true;
            //}
            //else
            //{
            //    voidToolStripMenuItem.Visible = false;
            //}

        }

        private void addPDFPackingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();

            var frmplMain_show = new frmplMain(plr_mstr_model, this);
            frmplMain_show.Text = "Add a New Batch ID Packing List info";
            frmplMain_show.btnUpadeAdd.Text = "&Add";
            frmplMain_show.toolStripStatusLabel1.Text = "Notice: Add a New Batch ID Packing List info";
            frmplMain_show.btnGenCartonNo2.Enabled = false;
            frmplMain_show.ShowDialog();
        }

        private void dataGVPackingListDetailPDFInfo5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            initprocds(e, dataGVPackingListDetailPDFInfo5, "pdf");
        }

        private void dataGVPackingListDetailPDFInfo5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            initfrmplMainShow(e, dataGVPackingListDetailPDFInfo5, "PDF Packing list Maintenance");
        }

        private void dataGVPOCheckPackingListError7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            initfrmplMainShow(e, dataGVPOCheckPackingListError7, "PO Check Error Packing list Maintenance");
        }



        private void dataGVPackingListDetailTransferInfo3_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

            e.Row.Cells["Batch_Id"].Value = data1GV2PackingListDetailTransferInfo2[0, 0].Value;
            e.Row.Cells["LineId"].Value = getMaxOrMinColumnFromDataTable(_ds_plr_mstr3.Tables[0], "LineId", true) + 1;

            e.Row.Cells["plr_status"].Value = "No";



            e.Row.Cells["plr_rcp_date"].Value = DateTime.Now.Date;
            e.Row.Cells["plr_deli_date"].Value = DateTime.Now.Date;
            dodelcelselectdelegate(data1GV2PackingListDetailTransferInfo2, 3, e);

        }
        delegate void delcelselectdefault(DataGridView dgv, int selectedindex, DataGridViewRowEventArgs e);

        public void dodelcelselectdelegate(DataGridView dgv, int selectedindex, DataGridViewRowEventArgs e)
        {
            delcelselectdefault dodel = new delcelselectdefault(cellselectdefault);
            object[] args = new object[3];
            args[0] = dgv;
            args[1] = selectedindex;
            args[2] = e;
            BeginInvoke(dodel, args);
        }

        private void cellselectdefault(DataGridView dgv, int selectedindex, DataGridViewRowEventArgs e)
        {
            if (e.Row.IsNewRow)
            {

                e.Row.Cells[selectedindex].Selected = true;
            }
            else
            {
                dgv.Rows[dgv.CurrentRow.Index].Cells[selectedindex].Selected = true;
            }
        }
        private void cellSelect(object dwko)
        {
            DoWrokObject dwo = (DoWrokObject)dwko;
            if (dwo._eX >= 0 && dwo._eX < dwo._dgv.RowCount - 1)
            {
                var cartonidenter = dwo._dgv.Rows[dwo._eX].Cells[dwo._sameColumnName].Value;

                //dgv.Rows[dgv.CurrentRow.Index].Cells[selectedindex].Selected = true;

                //m
                for (int i = 0; i < dwo._dgv.RowCount - 1; i++)
                {
                    if (dwo._dgv.Rows[i].DefaultCellStyle.BackColor != Color.White)
                    {
                        dwo._dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        if (dwo._dgv.Rows[i].Cells[dwo._deffCellName].Value.ToString().Equals(dwo._deffCellValue))
                        {
                            dwo._dgv.Rows[i].Cells[dwo._deffCellName].Style.BackColor = dwo._deffcolors;
                        }

                    }
                    var cartonid = dwo._dgv.Rows[i].Cells[dwo._sameColumnName].Value;
                    if (cartonid != DBNull.Value)
                    {
                        if (cartonid.ToString() == cartonidenter.ToString())
                        {
                            dwo._dgv.Rows[i].DefaultCellStyle.BackColor = dwo._colors;
                            if (dwo._dgv.Rows[i].Cells[dwo._deffCellName].Value.ToString().Equals(dwo._deffCellValue))
                            {
                                dwo._dgv.Rows[i].Cells[dwo._deffCellName].Style.BackColor = dwo._deffcolors;
                            }
                        }
                    }
                }

            }

        }

        private delegate void MyInvoke(object dwko);

        public void DoWorkdelegate(object dwko)
        {
            DoWrokObject dwo = (DoWrokObject)dwko;
            MyInvoke mi = new MyInvoke(cellSelect);
            BeginInvoke(mi, dwo);
        }
        private void dataGVPackingListDetailTransferInfo3_Leave(object sender, EventArgs e)
        {
            _intMeKeysDown = 0;
            if (data1GV2PackingListDetailTransferInfo2.DataSource != null)
            {
                dataNewRow(data1GV2PackingListDetailTransferInfo2, _ds_plr_mstr3);

            }
        }
        private bool dataNewRow(DataGridView dgv, DataSet ds)
        {
            try
            {
                DataSet dsChanges = null;
                dsChanges = ds.GetChanges(DataRowState.Added);
                var plr_mstr_model = new PIE.Model.plr_mstr();
                Boolean saveResult = false;
                if (dsChanges != null && dsChanges.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow item in dsChanges.Tables[0].Rows)
                    {
                        plr_mstr_model.Batch_ID = item["Batch_ID"] == DBNull.Value ? "" : item["Batch_ID"].ToString();
                        plr_mstr_model.LineID = item["LineID"] == DBNull.Value ? 0 : Convert.ToInt32(item["LineID"]);
                        plr_mstr_model.plr_doc_type = item["plr_doc_type"] == DBNull.Value ? "" : item["plr_doc_type"].ToString().Trim();

                        plr_mstr_model.plr_status = item["plr_status"] == DBNull.Value ? "" : item["plr_status"].ToString().Trim();
                        plr_mstr_model.plr_pallet_no = item["plr_pallet_no"] == DBNull.Value ? "" : item["plr_pallet_no"].ToString().Trim();

                        //plr_mstr_model.plr_suppliers_id = item["plr_suppliers_id"] == DBNull.Value ? "" : item["plr_suppliers_id"].ToString().Trim();

                        plr_mstr_model.InvoiceID = item["InvoiceID"] == DBNull.Value ? "" : item["InvoiceID"].ToString().Trim();
                        plr_mstr_model.packingListID = item["packingListID"] == DBNull.Value ? "" : item["packingListID"].ToString().Trim();
                        plr_mstr_model.CartonID = item["CartonID"] == DBNull.Value ? "" : item["CartonID"].ToString().Trim();
                        plr_mstr_model.CartonType = item["CartonType"] == DBNull.Value ? "" : item["CartonType"].ToString().Trim();

                        plr_mstr_model.plr_site = item["plr_site"] == DBNull.Value ? "" : item["plr_site"].ToString();
                        plr_mstr_model.plr_pallet_no = item["plr_pallet_no"] == DBNull.Value ? "" : item["plr_pallet_no"].ToString();
                        plr_mstr_model.plr_po = item["plr_po"] == DBNull.Value ? "" : item["plr_po"].ToString();
                        plr_mstr_model.plr_co = item["plr_co"] == DBNull.Value ? "" : item["plr_co"].ToString();
                        plr_mstr_model.plr_partno = item["plr_partno"] == DBNull.Value ? "" : item["plr_partno"].ToString();

                        plr_mstr_model.plr_date_code = item["plr_date_code"] == DBNull.Value ? "" : item["plr_date_code"].ToString();


                        if (string.IsNullOrEmpty(plr_mstr_model.Batch_ID) || plr_mstr_model.LineID == 0 || string.IsNullOrEmpty(plr_mstr_model.plr_partno) || string.IsNullOrEmpty(plr_mstr_model.CartonID) || string.IsNullOrEmpty(plr_mstr_model.plr_po))
                        {
                            ds.Tables[0].RejectChanges();
                            //MessageBox.Show("新记录：" + plr_mstr_model.Batch_ID + "," + plr_mstr_model.LineID + " Suppliers,PO#,CartonID为空，无法新增。", "Error");
                            toolStripStatusLabelMessage.Text = "提示: 新记录" + plr_mstr_model.Batch_ID + "," + plr_mstr_model.LineID + " Part,PO#,CartonID为空，新增失败,请输入正确内容，谢谢。";
                            dgv.Refresh();
                            //dgv.Rows[dgv.RowCount-2].Cells[2].Selected = true;
                            break;
                        }
                        plr_mstr_model.plr_vend_mfgr = item["plr_vend_mfgr"] == DBNull.Value ? "" : item["plr_vend_mfgr"].ToString();
                        plr_mstr_model.Plr_vm_partno = item["Plr_vm_partno"] == DBNull.Value ? "" : item["Plr_vm_partno"].ToString();
                        plr_mstr_model.plr_qty = item["plr_qty"] == DBNull.Value ? 0 : Convert.ToDecimal(item["plr_qty"]);
                        plr_mstr_model.plr_carton_qty = item["plr_carton_qty"] == DBNull.Value ? 0 : Convert.ToDecimal(item["plr_carton_qty"]);
                        plr_mstr_model.plr_rcp_date = item["plr_rcp_date"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(item["plr_rcp_date"].ToString());
                        plr_mstr_model.plr_deli_date = item["plr_deli_date"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(item["plr_deli_date"].ToString());

                        plr_mstr_model.plr_doc_type = "New";
                        plr_mstr_model.plr_cre_date = DbHelperSQL.getServerGetDate();
                        plr_mstr_model.plr_update_date = DateTime.Now;
                        plr_mstr_model.plr_user_ip = Program.getClientIP();


                        saveResult = new PIE.BLL.plr_mstr().Add(plr_mstr_model);
                    }
                    if (saveResult)
                    {
                        ds.Tables[0].AcceptChanges();
                        //MessageBox.Show("新增记录已经保存", "提示");
                        _newBatchid = plr_mstr_model.Batch_ID;
                        _newCartonid = plr_mstr_model.CartonID;

                        toolStripStatusLabelMessage.Text = "提示: 新增记录 " + _newBatchid + "," + plr_mstr_model.LineID + " 已经保存OK";

                        _strbatchidSelect = plr_mstr_model.Batch_ID;
                        PIE.Model.plr_batch_mstr plr_batch_mstr_model = new PIE.BLL.plr_batch_mstr().GetModel(plr_mstr_model.Batch_ID);
                        if (plr_batch_mstr_model.batch_doc.Equals("e-Packing"))
                        {
                            plr_batch_mstr_model.batch_doc = "e-Packing,New";
                        }
                        plr_batch_mstr_model.plr_suppliers_id = plr_mstr_model.plr_suppliers_id;

                        plr_batch_mstr_model.batch_dec01++;
                        plr_batch_mstr_model.batch_update_date = DbHelperSQL.getServerGetDate();
                        plr_batch_mstr_model.batch_user_ip = Program.getClientIP();

                        var intbmm = new PIE.BLL.plr_batch_mstr().Update(plr_batch_mstr_model);

                        var resultint = Program.GenCartonNo(plr_mstr_model);


                        return true;

                        //dgv.CurrentCell = dgv.Rows[dgv.RowCount - 2].Cells[2];
                        //dataGVPackingListDetailTransferInfo3.ClearSelection();
                        //dataGVPackingListDetailTransferInfo3.CurrentCell = dataGVPackingListDetailTransferInfo3.Rows[dgv.RowCount - 2].Cells[2];
                        //dgv.ClearSelection();
                        //dgv.CurrentCell = dgv.Rows[dgv.RowCount - 2].Cells[2];
                        //dgv.Rows[dgv.RowCount - 2].Cells[2].Selected = true;
                        //dgv.Focus();

                        //dgv.CurrentCell.PositionEditingPanel();
                        //dgv.BeginEdit(true);

                    }

                    else
                    {
                        dgv.Refresh();
                        return false;

                    }

                }
                return false;

            }
            catch (Exception ex)
            {
                ds.Tables[0].RejectChanges();
                // ds.Tables[0].AcceptChanges();
                dgv.Refresh();
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void dataGVPackingListDetailTransferInfo3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < data1GV2PackingListDetailTransferInfo2.RowCount)
            {


                var returnnew = dataNewRow(data1GV2PackingListDetailTransferInfo2, _ds_plr_mstr3);


                //
                if (_tDoWorkBackClorThread.ThreadState == ThreadState.Running)
                {
                    _tDoWorkBackClorThread.Abort();
                }
                if (_tDoWorkBackClorThread.ThreadState == ThreadState.Unstarted)
                {
                    DoWrokObject dwo = new DoWrokObject(data1GV2PackingListDetailTransferInfo2, 3, e.RowIndex, Color.Yellow, "CartonID", "plr_status", "Yes", Color.LightGray);
                    _tDoWorkBackClorThread.Start(dwo);

                }
                if (_tDoWorkBackClorThread.ThreadState == ThreadState.Stopped)
                {
                    _tDoWorkBackClorThread = new Thread(new ParameterizedThreadStart(DoWorkdelegate));
                    DoWrokObject dwo = new DoWrokObject(data1GV2PackingListDetailTransferInfo2, 3, e.RowIndex, Color.Yellow, "CartonID", "plr_status", "Yes", Color.LightGray);
                    _tDoWorkBackClorThread.Start(dwo);

                }
                //DoWorkdelegate(dwo);

                if (data1GV2PackingListDetailTransferInfo2.Rows[e.RowIndex].IsNewRow)
                {
                    return;
                }
                if (returnnew)
                {
                    _strbatchidSelect = _newBatchid;
                    _strCartonID = _newCartonid;
                }
                else
                {
                    var strbatchidSelectCurr = data1GV2PackingListDetailTransferInfo2.Rows[e.RowIndex].Cells["Batch_ID"].Value.ToString();
                    var strCartonIDCurr = data1GV2PackingListDetailTransferInfo2.Rows[e.RowIndex].Cells["CartonID"].Value.ToString();

                    if (!string.IsNullOrEmpty(strbatchidSelectCurr) && !string.IsNullOrEmpty(strCartonIDCurr))
                    {
                        _strbatchidSelect = strbatchidSelectCurr;
                        _strCartonID = strCartonIDCurr;
                    }
                }

                //if (returnnew)
                //{
                //    initDataGV_Tran4(newBatchid, newCartonid);
                //}
                //else// if(intVoidRightMenu3==-1)
                //{
                //    initDataGV_Tran4(data1GV2PackingListDetailTransferInfo3.Rows[e.RowIndex].Cells["Batch_ID"].Value.ToString(), data1GV2PackingListDetailTransferInfo3.Rows[e.RowIndex].Cells["CartonID"].Value.ToString());
                //}
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("tiemer:"+timer1.Interval.ToString());
        }
        private void UploadERP()
        {
            try
            {

                //toolStripStatusLabelMessage.Text = "Notice: Uploading to ERP Start";
                //btnUploadtoERP.Text = "Uploading...";
                //btnUploadtoERP.Enabled = false;
                SetToolTextdelegate(toolLabel2ThreadMsg, "$UploadExcel: Notice: Uploading to ERP Start", true, true);
                SetCtlTextdelegate(btnUploadtoERP, "Uploading...", false, true);
                string strresult;

                Program.UploadtoERP(this);

                strresult = Program._uploaderpmsg;

                //initDataGV_Tran4(_strbatchidSelect);

                //MessageBox.Show(strresult);
                //toolStripStatusLabelMessage.Text = "Notice: Uploading to ERP END";
                SetToolTextdelegate(toolLabel2ThreadMsg, strresult, true, true);

                CartonFromTo ctfo = new CartonFromTo(0, 0, "", 3, "", 0, "");
                initDGVdelegate(ctfo);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                SetToolTextdelegate(toolLabel2ThreadMsg, "$UploadExcel: " + ex.Message, true, true);
            }
            finally
            {
                SetCtlTextdelegate(btnUploadtoERP, "&UploadToERP", true, true);

            }
        }
        private void btnUploadtoERP_Click(object sender, EventArgs e)
        {
            //_tuploadERP = new Thread(UploadERP);
            if (_tuploadERP.ThreadState == ThreadState.Running)
            {
                _tuploadERP.Abort();
            }
            if (_tuploadERP.ThreadState == ThreadState.Unstarted)
            {
                _tuploadERP.Start();
            }
            else if (_tuploadERP.ThreadState == ThreadState.Stopped)
            {
                _tuploadERP = new Thread(UploadERP);
                _tuploadERP.Start();
            }



        }

        private void dataGVPackingListDetailTransferInfo3_Scroll(object sender, ScrollEventArgs e)
        {
            dTimePicker.Visible = false;
        }

        private void dataGVPackingListDetailTransferInfo3_Resize(object sender, EventArgs e)
        {
            dTimePicker.Visible = false;
        }

        private void txtSuppliersID_TextChanged(object sender, EventArgs e)
        {
            _strsuppliers = txtSuppliersID.Text.Trim();
            txtBackColor(txtSuppliersID);
        }

        public void txtBackColor(System.Windows.Forms.TextBox tb)
        {
            if (tb.Text.Length > 0)
            {
                tb.BackColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.Yellow;
            }
        }

        private void txtBatchID_TextChanged(object sender, EventArgs e)
        {
            txtBackColor(txtBatchID);
        }


        private void dataGVCartonDetailInfo4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            initfrmplMainShow(e, data2GV1CartonDetailInfo3, "e-Packing list Maintenance");
        }

        private void FrmPIE_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_tuploadERP.ThreadState == ThreadState.Running)
            {
                _tuploadERP.Abort();
            }
            if (_tuploadExcel.ThreadState == ThreadState.Running)
            {
                _tuploadERP.Abort();
            }
            if (_tprintCtn.ThreadState == ThreadState.Running)
            {
                _tprintCtn.Abort();
            }
            if (_tDoWorkBackClorThread.ThreadState == ThreadState.Running)
            {
                _tDoWorkBackClorThread.Abort();
            }
            if (_tinitDataGVThread.ThreadState == ThreadState.Running)
            {
                _tinitDataGVThread.Abort();
            }
            if (_tinitStateVoidColorThread.ThreadState == ThreadState.Running)
            {
                _tinitStateVoidColorThread.Abort();
            }
            _logonDomain.Dispose();
            Dispose();
            GC.Collect();
        }




        private void voidBatchIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tab1AllPacklingList1.SelectedTab == tabPackingListMasterInfo1)
            {
                if (_intVoidRightMenu1row < 0)
                {
                    toolStripStatusLabelMessage.Text = "请选择 BatchID。";
                    return;
                }

                var batchid = data1GV1PackingListMasterInfo1.Rows[_intVoidRightMenu1row].Cells["Batch_ID"].Value == DBNull.Value ? "" : data1GV1PackingListMasterInfo1.Rows[_intVoidRightMenu1row].Cells["Batch_ID"].Value.ToString();
                var batch_status = data1GV1PackingListMasterInfo1.Rows[_intVoidRightMenu1row].Cells["batch_status"].Value == DBNull.Value ? "" : data1GV1PackingListMasterInfo1.Rows[_intVoidRightMenu1row].Cells["batch_status"].Value.ToString();

                if (!string.IsNullOrEmpty(batch_status) && batch_status == "Yes")
                {
                    toolStripStatusLabelMessage.Text = "BatchID: " + batchid + " 早已作废";
                    _intVoidRightMenu1row = -1;
                    return;
                }
                if (!string.IsNullOrEmpty(batchid))
                {
                    var msg = "是否作废 BatchID: " + batchid;
                    if (MessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        PIE.Model.plr_batch_mstr plr_bath_mstr_model_update = new PIE.BLL.plr_batch_mstr().GetModel(batchid);
                        plr_bath_mstr_model_update.batch_status = "Yes";
                        plr_bath_mstr_model_update.batch_update_date = DbHelperSQL.getServerGetDate();
                        plr_bath_mstr_model_update.batch_user_ip = Program.getClientIP();
                        var resutlupdate = new PIE.BLL.plr_batch_mstr().Update(plr_bath_mstr_model_update);
                        string strupdateplr_mstr = @"update plr_mstr set plr_status='Yes' where Batch_ID='" + batchid + "'";
                        string strupdateplr_mstr_tran = @"update plr_mstr_tran set plr_status='Yes',plr_status_msg='Void' where plr_status<>'U' and Batch_ID='" + batchid + "'";

                        if (resutlupdate)
                        {
                            var resultmstr = DbHelperSQL.ExecuteSql(strupdateplr_mstr);
                            var resultmstr_tran = DbHelperSQL.ExecuteSql(strupdateplr_mstr_tran);
                            toolStripStatusLabelMessage.Text = " 作废BatchID: " + batchid + " Success";
                            initDataGV();
                            initDataGV_e_Packing3("");
                            initDataGV_Tran4("");
                        }
                        else
                        {
                            toolStripStatusLabelMessage.Text = " 作废BatchID: " + batchid + " Fail";
                        }
                    }
                }
                _intVoidRightMenu1row = -1;
            }
            else if (tab1AllPacklingList1.SelectedTab == tabPackingListDetailInfoEPacking2)
            {
                if (_intVoidRightMenu2row < 0)
                {
                    toolStripStatusLabelMessage.Text = "请选择 BatchID。";
                    return;
                }
                var batchid = data1GV2PackingListDetailTransferInfo2.Rows[_intVoidRightMenu2row].Cells["Batch_ID"].Value == DBNull.Value ? "" : data1GV2PackingListDetailTransferInfo2.Rows[_intVoidRightMenu2row].Cells["Batch_ID"].Value.ToString();
                var batch_line = data1GV2PackingListDetailTransferInfo2.Rows[_intVoidRightMenu2row].Cells["LineID"].Value == DBNull.Value ? "" : data1GV2PackingListDetailTransferInfo2.Rows[_intVoidRightMenu2row].Cells["LineID"].Value.ToString();
                var batch_status = data1GV2PackingListDetailTransferInfo2.Rows[_intVoidRightMenu2row].Cells["plr_status"].Value == DBNull.Value ? "" : data1GV2PackingListDetailTransferInfo2.Rows[_intVoidRightMenu2row].Cells["plr_status"].Value.ToString();

                if (!string.IsNullOrEmpty(batch_status) && batch_status == "Yes")
                {
                    toolStripStatusLabelMessage.Text = "BatchID: " + batchid + "，LineId: " + batch_line + " 早已作废";
                    _intVoidRightMenu2row = -1;
                    return;
                }
                if (!string.IsNullOrEmpty(batchid))
                {
                    var msg = "是否作废 BatchID: " + batchid + "，LineId: " + batch_line;
                    if (MessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        PIE.Model.plr_mstr plr_bath_mstr_model_update = new PIE.BLL.plr_mstr().GetModel(batchid, Convert.ToInt32(batch_line));
                        plr_bath_mstr_model_update.plr_status = "Yes";
                        plr_bath_mstr_model_update.plr_update_date = DbHelperSQL.getServerGetDate();
                        plr_bath_mstr_model_update.plr_user_ip = Program.getClientIP();
                        var resutlupdate = new PIE.BLL.plr_mstr().Update(plr_bath_mstr_model_update);

                        string strupdateplr_mstr_tran = @"update plr_mstr_tran set plr_status='Yes',plr_status_msg='Void' where plr_status<>'U' and Batch_ID='" + batchid + "' and LineID='" + batch_line + "'";

                        if (resutlupdate)
                        {
                            var resultmstr_tran = DbHelperSQL.ExecuteSql(strupdateplr_mstr_tran);

                            toolStripStatusLabelMessage.Text = " 作废BatchID: " + batchid + "，LineId: " + batch_line + " Success";
                            initDataGV_e_Packing3(batchid);
                        }
                        else
                        {
                            toolStripStatusLabelMessage.Text = " 作废BatchID: " + batchid + "，LineId: " + batch_line + " Fail";
                        }
                    }
                }
                _intVoidRightMenu2row = -1;

            }


        }




        private void dataGVPackingListMasterInfo1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {//initStateVoidColor();
            if (data1GV1PackingListMasterInfo1.RowCount > 1)
            {
                _tinitStateVoidColorThread = new Thread(new ParameterizedThreadStart(initStateVoidColor));
                if (_tinitStateVoidColorThread.ThreadState == ThreadState.Running)
                {
                    _tinitStateVoidColorThread.Abort();
                }
                if (_tinitStateVoidColorThread.ThreadState == ThreadState.Stopped || _tinitStateVoidColorThread.ThreadState == ThreadState.Unstarted)
                {
                    DoWrokObject dwoj = new DoWrokObject(data1GV1PackingListMasterInfo1, 0, 0, Color.LightGray, "batch_status", "", "", Color.Yellow);
                    _tinitStateVoidColorThread.Start(dwoj);
                }
            }

        }

        delegate void initStateVoidColordel(object colobj);
        public void initStateVoidColorDelegate(object colobj)
        {
            initStateVoidColordel isvc = new initStateVoidColordel(initStateVoidColor);

            BeginInvoke(isvc, colobj);
        }
        private void initStateVoidColor(object colobj)
        {
            DoWrokObject dwobj = (DoWrokObject)colobj;
            var dgv = dwobj._dgv;
            var columnname = dwobj._sameColumnName;

            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                var voidstatus = dgv.Rows[i].Cells[columnname].Value;
                if (voidstatus != null && voidstatus.ToString() == "Yes")
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = dwobj._colors;

                }
            }
        }

        private void dataGVCartonDetailInfo4_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            // DoWorkdelegate(data2GV1CartonDetailInfo3, 3, e.RowIndex, Color.LightGreen, "CartonID", "plr_status", "Yes", Color.LightGray);

            //_tDoWorkBackClorThread = new Thread(new ParameterizedThreadStart(DoWorkdelegate));
            if (_tDoWorkBackClorThread.ThreadState == ThreadState.Running)
            {
                _tDoWorkBackClorThread.Abort();
            }
            if (_tDoWorkBackClorThread.ThreadState == ThreadState.Unstarted)
            {
                DoWrokObject dwo = new DoWrokObject(data2GV1CartonDetailInfo3, 3, e.RowIndex, Color.LightGreen, "CartonID", "plr_status", "Yes", Color.LightGray);

                _tDoWorkBackClorThread.Start(dwo);

            }
            if (_tDoWorkBackClorThread.ThreadState == ThreadState.Stopped)
            {
                _tDoWorkBackClorThread = new Thread(new ParameterizedThreadStart(DoWorkdelegate));
                DoWrokObject dwo = new DoWrokObject(data2GV1CartonDetailInfo3, 3, e.RowIndex, Color.LightGreen, "CartonID", "plr_status", "Yes", Color.LightGray);

                _tDoWorkBackClorThread.Start(dwo);

            }
        }


        delegate void initdgv(DataGridView dgv);

        private void maxmSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            int selectedindexCurrent = -1;
            initdgv initmi = new initdgv(initHeaderTextPlrBatchMstr1);
            Color colors = Color.Yellow;

            string strcolumn = "";
            string strSameColumns = "";
            if (_strcurrTab == 1)
            {
                if (tab1AllPacklingList1.SelectedTab == tabPackingListMasterInfo1)
                {
                    if (data1GV1PackingListMasterInfo1.RowCount < 2)
                    {
                        toolStripStatusLabelMessage.Text = "1.NO Record.";
                        return;
                    }
                    initmi = new initdgv(initHeaderTextPlrBatchMstr1);
                    selectedindexCurrent = data1GV1PackingListMasterInfo1.CurrentRow.Index;
                    colors = Color.LightGreen;
                    strcolumn = "batch_status";
                    strSameColumns = "batch_user_ip";
                    _maxsizeToDataGridView = 1;
                    _strcurrMax = 0;
                    ds = _dsbatch1;

                }
                else if (tab1AllPacklingList1.SelectedTab == tabPackingListDetailInfoEPacking2)
                {
                    if (data1GV2PackingListDetailTransferInfo2.RowCount < 2)
                    {
                        toolStripStatusLabelMessage.Text = "2.NO Record.";
                        return;
                    }
                    initmi = new initdgv(initHeaderTextPlrMstr2);
                    strcolumn = "plr_status";
                    strSameColumns = "CartonID";
                    _maxsizeToDataGridView = 2;
                    _strcurrMax = 1;
                    selectedindexCurrent = data1GV2PackingListDetailTransferInfo2.CurrentRow.Index;
                    ds = _dsePacking2;
                }

            }
            else if (_strcurrTab == 2)
            {
                if (tab2AllCartonDetail2.SelectedTab == tab2CartonDetailInfo1)
                {
                    if (data2GV1CartonDetailInfo3.RowCount < 2)
                    {
                        toolStripStatusLabelMessage.Text = "3.NO Record.";
                        return;
                    }
                    initmi = new initdgv(initHeaderTextCartonDetails3);
                    selectedindexCurrent = data2GV1CartonDetailInfo3.CurrentRow.Index;
                    strcolumn = "plr_status";
                    _maxsizeToDataGridView = 3;
                    strSameColumns = "CartonID";
                    _strcurrMax = 1;
                    colors = Color.LightGreen;
                    ds = _dsCarton3;
                }

            }
            if (ds != null)
            {
                _maximunfrm = new MaximunSizeFrm(ds, toolStripStatusLabelMessage.Text, selectedindexCurrent, strSameColumns, strcolumn, colors, this);
                initmi(_maximunfrm.dataGVMax);
                _maximunfrm.Text = _maximunfrm.Text + _maxsizeToDataGridView;
                _maximunfrm.Show();
            }
            else
            {
                toolStripStatusLabelMessage.Text = "Please Select Right Windows.Thanks.";
            }

        }


        private void tab1AllPacklingList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _strcurrTab = 1;
                toolStripStatusLabelMessage.Text = tab1AllPacklingList1.SelectedTab.Text;
            }
        }

        private void tab2AllCartonDetail2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _strcurrTab = 2;
                toolStripStatusLabelMessage.Text = tab2AllCartonDetail2.SelectedTab.Text;
            }
        }

        private void dataGVCartonDetailInfo4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolLabelPointXY.Text = "总计:" + (data2GV1CartonDetailInfo3.Rows.Count - 1) + ",当前行:" + (e.RowIndex + 1) + ",列:" + (e.ColumnIndex + 1);
            if (e.RowIndex >= 0 && e.RowIndex > data2GV1CartonDetailInfo3.Rows.Count - 1)
            {
                _intVoidRightMenu3row = e.RowIndex;
            }
        }

        public void initEditMstr(DataGridView dgv, int intselect, string strtxt)
        {
            PIE.Model.plr_mstr plr_mstr_model = new PIE.Model.plr_mstr();

            plr_mstr_model.Batch_ID = dgv.Rows[intselect].Cells["Batch_ID"].Value.ToString().Trim();
            plr_mstr_model.LineID = Convert.ToInt32(dgv.Rows[intselect].Cells["LineID"].Value);
            plr_mstr_model = new PIE.BLL.plr_mstr().GetModel(plr_mstr_model.Batch_ID, plr_mstr_model.LineID);
            var frmplMain_show = new frmplMain(plr_mstr_model, this);
            frmplMain_show.Text = strtxt;
            frmplMain_show.ShowDialog();
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_maxactive)
            {
                if (_maximunfrm != null && _strcurrMax == 1)
                {
                    initEditMstr(_maximunfrm.dataGVMax, _maximunfrm._selectedindexrow, "e-Packing list Maintenance GVMax1");

                }
                else
                {
                    toolStripStatusLabelMessage.Text = "Can't edit this Items.";
                }
            }
            else
            {
                if (_strcurrTab == 1)
                {
                    if (tab1AllPacklingList1.SelectedTab == tabPackingListDetailInfoEPacking2)
                    {

                        initEditMstr(data1GV2PackingListDetailTransferInfo2, _intVoidRightMenu2row, "e-Packing list Maintenance Info3");

                    }

                }
                else if (_strcurrTab == 2)
                {
                    if (tab2AllCartonDetail2.SelectedTab == tab2CartonDetailInfo1)
                    {

                        initEditMstr(data2GV1CartonDetailInfo3, _intVoidRightMenu3row, "e-Packing list Maintenance Info4");

                    }
                }
            }



        }

        private void contextMenuStripDataGVEdit_Opening(object sender, CancelEventArgs e)
        {


            if (_strcurrTab == 1)
            {
                if (tab1AllPacklingList1.SelectedTab == tabPackingListMasterInfo1)
                {
                    editToolStripMenuItem2.Visible = false;
                    releaseFrozen(data1GV1PackingListMasterInfo1, _intVoidRightMenu1col);
                }
                else if (tab1AllPacklingList1.SelectedTab == tabPackingListDetailInfoEPacking2)
                {
                    editToolStripMenuItem2.Visible = true;
                    releaseFrozen(data1GV2PackingListDetailTransferInfo2, _intVoidRightMenu2col);

                }
                voidBatchIDToolStripMenuItem2.Visible = true;
            }
            if (_strcurrTab == 2)
            {
                if (tab2AllCartonDetail2.SelectedTab == tab2CartonDetailInfo1)
                {
                    voidBatchIDToolStripMenuItem2.Visible = false;
                    releaseFrozen(data2GV1CartonDetailInfo3, _intVoidRightMenu3col);
                }
                else
                {

                    voidBatchIDToolStripMenuItem2.Visible = true;
                }
                editToolStripMenuItem2.Visible = true;
            }

            if (_maximunfrm != null)
            {
                voidBatchIDToolStripMenuItem2.Visible = false;
                editToolStripMenuItem2.Visible = true;
                releaseFrozen(_maximunfrm.dataGVMax, _maximunfrm._selectedindexcol);
            }


        }

        public void releaseFrozen(DataGridView dgv, int colindex)
        {
            if (dgv.Columns[colindex].Frozen)
            {

                frozenToolStripMenuItem.Text = "&Release Frozen";
            }
            else
            {
                frozenToolStripMenuItem.Text = "&Frozen";
            }
        }

        private void frozenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_strcurrTab == 1)
            {
                if (tab1AllPacklingList1.SelectedTab == tabPackingListMasterInfo1)
                {
                    colFronzen(data1GV1PackingListMasterInfo1, _intVoidRightMenu1col);
                }
                else if (tab1AllPacklingList1.SelectedTab == tabPackingListDetailInfoEPacking2)
                {
                    colFronzen(data1GV2PackingListDetailTransferInfo2, _intVoidRightMenu2col);

                }
            }
            if (_strcurrTab == 2)
            {
                if (tab2AllCartonDetail2.SelectedTab == tab2CartonDetailInfo1)
                {
                    colFronzen(data2GV1CartonDetailInfo3, _intVoidRightMenu3col);
                }

            }
            if (_maximunfrm != null)
            {
                colFronzen(_maximunfrm.dataGVMax, _maximunfrm._selectedindexcol);
            }
        }

        public void colFronzen(DataGridView dgv, int colindex)
        {
            if (dgv.DataSource != null)
            {
                dgv.Columns[colindex].Frozen = !dgv.Columns[colindex].Frozen;
            }
            if (dgv.Columns[colindex].Frozen)
            {
                dgv.Columns[colindex].DefaultCellStyle.ForeColor = Color.MediumVioletRed;
            }
            else
            {
                dgv.Columns[colindex].DefaultCellStyle.ForeColor = Color.Black;
            }

        }

        private void FrmPIE_Activated(object sender, EventArgs e)
        {
            _maxactive = false;
        }

        private void reflash2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabDataGVinit();
        }



        private void data1GV2PackingListDetailTransferInfo3_KeyUp(object sender, KeyEventArgs e)
        {
            _intMeKeysDown = 1;

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {

                var enterindex = data1GV2PackingListDetailTransferInfo2.CurrentRow.Index;
                var countindex = data1GV2PackingListDetailTransferInfo2.RowCount;
                if (enterindex >= 0 && enterindex < countindex - 1)
                {

                    var returnnew = dataNewRow(data1GV2PackingListDetailTransferInfo2, _ds_plr_mstr3);
                    //DoWorkdelegate();
                    DoWrokObject dwo = new DoWrokObject(data1GV2PackingListDetailTransferInfo2, 2, enterindex, Color.Yellow, "CartonID", "plr_status", "Yes", Color.LightGray);

                    Thread dowork3 = new Thread(new ParameterizedThreadStart(DoWorkdelegate));
                    if (dowork3.ThreadState == ThreadState.Stopped || dowork3.ThreadState == ThreadState.Unstarted)
                    {
                        dowork3.Start(dwo);

                    }
                    //initDataGV_Tran4(_strbatchidSelect, _strCartonID);
                    //_tinitDataGVThread = new Thread(new ParameterizedThreadStart(initDGVdelegate));
                    if (_tinitDataGVThread.ThreadState == ThreadState.Running)
                    {
                        _tinitDataGVThread.Abort();
                    }
                    if (_tinitDataGVThread.ThreadState == ThreadState.Unstarted)
                    {
                        CartonFromTo ctfo = new CartonFromTo(0, 0, "", 5, _strbatchidSelect, 0, _strCartonID);
                        _tinitDataGVThread.Start(ctfo);
                    }
                    if (_tinitDataGVThread.ThreadState == ThreadState.Stopped)
                    {
                        _tinitDataGVThread = new Thread(new ParameterizedThreadStart(initDGVdelegate));
                        CartonFromTo ctfo = new CartonFromTo(0, 0, "", 5, _strbatchidSelect, 0, _strCartonID);
                        _tinitDataGVThread.Start(ctfo);
                    }


                }
            }
        }

        private void data1GV1PackingListMasterInfo1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditMastrInfo(data1GV1PackingListMasterInfo1, tab1AllPacklingList1, tabPackingListDetailInfoEPacking2);
            }
            _intMeKeysDown = 1;
        }

        private void data2GV1CartonDetailInfo4_KeyUp(object sender, KeyEventArgs e)
        {
            _intMeKeysDown = 1;

        }

        private void data1GV1PackingListMasterInfo1_Leave(object sender, EventArgs e)
        {
            _intMeKeysDown = 0;
        }

        private void data2GV1CartonDetailInfo4_Leave(object sender, EventArgs e)
        {
            _intMeKeysDown = 0;
        }

        private void data1GV1PackingListMasterInfo1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DoWork(data1GV1PackingListMasterInfo1, 0, e.RowIndex, Color.LawnGreen, "batch_user_ip", "batch_status", "Yes", Color.LightGray);
        }

        private void data1GV1PackingListMasterInfo1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            data1GV1PackingListMasterInfo1.ContextMenuStrip = null;
            if (e.RowIndex > -1 && e.RowIndex < data1GV1PackingListMasterInfo1.RowCount - 1)
            {
                _intVoidRightMenu1row = e.RowIndex;
                _intVoidRightMenu1col = e.ColumnIndex;
                _strcurrTab = 1;
                data1GV1PackingListMasterInfo1.ContextMenuStrip = contextMenuStripDataGVEdit;


            }
        }


        private void data1GV2PackingListDetailTransferInfo2_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            data1GV2PackingListDetailTransferInfo2.ContextMenuStrip = null;
            if (e.RowIndex > -1 && e.RowIndex < data1GV2PackingListDetailTransferInfo2.RowCount - 1)
            {
                _intVoidRightMenu2row = e.RowIndex;
                _intVoidRightMenu2col = e.ColumnIndex;

                _strcurrTab = 1;
                data1GV2PackingListDetailTransferInfo2.ContextMenuStrip = contextMenuStripDataGVEdit;

            }
        }

        private void data2GV1CartonDetailInfo3_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            data2GV1CartonDetailInfo3.ContextMenuStrip = null;
            if (e.RowIndex > -1 && e.RowIndex < data2GV1CartonDetailInfo3.RowCount - 1)
            {
                _intVoidRightMenu3row = e.RowIndex;
                _intVoidRightMenu3col = e.ColumnIndex;
                _strcurrTab = 2;
                data2GV1CartonDetailInfo3.ContextMenuStrip = contextMenuStripDataGVEdit;

            }

        }

        private void clearNoticeMsgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolLabel2ThreadMsg.Text = "";
            toolStripStatusLabelMessage.Text = "";
        }

        private void FrmPIE_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsDisposed)
            {
                Dispose();
                GC.Collect();
            }
        }

        private void openPrintFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string allfileNamepath;
            string pathname = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "0labeltxt";
            if (string.IsNullOrEmpty(strSaveLabelFile))
            {

                allfileNamepath = pathname;
            }
            else
            {

                allfileNamepath = System.IO.Path.Combine(pathname, strSaveLabelFile);
            }
            OpenFolderAndSelectFile(allfileNamepath);
        }

        private void OpenFolderAndSelectFile(String fileFullName)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            System.Diagnostics.Process.Start(psi);
        }






    }
}
