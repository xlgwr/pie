using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:pi_sq
    /// </summary>
    public partial class pi_sq
    {
        public pi_sq()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("sq_id", "pi_sq");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string sq_type, int sq_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from pi_sq");
            strSql.Append(" where sq_type=@sq_type and sq_id=@sq_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@sq_type", SqlDbType.NVarChar,50),
					new SqlParameter("@sq_id", SqlDbType.Int,4)			};
            parameters[0].Value = sq_type;
            parameters[1].Value = sq_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.pi_sq model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into pi_sq(");
            strSql.Append("sq_type,sq_id,sq_name,sq_desc,sq_unit,co_id,co_desc)");
            strSql.Append(" values (");
            strSql.Append("@sq_type,@sq_id,@sq_name,@sq_desc,@sq_unit,@co_id,@co_desc)");
            SqlParameter[] parameters = {
					new SqlParameter("@sq_type", SqlDbType.NVarChar,50),
					new SqlParameter("@sq_id", SqlDbType.Int,4),
					new SqlParameter("@sq_name", SqlDbType.NVarChar,100),
					new SqlParameter("@sq_desc", SqlDbType.NVarChar,300),
					new SqlParameter("@sq_unit", SqlDbType.NVarChar,50),
					new SqlParameter("@co_id", SqlDbType.NVarChar,50),
					new SqlParameter("@co_desc", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.sq_type;
            parameters[1].Value = model.sq_id;
            parameters[2].Value = model.sq_name;
            parameters[3].Value = model.sq_desc;
            parameters[4].Value = model.sq_unit;
            parameters[5].Value = model.co_id;
            parameters[6].Value = model.co_desc;

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
        public bool Update(PI.Model.pi_sq model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update pi_sq set ");
            strSql.Append("sq_name=@sq_name,");
            strSql.Append("sq_desc=@sq_desc,");
            strSql.Append("sq_unit=@sq_unit,");
            strSql.Append("co_id=@co_id,");
            strSql.Append("co_desc=@co_desc");
            strSql.Append(" where sq_type=@sq_type and sq_id=@sq_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@sq_name", SqlDbType.NVarChar,100),
					new SqlParameter("@sq_desc", SqlDbType.NVarChar,300),
					new SqlParameter("@sq_unit", SqlDbType.NVarChar,50),
					new SqlParameter("@co_id", SqlDbType.NVarChar,50),
					new SqlParameter("@co_desc", SqlDbType.NVarChar,50),
					new SqlParameter("@sq_type", SqlDbType.NVarChar,50),
					new SqlParameter("@sq_id", SqlDbType.Int,4)};
            parameters[0].Value = model.sq_name;
            parameters[1].Value = model.sq_desc;
            parameters[2].Value = model.sq_unit;
            parameters[3].Value = model.co_id;
            parameters[4].Value = model.co_desc;
            parameters[5].Value = model.sq_type;
            parameters[6].Value = model.sq_id;

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
        public bool Delete(string sq_type, int sq_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from pi_sq ");
            strSql.Append(" where sq_type=@sq_type and sq_id=@sq_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@sq_type", SqlDbType.NVarChar,50),
					new SqlParameter("@sq_id", SqlDbType.Int,4)			};
            parameters[0].Value = sq_type;
            parameters[1].Value = sq_id;

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
        public PI.Model.pi_sq GetModel(string sq_type, int sq_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 sq_type,sq_id,sq_name,sq_desc,sq_unit,co_id,co_desc from pi_sq ");
            strSql.Append(" where sq_type=@sq_type and sq_id=@sq_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@sq_type", SqlDbType.NVarChar,50),
					new SqlParameter("@sq_id", SqlDbType.Int,4)			};
            parameters[0].Value = sq_type;
            parameters[1].Value = sq_id;

            PI.Model.pi_sq model = new PI.Model.pi_sq();
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
        public PI.Model.pi_sq DataRowToModel(DataRow row)
        {
            PI.Model.pi_sq model = new PI.Model.pi_sq();
            if (row != null)
            {
                if (row["sq_type"] != null)
                {
                    model.sq_type = row["sq_type"].ToString();
                }
                if (row["sq_id"] != null && row["sq_id"].ToString() != "")
                {
                    model.sq_id = int.Parse(row["sq_id"].ToString());
                }
                if (row["sq_name"] != null)
                {
                    model.sq_name = row["sq_name"].ToString();
                }
                if (row["sq_desc"] != null)
                {
                    model.sq_desc = row["sq_desc"].ToString();
                }
                if (row["sq_unit"] != null)
                {
                    model.sq_unit = row["sq_unit"].ToString();
                }
                if (row["co_id"] != null)
                {
                    model.co_id = row["co_id"].ToString();
                }
                if (row["co_desc"] != null)
                {
                    model.co_desc = row["co_desc"].ToString();
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
            strSql.Append("select sq_type,sq_id,sq_name,sq_desc,sq_unit,co_id,co_desc ");
            strSql.Append(" FROM pi_sq ");
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
            strSql.Append(" sq_type,sq_id,sq_name,sq_desc,sq_unit,co_id,co_desc ");
            strSql.Append(" FROM pi_sq ");
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
            strSql.Append("select count(1) FROM pi_sq ");
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
                strSql.Append("order by T.sq_id desc");
            }
            strSql.Append(")AS Row, T.*  from pi_sq T ");
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
            parameters[0].Value = "pi_sq";
            parameters[1].Value = "sq_id";
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

