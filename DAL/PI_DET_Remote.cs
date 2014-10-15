using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:PI_DET_Remote
    /// </summary>
    public partial class PI_DET_Remote
    {
        public DbHelperSQLP DbHelperSQLP = new DbHelperSQLP(PubConstant.ConnectionStringRemote);
        public PI_DET_Remote()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_NO, int PI_LINE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PI_DET");
            strSql.Append(" where PI_NO=@PI_NO and PI_LINE=@PI_LINE ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_LINE", SqlDbType.Int,4)			};
            parameters[0].Value = PI_NO;
            parameters[1].Value = PI_LINE;

            return DbHelperSQLP.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(PI.Model.PI_DET_Remote model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PI_DET(");
            strSql.Append("PI_NO,PI_CARTON_NO,PI_SITE,PI_PART,PI_CO,PI_DESC,PI_QTY,PI_LOT,PI_NW,PI_K200_NW,PI_GW,PI_SBU,PI_REC_NO,PI_PRICE,PI_PALLET,PI_PO_price,PI_CONTRACT,PI_SEQ,PI_SEQ_CL,PI_IQC,PI_PO,PI_Taxcode,PI_ConnCode,pi_user,pi_cre_time,pi_ver,pi_mfgr,pi_mfgr_part,pi_mfgr_name,pi_Lic_req,pi_ori_PO_price,pi_PO_curr,pi_curr_rate,pi_us_rate,pi_vend)");
            strSql.Append(" values (");
            strSql.Append("@PI_NO,@PI_CARTON_NO,@PI_SITE,@PI_PART,@PI_CO,@PI_DESC,@PI_QTY,@PI_LOT,@PI_NW,@PI_K200_NW,@PI_GW,@PI_SBU,@PI_REC_NO,@PI_PRICE,@PI_PALLET,@PI_PO_price,@PI_CONTRACT,@PI_SEQ,@PI_SEQ_CL,@PI_IQC,@PI_PO,@PI_Taxcode,@PI_ConnCode,@pi_user,@pi_cre_time,@pi_ver,@pi_mfgr,@pi_mfgr_part,@pi_mfgr_name,@pi_Lic_req,@pi_ori_PO_price,@pi_PO_curr,@pi_curr_rate,@pi_us_rate,@pi_vend)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_CARTON_NO", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_SITE", SqlDbType.NVarChar,6),
					new SqlParameter("@PI_PART", SqlDbType.NVarChar,18),
					new SqlParameter("@PI_CO", SqlDbType.NVarChar,10),
					new SqlParameter("@PI_DESC", SqlDbType.NVarChar,48),
					new SqlParameter("@PI_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@PI_LOT", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_NW", SqlDbType.Decimal,9),
					new SqlParameter("@PI_K200_NW", SqlDbType.Decimal,9),
					new SqlParameter("@PI_GW", SqlDbType.Decimal,9),
					new SqlParameter("@PI_SBU", SqlDbType.NChar,4),
					new SqlParameter("@PI_REC_NO", SqlDbType.NVarChar,15),
					new SqlParameter("@PI_PRICE", SqlDbType.Decimal,9),
					new SqlParameter("@PI_PALLET", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_PO_price", SqlDbType.Decimal,9),
					new SqlParameter("@PI_CONTRACT", SqlDbType.Char,18),
					new SqlParameter("@PI_SEQ", SqlDbType.Int,4),
					new SqlParameter("@PI_SEQ_CL", SqlDbType.Int,4),
					new SqlParameter("@PI_IQC", SqlDbType.Char,4),
					new SqlParameter("@PI_PO", SqlDbType.Char,8),
					new SqlParameter("@PI_Taxcode", SqlDbType.Char,16),
					new SqlParameter("@PI_ConnCode", SqlDbType.Char,8),
					new SqlParameter("@pi_user", SqlDbType.Char,8),
					new SqlParameter("@pi_cre_time", SqlDbType.DateTime),
					new SqlParameter("@pi_ver", SqlDbType.Int,4),
					new SqlParameter("@pi_mfgr", SqlDbType.Char,8),
					new SqlParameter("@pi_mfgr_part", SqlDbType.Char,40),
					new SqlParameter("@pi_mfgr_name", SqlDbType.Char,40),
					new SqlParameter("@pi_Lic_req", SqlDbType.Char,3),
					new SqlParameter("@pi_ori_PO_price", SqlDbType.Decimal,9),
					new SqlParameter("@pi_PO_curr", SqlDbType.Char,8),
					new SqlParameter("@pi_curr_rate", SqlDbType.Decimal,9),
					new SqlParameter("@pi_us_rate", SqlDbType.Decimal,9),
					new SqlParameter("@pi_vend", SqlDbType.Char,8)};
            parameters[0].Value = model.PI_NO;
            parameters[1].Value = model.PI_CARTON_NO;
            parameters[2].Value = model.PI_SITE;
            parameters[3].Value = model.PI_PART;
            parameters[4].Value = model.PI_CO;
            parameters[5].Value = model.PI_DESC;
            parameters[6].Value = model.PI_QTY;
            parameters[7].Value = model.PI_LOT;
            parameters[8].Value = model.PI_NW;
            parameters[9].Value = model.PI_K200_NW;
            parameters[10].Value = model.PI_GW;
            parameters[11].Value = model.PI_SBU;
            parameters[12].Value = model.PI_REC_NO;
            parameters[13].Value = model.PI_PRICE;
            parameters[14].Value = model.PI_PALLET;
            parameters[15].Value = model.PI_PO_price;
            parameters[16].Value = model.PI_CONTRACT;
            parameters[17].Value = model.PI_SEQ;
            parameters[18].Value = model.PI_SEQ_CL;
            parameters[19].Value = model.PI_IQC;
            parameters[20].Value = model.PI_PO;
            parameters[21].Value = model.PI_Taxcode;
            parameters[22].Value = model.PI_ConnCode;
            parameters[23].Value = model.pi_user;
            parameters[24].Value = model.pi_cre_time;
            parameters[25].Value = model.pi_ver;
            parameters[26].Value = model.pi_mfgr;
            parameters[27].Value = model.pi_mfgr_part;
            parameters[28].Value = model.pi_mfgr_name;
            parameters[29].Value = model.pi_Lic_req;
            parameters[30].Value = model.pi_ori_PO_price;
            parameters[31].Value = model.pi_PO_curr;
            parameters[32].Value = model.pi_curr_rate;
            parameters[33].Value = model.pi_us_rate;
            parameters[34].Value = model.pi_vend;

            object obj = DbHelperSQLP.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(PI.Model.PI_DET_Remote model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PI_DET set ");
            strSql.Append("PI_CARTON_NO=@PI_CARTON_NO,");
            strSql.Append("PI_SITE=@PI_SITE,");
            strSql.Append("PI_PART=@PI_PART,");
            strSql.Append("PI_CO=@PI_CO,");
            strSql.Append("PI_DESC=@PI_DESC,");
            strSql.Append("PI_QTY=@PI_QTY,");
            strSql.Append("PI_LOT=@PI_LOT,");
            strSql.Append("PI_NW=@PI_NW,");
            strSql.Append("PI_K200_NW=@PI_K200_NW,");
            strSql.Append("PI_GW=@PI_GW,");
            strSql.Append("PI_SBU=@PI_SBU,");
            strSql.Append("PI_REC_NO=@PI_REC_NO,");
            strSql.Append("PI_PRICE=@PI_PRICE,");
            strSql.Append("PI_PALLET=@PI_PALLET,");
            strSql.Append("PI_PO_price=@PI_PO_price,");
            strSql.Append("PI_CONTRACT=@PI_CONTRACT,");
            strSql.Append("PI_SEQ=@PI_SEQ,");
            strSql.Append("PI_SEQ_CL=@PI_SEQ_CL,");
            strSql.Append("PI_IQC=@PI_IQC,");
            strSql.Append("PI_PO=@PI_PO,");
            strSql.Append("PI_Taxcode=@PI_Taxcode,");
            strSql.Append("PI_ConnCode=@PI_ConnCode,");
            strSql.Append("pi_user=@pi_user,");
            strSql.Append("pi_cre_time=@pi_cre_time,");
            strSql.Append("pi_ver=@pi_ver,");
            strSql.Append("pi_mfgr=@pi_mfgr,");
            strSql.Append("pi_mfgr_part=@pi_mfgr_part,");
            strSql.Append("pi_mfgr_name=@pi_mfgr_name,");
            strSql.Append("pi_Lic_req=@pi_Lic_req,");
            strSql.Append("pi_ori_PO_price=@pi_ori_PO_price,");
            strSql.Append("pi_PO_curr=@pi_PO_curr,");
            strSql.Append("pi_curr_rate=@pi_curr_rate,");
            strSql.Append("pi_us_rate=@pi_us_rate,");
            strSql.Append("pi_vend=@pi_vend");
            strSql.Append(" where PI_LINE=@PI_LINE");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_CARTON_NO", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_SITE", SqlDbType.NVarChar,6),
					new SqlParameter("@PI_PART", SqlDbType.NVarChar,18),
					new SqlParameter("@PI_CO", SqlDbType.NVarChar,10),
					new SqlParameter("@PI_DESC", SqlDbType.NVarChar,48),
					new SqlParameter("@PI_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@PI_LOT", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_NW", SqlDbType.Decimal,9),
					new SqlParameter("@PI_K200_NW", SqlDbType.Decimal,9),
					new SqlParameter("@PI_GW", SqlDbType.Decimal,9),
					new SqlParameter("@PI_SBU", SqlDbType.NChar,4),
					new SqlParameter("@PI_REC_NO", SqlDbType.NVarChar,15),
					new SqlParameter("@PI_PRICE", SqlDbType.Decimal,9),
					new SqlParameter("@PI_PALLET", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_PO_price", SqlDbType.Decimal,9),
					new SqlParameter("@PI_CONTRACT", SqlDbType.Char,18),
					new SqlParameter("@PI_SEQ", SqlDbType.Int,4),
					new SqlParameter("@PI_SEQ_CL", SqlDbType.Int,4),
					new SqlParameter("@PI_IQC", SqlDbType.Char,4),
					new SqlParameter("@PI_PO", SqlDbType.Char,8),
					new SqlParameter("@PI_Taxcode", SqlDbType.Char,16),
					new SqlParameter("@PI_ConnCode", SqlDbType.Char,8),
					new SqlParameter("@pi_user", SqlDbType.Char,8),
					new SqlParameter("@pi_cre_time", SqlDbType.DateTime),
					new SqlParameter("@pi_ver", SqlDbType.Int,4),
					new SqlParameter("@pi_mfgr", SqlDbType.Char,8),
					new SqlParameter("@pi_mfgr_part", SqlDbType.Char,40),
					new SqlParameter("@pi_mfgr_name", SqlDbType.Char,40),
					new SqlParameter("@pi_Lic_req", SqlDbType.Char,3),
					new SqlParameter("@pi_ori_PO_price", SqlDbType.Decimal,9),
					new SqlParameter("@pi_PO_curr", SqlDbType.Char,8),
					new SqlParameter("@pi_curr_rate", SqlDbType.Decimal,9),
					new SqlParameter("@pi_us_rate", SqlDbType.Decimal,9),
					new SqlParameter("@pi_vend", SqlDbType.Char,8),
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_LINE", SqlDbType.Int,4)};
            parameters[0].Value = model.PI_CARTON_NO;
            parameters[1].Value = model.PI_SITE;
            parameters[2].Value = model.PI_PART;
            parameters[3].Value = model.PI_CO;
            parameters[4].Value = model.PI_DESC;
            parameters[5].Value = model.PI_QTY;
            parameters[6].Value = model.PI_LOT;
            parameters[7].Value = model.PI_NW;
            parameters[8].Value = model.PI_K200_NW;
            parameters[9].Value = model.PI_GW;
            parameters[10].Value = model.PI_SBU;
            parameters[11].Value = model.PI_REC_NO;
            parameters[12].Value = model.PI_PRICE;
            parameters[13].Value = model.PI_PALLET;
            parameters[14].Value = model.PI_PO_price;
            parameters[15].Value = model.PI_CONTRACT;
            parameters[16].Value = model.PI_SEQ;
            parameters[17].Value = model.PI_SEQ_CL;
            parameters[18].Value = model.PI_IQC;
            parameters[19].Value = model.PI_PO;
            parameters[20].Value = model.PI_Taxcode;
            parameters[21].Value = model.PI_ConnCode;
            parameters[22].Value = model.pi_user;
            parameters[23].Value = model.pi_cre_time;
            parameters[24].Value = model.pi_ver;
            parameters[25].Value = model.pi_mfgr;
            parameters[26].Value = model.pi_mfgr_part;
            parameters[27].Value = model.pi_mfgr_name;
            parameters[28].Value = model.pi_Lic_req;
            parameters[29].Value = model.pi_ori_PO_price;
            parameters[30].Value = model.pi_PO_curr;
            parameters[31].Value = model.pi_curr_rate;
            parameters[32].Value = model.pi_us_rate;
            parameters[33].Value = model.pi_vend;
            parameters[34].Value = model.PI_NO;
            parameters[35].Value = model.PI_LINE;

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
        public bool Delete(int PI_LINE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PI_DET ");
            strSql.Append(" where PI_LINE=@PI_LINE");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_LINE", SqlDbType.Int,4)
			};
            parameters[0].Value = PI_LINE;

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
        public bool Delete(string PI_NO, int PI_LINE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PI_DET ");
            strSql.Append(" where PI_NO=@PI_NO and PI_LINE=@PI_LINE ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_NO", SqlDbType.NVarChar,12),
					new SqlParameter("@PI_LINE", SqlDbType.Int,4)			};
            parameters[0].Value = PI_NO;
            parameters[1].Value = PI_LINE;

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
        public bool DeleteList(string PI_LINElist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PI_DET ");
            strSql.Append(" where PI_LINE in (" + PI_LINElist + ")  ");
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
        public PI.Model.PI_DET_Remote GetModel(int PI_LINE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PI_NO,PI_LINE,PI_CARTON_NO,PI_SITE,PI_PART,PI_CO,PI_DESC,PI_QTY,PI_LOT,PI_NW,PI_K200_NW,PI_GW,PI_SBU,PI_REC_NO,PI_PRICE,PI_PALLET,PI_PO_price,PI_CONTRACT,PI_SEQ,PI_SEQ_CL,PI_IQC,PI_PO,PI_Taxcode,PI_ConnCode,pi_user,pi_cre_time,pi_ver,pi_mfgr,pi_mfgr_part,pi_mfgr_name,pi_Lic_req,pi_ori_PO_price,pi_PO_curr,pi_curr_rate,pi_us_rate,pi_vend from PI_DET ");
            strSql.Append(" where PI_LINE=@PI_LINE");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_LINE", SqlDbType.Int,4)
			};
            parameters[0].Value = PI_LINE;

            PI.Model.PI_DET_Remote model = new PI.Model.PI_DET_Remote();
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
        public PI.Model.PI_DET_Remote DataRowToModel(DataRow row)
        {
            PI.Model.PI_DET_Remote model = new PI.Model.PI_DET_Remote();
            if (row != null)
            {
                if (row["PI_NO"] != null)
                {
                    model.PI_NO = row["PI_NO"].ToString();
                }
                if (row["PI_LINE"] != null && row["PI_LINE"].ToString() != "")
                {
                    model.PI_LINE = int.Parse(row["PI_LINE"].ToString());
                }
                if (row["PI_CARTON_NO"] != null)
                {
                    model.PI_CARTON_NO = row["PI_CARTON_NO"].ToString();
                }
                if (row["PI_SITE"] != null)
                {
                    model.PI_SITE = row["PI_SITE"].ToString();
                }
                if (row["PI_PART"] != null)
                {
                    model.PI_PART = row["PI_PART"].ToString();
                }
                if (row["PI_CO"] != null)
                {
                    model.PI_CO = row["PI_CO"].ToString();
                }
                if (row["PI_DESC"] != null)
                {
                    model.PI_DESC = row["PI_DESC"].ToString();
                }
                if (row["PI_QTY"] != null && row["PI_QTY"].ToString() != "")
                {
                    model.PI_QTY = decimal.Parse(row["PI_QTY"].ToString());
                }
                if (row["PI_LOT"] != null)
                {
                    model.PI_LOT = row["PI_LOT"].ToString();
                }
                if (row["PI_NW"] != null && row["PI_NW"].ToString() != "")
                {
                    model.PI_NW = decimal.Parse(row["PI_NW"].ToString());
                }
                if (row["PI_K200_NW"] != null && row["PI_K200_NW"].ToString() != "")
                {
                    model.PI_K200_NW = decimal.Parse(row["PI_K200_NW"].ToString());
                }
                if (row["PI_GW"] != null && row["PI_GW"].ToString() != "")
                {
                    model.PI_GW = decimal.Parse(row["PI_GW"].ToString());
                }
                if (row["PI_SBU"] != null)
                {
                    model.PI_SBU = row["PI_SBU"].ToString();
                }
                if (row["PI_REC_NO"] != null)
                {
                    model.PI_REC_NO = row["PI_REC_NO"].ToString();
                }
                if (row["PI_PRICE"] != null && row["PI_PRICE"].ToString() != "")
                {
                    model.PI_PRICE = decimal.Parse(row["PI_PRICE"].ToString());
                }
                if (row["PI_PALLET"] != null)
                {
                    model.PI_PALLET = row["PI_PALLET"].ToString();
                }
                if (row["PI_PO_price"] != null && row["PI_PO_price"].ToString() != "")
                {
                    model.PI_PO_price = decimal.Parse(row["PI_PO_price"].ToString());
                }
                if (row["PI_CONTRACT"] != null)
                {
                    model.PI_CONTRACT = row["PI_CONTRACT"].ToString();
                }
                if (row["PI_SEQ"] != null && row["PI_SEQ"].ToString() != "")
                {
                    model.PI_SEQ = int.Parse(row["PI_SEQ"].ToString());
                }
                if (row["PI_SEQ_CL"] != null && row["PI_SEQ_CL"].ToString() != "")
                {
                    model.PI_SEQ_CL = int.Parse(row["PI_SEQ_CL"].ToString());
                }
                if (row["PI_IQC"] != null)
                {
                    model.PI_IQC = row["PI_IQC"].ToString();
                }
                if (row["PI_PO"] != null)
                {
                    model.PI_PO = row["PI_PO"].ToString();
                }
                if (row["PI_Taxcode"] != null)
                {
                    model.PI_Taxcode = row["PI_Taxcode"].ToString();
                }
                if (row["PI_ConnCode"] != null)
                {
                    model.PI_ConnCode = row["PI_ConnCode"].ToString();
                }
                if (row["pi_user"] != null)
                {
                    model.pi_user = row["pi_user"].ToString();
                }
                if (row["pi_cre_time"] != null && row["pi_cre_time"].ToString() != "")
                {
                    model.pi_cre_time = DateTime.Parse(row["pi_cre_time"].ToString());
                }
                if (row["pi_ver"] != null && row["pi_ver"].ToString() != "")
                {
                    model.pi_ver = int.Parse(row["pi_ver"].ToString());
                }
                if (row["pi_mfgr"] != null)
                {
                    model.pi_mfgr = row["pi_mfgr"].ToString();
                }
                if (row["pi_mfgr_part"] != null)
                {
                    model.pi_mfgr_part = row["pi_mfgr_part"].ToString();
                }
                if (row["pi_mfgr_name"] != null)
                {
                    model.pi_mfgr_name = row["pi_mfgr_name"].ToString();
                }
                if (row["pi_Lic_req"] != null)
                {
                    model.pi_Lic_req = row["pi_Lic_req"].ToString();
                }
                if (row["pi_ori_PO_price"] != null && row["pi_ori_PO_price"].ToString() != "")
                {
                    model.pi_ori_PO_price = decimal.Parse(row["pi_ori_PO_price"].ToString());
                }
                if (row["pi_PO_curr"] != null)
                {
                    model.pi_PO_curr = row["pi_PO_curr"].ToString();
                }
                if (row["pi_curr_rate"] != null && row["pi_curr_rate"].ToString() != "")
                {
                    model.pi_curr_rate = decimal.Parse(row["pi_curr_rate"].ToString());
                }
                if (row["pi_us_rate"] != null && row["pi_us_rate"].ToString() != "")
                {
                    model.pi_us_rate = decimal.Parse(row["pi_us_rate"].ToString());
                }
                if (row["pi_vend"] != null)
                {
                    model.pi_vend = row["pi_vend"].ToString();
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
            strSql.Append("select PI_NO,PI_LINE,PI_CARTON_NO,PI_SITE,PI_PART,PI_CO,PI_DESC,PI_QTY,PI_LOT,PI_NW,PI_K200_NW,PI_GW,PI_SBU,PI_REC_NO,PI_PRICE,PI_PALLET,PI_PO_price,PI_CONTRACT,PI_SEQ,PI_SEQ_CL,PI_IQC,PI_PO,PI_Taxcode,PI_ConnCode,pi_user,pi_cre_time,pi_ver,pi_mfgr,pi_mfgr_part,pi_mfgr_name,pi_Lic_req,pi_ori_PO_price,pi_PO_curr,pi_curr_rate,pi_us_rate,pi_vend ");
            strSql.Append(" from PI_DET ");
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
            strSql.Append(" PI_NO,PI_LINE,PI_CARTON_NO,PI_SITE,PI_PART,PI_CO,PI_DESC,PI_QTY,PI_LOT,PI_NW,PI_K200_NW,PI_GW,PI_SBU,PI_REC_NO,PI_PRICE,PI_PALLET,PI_PO_price,PI_CONTRACT,PI_SEQ,PI_SEQ_CL,PI_IQC,PI_PO,PI_Taxcode,PI_ConnCode,pi_user,pi_cre_time,pi_ver,pi_mfgr,pi_mfgr_part,pi_mfgr_name,pi_Lic_req,pi_ori_PO_price,pi_PO_curr,pi_curr_rate,pi_us_rate,pi_vend ");
            strSql.Append(" from PI_DET ");
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
            strSql.Append("select count(1) from PI_DET ");
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
                strSql.Append("order by T.PI_LINE desc");
            }
            strSql.Append(")AS Row, T.*  from PI_DET T ");
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
            parameters[0].Value = "PI_DET_Remote";
            parameters[1].Value = "PI_LINE";
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

