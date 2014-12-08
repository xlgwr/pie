namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pi_det
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string PI_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pi_LineID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string pi_wec_ctn { get; set; }

        public int plr_LineID_tran { get; set; }

        [StringLength(10)]
        public string pi_pallet_no { get; set; }

        [Required]
        [StringLength(50)]
        public string CartonNo { get; set; }

        [StringLength(50)]
        public string CartonID { get; set; }

        [Required]
        [StringLength(50)]
        public string pi_type { get; set; }

        [StringLength(50)]
        public string pi_status { get; set; }

        [StringLength(4000)]
        public string pi_status_msg { get; set; }

        [Column(TypeName = "text")]
        public string pi_remark { get; set; }

        public DateTime? pi_cre_date { get; set; }

        [StringLength(50)]
        public string pi_cre_userid { get; set; }

        public DateTime? pi_update_date { get; set; }

        [StringLength(50)]
        public string pi_edituser_id { get; set; }

        [StringLength(50)]
        public string pi_user_ip { get; set; }

        public short? pi_void_status { get; set; }

        [StringLength(50)]
        public string pi_chr01 { get; set; }

        [StringLength(50)]
        public string pi_chr02 { get; set; }

        [StringLength(50)]
        public string pi_chr03 { get; set; }

        public int? pi_deci1 { get; set; }

        public decimal? pi_deci2 { get; set; }
    }
}
