using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:PI_DET_Remote_ext
    /// </summary>
    public partial class PI_DET_Remote_ext:PI_DET_Remote
    {


        /// <summary>
        /// 删除一条数据PI_NO
        /// </summary>
        public bool Delete(string PI_NO, bool delPi_no)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PI_DET ");
            strSql.Append(" where PI_NO=@PI_NO");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12)		};
            parameters[0].Value = PI_NO;

            int rows = DbHelperSQLP.ExecuteSql(strSql.ToString(), parameters);
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PI_DET");
            strSql.Append(" where PI_NO=@PI_NO ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12) };
            parameters[0].Value = PI_NO;

            return DbHelperSQLP.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(string PI_NO, string change_pi_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PI_DET set ");
            strSql.Append("PI_NO=@change_pi_id ");
            strSql.Append(" where PI_NO=@PI_NO");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12),
					new SqlParameter("@change_pi_id", SqlDbType.NVarChar,12)};
            parameters[0].Value = PI_NO;
            parameters[1].Value = change_pi_id;

            int rows = DbHelperSQLP.ExecuteSql(strSql.ToString(), parameters);
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

