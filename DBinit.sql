USE [PIE]
GO
/****** Object:  Table [dbo].[plr_mstr_tran]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[plr_mstr_log]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[plr_mstr_err]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[plr_mstr]    Script Date: 09/05/2014 17:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[plr_mstr](
	[Batch_ID] [nvarchar](50) NOT NULL,
	[LineID] [int] NOT NULL,
	[plr_status] [nvarchar](50) NULL,
	[packingListID] [varchar](30) NULL,
	[InvoiceID] [varchar](30) NULL,
	[plr_pallet_no] [varchar](10) NULL,
	[CartonType] [nvarchar](50) NULL,
	[CartonID] [nvarchar](50) NOT NULL,
	[plr_po] [varchar](30) NULL,
	[plr_co] [nvarchar](50) NULL,
	[plr_partno] [varchar](30) NULL,
	[plr_date_code] [nvarchar](50) NULL,
	[plr_vend_mfgr] [varchar](30) NULL,
	[Plr_vm_partno] [varchar](30) NULL,
	[plr_carton_qty] [decimal](18, 0) NULL,
	[plr_qty] [decimal](18, 0) NULL,
	[plr_rcp_date] [date] NULL,
	[plr_deli_date] [date] NULL,
	[carton_id_prifix] [nvarchar](50) NULL,
	[carton_id_from] [decimal](18, 0) NULL,
	[carton_id_to] [decimal](18, 0) NULL,
	[plr_doc_type] [nvarchar](50) NULL,
	[re_mark] [text] NULL,
	[plr_suppliers_id] [nvarchar](50) NULL,
	[plr_site] [nvarchar](50) NULL,
	[plr_ttl] [int] NULL,
	[plr_um] [char](5) NULL,
	[plr_nw] [varchar](50) NULL,
	[plr_gw] [varchar](50) NULL,
	[plr_um_w] [char](4) NULL,
	[Plr_unitprice] [decimal](10, 4) NULL,
	[plr_msm] [varchar](50) NULL,
	[plr_doc_no1] [varchar](30) NULL,
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Void Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Number Carton' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'CartonType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PO#' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_po'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Part' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_partno'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Carton Qty' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_carton_qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QTY' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_qty'
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
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Suppliets ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_mstr', @level2type=N'COLUMN',@level2name=N'plr_suppliers_id'
GO
/****** Object:  Table [dbo].[plr_batch_mstr]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Void Status' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'plr_batch_mstr', @level2type=N'COLUMN',@level2name=N'batch_status'
GO
/****** Object:  Table [dbo].[pkey_ctl]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'0', N'台灣', N'143', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'0H', N'香港', N'110', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'1', N'中國', N'142', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'11', N'匈牙利', N'321', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'13', N'巴西', N'410', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'1E', N'英國', N'303', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'2', N'香港', N'110', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'22', N'西班牙', N'312', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'2J', N'日本', N'116', N'1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'3', N'馬來西亞', N'122', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'33', N'德國', N'304', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'4', N'泰國', N'136', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'5', N'美國', N'502', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'6', N'菲律賓', N'129', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'7', N'印尼', N'112', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'8', N'韓國', N'133', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'9', N'星加坡', N'132', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'A', N'澳地利', N'315', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'at', N'澳地利', N'315', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'AUST', N'澳洲', N'601', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'AUSTRIA', N'澳地利', N'315', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'B', N'英國', N'303', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BANG', N'孟加拉', NULL, N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BANGLADESH', N'孟加拉', NULL, N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BAR', N'巴巴多斯', N'405', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BELG', N'比利時', N'301', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BELGIUM', N'比利時', N'301', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BRAZIL', N'巴西', N'410', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BRITAIN', N'英國', N'303', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BU', N'保加利亞', N'316', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'BULGARIA', N'保加利亞', N'316', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'C', N'加拿大', N'501', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CC', N'克羅地亞', N'351', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CE', N'捷克', N'352', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CHINA', N'中國', N'142', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CN', N'中國', N'142', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'COST', N'哥斯達尼加', N'415', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CR', N'哥斯達尼加', N'415', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CRO', N'克羅地亞', N'351', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CROATIA', N'克羅地亞', N'351', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CZ', N'捷克', N'352', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'CZECH', N'捷克', N'352', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'D', N'墨西哥', N'429', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'DE', N'德國', N'304', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'DENMARK', N'丹麥', N'302', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'DK', N'丹麥', N'302', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'E', N'美國', N'502', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'ENGLAND', N'英國', N'303', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'ESTONIA', N'愛沙尼亞', N'334', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'F', N'法國', N'305', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'FC', N'法國', N'305', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'FD', N'芬蘭', N'318', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'FI', N'芬蘭', N'318', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'FINL', N'芬蘭', N'318', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'FINLAND', N'芬蘭', N'318', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'FRANCE', N'法國', N'305', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'GB', N'英國', N'303', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'GER', N'德國', N'304', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'Germany', N'德國', N'304', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'GREECE', N'希臘', N'310', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'H', N'香港', N'110', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'HOL', N'荷蘭', N'309', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'HOLL', N'荷蘭', N'309', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'HOLLAND', N'荷蘭', N'309', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'HOND', N'洪都拉斯', NULL, N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'HR', N'匈牙利', N'321', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'HU', N'匈牙利', N'321', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'HUNG', N'匈牙利', N'321', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'HUNGARY', N'匈牙利 ', N'321', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'I', N'意大利', N'307', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'ID', N'印尼', N'112', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'IE', N'愛爾蘭', N'306', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'IL', N'以色列', N'115', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'INA', N'印度', N'111', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'INDO', N'印尼', N'112', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'IRE', N'愛爾蘭', N'306', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'IRELAND', N'愛爾蘭', N'306', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'ISR', N'以色列', N'115', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'ITALY', N'意大利', N'307', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'J', N'日本', N'116', N'1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'KOR', N'韓國', N'133', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'korea', N'韓國', N'133', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'L', N'比利時', N'301', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'LIECH', N'列支敦斯登', N'323', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'LUXEMBURG', N'盧森堡', N'308', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'M', N'摩洛哥', N'232', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MA', N'馬爾他', N'324', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MAC', N'澳門', N'121', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MACEDONIA', N'馬其頓', NULL, N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MEX', N'墨西哥', N'429', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MO', N'摩洛哥', N'232', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MOR', N'摩洛哥', N'232', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MORO', N'摩洛哥', N'232', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MX', N'墨西哥', N'429', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'MY', N'馬來西亞', N'122', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'N', N'巴西', N'410', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'NETH', N'荷蘭', N'309', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'NEW', N'新西蘭', N'609', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'NEWZ', N'新西蘭', N'609', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'NL', N'荷蘭', N'309', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'NORW', N'挪威', N'326', N'0', NULL, NULL, NULL, NULL, NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'NORWAY', N'挪威 ', N'326', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'P', N'菲律賓', N'129', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'PA', N'巴拿馬', N'432', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'PANAMA', N'巴拿馬', N'432', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'PH', N'菲律賓', N'129', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'PL', N'波蘭', N'327', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'POL', N'波蘭', N'327', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'PORT', N'葡萄牙', N'311', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'PORTUGAL', N'葡萄牙', N'311', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'PT', N'葡萄牙', N'311', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'Q', N'中國', N'142', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'RI', N'米蘭', N'307', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'RICO', N'波多黎各', N'435', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'S', N'星加坡', N'132', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SAL', N'薩爾瓦多', N'440', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SCOT', N'蘇格蘭', N'303', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SENEGAL', N'塞內加爾', NULL, N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SG', N'星加坡', N'132', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SK', N'韓國', N'133', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SL', N'斯洛文尼亞', N'350', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SLO', N'斯洛伐克', N'353', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SP', N'南非', N'244', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SPA', N'西班牙', N'312', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SPAIN', N'西班牙', N'312', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SRI', N'斯里蘭卡', N'134', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SRI LANKA', N'斯里蘭卡', N'134', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'st lucia', N'聖盧西亞', N'437', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SV', N'薩爾瓦多', N'440', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SWED', N'瑞典', N'330', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SWEDEN', N'瑞典', N'330', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SWI', N'瑞士', N'331', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'SWIT', N'瑞士', N'331', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'T', N'台灣', N'143', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'TW', N'台灣', N'143', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'U', N'捷克', N'352', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'UK', N'英國', N'303', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'US', N'美國', N'502', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'V', N'越南', N'141', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'VIE', N'越南', N'141', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'VIETNAM', N'越南', N'141', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'X', N'印尼', N'112', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'co', N'Z', N'捷克', N'352', N'0', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'LogonDomain', N'WEC', N'LDAP://149.3.2.3/OU=WEC,DC=wongswec,DC=com', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'LogonDomain', N'WTSZ', N'LDAP://10.10.11.208/OU=wtszuser,DC=wongswtsz,DC=com', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'LogonDomain', N'WWTS', N'LDAP://142.2.70.25/OU=ShaJin,DC=wongs-sj,DC=com', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'pi_mstr', N'pi_id', NULL, NULL, NULL, NULL, NULL, CAST(0 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'plr_batch_mstr', N'batch_id', NULL, NULL, NULL, NULL, NULL, CAST(0 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'Plr_mstr_tran', N'Wec_Ctn', NULL, NULL, NULL, NULL, NULL, CAST(0 AS Decimal(18, 0)), NULL, NULL)
/****** Object:  Table [dbo].[pisr_grr]    Script Date: 09/05/2014 17:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pisr_grr](
	[pi_wec_ctn] [nvarchar](50) NOT NULL,
	[plr_LineID_tran] [int] NOT NULL,
	[Plant] [nvarchar](50) NOT NULL,
	[pisr_rir] [nvarchar](50) NULL,
	[pisr_invoice] [nvarchar](50) NULL,
	[pisr_part] [nvarchar](50) NULL,
	[Pisr_receiver] [nvarchar](50) NULL,
	[pisr_site] [nvarchar](50) NULL,
	[pisr_po_nbr] [nvarchar](50) NULL,
	[pisr_qty] [decimal](18, 0) NULL,
	[pisr_curr] [nvarchar](50) NULL,
	[pisr_cost] [decimal](18, 0) NULL,
	[pisr_base_cost] [decimal](18, 0) NULL,
	[pisr_us_cost] [decimal](18, 0) NULL,
	[pisr_seq] [nvarchar](50) NULL,
	[pisr_con_code] [nvarchar](50) NULL,
	[pisr_ch_desc] [nvarchar](50) NULL,
	[pisr_net_wt] [decimal](18, 0) NULL,
	[pisr_rec_type] [nvarchar](50) NULL,
	[pisr_abc] [nvarchar](50) NULL,
	[pisr_code] [nvarchar](50) NULL,
	[pisr_lic_req] [nvarchar](50) NULL,
	[pi_status] [nvarchar](50) NULL,
	[pi_status_msg] [nvarchar](4000) NULL,
	[pi_remark] [text] NULL,
	[pi_cre_date] [datetime] NULL,
	[pi_cre_userid] [nvarchar](50) NULL,
	[pi_update_date] [datetime] NULL,
	[pi_edituser_id] [nvarchar](50) NULL,
	[pi_user_ip] [nvarchar](50) NULL,
	[pi_void_status] [smallint] NULL,
	[pi_chr01] [nvarchar](50) NULL,
	[pi_chr02] [nvarchar](50) NULL,
	[pi_deci1] [int] NULL,
	[pi_deci2] [decimal](18, 0) NULL,
 CONSTRAINT [PK_pisr_grr_1] PRIMARY KEY CLUSTERED 
(
	[pi_wec_ctn] ASC,
	[plr_LineID_tran] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000100', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011BA9F8 AS DateTime), NULL, CAST(0x0000A39C011BA9F8 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000101', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB3F AS DateTime), NULL, CAST(0x0000A39C011CFB3F AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000102', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB4D AS DateTime), NULL, CAST(0x0000A39C011CFB4D AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000103', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB58 AS DateTime), NULL, CAST(0x0000A39C011CFB58 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000104', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB63 AS DateTime), NULL, CAST(0x0000A39C011CFB63 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000105', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB6E AS DateTime), NULL, CAST(0x0000A39C011CFB6E AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000106', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB79 AS DateTime), NULL, CAST(0x0000A39C011CFB79 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000107', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB88 AS DateTime), NULL, CAST(0x0000A39C011CFB88 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000108', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB92 AS DateTime), NULL, CAST(0x0000A39C011CFB92 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000109', 1, N'0', N'B1409040007', N'140902001', N'30974081-01R1F', N'R5898231', N'mg7024', N'10722059', CAST(10000 AS Decimal(18, 0)), N'usd', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011CFB9D AS DateTime), NULL, CAST(0x0000A39C011CFB9D AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000112', 4, N'0', N'B1409040006', N'140902001', N'31965110R1F', N'R5898230', N'MG7024', N'10719162', CAST(2500 AS Decimal(18, 0)), N'USD', NULL, CAST(9 AS Decimal(18, 0)), CAST(9 AS Decimal(18, 0)), N'159', N'TTL003', N'úÔ¤ðÈÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'IQC', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011DB4EF AS DateTime), NULL, CAST(0x0000A39C011DB4EF AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'200000000113', 5, N'0', N'B1409040008', N'140902001', N'31203243R2F', N'R5898232', N'mg5007', N'22051998', CAST(16000 AS Decimal(18, 0)), N'USD', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'157', N'TTL003', N'úÔ¤ðÈÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011DB4FA AS DateTime), NULL, CAST(0x0000A39C011DB4FA AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'V00000000110', 2, N'0', N'B1409040010', N'140902001', N'30974125-00R2F', N'R5898234', N'mg7024', N'V0016837', CAST(4000 AS Decimal(18, 0)), N'usd', NULL, CAST(1 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'139', N'TTL002', N'ªÝÏÍã²ÎÍ¢ÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011DB504 AS DateTime), NULL, CAST(0x0000A39C011DB504 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'V00000000111', 3, N'0', N'B1409040011', N'140902001', N'31943141R1F', N'R5898235', N'MG7024', N'V0016839', CAST(2500 AS Decimal(18, 0)), N'USD', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'157', N'TTL003', N'úÔ¤ðÈÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011DB50E AS DateTime), NULL, CAST(0x0000A39C011DB50E AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'V00000000114', 6, N'0', N'B1409040009', N'140902001', N'31143180R3F', N'R5898233', N'mg5007', N'V0016755', CAST(36000 AS Decimal(18, 0)), N'USD', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'157', N'TTL003', N'úÔ¤ðÈÁÑã¼»ÁþÀ', CAST(0 AS Decimal(18, 0)), N'STS', N'A', N'No', N'', NULL, NULL, NULL, CAST(0x0000A39C011DB518 AS DateTime), NULL, CAST(0x0000A39C011DB518 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[pi_mstr]    Script Date: 09/05/2014 17:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pi_mstr](
	[PI_ID] [nvarchar](50) NOT NULL,
	[LineID] [int] NOT NULL,
	[Plant] [nvarchar](50) NOT NULL,
	[pi_type] [nvarchar](50) NOT NULL,
	[pi_status] [nvarchar](50) NULL,
	[pi_status_msg] [nvarchar](4000) NULL,
	[pi_remark] [text] NULL,
	[pi_cre_date] [datetime] NULL,
	[pi_cre_userid] [nvarchar](50) NULL,
	[pi_update_date] [datetime] NULL,
	[pi_edituser_id] [nvarchar](50) NULL,
	[pi_user_ip] [nvarchar](50) NULL,
	[pi_void_status] [smallint] NULL,
	[pi_chr01] [nvarchar](50) NULL,
	[pi_chr02] [nvarchar](50) NULL,
	[pi_deci1] [int] NULL,
	[pi_deci2] [decimal](18, 0) NULL,
 CONSTRAINT [PK_pi_mstr] PRIMARY KEY CLUSTERED 
(
	[PI_ID] DESC,
	[LineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pi_det]    Script Date: 09/05/2014 17:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pi_det](
	[PI_ID] [nvarchar](50) NOT NULL,
	[pi_LineID] [int] NOT NULL,
	[pi_wec_ctn] [nvarchar](50) NOT NULL,
	[plr_LineID_tran] [int] NOT NULL,
	[pi_pallet_no] [nvarchar](10) NULL,
	[CartonNo] [nvarchar](50) NOT NULL,
	[CartonID] [nvarchar](50) NULL,
	[pi_type] [nvarchar](50) NOT NULL,
	[pi_status] [nvarchar](50) NULL,
	[pi_status_msg] [nvarchar](4000) NULL,
	[pi_remark] [text] NULL,
	[pi_cre_date] [datetime] NULL,
	[pi_cre_userid] [nvarchar](50) NULL,
	[pi_update_date] [datetime] NULL,
	[pi_edituser_id] [nvarchar](50) NULL,
	[pi_user_ip] [nvarchar](50) NULL,
	[pi_void_status] [smallint] NULL,
	[pi_chr01] [nvarchar](50) NULL,
	[pi_chr02] [nvarchar](50) NULL,
	[pi_deci1] [int] NULL,
	[pi_deci2] [decimal](18, 0) NULL,
 CONSTRAINT [PK_pi_det_tran] PRIMARY KEY CLUSTERED 
(
	[PI_ID] DESC,
	[pi_LineID] ASC,
	[pi_wec_ctn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OCR_mstr]    Script Date: 09/05/2014 17:45:07 ******/
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
/****** Object:  Table [dbo].[Irh_comp]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'LUOWU     ', N'L  ', N'LUOWU     ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'NW        ', N'5  ', N'NW        ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'NW        ', N'V5 ', N'NW        ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'NW        ', N'VT5', N'NW        ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'1  ', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'2  ', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'F0 ', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'FL0', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'FW ', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'K  ', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'M0 ', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'V0 ', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WEC       ', N'VT0', N'WEC       ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WELLOP    ', N'3  ', N'WELLOP    ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WELLOP    ', N'VT3', N'WELLOP    ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'90 ', N'WTSZ      ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'M1 ', N'WTSZ      ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'M3 ', N'WTSZ      ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'T  ', N'WTSZ      ', NULL, N'P1')
INSERT [dbo].[Irh_comp] ([Irh_Sys], [Irh_Prefix], [Irh_Comp], [Irh_connection], [Irh_inServer]) VALUES (N'WTSZ      ', N'V0 ', N'WTSZ      ', NULL, N'P1')
/****** Object:  Table [dbo].[sys_userInrole]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'wz.wu', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'michael.tai', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'ling.xie', 1, CAST(0x0000A38C01295C55 AS DateTime), CAST(0x0000A38C01295C55 AS DateTime), N'ling.xie', NULL, N'142.2.47.149', NULL, N'T')
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'gx.li', 2, CAST(0x0000A38D0103A952 AS DateTime), CAST(0x0000A38D0103A953 AS DateTime), N'gx.li', NULL, N'142.2.64.22', NULL, N'T')
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'eddie.ehan', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'demo', 2, CAST(0x0000A38E00AD2ADF AS DateTime), CAST(0x0000A38E00AD2ADF AS DateTime), NULL, NULL, N'142.2.47.149', NULL, NULL)
INSERT [dbo].[sys_userInrole] ([user_name], [role_id], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'cm.li', 2, CAST(0x0000A38D01096039 AS DateTime), CAST(0x0000A38D01096039 AS DateTime), N'cm.li', NULL, N'142.2.64.111', NULL, N'T')
/****** Object:  Table [dbo].[sys_user]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'cm.li', N'WWTS', N'EEC5F9373F95CC4F21D334C5A23CFB22', N'', N'', CAST(0x0000A38D010C4F2E AS DateTime), CAST(0x0000A38D01095EC4 AS DateTime), N'', N'', N'142.2.64.111', N'', N'T')
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'demo', N'WWTS', N'87EC83741750EE520A044896A28B4DB5', N'', N'', CAST(0x0000A39D01241062 AS DateTime), CAST(0x0000A38E00A2123C AS DateTime), N'', N'', N'142.2.47.149', N'142.2.47.149', N'T')
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'gx.li', N'WWTS', N'6F27AFF1C4FEDAD2CB6B439DA4DE9A56', N'', N'', CAST(0x0000A38D01044160 AS DateTime), CAST(0x0000A38D0103A844 AS DateTime), N'', N'', N'142.2.64.22', N'', N'T')
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'ling.xie', N'WWTS', N'681B03E018CB2B9CFEA8F119BA936A7C36D150E54B782C76', N'', N'', CAST(0x0000A38E00A5FBCA AS DateTime), CAST(0x0000A38C01295BD4 AS DateTime), N'', N'', N'142.2.47.149', N'142.2.47.149', N'T')
/****** Object:  Table [dbo].[sys_role]    Script Date: 09/05/2014 17:45:07 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[sys_role] ([role_id], [role_name], [role_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (3, N'newuser', N'New User', CAST(0x0000A38C00A7B5FF AS DateTime), CAST(0x0000A38C00A7B5FF AS DateTime), N'ling.xie', N'ling.xie', N'142.2.47.149', NULL, NULL)
INSERT [dbo].[sys_role] ([role_id], [role_name], [role_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (2, N'packing', N'Packing', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[sys_role] ([role_id], [role_name], [role_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (1, N'admin', N'administrator', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
/****** Object:  StoredProcedure [dbo].[sp_GetPIID]    Script Date: 09/05/2014 17:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<xlgwr>
-- Create date: <06/10/2014>
-- Description:	<Generate Company info for packing list upload>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetPIID]
(
 @PIID varchar(11) output
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
    select top 1 @seq = ctl_curr from dbo.pkey_ctl where t_name='pi_mstr' and t_value ='pi_id'
    if @seq is null 
    begin
		insert dbo.pkey_ctl (t_name,t_value,ctl_curr) values ('pi_mstr','pi_id',1)
		set @PIID = 'P' + right(convert(char(4),YEAR(GETDATE())),2) + cast( Right(100+Month(GetDate()),2) as char(2)) + cast( Right(100+Day(GetDate()),2)   as char(2)) + '0001'
    end
    else
    begin
		set @seq =@seq + 1
		if @seq>=9999
		    begin
			 update dbo.pkey_ctl set ctl_curr=1 where t_name='pi_mstr' and t_value ='pi_id'
			 set @seq=1
			end
		update dbo.pkey_ctl set ctl_curr=@seq where  t_name='pi_mstr' and t_value ='pi_id'
		--select REPLICATE('0',4-len(cast(1 as varchar(4))))+cast(1 as varchar(4))
		set @PIID = 'P' + right(convert(char(4),YEAR(GETDATE())),2) + cast( Right(100+Month(GetDate()),2) as char(2)) + cast( Right(100+Day(GetDate()),2)   as char(2))  + REPLICATE('0',4-len(cast(@seq as varchar(4))))+cast(@seq as varchar(4))
	end
	
    return
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetBatchID]    Script Date: 09/05/2014 17:45:08 ******/
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
		
		if @seq>=9999
		    begin
			 update dbo.pkey_ctl set ctl_curr=1 where t_name='plr_batch_mstr' and t_value ='batch_id'
			 set @seq=1
			end
			
		update dbo.pkey_ctl set ctl_curr=@seq where  t_name='plr_batch_mstr' and t_value ='batch_id'
		--select REPLICATE('0',4-len(cast(1 as varchar(4))))+cast(1 as varchar(4))
		set @BatchID = 'R' + right(convert(char(4),YEAR(GETDATE())),2) + cast( Right(100+Month(GetDate()),2) as char(2)) + cast( Right(100+Day(GetDate()),2)   as char(2))  + REPLICATE('0',4-len(cast(@seq as varchar(4))))+cast(@seq as varchar(4))
	end
	
    return
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Get_WecCtnPre]    Script Date: 09/05/2014 17:45:08 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GenCtn_Tran]    Script Date: 09/05/2014 17:45:08 ******/
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
  if exists(select * from plr_mstr_tran where Batch_ID=@Batch_ID and LineID=@LineID and plr_status='U')
				begin
				    set @result = 3
			        return
				end 
	
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
/****** Object:  Default [DF_plr_batch_mstr_Batch_void]    Script Date: 09/05/2014 17:45:07 ******/
ALTER TABLE [dbo].[plr_batch_mstr] ADD  CONSTRAINT [DF_plr_batch_mstr_Batch_void]  DEFAULT ((1)) FOR [batch_void]
GO
/****** Object:  Default [DF_Plr_mstr_plr_void_status]    Script Date: 09/05/2014 17:45:07 ******/
ALTER TABLE [dbo].[plr_mstr] ADD  CONSTRAINT [DF_Plr_mstr_plr_void_status]  DEFAULT ((0)) FOR [plr_void_status]
GO
/****** Object:  Default [DF_Plr_mstr_err_plr_void_status]    Script Date: 09/05/2014 17:45:07 ******/
ALTER TABLE [dbo].[plr_mstr_err] ADD  CONSTRAINT [DF_Plr_mstr_err_plr_void_status]  DEFAULT ((1)) FOR [plr_void_status]
GO
