using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:plr_mstr_tran
    /// </summary>
    public partial class plr_mstr_tran
    {
        public plr_mstr_tran()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("LineID", "plr_mstr_tran");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Batch_ID, string plr_partno, int LineID, int Wec_Ctn)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from plr_mstr_tran");
            strSql.Append(" where Batch_ID=@Batch_ID and plr_partno=@plr_partno and LineID=@LineID and Wec_Ctn=@Wec_Ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_partno", SqlDbType.VarChar,30),
					new SqlParameter("@LineID", SqlDbType.Int,4),
					new SqlParameter("@Wec_Ctn", SqlDbType.Int,4)			};
            parameters[0].Value = Batch_ID;
            parameters[1].Value = plr_partno;
            parameters[2].Value = LineID;
            parameters[3].Value = Wec_Ctn;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.plr_mstr_tran model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into plr_mstr_tran(");
            strSql.Append("Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,CartonNo,CartonID,plr_wec_ctn,plr_po,plr_partno,CartonType,plr_carton_qty,plr_qty,plr_suppliers_id,packingListID,InvoiceID,plr_rcp_date,plr_pallet_no,plr_deli_date,plr_site,plr_co,plr_date_code,plr_vend_mfgr,Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2)");
            strSql.Append(" values (");
            strSql.Append("@Batch_ID,@LineID,@Wec_Ctn,@plr_status,@plr_status_msg,@CartonNo,@CartonID,@plr_wec_ctn,@plr_po,@plr_partno,@CartonType,@plr_carton_qty,@plr_qty,@plr_suppliers_id,@packingListID,@InvoiceID,@plr_rcp_date,@plr_pallet_no,@plr_deli_date,@plr_site,@plr_co,@plr_date_code,@plr_vend_mfgr,@Plr_vm_partno,@carton_id_prifix,@re_mark,@plr_cre_date,@plr_cre_userid,@plr_update_date,@plr_edituser_id,@plr_user_ip,@plr_void_status,@plr_chr01,@plr_chr02,@plr_deci1,@plr_deci2)");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@LineID", SqlDbType.Int,4),
					new SqlParameter("@Wec_Ctn", SqlDbType.Int,4),
					new SqlParameter("@plr_status", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_status_msg", SqlDbType.NVarChar,4000),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_po", SqlDbType.VarChar,30),
					new SqlParameter("@plr_partno", SqlDbType.VarChar,30),
					new SqlParameter("@CartonType", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_carton_qty", SqlDbType.Decimal,9),
					new SqlParameter("@plr_qty", SqlDbType.Decimal,9),
					new SqlParameter("@plr_suppliers_id", SqlDbType.NVarChar,50),
					new SqlParameter("@packingListID", SqlDbType.VarChar,30),
					new SqlParameter("@InvoiceID", SqlDbType.VarChar,30),
					new SqlParameter("@plr_rcp_date", SqlDbType.Date,3),
					new SqlParameter("@plr_pallet_no", SqlDbType.NVarChar,10),
					new SqlParameter("@plr_deli_date", SqlDbType.Date,3),
					new SqlParameter("@plr_site", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_co", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_date_code", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_vend_mfgr", SqlDbType.VarChar,30),
					new SqlParameter("@Plr_vm_partno", SqlDbType.VarChar,30),
					new SqlParameter("@carton_id_prifix", SqlDbType.NVarChar,50),
					new SqlParameter("@re_mark", SqlDbType.Text),
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
            parameters[2].Value = model.Wec_Ctn;
            parameters[3].Value = model.plr_status;
            parameters[4].Value = model.plr_status_msg;
            parameters[5].Value = model.CartonNo;
            parameters[6].Value = model.CartonID;
            parameters[7].Value = model.plr_wec_ctn;
            parameters[8].Value = model.plr_po;
            parameters[9].Value = model.plr_partno;
            parameters[10].Value = model.CartonType;
            parameters[11].Value = model.plr_carton_qty;
            parameters[12].Value = model.plr_qty;
            parameters[13].Value = model.plr_suppliers_id;
            parameters[14].Value = model.packingListID;
            parameters[15].Value = model.InvoiceID;
            parameters[16].Value = model.plr_rcp_date;
            parameters[17].Value = model.plr_pallet_no;
            parameters[18].Value = model.plr_deli_date;
            parameters[19].Value = model.plr_site;
            parameters[20].Value = model.plr_co;
            parameters[21].Value = model.plr_date_code;
            parameters[22].Value = model.plr_vend_mfgr;
            parameters[23].Value = model.Plr_vm_partno;
            parameters[24].Value = model.carton_id_prifix;
            parameters[25].Value = model.re_mark;
            parameters[26].Value = model.plr_cre_date;
            parameters[27].Value = model.plr_cre_userid;
            parameters[28].Value = model.plr_update_date;
            parameters[29].Value = model.plr_edituser_id;
            parameters[30].Value = model.plr_user_ip;
            parameters[31].Value = model.plr_void_status;
            parameters[32].Value = model.plr_chr01;
            parameters[33].Value = model.plr_chr02;
            parameters[34].Value = model.plr_deci1;
            parameters[35].Value = model.plr_deci2;

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
        public bool Update(PIE.Model.plr_mstr_tran model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update plr_mstr_tran set ");
            strSql.Append("plr_status=@plr_status,");
            strSql.Append("plr_status_msg=@plr_status_msg,");
            strSql.Append("CartonNo=@CartonNo,");
            strSql.Append("CartonID=@CartonID,");
            strSql.Append("plr_wec_ctn=@plr_wec_ctn,");
            strSql.Append("plr_po=@plr_po,");
            strSql.Append("CartonType=@CartonType,");
            strSql.Append("plr_carton_qty=@plr_carton_qty,");
            strSql.Append("plr_qty=@plr_qty,");
            strSql.Append("plr_suppliers_id=@plr_suppliers_id,");
            strSql.Append("packingListID=@packingListID,");
            strSql.Append("InvoiceID=@InvoiceID,");
            strSql.Append("plr_rcp_date=@plr_rcp_date,");
            strSql.Append("plr_pallet_no=@plr_pallet_no,");
            strSql.Append("plr_deli_date=@plr_deli_date,");
            strSql.Append("plr_site=@plr_site,");
            strSql.Append("plr_co=@plr_co,");
            strSql.Append("plr_date_code=@plr_date_code,");
            strSql.Append("plr_vend_mfgr=@plr_vend_mfgr,");
            strSql.Append("Plr_vm_partno=@Plr_vm_partno,");
            strSql.Append("carton_id_prifix=@carton_id_prifix,");
            strSql.Append("re_mark=@re_mark,");
            strSql.Append("plr_cre_userid=@plr_cre_userid,");
            strSql.Append("plr_update_date=@plr_update_date,");
            strSql.Append("plr_edituser_id=@plr_edituser_id,");
            strSql.Append("plr_user_ip=@plr_user_ip,");
            strSql.Append("plr_void_status=@plr_void_status,");
            strSql.Append("plr_chr01=@plr_chr01,");
            strSql.Append("plr_chr02=@plr_chr02,");
            strSql.Append("plr_deci1=@plr_deci1,");
            strSql.Append("plr_deci2=@plr_deci2");
            strSql.Append(" where Batch_ID=@Batch_ID and plr_partno=@plr_partno and LineID=@LineID and Wec_Ctn=@Wec_Ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@plr_status", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_status_msg", SqlDbType.NVarChar,4000),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_po", SqlDbType.VarChar,30),
					new SqlParameter("@CartonType", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_carton_qty", SqlDbType.Decimal,9),
					new SqlParameter("@plr_qty", SqlDbType.Decimal,9),
					new SqlParameter("@plr_suppliers_id", SqlDbType.NVarChar,50),
					new SqlParameter("@packingListID", SqlDbType.VarChar,30),
					new SqlParameter("@InvoiceID", SqlDbType.VarChar,30),
					new SqlParameter("@plr_rcp_date", SqlDbType.Date,3),
					new SqlParameter("@plr_pallet_no", SqlDbType.NVarChar,10),
					new SqlParameter("@plr_deli_date", SqlDbType.Date,3),
					new SqlParameter("@plr_site", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_co", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_date_code", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_vend_mfgr", SqlDbType.VarChar,30),
					new SqlParameter("@Plr_vm_partno", SqlDbType.VarChar,30),
					new SqlParameter("@carton_id_prifix", SqlDbType.NVarChar,50),
					new SqlParameter("@re_mark", SqlDbType.Text),
					new SqlParameter("@plr_cre_userid", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_update_date", SqlDbType.DateTime),
					new SqlParameter("@plr_edituser_id", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_void_status", SqlDbType.SmallInt,2),
					new SqlParameter("@plr_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_chr02", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_deci1", SqlDbType.Int,4),
					new SqlParameter("@plr_deci2", SqlDbType.Decimal,9),
					new SqlParameter("@Batch_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@LineID", SqlDbType.Int,4),
					new SqlParameter("@Wec_Ctn", SqlDbType.Int,4),
					new SqlParameter("@plr_partno", SqlDbType.VarChar,30),
					new SqlParameter("@plr_cre_date", SqlDbType.DateTime)};
            parameters[0].Value = model.plr_status;
            parameters[1].Value = model.plr_status_msg;
            parameters[2].Value = model.CartonNo;
            parameters[3].Value = model.CartonID;
            parameters[4].Value = model.plr_wec_ctn;
            parameters[5].Value = model.plr_po;
            parameters[6].Value = model.CartonType;
            parameters[7].Value = model.plr_carton_qty;
            parameters[8].Value = model.plr_qty;
            parameters[9].Value = model.plr_suppliers_id;
            parameters[10].Value = model.packingListID;
            parameters[11].Value = model.InvoiceID;
            parameters[12].Value = model.plr_rcp_date;
            parameters[13].Value = model.plr_pallet_no;
            parameters[14].Value = model.plr_deli_date;
            parameters[15].Value = model.plr_site;
            parameters[16].Value = model.plr_co;
            parameters[17].Value = model.plr_date_code;
            parameters[18].Value = model.plr_vend_mfgr;
            parameters[19].Value = model.Plr_vm_partno;
            parameters[20].Value = model.carton_id_prifix;
            parameters[21].Value = model.re_mark;
            parameters[22].Value = model.plr_cre_userid;
            parameters[23].Value = model.plr_update_date;
            parameters[24].Value = model.plr_edituser_id;
            parameters[25].Value = model.plr_user_ip;
            parameters[26].Value = model.plr_void_status;
            parameters[27].Value = model.plr_chr01;
            parameters[28].Value = model.plr_chr02;
            parameters[29].Value = model.plr_deci1;
            parameters[30].Value = model.plr_deci2;
            parameters[31].Value = model.Batch_ID;
            parameters[32].Value = model.LineID;
            parameters[33].Value = model.Wec_Ctn;
            parameters[34].Value = model.plr_partno;
            parameters[35].Value = model.plr_cre_date;

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
        public bool Delete(string Batch_ID, string plr_partno, int LineID, int Wec_Ctn)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from plr_mstr_tran ");
            strSql.Append(" where Batch_ID=@Batch_ID and plr_partno=@plr_partno and LineID=@LineID and Wec_Ctn=@Wec_Ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_partno", SqlDbType.VarChar,30),
					new SqlParameter("@LineID", SqlDbType.Int,4),
					new SqlParameter("@Wec_Ctn", SqlDbType.Int,4)			};
            parameters[0].Value = Batch_ID;
            parameters[1].Value = plr_partno;
            parameters[2].Value = LineID;
            parameters[3].Value = Wec_Ctn;

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
        public PIE.Model.plr_mstr_tran GetModel(string Batch_ID, string plr_partno, int LineID, int Wec_Ctn)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,CartonNo,CartonID,plr_wec_ctn,plr_po,plr_partno,CartonType,plr_carton_qty,plr_qty,plr_suppliers_id,packingListID,InvoiceID,plr_rcp_date,plr_pallet_no,plr_deli_date,plr_site,plr_co,plr_date_code,plr_vend_mfgr,Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2 from plr_mstr_tran ");
            strSql.Append(" where Batch_ID=@Batch_ID and plr_partno=@plr_partno and LineID=@LineID and Wec_Ctn=@Wec_Ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@Batch_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_partno", SqlDbType.VarChar,30),
					new SqlParameter("@LineID", SqlDbType.Int,4),
					new SqlParameter("@Wec_Ctn", SqlDbType.Int,4)			};
            parameters[0].Value = Batch_ID;
            parameters[1].Value = plr_partno;
            parameters[2].Value = LineID;
            parameters[3].Value = Wec_Ctn;

            PIE.Model.plr_mstr_tran model = new PIE.Model.plr_mstr_tran();
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
        public PIE.Model.plr_mstr_tran GetModel(string plr_wec_ctn)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,CartonNo,CartonID,plr_wec_ctn,plr_po,plr_partno,CartonType,plr_carton_qty,plr_qty,plr_suppliers_id,packingListID,InvoiceID,plr_rcp_date,plr_pallet_no,plr_deli_date,plr_site,plr_co,plr_date_code,plr_vend_mfgr,Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2 from plr_mstr_tran ");
            strSql.Append(" where plr_wec_ctn=@plr_wec_ctn ");
            SqlParameter[] parameters = {
					new SqlParameter("@plr_wec_ctn", SqlDbType.NVarChar,50)};
            parameters[0].Value = plr_wec_ctn;

            PIE.Model.plr_mstr_tran model = new PIE.Model.plr_mstr_tran();
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
        public PIE.Model.plr_mstr_tran DataRowToModel(DataRow row)
        {
            PIE.Model.plr_mstr_tran model = new PIE.Model.plr_mstr_tran();
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
                if (row["Wec_Ctn"] != null && row["Wec_Ctn"].ToString() != "")
                {
                    model.Wec_Ctn = int.Parse(row["Wec_Ctn"].ToString());
                }
                if (row["plr_status"] != null)
                {
                    model.plr_status = row["plr_status"].ToString();
                }
                if (row["plr_status_msg"] != null)
                {
                    model.plr_status_msg = row["plr_status_msg"].ToString();
                }
                if (row["CartonNo"] != null)
                {
                    model.CartonNo = row["CartonNo"].ToString();
                }
                if (row["CartonID"] != null)
                {
                    model.CartonID = row["CartonID"].ToString();
                }
                if (row["plr_wec_ctn"] != null)
                {
                    model.plr_wec_ctn = row["plr_wec_ctn"].ToString();
                }
                if (row["plr_po"] != null)
                {
                    model.plr_po = row["plr_po"].ToString();
                }
                if (row["plr_partno"] != null)
                {
                    model.plr_partno = row["plr_partno"].ToString();
                }
                if (row["CartonType"] != null)
                {
                    model.CartonType = row["CartonType"].ToString();
                }
                if (row["plr_carton_qty"] != null && row["plr_carton_qty"].ToString() != "")
                {
                    model.plr_carton_qty = decimal.Parse(row["plr_carton_qty"].ToString());
                }
                if (row["plr_qty"] != null && row["plr_qty"].ToString() != "")
                {
                    model.plr_qty = decimal.Parse(row["plr_qty"].ToString());
                }
                if (row["plr_suppliers_id"] != null)
                {
                    model.plr_suppliers_id = row["plr_suppliers_id"].ToString();
                }
                if (row["packingListID"] != null)
                {
                    model.packingListID = row["packingListID"].ToString();
                }
                if (row["InvoiceID"] != null)
                {
                    model.InvoiceID = row["InvoiceID"].ToString();
                }
                if (row["plr_rcp_date"] != null && row["plr_rcp_date"].ToString() != "")
                {
                    model.plr_rcp_date = DateTime.Parse(row["plr_rcp_date"].ToString());
                }
                if (row["plr_pallet_no"] != null)
                {
                    model.plr_pallet_no = row["plr_pallet_no"].ToString();
                }
                if (row["plr_deli_date"] != null && row["plr_deli_date"].ToString() != "")
                {
                    model.plr_deli_date = DateTime.Parse(row["plr_deli_date"].ToString());
                }
                if (row["plr_site"] != null)
                {
                    model.plr_site = row["plr_site"].ToString();
                }
                if (row["plr_co"] != null)
                {
                    model.plr_co = row["plr_co"].ToString();
                }
                if (row["plr_date_code"] != null)
                {
                    model.plr_date_code = row["plr_date_code"].ToString();
                }
                if (row["plr_vend_mfgr"] != null)
                {
                    model.plr_vend_mfgr = row["plr_vend_mfgr"].ToString();
                }
                if (row["Plr_vm_partno"] != null)
                {
                    model.Plr_vm_partno = row["Plr_vm_partno"].ToString();
                }
                if (row["carton_id_prifix"] != null)
                {
                    model.carton_id_prifix = row["carton_id_prifix"].ToString();
                }
                if (row["re_mark"] != null)
                {
                    model.re_mark = row["re_mark"].ToString();
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
            strSql.Append("select Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,CartonNo,CartonID,plr_wec_ctn,plr_po,plr_partno,CartonType,plr_carton_qty,plr_qty,plr_suppliers_id,packingListID,InvoiceID,plr_rcp_date,plr_pallet_no,plr_deli_date,plr_site,plr_co,plr_date_code,plr_vend_mfgr,Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2 ");
            strSql.Append(" FROM plr_mstr_tran ");
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
            strSql.Append(" Batch_ID,LineID,Wec_Ctn,plr_status,plr_status_msg,CartonNo,CartonID,plr_wec_ctn,plr_po,plr_partno,CartonType,plr_carton_qty,plr_qty,plr_suppliers_id,packingListID,InvoiceID,plr_rcp_date,plr_pallet_no,plr_deli_date,plr_site,plr_co,plr_date_code,plr_vend_mfgr,Plr_vm_partno,carton_id_prifix,re_mark,plr_cre_date,plr_cre_userid,plr_update_date,plr_edituser_id,plr_user_ip,plr_void_status,plr_chr01,plr_chr02,plr_deci1,plr_deci2 ");
            strSql.Append(" FROM plr_mstr_tran ");
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
            strSql.Append("select count(1) FROM plr_mstr_tran ");
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
                strSql.Append("order by T.Wec_Ctn desc");
            }
            strSql.Append(")AS Row, T.*  from plr_mstr_tran T ");
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
            parameters[0].Value = "plr_mstr_tran";
            parameters[1].Value = "Wec_Ctn";
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

