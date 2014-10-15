using System;
namespace PIE.Model
{
    /// <summary>
    /// vpi_report:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class vpi_report
    {
        public vpi_report()
        { }
        #region Model
        private string _pi_id;
        private int _pi_lineid;
        private string _pi_status;
        private string _pi_wec_ctn;
        private int _plr_lineid_tran;
        private int? _pi_pallet_no;
        private string _cartonno;
        private string _cartonid;
        private string _pi_chr01;
        private string _codesc;
        private string _pisr_rir;
        private string _pisr_invoice;
        private string _pisr_part;
        private string _pisr_receiver;
        private string _pisr_site;
        private string _pisr_po_nbr;
        private decimal? _pisr_qty;
        private string _pisr_curr;
        private decimal? _pisr_cost;
        private decimal? _pisr_base_cost;
        private decimal? _pisr_us_cost;
        private string _pisr_seq;
        private string _sq_name;
        private decimal? _pisr_net_wt;
        private string _pisr_rec_type;
        private string _pisr_abc;
        private string _pisr_code;
        private string _pisr_lic_req;
        private string _pisr_sbu;
        private string _pisr_vend;
        private string _vend_name;
        private string _mfgr;
        private string _mfgr_name;
        private string _mfgr_part;
        private decimal? _pisr_dec01;
        private decimal? _pisr_dec02;
        private string _pallet_ttl_nw;
        private DateTime? _pi_cre_date;
        private int _gw;
        private string _rec_no;
        private string _contract;
        private string _pisr_con_code;
        /// <summary>
        /// 
        /// </summary>
        public string PI_ID
        {
            set { _pi_id = value; }
            get { return _pi_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int pi_LineID
        {
            set { _pi_lineid = value; }
            get { return _pi_lineid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_status
        {
            set { _pi_status = value; }
            get { return _pi_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_wec_ctn
        {
            set { _pi_wec_ctn = value; }
            get { return _pi_wec_ctn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int plr_LineID_tran
        {
            set { _plr_lineid_tran = value; }
            get { return _plr_lineid_tran; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? pi_pallet_no
        {
            set { _pi_pallet_no = value; }
            get { return _pi_pallet_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartonNo
        {
            set { _cartonno = value; }
            get { return _cartonno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CartonID
        {
            set { _cartonid = value; }
            get { return _cartonid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pi_chr01
        {
            set { _pi_chr01 = value; }
            get { return _pi_chr01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CoDesc
        {
            set { _codesc = value; }
            get { return _codesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_rir
        {
            set { _pisr_rir = value; }
            get { return _pisr_rir; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_invoice
        {
            set { _pisr_invoice = value; }
            get { return _pisr_invoice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_part
        {
            set { _pisr_part = value; }
            get { return _pisr_part; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pisr_receiver
        {
            set { _pisr_receiver = value; }
            get { return _pisr_receiver; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_site
        {
            set { _pisr_site = value; }
            get { return _pisr_site; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_po_nbr
        {
            set { _pisr_po_nbr = value; }
            get { return _pisr_po_nbr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_qty
        {
            set { _pisr_qty = value; }
            get { return _pisr_qty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_curr
        {
            set { _pisr_curr = value; }
            get { return _pisr_curr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_cost
        {
            set { _pisr_cost = value; }
            get { return _pisr_cost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_base_cost
        {
            set { _pisr_base_cost = value; }
            get { return _pisr_base_cost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_us_cost
        {
            set { _pisr_us_cost = value; }
            get { return _pisr_us_cost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_seq
        {
            set { _pisr_seq = value; }
            get { return _pisr_seq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sq_name
        {
            set { _sq_name = value; }
            get { return _sq_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_net_wt
        {
            set { _pisr_net_wt = value; }
            get { return _pisr_net_wt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_rec_type
        {
            set { _pisr_rec_type = value; }
            get { return _pisr_rec_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_abc
        {
            set { _pisr_abc = value; }
            get { return _pisr_abc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_code
        {
            set { _pisr_code = value; }
            get { return _pisr_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_lic_req
        {
            set { _pisr_lic_req = value; }
            get { return _pisr_lic_req; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_sbu
        {
            set { _pisr_sbu = value; }
            get { return _pisr_sbu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_vend
        {
            set { _pisr_vend = value; }
            get { return _pisr_vend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Vend_name
        {
            set { _vend_name = value; }
            get { return _vend_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MFGR
        {
            set { _mfgr = value; }
            get { return _mfgr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MFGR_Name
        {
            set { _mfgr_name = value; }
            get { return _mfgr_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MFGR_Part
        {
            set { _mfgr_part = value; }
            get { return _mfgr_part; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_dec01
        {
            set { _pisr_dec01 = value; }
            get { return _pisr_dec01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? pisr_dec02
        {
            set { _pisr_dec02 = value; }
            get { return _pisr_dec02; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pallet_TTL_NW
        {
            set { _pallet_ttl_nw = value; }
            get { return _pallet_ttl_nw; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? pi_cre_date
        {
            set { _pi_cre_date = value; }
            get { return _pi_cre_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int GW
        {
            set { _gw = value; }
            get { return _gw; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REC_NO
        {
            set { _rec_no = value; }
            get { return _rec_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Contract
        {
            set { _contract = value; }
            get { return _contract; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pisr_con_code
        {
            set { _pisr_con_code = value; }
            get { return _pisr_con_code; }
        }
        #endregion Model

    }
}

