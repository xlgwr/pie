using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:plr_mstr_err
    /// </summary>
    public partial class plr_mstr_err
    {
        public plr_mstr_err()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("LineID", "plr_mstr_err");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Batch_ID, int LineID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from plr_mstr_err");
            strSql.Append(" where Batch_ID=@Batch_ID and LineID=@LineID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.VarChar,20),
					new SqlParameter("@LineID", SqlDbType.Int,4)			};
            parameters[0].Value = Batch_ID;
            parameters[1].Value = LineID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.plr_mstr_err model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into plr_mstr_err(");
            strSql.Append("Batch_ID,LineID,plr_doc_type,plr_po,plr_partno,plr_qty,plr_err_msg,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2)");
            strSql.Append(" values (");
            strSql.Append("@Batch_ID,@LineID,@plr_doc_type,@plr_po,@plr_partno,@plr_qty,@plr_err_msg,@plr_cre_date,@plr_cre_userid,@plr_update_date,@plr_edituser_id,@plr_user_ip,@plr_void_status,@plr_chr01,@plr_chr02,@plr_deci1,@plr_deci2)");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.VarChar,20),
					new SqlParameter("@LineID", SqlDbType.Int,4),
					new SqlParameter("@plr_doc_type", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_po", SqlDbType.NVarChar,30),
					new SqlParameter("@plr_partno", SqlDbType.NVarChar,30),
					new SqlParameter("@plr_qty", SqlDbType.Decimal,9),
					new SqlParameter("@plr_err_msg", SqlDbType.Text),
					new SqlParameter("@plr_cre_date", SqlDbType.DateTime),
					new SqlParameter("@plr_cre_userid", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_update_date", SqlDbType.DateTime),
					new SqlParameter("@plr_edituser_id", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_void_status", SqlDbType.SmallInt,2),
					new SqlParameter("@plr_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_chr02", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_deci1", SqlDbType.Int,4),
					new SqlParameter("@plr_deci2", SqlDbType.Decimal,9)};
            parameters[0].Value = model.Batch_ID;
            parameters[1].Value = model.LineID;
            parameters[2].Value = model.plr_doc_type;
            parameters[3].Value = model.plr_po;
            parameters[4].Value = model.plr_partno;
            parameters[5].Value = model.plr_qty;
            parameters[6].Value = model.plr_err_msg;
            parameters[7].Value = model.plr_cre_date;
            parameters[8].Value = model.plr_cre_userid;
            parameters[9].Value = model.plr_update_date;
            parameters[10].Value = model.plr_edituser_id;
            parameters[11].Value = model.plr_user_ip;
            parameters[12].Value = model.plr_void_status;
            parameters[13].Value = model.plr_chr01;
            parameters[14].Value = model.plr_chr02;
            parameters[15].Value = model.plr_deci1;
            parameters[16].Value = model.plr_deci2;

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
        public bool Update(PIE.Model.plr_mstr_err model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update plr_mstr_err set ");
            strSql.Append("plr_doc_type=@plr_doc_type,");
            strSql.Append("plr_po=@plr_po,");
            strSql.Append("plr_partno=@plr_partno,");
            strSql.Append("plr_qty=@plr_qty,");
            strSql.Append("plr_err_msg=@plr_err_msg,");
            strSql.Append("plr_cre_date=@plr_cre_date,");
            strSql.Append("plr_cre_userid=@plr_cre_userid,");
            strSql.Append("plr_update_date=@plr_update_date,");
            strSql.Append("plr_edituser_id=@plr_edituser_id,");
            strSql.Append("plr_user_ip=@plr_user_ip,");
            strSql.Append("plr_void_status=@plr_void_status,");
            strSql.Append("plr_chr01=@plr_chr01,");
            strSql.Append("plr_chr02=@plr_chr02,");
            strSql.Append("plr_deci1=@plr_deci1,");
            strSql.Append("plr_deci2=@plr_deci2");
            strSql.Append(" where Batch_ID=@Batch_ID and LineID=@LineID ");
            SqlParameter[] parameters = {
					new SqlParameter("@plr_doc_type", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_po", SqlDbType.NVarChar,30),
					new SqlParameter("@plr_partno", SqlDbType.NVarChar,30),
					new SqlParameter("@plr_qty", SqlDbType.Decimal,9),
					new SqlParameter("@plr_err_msg", SqlDbType.Text),
					new SqlParameter("@plr_cre_date", SqlDbType.DateTime),
					new SqlParameter("@plr_cre_userid", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_update_date", SqlDbType.DateTime),
					new SqlParameter("@plr_edituser_id", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_void_status", SqlDbType.SmallInt,2),
					new SqlParameter("@plr_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_chr02", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_deci1", SqlDbType.Int,4),
					new SqlParameter("@plr_deci2", SqlDbType.Decimal,9),
					new SqlParameter("@Batch_ID", SqlDbType.VarChar,20),
					new SqlParameter("@LineID", SqlDbType.Int,4)};
            parameters[0].Value = model.plr_doc_type;
            parameters[1].Value = model.plr_po;
            parameters[2].Value = model.plr_partno;
            parameters[3].Value = model.plr_qty;
            parameters[4].Value = model.plr_err_msg;
            parameters[5].Value = model.plr_cre_date;
            parameters[6].Value = model.plr_cre_userid;
            parameters[7].Value = model.plr_update_date;
            parameters[8].Value = model.plr_edituser_id;
            parameters[9].Value = model.plr_user_ip;
            parameters[10].Value = model.plr_void_status;
            parameters[11].Value = model.plr_chr01;
            parameters[12].Value = model.plr_chr02;
            parameters[13].Value = model.plr_deci1;
            parameters[14].Value = model.plr_deci2;
            parameters[15].Value = model.Batch_ID;
            parameters[16].Value = model.LineID;

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
        public bool Delete(string Batch_ID, int LineID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from plr_mstr_err ");
            strSql.Append(" where Batch_ID=@Batch_ID and LineID=@LineID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.VarChar,20),
					new SqlParameter("@LineID", SqlDbType.Int,4)			};
            parameters[0].Value = Batch_ID;
            parameters[1].Value = LineID;

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
        public PIE.Model.plr_mstr_err GetModel(string Batch_ID, int LineID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Batch_ID,LineID,plr_doc_type,plr_po,plr_partno,plr_qty,plr_err_msg,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2 from plr_mstr_err ");
            strSql.Append(" where Batch_ID=@Batch_ID and LineID=@LineID ");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.VarChar,20),
					new SqlParameter("@LineID", SqlDbType.Int,4)			};
            parameters[0].Value = Batch_ID;
            parameters[1].Value = LineID;

            PIE.Model.plr_mstr_err model = new PIE.Model.plr_mstr_err();
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
        public PIE.Model.plr_mstr_err DataRowToModel(DataRow row)
        {
            PIE.Model.plr_mstr_err model = new PIE.Model.plr_mstr_err();
            if (row != null)
            {
                if (row["Batch_ID"] != null)
                {
                    model.Batch_ID = row["Batch_ID"].ToString();
                }
                if (row["LineID"] != null && row["LineID"].ToString() != "")
                {
                    model.LineID = int.Parse(row["LineID"].ToString());
                }
                if (row["plr_doc_type"] != null)
                {
                    model.plr_doc_type = row["plr_doc_type"].ToString();
                }
                if (row["plr_po"] != null)
                {
                    model.plr_po = row["plr_po"].ToString();
                }
                if (row["plr_partno"] != null)
                {
                    model.plr_partno = row["plr_partno"].ToString();
                }
                if (row["plr_qty"] != null && row["plr_qty"].ToString() != "")
                {
                    model.plr_qty = decimal.Parse(row["plr_qty"].ToString());
                }
                if (row["plr_err_msg"] != null)
                {
                    model.plr_err_msg = row["plr_err_msg"].ToString();
                }
                if (row["plr_cre_date"] != null && row["plr_cre_date"].ToString() != "")
                {
                    model.plr_cre_date = DateTime.Parse(row["plr_cre_date"].ToString());
                }
                if (row["plr_cre_userid"] != null)
                {
                    model.plr_cre_userid = row["plr_cre_userid"].ToString();
                }
                if (row["plr_update_date"] != null && row["plr_update_date"].ToString() != "")
                {
                    model.plr_update_date = DateTime.Parse(row["plr_update_date"].ToString());
                }
                if (row["plr_edituser_id"] != null)
                {
                    model.plr_edituser_id = row["plr_edituser_id"].ToString();
                }
                if (row["plr_user_ip"] != null)
                {
                    model.plr_user_ip = row["plr_user_ip"].ToString();
                }
                if (row["plr_void_status"] != null && row["plr_void_status"].ToString() != "")
                {
                    model.plr_void_status = int.Parse(row["plr_void_status"].ToString());
                }
                if (row["plr_chr01"] != null)
                {
                    model.plr_chr01 = row["plr_chr01"].ToString();
                }
                if (row["plr_chr02"] != null)
                {
                    model.plr_chr02 = row["plr_chr02"].ToString();
                }
                if (row["plr_deci1"] != null && row["plr_deci1"].ToString() != "")
                {
                    model.plr_deci1 = int.Parse(row["plr_deci1"].ToString());
                }
                if (row["plr_deci2"] != null && row["plr_deci2"].ToString() != "")
                {
                    model.plr_deci2 = decimal.Parse(row["plr_deci2"].ToString());
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
            strSql.Append("select Batch_ID,LineID,plr_doc_type,plr_po,plr_partno,plr_qty,plr_err_msg,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2 ");
            strSql.Append(" FROM plr_mstr_err ");
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
            strSql.Append(" Batch_ID,LineID,plr_doc_type,plr_po,plr_partno,plr_qty,plr_err_msg,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2 ");
            strSql.Append(" FROM plr_mstr_err ");
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
            strSql.Append("select count(1) FROM plr_mstr_err ");
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
                strSql.Append("order by T.LineID desc");
            }
            strSql.Append(")AS Row, T.*  from plr_mstr_err T ");
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
            parameters[0].Value = "plr_mstr_err";
            parameters[1].Value = "LineID";
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

