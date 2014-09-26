using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:plr_mstr_ext
    /// </summary>
    public partial class plr_mstr_ext : plr_mstr
    {
        public plr_mstr_ext()
        { }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PIE.Model.plr_mstr DataRowToModel(DataRow row, bool carton)
        {
            PIE.Model.plr_mstr model = new PIE.Model.plr_mstr();
            if (row != null)
            {
                if (row["Batch_ID"] != null)
                {
                    model.Batch_ID = row["Batch_ID"].ToString();
                }
                if (row["LineID"] != null && row["LineID"].ToString() != "")
                {
                    model.LineID = int.Parse(row["LineID"].ToString());
                }
                if (row["plr_po"] != null)
                {
                    model.plr_po = row["plr_po"].ToString();
                }
                if (row["plr_doc_type"] != null)
                {
                    model.packingListID = row["plr_doc_type"].ToString();
                }
                if (row["plr_partno"] != null)
                {
                    model.plr_partno = row["plr_partno"].ToString();
                }
                if (row["plr_carton_qty"] != null && row["plr_carton_qty"].ToString() != "")
                {
                    model.plr_carton_qty = decimal.Parse(row["plr_carton_qty"].ToString());
                }
                if (row["plr_qty"] != null && row["plr_qty"].ToString() != "")
                {
                    model.plr_qty = decimal.Parse(row["plr_qty"].ToString());
                }
                if (row["CartonType"] != null)
                {
                    model.CartonType = row["CartonType"].ToString();
                }
                if (row["CartonID"] != null)
                {
                    model.CartonID = row["CartonID"].ToString();
                }

            }
            return model;
        }
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

