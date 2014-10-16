using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:vpi_report_palletCount_ext
    /// </summary>
    public partial class vpi_report_palletCount_ext : vpi_report_palletCount
    {
        public vpi_report_palletCount_ext()
        { }
        public int getCount(string strwhere)
        {
            strwhere = "select count(1) from vpi_report_palletCount where " + strwhere;
            var result = DbHelperSQL.GetSingle(strwhere);
            return (int)result;
        }
    }
}

