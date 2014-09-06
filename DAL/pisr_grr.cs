using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PI.DAL
{
    /// <summary>
    /// 数据访问类:pisr_grr
    /// </summary>
    public partial class pisr_grr
    {
        public pisr_grr()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("plr_LineID_tran", "pisr_grr");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string pi_wec_ctn, int plr_LineID_tran)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from pisr_grr");
            strSql.Append(" where pi_wec_ctn=@pi_wec_ctn and plr_LineID_tran=@plr_LineID_tran ");
            SqlParameter[] parameters = {
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4)			};
            parameters[0].Value = pi_wec_ctn;
            parameters[1].Value = plr_LineID_tran;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.pisr_grr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into pisr_grr(");
            strSql.Append("pi_wec_ctn,plr_LineID_tran,Plant,pisr_rir,pisr_invoice,pisr_part,Pisr_receiver,pisr_site,pisr_po_nbr,pisr_qty,pisr_curr,pisr_cost,pisr_base_cost,pisr_us_cost,pisr_seq,pisr_con_code,pisr_ch_desc,pisr_net_wt,pisr_rec_type,pisr_abc,pisr_code,pisr_lic_req,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2)");
            strSql.Append(" values (");
            strSql.Append("@pi_wec_ctn,@plr_LineID_tran,@Plant,@pisr_rir,@pisr_invoice,@pisr_part,@Pisr_receiver,@pisr_site,@pisr_po_nbr,@pisr_qty,@pisr_curr,@pisr_cost,@pisr_base_cost,@pisr_us_cost,@pisr_seq,@pisr_con_code,@pisr_ch_desc,@pisr_net_wt,@pisr_rec_type,@pisr_abc,@pisr_code,@pisr_lic_req,@pi_status,@pi_status_msg,@pi_remark,@pi_cre_date,@pi_cre_userid,@pi_update_date,@pi_edituser_id,@pi_user_ip,@pi_void_status,@pi_chr01,@pi_chr02,@pi_deci1,@pi_deci2)");
            SqlParameter[] parameters = {
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4),
					new SqlParameter("@Plant", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_rir", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_invoice", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_part", SqlDbType.NVarChar,50),
					new SqlParameter("@Pisr_receiver", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_site", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_po_nbr", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_qty", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_curr", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_cost", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_base_cost", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_us_cost", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_seq", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_con_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_ch_desc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_net_wt", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_rec_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_abc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_lic_req", SqlDbType.NVarChar,50),
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
            parameters[0].Value = model.pi_wec_ctn;
            parameters[1].Value = model.plr_LineID_tran;
            parameters[2].Value = model.Plant;
            parameters[3].Value = model.pisr_rir;
            parameters[4].Value = model.pisr_invoice;
            parameters[5].Value = model.pisr_part;
            parameters[6].Value = model.Pisr_receiver;
            parameters[7].Value = model.pisr_site;
            parameters[8].Value = model.pisr_po_nbr;
            parameters[9].Value = model.pisr_qty;
            parameters[10].Value = model.pisr_curr;
            parameters[11].Value = model.pisr_cost;
            parameters[12].Value = model.pisr_base_cost;
            parameters[13].Value = model.pisr_us_cost;
            parameters[14].Value = model.pisr_seq;
            parameters[15].Value = model.pisr_con_code;
            parameters[16].Value = model.pisr_ch_desc;
            parameters[17].Value = model.pisr_net_wt;
            parameters[18].Value = model.pisr_rec_type;
            parameters[19].Value = model.pisr_abc;
            parameters[20].Value = model.pisr_code;
            parameters[21].Value = model.pisr_lic_req;
            parameters[22].Value = model.pi_status;
            parameters[23].Value = model.pi_status_msg;
            parameters[24].Value = model.pi_remark;
            parameters[25].Value = model.pi_cre_date;
            parameters[26].Value = model.pi_cre_userid;
            parameters[27].Value = model.pi_update_date;
            parameters[28].Value = model.pi_edituser_id;
            parameters[29].Value = model.pi_user_ip;
            parameters[30].Value = model.pi_void_status;
            parameters[31].Value = model.pi_chr01;
            parameters[32].Value = model.pi_chr02;
            parameters[33].Value = model.pi_deci1;
            parameters[34].Value = model.pi_deci2;

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
        public bool Update(PI.Model.pisr_grr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update pisr_grr set ");
            strSql.Append("Plant=@Plant,");
            strSql.Append("pisr_rir=@pisr_rir,");
            strSql.Append("pisr_invoice=@pisr_invoice,");
            strSql.Append("pisr_part=@pisr_part,");
            strSql.Append("Pisr_receiver=@Pisr_receiver,");
            strSql.Append("pisr_site=@pisr_site,");
            strSql.Append("pisr_po_nbr=@pisr_po_nbr,");
            strSql.Append("pisr_qty=@pisr_qty,");
            strSql.Append("pisr_curr=@pisr_curr,");
            strSql.Append("pisr_cost=@pisr_cost,");
            strSql.Append("pisr_base_cost=@pisr_base_cost,");
            strSql.Append("pisr_us_cost=@pisr_us_cost,");
            strSql.Append("pisr_seq=@pisr_seq,");
            strSql.Append("pisr_con_code=@pisr_con_code,");
            strSql.Append("pisr_ch_desc=@pisr_ch_desc,");
            strSql.Append("pisr_net_wt=@pisr_net_wt,");
            strSql.Append("pisr_rec_type=@pisr_rec_type,");
            strSql.Append("pisr_abc=@pisr_abc,");
            strSql.Append("pisr_code=@pisr_code,");
            strSql.Append("pisr_lic_req=@pisr_lic_req,");
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
            strSql.Append(" where pi_wec_ctn=@pi_wec_ctn and plr_LineID_tran=@plr_LineID_tran ");
            SqlParameter[] parameters = {
					new SqlParameter("@Plant", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_rir", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_invoice", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_part", SqlDbType.NVarChar,50),
					new SqlParameter("@Pisr_receiver", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_site", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_po_nbr", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_qty", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_curr", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_cost", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_base_cost", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_us_cost", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_seq", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_con_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_ch_desc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_net_wt", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_rec_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_abc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_lic_req", SqlDbType.NVarChar,50),
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
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4)};
            parameters[0].Value = model.Plant;
            parameters[1].Value = model.pisr_rir;
            parameters[2].Value = model.pisr_invoice;
            parameters[3].Value = model.pisr_part;
            parameters[4].Value = model.Pisr_receiver;
            parameters[5].Value = model.pisr_site;
            parameters[6].Value = model.pisr_po_nbr;
            parameters[7].Value = model.pisr_qty;
            parameters[8].Value = model.pisr_curr;
            parameters[9].Value = model.pisr_cost;
            parameters[10].Value = model.pisr_base_cost;
            parameters[11].Value = model.pisr_us_cost;
            parameters[12].Value = model.pisr_seq;
            parameters[13].Value = model.pisr_con_code;
            parameters[14].Value = model.pisr_ch_desc;
            parameters[15].Value = model.pisr_net_wt;
            parameters[16].Value = model.pisr_rec_type;
            parameters[17].Value = model.pisr_abc;
            parameters[18].Value = model.pisr_code;
            parameters[19].Value = model.pisr_lic_req;
            parameters[20].Value = model.pi_status;
            parameters[21].Value = model.pi_status_msg;
            parameters[22].Value = model.pi_remark;
            parameters[23].Value = model.pi_cre_date;
            parameters[24].Value = model.pi_cre_userid;
            parameters[25].Value = model.pi_update_date;
            parameters[26].Value = model.pi_edituser_id;
            parameters[27].Value = model.pi_user_ip;
            parameters[28].Value = model.pi_void_status;
            parameters[29].Value = model.pi_chr01;
            parameters[30].Value = model.pi_chr02;
            parameters[31].Value = model.pi_deci1;
            parameters[32].Value = model.pi_deci2;
            parameters[33].Value = model.pi_wec_ctn;
            parameters[34].Value = model.plr_LineID_tran;

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
        public bool Delete(string pi_wec_ctn, int plr_LineID_tran)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from pisr_grr ");
            strSql.Append(" where pi_wec_ctn=@pi_wec_ctn and plr_LineID_tran=@plr_LineID_tran ");
            SqlParameter[] parameters = {
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4)			};
            parameters[0].Value = pi_wec_ctn;
            parameters[1].Value = plr_LineID_tran;

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
        public PI.Model.pisr_grr GetModel(string pi_wec_ctn, int plr_LineID_tran)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 pi_wec_ctn,plr_LineID_tran,Plant,pisr_rir,pisr_invoice,pisr_part,Pisr_receiver,pisr_site,pisr_po_nbr,pisr_qty,pisr_curr,pisr_cost,pisr_base_cost,pisr_us_cost,pisr_seq,pisr_con_code,pisr_ch_desc,pisr_net_wt,pisr_rec_type,pisr_abc,pisr_code,pisr_lic_req,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 from pisr_grr ");
            strSql.Append(" where pi_wec_ctn=@pi_wec_ctn and plr_LineID_tran=@plr_LineID_tran ");
            SqlParameter[] parameters = {
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4)			};
            parameters[0].Value = pi_wec_ctn;
            parameters[1].Value = plr_LineID_tran;

            PI.Model.pisr_grr model = new PI.Model.pisr_grr();
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
        public PI.Model.pisr_grr DataRowToModel(DataRow row)
        {
            PI.Model.pisr_grr model = new PI.Model.pisr_grr();
            if (row != null)
            {
                if (row["pi_wec_ctn"] != null)
                {
                    model.pi_wec_ctn = row["pi_wec_ctn"].ToString();
                }
                if (row["plr_LineID_tran"] != null && row["plr_LineID_tran"].ToString() != "")
                {
                    model.plr_LineID_tran = int.Parse(row["plr_LineID_tran"].ToString());
                }
                if (row["Plant"] != null)
                {
                    model.Plant = row["Plant"].ToString();
                }
                if (row["pisr_rir"] != null)
                {
                    model.pisr_rir = row["pisr_rir"].ToString();
                }
                if (row["pisr_invoice"] != null)
                {
                    model.pisr_invoice = row["pisr_invoice"].ToString();
                }
                if (row["pisr_part"] != null)
                {
                    model.pisr_part = row["pisr_part"].ToString();
                }
                if (row["Pisr_receiver"] != null)
                {
                    model.Pisr_receiver = row["Pisr_receiver"].ToString();
                }
                if (row["pisr_site"] != null)
                {
                    model.pisr_site = row["pisr_site"].ToString();
                }
                if (row["pisr_po_nbr"] != null)
                {
                    model.pisr_po_nbr = row["pisr_po_nbr"].ToString();
                }
                if (row["pisr_qty"] != null && row["pisr_qty"].ToString() != "")
                {
                    model.pisr_qty = decimal.Parse(row["pisr_qty"].ToString());
                }
                if (row["pisr_curr"] != null)
                {
                    model.pisr_curr = row["pisr_curr"].ToString();
                }
                if (row["pisr_cost"] != null && row["pisr_cost"].ToString() != "")
                {
                    model.pisr_cost = decimal.Parse(row["pisr_cost"].ToString());
                }
                if (row["pisr_base_cost"] != null && row["pisr_base_cost"].ToString() != "")
                {
                    model.pisr_base_cost = decimal.Parse(row["pisr_base_cost"].ToString());
                }
                if (row["pisr_us_cost"] != null && row["pisr_us_cost"].ToString() != "")
                {
                    model.pisr_us_cost = decimal.Parse(row["pisr_us_cost"].ToString());
                }
                if (row["pisr_seq"] != null)
                {
                    model.pisr_seq = row["pisr_seq"].ToString();
                }
                if (row["pisr_con_code"] != null)
                {
                    model.pisr_con_code = row["pisr_con_code"].ToString();
                }
                if (row["pisr_ch_desc"] != null)
                {
                    model.pisr_ch_desc = row["pisr_ch_desc"].ToString();
                }
                if (row["pisr_net_wt"] != null && row["pisr_net_wt"].ToString() != "")
                {
                    model.pisr_net_wt = decimal.Parse(row["pisr_net_wt"].ToString());
                }
                if (row["pisr_rec_type"] != null)
                {
                    model.pisr_rec_type = row["pisr_rec_type"].ToString();
                }
                if (row["pisr_abc"] != null)
                {
                    model.pisr_abc = row["pisr_abc"].ToString();
                }
                if (row["pisr_code"] != null)
                {
                    model.pisr_code = row["pisr_code"].ToString();
                }
                if (row["pisr_lic_req"] != null)
                {
                    model.pisr_lic_req = row["pisr_lic_req"].ToString();
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
            strSql.Append("select pi_wec_ctn,plr_LineID_tran,Plant,pisr_rir,pisr_invoice,pisr_part,Pisr_receiver,pisr_site,pisr_po_nbr,pisr_qty,pisr_curr,pisr_cost,pisr_base_cost,pisr_us_cost,pisr_seq,pisr_con_code,pisr_ch_desc,pisr_net_wt,pisr_rec_type,pisr_abc,pisr_code,pisr_lic_req,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 ");
            strSql.Append(" FROM pisr_grr ");
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
            strSql.Append(" pi_wec_ctn,plr_LineID_tran,Plant,pisr_rir,pisr_invoice,pisr_part,Pisr_receiver,pisr_site,pisr_po_nbr,pisr_qty,pisr_curr,pisr_cost,pisr_base_cost,pisr_us_cost,pisr_seq,pisr_con_code,pisr_ch_desc,pisr_net_wt,pisr_rec_type,pisr_abc,pisr_code,pisr_lic_req,pi_status,pi_status_msg,pi_remark,pi_cre_date,pi_cre_userid,pi_update_date,pi_edituser_id,pi_user_ip,pi_void_status,pi_chr01,pi_chr02,pi_deci1,pi_deci2 ");
            strSql.Append(" FROM pisr_grr ");
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
            strSql.Append("select count(1) FROM pisr_grr ");
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
                strSql.Append("order by T.plr_LineID_tran desc");
            }
            strSql.Append(")AS Row, T.*  from pisr_grr T ");
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
            parameters[0].Value = "pisr_grr";
            parameters[1].Value = "plr_LineID_tran";
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

