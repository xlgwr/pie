using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:pi_det
    /// </summary>
    public partial class pi_det
    {
        public pi_det()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("pi_LineID", "pi_det");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_ID, int pi_LineID, string pi_wec_ctn)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from pi_det");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID and pi_wec_ctn=@pi_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50)			};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID;
            parameters[2].Value = pi_wec_ctn;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.pi_det model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into pi_det(");
            strSql.Append("PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_type,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2)");
            strSql.Append(" values (");
            strSql.Append("@PI_ID,@pi_LineID,@pi_wec_ctn,@plr_LineID_tran,@pi_pallet_no,@CartonNo,@CartonID,@pi_type,@pi_status,@pi_status_msg,@pi_remark,@pi_cre_date,@pi_cre_userid,@pi_update_date,@pi_edituser_id,@pi_user_ip,@pi_void_status,@pi_chr01,@pi_chr02,@pi_deci1,@pi_deci2)");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4),
					new SqlParameter("@pi_pallet_no", SqlDbType.NVarChar,10),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_status", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_status_msg", SqlDbType.NVarChar,4000),
					new SqlParameter("@pi_remark", SqlDbType.Text),
					new SqlParameter("@pi_cre_date", SqlDbType.DateTime),
					new SqlParameter("@pi_cre_userid", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_update_date", SqlDbType.DateTime),
					new SqlParameter("@pi_edituser_id", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_void_status", SqlDbType.SmallInt,2),
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr02", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_deci1", SqlDbType.Int,4),
					new SqlParameter("@pi_deci2", SqlDbType.Decimal,9)};
            parameters[0].Value = model.PI_ID;
            parameters[1].Value = model.pi_LineID;
            parameters[2].Value = model.pi_wec_ctn;
            parameters[3].Value = model.plr_LineID_tran;
            parameters[4].Value = model.pi_pallet_no;
            parameters[5].Value = model.CartonNo;
            parameters[6].Value = model.CartonID;
            parameters[7].Value = model.pi_type;
            parameters[8].Value = model.pi_status;
            parameters[9].Value = model.pi_status_msg;
            parameters[10].Value = model.pi_remark;
            parameters[11].Value = model.pi_cre_date;
            parameters[12].Value = model.pi_cre_userid;
            parameters[13].Value = model.pi_update_date;
            parameters[14].Value = model.pi_edituser_id;
            parameters[15].Value = model.pi_user_ip;
            parameters[16].Value = model.pi_void_status;
            parameters[17].Value = model.pi_chr01;
            parameters[18].Value = model.pi_chr02;
            parameters[19].Value = model.pi_deci1;
            parameters[20].Value = model.pi_deci2;

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
        public bool Update(PI.Model.pi_det model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update pi_det set ");
            strSql.Append("plr_LineID_tran=@plr_LineID_tran,");
            strSql.Append("pi_pallet_no=@pi_pallet_no,");
            strSql.Append("CartonNo=@CartonNo,");
            strSql.Append("CartonID=@CartonID,");
            strSql.Append("pi_type=@pi_type,");
            strSql.Append("pi_status=@pi_status,");
            strSql.Append("pi_status_msg=@pi_status_msg,");
            strSql.Append("pi_remark=@pi_remark,");
            strSql.Append("pi_cre_date=@pi_cre_date,");
            strSql.Append("pi_cre_userid=@pi_cre_userid,");
            strSql.Append("pi_update_date=@pi_update_date,");
            strSql.Append("pi_edituser_id=@pi_edituser_id,");
            strSql.Append("pi_user_ip=@pi_user_ip,");
            strSql.Append("pi_void_status=@pi_void_status,");
            strSql.Append("pi_chr01=@pi_chr01,");
            strSql.Append("pi_chr02=@pi_chr02,");
            strSql.Append("pi_deci1=@pi_deci1,");
            strSql.Append("pi_deci2=@pi_deci2");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID and pi_wec_ctn=@pi_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4),
					new SqlParameter("@pi_pallet_no", SqlDbType.NVarChar,10),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_status", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_status_msg", SqlDbType.NVarChar,4000),
					new SqlParameter("@pi_remark", SqlDbType.Text),
					new SqlParameter("@pi_cre_date", SqlDbType.DateTime),
					new SqlParameter("@pi_cre_userid", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_update_date", SqlDbType.DateTime),
					new SqlParameter("@pi_edituser_id", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_void_status", SqlDbType.SmallInt,2),
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr02", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_deci1", SqlDbType.Int,4),
					new SqlParameter("@pi_deci2", SqlDbType.Decimal,9),
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.plr_LineID_tran;
            parameters[1].Value = model.pi_pallet_no;
            parameters[2].Value = model.CartonNo;
            parameters[3].Value = model.CartonID;
            parameters[4].Value = model.pi_type;
            parameters[5].Value = model.pi_status;
            parameters[6].Value = model.pi_status_msg;
            parameters[7].Value = model.pi_remark;
            parameters[8].Value = model.pi_cre_date;
            parameters[9].Value = model.pi_cre_userid;
            parameters[10].Value = model.pi_update_date;
            parameters[11].Value = model.pi_edituser_id;
            parameters[12].Value = model.pi_user_ip;
            parameters[13].Value = model.pi_void_status;
            parameters[14].Value = model.pi_chr01;
            parameters[15].Value = model.pi_chr02;
            parameters[16].Value = model.pi_deci1;
            parameters[17].Value = model.pi_deci2;
            parameters[18].Value = model.PI_ID;
            parameters[19].Value = model.pi_LineID;
            parameters[20].Value = model.pi_wec_ctn;

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
        public bool Delete(string PI_ID, int pi_LineID, string pi_wec_ctn)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from pi_det ");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID and pi_wec_ctn=@pi_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50)			};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID;
            parameters[2].Value = pi_wec_ctn;

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
        public PI.Model.pi_det GetModel(string PI_ID, int pi_LineID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_type,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 from pi_det ");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4) 		};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID; 

            PI.Model.pi_det model = new PI.Model.pi_det();
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
        public PI.Model.pi_det GetModel(string PI_ID, int pi_LineID, string pi_wec_ctn)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_type,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 from pi_det ");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID and pi_wec_ctn=@pi_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50)			};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID;
            parameters[2].Value = pi_wec_ctn;

            PI.Model.pi_det model = new PI.Model.pi_det();
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
        public PI.Model.pi_det DataRowToModel(DataRow row)
        {
            PI.Model.pi_det model = new PI.Model.pi_det();
            if (row != null)
            {
                if (row["PI_ID"] != null)
                {
                    model.PI_ID = row["PI_ID"].ToString();
                }
                if (row["pi_LineID"] != null && row["pi_LineID"].ToString() != "")
                {
                    model.pi_LineID = int.Parse(row["pi_LineID"].ToString());
                }
                if (row["pi_wec_ctn"] != null)
                {
                    model.pi_wec_ctn = row["pi_wec_ctn"].ToString();
                }
                if (row["plr_LineID_tran"] != null && row["plr_LineID_tran"].ToString() != "")
                {
                    model.plr_LineID_tran = int.Parse(row["plr_LineID_tran"].ToString());
                }
                if (row["pi_pallet_no"] != null)
                {
                    model.pi_pallet_no = row["pi_pallet_no"].ToString();
                }
                if (row["CartonNo"] != null)
                {
                    model.CartonNo = row["CartonNo"].ToString();
                }
                if (row["CartonID"] != null)
                {
                    model.CartonID = row["CartonID"].ToString();
                }
                if (row["pi_type"] != null)
                {
                    model.pi_type = row["pi_type"].ToString();
                }
                if (row["pi_status"] != null)
                {
                    model.pi_status = row["pi_status"].ToString();
                }
                if (row["pi_status_msg"] != null)
                {
                    model.pi_status_msg = row["pi_status_msg"].ToString();
                }
                if (row["pi_remark"] != null)
                {
                    model.pi_remark = row["pi_remark"].ToString();
                }
                if (row["pi_cre_date"] != null && row["pi_cre_date"].ToString() != "")
                {
                    model.pi_cre_date = DateTime.Parse(row["pi_cre_date"].ToString());
                }
                if (row["pi_cre_userid"] != null)
                {
                    model.pi_cre_userid = row["pi_cre_userid"].ToString();
                }
                if (row["pi_update_date"] != null && row["pi_update_date"].ToString() != "")
                {
                    model.pi_update_date = DateTime.Parse(row["pi_update_date"].ToString());
                }
                if (row["pi_edituser_id"] != null)
                {
                    model.pi_edituser_id = row["pi_edituser_id"].ToString();
                }
                if (row["pi_user_ip"] != null)
                {
                    model.pi_user_ip = row["pi_user_ip"].ToString();
                }
                if (row["pi_void_status"] != null && row["pi_void_status"].ToString() != "")
                {
                    model.pi_void_status = int.Parse(row["pi_void_status"].ToString());
                }
                if (row["pi_chr01"] != null)
                {
                    model.pi_chr01 = row["pi_chr01"].ToString();
                }
                if (row["pi_chr02"] != null)
                {
                    model.pi_chr02 = row["pi_chr02"].ToString();
                }
                if (row["pi_deci1"] != null && row["pi_deci1"].ToString() != "")
                {
                    model.pi_deci1 = int.Parse(row["pi_deci1"].ToString());
                }
                if (row["pi_deci2"] != null && row["pi_deci2"].ToString() != "")
                {
                    model.pi_deci2 = decimal.Parse(row["pi_deci2"].ToString());
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
            strSql.Append("select PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_type,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 ");
            strSql.Append(" FROM pi_det ");
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
            strSql.Append(" PI_ID,pi_LineID,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_type,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 ");
            strSql.Append(" FROM pi_det ");
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
            strSql.Append("select count(1) FROM pi_det ");
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
                strSql.Append("order by T.pi_wec_ctn desc");
            }
            strSql.Append(")AS Row, T.*  from pi_det T ");
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
            parameters[0].Value = "pi_det";
            parameters[1].Value = "pi_wec_ctn";
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

