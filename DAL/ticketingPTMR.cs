using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:ticketingPTMR
    /// </summary>
    public partial class ticketingPTMR
    {
        public ticketingPTMR()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string t_id, string t_suppliers_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ticketingPTMR");
            strSql.Append(" where t_id=@t_id and t_suppliers_id=@t_suppliers_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@t_id", SqlDbType.NVarChar,50),
					new SqlParameter("@t_suppliers_id", SqlDbType.NVarChar,50)			};
            parameters[0].Value = t_id;
            parameters[1].Value = t_suppliers_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.ticketingPTMR model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ticketingPTMR(");
            strSql.Append("t_id,t_suppliers_id,t_inDocTime,t_backTime,t_outWait,t_receTime,t_outAwayTime,t_waitTime,t_totalTime,t_time01,t_time02,t_cre_date,t_update_date,t_cre_user,t_user_ip,t_chr01,t_chr02,t_chr03,t_dec01,t_dec02,t_int01,t_int02)");
            strSql.Append(" values (");
            strSql.Append("@t_id,@t_suppliers_id,@t_inDocTime,@t_backTime,@t_outWait,@t_receTime,@t_outAwayTime,@t_waitTime,@t_totalTime,@t_time01,@t_time02,@t_cre_date,@t_update_date,@t_cre_user,@t_user_ip,@t_chr01,@t_chr02,@t_chr03,@t_dec01,@t_dec02,@t_int01,@t_int02)");
            SqlParameter[] parameters = {
					new SqlParameter("@t_id", SqlDbType.NVarChar,50),
					new SqlParameter("@t_suppliers_id", SqlDbType.NVarChar,50),
					new SqlParameter("@t_inDocTime", SqlDbType.DateTime),
					new SqlParameter("@t_backTime", SqlDbType.DateTime),
					new SqlParameter("@t_outWait", SqlDbType.NVarChar,50),
					new SqlParameter("@t_receTime", SqlDbType.DateTime),
					new SqlParameter("@t_outAwayTime", SqlDbType.DateTime),
					new SqlParameter("@t_waitTime", SqlDbType.DateTime),
					new SqlParameter("@t_totalTime", SqlDbType.DateTime),
					new SqlParameter("@t_time01", SqlDbType.DateTime),
					new SqlParameter("@t_time02", SqlDbType.DateTime),
					new SqlParameter("@t_cre_date", SqlDbType.DateTime),
					new SqlParameter("@t_update_date", SqlDbType.DateTime),
					new SqlParameter("@t_cre_user", SqlDbType.NVarChar,50),
					new SqlParameter("@t_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@t_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@t_chr02", SqlDbType.NVarChar,50),
					new SqlParameter("@t_chr03", SqlDbType.NVarChar,50),
					new SqlParameter("@t_dec01", SqlDbType.Decimal,9),
					new SqlParameter("@t_dec02", SqlDbType.Decimal,9),
					new SqlParameter("@t_int01", SqlDbType.Int,4),
					new SqlParameter("@t_int02", SqlDbType.Int,4)};
            parameters[0].Value = model.t_id;
            parameters[1].Value = model.t_suppliers_id;
            parameters[2].Value = model.t_inDocTime;
            parameters[3].Value = model.t_backTime;
            parameters[4].Value = model.t_outWait;
            parameters[5].Value = model.t_receTime;
            parameters[6].Value = model.t_outAwayTime;
            parameters[7].Value = model.t_waitTime;
            parameters[8].Value = model.t_totalTime;
            parameters[9].Value = model.t_time01;
            parameters[10].Value = model.t_time02;
            parameters[11].Value = model.t_cre_date;
            parameters[12].Value = model.t_update_date;
            parameters[13].Value = model.t_cre_user;
            parameters[14].Value = model.t_user_ip;
            parameters[15].Value = model.t_chr01;
            parameters[16].Value = model.t_chr02;
            parameters[17].Value = model.t_chr03;
            parameters[18].Value = model.t_dec01;
            parameters[19].Value = model.t_dec02;
            parameters[20].Value = model.t_int01;
            parameters[21].Value = model.t_int02;

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
        public bool Update(PIE.Model.ticketingPTMR model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ticketingPTMR set ");
            strSql.Append("t_inDocTime=@t_inDocTime,");
            strSql.Append("t_backTime=@t_backTime,");
            strSql.Append("t_outWait=@t_outWait,");
            strSql.Append("t_receTime=@t_receTime,");
            strSql.Append("t_outAwayTime=@t_outAwayTime,");
            strSql.Append("t_waitTime=@t_waitTime,");
            strSql.Append("t_totalTime=@t_totalTime,");
            strSql.Append("t_time01=@t_time01,");
            strSql.Append("t_time02=@t_time02,");
            strSql.Append("t_cre_date=@t_cre_date,");
            strSql.Append("t_update_date=@t_update_date,");
            strSql.Append("t_cre_user=@t_cre_user,");
            strSql.Append("t_user_ip=@t_user_ip,");
            strSql.Append("t_chr01=@t_chr01,");
            strSql.Append("t_chr02=@t_chr02,");
            strSql.Append("t_chr03=@t_chr03,");
            strSql.Append("t_dec01=@t_dec01,");
            strSql.Append("t_dec02=@t_dec02,");
            strSql.Append("t_int01=@t_int01,");
            strSql.Append("t_int02=@t_int02");
            strSql.Append(" where t_id=@t_id and t_suppliers_id=@t_suppliers_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@t_inDocTime", SqlDbType.DateTime),
					new SqlParameter("@t_backTime", SqlDbType.DateTime),
					new SqlParameter("@t_outWait", SqlDbType.NVarChar,50),
					new SqlParameter("@t_receTime", SqlDbType.DateTime),
					new SqlParameter("@t_outAwayTime", SqlDbType.DateTime),
					new SqlParameter("@t_waitTime", SqlDbType.DateTime),
					new SqlParameter("@t_totalTime", SqlDbType.DateTime),
					new SqlParameter("@t_time01", SqlDbType.DateTime),
					new SqlParameter("@t_time02", SqlDbType.DateTime),
					new SqlParameter("@t_cre_date", SqlDbType.DateTime),
					new SqlParameter("@t_update_date", SqlDbType.DateTime),
					new SqlParameter("@t_cre_user", SqlDbType.NVarChar,50),
					new SqlParameter("@t_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@t_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@t_chr02", SqlDbType.NVarChar,50),
					new SqlParameter("@t_chr03", SqlDbType.NVarChar,50),
					new SqlParameter("@t_dec01", SqlDbType.Decimal,9),
					new SqlParameter("@t_dec02", SqlDbType.Decimal,9),
					new SqlParameter("@t_int01", SqlDbType.Int,4),
					new SqlParameter("@t_int02", SqlDbType.Int,4),
					new SqlParameter("@t_id", SqlDbType.NVarChar,50),
					new SqlParameter("@t_suppliers_id", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.t_inDocTime;
            parameters[1].Value = model.t_backTime;
            parameters[2].Value = model.t_outWait;
            parameters[3].Value = model.t_receTime;
            parameters[4].Value = model.t_outAwayTime;
            parameters[5].Value = model.t_waitTime;
            parameters[6].Value = model.t_totalTime;
            parameters[7].Value = model.t_time01;
            parameters[8].Value = model.t_time02;
            parameters[9].Value = model.t_cre_date;
            parameters[10].Value = model.t_update_date;
            parameters[11].Value = model.t_cre_user;
            parameters[12].Value = model.t_user_ip;
            parameters[13].Value = model.t_chr01;
            parameters[14].Value = model.t_chr02;
            parameters[15].Value = model.t_chr03;
            parameters[16].Value = model.t_dec01;
            parameters[17].Value = model.t_dec02;
            parameters[18].Value = model.t_int01;
            parameters[19].Value = model.t_int02;
            parameters[20].Value = model.t_id;
            parameters[21].Value = model.t_suppliers_id;

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
        public bool Delete(string t_id, string t_suppliers_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ticketingPTMR ");
            strSql.Append(" where t_id=@t_id and t_suppliers_id=@t_suppliers_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@t_id", SqlDbType.NVarChar,50),
					new SqlParameter("@t_suppliers_id", SqlDbType.NVarChar,50)			};
            parameters[0].Value = t_id;
            parameters[1].Value = t_suppliers_id;

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
        public PIE.Model.ticketingPTMR GetModel(string t_id, string t_suppliers_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 t_id,t_suppliers_id,t_inDocTime,t_backTime,t_outWait,t_receTime,t_outAwayTime,t_waitTime,t_totalTime,t_time01,t_time02,t_cre_date,t_update_date,t_cre_user,t_user_ip,t_chr01,t_chr02,t_chr03,t_dec01,t_dec02,t_int01,t_int02 from ticketingPTMR ");
            strSql.Append(" where t_id=@t_id and t_suppliers_id=@t_suppliers_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@t_id", SqlDbType.NVarChar,50),
					new SqlParameter("@t_suppliers_id", SqlDbType.NVarChar,50)			};
            parameters[0].Value = t_id;
            parameters[1].Value = t_suppliers_id;

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
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.ticketingPTMR DataRowToModel(DataRow row)
        {
            PIE.Model.ticketingPTMR model = new PIE.Model.ticketingPTMR();
            if (row != null)
            {
                if (row["t_id"] != null)
                {
                    model.t_id = row["t_id"].ToString();
                }
                if (row["t_suppliers_id"] != null)
                {
                    model.t_suppliers_id = row["t_suppliers_id"].ToString();
                }
                if (row["t_inDocTime"] != null && row["t_inDocTime"].ToString() != "")
                {
                    model.t_inDocTime = DateTime.Parse(row["t_inDocTime"].ToString());
                }
                if (row["t_backTime"] != null && row["t_backTime"].ToString() != "")
                {
                    model.t_backTime = DateTime.Parse(row["t_backTime"].ToString());
                }
                if (row["t_outWait"] != null)
                {
                    model.t_outWait = row["t_outWait"].ToString();
                }
                if (row["t_receTime"] != null && row["t_receTime"].ToString() != "")
                {
                    model.t_receTime = DateTime.Parse(row["t_receTime"].ToString());
                }
                if (row["t_outAwayTime"] != null && row["t_outAwayTime"].ToString() != "")
                {
                    model.t_outAwayTime = DateTime.Parse(row["t_outAwayTime"].ToString());
                }
                if (row["t_waitTime"] != null && row["t_waitTime"].ToString() != "")
                {
                    model.t_waitTime = DateTime.Parse(row["t_waitTime"].ToString());
                }
                if (row["t_totalTime"] != null && row["t_totalTime"].ToString() != "")
                {
                    model.t_totalTime = DateTime.Parse(row["t_totalTime"].ToString());
                }
                if (row["t_time01"] != null && row["t_time01"].ToString() != "")
                {
                    model.t_time01 = DateTime.Parse(row["t_time01"].ToString());
                }
                if (row["t_time02"] != null && row["t_time02"].ToString() != "")
                {
                    model.t_time02 = DateTime.Parse(row["t_time02"].ToString());
                }
                if (row["t_cre_date"] != null && row["t_cre_date"].ToString() != "")
                {
                    model.t_cre_date = DateTime.Parse(row["t_cre_date"].ToString());
                }
                if (row["t_update_date"] != null && row["t_update_date"].ToString() != "")
                {
                    model.t_update_date = DateTime.Parse(row["t_update_date"].ToString());
                }
                if (row["t_cre_user"] != null)
                {
                    model.t_cre_user = row["t_cre_user"].ToString();
                }
                if (row["t_user_ip"] != null)
                {
                    model.t_user_ip = row["t_user_ip"].ToString();
                }
                if (row["t_chr01"] != null)
                {
                    model.t_chr01 = row["t_chr01"].ToString();
                }
                if (row["t_chr02"] != null)
                {
                    model.t_chr02 = row["t_chr02"].ToString();
                }
                if (row["t_chr03"] != null)
                {
                    model.t_chr03 = row["t_chr03"].ToString();
                }
                if (row["t_dec01"] != null && row["t_dec01"].ToString() != "")
                {
                    model.t_dec01 = decimal.Parse(row["t_dec01"].ToString());
                }
                if (row["t_dec02"] != null && row["t_dec02"].ToString() != "")
                {
                    model.t_dec02 = decimal.Parse(row["t_dec02"].ToString());
                }
                if (row["t_int01"] != null && row["t_int01"].ToString() != "")
                {
                    model.t_int01 = int.Parse(row["t_int01"].ToString());
                }
                if (row["t_int02"] != null && row["t_int02"].ToString() != "")
                {
                    model.t_int02 = int.Parse(row["t_int02"].ToString());
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
            strSql.Append("select t_id,t_suppliers_id,t_inDocTime,t_backTime,t_outWait,t_receTime,t_outAwayTime,t_waitTime,t_totalTime,t_time01,t_time02,t_cre_date,t_update_date,t_cre_user,t_user_ip,t_chr01,t_chr02,t_chr03,t_dec01,t_dec02,t_int01,t_int02 ");
            strSql.Append(" FROM ticketingPTMR ");
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
            strSql.Append(" t_id,t_suppliers_id,t_inDocTime,t_backTime,t_outWait,t_receTime,t_outAwayTime,t_waitTime,t_totalTime,t_time01,t_time02,t_cre_date,t_update_date,t_cre_user,t_user_ip,t_chr01,t_chr02,t_chr03,t_dec01,t_dec02,t_int01,t_int02 ");
            strSql.Append(" FROM ticketingPTMR ");
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
            strSql.Append("select count(1) FROM ticketingPTMR ");
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
                strSql.Append("order by T.t_suppliers_id desc");
            }
            strSql.Append(")AS Row, T.*  from ticketingPTMR T ");
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
            parameters[0].Value = "ticketingPTMR";
            parameters[1].Value = "t_suppliers_id";
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

