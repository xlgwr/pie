namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class plr_batch_mstr
    {
        [Key]
        [StringLength(50)]
        public string batch_id { get; set; }

        [StringLength(50)]
        public string plr_suppliers_id { get; set; }

        [StringLength(50)]
        public string batch_doc { get; set; }

        [StringLength(50)]
        public string batch_status { get; set; }

        public short? batch_void { get; set; }

        public DateTime? batch_cre_date { get; set; }

        public DateTime? batch_update_date { get; set; }

        [StringLength(50)]
        public string batch_cre_user { get; set; }

        [StringLength(50)]
        public string batch_user_ip { get; set; }

        [StringLength(50)]
        public string batch_chr01 { get; set; }

        public decimal? batch_dec01 { get; set; }
    }
}
