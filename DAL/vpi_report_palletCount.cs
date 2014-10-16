using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:vpi_report_palletCount
    /// </summary>
    public partial class vpi_report_palletCount
    {
        public vpi_report_palletCount()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_NO, int pi_pallet_no, int TTL, string PI_CARTON_NO, string PI_DESC, decimal PI_GW, string use_char01, string use_char02, int use_dec01)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from vpi_report_palletCount");
            strSql.Append(" where PI_NO=@PI_NO and pi_pallet_no=@pi_pallet_no and TTL=@TTL and PI_CARTON_NO=@PI_CARTON_NO and PI_DESC=@PI_DESC and PI_GW=@PI_GW and use_char01=@use_char01 and use_char02=@use_char02 and use_dec01=@use_dec01 ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@TTL", SqlDbType.Int,4),
					new SqlParameter("@PI_CARTON_NO", SqlDbType.NVarChar,14),
					new SqlParameter("@PI_DESC", SqlDbType.NVarChar,16),
					new SqlParameter("@PI_GW", SqlDbType.Decimal,5),
					new SqlParameter("@use_char01", SqlDbType.VarChar,1),
					new SqlParameter("@use_char02", SqlDbType.VarChar,1),
					new SqlParameter("@use_dec01", SqlDbType.Int,4)			};
            parameters[0].Value = PI_NO;
            parameters[1].Value = pi_pallet_no;
            parameters[2].Value = TTL;
            parameters[3].Value = PI_CARTON_NO;
            parameters[4].Value = PI_DESC;
            parameters[5].Value = PI_GW;
            parameters[6].Value = use_char01;
            parameters[7].Value = use_char02;
            parameters[8].Value = use_dec01;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.vpi_report_palletCount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into vpi_report_palletCount(");
            strSql.Append("PI_NO,pi_pallet_no,TTL,PI_CARTON_NO,PI_DESC,PI_GW,use_char01,use_char02,use_dec01)");
            strSql.Append(" values (");
            strSql.Append("@PI_NO,@pi_pallet_no,@TTL,@PI_CARTON_NO,@PI_DESC,@PI_GW,@use_char01,@use_char02,@use_dec01)");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@TTL", SqlDbType.Int,4),
					new SqlParameter("@PI_CARTON_NO", SqlDbType.NVarChar,14),
					new SqlParameter("@PI_DESC", SqlDbType.NVarChar,16),
					new SqlParameter("@PI_GW", SqlDbType.Decimal,5),
					new SqlParameter("@use_char01", SqlDbType.VarChar,1),
					new SqlParameter("@use_char02", SqlDbType.VarChar,1),
					new SqlParameter("@use_dec01", SqlDbType.Int,4)};
            parameters[0].Value = model.PI_NO;
            parameters[1].Value = model.pi_pallet_no;
            parameters[2].Value = model.TTL;
            parameters[3].Value = model.PI_CARTON_NO;
            parameters[4].Value = model.PI_DESC;
            parameters[5].Value = model.PI_GW;
            parameters[6].Value = model.use_char01;
            parameters[7].Value = model.use_char02;
            parameters[8].Value = model.use_dec01;

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
        public bool Update(PIE.Model.vpi_report_palletCount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update vpi_report_palletCount set ");
            strSql.Append("PI_NO=@PI_NO,");
            strSql.Append("pi_pallet_no=@pi_pallet_no,");
            strSql.Append("TTL=@TTL,");
            strSql.Append("PI_CARTON_NO=@PI_CARTON_NO,");
            strSql.Append("PI_DESC=@PI_DESC,");
            strSql.Append("PI_GW=@PI_GW,");
            strSql.Append("use_char01=@use_char01,");
            strSql.Append("use_char02=@use_char02,");
            strSql.Append("use_dec01=@use_dec01");
            strSql.Append(" where PI_NO=@PI_NO and pi_pallet_no=@pi_pallet_no and TTL=@TTL and PI_CARTON_NO=@PI_CARTON_NO and PI_DESC=@PI_DESC and PI_GW=@PI_GW and use_char01=@use_char01 and use_char02=@use_char02 and use_dec01=@use_dec01 ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@TTL", SqlDbType.Int,4),
					new SqlParameter("@PI_CARTON_NO", SqlDbType.NVarChar,14),
					new SqlParameter("@PI_DESC", SqlDbType.NVarChar,16),
					new SqlParameter("@PI_GW", SqlDbType.Decimal,5),
					new SqlParameter("@use_char01", SqlDbType.VarChar,1),
					new SqlParameter("@use_char02", SqlDbType.VarChar,1),
					new SqlParameter("@use_dec01", SqlDbType.Int,4)};
            parameters[0].Value = model.PI_NO;
            parameters[1].Value = model.pi_pallet_no;
            parameters[2].Value = model.TTL;
            parameters[3].Value = model.PI_CARTON_NO;
            parameters[4].Value = model.PI_DESC;
            parameters[5].Value = model.PI_GW;
            parameters[6].Value = model.use_char01;
            parameters[7].Value = model.use_char02;
            parameters[8].Value = model.use_dec01;

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
        public bool Delete(string PI_NO, int pi_pallet_no, int TTL, string PI_CARTON_NO, string PI_DESC, decimal PI_GW, string use_char01, string use_char02, int use_dec01)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from vpi_report_palletCount ");
            strSql.Append(" where PI_NO=@PI_NO and pi_pallet_no=@pi_pallet_no and TTL=@TTL and PI_CARTON_NO=@PI_CARTON_NO and PI_DESC=@PI_DESC and PI_GW=@PI_GW and use_char01=@use_char01 and use_char02=@use_char02 and use_dec01=@use_dec01 ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@TTL", SqlDbType.Int,4),
					new SqlParameter("@PI_CARTON_NO", SqlDbType.NVarChar,14),
					new SqlParameter("@PI_DESC", SqlDbType.NVarChar,16),
					new SqlParameter("@PI_GW", SqlDbType.Decimal,5),
					new SqlParameter("@use_char01", SqlDbType.VarChar,1),
					new SqlParameter("@use_char02", SqlDbType.VarChar,1),
					new SqlParameter("@use_dec01", SqlDbType.Int,4)			};
            parameters[0].Value = PI_NO;
            parameters[1].Value = pi_pallet_no;
            parameters[2].Value = TTL;
            parameters[3].Value = PI_CARTON_NO;
            parameters[4].Value = PI_DESC;
            parameters[5].Value = PI_GW;
            parameters[6].Value = use_char01;
            parameters[7].Value = use_char02;
            parameters[8].Value = use_dec01;

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
        public PIE.Model.vpi_report_palletCount GetModel(string PI_NO, int pi_pallet_no, int TTL, string PI_CARTON_NO, string PI_DESC, decimal PI_GW, string use_char01, string use_char02, int use_dec01)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PI_NO,pi_pallet_no,TTL,PI_CARTON_NO,PI_DESC,PI_GW,use_char01,use_char02,use_dec01 from vpi_report_palletCount ");
            strSql.Append(" where PI_NO=@PI_NO and pi_pallet_no=@pi_pallet_no and TTL=@TTL and PI_CARTON_NO=@PI_CARTON_NO and PI_DESC=@PI_DESC and PI_GW=@PI_GW and use_char01=@use_char01 and use_char02=@use_char02 and use_dec01=@use_dec01 ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@TTL", SqlDbType.Int,4),
					new SqlParameter("@PI_CARTON_NO", SqlDbType.NVarChar,14),
					new SqlParameter("@PI_DESC", SqlDbType.NVarChar,16),
					new SqlParameter("@PI_GW", SqlDbType.Decimal,5),
					new SqlParameter("@use_char01", SqlDbType.VarChar,1),
					new SqlParameter("@use_char02", SqlDbType.VarChar,1),
					new SqlParameter("@use_dec01", SqlDbType.Int,4)			};
            parameters[0].Value = PI_NO;
            parameters[1].Value = pi_pallet_no;
            parameters[2].Value = TTL;
            parameters[3].Value = PI_CARTON_NO;
            parameters[4].Value = PI_DESC;
            parameters[5].Value = PI_GW;
            parameters[6].Value = use_char01;
            parameters[7].Value = use_char02;
            parameters[8].Value = use_dec01;

            PIE.Model.vpi_report_palletCount model = new PIE.Model.vpi_report_palletCount();
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
        public PIE.Model.vpi_report_palletCount DataRowToModel(DataRow row)
        {
            PIE.Model.vpi_report_palletCount model = new PIE.Model.vpi_report_palletCount();
            if (row != null)
            {
                if (row["PI_NO"] != null)
                {
                    model.PI_NO = row["PI_NO"].ToString();
                }
                if (row["pi_pallet_no"] != null && row["pi_pallet_no"].ToString() != "")
                {
                    model.pi_pallet_no = int.Parse(row["pi_pallet_no"].ToString());
                }
                if (row["TTL"] != null && row["TTL"].ToString() != "")
                {
                    model.TTL = int.Parse(row["TTL"].ToString());
                }
                if (row["PI_CARTON_NO"] != null)
                {
                    model.PI_CARTON_NO = row["PI_CARTON_NO"].ToString();
                }
                if (row["PI_DESC"] != null)
                {
                    model.PI_DESC = row["PI_DESC"].ToString();
                }
                if (row["PI_GW"] != null && row["PI_GW"].ToString() != "")
                {
                    model.PI_GW = decimal.Parse(row["PI_GW"].ToString());
                }
                if (row["use_char01"] != null)
                {
                    model.use_char01 = row["use_char01"].ToString();
                }
                if (row["use_char02"] != null)
                {
                    model.use_char02 = row["use_char02"].ToString();
                }
                if (row["use_dec01"] != null && row["use_dec01"].ToString() != "")
                {
                    model.use_dec01 = int.Parse(row["use_dec01"].ToString());
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
            strSql.Append("select PI_NO,pi_pallet_no,TTL,PI_CARTON_NO,PI_DESC,PI_GW,use_char01,use_char02,use_dec01 ");
            strSql.Append(" FROM vpi_report_palletCount ");
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
            strSql.Append(" PI_NO,pi_pallet_no,TTL,PI_CARTON_NO,PI_DESC,PI_GW,use_char01,use_char02,use_dec01 ");
            strSql.Append(" FROM vpi_report_palletCount ");
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
            strSql.Append("select count(1) FROM vpi_report_palletCount ");
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
                strSql.Append("order by T.use_dec01 desc");
            }
            strSql.Append(")AS Row, T.*  from vpi_report_palletCount T ");
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
            parameters[0].Value = "vpi_report_palletCount";
            parameters[1].Value = "use_dec01";
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

