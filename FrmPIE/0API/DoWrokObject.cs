using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE._0API
{
    class DoWrokObject
    {
        public DataGridView _dgv;
        public DataGridView _dgv1;
        public string _strBatchId;
        public int _selectedindex;
        public int _eX;
        public int _eY;
        public Color _colors;
        public string _sameColumnName;
        public string _deffCellName;
        public string _deffCellValue;
        public Color _deffcolors;

        frmIDR _idr_show;
        public int _maxValue;
        public int _minValue;
        public string _compMaxMin;


        public DoWrokObject(DataGridView dgv, int selectedindex, int eIndex, Color colors, string sameColumnName, string deffCellName, string deffCellValue, Color Deffcolors)
        {
            _dgv = dgv;
            _selectedindex = selectedindex;
            _eX = eIndex;
            _colors = colors;
            _sameColumnName = sameColumnName;
            _deffCellName = deffCellName;
            _deffCellValue = deffCellValue;
            _deffcolors = Deffcolors;

        }
        public DoWrokObject(frmIDR idr_show,DataGridView dgv, int selectedindex, int eIndex, Color colors, string sameColumnName, string deffCellName, string deffCellValue, Color Deffcolors, string compMaxMin)
        {
            _dgv = dgv;
            _selectedindex = selectedindex;
            _eX = eIndex;
            _colors = colors;
            _sameColumnName = sameColumnName;
            _deffCellName = deffCellName;
            _deffCellValue = deffCellValue;
            _deffcolors = Deffcolors;
            _compMaxMin = compMaxMin;
            _idr_show=idr_show;

        }
        public DoWrokObject(DataGridView dgv, DataGridView dgv1, string strBatchId)
        {
            _dgv = dgv;
            _dgv1 = dgv1;
            _strBatchId = strBatchId;

        }
        public DoWrokObject(DataGridView dgv, DataGridView dgv1, int ex, int ey)
        {
            _dgv = dgv;
            _dgv1 = dgv1;
            _eX = ex;
            _eY = ey;

        }
        public DoWrokObject(DataGridView dgv, int ex, int ey)
        {
            _dgv = dgv;
            _eX = ex;
            _eY = ey;

        }
        public DoWrokObject(DataGridView dgv, string strBatchId)
        {
            _dgv = dgv;
            _strBatchId = strBatchId;

        }
    }
}
