using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:plr_batch_mstr
    /// </summary>
    public partial class plr_batch_mstr
    {
        public plr_batch_mstr()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string batch_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from plr_batch_mstr");
            strSql.Append(" where batch_id=@batch_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@batch_id", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batch_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.plr_batch_mstr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into plr_batch_mstr(");
            strSql.Append("batch_id,plr_suppliers_id,batch_doc,batch_status,batch_void,batch_cre_date,batch_update_date,batch_cre_user,batch_user_ip,batch_chr01,batch_dec01)");
            strSql.Append(" values (");
            strSql.Append("@batch_id,@plr_suppliers_id,@batch_doc,@batch_status,@batch_void,@batch_cre_date,@batch_update_date,@batch_cre_user,@batch_user_ip,@batch_chr01,@batch_dec01)");
            SqlParameter[] parameters = {
					new SqlParameter("@batch_id", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_suppliers_id", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_doc", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_status", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_void", SqlDbType.SmallInt,2),
					new SqlParameter("@batch_cre_date", SqlDbType.DateTime),
					new SqlParameter("@batch_update_date", SqlDbType.DateTime),
					new SqlParameter("@batch_cre_user", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_dec01", SqlDbType.Decimal,9)};
            parameters[0].Value = model.batch_id;
            parameters[1].Value = model.plr_suppliers_id;
            parameters[2].Value = model.batch_doc;
            parameters[3].Value = model.batch_status;
            parameters[4].Value = model.batch_void;
            parameters[5].Value = model.batch_cre_date;
            parameters[6].Value = model.batch_update_date;
            parameters[7].Value = model.batch_cre_user;
            parameters[8].Value = model.batch_user_ip;
            parameters[9].Value = model.batch_chr01;
            parameters[10].Value = model.batch_dec01;

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
        public bool Update(PIE.Model.plr_batch_mstr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update plr_batch_mstr set ");
            strSql.Append("plr_suppliers_id=@plr_suppliers_id,");
            strSql.Append("batch_doc=@batch_doc,");
            strSql.Append("batch_status=@batch_status,");
            strSql.Append("batch_void=@batch_void,");
            strSql.Append("batch_cre_user=@batch_cre_user,");
            strSql.Append("batch_user_ip=@batch_user_ip,");
            strSql.Append("batch_chr01=@batch_chr01,");
            strSql.Append("batch_dec01=@batch_dec01");
            strSql.Append(" where batch_id=@batch_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@plr_suppliers_id", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_doc", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_status", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_void", SqlDbType.SmallInt,2),
					new SqlParameter("@batch_cre_user", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_dec01", SqlDbType.Decimal,9),
					new SqlParameter("@batch_id", SqlDbType.NVarChar,50),
					new SqlParameter("@batch_cre_date", SqlDbType.DateTime),
					new SqlParameter("@batch_update_date", SqlDbType.DateTime)};
            parameters[0].Value = model.plr_suppliers_id;
            parameters[1].Value = model.batch_doc;
            parameters[2].Value = model.batch_status;
            parameters[3].Value = model.batch_void;
            parameters[4].Value = model.batch_cre_user;
            parameters[5].Value = model.batch_user_ip;
            parameters[6].Value = model.batch_chr01;
            parameters[7].Value = model.batch_dec01;
            parameters[8].Value = model.batch_id;
            parameters[9].Value = model.batch_cre_date;
            parameters[10].Value = model.batch_update_date;

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
        public bool Delete(string batch_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from plr_batch_mstr ");
            strSql.Append(" where batch_id=@batch_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@batch_id", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batch_id;

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
        public bool DeleteList(string batch_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from plr_batch_mstr ");
            strSql.Append(" where batch_id in (" + batch_idlist + ")  ");
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
        public PIE.Model.plr_batch_mstr GetModel(string batch_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 batch_id,plr_suppliers_id,batch_doc,batch_status,batch_void,batch_cre_date,batch_update_date,batch_cre_user,batch_user_ip,batch_chr01,batch_dec01 from plr_batch_mstr ");
            strSql.Append(" where batch_id=@batch_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@batch_id", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batch_id;

            PIE.Model.plr_batch_mstr model = new PIE.Model.plr_batch_mstr();
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
        public PIE.Model.plr_batch_mstr DataRowToModel(DataRow row)
        {
            PIE.Model.plr_batch_mstr model = new PIE.Model.plr_batch_mstr();
            if (row != null)
            {
                if (row["batch_id"] != null)
                {
                    model.batch_id = row["batch_id"].ToString();
                }
                if (row["plr_suppliers_id"] != null)
                {
                    model.plr_suppliers_id = row["plr_suppliers_id"].ToString();
                }
                if (row["batch_doc"] != null)
                {
                    model.batch_doc = row["batch_doc"].ToString();
                }
                if (row["batch_status"] != null)
                {
                    model.batch_status = row["batch_status"].ToString();
                }
                if (row["batch_void"] != null && row["batch_void"].ToString() != "")
                {
                    model.batch_void = int.Parse(row["batch_void"].ToString());
                }
                if (row["batch_cre_date"] != null && row["batch_cre_date"].ToString() != "")
                {
                    model.batch_cre_date = DateTime.Parse(row["batch_cre_date"].ToString());
                }
                if (row["batch_update_date"] != null && row["batch_update_date"].ToString() != "")
                {
                    model.batch_update_date = DateTime.Parse(row["batch_update_date"].ToString());
                }
                if (row["batch_cre_user"] != null)
                {
                    model.batch_cre_user = row["batch_cre_user"].ToString();
                }
                if (row["batch_user_ip"] != null)
                {
                    model.batch_user_ip = row["batch_user_ip"].ToString();
                }
                if (row["batch_chr01"] != null)
                {
                    model.batch_chr01 = row["batch_chr01"].ToString();
                }
                if (row["batch_dec01"] != null && row["batch_dec01"].ToString() != "")
                {
                    model.batch_dec01 = decimal.Parse(row["batch_dec01"].ToString());
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
            strSql.Append("select batch_id,plr_suppliers_id,batch_doc,batch_status,batch_void,batch_cre_date,batch_update_date,batch_cre_user,batch_user_ip,batch_chr01,batch_dec01 ");
            strSql.Append(" FROM plr_batch_mstr ");
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
            strSql.Append(" batch_id,plr_suppliers_id,batch_doc,batch_status,batch_void,batch_cre_date,batch_update_date,batch_cre_user,batch_user_ip,batch_chr01,batch_dec01 ");
            strSql.Append(" FROM plr_batch_mstr ");
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
            strSql.Append("select count(1) FROM plr_batch_mstr ");
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
                strSql.Append("order by T.batch_id desc");
            }
            strSql.Append(")AS Row, T.*  from plr_batch_mstr T ");
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
            parameters[0].Value = "plr_batch_mstr";
            parameters[1].Value = "batch_id";
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

