namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pi_mstr
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string PI_ID { get; set; }

        [StringLength(50)]
        public string pi_status { get; set; }

        [StringLength(50)]
        public string pi_chr01 { get; set; }

        [Required]
        [StringLength(50)]
        public string Plant { get; set; }

        [Required]
        [StringLength(50)]
        public string pi_type { get; set; }

        [StringLength(50)]
        public string pi_cre_userid { get; set; }

        [StringLength(50)]
        public string pi_user_ip { get; set; }

        [Column(TypeName = "text")]
        public string pi_remark { get; set; }
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineID { get; set; }

        public DateTime? pi_cre_date { get; set; }


        [StringLength(4000)]
        public string pi_status_msg { get; set; }

        public DateTime? pi_update_date { get; set; }

        [StringLength(50)]
        public string pi_edituser_id { get; set; }

        public short? pi_void_status { get; set; }

        [StringLength(50)]
        public string pi_chr02 { get; set; }

        public int? pi_deci1 { get; set; }

        public decimal? pi_deci2 { get; set; }
    }
}
