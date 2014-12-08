namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class plr_mstr_err
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Batch_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineID { get; set; }

        [StringLength(50)]
        public string plr_doc_type { get; set; }

        [StringLength(30)]
        public string plr_po { get; set; }

        [StringLength(30)]
        public string plr_partno { get; set; }

        public decimal? plr_qty { get; set; }

        [Column(TypeName = "text")]
        public string plr_err_msg { get; set; }

        public DateTime? plr_cre_date { get; set; }

        [StringLength(50)]
        public string plr_cre_userid { get; set; }

        public DateTime? plr_update_date { get; set; }

        [StringLength(50)]
        public string plr_edituser_id { get; set; }

        [StringLength(50)]
        public string plr_user_ip { get; set; }

        public short? plr_void_status { get; set; }

        [StringLength(50)]
        public string plr_chr01 { get; set; }

        [StringLength(50)]
        public string plr_chr02 { get; set; }

        public int? plr_deci1 { get; set; }

        public decimal? plr_deci2 { get; set; }
    }
}
