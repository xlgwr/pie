using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:pkey_ctl
    /// </summary>
    public partial class pkey_ctl
    {
        public pkey_ctl()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string t_name, string t_value)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from pkey_ctl");
            strSql.Append(" where t_name=@t_name and t_value=@t_value ");
            SqlParameter[] parameters = {
					new SqlParameter("@t_name", SqlDbType.NVarChar,50),
					new SqlParameter("@t_value", SqlDbType.NVarChar,50)			};
            parameters[0].Value = t_name;
            parameters[1].Value = t_value;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.pkey_ctl model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into pkey_ctl(");
            strSql.Append("t_name,t_value,t_desc,t_yyww,prefix,ctl_fro,ctl_to,ctl_curr,ctl_curr_len,ctl_len)");
            strSql.Append(" values (");
            strSql.Append("@t_name,@t_value,@t_desc,@t_yyww,@prefix,@ctl_fro,@ctl_to,@ctl_curr,@ctl_curr_len,@ctl_len)");
            SqlParameter[] parameters = {
					new SqlParameter("@t_name", SqlDbType.NVarChar,50),
					new SqlParameter("@t_value", SqlDbType.NVarChar,50),
					new SqlParameter("@t_desc", SqlDbType.NVarChar,4000),
					new SqlParameter("@t_yyww", SqlDbType.NVarChar,50),
					new SqlParameter("@prefix", SqlDbType.NVarChar,50),
					new SqlParameter("@ctl_fro", SqlDbType.Decimal,9),
					new SqlParameter("@ctl_to", SqlDbType.Decimal,9),
					new SqlParameter("@ctl_curr", SqlDbType.Decimal,9),
					new SqlParameter("@ctl_curr_len", SqlDbType.Decimal,9),
					new SqlParameter("@ctl_len", SqlDbType.Decimal,9)};
            parameters[0].Value = model.t_name;
            parameters[1].Value = model.t_value;
            parameters[2].Value = model.t_desc;
            parameters[3].Value = model.t_yyww;
            parameters[4].Value = model.prefix;
            parameters[5].Value = model.ctl_fro;
            parameters[6].Value = model.ctl_to;
            parameters[7].Value = model.ctl_curr;
            parameters[8].Value = model.ctl_curr_len;
            parameters[9].Value = model.ctl_len;

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
        public bool Update(PIE.Model.pkey_ctl model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update pkey_ctl set ");
            strSql.Append("t_desc=@t_desc,");
            strSql.Append("t_yyww=@t_yyww,");
            strSql.Append("prefix=@prefix,");
            strSql.Append("ctl_fro=@ctl_fro,");
            strSql.Append("ctl_to=@ctl_to,");
            strSql.Append("ctl_curr=@ctl_curr,");
            strSql.Append("ctl_curr_len=@ctl_curr_len,");
            strSql.Append("ctl_len=@ctl_len");
            strSql.Append(" where t_name=@t_name and t_value=@t_value ");
            SqlParameter[] parameters = {
					new SqlParameter("@t_desc", SqlDbType.NVarChar,4000),
					new SqlParameter("@t_yyww", SqlDbType.NVarChar,50),
					new SqlParameter("@prefix", SqlDbType.NVarChar,50),
					new SqlParameter("@ctl_fro", SqlDbType.Decimal,9),
					new SqlParameter("@ctl_to", SqlDbType.Decimal,9),
					new SqlParameter("@ctl_curr", SqlDbType.Decimal,9),
					new SqlParameter("@ctl_curr_len", SqlDbType.Decimal,9),
					new SqlParameter("@ctl_len", SqlDbType.Decimal,9),
					new SqlParameter("@t_name", SqlDbType.NVarChar,50),
					new SqlParameter("@t_value", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.t_desc;
            parameters[1].Value = model.t_yyww;
            parameters[2].Value = model.prefix;
            parameters[3].Value = model.ctl_fro;
            parameters[4].Value = model.ctl_to;
            parameters[5].Value = model.ctl_curr;
            parameters[6].Value = model.ctl_curr_len;
            parameters[7].Value = model.ctl_len;
            parameters[8].Value = model.t_name;
            parameters[9].Value = model.t_value;

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
        public bool Delete(string t_name, string t_value)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from pkey_ctl ");
            strSql.Append(" where t_name=@t_name and t_value=@t_value ");
            SqlParameter[] parameters = {
					new SqlParameter("@t_name", SqlDbType.NVarChar,50),
					new SqlParameter("@t_value", SqlDbType.NVarChar,50)			};
            parameters[0].Value = t_name;
            parameters[1].Value = t_value;

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
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.pkey_ctl GetModel(string t_name, string t_value)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 t_name,t_value,t_desc,t_yyww,prefix,ctl_fro,ctl_to,ctl_curr,ctl_curr_len,ctl_len from pkey_ctl ");
            strSql.Append(" where t_name=@t_name and t_value=@t_value ");
            SqlParameter[] parameters = {
					new SqlParameter("@t_name", SqlDbType.NVarChar,50),
					new SqlParameter("@t_value", SqlDbType.NVarChar,50)			};
            parameters[0].Value = t_name;
            parameters[1].Value = t_value;

            PIE.Model.pkey_ctl model = new PIE.Model.pkey_ctl();
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
        public PIE.Model.pkey_ctl DataRowToModel(DataRow row)
        {
            PIE.Model.pkey_ctl model = new PIE.Model.pkey_ctl();
            if (row != null)
            {
                if (row["t_name"] != null)
                {
                    model.t_name = row["t_name"].ToString();
                }
                if (row["t_value"] != null)
                {
                    model.t_value = row["t_value"].ToString();
                }
                if (row["t_desc"] != null)
                {
                    model.t_desc = row["t_desc"].ToString();
                }
                if (row["t_yyww"] != null)
                {
                    model.t_yyww = row["t_yyww"].ToString();
                }
                if (row["prefix"] != null)
                {
                    model.prefix = row["prefix"].ToString();
                }
                if (row["ctl_fro"] != null && row["ctl_fro"].ToString() != "")
                {
                    model.ctl_fro = decimal.Parse(row["ctl_fro"].ToString());
                }
                if (row["ctl_to"] != null && row["ctl_to"].ToString() != "")
                {
                    model.ctl_to = decimal.Parse(row["ctl_to"].ToString());
                }
                if (row["ctl_curr"] != null && row["ctl_curr"].ToString() != "")
                {
                    model.ctl_curr = decimal.Parse(row["ctl_curr"].ToString());
                }
                if (row["ctl_curr_len"] != null && row["ctl_curr_len"].ToString() != "")
                {
                    model.ctl_curr_len = decimal.Parse(row["ctl_curr_len"].ToString());
                }
                if (row["ctl_len"] != null && row["ctl_len"].ToString() != "")
                {
                    model.ctl_len = decimal.Parse(row["ctl_len"].ToString());
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
            strSql.Append("select t_name,t_value,t_desc,t_yyww,prefix,ctl_fro,ctl_to,ctl_curr,ctl_curr_len,ctl_len ");
            strSql.Append(" FROM pkey_ctl ");
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
            strSql.Append(" t_name,t_value,t_desc,t_yyww,prefix,ctl_fro,ctl_to,ctl_curr,ctl_curr_len,ctl_len ");
            strSql.Append(" FROM pkey_ctl ");
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
            strSql.Append("select count(1) FROM pkey_ctl ");
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
                strSql.Append("order by T.t_value desc");
            }
            strSql.Append(")AS Row, T.*  from pkey_ctl T ");
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
            parameters[0].Value = "pkey_ctl";
            parameters[1].Value = "t_value";
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

