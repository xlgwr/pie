namespace IDR.EF.PIE
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    using IDR.Common;

    

    public partial class PIE : DbContext
    {
        public PIE()
            : base(PubConstant.GetConnectionString("ConnectionStringPIE"))//"name=PIE"
        {
        }

        public virtual DbSet<codetable> codetable { get; set; }
        public virtual DbSet<Irh_comp> Irh_comp { get; set; }
        public virtual DbSet<pi_det> pi_det { get; set; }
        public virtual DbSet<PI_DET_Remote> PI_DET_Remote { get; set; }
        public virtual DbSet<pi_mstr> pi_mstr { get; set; }
        public virtual DbSet<PI_MSTR_Remote> PI_MSTR_Remote { get; set; }
        public virtual DbSet<pi_sq> pi_sq { get; set; }
        public virtual DbSet<pisr_grr> pisr_grr { get; set; }
        public virtual DbSet<pkey_ctl> pkey_ctl { get; set; }
        public virtual DbSet<plr_batch_mstr> plr_batch_mstr { get; set; }
        public virtual DbSet<plr_mstr> plr_mstr { get; set; }
        public virtual DbSet<plr_mstr_err> plr_mstr_err { get; set; }
        public virtual DbSet<plr_mstr_log> plr_mstr_log { get; set; }
        public virtual DbSet<plr_mstr_tran> plr_mstr_tran { get; set; }
        public virtual DbSet<sys_role> sys_role { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }
        public virtual DbSet<sys_userInrole> sys_userInrole { get; set; }
        public virtual DbSet<ticketingPTMR> ticketingPTMR { get; set; }
        public virtual DbSet<OCR_mstr> OCR_mstr { get; set; }
        public virtual DbSet<vpi_detApisr_grr> vpi_detApisr_grr { get; set; }
        public virtual DbSet<vpi_report> vpi_report { get; set; }
        public virtual DbSet<vpi_report_base> vpi_report_base { get; set; }
        public virtual DbSet<vpi_report_palletCount> vpi_report_palletCount { get; set; }
        public virtual DbSet<vplr_carton> vplr_carton { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<codetable>()
                .Property(e => e.gb)
                .IsFixedLength();

            modelBuilder.Entity<codetable>()
                .Property(e => e.big)
                .IsFixedLength();

            modelBuilder.Entity<Irh_comp>()
                .Property(e => e.Irh_Sys)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Irh_comp>()
                .Property(e => e.Irh_Prefix)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Irh_comp>()
                .Property(e => e.Irh_Comp1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Irh_comp>()
                .Property(e => e.Irh_connection)
                .IsUnicode(false);

            modelBuilder.Entity<pi_det>()
                .Property(e => e.pi_remark)
                .IsUnicode(false);

            modelBuilder.Entity<pi_det>()
                .Property(e => e.pi_deci2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_QTY)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_NW)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_K200_NW)
                .HasPrecision(18, 7);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_GW)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_SBU)
                .IsFixedLength();

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_PRICE)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_PO_price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_CONTRACT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_IQC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_PO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_Taxcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.PI_ConnCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_user)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_mfgr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_mfgr_part)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_mfgr_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_Lic_req)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_ori_PO_price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_PO_curr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_curr_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_us_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<PI_DET_Remote>()
                .Property(e => e.pi_vend)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pi_mstr>()
                .Property(e => e.pi_remark)
                .IsUnicode(false);

            modelBuilder.Entity<pi_mstr>()
                .Property(e => e.pi_deci2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PI_MSTR_Remote>()
                .Property(e => e.msrepl_synctran_ts)
                .IsFixedLength();

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pisr_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pisr_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pisr_base_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pisr_us_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pisr_net_wt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pisr_dec01)
                .HasPrecision(18, 8);

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pisr_dec02)
                .HasPrecision(18, 8);

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pi_remark)
                .IsUnicode(false);

            modelBuilder.Entity<pisr_grr>()
                .Property(e => e.pi_deci2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<pkey_ctl>()
                .Property(e => e.ctl_fro)
                .HasPrecision(18, 0);

            modelBuilder.Entity<pkey_ctl>()
                .Property(e => e.ctl_to)
                .HasPrecision(18, 0);

            modelBuilder.Entity<pkey_ctl>()
                .Property(e => e.ctl_curr)
                .HasPrecision(18, 0);

            modelBuilder.Entity<pkey_ctl>()
                .Property(e => e.ctl_curr_len)
                .HasPrecision(18, 0);

            modelBuilder.Entity<pkey_ctl>()
                .Property(e => e.ctl_len)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_batch_mstr>()
                .Property(e => e.batch_dec01)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.packingListID)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_pallet_no)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_po)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_partno)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_vend_mfgr)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.Plr_vm_partno)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_carton_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.carton_id_from)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.carton_id_to)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.re_mark)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_um)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_nw)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_gw)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_um_w)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.Plr_unitprice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_msm)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_doc_no1)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr>()
                .Property(e => e.plr_deci2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr_err>()
                .Property(e => e.Batch_ID)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_err>()
                .Property(e => e.plr_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr_err>()
                .Property(e => e.plr_err_msg)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_err>()
                .Property(e => e.plr_deci2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.Batch_ID)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.packingListID)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.plr_pallet_no)
                .IsFixedLength();

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.plr_po)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.plr_partno)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.plr_vend_mfgr)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.Plr_vm_partno)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.plr_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.plr_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_log>()
                .Property(e => e.plr_deci2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.plr_po)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.plr_partno)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.plr_carton_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.plr_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.packingListID)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.plr_vend_mfgr)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.Plr_vm_partno)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.re_mark)
                .IsUnicode(false);

            modelBuilder.Entity<plr_mstr_tran>()
                .Property(e => e.plr_deci2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.re_mark)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.re_mark)
                .IsUnicode(false);

            modelBuilder.Entity<sys_userInrole>()
                .Property(e => e.re_mark)
                .IsUnicode(false);

            modelBuilder.Entity<ticketingPTMR>()
                .Property(e => e.t_dec01)
                .HasPrecision(18, 5);

            modelBuilder.Entity<ticketingPTMR>()
                .Property(e => e.t_dec02)
                .HasPrecision(18, 5);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.packingListID)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_pallet_no)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_po)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_partno)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_vend_mfgr)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.Plr_vm_partno)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_carton_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.carton_id_from)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.carton_id_to)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.re_mark)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_um)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_nw)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_gw)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_um_w)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.Plr_unitprice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_msm)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_doc_no1)
                .IsUnicode(false);

            modelBuilder.Entity<OCR_mstr>()
                .Property(e => e.plr_deci2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.pisr_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.pisr_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.pisr_base_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.pisr_us_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.pisr_net_wt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.MFGR_Part)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.pisr_dec01)
                .HasPrecision(18, 8);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.pisr_dec02)
                .HasPrecision(18, 8);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.REC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_detApisr_grr>()
                .Property(e => e.Contract)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.pisr_qty)
                .HasPrecision(38, 0);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.pisr_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.pisr_base_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.pisr_net_wt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.MFGR_Part)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.pisr_dec01)
                .HasPrecision(23, 13);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.pisr_dec02)
                .HasPrecision(38, 6);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.REC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_report>()
                .Property(e => e.Contract)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.pisr_qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.pisr_base_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.pisr_cost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.pisr_net_wt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.MFGR_Part)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.pisr_dec01)
                .HasPrecision(23, 13);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.pisr_dec02)
                .HasPrecision(37, 8);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.REC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_report_base>()
                .Property(e => e.Contract)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_report_palletCount>()
                .Property(e => e.PI_GW)
                .HasPrecision(8, 2);

            modelBuilder.Entity<vpi_report_palletCount>()
                .Property(e => e.use_char01)
                .IsUnicode(false);

            modelBuilder.Entity<vpi_report_palletCount>()
                .Property(e => e.use_char02)
                .IsUnicode(false);

            modelBuilder.Entity<vplr_carton>()
                .Property(e => e.plr_po)
                .IsUnicode(false);
        }
    }
}
