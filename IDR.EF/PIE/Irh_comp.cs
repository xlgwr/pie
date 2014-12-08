namespace IDR.EF.PIE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Irh_comp
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Irh_Sys { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Irh_Prefix { get; set; }

        [Column("Irh_Comp")]
        [Required]
        [StringLength(10)]
        public string Irh_Comp1 { get; set; }

        [StringLength(10)]
        public string Irh_connection { get; set; }

        [StringLength(50)]
        public string Irh_inServer { get; set; }
    }
}
