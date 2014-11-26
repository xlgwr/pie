using System;
using System.Data;
using System.Collections.Generic;
using PIE.Common;
using PI.Model;
namespace PI.BLL
{
    /// <summary>
    /// codetable
    /// </summary>
    public partial class codetable
    {
        private readonly PI.DAL.codetable dal = new PI.DAL.codetable();
        public codetable()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string gb)
        {
            return dal.Exists(gb);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.codetable model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PI.Model.codetable model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string gb)
        {

            return dal.Delete(gb);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string gblist)
        {
            return dal.DeleteList(PIE.Common.PageValidate.SafeLongFilter(gblist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PI.Model.codetable GetModel(string gb)
        {

            return dal.GetModel(gb);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PI.Model.codetable GetModelByCache(string gb)
        {

            string CacheKey = "codetableModel-" + gb;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(gb);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PI.Model.codetable)objModel;
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
        public List<PI.Model.codetable> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PI.Model.codetable> DataTableToList(DataTable dt)
        {
            List<PI.Model.codetable> modelList = new List<PI.Model.codetable>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PI.Model.codetable model;
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

