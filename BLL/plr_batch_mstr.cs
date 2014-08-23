using System;
using System.Data;
using System.Collections.Generic;
using PIE.Common;
using PIE.Model;
namespace PIE.BLL
{
    /// <summary>
    /// plr_batch_mstr
    /// </summary>
    public partial class plr_batch_mstr
    {
        private readonly PIE.DAL.plr_batch_mstr dal = new PIE.DAL.plr_batch_mstr();
        public plr_batch_mstr()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string batch_id)
        {
            return dal.Exists(batch_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.plr_batch_mstr model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PIE.Model.plr_batch_mstr model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string batch_id)
        {

            return dal.Delete(batch_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string batch_idlist)
        {
            return dal.DeleteList(batch_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.plr_batch_mstr GetModel(string batch_id)
        {

            return dal.GetModel(batch_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PIE.Model.plr_batch_mstr GetModelByCache(string batch_id)
        {

            string CacheKey = "plr_batch_mstrModel-" + batch_id;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(batch_id);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PIE.Model.plr_batch_mstr)objModel;
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
        public List<PIE.Model.plr_batch_mstr> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PIE.Model.plr_batch_mstr> DataTableToList(DataTable dt)
        {
            List<PIE.Model.plr_batch_mstr> modelList = new List<PIE.Model.plr_batch_mstr>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PIE.Model.plr_batch_mstr model;
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

