//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class plr_mstr_err
    {
        public string Batch_ID { get; set; }
        public int LineID { get; set; }
        public string plr_doc_type { get; set; }
        public string plr_po { get; set; }
        public string plr_partno { get; set; }
        public Nullable<decimal> plr_qty { get; set; }
        public string plr_err_msg { get; set; }
        public Nullable<System.DateTime> plr_cre_date { get; set; }
        public string plr_cre_userid { get; set; }
        public Nullable<System.DateTime> plr_update_date { get; set; }
        public string plr_edituser_id { get; set; }
        public string plr_user_ip { get; set; }
        public Nullable<short> plr_void_status { get; set; }
        public string plr_chr01 { get; set; }
        public string plr_chr02 { get; set; }
        public Nullable<int> plr_deci1 { get; set; }
        public Nullable<decimal> plr_deci2 { get; set; }
    }
}
