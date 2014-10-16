using System;
using System.Data;
using System.Collections.Generic;
using PIE.Common;
using PIE.Model;
namespace PIE.BLL
{
    /// <summary>
    /// vpi_report_palletCount
    /// </summary>
    public partial class vpi_report_palletCount
    {
        private readonly PIE.DAL.vpi_report_palletCount dal = new PIE.DAL.vpi_report_palletCount();
        public vpi_report_palletCount()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_NO, int pi_pallet_no, int TTL, string PI_CARTON_NO, string PI_DESC, decimal PI_GW, string use_char01, string use_char02, int use_dec01)
        {
            return dal.Exists(PI_NO, pi_pallet_no, TTL, PI_CARTON_NO, PI_DESC, PI_GW, use_char01, use_char02, use_dec01);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.vpi_report_palletCount model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PIE.Model.vpi_report_palletCount model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string PI_NO, int pi_pallet_no, int TTL, string PI_CARTON_NO, string PI_DESC, decimal PI_GW, string use_char01, string use_char02, int use_dec01)
        {

            return dal.Delete(PI_NO, pi_pallet_no, TTL, PI_CARTON_NO, PI_DESC, PI_GW, use_char01, use_char02, use_dec01);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.vpi_report_palletCount GetModel(string PI_NO, int pi_pallet_no, int TTL, string PI_CARTON_NO, string PI_DESC, decimal PI_GW, string use_char01, string use_char02, int use_dec01)
        {

            return dal.GetModel(PI_NO, pi_pallet_no, TTL, PI_CARTON_NO, PI_DESC, PI_GW, use_char01, use_char02, use_dec01);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PIE.Model.vpi_report_palletCount GetModelByCache(string PI_NO, int pi_pallet_no, int TTL, string PI_CARTON_NO, string PI_DESC, decimal PI_GW, string use_char01, string use_char02, int use_dec01)
        {

            string CacheKey = "vpi_report_palletCountModel-" + PI_NO + pi_pallet_no + TTL + PI_CARTON_NO + PI_DESC + PI_GW + use_char01 + use_char02 + use_dec01;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(PI_NO, pi_pallet_no, TTL, PI_CARTON_NO, PI_DESC, PI_GW, use_char01, use_char02, use_dec01);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PIE.Model.vpi_report_palletCount)objModel;
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
        public List<PIE.Model.vpi_report_palletCount> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PIE.Model.vpi_report_palletCount> DataTableToList(DataTable dt)
        {
            List<PIE.Model.vpi_report_palletCount> modelList = new List<PIE.Model.vpi_report_palletCount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PIE.Model.vpi_report_palletCount model;
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

