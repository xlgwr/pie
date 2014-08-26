using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FrmPIE._0API
{
    class CartonFromTo
    {

        public decimal _wec_ctn_Fr;
        public decimal _wec_ctn_To;
        public string _print_Type;
        public string _print_port;

        public int _dgvNumber;
        public string _batchID;
        public int _lineID;

        public DataGridView _dgv;
        public string _dotype;
        public string _cartonID;
        public string _userid;
        public string _userip;

        public CartonFromTo(decimal wec_ctn_fr, decimal wec_ctn_to, string print_type, int dgvIndex, string batchid, int lineid, string cartonid)
        {
            // TODO: Complete member initialization
            _wec_ctn_Fr = wec_ctn_fr;
            _wec_ctn_To = wec_ctn_to;
            _print_Type = print_type;
            _dgvNumber = dgvIndex;
            _batchID = batchid;
            _lineID = lineid;
            _cartonID = cartonid;
        }
        public CartonFromTo(decimal wec_ctn_fr, decimal wec_ctn_to, string print_type, string print_port)
        {
            // TODO: Complete member initialization
            _wec_ctn_Fr = wec_ctn_fr;
            _wec_ctn_To = wec_ctn_to;
            _print_Type = print_type;
            _print_port = print_port;
        }
        public CartonFromTo(DataGridView dgv, string batchid, string dotype, string userid, string userip, int lineid)
        {
            // TODO: Complete member initialization
            _dgv = dgv;
            _batchID = batchid;
            _lineID = lineid;
            _dotype = dotype;
            _userid = userid;
            _userip = userip;
        }
        public CartonFromTo(DataGridView dgv, string batchid, string dotype, string userid, string userip, string cartonid)
        {
            // TODO: Complete member initialization
            _dgv = dgv;
            _batchID = batchid;
            _cartonID = cartonid;
            _dotype = dotype;
            _userid = userid;
            _userip = userip;
        }
    }
}
