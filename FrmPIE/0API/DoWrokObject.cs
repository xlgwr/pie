using FrmPIE;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmIDR._0API
{
    class DoWrokObject
    {
        public DataGridView _dgv;
        public DataGridView _dgv1;
        public frmEnterForReference _FrmForRefe;
        public bool _FrmForRefeHas = false;
        public string _strBatchId;
        public int _selectedindex;
        public int _eX;
        public int _eY;
        public bool _hasLineID;
        public string _voidColumn;

        public Color _colors;
        public string _selectColumnNameValue;
        public string _sameColumnName;
        public string _sameColumnNameCount;
        public string _sameColumnNameCountHeaderText;
        public string _sameColumnNameCountValut;
        public string _deffCellName;
        public string _deffCellValue;
        public string _strCellColName = "Batch_ID";
        public string _FrmForRefeLblMsg;

        public Color _deffcolors;

        frmIDR _idr_show;
        public int _maxValue;
        public int _minValue;
        public string _compMaxMin;
        
        //temp
        public string _cartonidenter;
        public int _fori;


        public DoWrokObject(DataGridView dgv, int selectedindex, int eIndex, Color colors, string sameColumnName, string deffCellName, string deffCellValue, Color Deffcolors)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _selectedindex = selectedindex;
            _eX = eIndex;
            _colors = colors;
            _sameColumnName = sameColumnName;
            _deffCellName = deffCellName;
            _deffCellValue = deffCellValue;
            _deffcolors = Deffcolors;

        }
        public DoWrokObject(frmEnterForReference FrmForRefe, DataGridView dgv, int selectedindex, int eIndex, Color colors, string selectColumnNameValue, string FrmForRefeLblMsg, string sameColumnName, string deffCellName, string deffCellValue, Color Deffcolors)
        {
            _FrmForRefe = FrmForRefe;
            _FrmForRefeLblMsg = FrmForRefeLblMsg;
            _FrmForRefeHas = true;
            _dgv = dgv;
            _selectedindex = selectedindex;
            _eX = eIndex;
            _colors = colors;
            _selectColumnNameValue = selectColumnNameValue;
            _sameColumnName = sameColumnName;
            _deffCellName = deffCellName;
            _deffCellValue = deffCellValue;
            _deffcolors = Deffcolors;

        }
        public DoWrokObject(DataGridView dgv, int selectedindex, int eIndex, Color colors, string sameColumnNameCount, string sameColumnNameCountValut, string sameColumnName, string deffCellName, string deffCellValue, Color Deffcolors)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _selectedindex = selectedindex;
            _eX = eIndex;
            _colors = colors;
            _sameColumnName = sameColumnName;
            _sameColumnNameCount = sameColumnNameCount;
            _sameColumnNameCountHeaderText = dgv.Columns[sameColumnNameCount].HeaderText;
            _sameColumnNameCountValut = sameColumnNameCountValut;
            _deffCellName = deffCellName;
            _deffCellValue = deffCellValue;
            _deffcolors = Deffcolors;

        }
        public DoWrokObject(frmIDR idr_show, DataGridView dgv, int selectedindex, int eIndex, Color colors, string sameColumnNameCount, string sameColumnNameCountValut, string sameColumnName, string deffCellName, string deffCellValue, Color Deffcolors, string compMaxMin)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _selectedindex = selectedindex;
            _eX = eIndex;
            _colors = colors;
            _sameColumnName = sameColumnName;
            _sameColumnNameCount = sameColumnNameCount;
            _sameColumnNameCountHeaderText = dgv.Columns[sameColumnNameCount].HeaderText;
            _sameColumnNameCountValut = sameColumnNameCountValut;
            _deffCellName = deffCellName;
            _deffCellValue = deffCellValue;
            _deffcolors = Deffcolors;
            _compMaxMin = compMaxMin;
            _idr_show = idr_show;

        }
        public DoWrokObject(frmIDR idr_show, DataGridView dgv, int selectedindex, int eIndex, Color colors, string sameColumnName, string deffCellName, string deffCellValue, Color Deffcolors, string compMaxMin)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _selectedindex = selectedindex;
            _eX = eIndex;
            _colors = colors;
            _sameColumnName = sameColumnName;
            _deffCellName = deffCellName;
            _deffCellValue = deffCellValue;
            _deffcolors = Deffcolors;
            _compMaxMin = compMaxMin;
            _idr_show = idr_show;

        }
        public DoWrokObject(DataGridView dgv, DataGridView dgv1, string strBatchId)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _dgv1 = dgv1;
            _strBatchId = strBatchId;

        }
        public DoWrokObject(DataGridView dgv, DataGridView dgv1, int ex, int ey)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _dgv1 = dgv1;
            _eX = ex;
            _eY = ey;

        }
        public DoWrokObject(DataGridView dgv, int ex, int ey)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _eX = ex;
            _eY = ey;

        }
        public DoWrokObject(DataGridView dgv, int ex, int ey, string strCellColName)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _eX = ex;
            _eY = ey;
            _strCellColName = strCellColName;

        }
        public DoWrokObject(DataGridView dgv, int ex, int ey, bool haslineid, string voidColumn)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _eX = ex;
            _eY = ey;
            _hasLineID = haslineid;
            _voidColumn = voidColumn;

        }
        public DoWrokObject(DataGridView dgv, string strBatchId)
        {
            _FrmForRefeHas = false;
            _dgv = dgv;
            _strBatchId = strBatchId;

        }

    }
}
