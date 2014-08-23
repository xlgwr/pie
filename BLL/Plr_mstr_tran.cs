using System;
using System.Data;
using System.Collections.Generic;
using PIE.Common;
using PIE.Model;
namespace PIE.BLL
{
    /// <summary>
    /// plr_mstr_tran
    /// </summary>
    public partial class plr_mstr_tran
    {
        private readonly PIE.DAL.plr_mstr_tran dal = new PIE.DAL.plr_mstr_tran();
        public plr_mstr_tran()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Batch_ID, string plr_partno, int LineID, int Wec_Ctn)
        {
            return dal.Exists(Batch_ID, plr_partno, LineID, Wec_Ctn);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.plr_mstr_tran model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PIE.Model.plr_mstr_tran model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Batch_ID, string plr_partno, int LineID, int Wec_Ctn)
        {

            return dal.Delete(Batch_ID, plr_partno, LineID, Wec_Ctn);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.plr_mstr_tran GetModel(string Batch_ID, string plr_partno, int LineID, int Wec_Ctn)
        {

            return dal.GetModel(Batch_ID, plr_partno, LineID, Wec_Ctn);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PIE.Model.plr_mstr_tran GetModelByCache(string Batch_ID, string plr_partno, int LineID, int Wec_Ctn)
        {

            string CacheKey = "plr_mstr_tranModel-" + Batch_ID + plr_partno + LineID + Wec_Ctn;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Batch_ID, plr_partno, LineID, Wec_Ctn);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PIE.Model.plr_mstr_tran)objModel;
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
        public List<PIE.Model.plr_mstr_tran> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PIE.Model.plr_mstr_tran> DataTableToList(DataTable dt)
        {
            List<PIE.Model.plr_mstr_tran> modelList = new List<PIE.Model.plr_mstr_tran>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PIE.Model.plr_mstr_tran model;
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

