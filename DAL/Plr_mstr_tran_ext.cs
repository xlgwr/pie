using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:plr_mstr_tran_ext
    /// </summary>
    public partial class plr_mstr_tran_ext : plr_mstr_tran
    {
        string _strAtt = @"Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,CartonNo,CartonID,plr_wec_ctn,plr_po,plr_partno,CartonType,plr_carton_qty,plr_qty,plr_suppliers_id,packingListID,InvoiceID,plr_rcp_date,plr_pallet_no,plr_deli_date,plr_site,plr_co,plr_date_code,plr_vend_mfgr,Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2 from plr_mstr_tran ";
        public plr_mstr_tran_ext()
        { }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string plr_wec_ctn)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from plr_mstr_tran");
            strSql.Append(" where plr_wec_ctn=@plr_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@plr_wec_ctn", SqlDbType.NVarChar,50)};
            parameters[0].Value = plr_wec_ctn;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.plr_mstr_tran GetModel(string plr_wec_ctn)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 " + _strAtt);
            strSql.Append(" where plr_wec_ctn=@plr_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@plr_wec_ctn", SqlDbType.NVarChar,50)};
            parameters[0].Value = plr_wec_ctn;

            PIE.Model.plr_mstr_tran model = new PIE.Model.plr_mstr_tran();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.plr_mstr_tran GetModel(int LineID, string plr_wec_ctn)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 " + _strAtt);
            strSql.Append(" where LineID = @LineID and plr_wec_ctn=@plr_wec_ctn ");
            SqlParameter[] parameters = {
                    new SqlParameter("@LineID", SqlDbType.Int,4),
					new SqlParameter("@plr_wec_ctn", SqlDbType.NVarChar,50)};

            parameters[0].Value = LineID;
            parameters[1].Value = plr_wec_ctn;

            PIE.Model.plr_mstr_tran model = new PIE.Model.plr_mstr_tran();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.plr_mstr_tran GetModel(string Batch_ID, int LineID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 " + _strAtt);
            strSql.Append(" where Batch_ID=@Batch_ID and LineID=@LineID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@LineID", SqlDbType.Int,4)			};
            parameters[0].Value = Batch_ID;
            parameters[1].Value = LineID;

            PIE.Model.plr_mstr_tran model = new PIE.Model.plr_mstr_tran();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

