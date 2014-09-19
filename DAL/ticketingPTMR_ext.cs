using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:ticketingPTMR_ext
    /// </summary>
    public partial class ticketingPTMR_ext : ticketingPTMR
    {
        public ticketingPTMR_ext()
        { }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.ticketingPTMR GetModel(string t_suppliers_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 t_id,t_suppliers_id,t_inDocTime,t_backTime,t_outWait,t_receTime,t_outAwayTime,t_waitTime,t_totalTime,t_time01,t_time02,t_cre_date,t_update_date,t_cre_user,t_user_ip,t_chr01,t_chr02,t_chr03,t_dec01,t_dec02,t_int01,t_int02 from ticketingPTMR ");
            strSql.Append(" where t_suppliers_id=@t_suppliers_id and t_int01='1'");
            SqlParameter[] parameters = {
					new SqlParameter("@t_suppliers_id", SqlDbType.NVarChar,50)			};
            parameters[0].Value =t_suppliers_id;

            PIE.Model.ticketingPTMR model = new PIE.Model.ticketingPTMR();
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
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t_suppliers_id as 条码号,t_inDocTime as 入单时间,t_backTime as 返回时间 ,t_receTime as 收贷时间,t_outAwayTime as 离开时间,t_user_ip as 登记IP ");
            strSql.Append(" FROM ticketingPTMR ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

    }
}

