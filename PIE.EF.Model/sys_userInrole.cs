//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIE.EF.Model.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class sys_userInrole
    {
        public string user_name { get; set; }
        public int role_id { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string create_user_id { get; set; }
        public string update_user_id { get; set; }
        public string client_ip { get; set; }
        public string re_mark { get; set; }
        public string flag_status { get; set; }
    }
}
