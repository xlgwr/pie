USE [PIE]
GO
/****** Object:  StoredProcedure [dbo].[sp_GenCtn_Tran]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<ling.xie>
-- Create date: <08-08-2014>
-- Description:	<Gen Carton No>
-- example exec 
--declare @result tinyint
--exec sp_GenCtn_Tran 'R1408080003','1','e-Packing','A11','Number','10455281','20000','WEC','11','11','','test',@result output
--select @result
-- =============================================
CREATE PROCEDURE [dbo].[sp_GenCtn_Tran]
	-- Add the parameters for the stored procedure here
	(
	 @Batch_ID varchar(20),
	 @LineID int,
	 @plr_doc_type nvarchar(50),
     @CartonID varchar(30),     
     @CartonType varchar(30),
     @plr_po varchar(50),
     @plr_qty decimal(18,0),
     @ctnPre varchar(10),
	 @ctnFr int,
     @ctnTo int,
     @plr_cre_userid varchar(50),
     @plr_user_ip varchar(50),
     --@plr_partno  varchar(30),
     @result tinyint output
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	declare @wec_ctn_pre nvarchar(50),
			@wec_ctn int, 
			@plr_wec_ctn nvarchar(50),
			@getYearMD nvarchar(8),
			@ctnPrefix nvarchar(10),
			@CartonNoIn nvarchar(30)
    -- Insert statements for procedure here
    set @result = 1 
    set @getYearMD = convert(char(4),YEAR(getdate())) + 
                     REPLICATE('0',2-len(month(getdate()))) + 
                     convert(nvarchar(2),month(getdate())) + 
                     convert(char(2),Datepart(week,GETDATE()))
 
  if exists(select * from plr_mstr_tran where Batch_ID=@Batch_ID and LineID=@LineID )--and plr_po=@plr_po
			      delete from plr_mstr_tran where plr_status<>'U' and Batch_ID=@Batch_ID and LineID=@LineID --and plr_po=@plr_po  -- clean the original record

   --1 ======
	if @ctnFr = @ctnTo
			if exists(select top 1 Wec_Ctn from Plr_mstr_tran where Batch_ID=@Batch_ID and CartonID=@CartonID)
				begin
				select top 1 @wec_ctn=Wec_Ctn,@CartonNoIn=CartonNo,@plr_wec_ctn=plr_wec_ctn from Plr_mstr_tran where Batch_ID=@Batch_ID and CartonID=@CartonID
				 
				    insert into Plr_mstr_tran 
						(Batch_ID, LineID, Wec_Ctn, CartonNo, plr_wec_ctn, CartonID, CartonType,plr_suppliers_id, packingListID, InvoiceID, plr_site, plr_pallet_no, plr_po, plr_co, plr_partno, plr_date_code, plr_vend_mfgr, Plr_vm_partno,plr_carton_qty, plr_qty, plr_rcp_date, plr_deli_date, carton_id_prifix, plr_status, plr_cre_date, plr_cre_userid, plr_update_date, plr_edituser_id, plr_user_ip, plr_void_status, plr_chr01, plr_chr02, plr_deci1, plr_deci2)
					select top 1 Batch_ID, LineID, @wec_ctn,@CartonNoIn,@plr_wec_ctn,CartonID, CartonType,plr_suppliers_id, packingListID, InvoiceID, plr_site, plr_pallet_no, plr_po, plr_co, plr_partno, plr_date_code, plr_vend_mfgr, Plr_vm_partno,plr_carton_qty, plr_qty, plr_rcp_date, plr_deli_date, carton_id_prifix, 'C',getdate(),@plr_cre_userid, getdate(), plr_edituser_id,@plr_user_ip, plr_void_status, plr_chr01, plr_chr02, plr_deci1, plr_deci2
					from Plr_mstr where Batch_ID=@Batch_ID and LineID=@LineID and plr_po=@plr_po --and plr_partno=@plr_partno
					
			     select @result = 0	
				 return
				end  
				               
    begin tran
    	select top 1 @wec_ctn = ctl_curr from dbo.pkey_ctl where t_name='Plr_mstr_tran' and t_value ='Wec_Ctn'
		if (@wec_ctn is null) or (@wec_ctn='')
		  set @wec_ctn = 0

		
		---2 >=======	
		while (@ctnFr <= @ctnTo)
		 begin
		 
		    set @wec_ctn = @wec_ctn + 1 
		    set @ctnPrefix = @ctnPre+CONVERT(nvarchar,@ctnFr)
		    
            if exists(select top 1 t_name from dbo.pkey_ctl where t_name='Plr_mstr_tran' and t_value ='Wec_Ctn')
              update dbo.pkey_ctl set ctl_curr=@wec_ctn where t_name='Plr_mstr_tran' and t_value ='Wec_Ctn'
            else
			  insert dbo.pkey_ctl (t_name,t_value,ctl_curr) values ('Plr_mstr_tran','Wec_Ctn',@wec_ctn)
			 
            if exists(select top 1 Wec_Ctn from Plr_mstr_tran where Wec_Ctn = @wec_ctn)		
              continue
              	
			--select @wec_ctn_pre=Irh_Sys
			if exists(select top 1 irh_prefix
						 from Irh_comp  where (rtrim(irh_prefix)=substring(@plr_po,1,1) or rtrim(irh_prefix)=substring(@plr_po,1,2) 
							 or rtrim(irh_prefix)=substring(@plr_po,1,3)))
			  select @wec_ctn_pre=irh_prefix
				 from Irh_comp  where (rtrim(irh_prefix)=substring(@plr_po,1,1) or rtrim(irh_prefix)=substring(@plr_po,1,2) 
					 or rtrim(irh_prefix)=substring(@plr_po,1,3))
			 else
				set @wec_ctn_pre='Z'
			 		 
			 set @plr_wec_ctn = ltrim(rtrim(@wec_ctn_pre)) + REPLICATE('0',12-len(ltrim(rtrim(@wec_ctn_pre)))-LEN(@wec_ctn)) + convert(nvarchar,@wec_ctn)
		
		   
	        insert into Plr_mstr_tran 
			       (Batch_ID, LineID, Wec_Ctn, CartonNo, plr_wec_ctn, CartonID, CartonType,plr_suppliers_id, packingListID, InvoiceID, plr_site, plr_pallet_no, plr_po, plr_co, plr_partno, plr_date_code, plr_vend_mfgr, Plr_vm_partno, plr_carton_qty, plr_qty, plr_rcp_date, plr_deli_date, carton_id_prifix, plr_status, plr_cre_date, plr_cre_userid, plr_update_date, plr_edituser_id, plr_user_ip, plr_void_status, plr_chr01, plr_chr02, plr_deci1, plr_deci2)
			select Batch_ID, LineID, @wec_ctn,@ctnPrefix,@plr_wec_ctn,CartonID, CartonType,plr_suppliers_id, packingListID, InvoiceID, plr_site, plr_pallet_no, plr_po, plr_co, plr_partno, plr_date_code, plr_vend_mfgr, Plr_vm_partno, plr_carton_qty, plr_qty, plr_rcp_date, plr_deli_date, carton_id_prifix, 'C',getdate(),@plr_cre_userid, getdate(), plr_edituser_id,@plr_user_ip, plr_void_status, plr_chr01, plr_chr02, plr_deci1, plr_deci2
			from Plr_mstr where Batch_ID=@Batch_ID and LineID=@LineID and plr_po=@plr_po --and plr_partno=@plr_partno
			
			--print @lineID
			
			set @ctnFr = @ctnFr + 1
	   end
    	
    	select @result = 0	
	commit tran
   if @@ERROR <> 0
   begin
     select @result = 1
     rollback tran
     return
   end
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Get_WecCtnPre]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Herry Zheng>
-- Create date: <06/10/2014>
-- Description:	<Generate Company info for packing list upload>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Get_WecCtnPre]
(
	@po_nbr varchar(30),
	@wec_ctn_pre char(6) output
)
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- gen location and company inforamtion here
   if exists(select top 1 Irh_Sys
						 from Irh_comp  where (rtrim(irh_prefix)=substring(@po_nbr,1,1) or rtrim(irh_prefix)=substring(@po_nbr,1,2) 
							 or rtrim(irh_prefix)=substring(@po_nbr,1,3)))
			  select @wec_ctn_pre=Irh_Sys
				 from Irh_comp  where (rtrim(irh_prefix)=substring(@po_nbr,1,1) or rtrim(irh_prefix)=substring(@po_nbr,1,2) 
					 or rtrim(irh_prefix)=substring(@po_nbr,1,3))
			 else
				set @wec_ctn_pre='Z'
		 
	return	 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetBatchID]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<xlgwr>
-- Create date: <06/10/2014>
-- Description:	<Generate Company info for packing list upload>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetBatchID]
(
 @BatchID varchar(11) output
)
AS
declare @max_BatchID varchar(11),
		@seq int,
		@iSeq int

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- gen location and company inforamtion here  BatchID Sample: R1406050003
    --select top 1 @max_BatchID = Batch_ID from plr_mstr order by Batch_ID desc,plr_cre_date desc
    --select top 1 @max_BatchID =  batch_id from [dbo].[plr_batch_mstr] order by batch_id desc, batch_cre_date desc
    select top 1 @seq = ctl_curr from dbo.pkey_ctl where t_name='plr_batch_mstr' and t_value ='batch_id'
    if @seq is null 
    begin
		insert dbo.pkey_ctl (t_name,t_value,ctl_curr) values ('plr_batch_mstr','batch_id',1)
		set @BatchID = 'R' + right(convert(char(4),YEAR(GETDATE())),2) + cast( Right(100+Month(GetDate()),2) as char(2)) + cast( Right(100+Day(GetDate()),2)   as char(2)) + '0001'
    end
    else
    begin
		set @seq =@seq + 1
		update dbo.pkey_ctl set ctl_curr=@seq where  t_name='plr_batch_mstr' and t_value ='batch_id'
		--select REPLICATE('0',4-len(cast(1 as varchar(4))))+cast(1 as varchar(4))
		set @BatchID = 'R' + right(convert(char(4),YEAR(GETDATE())),2) + cast( Right(100+Month(GetDate()),2) as char(2)) + cast( Right(100+Day(GetDate()),2)   as char(2))  + REPLICATE('0',4-len(cast(@seq as varchar(4))))+cast(@seq as varchar(4))
	end
	
    return
END

GO
/****** Object:  Table [dbo].[Irh_comp]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Irh_comp](
	[Irh_Sys] [char](10) NOT NULL,
	[Irh_Prefix] [char](3) NOT NULL,
	[Irh_Comp] [char](10) NOT NULL,
	[Irh_connection] [varchar](10) NULL,
	[Irh_inServer] [nvarchar](50) NULL,
 CONSTRAINT [PK_Irh_comp] PRIMARY KEY CLUSTERED 
(
	[Irh_Sys] ASC,
	[Irh_Prefix] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OCR_mstr]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OCR_mstr](
	[Ocr_BatchID] [varchar](20) NOT NULL,
	[Ocr_PackinglistID] [varchar](30) NULL,
	[Ocr_vend] [char](20) NULL,
	[Ocr_doc_no] [varchar](20) NULL,
	[Ocr_rcp_date] [date] NULL,
	[Ocr_lineID] [char](6) NOT NULL,
	[Ocr_ctnID] [varchar](30) NULL,
	[Ocr_partno] [varchar](30) NULL,
	[Ocr_po] [varchar](30) NULL,
	[Ocr_custpart] [varchar](30) NULL,
	[Ocr_qty] [varchar](50) NULL,
	[Ocr_nw] [varchar](50) NULL,
	[Ocr_gw] [varchar](50) NULL,
	[Ocr_ref_no] [varchar](20) NULL,
	[Ocr_ref_no1] [varchar](1) NOT NULL,
	[Ocr_TTL] [int] NULL,
	[Ocr_unitprice] [numeric](10, 4) NULL,
	[Ocr_status] [char](10) NULL,
	[Ocr_cre_date] [datetime] NULL,
	[Ocr_cre_user] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pkey_ctl]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pkey_ctl](
	[t_name] [nvarchar](50) NOT NULL,
	[t_value] [nvarchar](50) NOT NULL,
	[t_desc] [nvarchar](4000) NULL,
	[t_yyww] [nvarchar](50) NULL,
	[prefix] [nvarchar](50) NULL,
	[ctl_fro] [decimal](18, 0) NULL,
	[ctl_to] [decimal](18, 0) NULL,
	[ctl_curr] [decimal](18, 0) NULL,
	[ctl_curr_len] [decimal](18, 0) NULL,
	[ctl_len] [decimal](18, 0) NULL,
 CONSTRAINT [PK_pkey_ctl_1] PRIMARY KEY CLUSTERED 
(
	[t_name] ASC,
	[t_value] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[plr_batch_mstr]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[plr_batch_mstr](
	[batch_id] [nvarchar](50) NOT NULL,
	[plr_suppliers_id] [nvarchar](50) NULL,
	[batch_doc] [nvarchar](50) NULL,
	[batch_status] [nvarchar](50) NULL,
	[batch_void] [smallint] NULL,
	[batch_cre_date] [datetime] NULL,
	[batch_update_date] [datetime] NULL,
	[batch_cre_user] [nvarchar](50) NULL,
	[batch_user_ip] [nvarchar](50) NULL,
	[batch_chr01] [nvarchar](50) NULL,
	[batch_dec01] [decimal](18, 0) NULL,
 CONSTRAINT [PK_plr_batch_mstr] PRIMARY KEY CLUSTERED 
(
	[batch_id] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[plr_mstr]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[plr_mstr](
	[Batch_ID] [nvarchar](50) NOT NULL,
	[LineID] [int] NOT NULL,
	[plr_suppliers_id] [nvarchar](50) NULL,
	[InvoiceID] [varchar](30) NULL,
	[plr_po] [varchar](30) NULL,
	[packingListID] [varchar](30) NULL,
	[plr_partno] [varchar](30) NULL,
	[plr_carton_qty] [decimal](18, 0) NULL,
	[plr_qty] [decimal](18, 0) NULL,
	[CartonType] [nvarchar](50) NULL,
	[CartonID] [nvarchar](50) NOT NULL,
	[plr_rcp_date] [date] NULL,
	[plr_deli_date] [date] NULL,
	[carton_id_prifix] [nvarchar](50) NULL,
	[carton_id_from] [decimal](18, 0) NULL,
	[carton_id_to] [decimal](18, 0) NULL,
	[re_mark] [text] NULL,
	[plr_site] [nvarchar](50) NULL,
	[plr_pallet_no] [varchar](10) NULL,
	[plr_co] [nvarchar](50) NULL,
	[plr_date_code] [nvarchar](50) NULL,
	[plr_vend_mfgr] [varchar](30) NULL,
	[Plr_vm_partno] [varchar](30) NULL,
	[plr_doc_type] [nvarchar](50) NULL,
	[plr_ttl] [int] NULL,
	[plr_um] [char](5) NULL,
	[plr_nw] [varchar](50) NULL,
	[plr_gw] [varchar](50) NULL,
	[plr_um_w] [char](4) NULL,
	[Plr_unitprice] [decimal](10, 4) NULL,
	[plr_msm] [varchar](50) NULL,
	[plr_doc_no1] [varchar](30) NULL,
	[plr_status] [nvarchar](50) NULL,
	[plr_cre_date] [datetime] NULL,
	[plr_cre_userid] [nvarchar](50) NULL,
	[plr_update_date] [datetime] NULL,
	[plr_edituser_id] [nvarchar](50) NULL,
	[plr_user_ip] [nvarchar](50) NULL,
	[plr_void_status] [smallint] NULL,
	[plr_chr01] [nvarchar](50) NULL,
	[plr_chr02] [nvarchar](50) NULL,
	[plr_deci1] [int] NULL,
	[plr_deci2] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Plr_mstr] PRIMARY KEY CLUSTERED 
(
	[Batch_ID] DESC,
	[LineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[plr_mstr_err]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[plr_mstr_err](
	[Batch_ID] [varchar](20) NOT NULL,
	[LineID] [int] NOT NULL,
	[plr_doc_type] [nvarchar](50) NULL,
	[plr_po] [nvarchar](30) NULL,
	[plr_partno] [nvarchar](30) NULL,
	[plr_qty] [decimal](18, 0) NULL,
	[plr_err_msg] [text] NULL,
	[plr_cre_date] [datetime] NULL,
	[plr_cre_userid] [nvarchar](50) NULL,
	[plr_update_date] [datetime] NULL,
	[plr_edituser_id] [nvarchar](50) NULL,
	[plr_user_ip] [nvarchar](50) NULL,
	[plr_void_status] [smallint] NULL,
	[plr_chr01] [nvarchar](50) NULL,
	[plr_chr02] [nvarchar](50) NULL,
	[plr_deci1] [int] NULL,
	[plr_deci2] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Plr_mstr_err_msg] PRIMARY KEY CLUSTERED 
(
	[Batch_ID] DESC,
	[LineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[plr_mstr_log]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[plr_mstr_log](
	[Batch_ID] [varchar](20) NOT NULL,
	[LineID] [int] NOT NULL,
	[Wec_Ctn] [int] NOT NULL,
	[CartonNo] [int] NOT NULL,
	[plr_wec_ctn] [nvarchar](50) NULL,
	[CartonID] [nvarchar](50) NOT NULL,
	[CartonType] [nvarchar](50) NULL,
	[packingListID] [varchar](30) NULL,
	[InvoiceID] [varchar](30) NULL,
	[plr_site] [nvarchar](50) NULL,
	[plr_pallet_no] [nchar](10) NULL,
	[plr_po] [varchar](30) NULL,
	[plr_co] [nvarchar](50) NULL,
	[plr_partno] [varchar](30) NOT NULL,
	[plr_date_code] [nvarchar](50) NULL,
	[plr_vend_mfgr] [varchar](30) NULL,
	[Plr_vm_partno] [varchar](30) NULL,
	[plr_qty] [decimal](18, 0) NULL,
	[plr_rcp_date] [date] NULL,
	[plr_deli_date] [date] NULL,
	[carton_id_prifix] [nvarchar](50) NULL,
	[plr_status] [char](10) NULL,
	[plr_cre_date] [datetime] NULL,
	[plr_cre_userid] [nvarchar](50) NULL,
	[plr_update_date] [datetime] NULL,
	[plr_edituser_id] [nvarchar](50) NULL,
	[plr_user_ip] [nvarchar](50) NULL,
	[plr_void_status] [smallint] NULL,
	[plr_chr01] [nvarchar](50) NULL,
	[plr_chr02] [nvarchar](50) NULL,
	[plr_deci1] [int] NULL,
	[plr_deci2] [decimal](18, 0) NULL,
 CONSTRAINT [PK_plr_mstr_log] PRIMARY KEY CLUSTERED 
(
	[Batch_ID] DESC,
	[LineID] ASC,
	[Wec_Ctn] ASC,
	[plr_partno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[plr_mstr_tran]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[plr_mstr_tran](
	[Batch_ID] [nvarchar](50) NOT NULL,
	[LineID] [int] NOT NULL,
	[Wec_Ctn] [int] NOT NULL,
	[plr_status] [nvarchar](50) NULL,
	[plr_status_msg] [nvarchar](4000) NULL,
	[CartonNo] [nvarchar](50) NOT NULL,
	[CartonID] [nvarchar](50) NOT NULL,
	[plr_wec_ctn] [nvarchar](50) NULL,
	[plr_po] [varchar](30) NULL,
	[plr_partno] [varchar](30) NOT NULL,
	[CartonType] [nvarchar](50) NULL,
	[plr_carton_qty] [decimal](18, 0) NULL,
	[plr_qty] [decimal](18, 0) NULL,
	[plr_suppliers_id] [nvarchar](50) NULL,
	[packingListID] [varchar](30) NULL,
	[InvoiceID] [varchar](30) NULL,
	[plr_rcp_date] [date] NULL,
	[plr_pallet_no] [nvarchar](10) NULL,
	[plr_deli_date] [date] NULL,
	[plr_site] [nvarchar](50) NULL,
	[plr_co] [nvarchar](50) NULL,
	[plr_date_code] [nvarchar](50) NULL,
	[plr_vend_mfgr] [varchar](30) NULL,
	[Plr_vm_partno] [varchar](30) NULL,
	[carton_id_prifix] [nvarchar](50) NULL,
	[re_mark] [text] NULL,
	[plr_cre_date] [datetime] NULL,
	[plr_cre_userid] [nvarchar](50) NULL,
	[plr_update_date] [datetime] NULL,
	[plr_edituser_id] [nvarchar](50) NULL,
	[plr_user_ip] [nvarchar](50) NULL,
	[plr_void_status] [smallint] NULL,
	[plr_chr01] [nvarchar](50) NULL,
	[plr_chr02] [nvarchar](50) NULL,
	[plr_deci1] [int] NULL,
	[plr_deci2] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Plr_mstr_tran] PRIMARY KEY CLUSTERED 
(
	[Batch_ID] DESC,
	[LineID] ASC,
	[Wec_Ctn] ASC,
	[plr_partno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sys_role]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_role](
	[role_id] [int] NOT NULL,
	[role_name] [nvarchar](50) NOT NULL,
	[role_desc] [nvarchar](100) NULL,
	[update_time] [datetime] NULL,
	[create_time] [datetime] NULL,
	[create_user_id] [nvarchar](50) NULL,
	[update_user_id] [nvarchar](50) NULL,
	[client_ip] [nvarchar](100) NULL,
	[re_mark] [text] NULL,
	[flag_status] [nvarchar](10) NULL,
 CONSTRAINT [PK_system_role] PRIMARY KEY CLUSTERED 
(
	[role_id] DESC,
	[role_name] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sys_user]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_user](
	[user_name] [nvarchar](50) NOT NULL,
	[user_comp] [nvarchar](50) NOT NULL,
	[user_password] [nvarchar](50) NULL,
	[user_email] [nvarchar](150) NULL,
	[user_desc] [nvarchar](100) NULL,
	[update_time] [datetime] NULL,
	[create_time] [datetime] NULL,
	[create_user_id] [nvarchar](50) NULL,
	[update_user_id] [nvarchar](50) NULL,
	[client_ip] [nvarchar](100) NULL,
	[re_mark] [text] NULL,
	[flag_status] [nvarchar](10) NULL,
 CONSTRAINT [PK_system_user] PRIMARY KEY CLUSTERED 
(
	[user_name] ASC,
	[user_comp] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sys_userInrole]    Script Date: 2014-08-23 23:22:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_userInrole](
	[user_name] [nvarchar](50) NOT NULL,
	[role_id] [int] NOT NULL,
	[update_time] [datetime] NULL,
	[create_time] [datetime] NULL,
	[create_user_id] [nvarchar](50) NULL,
	[update_user_id] [nvarchar](50) NULL,
	[client_ip] [nvarchar](100) NULL,
	[re_mark] [text] NULL,
	[flag_status] [nvarchar](10) NULL,
 CONSTRAINT [PK_system_userInrole] PRIMARY KEY CLUSTERED 
(
	[user_name] DESC,
	[role_id] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'LUOWU     ', N'L  ', N'LUOWU     ', NULL, NULL)
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'NW        ', N'5  ', N'NW        ', NULL, NULL)
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'NW        ', N'V5 ', N'NW        ', NULL, NULL)
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'NW        ', N'VT5', N'NW        ', NULL, NULL)
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'1  ', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'2  ', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'F0 ', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'FL0', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'FW ', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'K  ', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'M0 ', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'V0 ', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'VT0', N'WEC       ', NULL, N'P1')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WELLOP    ', N'3  ', N'WELLOP    ', NULL, N'TESTOLDWEC')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WELLOP    ', N'VT3', N'WELLOP    ', NULL, N'TESTOLDWEC')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'90 ', N'WTSZ      ', NULL, N'TESTOLDWEC')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'M0 ', N'WTSZ      ', NULL, N'TESTOLDWEC')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'M3 ', N'WTSZ      ', NULL, N'TESTOLDWEC')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'T  ', N'WTSZ      ', NULL, N'TESTOLDWEC')
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'V0 ', N'WTSZ      ', NULL, N'TESTOLDWEC')
GO
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'LogonDomain', N'WEC', N'LDAP://149.3.2.3/OU=WEC,DC=wongswec,DC=com', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'LogonDomain', N'WTSZ', N'LDAP://10.10.11.208/OU=wtszuser,DC=wongswtsz,DC=com', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'LogonDomain', N'WWTS', N'LDAP://142.2.70.25/OU=ShaJin,DC=wongs-sj,DC=com', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'plr_batch_mstr', N'batch_id', NULL, NULL, NULL, NULL, NULL, CAST(0 AS Decimal(18, 0)), NULL, NULL)
GO
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'Plr_mstr_tran', N'Wec_Ctn', NULL, NULL, NULL, NULL, NULL, CAST(0 AS Decimal(18, 0)), NULL, NULL)
GO
INSERT [dbo].[sys_role] ([role_id], [role_name], [role_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (3, N'newuser', N'New User', CAST(0x0000A38C00A7B5FF AS DateTime), CAST(0x0000A38C00A7B5FF AS DateTime), N'ling.xie', N'ling.xie', N'142.2.47.149', NULL, NULL)
GO
INSERT [dbo].[sys_role] ([role_id], [role_name], [role_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (2, N'packing', N'Packing', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_role] ([role_id], [role_name], [role_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (1, N'admin', N'administrator', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'cm.li', N'WWTS', N'EEC5F9373F95CC4F21D334C5A23CFB22', N'', N'', CAST(0x0000A38D010C4F2E AS DateTime), CAST(0x0000A38D01095EC4 AS DateTime), N'', N'', N'142.2.64.111', N'', N'T')
GO
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'demo', N'WWTS', N'87EC83741750EE520A044896A28B4DB5', N'', N'', CAST(0x0000A390017FDB6D AS DateTime), CAST(0x0000A38E00A2123C AS DateTime), N'', N'', N'142.2.47.149', N'169.254.227.242', N'T')
GO
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'gx.li', N'WWTS', N'6F27AFF1C4FEDAD2CB6B439DA4DE9A56', N'', N'', CAST(0x0000A38D01044160 AS DateTime), CAST(0x0000A38D0103A844 AS DateTime), N'', N'', N'142.2.64.22', N'', N'T')
GO
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'ling.xie', N'WWTS', N'681B03E018CB2B9CFEA8F119BA936A7C36D150E54B782C76', N'', N'', CAST(0x0000A38E00A5FBCA AS DateTime), CAST(0x0000A38C01295BD4 AS DateTime), N'', N'', N'142.2.47.149', N'142.2.47.149', N'T')
GO
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'wz.wu', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'michael.tai', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'ling.xie', 1, CAST(0x0000A38C01295C55 AS DateTime), CAST(0x0000A38C01295C55 AS DateTime), N'ling.xie', NULL, N'142.2.47.149', NULL, N'T')
GO
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'gx.li', 2, CAST(0x0000A38D0103A952 AS DateTime), CAST(0x0000A38D0103A953 AS DateTime), N'gx.li', NULL, N'142.2.64.22', NULL, N'T')
GO
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'eddie.ehan', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'demo', 2, CAST(0x0000A38E00AD2ADF AS DateTime), CAST(0x0000A38E00AD2ADF AS DateTime), NULL, NULL, N'142.2.47.149', NULL, NULL)
GO
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'cm.li', 2, CAST(0x0000A38D01096039 AS DateTime), CAST(0x0000A38D01096039 AS DateTime), N'cm.li', NULL, N'142.2.64.111', NULL, N'T')
GO
ALTER TABLE [dbo].[plr_batch_mstr] ADD  CONSTRAINT [DF_plr_batch_mstr_Batch_void]  DEFAULT ((1)) FOR [batch_void]
GO
ALTER TABLE [dbo].[plr_mstr] ADD  CONSTRAINT [DF_Plr_mstr_plr_void_status]  DEFAULT ((1)) FOR [plr_void_status]
GO
ALTER TABLE [dbo].[plr_mstr_err] ADD  CONSTRAINT [DF_Plr_mstr_err_plr_void_status]  DEFAULT ((1)) FOR [plr_void_status]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Void Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_batch_mstr', @level2type=N'COLUMN',@level2name=N'batch_status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Suppliets ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_suppliers_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PO#' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_po'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Part' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_partno'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Carton Qty' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_carton_qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QTY' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Number Carton' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'CartonType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Rec Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_rcp_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Deli Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_deli_date'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Carton Prifix' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'carton_id_prifix'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Carton ID From' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'carton_id_from'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'TO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'carton_id_to'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ReMark' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N're_mark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Void Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_status'
GO
