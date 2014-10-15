using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using PIE.DBUtility;//Please add references
namespace PIE.DAL
{
    /// <summary>
    /// 数据访问类:vpi_report_ext
    /// </summary>
    public partial class vpi_report_ext : vpi_report
    {
        public vpi_report_ext()
        { }
        public int getCount(string strwhere)
        {
            strwhere = "select count(1) from vpi_report where "+strwhere;
            var result = DbHelperSQL.GetSingle(strwhere);
            return (int)result;
        }
    }
}

