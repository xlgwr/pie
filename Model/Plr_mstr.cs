using System;
namespace PIE.Model
{
    /// <summary>
    /// plr_mstr:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class plr_mstr
    {
        public plr_mstr()
        { }
        #region Model
        private string _batch_id;
        private int _lineid;
        private string _plr_suppliers_id;
        private string _invoiceid;
        private string _plr_po;
        private string _packinglistid;
        private string _plr_partno;
        private decimal? _plr_carton_qty;
        private decimal? _plr_qty;
        private string _cartontype;
        private string _cartonid;
        private DateTime _plr_rcp_date = DateTime.Now;
        private DateTime _plr_deli_date = DateTime.Now;
        private string _carton_id_prifix;
        private decimal? _carton_id_from;
        private decimal? _carton_id_to;
        private string _re_mark;
        private string _plr_site;
        private string _plr_pallet_no;
        private string _plr_co;
        private string _plr_date_code;
        private string _plr_vend_mfgr;
        private string _plr_vm_partno;
        private string _plr_doc_type;
        private int? _plr_ttl;
        private string _plr_um;
        private string _plr_nw;
        private string _plr_gw;
        private string _plr_um_w;
        private decimal? _plr_unitprice;
        private string _plr_msm;
        private string _plr_doc_no1;
        private string _plr_status;
        private DateTime _plr_cre_date = DateTime.Now;
        private string _plr_cre_userid;
        private DateTime _plr_update_date = DateTime.Now;
        private string _plr_edituser_id;
        private string _plr_user_ip;
        private int? _plr_void_status = 1;
        private string _plr_chr01;
        private string _plr_chr02;
        private int? _plr_deci1;
        private decimal? _plr_deci2;
        /// <summary>
        /// 
        /// </summary>
        public string Batch_ID
        {
            set { _batch_id = value; }
            get { return _batch_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int LineID
        {
            set { _lineid = value; }
            get { return _lineid; }
        }
        /// <summary>
        /// Suppliets ID
        /// </summary>
        public string plr_suppliers_id
        {
            set { _plr_suppliers_id = value; }
            get { return _plr_suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceID
        {
            set { _invoiceid = value; }
            get { return _invoiceid; }
        }
        /// <summary>
        /// PO#
        /// </summary>
        public string plr_po
        {
            set { _plr_po = value; }
            get { return _plr_po; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string packingListID
        {
            set { _packinglistid = value; }
            get { return _packinglistid; }
        }
        /// <summary>
        /// Part
        /// </summary>
        public string plr_partno
        {
            set { _plr_partno = value; }
            get { return _plr_partno; }
        }
        /// <summary>
        /// Carton Qty
        /// </summary>
        public decimal? plr_carton_qty
        {
            set { _plr_carton_qty = value; }
            get { return _plr_carton_qty; }
        }
        /// <summary>
        /// QTY
        /// </summary>
        public decimal? plr_qty
        {
            set { _plr_qty = value; }
            get { return _plr_qty; }
        }
        /// <summary>
        /// Number Carton
        /// </summary>
        public string CartonType
        {
            set { _cartontype = value; }
            get { return _cartontype; }
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
        /// Rec Date
        /// </summary>
        public DateTime plr_rcp_date
        {
            set { _plr_rcp_date = value; }
            get { return _plr_rcp_date; }
        }
        /// <summary>
        /// Deli Date
        /// </summary>
        public DateTime plr_deli_date
        {
            set { _plr_deli_date = value; }
            get { return _plr_deli_date; }
        }
        /// <summary>
        /// Carton Prifix
        /// </summary>
        public string carton_id_prifix
        {
            set { _carton_id_prifix = value; }
            get { return _carton_id_prifix; }
        }
        /// <summary>
        /// Carton ID From
        /// </summary>
        public decimal? carton_id_from
        {
            set { _carton_id_from = value; }
            get { return _carton_id_from; }
        }
        /// <summary>
        /// TO
        /// </summary>
        public decimal? carton_id_to
        {
            set { _carton_id_to = value; }
            get { return _carton_id_to; }
        }
        /// <summary>
        /// ReMark
        /// </summary>
        public string re_mark
        {
            set { _re_mark = value; }
            get { return _re_mark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_site
        {
            set { _plr_site = value; }
            get { return _plr_site; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_pallet_no
        {
            set { _plr_pallet_no = value; }
            get { return _plr_pallet_no; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_co
        {
            set { _plr_co = value; }
            get { return _plr_co; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_date_code
        {
            set { _plr_date_code = value; }
            get { return _plr_date_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_vend_mfgr
        {
            set { _plr_vend_mfgr = value; }
            get { return _plr_vend_mfgr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plr_vm_partno
        {
            set { _plr_vm_partno = value; }
            get { return _plr_vm_partno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_doc_type
        {
            set { _plr_doc_type = value; }
            get { return _plr_doc_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? plr_ttl
        {
            set { _plr_ttl = value; }
            get { return _plr_ttl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_um
        {
            set { _plr_um = value; }
            get { return _plr_um; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_nw
        {
            set { _plr_nw = value; }
            get { return _plr_nw; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_gw
        {
            set { _plr_gw = value; }
            get { return _plr_gw; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_um_w
        {
            set { _plr_um_w = value; }
            get { return _plr_um_w; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Plr_unitprice
        {
            set { _plr_unitprice = value; }
            get { return _plr_unitprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_msm
        {
            set { _plr_msm = value; }
            get { return _plr_msm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_doc_no1
        {
            set { _plr_doc_no1 = value; }
            get { return _plr_doc_no1; }
        }
        /// <summary>
        /// Void Status
        /// </summary>
        public string plr_status
        {
            set { _plr_status = value; }
            get { return _plr_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime plr_cre_date
        {
            set { _plr_cre_date = value; }
            get { return _plr_cre_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_cre_userid
        {
            set { _plr_cre_userid = value; }
            get { return _plr_cre_userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime plr_update_date
        {
            set { _plr_update_date = value; }
            get { return _plr_update_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_edituser_id
        {
            set { _plr_edituser_id = value; }
            get { return _plr_edituser_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_user_ip
        {
            set { _plr_user_ip = value; }
            get { return _plr_user_ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? plr_void_status
        {
            set { _plr_void_status = value; }
            get { return _plr_void_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_chr01
        {
            set { _plr_chr01 = value; }
            get { return _plr_chr01; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plr_chr02
        {
            set { _plr_chr02 = value; }
            get { return _plr_chr02; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? plr_deci1
        {
            set { _plr_deci1 = value; }
            get { return _plr_deci1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? plr_deci2
        {
            set { _plr_deci2 = value; }
            get { return _plr_deci2; }
        }
        #endregion Model

    }
}

