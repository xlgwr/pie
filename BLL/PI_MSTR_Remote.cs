using System;
using System.Data;
using System.Collections.Generic;
using PIE.Common;
using PI.Model;
namespace PI.BLL
{
    /// <summary>
    /// PI_DET_Remote
    /// </summary>
    public partial class PI_DET_Remote
    {
        private readonly PI.DAL.PI_DET_Remote dal = new PI.DAL.PI_DET_Remote();
        public PI_DET_Remote()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string PI_NO, int PI_LINE)
        {
            return dal.Exists(PI_NO, PI_LINE);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(PI.Model.PI_DET_Remote model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PI.Model.PI_DET_Remote model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int PI_LINE)
        {

            return dal.Delete(PI_LINE);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string PI_NO, int PI_LINE)
        {

            return dal.Delete(PI_NO, PI_LINE);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string PI_LINElist)
        {
            return dal.DeleteList(PIE.Common.PageValidate.SafeLongFilter(PI_LINElist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PI.Model.PI_DET_Remote GetModel(int PI_LINE)
        {

            return dal.GetModel(PI_LINE);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PI.Model.PI_DET_Remote GetModelByCache(int PI_LINE)
        {

            string CacheKey = "PI_DET_RemoteModel-" + PI_LINE;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(PI_LINE);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PI.Model.PI_DET_Remote)objModel;
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
        public List<PI.Model.PI_DET_Remote> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PI.Model.PI_DET_Remote> DataTableToList(DataTable dt)
        {
            List<PI.Model.PI_DET_Remote> modelList = new List<PI.Model.PI_DET_Remote>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PI.Model.PI_DET_Remote model;
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

