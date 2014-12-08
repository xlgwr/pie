namespace IDR.EF.PIRemote
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PI_MSTR
    {
        [Key]
        [StringLength(12)]
        public string PI_NO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PI_Date { get; set; }

        [StringLength(2)]
        public string PI_Page { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] msrepl_synctran_ts { get; set; }
    }
}
