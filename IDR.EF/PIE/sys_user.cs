namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_user
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string user_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string user_comp { get; set; }

        [StringLength(250)]
        public string user_password { get; set; }

        [StringLength(150)]
        public string user_email { get; set; }

        [StringLength(100)]
        public string user_desc { get; set; }

        public DateTime? update_time { get; set; }

        public DateTime? create_time { get; set; }

        [StringLength(50)]
        public string create_user_id { get; set; }

        [StringLength(50)]
        public string update_user_id { get; set; }

        [StringLength(100)]
        public string client_ip { get; set; }

        [Column(TypeName = "text")]
        public string re_mark { get; set; }

        [StringLength(10)]
        public string flag_status { get; set; }
    }
}
