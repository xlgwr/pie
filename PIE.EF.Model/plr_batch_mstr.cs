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
    
    public partial class plr_batch_mstr
    {
        public plr_batch_mstr()
        {
            this.plr_mstr = new HashSet<plr_mstr>();
        }
    
        public string batch_id { get; set; }
        public string plr_suppliers_id { get; set; }
        public string batch_doc { get; set; }
        public string batch_status { get; set; }
        public Nullable<short> batch_void { get; set; }
        public Nullable<System.DateTime> batch_cre_date { get; set; }
        public Nullable<System.DateTime> batch_update_date { get; set; }
        public string batch_cre_user { get; set; }
        public string batch_user_ip { get; set; }
        public string batch_chr01 { get; set; }
        public Nullable<decimal> batch_dec01 { get; set; }
    
        public virtual ICollection<plr_mstr> plr_mstr { get; set; }
    }
}
