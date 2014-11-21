using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:pisr_grr_ext
    /// </summary>
    public partial class pisr_grr_ext:pisr_grr
    {

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string pi_wec_ctn, string pisr_rir,string getPrice,string piid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update pisr_grr set ");
            strSql.Append("pi_chr01=@pi_chr01,");
            strSql.Append("pi_chr02=@pi_chr02 ");
            strSql.Append(" where pi_wec_ctn=@pi_wec_ctn and pisr_rir=@pisr_rir ");
            SqlParameter[] parameters = {
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_rir", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr02", SqlDbType.NVarChar,50)};
            parameters[0].Value = pi_wec_ctn;
            parameters[1].Value = pisr_rir;
            parameters[2].Value = getPrice; 
            parameters[3].Value = piid;  

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
    }
}

