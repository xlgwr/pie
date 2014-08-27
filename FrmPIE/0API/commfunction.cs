using System;
using System.Collections.Generic;
using System.Web.Services.Description;
using System.Windows.Forms;

using PIE.DBUtility;
using System.Data.SqlClient;
using System.Data;

using System.Net;
using System.Net.Sockets;

using System.DirectoryServices;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Text;

namespace FrmPIE._0API
{
    class commfunction
    {

        public delegate void dinitDataGridViewSource(object obj);
        public delegate void dSafeSetCtlText(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible);
        public delegate void dSafeSetToolText(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible);
        public delegate void dSafeSetDataGVds(System.Windows.Forms.DataGridView ctl, DataSet ds, int selectIndexRow, int intselectIndexCol);
        public commfunction()
        {
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
                    strwhere = "select top 1 batch_id,batch_doc,batch_status,batch_cre_date," +
                        "batch_dec01,batch_user_ip FROM plr_batch_mstr where Batch_ID='" + batchid + "'";
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
                        strwhere += " and LineID='" + batchid + "' ";
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
                        strwhere += " and LineID='" + batchid + "' ";
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

                if (reurntype.Equals("model"))
                {
                    plr_mstr = new PIE.BLL.plr_mstr().GetModel(batchid, lineid);
                    return plr_mstr;
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
    }

}
