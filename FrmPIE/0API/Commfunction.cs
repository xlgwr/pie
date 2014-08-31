using System;
using System.Collections.Generic;
using System.Web.Services.Description;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

using PIE.DBUtility;
using System.Data.SqlClient;
using System.Data;

using System.Net;
using System.Net.Sockets;

using System.DirectoryServices;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Text;
using PIE.Common;
using System.Threading;

namespace FrmPIE._0API
{
    class Commfunction
    {
        frmIDR _idr_show;
        public static string _uploaderpmsg = "";
        public static string _uploaderrows = "";

        public delegate void voidMethod();
        public delegate void dinitDataGVSource(object obj);
        public delegate void dDoWorkCellSelectColor(object dwko);
        public delegate void dSafeSetCtlText(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible);
        public delegate void dSafeSetToolText(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible);
        public delegate void dSafeSetDataGVds(System.Windows.Forms.DataGridView ctl, DataSet ds, int selectIndexRow, int intselectIndexCol);


        //定义一个DateTimePicker控件
        private DateTimePicker dTimePicker = new DateTimePicker();
        public DataGridView _shareDgv;
        PIE.Model.plr_mstr _plr_mstr_model = new PIE.Model.plr_mstr();
        public Commfunction(frmIDR idr)
        {
            _idr_show = idr;
        }

        public void DoWorkCellSelectColordelegate(object dwko)
        {
            DoWrokObject dwo = (DoWrokObject)dwko;
            dDoWorkCellSelectColor mi = new dDoWorkCellSelectColor(cellSelectMethod);
            _idr_show.BeginInvoke(mi, dwo);

        }
        public void SetToolTextdelegate(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible)
        {
            dSafeSetToolText objSet = new dSafeSetToolText(setToolText);

            _idr_show.BeginInvoke(objSet, new object[] { ctl, strMsg, enable, visible });
        }
        public void SetCtlTextdelegate(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible)
        {
            dSafeSetCtlText objSet = new dSafeSetCtlText(setControlText);

            _idr_show.BeginInvoke(objSet, new object[] { ctl, strMsg, enable, visible });
        }
        public void initWECPrintFromToDeleteaget(CartonFromTo cft)
        {
            dinitDataGVSource me = new dinitDataGVSource(initWECPrintFromTo);
            _idr_show.BeginInvoke(me, cft);
        }

        public static string getClientIP()
        {
            IPAddress[] arrIPAddresses = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in arrIPAddresses)
            {
                if (ip.AddressFamily.Equals(AddressFamily.InterNetwork))
                {
                    return ip.ToString();
                }
            }
            return "Nothing";
        }
        private static bool initWebServer(string plr_po, WebReference100.Service server100, string intable, string strPO, out DataSet ds)
        {
            int returnValueNumber;
            string wec_ctn_pre;
            string strServer;


            SqlParameter[] parameters ={
                new SqlParameter("@po_nbr",SqlDbType.VarChar,30),
                new SqlParameter("@wec_ctn_pre",SqlDbType.VarChar,30)
                };

            parameters[0].Value = plr_po;

            parameters[1].Direction = ParameterDirection.Output;

            DbHelperSQL.RunProcedure("sp_Get_WecCtnPre", parameters, out returnValueNumber);

            wec_ctn_pre = parameters[1].Value.ToString().Trim();



            if (wec_ctn_pre == "WWTS")
            {
                strServer = "TESTOLDWEC";
            }
            else if (wec_ctn_pre == "WEC")
            {
                strServer = "P1";
            }
            else if (wec_ctn_pre == "WTSZ")
            {
                strServer = "TESTOLDWEC";
            }
            else if (wec_ctn_pre == "Wellop")
            {
                strServer = "TESTOLDWEC";
            }
            else
            {
                strServer = "P1";
            }
            try
            {

                ds = server100.GetTable_n(strServer, intable, strPO);
                return true;
            }
            catch (Exception ex)
            {

                ds = null;
                return false;
                //MessageBox.Show(ex.Message);

            }

        }
        public void cellSelectMethod(object dwko, bool oldflag)
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
        public void cellSelectMethod(object dwko)
        {

            DoWrokObject dwo = (DoWrokObject)dwko;
            int mcount = 0;
            int minValue = 0;
            int maxValue = 0;
            int minresult = 0;
            int maxreuslt = 0;

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
                            mcount++;
                            dwo._dgv.Rows[i].DefaultCellStyle.BackColor = dwo._colors;

                            if (dwo._dgv.Rows[i].Cells[dwo._deffCellName].Value.ToString().Equals(dwo._deffCellValue))
                            {
                                dwo._dgv.Rows[i].Cells[dwo._deffCellName].Style.BackColor = dwo._deffcolors;
                            }
                            if (!string.IsNullOrEmpty(dwo._compMaxMin))
                            {
                                if (mcount == 1)
                                {
                                    minValue = (int)dwo._dgv.Rows[i].Cells[dwo._compMaxMin].Value;
                                    maxValue = minValue;
                                }
                                else
                                {
                                    minresult = (int)dwo._dgv.Rows[i].Cells[dwo._compMaxMin].Value;
                                    maxreuslt = minresult;
                                    if (minresult < minValue)
                                    {
                                        minValue = minresult;
                                    }
                                    if (maxreuslt > maxValue)
                                    {
                                        maxValue = maxreuslt;
                                    }
                                }
                            }

                        }
                    }
                }
                _idr_show._intFrom = minValue;
                _idr_show._intTo = maxValue;


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
        /// <summary>
        /// plr_batch_mstr
        /// </summary>
        /// <param name="ctftobj">CartonFromTo</param>
        /// <param name="isRefresh">ture,false</param>
        /// <param name="reurntype">datasets 50 or dataset1 or model(all,ds,model)</param>
        /// <returns>datasets 50 or dataset1 or model(all,ds,model)</returns>
        public object initDataGVPlrBatchMstr(CartonFromTo ctftobj, bool isRefresh, string reurntype)
        {
            var dgv = ctftobj._dgv;
            var batchid = ctftobj._batchID;

            try
            {
                string strwhere;
                DataSet plr_batch_mstr_ds1;
                PIE.Model.plr_batch_mstr plr_batch_mstr_model = new PIE.Model.plr_batch_mstr();

                if (isRefresh)
                {
                    if (reurntype.Equals("all"))
                    {
                        strwhere = "select top 100 batch_id,batch_doc,batch_status,batch_cre_date," +
                            "batch_dec01,batch_user_ip FROM plr_batch_mstr";
                    }
                    else
                    {
                        strwhere = "select top 1 batch_id,batch_doc,batch_status,batch_cre_date," +
                                        "batch_dec01,batch_user_ip FROM plr_batch_mstr where Batch_ID='" + batchid + "'";
                    }

                    plr_batch_mstr_ds1 = DbHelperSQL.Query(strwhere);

                    dgv.DataSource = plr_batch_mstr_ds1.Tables[0].DefaultView;
                    initHeaderTextPlrBatchMstr1(dgv);
                    dgv.Refresh();
                    if (reurntype.Equals("ds"))
                    {
                        return plr_batch_mstr_ds1;
                    }
                }
                if (reurntype.Equals("model"))
                {
                    plr_batch_mstr_model = new PIE.BLL.plr_batch_mstr().GetModel(batchid);
                    return plr_batch_mstr_model;
                }
                if (reurntype.Equals("ds"))
                {
                    strwhere = "select top 1 batch_id,batch_doc,batch_status,batch_cre_date," +
                "batch_dec01,batch_user_ip FROM plr_batch_mstr where Batch_ID='" + batchid + "'";
                    plr_batch_mstr_ds1 = DbHelperSQL.Query(strwhere);

                    return plr_batch_mstr_ds1;
                }
                if (reurntype.Equals("all"))
                {
                    strwhere = "select batch_id,batch_doc,batch_status,batch_cre_date,batch_dec01,batch_user_ip FROM plr_batch_mstr";
                    plr_batch_mstr_ds1 = DbHelperSQL.Query(strwhere);
                    return plr_batch_mstr_ds1;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        /// <summary>
        /// plr_batch_mstr
        /// </summary>
        /// <param name="ctftobj">CartonFromTo</param>
        /// <param name="isRefresh">ture,false</param>
        /// <param name="reurntype">datasets 50 or dataset1 or model(all,ds,model,nothing(if only refresh))</param>
        /// <returns>datasets 50 or dataset1 or model(all,ds,model,nothing(if only refresh))</returns>
        public object initDataGVplr_mstr(object ctftobj, bool isRefresh, string reurntype)
        {
            CartonFromTo ctft = (CartonFromTo)ctftobj;
            var batchid = ctft._batchID;
            var lineid = ctft._lineID;

            try
            {
                string strwhere;
                StringBuilder strSql;
                DataSet plr_mstr_ds;

                PIE.Model.plr_mstr plr_mstr = new PIE.Model.plr_mstr();

                strwhere = " Batch_ID='" + batchid + "' ";

                if (isRefresh)
                {
                    if (lineid != 0)
                    {
                        strwhere += " and LineID='" + lineid + "' ";
                    }
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("Batch_ID,LineID,plr_status,plr_pallet_no,InvoiceID,plr_po,packingListID,plr_partno,CartonType,");
                    strSql.Append("CartonID,plr_carton_qty,plr_qty,plr_rcp_date,plr_deli_date,carton_id_prifix,carton_id_from,carton_id_to,");
                    strSql.Append("re_mark,plr_site,plr_co,plr_date_code,plr_vend_mfgr,");
                    strSql.Append("Plr_vm_partno,plr_doc_type,plr_ttl,plr_um,plr_nw,plr_gw,");
                    strSql.Append("plr_msm,plr_cre_date,");
                    strSql.Append("plr_update_date");
                    strSql.Append(" FROM plr_mstr ");
                    strSql.Append(" where ");
                    strSql.Append(strwhere);

                    plr_mstr_ds = DbHelperSQL.Query(strSql.ToString());


                    var dgv = ctft._dgv;
                    dgv.DataSource = plr_mstr_ds.Tables[0].DefaultView;

                    initHeaderTextPlrMstr2(dgv);

                    dgv.Refresh();

                    if (reurntype.Equals("ds"))
                    {
                        return plr_mstr_ds;
                    }
                }
                if (reurntype.Equals("model"))
                {
                    plr_mstr = new PIE.BLL.plr_mstr().GetModel(batchid, lineid);
                    return plr_mstr;
                }
                if (reurntype.Equals("ds"))
                {
                    if (lineid != 0)
                    {
                        strwhere += " and LineID='" + lineid + "' ";
                    }
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("Batch_ID,LineID,plr_status,plr_pallet_no,InvoiceID,plr_po,packingListID,plr_partno,CartonType,");
                    strSql.Append("CartonID,plr_carton_qty,plr_qty,plr_rcp_date,plr_deli_date,carton_id_prifix,carton_id_from,carton_id_to,");
                    strSql.Append("re_mark,plr_site,plr_co,plr_date_code,plr_vend_mfgr,");
                    strSql.Append("Plr_vm_partno,plr_doc_type,plr_ttl,plr_um,plr_nw,plr_gw,");
                    strSql.Append("plr_msm,plr_cre_date,");
                    strSql.Append("plr_update_date");
                    strSql.Append(" FROM plr_mstr ");
                    strSql.Append(" where ");
                    strSql.Append(strwhere);

                    plr_mstr_ds = DbHelperSQL.Query(strSql.ToString());
                    return plr_mstr_ds;
                }
                if (reurntype.Equals("all"))
                {
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("Batch_ID,LineID,plr_status,plr_pallet_no,InvoiceID,plr_po,packingListID,plr_partno,CartonType,");
                    strSql.Append("CartonID,plr_carton_qty,plr_qty,plr_rcp_date,plr_deli_date,carton_id_prifix,carton_id_from,carton_id_to,");
                    strSql.Append("re_mark,plr_site,plr_co,plr_date_code,plr_vend_mfgr,");
                    strSql.Append("Plr_vm_partno,plr_doc_type,plr_ttl,plr_um,plr_nw,plr_gw,");
                    strSql.Append("plr_msm,plr_cre_date,");
                    strSql.Append("plr_update_date");
                    strSql.Append(" FROM plr_mstr ");

                    plr_mstr_ds = DbHelperSQL.Query(strSql.ToString());
                    return plr_mstr_ds;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        /// <summary>
        /// plr_batch_mstr
        /// </summary>
        /// <param name="ctftobj">CartonFromTo</param>
        /// <param name="isRefresh">ture,false</param>
        /// <param name="reurntype">datasets 50 or dataset1 or model(all,ds,model,nothing(if only refresh))</param>
        /// <returns>datasets 50 or dataset1 or model(all,ds,model,nothing(if only refresh))</returns>
        public object initDataGVplr_mstr_tran(object ctftobj, bool isRefresh, string reurntype)
        {
            CartonFromTo ctft = (CartonFromTo)ctftobj;
            var batchid = ctft._batchID;
            var lineid = ctft._lineID;
            var wecid = ctft._wec_ctn_Fr;
            var carton = ctft._cartonID;

            try
            {
                string strwhere;
                StringBuilder strSql;
                DataSet plr_mstr_tran_ds;

                PIE.Model.plr_mstr_tran plr_mstr_tran = new PIE.Model.plr_mstr_tran();

                strwhere = " Batch_ID='" + batchid + "' ";

                if (isRefresh)
                {


                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,plr_pallet_no,CartonNo,CartonID,plr_wec_ctn,plr_po,");
                    strSql.Append("plr_partno,CartonType,plr_carton_qty,plr_qty,packingListID,InvoiceID,");
                    strSql.Append("plr_rcp_date,plr_deli_date,");
                    strSql.Append("Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date");
                    strSql.Append(" FROM plr_mstr_tran");

                    if (!reurntype.Equals("all"))
                    {
                        if (lineid != 0)
                        {
                            strwhere += " and LineID='" + lineid + "' ";
                        }
                    }
                    else
                    {
                        strwhere = " plr_status <>'U' ";
                    }

                    strSql.Append(" where ");
                    strSql.Append(strwhere);

                    plr_mstr_tran_ds = DbHelperSQL.Query(strSql.ToString());


                    var dgv = ctft._dgv;
                    dgv.DataSource = plr_mstr_tran_ds.Tables[0].DefaultView;

                    initHeaderTextCartonDetails3(dgv);

                    dgv.Refresh();

                    if (!reurntype.Equals("model"))
                    {
                        return plr_mstr_tran_ds;
                    }
                }
                if (reurntype.Equals("model"))
                {
                    plr_mstr_tran = new PIE.DAL.plr_mstr_tran().GetModel(batchid, lineid);
                    return plr_mstr_tran;
                }
                if (reurntype.Equals("ds"))
                {
                    if (lineid != 0)
                    {
                        strwhere += " and LineID='" + lineid + "' ";
                    }
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,plr_pallet_no,CartonNo,CartonID,plr_wec_ctn,plr_po,");
                    strSql.Append("plr_partno,CartonType,plr_carton_qty,plr_qty,packingListID,InvoiceID,");
                    strSql.Append("plr_rcp_date,plr_deli_date,");
                    strSql.Append("Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date");
                    strSql.Append(" FROM plr_mstr_tran");
                    strSql.Append(" where ");
                    strSql.Append(strwhere);

                    plr_mstr_tran_ds = DbHelperSQL.Query(strSql.ToString());
                    return plr_mstr_tran_ds;
                }
                if (reurntype.Equals("all"))
                {
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,plr_pallet_no,CartonNo,CartonID,plr_wec_ctn,plr_po,");
                    strSql.Append("plr_partno,CartonType,plr_carton_qty,plr_qty,packingListID,InvoiceID,");
                    strSql.Append("plr_rcp_date,plr_deli_date,");
                    strSql.Append("Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date");
                    strSql.Append(" FROM plr_mstr_tran");

                    plr_mstr_tran_ds = DbHelperSQL.Query(strSql.ToString());
                    return plr_mstr_tran_ds;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        /// <summary>
        /// pi_mstr
        /// </summary>
        /// <param name="ctftobj">CartonFromTo</param>
        /// <param name="isRefresh">ture,false</param>
        /// <param name="reurntype">datasets 50 or dataset1 or model(all,ds,model,nothing(if only refresh))</param>
        /// <returns>datasets 50 or dataset1 or model(all,ds,model,nothing(if only refresh))</returns>
        public object initDataGVpi_mstr(object ctftobj, bool isRefresh, string reurntype)
        {
            CartonFromTo ctft = (CartonFromTo)ctftobj;
            var batchid = ctft._batchID;
            var lineid = ctft._lineID;
            try
            {
                string strwhere;
                StringBuilder strSql;
                DataSet pi_mstr_ds;

                PI.Model.pi_mstr pi_mstr = new PI.Model.pi_mstr();

                strwhere = " PI_ID='" + batchid + "' ";

                if (isRefresh)
                {
                    if (lineid != 0)
                    {
                        strwhere += " and LineID='" + lineid + "' ";
                    }
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("PI_ID,LineID,Plant,pi_type,pi_status,pi_status_msg,pi_remark, ");
                    strSql.Append("pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id, ");
                    strSql.Append("pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2  ");
                    strSql.Append(" FROM pi_mstr ");
                    strSql.Append(" where ");
                    strSql.Append(strwhere);

                    pi_mstr_ds = DbHelperSQL.Query(strSql.ToString());


                    var dgv = ctft._dgv;
                    dgv.DataSource = pi_mstr_ds.Tables[0].DefaultView;

                    initHeaderTextPlrMstr2(dgv);

                    dgv.Refresh();

                    if (reurntype.Equals("ds"))
                    {
                        return pi_mstr_ds;
                    }
                }
                if (reurntype.Equals("model"))
                {
                    pi_mstr = new PI.DAL.pi_mstr().GetModel(batchid, lineid);
                    return pi_mstr;
                }
                if (reurntype.Equals("ds"))
                {
                    if (lineid != 0)
                    {
                        strwhere += " and LineID='" + lineid + "' ";
                    }
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("PI_ID,LineID,Plant,pi_type,pi_status,pi_status_msg,pi_remark, ");
                    strSql.Append("pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id, ");
                    strSql.Append("pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2  ");
                    strSql.Append(" FROM pi_mstr ");
                    strSql.Append(" where ");
                    strSql.Append(strwhere);


                    pi_mstr_ds = DbHelperSQL.Query(strSql.ToString());
                    return pi_mstr_ds;
                }
                if (reurntype.Equals("all"))
                {
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("PI_ID,LineID,Plant,pi_type,pi_status,pi_status_msg,pi_remark, ");
                    strSql.Append("pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id, ");
                    strSql.Append("pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2  ");
                    strSql.Append(" FROM pi_mstr ");
                    strSql.Append(" where ");
                    pi_mstr_ds = DbHelperSQL.Query(strSql.ToString());
                    return pi_mstr_ds;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        /// <summary>
        /// pi_det
        /// </summary>
        /// <param name="ctftobj">CartonFromTo</param>
        /// <param name="isRefresh">ture,false</param>
        /// <param name="reurntype">datasets 50 or dataset1 or model(all,ds,model,nothing(if only refresh))</param>
        /// <returns>datasets 50 or dataset1 or model(all,ds,model,nothing(if only refresh))</returns>
        public object initDataGVpi_det(object ctftobj, bool isRefresh, string reurntype)
        {
            CartonFromTo ctft = (CartonFromTo)ctftobj;
            var batchid = ctft._batchID;
            var lineid = ctft._lineID;
            try
            {
                string strwhere;
                StringBuilder strSql;
                DataSet pi_det_ds;

                PI.Model.pi_det pi_det = new PI.Model.pi_det();

                strwhere = " PI_ID='" + batchid + "' ";

                if (isRefresh)
                {
                    if (lineid != 0)
                    {
                        strwhere += " and pi_LineID='" + lineid + "' ";
                    }
                    strSql = new StringBuilder();
                    //strSql.Append("select ");
                    //strSql.Append("PI_ID,LineID,Plant,pi_type,pi_status,pi_status_msg,pi_remark, ");
                    //strSql.Append("pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id, ");
                    //strSql.Append("pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2  ");
                    //strSql.Append(" FROM pi_mstr ");
                    //strSql.Append(" where ");
                    strSql.Append("select ");
                    strSql.Append("PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID, ");
                    strSql.Append("pi_type,pi_status,pi_status_msg,pi_remark, ");
                    strSql.Append("pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 ");
                    strSql.Append(" FROM pi_det ");
                    strSql.Append(" where ");
                    strSql.Append(strwhere);

                    pi_det_ds = DbHelperSQL.Query(strSql.ToString());


                    var dgv = ctft._dgv;
                    dgv.DataSource = pi_det_ds.Tables[0].DefaultView;
                    ///***************
                    //initHeaderTextCartonDetails3(dgv);

                    dgv.Refresh();

                    if (reurntype.Equals("ds"))
                    {
                        return pi_det_ds;
                    }
                }
                if (reurntype.Equals("model"))
                {
                    pi_det = new PI.DAL.pi_det().GetModel(batchid, lineid);
                    return pi_det;
                }
                if (reurntype.Equals("ds"))
                {
                    if (lineid != 0)
                    {
                        strwhere += " and pi_LineID='" + lineid + "' ";
                    }
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID, ");
                    strSql.Append("pi_type,pi_status,pi_status_msg,pi_remark, ");
                    strSql.Append("pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 ");
                    strSql.Append(" FROM pi_det ");
                    strSql.Append(" where ");
                    strSql.Append(strwhere);


                    pi_det_ds = DbHelperSQL.Query(strSql.ToString());
                    return pi_det_ds;
                }
                if (reurntype.Equals("all"))
                {
                    strSql = new StringBuilder();
                    strSql.Append("select ");
                    strSql.Append("PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID, ");
                    strSql.Append("pi_type,pi_status,pi_status_msg,pi_remark, ");
                    strSql.Append("pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 ");
                    strSql.Append(" FROM pi_det ");

                    pi_det_ds = DbHelperSQL.Query(strSql.ToString());
                    return pi_det_ds;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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
            //dgv.Columns["plr_suppliers_id"].HeaderText = "Suppliers";
            dgv.Columns["batch_doc"].HeaderText = "Batch Type";
            dgv.Columns["batch_status"].HeaderText = "Void";//"Status";
            //dgv.Columns["batch_void"].HeaderText = "Void";

            dgv.Columns["batch_cre_date"].HeaderText = "Create Date";
            //dgv.Columns["batch_update_date"].HeaderText = "Update Date";
            //dgv.Columns["batch_cre_user"].HeaderText = "User Id";
            //dgv.Columns["batch_user_ip"].HeaderText = "Client IP";
            //dgv.Columns["batch_chr01"].HeaderText = "other";
            dgv.Columns["batch_dec01"].HeaderText = "Items Count";
            dgv.Columns["batch_user_ip"].HeaderText = "Create IP";

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
        private void initHeaderTextPIDet(DataGridView dgv)
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
        public static void getBatchiLineId(DataGridView dgv, int eIndex, PIE.Model.plr_mstr plr_mstr_model)
        {
            if (eIndex >= 0 && eIndex < dgv.Rows.Count - 1)
            {

                plr_mstr_model.Batch_ID = dgv.Rows[eIndex].Cells["Batch_ID"].Value.ToString().Trim();
                plr_mstr_model.LineID = Convert.ToInt32(dgv.Rows[eIndex].Cells["LineID"].Value);
            }
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

        public int getMaxOrMinColumnFromDataTable(System.Data.DataTable dt, string columnname, bool getmax, bool onebyone)
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
                        if (onebyone)
                        {
                            if (result - max > 1)
                            {
                                break;
                            }
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
        public void initScanTXT(TextBox tb, int secMorelen, int substringlen)
        {
            if (tb.Text.Length >= substringlen)
            {
                char ckey = '\'';
                string skey = "<|>";
                string str12 = tb.Text.Replace(ckey, ' ');
                if (tb.Text.IndexOf(skey) > 0 && tb.Text.Length >= secMorelen)
                {
                    str12 = str12.Replace(skey, " ");
                }
                tb.Text = str12.Substring(str12.Length - substringlen, substringlen);
                tb.SelectionStart = tb.Text.Length;
            }
        }
        public void UploadtoERP(frmPIE.frm412UploadToERP frm4uploadToERP)
        {
            try
            {
                string strWheretran = "plr_status = 'C'";
                if (!string.IsNullOrEmpty(frm4uploadToERP._strbatchid))
                {

                    strWheretran += " and Batch_ID='" + frm4uploadToERP._strbatchid + "' ";
                }

                string strWhereMast = "";
                string strPO = "";
                string strPO_mstr = "";

                int intUploadSum = 0;
                int intUploadCount = 0;
                int intUploadDup = 0;
                int intUploadErrCount = 0;


                string strResult = "";

                WebReference100.Service server100 = new WebReference100.Service();
                server100.Timeout = 9000000;

                DataSet ds = null;

                List<PIE.Model.plr_mstr> plr_mstr_ls = null;

                List<PIE.Model.plr_mstr_tran> plr_mstr_tran_ls = new PIE.BLL.plr_mstr_tran().GetModelList(strWheretran);



                if (plr_mstr_tran_ls != null && plr_mstr_tran_ls.Count > 0)
                {

                    intUploadSum = plr_mstr_tran_ls.Count;
                    var currint = 0;
                    foreach (PIE.Model.plr_mstr_tran item in plr_mstr_tran_ls)
                    {
                        char ckey = '@';
                        strPO = item.Batch_ID + "@" + "" + "@" + "" + "@" +
                                                     item.InvoiceID + "@" + item.plr_po + "@" + "" + "@" +
                                                     item.plr_partno + "@" + item.plr_site + "@" + item.Plr_vm_partno + "@" + item.plr_vend_mfgr + "@" + "" + "@" +
                                                     item.plr_co + "@" + item.plr_date_code + "@" + "" + "@" + "" + "@" +
                                                     item.plr_qty + "@" + "" + "@" +
                                                     item.Wec_Ctn + "@" + item.CartonNo + "@" + item.plr_carton_qty + "@" +
                                                     "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" + "" + "@" +
                                                     item.CartonID + "@" + item.plr_pallet_no;
                        strPO = @strPO.ToString();

                        currint++;

                        SetCtlTextdelegate(frm4uploadToERP.lbl0MsgUploadToERP, "$UploadToERP: Notice: 第 " + currint + " 条开始上传", true, true);

                        var returnWeb = initWebServer(item.plr_po, server100, "wsas013", strPO, out ds);
                        if (returnWeb)
                        {
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                string strResultWebser = ds.Tables[0].Rows[0][4].ToString();
                                string strErrMessage = ds.Tables[0].Rows[0][5].ToString();
                                string strABC = ds.Tables[0].Rows[0][6].ToString();
                                string strcheck = ds.Tables[0].Rows[0][7].ToString();

                                item.plr_chr01 = strABC;
                                item.plr_chr02 = strcheck;

                                if (strResultWebser.Equals("2"))
                                {
                                    item.plr_status = "U";
                                    item.plr_status_msg = strErrMessage;
                                    item.plr_update_date = DateTime.Now;
                                    item.plr_user_ip = getClientIP();

                                    var intupdate = new PIE.BLL.plr_mstr_tran().Update(item);

                                    intUploadCount++;

                                    SetCtlTextdelegate(frm4uploadToERP.lbl0MsgUploadToERP, "$UploadToERP: Notice: 第 " + intUploadCount + " 条上传Success。", true, true);

                                }
                                else if (strResultWebser.Equals("1"))
                                {

                                    item.plr_status = "U";
                                    item.plr_status_msg = strErrMessage;
                                    item.plr_update_date = DateTime.Now;
                                    item.plr_user_ip = getClientIP();

                                    var intupdate = new PIE.BLL.plr_mstr_tran().Update(item);

                                    intUploadDup++;
                                }
                                else
                                {
                                    item.plr_status = "E";
                                    item.plr_status_msg = strErrMessage;

                                    item.plr_update_date = DateTime.Now;
                                    item.plr_user_ip = getClientIP();

                                    var intupdate = new PIE.BLL.plr_mstr_tran().Update(item);
                                    strResult = strResult + "未上传：" + item.Batch_ID + "," + item.LineID + ",Error:" + strErrMessage + "\n";
                                    intUploadErrCount++;
                                }

                            }
                            else
                            {

                                item.plr_status = "N";
                                item.plr_status_msg = "WebServer Error 没有返回值";

                                item.plr_update_date = DateTime.Now;
                                item.plr_user_ip = getClientIP();

                                var intupdate = new PIE.BLL.plr_mstr_tran().Update(item);
                                strResult = strResult + "未上传：" + item.Batch_ID + "," + item.LineID + ",Error:" + "WebServer 没有返回值" + "\n";
                                intUploadErrCount++;
                            }

                        }
                        else
                        {
                            strResult = "$UploadToERP: Error: Webservice 连接超时.";
                            break;
                        }

                    }
                    strResult = strResult == "" ? "\t1. 需要上传：" + intUploadSum + "条,\n\t2. 上传：" + intUploadCount + "条记录OK.\n\t3. 有" + intUploadDup + "条重复。\n\t4. 有" + intUploadErrCount + "条上传失败。\n" : "\t1. 需要上传：" + intUploadSum + "条,\n\t2. 上传：" + intUploadCount + "条记录OK.\n\t3. 有" + intUploadDup + "条重复。\n\t4. 有" + intUploadErrCount + "条上传失败。\n" + "\t5.失败的记录:\n" + strResult;


                }
                else
                {
                    strResult = "$UploadToERP: Error: 系统数据库中没有可上传的（C状态）记录。";
                }
                SetCtlTextdelegate(frm4uploadToERP.lbl0MsgUploadToERP, strResult, true, true);
                SetToolTextdelegate(_idr_show.status15toolLabelstrResult, strResult, true, true);
                MessageBox.Show(strResult);
                _uploaderpmsg = "$UploadToERP: 上传ERP完成。";

            }
            catch (Exception ex)
            {

                _uploaderpmsg = "$UploadToERP: Error:" + ex.Message;
            }


        }
        public bool isNumber(System.Windows.Forms.TextBox tb, Control cl)
        {
            if (!PageValidate.IsNumber(tb.Text))
            {
                tb.Focus();
                tb.SelectAll();
                cl.Text = "Notice:请输入正确的数字，谢谢.";
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

            frmPIE.frm513PrintCartonLabel frm513PCL = (frmPIE.frm513PrintCartonLabel)_cartonfromto._objclass;
            decimal wec_ctn_Fr = _cartonfromto._wec_ctn_Fr;
            decimal wec_ctn_To = _cartonfromto._wec_ctn_To;
            string print_Type = _cartonfromto._print_Type;
            string print_port = _cartonfromto._print_port;

            StringBuilder strtxt = new StringBuilder();


            string strfromto = wec_ctn_Fr.ToString() + "-" + wec_ctn_To.ToString();

            //btnPrint.Enabled = false;
            SetCtlTextdelegate(frm513PCL.btn0Print_PrintCartonLabel, "Print...", false, true);
            SetCtlTextdelegate(frm513PCL.lbl0PrintMsg, "Printing ......", true, true);

            while (wec_ctn_Fr <= wec_ctn_To)
            {

                strWhere = "Wec_Ctn='" + wec_ctn_Fr + "'";

                List<PIE.Model.plr_mstr_tran> plr_mstr_tran_list = new PIE.BLL.plr_mstr_tran().GetModelList(strWhere);
                int listcount = plr_mstr_tran_list.Count;
                if (listcount > 0)
                {

                    if (print_Type.Equals("ZPL"))
                    {
                        int x = 39;
                        int y = 30;
                        int xoff = 0;
                        int yoff = 50;

                        #region zpl
                        strtxt.AppendLine("^XA");
                        strtxt.AppendLine("^EG");
                        strtxt.AppendLine("^XZ");
                        strtxt.AppendLine("^XA");

                        strtxt.AppendLine("^MCY");
                        strtxt.AppendLine("^XZ");
                        strtxt.AppendLine("^XA");

                        strtxt.AppendLine("^FWN^CFD,24^PW905^LH0,0");
                        strtxt.AppendLine("^CI3^PR2^MNY^MTT^MMT^MD3.5^JJ0,0^PON^PMN^LRN");
                        strtxt.AppendLine("^LT-9");
                        strtxt.AppendLine("^XZ");
                        strtxt.AppendLine("^XA");

                        strtxt.AppendLine("^DFR:TEMP_FMT.ZPL");
                        strtxt.AppendLine("^LRN");
                        strtxt.AppendLine("^XZ");
                        strtxt.AppendLine("^XA");

                        strtxt.AppendLine("^XFR:TEMP_FMT.ZPL");
                        strtxt.AppendLine("^A0N,161,104^FO573,14^FD" + plr_mstr_tran_list[0].CartonID + "^FS");
                        strtxt.AppendLine("^A0N,42,42^FO601,191^FD" + plr_mstr_tran_list[0].plr_vend_mfgr + "^FS");
                        int totoal = 0;
                        for (int i = 0; i < listcount; i++)
                        {
                            totoal = totoal + Convert.ToInt32(plr_mstr_tran_list[i].plr_qty);
                            if (i >= limitCount)
                            {
                                continue;
                            }
                            strtxt.AppendLine("^A0N,44,30^FO" + (x) + "," + (y + yoff * i) + "^FD" + plr_mstr_tran_list[i].plr_partno + "^FS");
                            strtxt.AppendLine("^A0N,44,30^FO" + (x + 300) + "," + (y + yoff * i + 2) + "^FD" + plr_mstr_tran_list[i].plr_qty + "^FS");

                        }
                        if (listcount > limitCount)
                        {
                            strtxt.AppendLine(@"^A0N,44,30^FO30,392^FD ..................");
                        }
                        strtxt.AppendLine("^A0N,44,30^FO36,392^FDT0TAL: " + listcount.ToString() + "^FS");

                        strtxt.AppendLine("^A0N,44,30^FO344,391^FD" + totoal.ToString() + "^FS");

                        strtxt.AppendLine("^BY2,2.0^FO433,273^B3N,Y,104,N^FD" + plr_mstr_tran_list[0].plr_wec_ctn + "^FS");


                        strtxt.AppendLine("^PQ1,0,1,Y");

                        strtxt.AppendLine("^XZ");
                        strtxt.AppendLine("^XA");

                        strtxt.AppendLine("^IDR:TEMP_FMT.ZPL");
                        strtxt.AppendLine("^XZ");
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

                    SetCtlTextdelegate(frm513PCL.lbl0PrintMsg, "$Print 生成第" + wec_ctn_Fr.ToString() + "条打印文件Success.", true, true);
                }
                else
                {
                    intPrintErrorCount++;
                    messageBoxError = messageBoxError + wec_ctn_Fr.ToString() + ",\t";

                }
                wec_ctn_Fr++;
                intPrintCount++;
            }
            if (intPrintErrorCount == intPrintCount)
            {
                SetCtlTextdelegate(frm513PCL.lbl0PrintMsg, "$Print: 无" + strfromto + "的记录。", true, true);
                SetCtlTextdelegate(frm513PCL.btn0Print_PrintCartonLabel, "&Print", true, true);
                SetCtlTextdelegate(frm513PCL.lbl0PrintMsg, "$Print: Printing End", true, true);
                return;
            }
            else if (intPrintErrorCount > 0)
            {

                SetCtlTextdelegate(frm513PCL.lbl0PrintMsg, "$Print: 无" + messageBoxError + "的记录。", true, true);
            }
            string strprefix = print_Type;
            if (frm513PCL.chk0PrintToFile_PrintCartonLabel.Checked)
            {

                _idr_show._strSaveLabelFile = strprefix + strfromto + ".txt";
                var returnresult = Xprint.XPrint.WriteTxT(_idr_show._strSaveLabelFile, strtxt);

                messageBox = "\tSuccess: 总打印：" + intPrintCount + "条记录。TXT文件存于: \n" + returnresult;

                if (!string.IsNullOrEmpty(returnresult))
                {

                    resultmsg = "Notice: 打印 " + strprefix + strfromto;
                    var dialogbutton = MessageBox.Show(messageBox + " Success.\n\t是否打印些文件？", "Notice:Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dialogbutton == DialogResult.Yes)
                    {
                        if (Xprint.XPrint.Print(strtxt.ToString(), print_port))
                        {
                            resultmsg += " 成功。";
                        }
                        else
                        {
                            resultmsg += " 失败,本地打印端口:" + print_port + "打开失败或打印机未就绪。";
                        }
                    }
                    else
                    {

                        resultmsg += messageBox;

                    }
                }
                else
                {
                    MessageBox.Show(messageBox + " Fail.");
                }

            }
            else
            {
                resultmsg = "Notice: 打印 " + strprefix + strfromto;

                if (Xprint.XPrint.Print(strtxt.ToString(), print_port))
                {
                    resultmsg += " 成功。";
                }
                else
                {
                    resultmsg += " 失败,本地打印端口:" + print_port + "打开失败或打印机未就绪。";
                }
            }

            //btnPrint.Enabled = true;
            SetCtlTextdelegate(frm513PCL.btn0Print_PrintCartonLabel, "&Print", true, true);
            SetCtlTextdelegate(frm513PCL.lbl0PrintMsg, resultmsg, true, true);
            SetToolTextdelegate(_idr_show.status15toolLabelstrResult, resultmsg, true, true);

        }
        public void initThreadDowrokColor(DoWrokObject dwo)
        {
            if (dwo._eX >= 0 && dwo._eX < dwo._dgv.RowCount)
            {


                _idr_show._tDoWorkBackClorThread = new Thread(new ParameterizedThreadStart(DoWorkCellSelectColordelegate));
                if (_idr_show._tDoWorkBackClorThread.ThreadState == ThreadState.Running)
                {
                    _idr_show._tDoWorkBackClorThread.Abort();
                }
                if (_idr_show._tDoWorkBackClorThread.ThreadState == ThreadState.Unstarted)
                {
                    _idr_show._tDoWorkBackClorThread.Start(dwo);

                }
                if (_idr_show._tDoWorkBackClorThread.ThreadState == ThreadState.Stopped)
                {
                    _idr_show._tDoWorkBackClorThread = new Thread(new ParameterizedThreadStart(DoWorkCellSelectColordelegate));
                    _idr_show._tDoWorkBackClorThread.Start(dwo);

                }
            }
        }


        /// <summary>
        /// set dgv,dgv1,ex,ey;
        /// </summary>
        /// <param name="dwo">dgv,dgv1,ex,ey</param>
        public void selectCellMethod(DoWrokObject dwo, bool mainDataGV)
        {


            _idr_show.status14toolLabelCellRowColXY.Text = "总计:" + (dwo._dgv.Rows.Count - 1) + ",当前行:" + (dwo._eX + 1) + ",列:" + (dwo._eY + 1);
            try
            {
                if (dwo._eX >= 0 && dwo._eX < dwo._dgv.RowCount - 1)
                {
                    _plr_mstr_model.Batch_ID = dwo._dgv.Rows[dwo._eX].Cells["Batch_ID"].Value.ToString().Trim();

                    _plr_mstr_model.LineID = Convert.ToInt32(dwo._dgv.Rows[dwo._eX].Cells["LineID"].Value);
                    _plr_mstr_model.CartonID = dwo._dgv.Rows[dwo._eX].Cells["CartonID"].Value.ToString().Trim();

                    selectNextDGVRow(dwo._dgv1, "LineID", _plr_mstr_model.LineID.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string selectCellMethod(DoWrokObject dwo)
        {
            _idr_show.status14toolLabelCellRowColXY.Text = "总计:" + (dwo._dgv.Rows.Count - 1) + ",当前行:" + (dwo._eX + 1) + ",列:" + (dwo._eY + 1);
            try
            {
                if (dwo._eX >= 0 && dwo._eX < dwo._dgv.RowCount - 1)
                {
                    _plr_mstr_model.Batch_ID = dwo._dgv.Rows[dwo._eX].Cells["Batch_ID"].Value.ToString().Trim();
                    return _plr_mstr_model.Batch_ID;
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }

        }
        public void selectNextDGVRow(DataGridView dgv, string colName, string colValue)
        {
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells[colName].Value.ToString().Equals(colValue))
                {
                    dgv.Rows[i].Cells[0].Selected = true;
                    break;
                }
            }
        }
        public void initWECPrintFromTo(object objCartonFromTo)
        {
            CartonFromTo cfo = (CartonFromTo)objCartonFromTo;
            if (cfo._ds != null)
            {
                var count = cfo._ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    cfo._clfrom.Text = getMaxOrMinColumnFromDataTable(cfo._ds.Tables[0], "Wec_Ctn", false).ToString();

                    cfo._clto.Text = getMaxOrMinColumnFromDataTable(cfo._ds.Tables[0], "Wec_Ctn", true).ToString();

                }
            }
            else
            {
                cfo._clfrom.Text = "";
                cfo._clto.Text = "";
            }
        }

        public void OpenFolderAndSelectFile(String fileFullName)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            System.Diagnostics.Process.Start(psi);
        }
        /////////////////////////////////////
        //start place
        /////////////////////////////////
    }

}
