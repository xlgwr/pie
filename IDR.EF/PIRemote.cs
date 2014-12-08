namespace IDR.EF.PIRemote
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    using IDR.Common;

    public partial class PIRemote : DbContext
    {
        public PIRemote()
            : base(PubConstant.GetConnectionString("ConnectionStringPIRemote"))//"name=PIRemote"
        {
        }

        public virtual DbSet<PI_DET> PI_DET { get; set; }
        public virtual DbSet<PI_MSTR> PI_MSTR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_QTY)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_NW)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_K200_NW)
                .HasPrecision(18, 7);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_GW)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_SBU)
                .IsFixedLength();

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_PRICE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_PO_price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_CONTRACT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_IQC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_PO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_Taxcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.PI_ConnCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_user)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_mfgr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_mfgr_part)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_mfgr_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_Lic_req)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_ori_PO_price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_PO_curr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_curr_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_us_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET>()
                .Property(e => e.pi_vend)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_MSTR>()
                .Property(e => e.msrepl_synctran_ts)
                .IsFixedLength();
        }
    }
}
