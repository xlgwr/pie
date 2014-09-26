using System.Collections.Generic;
using System.Data;

namespace PI.BLL
{
    /// <summary>
    /// pi_det_ext
    /// </summary>
    public partial class pi_det_ext : pi_det
    {
        private readonly PI.DAL.pi_det_ext dal = new PI.DAL.pi_det_ext();

        public pi_det_ext()
        { }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PI.Model.pi_det> GetModelList(string strWhere, bool distinct)
        {
            DataSet ds = dal.GetList(strWhere, distinct);
            return DataTableToList(ds.Tables[0], distinct);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<PI.Model.pi_det> DataTableToList(DataTable dt, bool distinct)
        {
            List<PI.Model.pi_det> modelList = new List<PI.Model.pi_det>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                PI.Model.pi_det model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n], distinct);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }
    }
}