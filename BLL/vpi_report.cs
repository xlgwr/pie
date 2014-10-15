using System;
using System.Data;
using System.Collections.Generic;
using PIE.Common;
using PIE.Model;
namespace PIE.BLL
{
    /// <summary>
    /// vpi_report
    /// </summary>
    public partial class vpi_report
    {
        private readonly PIE.DAL.vpi_report dal = new PIE.DAL.vpi_report();
        public vpi_report()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_ID, int pi_LineID, string pi_status, string pi_wec_ctn, int plr_LineID_tran, int pi_pallet_no, string CartonNo, string CartonID, string pi_chr01, string CoDesc, string pisr_rir, string pisr_invoice, string pisr_part, string Pisr_receiver, string pisr_site, string pisr_po_nbr, decimal pisr_qty, string pisr_curr, decimal pisr_cost, decimal pisr_base_cost, decimal pisr_us_cost, string pisr_seq, string sq_name, decimal pisr_net_wt, string pisr_rec_type, string pisr_abc, string pisr_code, string pisr_lic_req, string pisr_sbu, string pisr_vend, string Vend_name, string MFGR, string MFGR_Name, string MFGR_Part, decimal pisr_dec01, decimal pisr_dec02, string Pallet_TTL_NW, DateTime pi_cre_date, int GW, string REC_NO, string Contract, string pisr_con_code)
        {
            return dal.Exists(PI_ID, pi_LineID, pi_status, pi_wec_ctn, plr_LineID_tran, pi_pallet_no, CartonNo, CartonID, pi_chr01, CoDesc, pisr_rir, pisr_invoice, pisr_part, Pisr_receiver, pisr_site, pisr_po_nbr, pisr_qty, pisr_curr, pisr_cost, pisr_base_cost, pisr_us_cost, pisr_seq, sq_name, pisr_net_wt, pisr_rec_type, pisr_abc, pisr_code, pisr_lic_req, pisr_sbu, pisr_vend, Vend_name, MFGR, MFGR_Name, MFGR_Part, pisr_dec01, pisr_dec02, Pallet_TTL_NW, pi_cre_date, GW, REC_NO, Contract, pisr_con_code);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.vpi_report model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PIE.Model.vpi_report model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string PI_ID, int pi_LineID, string pi_status, string pi_wec_ctn, int plr_LineID_tran, int pi_pallet_no, string CartonNo, string CartonID, string pi_chr01, string CoDesc, string pisr_rir, string pisr_invoice, string pisr_part, string Pisr_receiver, string pisr_site, string pisr_po_nbr, decimal pisr_qty, string pisr_curr, decimal pisr_cost, decimal pisr_base_cost, decimal pisr_us_cost, string pisr_seq, string sq_name, decimal pisr_net_wt, string pisr_rec_type, string pisr_abc, string pisr_code, string pisr_lic_req, string pisr_sbu, string pisr_vend, string Vend_name, string MFGR, string MFGR_Name, string MFGR_Part, decimal pisr_dec01, decimal pisr_dec02, string Pallet_TTL_NW, DateTime pi_cre_date, int GW, string REC_NO, string Contract, string pisr_con_code)
        {

            return dal.Delete(PI_ID, pi_LineID, pi_status, pi_wec_ctn, plr_LineID_tran, pi_pallet_no, CartonNo, CartonID, pi_chr01, CoDesc, pisr_rir, pisr_invoice, pisr_part, Pisr_receiver, pisr_site, pisr_po_nbr, pisr_qty, pisr_curr, pisr_cost, pisr_base_cost, pisr_us_cost, pisr_seq, sq_name, pisr_net_wt, pisr_rec_type, pisr_abc, pisr_code, pisr_lic_req, pisr_sbu, pisr_vend, Vend_name, MFGR, MFGR_Name, MFGR_Part, pisr_dec01, pisr_dec02, Pallet_TTL_NW, pi_cre_date, GW, REC_NO, Contract, pisr_con_code);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.vpi_report GetModel(string PI_ID, int pi_LineID, string pi_status, string pi_wec_ctn, int plr_LineID_tran, int pi_pallet_no, string CartonNo, string CartonID, string pi_chr01, string CoDesc, string pisr_rir, string pisr_invoice, string pisr_part, string Pisr_receiver, string pisr_site, string pisr_po_nbr, decimal pisr_qty, string pisr_curr, decimal pisr_cost, decimal pisr_base_cost, decimal pisr_us_cost, string pisr_seq, string sq_name, decimal pisr_net_wt, string pisr_rec_type, string pisr_abc, string pisr_code, string pisr_lic_req, string pisr_sbu, string pisr_vend, string Vend_name, string MFGR, string MFGR_Name, string MFGR_Part, decimal pisr_dec01, decimal pisr_dec02, string Pallet_TTL_NW, DateTime pi_cre_date, int GW, string REC_NO, string Contract, string pisr_con_code)
        {

            return dal.GetModel(PI_ID, pi_LineID, pi_status, pi_wec_ctn, plr_LineID_tran, pi_pallet_no, CartonNo, CartonID, pi_chr01, CoDesc, pisr_rir, pisr_invoice, pisr_part, Pisr_receiver, pisr_site, pisr_po_nbr, pisr_qty, pisr_curr, pisr_cost, pisr_base_cost, pisr_us_cost, pisr_seq, sq_name, pisr_net_wt, pisr_rec_type, pisr_abc, pisr_code, pisr_lic_req, pisr_sbu, pisr_vend, Vend_name, MFGR, MFGR_Name, MFGR_Part, pisr_dec01, pisr_dec02, Pallet_TTL_NW, pi_cre_date, GW, REC_NO, Contract, pisr_con_code);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PIE.Model.vpi_report GetModelByCache(string PI_ID, int pi_LineID, string pi_status, string pi_wec_ctn, int plr_LineID_tran, int pi_pallet_no, string CartonNo, string CartonID, string pi_chr01, string CoDesc, string pisr_rir, string pisr_invoice, string pisr_part, string Pisr_receiver, string pisr_site, string pisr_po_nbr, decimal pisr_qty, string pisr_curr, decimal pisr_cost, decimal pisr_base_cost, decimal pisr_us_cost, string pisr_seq, string sq_name, decimal pisr_net_wt, string pisr_rec_type, string pisr_abc, string pisr_code, string pisr_lic_req, string pisr_sbu, string pisr_vend, string Vend_name, string MFGR, string MFGR_Name, string MFGR_Part, decimal pisr_dec01, decimal pisr_dec02, string Pallet_TTL_NW, DateTime pi_cre_date, int GW, string REC_NO, string Contract, string pisr_con_code)
        {

            string CacheKey = "vpi_reportModel-" + PI_ID + pi_LineID + pi_status + pi_wec_ctn + plr_LineID_tran + pi_pallet_no + CartonNo + CartonID + pi_chr01 + CoDesc + pisr_rir + pisr_invoice + pisr_part + Pisr_receiver + pisr_site + pisr_po_nbr + pisr_qty + pisr_curr + pisr_cost + pisr_base_cost + pisr_us_cost + pisr_seq + sq_name + pisr_net_wt + pisr_rec_type + pisr_abc + pisr_code + pisr_lic_req + pisr_sbu + pisr_vend + Vend_name + MFGR + MFGR_Name + MFGR_Part + pisr_dec01 + pisr_dec02 + Pallet_TTL_NW + pi_cre_date + GW + REC_NO + Contract + pisr_con_code;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(PI_ID, pi_LineID, pi_status, pi_wec_ctn, plr_LineID_tran, pi_pallet_no, CartonNo, CartonID, pi_chr01, CoDesc, pisr_rir, pisr_invoice, pisr_part, Pisr_receiver, pisr_site, pisr_po_nbr, pisr_qty, pisr_curr, pisr_cost, pisr_base_cost, pisr_us_cost, pisr_seq, sq_name, pisr_net_wt, pisr_rec_type, pisr_abc, pisr_code, pisr_lic_req, pisr_sbu, pisr_vend, Vend_name, MFGR, MFGR_Name, MFGR_Part, pisr_dec01, pisr_dec02, Pallet_TTL_NW, pi_cre_date, GW, REC_NO, Contract, pisr_con_code);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PIE.Model.vpi_report)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PIE.Model.vpi_report> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PIE.Model.vpi_report> DataTableToList(DataTable dt)
        {
            List<PIE.Model.vpi_report> modelList = new List<PIE.Model.vpi_report>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PIE.Model.vpi_report model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

