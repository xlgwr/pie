using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:PI_MSTR_Remote
    /// </summary>
    public partial class PI_MSTR_Remote
    {

        public DbHelperSQLP DbHelperSQLP = new DbHelperSQLP(PubConstant.ConnectionStringRemote);
        public PI_MSTR_Remote()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_NO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PI_MSTR");
            strSql.Append(" where PI_NO=@PI_NO ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12)			};
            parameters[0].Value = PI_NO;

            return DbHelperSQLP.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.PI_MSTR_Remote model)
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
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PI.Model.PI_MSTR_Remote model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PI_MSTR set ");
            strSql.Append("PI_Date=@PI_Date,");
            strSql.Append("PI_Page=@PI_Page");
            strSql.Append(" where PI_NO=@PI_NO ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_Date", SqlDbType.SmallDateTime),
					new SqlParameter("@PI_Page", SqlDbType.NVarChar,2),
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12)};
            parameters[0].Value = model.PI_Date;
            parameters[1].Value = model.PI_Page;
            parameters[2].Value = model.PI_NO;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string PI_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PI_MSTR ");
            strSql.Append(" where PI_NO=@PI_NO ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12)			};
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string PI_NOlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PI_MSTR ");
            strSql.Append(" where PI_NO in (" + PI_NOlist + ")  ");
            int rows = DbHelperSQLP.ExecuteSql(strSql.ToString());
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
        public PI.Model.PI_MSTR_Remote GetModel(string PI_NO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PI_NO,PI_Date,PI_Page,msrepl_synctran_ts from PI_MSTR ");
            strSql.Append(" where PI_NO=@PI_NO ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12)			};
            parameters[0].Value = PI_NO;

            PI.Model.PI_MSTR_Remote model = new PI.Model.PI_MSTR_Remote();
            DataSet ds = DbHelperSQLP.Query(strSql.ToString(), parameters);
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
        public PI.Model.PI_MSTR_Remote DataRowToModel(DataRow row)
        {
            PI.Model.PI_MSTR_Remote model = new PI.Model.PI_MSTR_Remote();
            if (row != null)
            {
                if (row["PI_NO"] != null)
                {
                    model.PI_NO = row["PI_NO"].ToString();
                }
                if (row["PI_Date"] != null && row["PI_Date"].ToString() != "")
                {
                    model.PI_Date = DateTime.Parse(row["PI_Date"].ToString());
                }
                if (row["PI_Page"] != null)
                {
                    model.PI_Page = row["PI_Page"].ToString();
                }
                if (row["msrepl_synctran_ts"] != null && row["msrepl_synctran_ts"].ToString() != "")
                {
                    model.msrepl_synctran_ts = DateTime.Parse(row["msrepl_synctran_ts"].ToString());
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
            strSql.Append("select PI_NO,PI_Date,PI_Page,msrepl_synctran_ts ");
            strSql.Append(" from PI_MSTR ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLP.Query(strSql.ToString());
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
            strSql.Append(" PI_NO,PI_Date,PI_Page,msrepl_synctran_ts ");
            strSql.Append(" from PI_MSTR ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQLP.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PI_MSTR ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQLP.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.PI_NO desc");
            }
            strSql.Append(")AS Row, T.*  from PI_MSTR T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQLP.Query(strSql.ToString());
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
            parameters[0].Value = "PI_MSTR_Remote";
            parameters[1].Value = "PI_NO";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQLP.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

