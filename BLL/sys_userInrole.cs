using System;
using System.Data;
using System.Collections.Generic;
using PIE.Common;
using PIE.Model;
namespace PIE.BLL
{
    /// <summary>
    /// sys_userInrole
    /// </summary>
    public partial class sys_userInrole
    {
        private readonly PIE.DAL.sys_userInrole dal = new PIE.DAL.sys_userInrole();
        public sys_userInrole()
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
        public bool Exists(string user_name, int role_id)
        {
            return dal.Exists(user_name, role_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(PIE.Model.sys_userInrole model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(PIE.Model.sys_userInrole model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string user_name, int role_id)
        {

            return dal.Delete(user_name, role_id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.sys_userInrole GetModel(string user_name, int role_id)
        {

            return dal.GetModel(user_name, role_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public PIE.Model.sys_userInrole GetModelByCache(string user_name, int role_id)
        {

            string CacheKey = "sys_userInroleModel-" + user_name + role_id;
            object objModel = PIE.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(user_name, role_id);
                    if (objModel != null)
                    {
                        int ModelCache = PIE.Common.ConfigHelper.GetConfigInt("ModelCache");
                        PIE.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (PIE.Model.sys_userInrole)objModel;
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
        public List<PIE.Model.sys_userInrole> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PIE.Model.sys_userInrole> DataTableToList(DataTable dt)
        {
            List<PIE.Model.sys_userInrole> modelList = new List<PIE.Model.sys_userInrole>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PIE.Model.sys_userInrole model;
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

