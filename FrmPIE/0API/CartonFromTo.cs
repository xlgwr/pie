using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FrmPIE._0API
{
    class CartonFromTo
    {

        public decimal _wec_ctn_Fr;
        public decimal _wec_ctn_To;
        public string _print_Type;
        public string _print_port;
        public object _objclass;

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
        public CartonFromTo(object obj,decimal wec_ctn_fr, decimal wec_ctn_to, string print_type, string print_port)
        {
            // TODO: Complete member initialization
            _objclass = obj;
            _wec_ctn_Fr = wec_ctn_fr;
            _wec_ctn_To = wec_ctn_to;
            _print_Type = print_type;
            _print_port = print_port;
        }
        public CartonFromTo(DataGridView dgv, string batchid, int lineid, string dotype, string userid, string userip)
        {
            // TODO: Complete member initialization
            _dgv = dgv;
            _batchID = batchid;
            _lineID = lineid;
            _dotype = dotype;
            _userid = userid;
            _userip = userip;
        }
        public CartonFromTo(DataGridView dgv, string batchid, string cartonid, string dotype, string userid, string userip)
        {
            // TODO: Complete member initialization
            _dgv = dgv;
            _batchID = batchid;
            _cartonID = cartonid;
            _dotype = dotype;
            _userid = userid;
            _userip = userip;
        }


        public static string[] initCartonFromTo(string CartonId, string CartonType, out string carprefix)
        {
            Regex RegPrefix = new Regex(@"[a-zA-Z\.,@?^=%&amp;:/~\+#]+");
            var iPos = CartonId.IndexOf('-');
            var strCtnId = CartonId;

            string[] strCtnIdArr = new string[2];

            Match m = RegPrefix.Match(strCtnId);
            if (m.Success)
            {
                carprefix = m.Value;

            }
            else
            {
                carprefix = "";
            }
            if (!string.IsNullOrEmpty(carprefix))
            {

                strCtnId = strCtnId.Replace(carprefix, " ");
            }
            if (iPos > 0)
            {
                strCtnIdArr = strCtnId.Split('-');
                if (string.IsNullOrEmpty(strCtnIdArr[0]))
                {
                    strCtnIdArr[0] = "0";
                }
                if (string.IsNullOrEmpty(strCtnIdArr[1]))
                {
                    strCtnIdArr[0] = "0";
                }
            }
            else
            {


                strCtnIdArr[0] = strCtnId;
                strCtnIdArr[1] = strCtnId;
            }

            return strCtnIdArr;
        }
    }
}
