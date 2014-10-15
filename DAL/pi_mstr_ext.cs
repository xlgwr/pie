using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:pi_mstr_ext
    /// </summary>
    public partial class pi_mstr_ext : pi_mstr
    {
        public pi_mstr_ext()
        { }
        /// <summary>
        /// 得到一个对象实体pi_chr01>PI add from epacking batchid
        /// </summary>
        public PI.Model.pi_mstr GetModel(string pi_chr01)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PI_ID,LineID,Plant,pi_type,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 from pi_mstr ");
            strSql.Append(" where pi_chr01=@pi_chr01 ");
            SqlParameter[] parameters = {
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50)	};
            parameters[0].Value = pi_chr01;

            PI.Model.pi_mstr model = new PI.Model.pi_mstr();
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
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder,bool forenquire)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" PI_ID,pi_status,Plant,pi_type,pi_user_ip,pi_remark,pi_cre_date,pi_chr01 ");
            strSql.Append(" FROM pi_mstr ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

    }
}

