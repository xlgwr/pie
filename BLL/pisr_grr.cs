using System;
using System.Data;
using System.Collections.Generic;
using PIE.Common;
using PI.Model;
namespace PI.BLL
{
    /// <summary>
    /// pisr_grr
    /// </summary>
    public partial class pisr_grr
    {
        private readonly PI.DAL.pisr_grr dal = new PI.DAL.pisr_grr();
        public pisr_grr()
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
        public bool Exists(string pi_wec_ctn, int plr_LineID_tran)
        {
            return dal.Exists(pi_wec_ctn, plr_LineID_tran);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PI.Model.pisr_grr model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PI.Model.pisr_grr model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string pi_wec_ctn, int plr_LineID_tran)
        {

            return dal.Delete(pi_wec_ctn, plr_LineID_tran);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PI.Model.pisr_grr GetModel(string pi_wec_ctn, int plr_LineID_tran)
        {

            return dal.GetModel(pi_wec_ctn, plr_LineID_tran);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PI.Model.pisr_grr GetModelByCache(string pi_wec_ctn, int plr_LineID_tran)
        {

            string CacheKey = "pisr_grrModel-" + pi_wec_ctn + plr_LineID_tran;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(pi_wec_ctn, plr_LineID_tran);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PI.Model.pisr_grr)objModel;
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
        public List<PI.Model.pisr_grr> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PI.Model.pisr_grr> DataTableToList(DataTable dt)
        {
            List<PI.Model.pisr_grr> modelList = new List<PI.Model.pisr_grr>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PI.Model.pisr_grr model;
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

