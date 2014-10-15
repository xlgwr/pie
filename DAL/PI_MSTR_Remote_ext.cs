using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:PI_MSTR_Remote_ext
    /// </summary>
    public partial class PI_MSTR_Remote_ext : PI_MSTR_Remote
    {

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.PI_MSTR_Remote model,bool nottimestamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PI_MSTR(");
            strSql.Append("PI_NO,PI_Date,PI_Page)");
            strSql.Append(" values (");
            strSql.Append("@PI_NO,@PI_Date,@PI_Page)");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_Date", SqlDbType.SmallDateTime),
					new SqlParameter("@PI_Page", SqlDbType.NVarChar,2)};
            parameters[0].Value = model.PI_NO;
            parameters[1].Value = model.PI_Date;
            parameters[2].Value = model.PI_Page;

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

