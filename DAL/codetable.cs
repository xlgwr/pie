using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:codetable
    /// </summary>
    public partial class codetable
    {
        public codetable()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string gb)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from codetable");
            strSql.Append(" where gb=@gb ");
            SqlParameter[] parameters = {
					new SqlParameter("@gb", SqlDbType.NChar,1)			};
            parameters[0].Value = gb;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.codetable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into codetable(");
            strSql.Append("gb,big)");
            strSql.Append(" values (");
            strSql.Append("@gb,@big)");
            SqlParameter[] parameters = {
					new SqlParameter("@gb", SqlDbType.NChar,1),
					new SqlParameter("@big", SqlDbType.NChar,1)};
            parameters[0].Value = model.gb;
            parameters[1].Value = model.big;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(PI.Model.codetable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update codetable set ");
            strSql.Append("big=@big");
            strSql.Append(" where gb=@gb ");
            SqlParameter[] parameters = {
					new SqlParameter("@big", SqlDbType.NChar,1),
					new SqlParameter("@gb", SqlDbType.NChar,1)};
            parameters[0].Value = model.big;
            parameters[1].Value = model.gb;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string gb)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from codetable ");
            strSql.Append(" where gb=@gb ");
            SqlParameter[] parameters = {
					new SqlParameter("@gb", SqlDbType.NChar,1)			};
            parameters[0].Value = gb;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string gblist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from codetable ");
            strSql.Append(" where gb in (" + gblist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        /// 得到一个对象实体
        /// </summary>
        public PI.Model.codetable GetModel(string gb)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 gb,big from codetable ");
            strSql.Append(" where gb=@gb ");
            SqlParameter[] parameters = {
					new SqlParameter("@gb", SqlDbType.NChar,1)			};
            parameters[0].Value = gb;

            PI.Model.codetable model = new PI.Model.codetable();
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
        public PI.Model.codetable DataRowToModel(DataRow row)
        {
            PI.Model.codetable model = new PI.Model.codetable();
            if (row != null)
            {
                if (row["gb"] != null)
                {
                    model.gb = row["gb"].ToString();
                }
                if (row["big"] != null)
                {
                    model.big = row["big"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select gb,big ");
            strSql.Append(" FROM codetable ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" gb,big ");
            strSql.Append(" FROM codetable ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM codetable ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.gb desc");
            }
            strSql.Append(")AS Row, T.*  from codetable T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "codetable";
            parameters[1].Value = "gb";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

