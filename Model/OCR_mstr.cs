using System;

namespace PIE.Model
{
    /// <summary>
    /// OCR_mstr:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class OCR_mstr
    {
        public OCR_mstr()
        { }

        #region Model

        private string _ocr_batchid;
        private string _ocr_packinglistid;
        private string _ocr_vend;
        private string _ocr_doc_no;
        private DateTime? _ocr_rcp_date;
        private string _ocr_lineid;
        private string _ocr_ctnid;
        private string _ocr_partno;
        private string _ocr_po;
        private string _ocr_custpart;
        private string _ocr_qty;
        private string _ocr_nw;
        private string _ocr_gw;
        private string _ocr_ref_no;
        private string _ocr_ref_no1;
        private int? _ocr_ttl;
        private decimal? _ocr_unitprice;
        private string _ocr_status;
        private DateTime? _ocr_cre_date;
        private string _ocr_cre_user;

        /// <summary>
        ///
        /// </summary>
        public string Ocr_BatchID
        {
            set { _ocr_batchid = value; }
            get { return _ocr_batchid; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_PackinglistID
        {
            set { _ocr_packinglistid = value; }
            get { return _ocr_packinglistid; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_vend
        {
            set { _ocr_vend = value; }
            get { return _ocr_vend; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_doc_no
        {
            set { _ocr_doc_no = value; }
            get { return _ocr_doc_no; }
        }

        /// <summary>
        ///
        /// </summary>
        public DateTime? Ocr_rcp_date
        {
            set { _ocr_rcp_date = value; }
            get { return _ocr_rcp_date; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_lineID
        {
            set { _ocr_lineid = value; }
            get { return _ocr_lineid; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_ctnID
        {
            set { _ocr_ctnid = value; }
            get { return _ocr_ctnid; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_partno
        {
            set { _ocr_partno = value; }
            get { return _ocr_partno; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_po
        {
            set { _ocr_po = value; }
            get { return _ocr_po; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_custpart
        {
            set { _ocr_custpart = value; }
            get { return _ocr_custpart; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_qty
        {
            set { _ocr_qty = value; }
            get { return _ocr_qty; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_nw
        {
            set { _ocr_nw = value; }
            get { return _ocr_nw; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_gw
        {
            set { _ocr_gw = value; }
            get { return _ocr_gw; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_ref_no
        {
            set { _ocr_ref_no = value; }
            get { return _ocr_ref_no; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_ref_no1
        {
            set { _ocr_ref_no1 = value; }
            get { return _ocr_ref_no1; }
        }

        /// <summary>
        ///
        /// </summary>
        public int? Ocr_TTL
        {
            set { _ocr_ttl = value; }
            get { return _ocr_ttl; }
        }

        /// <summary>
        ///
        /// </summary>
        public decimal? Ocr_unitprice
        {
            set { _ocr_unitprice = value; }
            get { return _ocr_unitprice; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_status
        {
            set { _ocr_status = value; }
            get { return _ocr_status; }
        }

        /// <summary>
        ///
        /// </summary>
        public DateTime? Ocr_cre_date
        {
            set { _ocr_cre_date = value; }
            get { return _ocr_cre_date; }
        }

        /// <summary>
        ///
        /// </summary>
        public string Ocr_cre_user
        {
            set { _ocr_cre_user = value; }
            get { return _ocr_cre_user; }
        }

        #endregion Model
    }
}