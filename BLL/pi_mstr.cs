using System;
using System.Collections.Generic;
using System.Data;

namespace PI.BLL
{
    /// <summary>
    /// pi_mstr
    /// </summary>
    public partial class pi_mstr
    {
        private readonly PI.DAL.pi_mstr dal = new PI.DAL.pi_mstr();

        public pi_mstr()
        { }

        #region BasicMethod

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
        public bool Exists(string PI_ID, int LineID)
        {
            return dal.Exists(PI_ID, LineID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.pi_mstr model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PI.Model.pi_mstr model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string PI_ID, int LineID)
        {
            return dal.Delete(PI_ID, LineID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PI.Model.pi_mstr GetModel(string PI_ID, int LineID)
        {
            return dal.GetModel(PI_ID, LineID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PI.Model.pi_mstr GetModelByCache(string PI_ID, int LineID)
        {
            string CacheKey = "pi_mstrModel-" + PI_ID + LineID;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(PI_ID, LineID);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PI.Model.pi_mstr)objModel;
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
        public List<PI.Model.pi_mstr> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PI.Model.pi_mstr> DataTableToList(DataTable dt)
        {
            List<PI.Model.pi_mstr> modelList = new List<PI.Model.pi_mstr>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PI.Model.pi_mstr model;
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

        #endregion BasicMethod
    }
}