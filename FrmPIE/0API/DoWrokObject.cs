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
        public int _selectedindex;
        public int _eIndex;
        public Color _colors;
        public string _sameColumnName;
        public string _deffCellName;
        public string _deffCellValue;
        public Color _deffcolors;
        public DoWrokObject(DataGridView dgv, int selectedindex, int eIndex, Color colors, string sameColumnName, string deffCellName, string deffCellValue, Color Deffcolors)
        {
            _dgv = dgv;
            _selectedindex = selectedindex;
            _eIndex = eIndex;
            _colors = colors;
            _sameColumnName = sameColumnName;
            _deffCellName = deffCellName;
            _deffCellValue = deffCellValue;
            _deffcolors = Deffcolors;

        }
    }
}
