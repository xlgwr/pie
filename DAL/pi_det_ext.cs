using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:pi_det_ext
    /// </summary>
    /// 
    public partial class pi_det_ext : pi_det
    {
        string _strAttr = @"PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_type,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 from pi_det";
        public pi_det_ext()
        { }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string PI_ID, string change_pi_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update pi_det set ");
            strSql.Append("PI_ID=@change_pi_id ");
            strSql.Append(" where PI_ID=@PI_ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@change_pi_id", SqlDbType.NVarChar,50)
                                        };
            parameters[0].Value = PI_ID;
            parameters[1].Value = change_pi_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string strorderby)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_type,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 ");
            strSql.Append(" FROM pi_det ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + strorderby);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #region  BasicMethod
        /// <summary>
        /// 得到最大ID piid add where 
        /// </summary>
        public int GetMaxId(string piid)
        {
            return DbHelperSQL.GetMaxID("pi_deci1", "PI_ID='" + piid + "'", "pi_det", false);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string pi_wec_ctn)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from pi_det");
            strSql.Append(" where pi_wec_ctn=@pi_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50)			};

            parameters[0].Value = pi_wec_ctn;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_ID, int pi_LineID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from pi_det");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4)		};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PI.Model.pi_det GetModel(string PI_ID, int pi_LineID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 " + _strAttr);
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4) 		};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID;

            PI.Model.pi_det model = new PI.Model.pi_det();
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
        public PI.Model.pi_det GetModel(string PI_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 " + _strAttr);
            strSql.Append(" where PI_ID=@PI_ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50)	};
            parameters[0].Value = PI_ID;

            PI.Model.pi_det model = new PI.Model.pi_det();
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
        public PI.Model.pi_det GetModel(string PI_ID, int pi_pallet_num, bool palletSN)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 " + _strAttr);
            strSql.Append(" where PI_ID=@PI_ID and pi_deci1=@pi_pallet_num ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_pallet_num", SqlDbType.Int,4) 		};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_pallet_num;

            PI.Model.pi_det model = new PI.Model.pi_det();
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
        public PI.Model.pi_det DataRowToModel(DataRow row, bool distinct)
        {
            PI.Model.pi_det model = new PI.Model.pi_det();
            if (row != null)
            {
                if (row["pi_wec_ctn"] != null)
                {
                    model.pi_wec_ctn = row["pi_wec_ctn"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PI.Model.pi_det GetModel(string PI_ID, string pi_wec_ctn, int plr_LineID_tran)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 " + _strAttr);
            strSql.Append(" where PI_ID=@PI_ID and plr_LineID_tran=@plr_LineID_tran and pi_wec_ctn=@pi_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4)			};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_wec_ctn;
            parameters[2].Value = plr_LineID_tran;

            PI.Model.pi_det model = new PI.Model.pi_det();
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
        public PI.Model.pi_det GetModel(string PI_ID, string pi_wec_ctn)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 " + _strAttr);
            strSql.Append(" where PI_ID=@PI_ID and pi_wec_ctn=@pi_wec_ctn and pi_chr01 ='' ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50)			};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_wec_ctn;

            PI.Model.pi_det model = new PI.Model.pi_det();
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, bool distinct)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct pi_wec_ctn ");
            strSql.Append(" FROM pi_det ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

