using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:vpi_report
    /// </summary>
    public partial class vpi_report
    {
        public vpi_report()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_ID, int pi_LineID, string pi_status, string pi_wec_ctn, int plr_LineID_tran, int pi_pallet_no, string CartonNo, string CartonID, string pi_chr01, string CoDesc, string pisr_rir, string pisr_invoice, string pisr_part, string Pisr_receiver, string pisr_site, string pisr_po_nbr, decimal pisr_qty, string pisr_curr, decimal pisr_cost, decimal pisr_base_cost, decimal pisr_us_cost, string pisr_seq, string sq_name, decimal pisr_net_wt, string pisr_rec_type, string pisr_abc, string pisr_code, string pisr_lic_req, string pisr_sbu, string pisr_vend, string Vend_name, string MFGR, string MFGR_Name, string MFGR_Part, decimal pisr_dec01, decimal pisr_dec02, string Pallet_TTL_NW, DateTime pi_cre_date, int GW, string REC_NO, string Contract, string pisr_con_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from vpi_report");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID and pi_status=@pi_status and pi_wec_ctn=@pi_wec_ctn and plr_LineID_tran=@plr_LineID_tran and pi_pallet_no=@pi_pallet_no and CartonNo=@CartonNo and CartonID=@CartonID and pi_chr01=@pi_chr01 and CoDesc=@CoDesc and pisr_rir=@pisr_rir and pisr_invoice=@pisr_invoice and pisr_part=@pisr_part and Pisr_receiver=@Pisr_receiver and pisr_site=@pisr_site and pisr_po_nbr=@pisr_po_nbr and pisr_qty=@pisr_qty and pisr_curr=@pisr_curr and pisr_cost=@pisr_cost and pisr_base_cost=@pisr_base_cost and pisr_us_cost=@pisr_us_cost and pisr_seq=@pisr_seq and sq_name=@sq_name and pisr_net_wt=@pisr_net_wt and pisr_rec_type=@pisr_rec_type and pisr_abc=@pisr_abc and pisr_code=@pisr_code and pisr_lic_req=@pisr_lic_req and pisr_sbu=@pisr_sbu and pisr_vend=@pisr_vend and Vend_name=@Vend_name and MFGR=@MFGR and MFGR_Name=@MFGR_Name and MFGR_Part=@MFGR_Part and pisr_dec01=@pisr_dec01 and pisr_dec02=@pisr_dec02 and Pallet_TTL_NW=@Pallet_TTL_NW and pi_cre_date=@pi_cre_date and GW=@GW and REC_NO=@REC_NO and Contract=@Contract and pisr_con_code=@pisr_con_code ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_status", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@CoDesc", SqlDbType.NVarChar,4000),
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
					new SqlParameter("@sq_name", SqlDbType.NVarChar,100),
					new SqlParameter("@pisr_net_wt", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_rec_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_abc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_lic_req", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_sbu", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_vend", SqlDbType.NVarChar,50),
					new SqlParameter("@Vend_name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Part", SqlDbType.VarChar,30),
					new SqlParameter("@pisr_dec01", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_dec02", SqlDbType.Decimal,9),
					new SqlParameter("@Pallet_TTL_NW", SqlDbType.NVarChar,10),
					new SqlParameter("@pi_cre_date", SqlDbType.DateTime),
					new SqlParameter("@GW", SqlDbType.Int,4),
					new SqlParameter("@REC_NO", SqlDbType.VarChar,1),
					new SqlParameter("@Contract", SqlDbType.VarChar,1),
					new SqlParameter("@pisr_con_code", SqlDbType.NVarChar,50)			};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID;
            parameters[2].Value = pi_status;
            parameters[3].Value = pi_wec_ctn;
            parameters[4].Value = plr_LineID_tran;
            parameters[5].Value = pi_pallet_no;
            parameters[6].Value = CartonNo;
            parameters[7].Value = CartonID;
            parameters[8].Value = pi_chr01;
            parameters[9].Value = CoDesc;
            parameters[10].Value = pisr_rir;
            parameters[11].Value = pisr_invoice;
            parameters[12].Value = pisr_part;
            parameters[13].Value = Pisr_receiver;
            parameters[14].Value = pisr_site;
            parameters[15].Value = pisr_po_nbr;
            parameters[16].Value = pisr_qty;
            parameters[17].Value = pisr_curr;
            parameters[18].Value = pisr_cost;
            parameters[19].Value = pisr_base_cost;
            parameters[20].Value = pisr_us_cost;
            parameters[21].Value = pisr_seq;
            parameters[22].Value = sq_name;
            parameters[23].Value = pisr_net_wt;
            parameters[24].Value = pisr_rec_type;
            parameters[25].Value = pisr_abc;
            parameters[26].Value = pisr_code;
            parameters[27].Value = pisr_lic_req;
            parameters[28].Value = pisr_sbu;
            parameters[29].Value = pisr_vend;
            parameters[30].Value = Vend_name;
            parameters[31].Value = MFGR;
            parameters[32].Value = MFGR_Name;
            parameters[33].Value = MFGR_Part;
            parameters[34].Value = pisr_dec01;
            parameters[35].Value = pisr_dec02;
            parameters[36].Value = Pallet_TTL_NW;
            parameters[37].Value = pi_cre_date;
            parameters[38].Value = GW;
            parameters[39].Value = REC_NO;
            parameters[40].Value = Contract;
            parameters[41].Value = pisr_con_code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.vpi_report model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into vpi_report(");
            strSql.Append("PI_ID,pi_LineID,pi_status,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_chr01,CoDesc,pisr_rir,pisr_invoice,pisr_part,Pisr_receiver,pisr_site,pisr_po_nbr,pisr_qty,pisr_curr,pisr_cost,pisr_base_cost,pisr_us_cost,pisr_seq,sq_name,pisr_net_wt,pisr_rec_type,pisr_abc,pisr_code,pisr_lic_req,pisr_sbu,pisr_vend,Vend_name,MFGR,MFGR_Name,MFGR_Part,pisr_dec01,pisr_dec02,Pallet_TTL_NW,pi_cre_date,GW,REC_NO,Contract,pisr_con_code)");
            strSql.Append(" values (");
            strSql.Append("@PI_ID,@pi_LineID,@pi_status,@pi_wec_ctn,@plr_LineID_tran,@pi_pallet_no,@CartonNo,@CartonID,@pi_chr01,@CoDesc,@pisr_rir,@pisr_invoice,@pisr_part,@Pisr_receiver,@pisr_site,@pisr_po_nbr,@pisr_qty,@pisr_curr,@pisr_cost,@pisr_base_cost,@pisr_us_cost,@pisr_seq,@sq_name,@pisr_net_wt,@pisr_rec_type,@pisr_abc,@pisr_code,@pisr_lic_req,@pisr_sbu,@pisr_vend,@Vend_name,@MFGR,@MFGR_Name,@MFGR_Part,@pisr_dec01,@pisr_dec02,@Pallet_TTL_NW,@pi_cre_date,@GW,@REC_NO,@Contract,@pisr_con_code)");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_status", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@CoDesc", SqlDbType.NVarChar,4000),
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
					new SqlParameter("@sq_name", SqlDbType.NVarChar,100),
					new SqlParameter("@pisr_net_wt", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_rec_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_abc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_lic_req", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_sbu", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_vend", SqlDbType.NVarChar,50),
					new SqlParameter("@Vend_name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Part", SqlDbType.VarChar,30),
					new SqlParameter("@pisr_dec01", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_dec02", SqlDbType.Decimal,9),
					new SqlParameter("@Pallet_TTL_NW", SqlDbType.NVarChar,10),
					new SqlParameter("@pi_cre_date", SqlDbType.DateTime),
					new SqlParameter("@GW", SqlDbType.Int,4),
					new SqlParameter("@REC_NO", SqlDbType.VarChar,1),
					new SqlParameter("@Contract", SqlDbType.VarChar,1),
					new SqlParameter("@pisr_con_code", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.PI_ID;
            parameters[1].Value = model.pi_LineID;
            parameters[2].Value = model.pi_status;
            parameters[3].Value = model.pi_wec_ctn;
            parameters[4].Value = model.plr_LineID_tran;
            parameters[5].Value = model.pi_pallet_no;
            parameters[6].Value = model.CartonNo;
            parameters[7].Value = model.CartonID;
            parameters[8].Value = model.pi_chr01;
            parameters[9].Value = model.CoDesc;
            parameters[10].Value = model.pisr_rir;
            parameters[11].Value = model.pisr_invoice;
            parameters[12].Value = model.pisr_part;
            parameters[13].Value = model.Pisr_receiver;
            parameters[14].Value = model.pisr_site;
            parameters[15].Value = model.pisr_po_nbr;
            parameters[16].Value = model.pisr_qty;
            parameters[17].Value = model.pisr_curr;
            parameters[18].Value = model.pisr_cost;
            parameters[19].Value = model.pisr_base_cost;
            parameters[20].Value = model.pisr_us_cost;
            parameters[21].Value = model.pisr_seq;
            parameters[22].Value = model.sq_name;
            parameters[23].Value = model.pisr_net_wt;
            parameters[24].Value = model.pisr_rec_type;
            parameters[25].Value = model.pisr_abc;
            parameters[26].Value = model.pisr_code;
            parameters[27].Value = model.pisr_lic_req;
            parameters[28].Value = model.pisr_sbu;
            parameters[29].Value = model.pisr_vend;
            parameters[30].Value = model.Vend_name;
            parameters[31].Value = model.MFGR;
            parameters[32].Value = model.MFGR_Name;
            parameters[33].Value = model.MFGR_Part;
            parameters[34].Value = model.pisr_dec01;
            parameters[35].Value = model.pisr_dec02;
            parameters[36].Value = model.Pallet_TTL_NW;
            parameters[37].Value = model.pi_cre_date;
            parameters[38].Value = model.GW;
            parameters[39].Value = model.REC_NO;
            parameters[40].Value = model.Contract;
            parameters[41].Value = model.pisr_con_code;

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
        public bool Update(PIE.Model.vpi_report model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update vpi_report set ");
            strSql.Append("PI_ID=@PI_ID,");
            strSql.Append("pi_LineID=@pi_LineID,");
            strSql.Append("pi_status=@pi_status,");
            strSql.Append("pi_wec_ctn=@pi_wec_ctn,");
            strSql.Append("plr_LineID_tran=@plr_LineID_tran,");
            strSql.Append("pi_pallet_no=@pi_pallet_no,");
            strSql.Append("CartonNo=@CartonNo,");
            strSql.Append("CartonID=@CartonID,");
            strSql.Append("pi_chr01=@pi_chr01,");
            strSql.Append("CoDesc=@CoDesc,");
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
            strSql.Append("sq_name=@sq_name,");
            strSql.Append("pisr_net_wt=@pisr_net_wt,");
            strSql.Append("pisr_rec_type=@pisr_rec_type,");
            strSql.Append("pisr_abc=@pisr_abc,");
            strSql.Append("pisr_code=@pisr_code,");
            strSql.Append("pisr_lic_req=@pisr_lic_req,");
            strSql.Append("pisr_sbu=@pisr_sbu,");
            strSql.Append("pisr_vend=@pisr_vend,");
            strSql.Append("Vend_name=@Vend_name,");
            strSql.Append("MFGR=@MFGR,");
            strSql.Append("MFGR_Name=@MFGR_Name,");
            strSql.Append("MFGR_Part=@MFGR_Part,");
            strSql.Append("pisr_dec01=@pisr_dec01,");
            strSql.Append("pisr_dec02=@pisr_dec02,");
            strSql.Append("Pallet_TTL_NW=@Pallet_TTL_NW,");
            strSql.Append("pi_cre_date=@pi_cre_date,");
            strSql.Append("GW=@GW,");
            strSql.Append("REC_NO=@REC_NO,");
            strSql.Append("Contract=@Contract,");
            strSql.Append("pisr_con_code=@pisr_con_code");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID and pi_status=@pi_status and pi_wec_ctn=@pi_wec_ctn and plr_LineID_tran=@plr_LineID_tran and pi_pallet_no=@pi_pallet_no and CartonNo=@CartonNo and CartonID=@CartonID and pi_chr01=@pi_chr01 and CoDesc=@CoDesc and pisr_rir=@pisr_rir and pisr_invoice=@pisr_invoice and pisr_part=@pisr_part and Pisr_receiver=@Pisr_receiver and pisr_site=@pisr_site and pisr_po_nbr=@pisr_po_nbr and pisr_qty=@pisr_qty and pisr_curr=@pisr_curr and pisr_cost=@pisr_cost and pisr_base_cost=@pisr_base_cost and pisr_us_cost=@pisr_us_cost and pisr_seq=@pisr_seq and sq_name=@sq_name and pisr_net_wt=@pisr_net_wt and pisr_rec_type=@pisr_rec_type and pisr_abc=@pisr_abc and pisr_code=@pisr_code and pisr_lic_req=@pisr_lic_req and pisr_sbu=@pisr_sbu and pisr_vend=@pisr_vend and Vend_name=@Vend_name and MFGR=@MFGR and MFGR_Name=@MFGR_Name and MFGR_Part=@MFGR_Part and pisr_dec01=@pisr_dec01 and pisr_dec02=@pisr_dec02 and Pallet_TTL_NW=@Pallet_TTL_NW and pi_cre_date=@pi_cre_date and GW=@GW and REC_NO=@REC_NO and Contract=@Contract and pisr_con_code=@pisr_con_code ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_status", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@CoDesc", SqlDbType.NVarChar,4000),
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
					new SqlParameter("@sq_name", SqlDbType.NVarChar,100),
					new SqlParameter("@pisr_net_wt", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_rec_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_abc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_lic_req", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_sbu", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_vend", SqlDbType.NVarChar,50),
					new SqlParameter("@Vend_name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Part", SqlDbType.VarChar,30),
					new SqlParameter("@pisr_dec01", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_dec02", SqlDbType.Decimal,9),
					new SqlParameter("@Pallet_TTL_NW", SqlDbType.NVarChar,10),
					new SqlParameter("@pi_cre_date", SqlDbType.DateTime),
					new SqlParameter("@GW", SqlDbType.Int,4),
					new SqlParameter("@REC_NO", SqlDbType.VarChar,1),
					new SqlParameter("@Contract", SqlDbType.VarChar,1),
					new SqlParameter("@pisr_con_code", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.PI_ID;
            parameters[1].Value = model.pi_LineID;
            parameters[2].Value = model.pi_status;
            parameters[3].Value = model.pi_wec_ctn;
            parameters[4].Value = model.plr_LineID_tran;
            parameters[5].Value = model.pi_pallet_no;
            parameters[6].Value = model.CartonNo;
            parameters[7].Value = model.CartonID;
            parameters[8].Value = model.pi_chr01;
            parameters[9].Value = model.CoDesc;
            parameters[10].Value = model.pisr_rir;
            parameters[11].Value = model.pisr_invoice;
            parameters[12].Value = model.pisr_part;
            parameters[13].Value = model.Pisr_receiver;
            parameters[14].Value = model.pisr_site;
            parameters[15].Value = model.pisr_po_nbr;
            parameters[16].Value = model.pisr_qty;
            parameters[17].Value = model.pisr_curr;
            parameters[18].Value = model.pisr_cost;
            parameters[19].Value = model.pisr_base_cost;
            parameters[20].Value = model.pisr_us_cost;
            parameters[21].Value = model.pisr_seq;
            parameters[22].Value = model.sq_name;
            parameters[23].Value = model.pisr_net_wt;
            parameters[24].Value = model.pisr_rec_type;
            parameters[25].Value = model.pisr_abc;
            parameters[26].Value = model.pisr_code;
            parameters[27].Value = model.pisr_lic_req;
            parameters[28].Value = model.pisr_sbu;
            parameters[29].Value = model.pisr_vend;
            parameters[30].Value = model.Vend_name;
            parameters[31].Value = model.MFGR;
            parameters[32].Value = model.MFGR_Name;
            parameters[33].Value = model.MFGR_Part;
            parameters[34].Value = model.pisr_dec01;
            parameters[35].Value = model.pisr_dec02;
            parameters[36].Value = model.Pallet_TTL_NW;
            parameters[37].Value = model.pi_cre_date;
            parameters[38].Value = model.GW;
            parameters[39].Value = model.REC_NO;
            parameters[40].Value = model.Contract;
            parameters[41].Value = model.pisr_con_code;

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
        public bool Delete(string PI_ID, int pi_LineID, string pi_status, string pi_wec_ctn, int plr_LineID_tran, int pi_pallet_no, string CartonNo, string CartonID, string pi_chr01, string CoDesc, string pisr_rir, string pisr_invoice, string pisr_part, string Pisr_receiver, string pisr_site, string pisr_po_nbr, decimal pisr_qty, string pisr_curr, decimal pisr_cost, decimal pisr_base_cost, decimal pisr_us_cost, string pisr_seq, string sq_name, decimal pisr_net_wt, string pisr_rec_type, string pisr_abc, string pisr_code, string pisr_lic_req, string pisr_sbu, string pisr_vend, string Vend_name, string MFGR, string MFGR_Name, string MFGR_Part, decimal pisr_dec01, decimal pisr_dec02, string Pallet_TTL_NW, DateTime pi_cre_date, int GW, string REC_NO, string Contract, string pisr_con_code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from vpi_report ");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID and pi_status=@pi_status and pi_wec_ctn=@pi_wec_ctn and plr_LineID_tran=@plr_LineID_tran and pi_pallet_no=@pi_pallet_no and CartonNo=@CartonNo and CartonID=@CartonID and pi_chr01=@pi_chr01 and CoDesc=@CoDesc and pisr_rir=@pisr_rir and pisr_invoice=@pisr_invoice and pisr_part=@pisr_part and Pisr_receiver=@Pisr_receiver and pisr_site=@pisr_site and pisr_po_nbr=@pisr_po_nbr and pisr_qty=@pisr_qty and pisr_curr=@pisr_curr and pisr_cost=@pisr_cost and pisr_base_cost=@pisr_base_cost and pisr_us_cost=@pisr_us_cost and pisr_seq=@pisr_seq and sq_name=@sq_name and pisr_net_wt=@pisr_net_wt and pisr_rec_type=@pisr_rec_type and pisr_abc=@pisr_abc and pisr_code=@pisr_code and pisr_lic_req=@pisr_lic_req and pisr_sbu=@pisr_sbu and pisr_vend=@pisr_vend and Vend_name=@Vend_name and MFGR=@MFGR and MFGR_Name=@MFGR_Name and MFGR_Part=@MFGR_Part and pisr_dec01=@pisr_dec01 and pisr_dec02=@pisr_dec02 and Pallet_TTL_NW=@Pallet_TTL_NW and pi_cre_date=@pi_cre_date and GW=@GW and REC_NO=@REC_NO and Contract=@Contract and pisr_con_code=@pisr_con_code ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_status", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@CoDesc", SqlDbType.NVarChar,4000),
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
					new SqlParameter("@sq_name", SqlDbType.NVarChar,100),
					new SqlParameter("@pisr_net_wt", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_rec_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_abc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_lic_req", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_sbu", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_vend", SqlDbType.NVarChar,50),
					new SqlParameter("@Vend_name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Part", SqlDbType.VarChar,30),
					new SqlParameter("@pisr_dec01", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_dec02", SqlDbType.Decimal,9),
					new SqlParameter("@Pallet_TTL_NW", SqlDbType.NVarChar,10),
					new SqlParameter("@pi_cre_date", SqlDbType.DateTime),
					new SqlParameter("@GW", SqlDbType.Int,4),
					new SqlParameter("@REC_NO", SqlDbType.VarChar,1),
					new SqlParameter("@Contract", SqlDbType.VarChar,1),
					new SqlParameter("@pisr_con_code", SqlDbType.NVarChar,50)			};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID;
            parameters[2].Value = pi_status;
            parameters[3].Value = pi_wec_ctn;
            parameters[4].Value = plr_LineID_tran;
            parameters[5].Value = pi_pallet_no;
            parameters[6].Value = CartonNo;
            parameters[7].Value = CartonID;
            parameters[8].Value = pi_chr01;
            parameters[9].Value = CoDesc;
            parameters[10].Value = pisr_rir;
            parameters[11].Value = pisr_invoice;
            parameters[12].Value = pisr_part;
            parameters[13].Value = Pisr_receiver;
            parameters[14].Value = pisr_site;
            parameters[15].Value = pisr_po_nbr;
            parameters[16].Value = pisr_qty;
            parameters[17].Value = pisr_curr;
            parameters[18].Value = pisr_cost;
            parameters[19].Value = pisr_base_cost;
            parameters[20].Value = pisr_us_cost;
            parameters[21].Value = pisr_seq;
            parameters[22].Value = sq_name;
            parameters[23].Value = pisr_net_wt;
            parameters[24].Value = pisr_rec_type;
            parameters[25].Value = pisr_abc;
            parameters[26].Value = pisr_code;
            parameters[27].Value = pisr_lic_req;
            parameters[28].Value = pisr_sbu;
            parameters[29].Value = pisr_vend;
            parameters[30].Value = Vend_name;
            parameters[31].Value = MFGR;
            parameters[32].Value = MFGR_Name;
            parameters[33].Value = MFGR_Part;
            parameters[34].Value = pisr_dec01;
            parameters[35].Value = pisr_dec02;
            parameters[36].Value = Pallet_TTL_NW;
            parameters[37].Value = pi_cre_date;
            parameters[38].Value = GW;
            parameters[39].Value = REC_NO;
            parameters[40].Value = Contract;
            parameters[41].Value = pisr_con_code;

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
        public PIE.Model.vpi_report GetModel(string PI_ID, int pi_LineID, string pi_status, string pi_wec_ctn, int plr_LineID_tran, int pi_pallet_no, string CartonNo, string CartonID, string pi_chr01, string CoDesc, string pisr_rir, string pisr_invoice, string pisr_part, string Pisr_receiver, string pisr_site, string pisr_po_nbr, decimal pisr_qty, string pisr_curr, decimal pisr_cost, decimal pisr_base_cost, decimal pisr_us_cost, string pisr_seq, string sq_name, decimal pisr_net_wt, string pisr_rec_type, string pisr_abc, string pisr_code, string pisr_lic_req, string pisr_sbu, string pisr_vend, string Vend_name, string MFGR, string MFGR_Name, string MFGR_Part, decimal pisr_dec01, decimal pisr_dec02, string Pallet_TTL_NW, DateTime pi_cre_date, int GW, string REC_NO, string Contract, string pisr_con_code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 PI_ID,pi_LineID,pi_status,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_chr01,CoDesc,pisr_rir,pisr_invoice,pisr_part,Pisr_receiver,pisr_site,pisr_po_nbr,pisr_qty,pisr_curr,pisr_cost,pisr_base_cost,pisr_us_cost,pisr_seq,sq_name,pisr_net_wt,pisr_rec_type,pisr_abc,pisr_code,pisr_lic_req,pisr_sbu,pisr_vend,Vend_name,MFGR,MFGR_Name,MFGR_Part,pisr_dec01,pisr_dec02,Pallet_TTL_NW,pi_cre_date,GW,REC_NO,Contract,pisr_con_code from vpi_report ");
            strSql.Append(" where PI_ID=@PI_ID and pi_LineID=@pi_LineID and pi_status=@pi_status and pi_wec_ctn=@pi_wec_ctn and plr_LineID_tran=@plr_LineID_tran and pi_pallet_no=@pi_pallet_no and CartonNo=@CartonNo and CartonID=@CartonID and pi_chr01=@pi_chr01 and CoDesc=@CoDesc and pisr_rir=@pisr_rir and pisr_invoice=@pisr_invoice and pisr_part=@pisr_part and Pisr_receiver=@Pisr_receiver and pisr_site=@pisr_site and pisr_po_nbr=@pisr_po_nbr and pisr_qty=@pisr_qty and pisr_curr=@pisr_curr and pisr_cost=@pisr_cost and pisr_base_cost=@pisr_base_cost and pisr_us_cost=@pisr_us_cost and pisr_seq=@pisr_seq and sq_name=@sq_name and pisr_net_wt=@pisr_net_wt and pisr_rec_type=@pisr_rec_type and pisr_abc=@pisr_abc and pisr_code=@pisr_code and pisr_lic_req=@pisr_lic_req and pisr_sbu=@pisr_sbu and pisr_vend=@pisr_vend and Vend_name=@Vend_name and MFGR=@MFGR and MFGR_Name=@MFGR_Name and MFGR_Part=@MFGR_Part and pisr_dec01=@pisr_dec01 and pisr_dec02=@pisr_dec02 and Pallet_TTL_NW=@Pallet_TTL_NW and pi_cre_date=@pi_cre_date and GW=@GW and REC_NO=@REC_NO and Contract=@Contract and pisr_con_code=@pisr_con_code ");
            SqlParameter[] parameters = {
					new SqlParameter("@PI_ID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_LineID", SqlDbType.Int,4),
					new SqlParameter("@pi_status", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_wec_ctn", SqlDbType.NVarChar,50),
					new SqlParameter("@plr_LineID_tran", SqlDbType.Int,4),
					new SqlParameter("@pi_pallet_no", SqlDbType.Int,4),
					new SqlParameter("@CartonNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CartonID", SqlDbType.NVarChar,50),
					new SqlParameter("@pi_chr01", SqlDbType.NVarChar,50),
					new SqlParameter("@CoDesc", SqlDbType.NVarChar,4000),
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
					new SqlParameter("@sq_name", SqlDbType.NVarChar,100),
					new SqlParameter("@pisr_net_wt", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_rec_type", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_abc", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_code", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_lic_req", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_sbu", SqlDbType.NVarChar,50),
					new SqlParameter("@pisr_vend", SqlDbType.NVarChar,50),
					new SqlParameter("@Vend_name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@MFGR_Part", SqlDbType.VarChar,30),
					new SqlParameter("@pisr_dec01", SqlDbType.Decimal,9),
					new SqlParameter("@pisr_dec02", SqlDbType.Decimal,9),
					new SqlParameter("@Pallet_TTL_NW", SqlDbType.NVarChar,10),
					new SqlParameter("@pi_cre_date", SqlDbType.DateTime),
					new SqlParameter("@GW", SqlDbType.Int,4),
					new SqlParameter("@REC_NO", SqlDbType.VarChar,1),
					new SqlParameter("@Contract", SqlDbType.VarChar,1),
					new SqlParameter("@pisr_con_code", SqlDbType.NVarChar,50)			};
            parameters[0].Value = PI_ID;
            parameters[1].Value = pi_LineID;
            parameters[2].Value = pi_status;
            parameters[3].Value = pi_wec_ctn;
            parameters[4].Value = plr_LineID_tran;
            parameters[5].Value = pi_pallet_no;
            parameters[6].Value = CartonNo;
            parameters[7].Value = CartonID;
            parameters[8].Value = pi_chr01;
            parameters[9].Value = CoDesc;
            parameters[10].Value = pisr_rir;
            parameters[11].Value = pisr_invoice;
            parameters[12].Value = pisr_part;
            parameters[13].Value = Pisr_receiver;
            parameters[14].Value = pisr_site;
            parameters[15].Value = pisr_po_nbr;
            parameters[16].Value = pisr_qty;
            parameters[17].Value = pisr_curr;
            parameters[18].Value = pisr_cost;
            parameters[19].Value = pisr_base_cost;
            parameters[20].Value = pisr_us_cost;
            parameters[21].Value = pisr_seq;
            parameters[22].Value = sq_name;
            parameters[23].Value = pisr_net_wt;
            parameters[24].Value = pisr_rec_type;
            parameters[25].Value = pisr_abc;
            parameters[26].Value = pisr_code;
            parameters[27].Value = pisr_lic_req;
            parameters[28].Value = pisr_sbu;
            parameters[29].Value = pisr_vend;
            parameters[30].Value = Vend_name;
            parameters[31].Value = MFGR;
            parameters[32].Value = MFGR_Name;
            parameters[33].Value = MFGR_Part;
            parameters[34].Value = pisr_dec01;
            parameters[35].Value = pisr_dec02;
            parameters[36].Value = Pallet_TTL_NW;
            parameters[37].Value = pi_cre_date;
            parameters[38].Value = GW;
            parameters[39].Value = REC_NO;
            parameters[40].Value = Contract;
            parameters[41].Value = pisr_con_code;

            PIE.Model.vpi_report model = new PIE.Model.vpi_report();
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
        public PIE.Model.vpi_report DataRowToModel(DataRow row)
        {
            PIE.Model.vpi_report model = new PIE.Model.vpi_report();
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
                if (row["pi_status"] != null)
                {
                    model.pi_status = row["pi_status"].ToString();
                }
                if (row["pi_wec_ctn"] != null)
                {
                    model.pi_wec_ctn = row["pi_wec_ctn"].ToString();
                }
                if (row["plr_LineID_tran"] != null && row["plr_LineID_tran"].ToString() != "")
                {
                    model.plr_LineID_tran = int.Parse(row["plr_LineID_tran"].ToString());
                }
                if (row["pi_pallet_no"] != null && row["pi_pallet_no"].ToString() != "")
                {
                    model.pi_pallet_no = int.Parse(row["pi_pallet_no"].ToString());
                }
                if (row["CartonNo"] != null)
                {
                    model.CartonNo = row["CartonNo"].ToString();
                }
                if (row["CartonID"] != null)
                {
                    model.CartonID = row["CartonID"].ToString();
                }
                if (row["pi_chr01"] != null)
                {
                    model.pi_chr01 = row["pi_chr01"].ToString();
                }
                if (row["CoDesc"] != null)
                {
                    model.CoDesc = row["CoDesc"].ToString();
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
                if (row["sq_name"] != null)
                {
                    model.sq_name = row["sq_name"].ToString();
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
                if (row["pisr_sbu"] != null)
                {
                    model.pisr_sbu = row["pisr_sbu"].ToString();
                }
                if (row["pisr_vend"] != null)
                {
                    model.pisr_vend = row["pisr_vend"].ToString();
                }
                if (row["Vend_name"] != null)
                {
                    model.Vend_name = row["Vend_name"].ToString();
                }
                if (row["MFGR"] != null)
                {
                    model.MFGR = row["MFGR"].ToString();
                }
                if (row["MFGR_Name"] != null)
                {
                    model.MFGR_Name = row["MFGR_Name"].ToString();
                }
                if (row["MFGR_Part"] != null)
                {
                    model.MFGR_Part = row["MFGR_Part"].ToString();
                }
                if (row["pisr_dec01"] != null && row["pisr_dec01"].ToString() != "")
                {
                    model.pisr_dec01 = decimal.Parse(row["pisr_dec01"].ToString());
                }
                if (row["pisr_dec02"] != null && row["pisr_dec02"].ToString() != "")
                {
                    model.pisr_dec02 = decimal.Parse(row["pisr_dec02"].ToString());
                }
                if (row["Pallet_TTL_NW"] != null)
                {
                    model.Pallet_TTL_NW = row["Pallet_TTL_NW"].ToString();
                }
                if (row["pi_cre_date"] != null && row["pi_cre_date"].ToString() != "")
                {
                    model.pi_cre_date = DateTime.Parse(row["pi_cre_date"].ToString());
                }
                if (row["GW"] != null && row["GW"].ToString() != "")
                {
                    model.GW = int.Parse(row["GW"].ToString());
                }
                if (row["REC_NO"] != null)
                {
                    model.REC_NO = row["REC_NO"].ToString();
                }
                if (row["Contract"] != null)
                {
                    model.Contract = row["Contract"].ToString();
                }
                if (row["pisr_con_code"] != null)
                {
                    model.pisr_con_code = row["pisr_con_code"].ToString();
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
            strSql.Append("select PI_ID,pi_LineID,pi_status,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_chr01,CoDesc,pisr_rir,pisr_invoice,pisr_part,Pisr_receiver,pisr_site,pisr_po_nbr,pisr_qty,pisr_curr,pisr_cost,pisr_base_cost,pisr_us_cost,pisr_seq,sq_name,pisr_net_wt,pisr_rec_type,pisr_abc,pisr_code,pisr_lic_req,pisr_sbu,pisr_vend,Vend_name,MFGR,MFGR_Name,MFGR_Part,pisr_dec01,pisr_dec02,Pallet_TTL_NW,pi_cre_date,GW,REC_NO,Contract,pisr_con_code ");
            strSql.Append(" FROM vpi_report ");
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
            strSql.Append(" PI_ID,pi_LineID,pi_status,pi_wec_ctn,plr_LineID_tran,pi_pallet_no,CartonNo,CartonID,pi_chr01,CoDesc,pisr_rir,pisr_invoice,pisr_part,Pisr_receiver,pisr_site,pisr_po_nbr,pisr_qty,pisr_curr,pisr_cost,pisr_base_cost,pisr_us_cost,pisr_seq,sq_name,pisr_net_wt,pisr_rec_type,pisr_abc,pisr_code,pisr_lic_req,pisr_sbu,pisr_vend,Vend_name,MFGR,MFGR_Name,MFGR_Part,pisr_dec01,pisr_dec02,Pallet_TTL_NW,pi_cre_date,GW,REC_NO,Contract,pisr_con_code ");
            strSql.Append(" FROM vpi_report ");
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
            strSql.Append("select count(1) FROM vpi_report ");
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
                strSql.Append("order by T.pisr_con_code desc");
            }
            strSql.Append(")AS Row, T.*  from vpi_report T ");
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
            parameters[0].Value = "vpi_report";
            parameters[1].Value = "pisr_con_code";
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

