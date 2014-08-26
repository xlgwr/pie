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

namespace FrmPIE._0API
{
    class commfunction
    {

        public delegate void initDataGridViewSource(object ctftobj);
        public delegate void SafeSetCtlText(System.Windows.Forms.Control ctl, string strMsg, bool enable, bool visible);
        public delegate void SafeSetToolText(System.Windows.Forms.ToolStripItem ctl, string strMsg, bool enable, bool visible);
        public delegate void SafeSetDataGVds(System.Windows.Forms.DataGridView ctl, DataSet ds, int selectIndexRow, int intselectIndexCol);
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

        public void initDataGVBM0(object ctftobj)
        {
            CartonFromTo ctft = (CartonFromTo)ctftobj;
            var dgv = ctft._dgv;
            var batchid = ctft._batchID;
            var lineid = ctft._lineID;
            var cartonid = ctft._cartonID;
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

                }
                dgv.DataSource = plr_batch_mstr_ds1.Tables[0].DefaultView;

                initHeaderTextPlrBatchMstr1(dgv);

                dgv.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }

}
