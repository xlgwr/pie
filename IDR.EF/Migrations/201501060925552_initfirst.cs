namespace IDR.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initfirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.codetable",
                c => new
                    {
                        gb = c.String(nullable: false, maxLength: 1, fixedLength: true),
                        big = c.String(maxLength: 1, fixedLength: true),
                    })
                .PrimaryKey(t => t.gb);
            
            CreateTable(
                "dbo.Irh_comp",
                c => new
                    {
                        Irh_Sys = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Irh_Prefix = c.String(nullable: false, maxLength: 3, fixedLength: true, unicode: false),
                        Irh_Comp = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Irh_connection = c.String(maxLength: 10, unicode: false),
                        Irh_inServer = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.Irh_Sys, t.Irh_Prefix });
            
            CreateTable(
                "dbo.OCR_mstr",
                c => new
                    {
                        Batch_ID = c.String(nullable: false, maxLength: 50),
                        LineID = c.Int(nullable: false),
                        CartonID = c.String(nullable: false, maxLength: 50),
                        plr_status = c.String(maxLength: 50),
                        packingListID = c.String(maxLength: 30, unicode: false),
                        InvoiceID = c.String(maxLength: 30, unicode: false),
                        plr_pallet_no = c.String(maxLength: 10, unicode: false),
                        CartonType = c.String(maxLength: 50),
                        plr_po = c.String(maxLength: 30, unicode: false),
                        plr_co = c.String(maxLength: 50),
                        plr_partno = c.String(maxLength: 30, unicode: false),
                        plr_date_code = c.String(maxLength: 50),
                        plr_vend_mfgr = c.String(maxLength: 30, unicode: false),
                        Plr_vm_partno = c.String(maxLength: 30, unicode: false),
                        plr_carton_qty = c.Decimal(precision: 18, scale: 0),
                        plr_qty = c.Decimal(precision: 18, scale: 0),
                        plr_rcp_date = c.DateTime(),
                        plr_deli_date = c.DateTime(),
                        carton_id_prifix = c.String(maxLength: 50),
                        carton_id_from = c.Decimal(precision: 18, scale: 0),
                        carton_id_to = c.Decimal(precision: 18, scale: 0),
                        plr_doc_type = c.String(maxLength: 50),
                        re_mark = c.String(unicode: false, storeType: "text"),
                        plr_suppliers_id = c.String(maxLength: 50),
                        plr_site = c.String(maxLength: 50),
                        plr_ttl = c.Int(),
                        plr_um = c.String(maxLength: 5, fixedLength: true, unicode: false),
                        plr_nw = c.String(maxLength: 50, unicode: false),
                        plr_gw = c.String(maxLength: 50, unicode: false),
                        plr_um_w = c.String(maxLength: 4, fixedLength: true, unicode: false),
                        Plr_unitprice = c.Decimal(precision: 10, scale: 4),
                        plr_msm = c.String(maxLength: 50, unicode: false),
                        plr_doc_no1 = c.String(maxLength: 30, unicode: false),
                        plr_cre_date = c.DateTime(),
                        plr_cre_userid = c.String(maxLength: 50),
                        plr_update_date = c.DateTime(),
                        plr_edituser_id = c.String(maxLength: 50),
                        plr_user_ip = c.String(maxLength: 50),
                        plr_void_status = c.Short(),
                        plr_chr01 = c.String(maxLength: 50),
                        plr_chr02 = c.String(maxLength: 50),
                        plr_deci1 = c.Int(),
                        plr_deci2 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.Batch_ID, t.LineID, t.CartonID });
            
            CreateTable(
                "dbo.pi_det",
                c => new
                    {
                        PI_ID = c.String(nullable: false, maxLength: 50),
                        pi_LineID = c.Int(nullable: false),
                        pi_wec_ctn = c.String(nullable: false, maxLength: 50),
                        plr_LineID_tran = c.Int(nullable: false),
                        pi_pallet_no = c.String(maxLength: 10),
                        CartonNo = c.String(nullable: false, maxLength: 50),
                        CartonID = c.String(maxLength: 50),
                        pi_type = c.String(nullable: false, maxLength: 50),
                        pi_status = c.String(maxLength: 50),
                        pi_status_msg = c.String(maxLength: 4000),
                        pi_remark = c.String(unicode: false, storeType: "text"),
                        pi_cre_date = c.DateTime(),
                        pi_cre_userid = c.String(maxLength: 50),
                        pi_update_date = c.DateTime(),
                        pi_edituser_id = c.String(maxLength: 50),
                        pi_user_ip = c.String(maxLength: 50),
                        pi_void_status = c.Short(),
                        pi_chr01 = c.String(maxLength: 50),
                        pi_chr02 = c.String(maxLength: 50),
                        pi_chr03 = c.String(maxLength: 50),
                        pi_deci1 = c.Int(),
                        pi_deci2 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.PI_ID, t.pi_LineID, t.pi_wec_ctn });
            
            CreateTable(
                "dbo.PI_DET_Remote",
                c => new
                    {
                        PI_NO = c.String(nullable: false, maxLength: 12),
                        PI_LINE = c.Int(nullable: false),
                        PI_CARTON_NO = c.String(maxLength: 12),
                        PI_SITE = c.String(maxLength: 6),
                        PI_PART = c.String(maxLength: 18),
                        PI_CO = c.String(maxLength: 10),
                        PI_DESC = c.String(maxLength: 48),
                        PI_QTY = c.Decimal(precision: 18, scale: 4, storeType: "numeric"),
                        PI_LOT = c.String(maxLength: 12),
                        PI_NW = c.Decimal(precision: 18, scale: 4, storeType: "numeric"),
                        PI_K200_NW = c.Decimal(precision: 18, scale: 7, storeType: "numeric"),
                        PI_GW = c.Decimal(precision: 18, scale: 4, storeType: "numeric"),
                        PI_SBU = c.String(maxLength: 4, fixedLength: true),
                        PI_REC_NO = c.String(maxLength: 15),
                        PI_PRICE = c.Decimal(precision: 18, scale: 4, storeType: "numeric"),
                        PI_PALLET = c.String(maxLength: 12),
                        PI_PO_price = c.Decimal(precision: 18, scale: 4, storeType: "numeric"),
                        PI_CONTRACT = c.String(maxLength: 18, fixedLength: true, unicode: false),
                        PI_SEQ = c.Int(),
                        PI_SEQ_CL = c.Int(),
                        PI_IQC = c.String(maxLength: 4, fixedLength: true, unicode: false),
                        PI_PO = c.String(maxLength: 8, fixedLength: true, unicode: false),
                        PI_Taxcode = c.String(maxLength: 16, fixedLength: true, unicode: false),
                        PI_ConnCode = c.String(maxLength: 8, fixedLength: true, unicode: false),
                        pi_user = c.String(maxLength: 8, fixedLength: true, unicode: false),
                        pi_cre_time = c.DateTime(),
                        pi_ver = c.Int(),
                        pi_mfgr = c.String(maxLength: 8, fixedLength: true, unicode: false),
                        pi_mfgr_part = c.String(maxLength: 40, fixedLength: true, unicode: false),
                        pi_mfgr_name = c.String(maxLength: 40, fixedLength: true, unicode: false),
                        pi_Lic_req = c.String(maxLength: 3, fixedLength: true, unicode: false),
                        pi_ori_PO_price = c.Decimal(precision: 18, scale: 4, storeType: "numeric"),
                        pi_PO_curr = c.String(maxLength: 8, fixedLength: true, unicode: false),
                        pi_curr_rate = c.Decimal(precision: 18, scale: 4, storeType: "numeric"),
                        pi_us_rate = c.Decimal(precision: 18, scale: 4, storeType: "numeric"),
                        pi_vend = c.String(maxLength: 8, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => new { t.PI_NO, t.PI_LINE });
            
            CreateTable(
                "dbo.pi_mstr",
                c => new
                    {
                        PI_ID = c.String(nullable: false, maxLength: 50),
                        LineID = c.Int(nullable: false),
                        Plant = c.String(nullable: false, maxLength: 50),
                        pi_type = c.String(nullable: false, maxLength: 50),
                        pi_status = c.String(maxLength: 50),
                        pi_status_msg = c.String(maxLength: 4000),
                        pi_remark = c.String(unicode: false, storeType: "text"),
                        pi_cre_date = c.DateTime(),
                        pi_cre_userid = c.String(maxLength: 50),
                        pi_update_date = c.DateTime(),
                        pi_edituser_id = c.String(maxLength: 50),
                        pi_user_ip = c.String(maxLength: 50),
                        pi_void_status = c.Short(),
                        pi_chr01 = c.String(maxLength: 50),
                        pi_chr02 = c.String(maxLength: 50),
                        pi_deci1 = c.Int(),
                        pi_deci2 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.PI_ID, t.LineID });
            
            CreateTable(
                "dbo.PI_MSTR_Remote",
                c => new
                    {
                        PI_NO = c.String(nullable: false, maxLength: 12),
                        PI_Date = c.DateTime(storeType: "smalldatetime"),
                        PI_Page = c.String(maxLength: 2),
                        msrepl_synctran_ts = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    })
                .PrimaryKey(t => t.PI_NO);
            
            CreateTable(
                "dbo.pi_sq",
                c => new
                    {
                        sq_type = c.String(nullable: false, maxLength: 50),
                        sq_id = c.Int(nullable: false),
                        sq_name = c.String(maxLength: 100),
                        sq_desc = c.String(maxLength: 300),
                        sq_unit = c.String(maxLength: 50),
                        co_id = c.String(nullable: false, maxLength: 50),
                        co_desc = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.sq_type, t.sq_id });
            
            CreateTable(
                "dbo.pisr_grr",
                c => new
                    {
                        pi_wec_ctn = c.String(nullable: false, maxLength: 50),
                        plr_LineID_tran = c.Int(nullable: false),
                        pi_chr02 = c.String(nullable: false, maxLength: 50),
                        Plant = c.String(nullable: false, maxLength: 50),
                        pisr_rir = c.String(maxLength: 50),
                        pisr_invoice = c.String(maxLength: 50),
                        pisr_part = c.String(maxLength: 50),
                        Pisr_receiver = c.String(maxLength: 50),
                        pisr_site = c.String(maxLength: 50),
                        pisr_po_nbr = c.String(maxLength: 50),
                        pisr_qty = c.Decimal(precision: 18, scale: 0),
                        pisr_curr = c.String(maxLength: 50),
                        pisr_cost = c.Decimal(precision: 18, scale: 4),
                        pisr_base_cost = c.Decimal(precision: 18, scale: 4),
                        pisr_us_cost = c.Decimal(precision: 18, scale: 4),
                        pisr_seq = c.String(maxLength: 50),
                        pisr_con_code = c.String(maxLength: 50),
                        pisr_ch_desc = c.String(maxLength: 50),
                        pisr_net_wt = c.Decimal(precision: 18, scale: 4),
                        pisr_rec_type = c.String(maxLength: 50),
                        pisr_abc = c.String(maxLength: 50),
                        pisr_code = c.String(maxLength: 50),
                        pisr_lic_req = c.String(maxLength: 50),
                        pisr_sbu = c.String(maxLength: 50),
                        pisr_vend = c.String(maxLength: 50),
                        pisr_mfgr_name = c.String(maxLength: 50),
                        pisr_char01 = c.String(maxLength: 50),
                        pisr_char02 = c.String(maxLength: 50),
                        pisr_char03 = c.String(maxLength: 50),
                        pisr_dec01 = c.Decimal(precision: 18, scale: 8),
                        pisr_dec02 = c.Decimal(precision: 18, scale: 8),
                        pisr_int01 = c.Int(),
                        pisr_int02 = c.Int(),
                        pi_status = c.String(maxLength: 50),
                        pi_status_msg = c.String(maxLength: 4000),
                        pi_remark = c.String(unicode: false, storeType: "text"),
                        pi_cre_date = c.DateTime(),
                        pi_cre_userid = c.String(maxLength: 50),
                        pi_update_date = c.DateTime(),
                        pi_edituser_id = c.String(maxLength: 50),
                        pi_user_ip = c.String(maxLength: 50),
                        pi_void_status = c.Short(),
                        pi_chr01 = c.String(maxLength: 50),
                        pi_deci1 = c.Int(),
                        pi_deci2 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.pi_wec_ctn, t.plr_LineID_tran, t.pi_chr02 });
            
            CreateTable(
                "dbo.pkey_ctl",
                c => new
                    {
                        t_name = c.String(nullable: false, maxLength: 50),
                        t_value = c.String(nullable: false, maxLength: 50),
                        t_desc = c.String(maxLength: 4000),
                        t_yyww = c.String(maxLength: 50),
                        prefix = c.String(maxLength: 50),
                        ctl_fro = c.Decimal(precision: 18, scale: 0),
                        ctl_to = c.Decimal(precision: 18, scale: 0),
                        ctl_curr = c.Decimal(precision: 18, scale: 0),
                        ctl_curr_len = c.Decimal(precision: 18, scale: 0),
                        ctl_len = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.t_name, t.t_value });
            
            CreateTable(
                "dbo.plr_batch_mstr",
                c => new
                    {
                        batch_id = c.String(nullable: false, maxLength: 50),
                        plr_suppliers_id = c.String(maxLength: 50),
                        batch_doc = c.String(maxLength: 50),
                        batch_status = c.String(maxLength: 50),
                        batch_void = c.Short(),
                        batch_cre_date = c.DateTime(),
                        batch_update_date = c.DateTime(),
                        batch_cre_user = c.String(maxLength: 50),
                        batch_user_ip = c.String(maxLength: 50),
                        batch_chr01 = c.String(maxLength: 50),
                        batch_dec01 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => t.batch_id);
            
            CreateTable(
                "dbo.plr_mstr",
                c => new
                    {
                        Batch_ID = c.String(nullable: false, maxLength: 50),
                        LineID = c.Int(nullable: false),
                        plr_status = c.String(maxLength: 50),
                        packingListID = c.String(maxLength: 30, unicode: false),
                        InvoiceID = c.String(maxLength: 30, unicode: false),
                        plr_pallet_no = c.String(maxLength: 10, unicode: false),
                        CartonType = c.String(maxLength: 50),
                        CartonID = c.String(nullable: false, maxLength: 50),
                        plr_po = c.String(maxLength: 30, unicode: false),
                        plr_co = c.String(maxLength: 50),
                        plr_partno = c.String(maxLength: 30, unicode: false),
                        plr_date_code = c.String(maxLength: 50),
                        plr_vend_mfgr = c.String(maxLength: 30, unicode: false),
                        Plr_vm_partno = c.String(maxLength: 30, unicode: false),
                        plr_carton_qty = c.Decimal(precision: 18, scale: 0),
                        plr_qty = c.Decimal(precision: 18, scale: 0),
                        plr_rcp_date = c.DateTime(),
                        plr_deli_date = c.DateTime(),
                        carton_id_prifix = c.String(maxLength: 50),
                        carton_id_from = c.Decimal(precision: 18, scale: 0),
                        carton_id_to = c.Decimal(precision: 18, scale: 0),
                        plr_doc_type = c.String(maxLength: 50),
                        re_mark = c.String(unicode: false, storeType: "text"),
                        plr_suppliers_id = c.String(maxLength: 50),
                        plr_site = c.String(maxLength: 50),
                        plr_ttl = c.Int(),
                        plr_um = c.String(maxLength: 5, fixedLength: true, unicode: false),
                        plr_nw = c.String(maxLength: 50, unicode: false),
                        plr_gw = c.String(maxLength: 50, unicode: false),
                        plr_um_w = c.String(maxLength: 4, fixedLength: true, unicode: false),
                        Plr_unitprice = c.Decimal(precision: 10, scale: 4),
                        plr_msm = c.String(maxLength: 50, unicode: false),
                        plr_doc_no1 = c.String(maxLength: 30, unicode: false),
                        plr_cre_date = c.DateTime(),
                        plr_cre_userid = c.String(maxLength: 50),
                        plr_update_date = c.DateTime(),
                        plr_edituser_id = c.String(maxLength: 50),
                        plr_user_ip = c.String(maxLength: 50),
                        plr_void_status = c.Short(),
                        plr_chr01 = c.String(maxLength: 50),
                        plr_chr02 = c.String(maxLength: 50),
                        plr_deci1 = c.Int(),
                        plr_deci2 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.Batch_ID, t.LineID });
            
            CreateTable(
                "dbo.plr_mstr_err",
                c => new
                    {
                        Batch_ID = c.String(nullable: false, maxLength: 20, unicode: false),
                        LineID = c.Int(nullable: false),
                        plr_doc_type = c.String(maxLength: 50),
                        plr_po = c.String(maxLength: 30),
                        plr_partno = c.String(maxLength: 30),
                        plr_qty = c.Decimal(precision: 18, scale: 0),
                        plr_err_msg = c.String(unicode: false, storeType: "text"),
                        plr_cre_date = c.DateTime(),
                        plr_cre_userid = c.String(maxLength: 50),
                        plr_update_date = c.DateTime(),
                        plr_edituser_id = c.String(maxLength: 50),
                        plr_user_ip = c.String(maxLength: 50),
                        plr_void_status = c.Short(),
                        plr_chr01 = c.String(maxLength: 50),
                        plr_chr02 = c.String(maxLength: 50),
                        plr_deci1 = c.Int(),
                        plr_deci2 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.Batch_ID, t.LineID });
            
            CreateTable(
                "dbo.plr_mstr_log",
                c => new
                    {
                        Batch_ID = c.String(nullable: false, maxLength: 20, unicode: false),
                        LineID = c.Int(nullable: false),
                        Wec_Ctn = c.Int(nullable: false),
                        plr_partno = c.String(nullable: false, maxLength: 30, unicode: false),
                        CartonNo = c.Int(nullable: false),
                        plr_wec_ctn = c.String(maxLength: 50),
                        CartonID = c.String(nullable: false, maxLength: 50),
                        CartonType = c.String(maxLength: 50),
                        packingListID = c.String(maxLength: 30, unicode: false),
                        InvoiceID = c.String(maxLength: 30, unicode: false),
                        plr_site = c.String(maxLength: 50),
                        plr_pallet_no = c.String(maxLength: 10, fixedLength: true),
                        plr_po = c.String(maxLength: 30, unicode: false),
                        plr_co = c.String(maxLength: 50),
                        plr_date_code = c.String(maxLength: 50),
                        plr_vend_mfgr = c.String(maxLength: 30, unicode: false),
                        Plr_vm_partno = c.String(maxLength: 30, unicode: false),
                        plr_qty = c.Decimal(precision: 18, scale: 0),
                        plr_rcp_date = c.DateTime(),
                        plr_deli_date = c.DateTime(),
                        carton_id_prifix = c.String(maxLength: 50),
                        plr_status = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        plr_cre_date = c.DateTime(),
                        plr_cre_userid = c.String(maxLength: 50),
                        plr_update_date = c.DateTime(),
                        plr_edituser_id = c.String(maxLength: 50),
                        plr_user_ip = c.String(maxLength: 50),
                        plr_void_status = c.Short(),
                        plr_chr01 = c.String(maxLength: 50),
                        plr_chr02 = c.String(maxLength: 50),
                        plr_deci1 = c.Int(),
                        plr_deci2 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.Batch_ID, t.LineID, t.Wec_Ctn, t.plr_partno });
            
            CreateTable(
                "dbo.plr_mstr_tran",
                c => new
                    {
                        Batch_ID = c.String(nullable: false, maxLength: 50),
                        LineID = c.Int(nullable: false),
                        Wec_Ctn = c.Int(nullable: false),
                        plr_wec_ctn = c.String(nullable: false, maxLength: 50),
                        plr_po = c.String(nullable: false, maxLength: 30, unicode: false),
                        plr_partno = c.String(nullable: false, maxLength: 30, unicode: false),
                        plr_status = c.String(maxLength: 50),
                        plr_status_msg = c.String(maxLength: 4000),
                        CartonNo = c.String(nullable: false, maxLength: 50),
                        CartonID = c.String(nullable: false, maxLength: 50),
                        CartonType = c.String(maxLength: 50),
                        plr_carton_qty = c.Decimal(precision: 18, scale: 0),
                        plr_qty = c.Decimal(precision: 18, scale: 0),
                        plr_suppliers_id = c.String(maxLength: 50),
                        packingListID = c.String(maxLength: 30, unicode: false),
                        InvoiceID = c.String(maxLength: 30, unicode: false),
                        plr_rcp_date = c.DateTime(),
                        plr_pallet_no = c.String(maxLength: 10),
                        plr_deli_date = c.DateTime(),
                        plr_site = c.String(maxLength: 50),
                        plr_co = c.String(maxLength: 50),
                        plr_date_code = c.String(maxLength: 50),
                        plr_vend_mfgr = c.String(maxLength: 30, unicode: false),
                        Plr_vm_partno = c.String(maxLength: 30, unicode: false),
                        carton_id_prifix = c.String(maxLength: 50),
                        re_mark = c.String(unicode: false, storeType: "text"),
                        plr_cre_date = c.DateTime(),
                        plr_cre_userid = c.String(maxLength: 50),
                        plr_update_date = c.DateTime(),
                        plr_edituser_id = c.String(maxLength: 50),
                        plr_user_ip = c.String(maxLength: 50),
                        plr_void_status = c.Short(),
                        plr_chr01 = c.String(maxLength: 50),
                        plr_chr02 = c.String(maxLength: 50),
                        plr_deci1 = c.Int(),
                        plr_deci2 = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.Batch_ID, t.LineID, t.Wec_Ctn, t.plr_wec_ctn, t.plr_po, t.plr_partno });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.plr_mstr_tran");
            DropTable("dbo.plr_mstr_log");
            DropTable("dbo.plr_mstr_err");
            DropTable("dbo.plr_mstr");
            DropTable("dbo.plr_batch_mstr");
            DropTable("dbo.pkey_ctl");
            DropTable("dbo.pisr_grr");
            DropTable("dbo.pi_sq");
            DropTable("dbo.PI_MSTR_Remote");
            DropTable("dbo.pi_mstr");
            DropTable("dbo.PI_DET_Remote");
            DropTable("dbo.pi_det");
            DropTable("dbo.OCR_mstr");
            DropTable("dbo.Irh_comp");
            DropTable("dbo.codetable");
        }
    }
}
