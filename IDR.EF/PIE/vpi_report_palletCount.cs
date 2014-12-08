namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vpi_report_palletCount
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string PI_NO { get; set; }

        public int? plr_LineID { get; set; }

        [StringLength(14)]
        public string PI_CARTON_NO { get; set; }

        public int? TTL { get; set; }

        [StringLength(16)]
        public string PI_DESC { get; set; }

        public decimal? PI_GW { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string use_char01 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string use_char02 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int use_dec01 { get; set; }

        [StringLength(50)]
        public string pi_pallet_no { get; set; }
    }
}
