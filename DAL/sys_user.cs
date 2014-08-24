using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:sys_user
    /// </summary>
    public partial class sys_user
    {
        public sys_user()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string user_name, string user_comp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from sys_user");
            strSql.Append(" where user_name=@user_name and user_comp=@user_comp ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_comp", SqlDbType.NVarChar,50)			};
            parameters[0].Value = user_name;
            parameters[1].Value = user_comp;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.sys_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into sys_user(");
            strSql.Append("user_name,user_comp,user_password,user_email,user_desc,update_time,create_time,create_user_id,update_user_id,client_ip,re_mark,flag_status)");
            strSql.Append(" values (");
            strSql.Append("@user_name,@user_comp,@user_password,@user_email,@user_desc,@update_time,@create_time,@create_user_id,@update_user_id,@client_ip,@re_mark,@flag_status)");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_comp", SqlDbType.NVarChar,50),
					new SqlParameter("@user_password", SqlDbType.NVarChar,50),
					new SqlParameter("@user_email", SqlDbType.NVarChar,150),
					new SqlParameter("@user_desc", SqlDbType.NVarChar,100),
					new SqlParameter("@update_time", SqlDbType.DateTime),
					new SqlParameter("@create_time", SqlDbType.DateTime),
					new SqlParameter("@create_user_id", SqlDbType.NVarChar,50),
					new SqlParameter("@update_user_id", SqlDbType.NVarChar,50),
					new SqlParameter("@client_ip", SqlDbType.NVarChar,100),
					new SqlParameter("@re_mark", SqlDbType.Text),
					new SqlParameter("@flag_status", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.user_name;
            parameters[1].Value = model.user_comp;
            parameters[2].Value = model.user_password;
            parameters[3].Value = model.user_email;
            parameters[4].Value = model.user_desc;
            parameters[5].Value = model.update_time;
            parameters[6].Value = model.create_time;
            parameters[7].Value = model.create_user_id;
            parameters[8].Value = model.update_user_id;
            parameters[9].Value = model.client_ip;
            parameters[10].Value = model.re_mark;
            parameters[11].Value = model.flag_status;

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
        public bool Update(PIE.Model.sys_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update sys_user set ");
            strSql.Append("user_password=@user_password,");
            strSql.Append("user_email=@user_email,");
            strSql.Append("user_desc=@user_desc,");
            strSql.Append("create_time=@create_time,");
            strSql.Append("update_time=@update_time,");
            strSql.Append("create_user_id=@create_user_id,");
            strSql.Append("update_user_id=@update_user_id,");
            strSql.Append("client_ip=@client_ip,");
            strSql.Append("re_mark=@re_mark,");
            strSql.Append("flag_status=@flag_status");
            strSql.Append(" where user_name=@user_name and user_comp=@user_comp ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_password", SqlDbType.NVarChar,50),
					new SqlParameter("@user_email", SqlDbType.NVarChar,150),
					new SqlParameter("@user_desc", SqlDbType.NVarChar,100),
					new SqlParameter("@create_time", SqlDbType.DateTime),
					new SqlParameter("@create_user_id", SqlDbType.NVarChar,50),
					new SqlParameter("@update_user_id", SqlDbType.NVarChar,50),
					new SqlParameter("@client_ip", SqlDbType.NVarChar,100),
					new SqlParameter("@re_mark", SqlDbType.Text),
					new SqlParameter("@flag_status", SqlDbType.NVarChar,10),
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_comp", SqlDbType.NVarChar,50),
					new SqlParameter("@update_time", SqlDbType.DateTime)};
            parameters[0].Value = model.user_password;
            parameters[1].Value = model.user_email;
            parameters[2].Value = model.user_desc;
            parameters[3].Value = model.create_time;
            parameters[4].Value = model.create_user_id;
            parameters[5].Value = model.update_user_id;
            parameters[6].Value = model.client_ip;
            parameters[7].Value = model.re_mark;
            parameters[8].Value = model.flag_status;
            parameters[9].Value = model.user_name;
            parameters[10].Value = model.user_comp;
            parameters[11].Value = model.update_time;

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
        public bool Delete(string user_name, string user_comp)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from sys_user ");
            strSql.Append(" where user_name=@user_name and user_comp=@user_comp ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_comp", SqlDbType.NVarChar,50)			};
            parameters[0].Value = user_name;
            parameters[1].Value = user_comp;

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
        public PIE.Model.sys_user GetModel(string user_name, string user_comp)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 user_name,user_comp,user_password,user_email,user_desc,update_time,create_time,create_user_id,update_user_id,client_ip,re_mark,flag_status from sys_user ");
            strSql.Append(" where user_name=@user_name and user_comp=@user_comp ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_comp", SqlDbType.NVarChar,50)			};
            parameters[0].Value = user_name;
            parameters[1].Value = user_comp;

            PIE.Model.sys_user model = new PIE.Model.sys_user();
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
        public PIE.Model.sys_user DataRowToModel(DataRow row)
        {
            PIE.Model.sys_user model = new PIE.Model.sys_user();
            if (row != null)
            {
                if (row["user_name"] != null)
                {
                    model.user_name = row["user_name"].ToString();
                }
                if (row["user_comp"] != null)
                {
                    model.user_comp = row["user_comp"].ToString();
                }
                if (row["user_password"] != null)
                {
                    model.user_password = row["user_password"].ToString();
                }
                if (row["user_email"] != null)
                {
                    model.user_email = row["user_email"].ToString();
                }
                if (row["user_desc"] != null)
                {
                    model.user_desc = row["user_desc"].ToString();
                }
                if (row["update_time"] != null && row["update_time"].ToString() != "")
                {
                    model.update_time = DateTime.Parse(row["update_time"].ToString());
                }
                if (row["create_time"] != null && row["create_time"].ToString() != "")
                {
                    model.create_time = DateTime.Parse(row["create_time"].ToString());
                }
                if (row["create_user_id"] != null)
                {
                    model.create_user_id = row["create_user_id"].ToString();
                }
                if (row["update_user_id"] != null)
                {
                    model.update_user_id = row["update_user_id"].ToString();
                }
                if (row["client_ip"] != null)
                {
                    model.client_ip = row["client_ip"].ToString();
                }
                if (row["re_mark"] != null)
                {
                    model.re_mark = row["re_mark"].ToString();
                }
                if (row["flag_status"] != null)
                {
                    model.flag_status = row["flag_status"].ToString();
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
            strSql.Append("select user_name,user_comp,user_password,user_email,user_desc,update_time,create_time,create_user_id,update_user_id,client_ip,re_mark,flag_status ");
            strSql.Append(" FROM sys_user ");
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
            strSql.Append(" user_name,user_comp,user_password,user_email,user_desc,update_time,create_time,create_user_id,update_user_id,client_ip,re_mark,flag_status ");
            strSql.Append(" FROM sys_user ");
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
            strSql.Append("select count(1) FROM sys_user ");
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
                strSql.Append("order by T.user_comp desc");
            }
            strSql.Append(")AS Row, T.*  from sys_user T ");
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
            parameters[0].Value = "sys_user";
            parameters[1].Value = "user_comp";
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

