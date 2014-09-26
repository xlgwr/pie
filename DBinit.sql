USE [PIE]
GO
/****** Object:  Table [dbo].[plr_mstr_tran]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[plr_mstr_log]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[plr_mstr_err]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[plr_mstr]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[plr_batch_mstr]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[pkey_ctl]    Script Date: 09/19/2014 17:32:43 ******/
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
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'pi_mstr', N'pi_id', NULL, NULL, NULL, NULL, NULL, CAST(36 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'plr_batch_mstr', N'batch_id', NULL, NULL, NULL, NULL, NULL, CAST(11 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'Plr_mstr_tran', N'Wec_Ctn', NULL, NULL, NULL, NULL, NULL, CAST(275 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'ticketingPTMR', N't_id', N'T1409190007', NULL, NULL, NULL, NULL, CAST(7 AS Decimal(18, 0)), NULL, NULL)
/****** Object:  Table [dbo].[pisr_grr]    Script Date: 09/19/2014 17:32:43 ******/
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
	[pisr_cost] [decimal](18, 4) NULL,
	[pisr_base_cost] [decimal](18, 4) NULL,
	[pisr_us_cost] [decimal](18, 4) NULL,
	[pisr_seq] [nvarchar](50) NULL,
	[pisr_con_code] [nvarchar](50) NULL,
	[pisr_ch_desc] [nvarchar](50) NULL,
	[pisr_net_wt] [decimal](18, 4) NULL,
	[pisr_rec_type] [nvarchar](50) NULL,
	[pisr_abc] [nvarchar](50) NULL,
	[pisr_code] [nvarchar](50) NULL,
	[pisr_lic_req] [nvarchar](50) NULL,
	[pisr_sbu] [nvarchar](50) NULL,
	[pisr_vend] [nvarchar](50) NULL,
	[pisr_mfgr_name] [nvarchar](50) NULL,
	[pisr_char01] [nvarchar](50) NULL,
	[pisr_char02] [nvarchar](50) NULL,
	[pisr_char03] [nvarchar](50) NULL,
	[pisr_dec01] [decimal](18, 8) NULL,
	[pisr_dec02] [decimal](18, 8) NULL,
	[pisr_int01] [int] NULL,
	[pisr_int02] [int] NULL,
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
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000026', 1, N'0', N'B1409090008', N'140909001', N'61467633R1F', N'R5903116', N'mg1328', N'10732382', CAST(90 AS Decimal(18, 0)), N'usd', NULL, CAST(1.8748 AS Decimal(18, 4)), CAST(1.8748 AS Decimal(18, 4)), N'389', N'CAR001', N'Í¢©¶', CAST(184.5000 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0002', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.18450000 AS Decimal(18, 8)), CAST(16.60500000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA855 AS DateTime), NULL, CAST(0x0000A3A1011BA855 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000026', 2, N'0', N'B1409090009', N'140909001', N'61538370R3F', N'R5903117', N'MG7024', N'10732531', CAST(300 AS Decimal(18, 0)), N'USD', NULL, CAST(3.7830 AS Decimal(18, 4)), CAST(3.7830 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(278.5000 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.27850000 AS Decimal(18, 8)), CAST(83.55000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA85A AS DateTime), NULL, CAST(0x0000A3A1011BA85A AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000026', 3, N'0', N'B1409090010', N'140909001', N'61552451R1F', N'R5903118', N'MG7024', N'10735022', CAST(500 AS Decimal(18, 0)), N'usd', NULL, CAST(4.4413 AS Decimal(18, 4)), CAST(4.4413 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(410.0000 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.41000000 AS Decimal(18, 8)), CAST(205.00000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA85B AS DateTime), NULL, CAST(0x0000A3A1011BA85B AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000027', 4, N'0', N'B1409090006', N'140909001', N'61552453R1F', N'R5903114', N'MG7024', N'10730699', CAST(500 AS Decimal(18, 0)), N'USD', NULL, CAST(4.4831 AS Decimal(18, 4)), CAST(4.4831 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(401.5900 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.40159000 AS Decimal(18, 8)), CAST(200.79500000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA867 AS DateTime), NULL, CAST(0x0000A3A1011BA867 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000028', 6, N'0', N'B1409090007', N'140909001', N'61566461R1F', N'R5903115', N'MG7024', N'10730699', CAST(300 AS Decimal(18, 0)), N'USD', NULL, CAST(1.9563 AS Decimal(18, 4)), CAST(1.9563 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(59.0100 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.05901000 AS Decimal(18, 8)), CAST(17.70300000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA874 AS DateTime), NULL, CAST(0x0000A3A1011BA874 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000029', 7, N'0', N'B1409090004', N'140909001', N'61427403R1F', N'R5903112', N'mg7024', N'10730698', CAST(400 AS Decimal(18, 0)), N'USD', NULL, CAST(1.2824 AS Decimal(18, 4)), CAST(1.2824 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(42.0200 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.04202000 AS Decimal(18, 8)), CAST(16.80800000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA88F AS DateTime), NULL, CAST(0x0000A3A1011BA88F AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000029', 8, N'0', N'B1409090002', N'140909001', N'61538372R3F', N'R5903110', N'MG7024', N'10730241', CAST(1500 AS Decimal(18, 0)), N'USD', NULL, CAST(3.3420 AS Decimal(18, 4)), CAST(3.3420 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(207.2000 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.20720000 AS Decimal(18, 8)), CAST(310.80000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA890 AS DateTime), NULL, CAST(0x0000A3A1011BA890 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000029', 9, N'0', N'B1409090003', N'140909001', N'61540970R2F', N'R5903111', N'MG7024', N'10730241', CAST(200 AS Decimal(18, 0)), N'USD', NULL, CAST(4.4016 AS Decimal(18, 4)), CAST(4.4016 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(376.5000 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.37650000 AS Decimal(18, 8)), CAST(75.30000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA88C AS DateTime), NULL, CAST(0x0000A3A1011BA88C AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000029', 10, N'0', N'B1409090005', N'140909001', N'61527403R2F', N'R5903113', N'mg7024', N'10730698', CAST(500 AS Decimal(18, 0)), N'USD', NULL, CAST(2.0844 AS Decimal(18, 4)), CAST(2.0844 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(31.9000 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(0.03190000 AS Decimal(18, 8)), CAST(15.95000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA88D AS DateTime), NULL, CAST(0x0000A3A1011BA88D AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000029', 11, N'0', N'B1409090001', N'140909001', N'61521729R4F', N'R5903109', N'MG7024', N'10730240', CAST(6 AS Decimal(18, 0)), N'USD', NULL, CAST(49.3145 AS Decimal(18, 4)), CAST(49.3145 AS Decimal(18, 4)), N'235', N'CTN001', N'ÒÂÍ¢Í¢¤õ', CAST(5000.0000 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'GZPY', N'GUANGZHOU SCA PACKING CO.,LTD', NULL, NULL, NULL, CAST(5.00000000 AS Decimal(18, 8)), CAST(30.00000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011BA88E AS DateTime), NULL, CAST(0x0000A3A1011BA88E AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000071', 1, N'0', N'B1409090013', N'140909010', N'60153110R7GB', N'R5903121', N'MG0122', N'10733503', CAST(84 AS Decimal(18, 0)), N'HKD', NULL, CAST(7.4500 AS Decimal(18, 4)), CAST(7.4500 AS Decimal(18, 4)), N'190', N'MAN001', N'Á¸Ú', CAST(218.2600 AS Decimal(18, 4)), N'IQC', N'', N'No', N'', N'0003', N'CANG', N'Canning Printing Co., Ltd.', NULL, NULL, NULL, CAST(0.21826000 AS Decimal(18, 8)), CAST(18.33384000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011A4071 AS DateTime), NULL, CAST(0x0000A3A1011A4071 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000072', 2, N'0', N'B1409090015', N'140909010', N'60247467R1F', N'R5903123', N'mg0248', N'10734787', CAST(8000 AS Decimal(18, 0)), N'HKD', NULL, CAST(0.0278 AS Decimal(18, 4)), CAST(0.0278 AS Decimal(18, 4)), N'191', N'LAB001', N'¨Í¢(ÛÃ®)', CAST(0.0300 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0002', N'CANG', N'Canning Printing Co., Ltd.', NULL, NULL, NULL, CAST(0.00003000 AS Decimal(18, 8)), CAST(0.24000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011A407C AS DateTime), NULL, CAST(0x0000A3A1011A407C AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000073', 3, N'0', N'B1409090011', N'140909010', N'60125090R1F', N'R5903119', N'mg7024', N'10730695', CAST(500 AS Decimal(18, 0)), N'HKD', NULL, CAST(0.2940 AS Decimal(18, 4)), CAST(0.2940 AS Decimal(18, 4)), N'190', N'MAN001', N'Á¸Ú', CAST(7.5000 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'CANG', N'Canning Printing Co., Ltd.', NULL, NULL, NULL, CAST(0.00750000 AS Decimal(18, 8)), CAST(3.75000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011A4088 AS DateTime), NULL, CAST(0x0000A3A1011A4088 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000074', 4, N'0', N'B1409090014', N'140909010', N'60143310R3F', N'R5903122', N'mg1328', N'10734226', CAST(1000 AS Decimal(18, 0)), N'hkd', NULL, CAST(0.2646 AS Decimal(18, 4)), CAST(0.2646 AS Decimal(18, 4)), N'190', N'MAN001', N'Á¸Ú', CAST(5.2700 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0002', N'CANG', N'Canning Printing Co., Ltd.', NULL, NULL, NULL, CAST(0.00527000 AS Decimal(18, 8)), CAST(5.27000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011A4092 AS DateTime), NULL, CAST(0x0000A3A1011A4092 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pisr_grr] ([pi_wec_ctn], [plr_LineID_tran], [Plant], [pisr_rir], [pisr_invoice], [pisr_part], [Pisr_receiver], [pisr_site], [pisr_po_nbr], [pisr_qty], [pisr_curr], [pisr_cost], [pisr_base_cost], [pisr_us_cost], [pisr_seq], [pisr_con_code], [pisr_ch_desc], [pisr_net_wt], [pisr_rec_type], [pisr_abc], [pisr_code], [pisr_lic_req], [pisr_sbu], [pisr_vend], [pisr_mfgr_name], [pisr_char01], [pisr_char02], [pisr_char03], [pisr_dec01], [pisr_dec02], [pisr_int01], [pisr_int02], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'100000000075', 5, N'0', N'B1409090012', N'140909010', N'60115001R3F', N'R5903120', N'MG7024', N'10733267', CAST(2000 AS Decimal(18, 0)), N'HKD', NULL, CAST(4.7500 AS Decimal(18, 4)), CAST(4.7500 AS Decimal(18, 4)), N'190', N'MAN001', N'Á¸Ú', CAST(221.8600 AS Decimal(18, 4)), N'STS', N'', N'No', N'', N'0003', N'CANG', N'Canning Printing Co., Ltd.', NULL, NULL, NULL, CAST(0.22186000 AS Decimal(18, 8)), CAST(443.72000000 AS Decimal(18, 8)), NULL, NULL, NULL, NULL, NULL, CAST(0x0000A3A1011A409C AS DateTime), NULL, CAST(0x0000A3A1011A409C AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[pi_sq]    Script Date: 09/19/2014 17:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pi_sq](
	[sq_type] [nvarchar](50) NOT NULL,
	[sq_id] [int] NOT NULL,
	[sq_name] [nvarchar](100) NULL,
	[sq_desc] [nvarchar](300) NULL,
	[sq_unit] [nvarchar](50) NULL,
	[co_id] [nvarchar](50) NOT NULL,
	[co_desc] [nvarchar](50) NULL,
 CONSTRAINT [PK_pi_sq] PRIMARY KEY CLUSTERED 
(
	[sq_type] ASC,
	[sq_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 1, N'保险丝', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 2, N'保险丝', N'电压≤1000伏', N'个', N'150', N'菲律宾')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 3, N'保险丝', N'电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 4, N'保险丝', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 5, N'保险丝', N'电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 6, N'保险丝座', N'电压≤1000V/保险丝固定支架', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 7, N'保险丝座', N'电压≤1000V/保险丝固定支架', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 8, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 9, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 10, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 11, N'变压器', N'额定容量≤1KVA', N'个', N'161', N'越南')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 12, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 13, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 14, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 15, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 16, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 17, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 18, N'插座', N'电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 19, N'插座', N'电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 20, N'插座', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 21, N'插座', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 22, N'插座', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 23, N'插座', N'电压≤1000伏', N'个', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 24, N'插座', N'电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 25, N'插座', N'电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 26, N'插座', N'电压≤1000伏', N'个', N'133', N'印度尼西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 27, N'插座', N'电压≤1000伏', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 28, N'插座', N'电压≤1000伏', N'个', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 29, N'电感器', N'感量＜1000mh', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 30, N'电感器', N'感量＜1000mh', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 31, N'电感器', N'感量＜1000mh', N'个', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 32, N'电感器', N'感量＜1000mh', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 33, N'电感器', N'感量＜1000mh', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 34, N'电感器', N'感量＜1000mh', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 35, N'电感器', N'感量＜1000mh', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 36, N'电感器', N'感量＜1000mh', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 37, N'电感器', N'感量＜1000mh', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 38, N'发光二极管', N'无规格', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 39, N'发光二极管', N'无规格', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 40, N'发光二极管', N'无规格', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 41, N'发光管显示器', N'无规格', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 42, N'发光管显示器', N'无规格', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 43, N'三极管', N'耗散功率＜1W', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 44, N'三极管', N'耗散功率＜1W', N'个', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 45, N'三极管', N'耗散功率＜1W', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 46, N'三极管', N'耗散功率＜1W', N'个', N'150', N'菲律宾')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 47, N'三极管', N'耗散功率＜1W', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 48, N'三极管', N'耗散功率＜1W', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 49, N'三极管', N'耗散功率≥1W', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 50, N'三极管', N'耗散功率≥1W', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 51, N'三极管', N'耗散功率≥1W', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 52, N'三极管', N'耗散功率≥1W', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 53, N'开关', N'电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 54, N'开关', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 55, N'开关', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 56, N'开关', N'电压≤1000伏', N'个', N'309', N'墨西哥')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 57, N'继电器', N'电压≤36伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 58, N'继电器', N'电压≤36伏', N'个', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 59, N'继电器', N'电压≤36伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 60, N'继电器', N'电压≤36伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 61, N'继电器', N'电压≤36伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 62, N'继电器', N'电压≤36伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 63, N'继电器', N'电压＞60伏', N'个', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 64, N'可控硅', N'无规格', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 65, N'锂电池', N'无规格', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 66, N'锂电池', N'无规格', N'个', N'133', N'印度尼西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 67, N'锂离子充电池', N'无规格', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 68, N'蜂鸣器', N'音量≤110db', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 69, N'打印机用内存条', N'0.001-0.01千克/台', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 70, N'散热风扇', N'功率≤125瓦', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 71, N'散热风扇', N'功率≤125瓦', N'台', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 72, N'散热风扇', N'功率≤125瓦', N'台', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 73, N'阵列式二极管', N'无规格', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 74, N'阵列式二极管', N'无规格', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 75, N'阵列式二极管', N'无规格', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 76, N'阵列式二极管', N'无规格', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 77, N'插式多层瓷介电容', N'0.000003-0.01千克/个', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 78, N'插式多层瓷介电容', N'0.000003-0.01千克/个', N'千克', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 79, N'插式多层瓷介电容', N'0.021-0.042千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 80, N'片式多层瓷介电容器', N'0.0000001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 81, N'片式多层瓷介电容器', N'0.0000002-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 82, N'片式多层瓷介电容器', N'0.0000002-0.01千克/个', N'千克', N'153', N'新加坡')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 83, N'片式多层瓷介电容器', N'0.000001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 84, N'片式多层瓷介电容器', N'0.00001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 85, N'插式固定电阻', N'额定功率≤20W/0.00001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 86, N'插式固定电阻', N'额定功率≤20W/0.0000025-0.01千克/个', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 87, N'插式固定电阻', N'额定功率≤20W/0.0000025-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 88, N'插式固定电阻', N'额定功率≤20W/0.000001-0.01千克/个', N'千克', N'309', N'墨西哥')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 89, N'插式固定电阻', N'额定功率≤20W/0.00012-0.01千克/个', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 90, N'插式固定电阻', N'额定功率≤20W/0.01-0.02千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 91, N'插式固定电阻', N'额定功率≤20W/0.024-0.048千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 92, N'插式固定电阻', N'额定功率≤20W/0.049-0.098千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 93, N'插式固定电阻', N'额定功率≤20W/0.099-0.198千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 94, N'式片固定电阻', N'额定功率≤20W', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 95, N'式片固定电阻', N'额定功率≤20W', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 96, N'式片固定电阻', N'额定功率≤20W', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 97, N'式片固定电阻', N'额定功率≤20W', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 98, N'式片固定电阻', N'额定功率≤20W', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 99, N'插式铝电解电容', N'0.00002-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 100, N'插式铝电解电容', N'0.0001-0.01千克/个', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 101, N'插式铝电解电容', N'0.0002-0.01千克/个', N'千克', N'133', N'印度尼西亚')
GO
print 'Processed 100 total records'
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 102, N'插式铝电解电容', N'0.01145-0.0229千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 103, N'插式铝电解电容', N'0.023-0.046千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 104, N'插式铝电解电容', N'0.04646-0.09292千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 105, N'插式铝电解电容', N'0.10087-0.2017千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 106, N'插式钽电容', N'0.00002-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 107, N'片式钽电容', N'0.000001-0.01千克/个', N'千克', N'276', N'捷克            ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 108, N'片式钽电容', N'0.00002-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 109, N'片式钽电容', N'0.0001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 110, N'片式磁珠', N'无规格', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 111, N'软性空白线路板(四层及以下)', N'0.00001-0.01KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 112, N'软性空白线路板(四层及以下)', N'0.00001-0.01KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 113, N'刚性空白印刷线路板(四层以上)', N'0.00001-0.01KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 114, N'刚性空白印刷线路板(四层以上)', N'0.011-0.020KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 115, N'刚性空白印刷线路板(四层以上)', N'0.021-0.040KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 116, N'刚性空白印刷线路板(四层以上)', N'0.02-0.040KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 117, N'刚性空白印刷线路板(四层以上)', N'0.041-0.080KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 118, N'刚性空白印刷线路板(四层以上)', N'0.042-0.084KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 119, N'刚性空白印刷线路板(四层以上)', N'0.080-0.160KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 120, N'刚性空白印刷线路板(四层以上)', N'0.085-0.170KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 121, N'刚性空白印刷线路板(四层以上)', N'0.171-0.340KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 122, N'刚性空白印刷线路板(四层及以下)', N'0.00001-0.01KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 123, N'刚性空白印刷线路板(四层及以下)', N'0.00001-0.01KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 124, N'刚性空白印刷线路板(四层及以下)', N'0.00001-0.01KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 125, N'刚性空白印刷线路板(四层及以下)', N'0.00001-0.01KG/块', N'块', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 126, N'刚性空白印刷线路板(四层及以下)', N'0.011-0.022KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 127, N'刚性空白印刷线路板(四层及以下)', N'0.011-0.022KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 128, N'刚性空白印刷线路板(四层及以下)', N'0.0221-0.044KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 129, N'刚性空白印刷线路板(四层及以下)', N'0.0221-0.044KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 130, N'刚性空白印刷线路板(四层及以下)', N'0.023-0.046KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 131, N'刚性空白印刷线路板(四层及以下)', N'0.03-0.06KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 132, N'刚性空白印刷线路板(四层及以下)', N'0.04485-0.0897KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 133, N'刚性空白印刷线路板(四层及以下)', N'0.050-0.100KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 134, N'刚性空白印刷线路板(四层及以下)', N'0.101-0.200KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 135, N'刚性空白印刷线路板(四层及以下)', N'0.101-0.200KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 136, N'刚性空白印刷线路板(四层及以下)', N'0.201-0.400KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 137, N'刚性空白印刷线路板(四层及以下)', N'0.201-0.400KG/块', N'块', N'161', N'越南')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 138, N'刚性空白印刷线路板(四层及以下)', N'0.401-0.800KG/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 139, N'处理及控制数字式单片集成电路', N'0.00000001-0.01KG/个', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 140, N'处理及控制数字式单片集成电路', N'0.00000001-0.01KG/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 141, N'处理及控制数字式单片集成电路', N'0.00000001-0.01KG/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 142, N'处理及控制数字式单片集成电路', N'0.00000001-0.01KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 143, N'处理及控制数字式单片集成电路', N'0.00000001-0.01KG/个', N'个', N'150', N'菲律宾')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 144, N'处理及控制数字式单片集成电路', N'0.00000001-0.01KG/个', N'个', N'154', N'韩国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 145, N'处理及控制数字式单片集成电路', N'0.0101-0.02KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 146, N'存储集成电路', N'0.00000001-0.01KG/个', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 147, N'存储集成电路', N'0.00000001-0.01KG/个', N'个', N'150', N'菲律宾')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 148, N'电机伺服器用变频模块', N'0.0200-0.04KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 149, N'电机伺服器用变频模块', N'0.1-0.2KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 150, N'电机伺服器用变频模块', N'0.3-0.6KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 151, N'电机伺服器用变频模块', N'0.7-1.4KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 152, N'电机伺服器用功能模块', N'0.05-0.10KG/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 153, N'绝缘栅双极模块', N'0.00000001-0.01KG/个', N'个', N'150', N'菲律宾')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 154, N'绝缘栅双极模块', N'0.041-0.082KG/个', N'个', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 155, N'绝缘栅双极模块', N'0.073-0.146KG/个', N'个', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 156, N'可控硅', N'0.00000001-0.01KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 157, N'模拟线性单片集成电路', N'0.00000001-0.01KG/个', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 158, N'模拟线性单片集成电路', N'0.00000001-0.01KG/个', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 159, N'模拟线性单片集成电路', N'0.00000001-0.01KG/个', N'个', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 160, N'模拟线性单片集成电路', N'0.00000001-0.01KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 161, N'模拟线性单片集成电路', N'0.00000001-0.01KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 162, N'模拟线性单片集成电路', N'0.0101-0.0200KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 163, N'模拟线性单片集成电路', N'0.0101-0.0200KG/个', N'个', N'330', N'加拿大')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 164, N'模拟线性单片集成电路', N'0.0300-0.0400KG/个', N'个', N'161', N'越南')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 165, N'二极管', N'0.00000001-0.01KG/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 166, N'二极管', N'0.00000001-0.01KG/个', N'个', N'275', N'克罗地亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 167, N'二极管', N'0.00000001-0.01KG/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 168, N'二极管', N'0.00000001-0.01KG/个', N'个', N'150', N'菲律宾')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 169, N'二极管', N'0.00000001-0.01KG/个', N'个', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 170, N'二极管', N'0.02-0.04KG/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 171, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 172, N'阵列式三极管', N'耗散功率＜1W', N'个', N'150', N'菲律宾')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 173, N'阵列式三极管', N'耗散功率＜1W', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 174, N'散热风扇', N'功率≤125瓦', N'台', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 175, N'散热风扇', N'功率≤125瓦', N'台', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 176, N'压电晶体', N'已装配', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 177, N'压电晶体', N'已装配', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 178, N'压电晶体', N'已装配', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 179, N'压电晶体', N'已装配', N'个', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 180, N'滤波器(非贴片式)', N'其他半导体器件', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 181, N'滤波器(非贴片式)', N'其他半导体器件', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 182, N'滤波器(非贴片式)', N'其他半导体器件', N'个', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 183, N'滤波器(非贴片式)', N'其他半导体器件', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 184, N'滤波器', N'感量小于1000h', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 185, N'滤波器', N'感量小于1000h', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 186, N'滤波器', N'感量小于1000h', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 187, N'电力滤波器', N'变频调速器用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 188, N'可控硅', N'0.11-0.22千克/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 189, N'纸卡板', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 190, N'说明书', N'纸制印刷品', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 191, N'贴纸(标签)', N'纸制，标识产品用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 192, N'塑胶绝缘片', N'绝缘材料', N'千克', N'331', N'美国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 193, N'塑胶绝缘套', N'绝缘材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 194, N'塑胶螺钉', N'紧固件', N'千克', N'331', N'美国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 195, N'塑胶螺母', N'紧固件', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 196, N'塑胶螺丝', N'紧固件', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 197, N'塑胶线夹', N'塑胶制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 198, N'塑胶扎带', N'包扎货物用', N'千克', N'153', N'新加坡')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 199, N'条形海棉', N'聚乙烯', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 200, N'条形珍珠棉', N'聚乙烯', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 201, N'热缩管', N'绝缘材料', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 202, N'收银机用防水胶框', N'保护用', N'千克', N'162', N'中国')
GO
print 'Processed 200 total records'
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 203, N'收银机用感应器', N'0.001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 204, N'收银机用感应器', N'0.001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 205, N'收银机用钢按键', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 206, N'收银机用钢柱', N'钢制', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 207, N'收银机用功能模块', N'无线数据传输', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 208, N'收银机用铝卡扣', N'铝制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 209, N'收银机用塑胶按键', N'塑胶制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 210, N'收银机用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 211, N'收银机用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 212, N'收银机用天线', N'接收用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 213, N'收银机用铁盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 214, N'铁固定夹', N'铁制', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 215, N'铁固定夹', N'铁制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 216, N'铁固定夹', N'铁制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 217, N'铁固定片', N'铁制', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 218, N'铁支撑架', N'铁制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 219, N'铁支撑架', N'铁制', N'千克', N'245', N'芬兰')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 220, N'铁支撑架', N'铁制', N'千克', N'245', N'芬兰')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 221, N'铁支撑架', N'铁制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 222, N'通迅用天线', N'0.00001-0.01千克/个', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 223, N'铜固定片', N'铜制', N'千克', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 224, N'铜固定片', N'铜制', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 225, N'铜连接片', N'铜制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 226, N'铜连接片', N'铜制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 227, N'铜螺母', N'铜制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 228, N'铜螺旋弹簧', N'带垫圈', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 229, N'铜散热片', N'铜制，散热用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 230, N'铜支撑架', N'铜制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 231, N'铜支撑架', N'铜制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 232, N'铜柱', N'铜制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 233, N'铜柱', N'铜制', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 234, N'瓦楞纸彩盒', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 235, N'瓦愣纸纸箱', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 236, N'无接头导电排线', N'1000伏≥耐压＞80伏', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 237, N'无线数据收发器塑胶塞', N'保护用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 238, N'无线数据收发器用钢盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 239, N'无线数据收发器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 240, N'无线数据收发器用塑胶盖', N'保护用', N'千克', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 241, N'无线数据收发器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 242, N'吸塑盒', N'包装货物用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 243, N'锡珠', N'改善焊接加锡', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 244, N'智能灯光控制器用铝外壳', N'保护用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 245, N'智能定时控制器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 246, N'PE防静电袋', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 247, N'PE胶袋', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 248, N'PE汽泡胶袋', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 249, N'变频调速器用感应器', N'0.0001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 250, N'变频调速器用钢盖', N'保护用', N'千克', N'331', N'美国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 251, N'变频调速器用钢盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 252, N'变频调速器用钢罩', N'保护用', N'千克', N'231', N'英国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 253, N'变频调速器用铝外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 254, N'变频调速器用塑胶按键', N'开关作用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 255, N'变频调速器用塑胶按键板', N'控制', N'千克', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 256, N'变频调速器用塑胶保护罩', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 257, N'变频调速器用塑胶挡板', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 258, N'变频调速器用塑胶导光件', N'导光用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 259, N'变频调速器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 260, N'变频调速器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 261, N'变频调速器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 262, N'变频调速器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 263, N'变频调速器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 264, N'变频调速器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 265, N'变频调速器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 266, N'变频调速器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 267, N'变频调速器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 268, N'变频调速器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 269, N'变频调速器用塑胶罩', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 270, N'变频调速器用塑胶罩', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 271, N'变频调速器用铁接地板', N'铁制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 272, N'薄膜碳质电阻', N'0.000001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 273, N'薄膜碳质电阻', N'0.000001-0.01千克/个', N'千克', N'153', N'新加坡')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 274, N'薄膜碳质电阻', N'0.00001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 275, N'插座用外壳(带螺丝)', N'电机伺服器用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 276, N'打印机线路板组件用天线', N'接收用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 277, N'打印机线路板组件用天线', N'接收用', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 278, N'打印机用功能模块', N'0.001-0.01千克/个', N'千克', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 279, N'打印机用功能模块', N'0.01-0.02千克/个', N'千克', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 280, N'打印机用塑胶按键', N'开关作用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 281, N'打印机用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 282, N'打印机用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 283, N'打印机用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 284, N'打印机用塑胶夹', N'紧固件', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 285, N'打印机用塑胶填充泡棉', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 286, N'打印机用塑胶外壳', N'保护用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 287, N'打印机用塑胶外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 288, N'带接头电源线', N'1000伏≥耐压＞80伏', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 289, N'电机伺服器用带温度电子模块', N'功率60W', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 290, N'电机伺服器用带温度电子模块', N'功率60W', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 291, N'电机伺服器用带温度电子模块', N'功率60W', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 292, N'电机伺服器用带温度电子模块', N'功率60W', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 293, N'电机伺服器用感应器', N'0.0001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 294, N'电机伺服器用功能模块', N'0.01-0.02千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 295, N'电机伺服器用功能模块', N'0.05-0.3千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 296, N'电机伺服器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 297, N'电机伺服器用塑胶壳', N'保护用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 298, N'电机伺服器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 299, N'电机伺服器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 300, N'电机伺服器用铁盖', N'保护用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 301, N'电机伺服器用铁盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 302, N'电机伺服器用铁盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 303, N'电机伺服器用支撑架', N'金属', N'千克', N'137', N'日本')
GO
print 'Processed 300 total records'
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 304, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 305, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 306, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 307, N'电机伺服器用支撑架', N'金属', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 308, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 309, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 310, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 311, N'镀锡铜线', N'其它铜合金丝(起连接作用)', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 312, N'方型海棉', N'聚乙烯', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 313, N'方形珍珠棉', N'聚乙烯', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 314, N'防潮珠', N'含二氧化硅 99.71%', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 315, N'复印机用感应器', N'0.0001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 316, N'钢螺旋弹簧', N'钢制', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 317, N'钢散热片', N'钢制，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 318, N'钢散热片', N'钢制，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 319, N'钢支撑架', N'钢制', N'千克', N'331', N'美国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 320, N'钢支撑架', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 321, N'钢支撑架', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 322, N'钢支撑架', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 323, N'钢支撑架', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 324, N'钢支撑架', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 325, N'钢支撑架', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 326, N'钢支撑架', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 327, N'公交车刷卡器用钢盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 328, N'公交车刷卡器用钢盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 329, N'公交车刷卡器用钢扣', N'紧固件', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 330, N'公交车刷卡器用塑胶按键', N'开关作用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 331, N'公交车刷卡器用塑胶垫圈', N'紧固件', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 332, N'公交车刷卡器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 333, N'公交车刷卡器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 334, N'公交车刷卡器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 335, N'公交车刷卡器用塑胶面板', N'控制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 336, N'公交车刷卡器用铜导电帽', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 337, N'公交车刷卡器用橡胶密封圈', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 338, N'公交车刷卡器用橡胶密封圈', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 339, N'光纤收发器', N'0.001-0.01千克/个', N'千克', N'150', N'菲律宾')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 340, N'光纤收发器', N'0.01-0.02千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 341, N'硅胶按纽', N'变频调速器用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 342, N'硅胶按纽', N'收银机用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 343, N'硅胶脚垫', N'0.00001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 344, N'金属磁铁', N'0.0000001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 345, N'聚亚胺脂胶水', N'氰基丙烯酸脂粘合剂', N'千克', N'331', N'美国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 346, N'可编程控制器用塑胶隔离棒', N'控制', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 347, N'可编程控制器用塑胶外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 348, N'路由器用钢板盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 349, N'路由器用钢板盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 350, N'路由器用钢板面板', N'控制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 351, N'路由器用钢板罩', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 352, N'路由器用钢垫圈', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 353, N'路由器用功能模块', N'0.0001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 354, N'路由器用塑胶导光条', N'导光用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 355, N'路由器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 356, N'路由器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 357, N'铝支撑架', N'铝制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 358, N'铝制散热片', N'非工业用铝制器，散热用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 359, N'铝制散热片', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 360, N'铝制散热片', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 361, N'铝制散热片', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 362, N'铝制散热片', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 363, N'铝制散热片', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 364, N'铝制散热片', N'非工业用铝制器，散热用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 365, N'铝制散热器', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 366, N'铝制散热器', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 367, N'铝制散热器', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 368, N'铝制散热器', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 369, N'铝制散热器', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 370, N'铝制散热器', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 371, N'汽车数据转换器用铝外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 372, N'汽车数据转换器用面板', N'铝加塑胶制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 373, N'汽车数据转换器用面板', N'铝加塑胶制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 374, N'汽车数据转换器用塑胶底壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 375, N'汽车数据转换器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 376, N'汽车数据转换器用塑胶圈', N'紧固用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 377, N'汽车数据转换器用塑胶外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 378, N'汽车数据转换器用塑胶外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 379, N'汽车数据转换器用塑胶外套', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 380, N'汽车数据转换器用塑胶外套', N'保护用', N'千克', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 381, N'汽车数据转换器用塑胶柱', N'支撑', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 382, N'汽车数据转换器用铁盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 383, N'"铁制螺丝,非用于民航维护修理"', N'"杆径≤6mm,抗拉强度＜800兆帕,"', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 384, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 385, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 386, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 387, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 388, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 389, N'纸隔', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 390, N'片式固定电阻', N'额定功率≤20W/0.1-10000千个/千克', N'千克', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 391, N'片式固定电阻', N'额定功率≤20W/0.1-10000千个/千克', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 392, N'片式固定电阻', N'额定功率≤20W/0.1-10000千个/千克', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 393, N'片式固定电阻', N'额定功率≤20W/0.1-10000千个/千克', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 394, N'片式固定电阻', N'额定功率≤20W/0.1-10000千个/千克', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 395, N'塑料薄膜介质电容(非片式)', N'0.00001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 396, N'塑料薄膜介质电容(非片式)', N'0.00001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 397, N'塑料薄膜介质电容(非片式)', N'0.00001-0.01千克/个', N'千克', N'235', N'意大利')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 398, N'塑料薄膜介质电容(非片式)', N'0.00001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 399, N'塑料薄膜介质电容(非片式)', N'0.01-0.02千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 400, N'塑料薄膜介质电容(非片式)', N'0.022-0.044千克/个', N'千克', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 401, N'塑料薄膜介质电容(片式)', N'0.00001-0.01千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 402, N'SD卡', N'未录制', N'个', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 403, N'保险丝', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 404, N'保险丝', N'电压≤1000伏', N'个', N'137', N'日本')
GO
print 'Processed 400 total records'
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 405, N'变压器', N'额定容量≤1KVA', N'个', N'161', N'越南')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 406, N'变压器', N'额定容量≤1KVA', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 407, N'可控硅', N'0.4-0.8千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 408, N'锂电池', N'1.2-6V', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 409, N'锂电池', N'1.2-6V', N'个', N'136', N'以色列')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 410, N'液晶体显示屏(26寸以下)', N'0.06-0.12千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 411, N'整流器', N'0.07-0.14千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 412, N'刚性空白印刷线路板(四层及以下)', N'0.05-0.1千克/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 413, N'刚性空白印刷线路板(四层以上)', N'0.3-0.6千克/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 414, N'软性空白线路板(四层及以下)', N'0.00001-0.01千克/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 415, N'软性空白线路板(四层及以下)', N'0.00001-0.01千克/块', N'块', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 416, N'插座', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 417, N'插座', N'电压≤1000伏', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 418, N'插座', N'电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 419, N'程序安装光盘', N'只读光盘', N'张', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 420, N'二极管', N'0.18-0.36千克/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 421, N'锂电池', N'1.2-6V', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 422, N'锂离子充电池', N'1.2-6V', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 423, N'麦克风', N'0.00001-0.01千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 424, N'触摸屏', N'打印机用', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 425, N'散热风扇', N'功率≤125瓦', N'台', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 426, N'针式打印机', N'0.3-0.6千克/台', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 427, N'电机伺服器用塑胶软胶管', N'PVC/最小爆破压力为27.6MPa', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 428, N'电机伺服器用塑胶软胶管', N'PVC/最小爆破压力为27.6MPa', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 429, N'电机伺服器用塑胶硬胶管', N'ABS', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 430, N'电脑用钢夹子', N'紧固件', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 431, N'绝缘清漆(溶于非水介质)', N'含异丙醇20%，丙二醇甲基52%，', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 432, N'滤波器(非贴片式)', N'其他半导体器件', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 433, N'电机伺服器用功能模块', N'0.5-1千克/个', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 434, N'无绳数字电话用铁盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 435, N'喇叭仔', N'其他扬声器', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 436, N'带接头电线', N'1000伏≥耐压＞80伏', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 437, N'带接头电线', N'1000伏≥耐压＞80伏', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 438, N'智能定时控制器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 439, N'外置消费卡塑胶保护套', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 440, N'风扇塑胶钢网连接件', N'电机伺服器用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 441, N'复印机用塑胶保护薄膜', N'聚乙烯', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 442, N'钢垫片', N'非民航用', N'千克', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 443, N'钢垫片', N'非民航用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 444, N'钢垫片', N'非民航用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 445, N'钢垫片', N'非民航用', N'千克', N'232', N'德国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 446, N'钢垫片', N'非民航用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 447, N'钢垫片', N'非民航用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 448, N'可变电阻/电位器', N'额定功率≤20W/0.1-10000千个/千克', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 449, N'可变电阻/电位器', N'额定功率≤20W/0.1-10000千个/千克', N'千克', N'247', N'匈牙利')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 450, N'可变电阻/电位器', N'额定功率≤20W/0.1-10000千个/千克', N'千克', N'295', N'哥斯达黎加')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 451, N'铝合金板', N'铝制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 452, N'塑胶支架', N'0.0000001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 453, N'塑胶支架', N'0.0000001-0.01千克/个', N'千克', N'231', N'英国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 454, N'塑胶支架', N'0.0000001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 455, N'塑胶支架', N'0.01-0.02千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 456, N'塑胶支架', N'0.02-0.04千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 457, N'塑胶支架', N'0.04-0.08千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 458, N'塑胶支架', N'0.15-0.3千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 459, N'条型热熔胶', N'人造树脂', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 460, N'外置消费卡塑胶壳', N'保护用', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 461, N'无接头电线', N'1000伏≥耐压＞80伏', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 462, N'无接头电线', N'1000伏≥耐压＞80伏', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 463, N'无接头电线', N'1000伏≥耐压＞80伏', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 464, N'无接头电线', N'1000伏≥耐压＞80伏', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 465, N'整流器', N'0.01-0.02千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 466, N'整流器', N'0.15-0.3千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 467, N'整流器', N'0.35-0.7千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 468, N'阵列式二极管', N'0.015-0.03千克/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 469, N'电力滤波器', N'变频调速器用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 470, N'锡条', N'焊接零件用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 471, N'锡线', N'焊接零件用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 472, N'汽车数据转换器用功能模块', N'0.01-0.02千克/台', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 473, N'无线数据收发器用功能模块', N'0.03-0.06千克/台', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 474, N'无线数据收发器用功能模块', N'0.00001-0.01千克/台', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 475, N'电机伺服器用变频模块', N'0.06-0.12千克/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 476, N'电机伺服器用变频模块', N'0.2-0.4千克/个', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 477, N'无线数据收发器用功能模块', N'0.00001-0.01千克/台', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 478, N'硬盘', N'容量320GB/内置式', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 479, N'铝制散热器', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 480, N'铝制散热器', N'非工业用铝制器，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 481, N'打印机用液晶体显示屏组件', N'带背光模组', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 482, N'打印机用液晶体显示屏组件', N'带背光模组', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 483, N'液晶显示屏组件', N'带驱动板', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 484, N'液晶显示屏组件', N'带驱动板', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 485, N'液晶体显示屏(26寸以下)', N'0.0001-0.01千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 486, N'液晶体显示屏(26寸以下)', N'0.011-0.022千克/个', N'个', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 487, N'液晶体显示屏(26寸以下)', N'0.03-0.06千克/个', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 488, N'液晶体显示屏(26寸以下)', N'0.06-0.12千克/个', N'个', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 489, N'变频调速器用钢盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 490, N'变频调速器用铝外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 491, N'电机伺服器用钢板', N'控制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 492, N'电机伺服器用钢盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 493, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 494, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 495, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 496, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 497, N'路由器用钢板面板', N'控制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 498, N'铝制散热片', N'非工业用铝制片，散热用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 499, N'铁固定片', N'铁制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 500, N'微型电机(机座尺寸20MM-39MM)', N'输出功率不超过37.5瓦', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 501, N'光电收发转换器', N'0.011-0.022千克/个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 502, N'收银机用塑胶按键', N'开关作用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 503, N'无线数据收发器塑胶垫圈', N'紧固用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 504, N'方形发泡胶', N'聚苯乙烯', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 505, N'自粘胶粘纸', N'包装货物用', N'千克', N'162', N'中国')
GO
print 'Processed 500 total records'
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 506, N'路由器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 507, N'电脑用钢后盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 508, N'电机伺服器用钢外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 509, N'外置消费卡塑胶壳', N'保护用', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 510, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 511, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'247', N'匈牙利')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 512, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 513, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 514, N'有接头组合线', N'80V<电压≤1000V', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 515, N'电机伺服器用支撑架', N'金属', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 516, N'钢散热片', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 517, N'汽车数据转换器用铝外壳', N'铝制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 518, N'变频调速器用塑胶挡板', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 519, N'变频调速器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 520, N'电机伺服器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 521, N'电机伺服器用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 522, N'电机伺服器用塑胶壳', N'保护用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 523, N'收银机用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 524, N'收银机用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 525, N'塑胶绝缘片', N'绝缘材质', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 526, N'无线数据收发器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 527, N'"铁制螺丝,非用于民航维护修理"', N'"杆径≤6mm,抗拉强度＜800兆帕,"', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 528, N'钢支撑架', N'钢制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 529, N'锡浆', N'粘贴SMT零件用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 530, N'公交车刷卡器用功能模块', N'0.07-0.14千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 531, N'公交车刷卡器用功能模块', N'0.025-0.05千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 532, N'有接头电话线', N'80伏<额定电压≦1000伏', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 533, N'电机伺服器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 534, N'智能灯光控制器用塑胶盖', N'保护用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 535, N'货物运输周转用胶卡板', N'8-15千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 536, N'硬盘', N'容量160GB/内置式', N'台', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 537, N'硬盘', N'容量250GB/内置式', N'台', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 538, N'硬盘', N'容量500GB/内置式', N'台', N'157', N'泰国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 539, N'汽车数据转换器用铝外壳', N'铝制', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 540, N'触摸屏', N'电脑用0.05-0.1千克/台', N'台', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 541, N'触摸屏', N'电脑用0.05-0.1千克/台', N'台', N'163', N'台澎金马关税区  ')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 542, N'打印机用塑胶支架', N'0.012-0.024千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 543, N'打印机用塑胶支架', N'0.000001-0.01千克/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 544, N'程序安装光盘', N'国内购买非进口/0.01-0.02kg/张', N'张', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 545, N'平板电脑用摄像头组件', N'照相用', N'台', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 546, N'平板电脑用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 547, N'平板电脑用塑胶壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 548, N'平板电脑用塑胶按钮', N'开关作用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 549, N'锂离子充电池', N'3-6V', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 550, N'纸托', N'包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 551, N'可编程控制器用塑胶外壳', N'保护用', N'千克', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 552, N'智能开关控制器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 553, N'智能开关控制器用塑胶盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 554, N'充电器', N'充电用', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 555, N'平板电脑用塑胶密封盖', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 556, N'纸隔', N'国内采购-包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 557, N'瓦愣纸纸箱', N'国内采购-包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 558, N'瓦楞纸彩盒', N'国内采购-包装材料', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 559, N'桥式整流器', N'由6个二极管组成的半导体模块', N'个', N'137', N'日本')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 560, N'变频器用箱体组合件/塑胶五金制', N'变频调速器用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 561, N'平板电脑用塑胶支架', N'支撑用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 562, N'通迅用天线', N'国内采购-国内购买非进口', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 563, N'绝缘栅双极模块', N'0.02-0.04kg /个', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 564, N'电机伺服器用钢外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 565, N'电机伺服器用钢外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 566, N'电力滤波器', N'4-8KG/个', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 567, N'打印机用塑胶外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 568, N'打印机用塑胶外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 569, N'打印机用塑胶外壳', N'保护用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 570, N'插座', N'国内采购-电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 571, N'开关', N'国内采购-电压≤1000伏', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 572, N'方型发泡胶', N'国内采购-聚乙烯/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 573, N'SIM卡', N'已录制', N'个', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 574, N'保险丝固定支座', N'青铜', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 575, N'保险丝固定支座', N'青铜', N'千克', N'143', N'马来西亚')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 576, N'无印刷纸制贴纸(标签)', N'纸制，标识产品用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 577, N'有印刷纸制贴纸(标签)', N'纸制，标识产品用', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 578, N'变频调速器用塑胶盖', N'国内采购-保护用/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 579, N'变频调速器用塑胶盖', N'国内采购-保护用/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 580, N'变频调速器用塑胶盖', N'国内采购-保护用/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 581, N'变频调速器用塑胶盖', N'国内采购-保护用/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 582, N'变频调速器用塑胶壳', N'国内采购-保护用/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 583, N'塑胶绝缘片', N'国内采购-绝缘材料/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 584, N'塑胶绝缘片', N'国内采购-绝缘材料/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 585, N'塑胶支架', N'国内采购-0.0000001-0.01千克/个/国内购买', N'千克', N'162', N'中国')
INSERT [dbo].[pi_sq] ([sq_type], [sq_id], [sq_name], [sq_desc], [sq_unit], [co_id], [co_desc]) VALUES (N'RM', 586, N'路由器用功能模块', N'0.05-0.1千克/个', N'千克', N'137', N'日本')
/****** Object:  Table [dbo].[PI_MSTR_Remote]    Script Date: 09/19/2014 17:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PI_MSTR_Remote](
	[PI_NO] [nvarchar](12) NOT NULL,
	[PI_Date] [smalldatetime] NULL,
	[PI_Page] [nvarchar](2) NULL,
	[msrepl_synctran_ts] [timestamp] NOT NULL,
 CONSTRAINT [PK_PI_MSTR_Remote] PRIMARY KEY CLUSTERED 
(
	[PI_NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pi_mstr]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[PI_DET_Remote]    Script Date: 09/19/2014 17:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PI_DET_Remote](
	[PI_NO] [nvarchar](12) NOT NULL,
	[PI_LINE] [int] IDENTITY(172964,1) NOT NULL,
	[PI_CARTON_NO] [nvarchar](12) NULL,
	[PI_SITE] [nvarchar](6) NULL,
	[PI_PART] [nvarchar](18) NULL,
	[PI_CO] [nvarchar](10) NULL,
	[PI_DESC] [nvarchar](48) NULL,
	[PI_QTY] [numeric](18, 4) NULL,
	[PI_LOT] [nvarchar](12) NULL,
	[PI_NW] [numeric](18, 4) NULL,
	[PI_K200_NW] [numeric](18, 7) NULL,
	[PI_GW] [numeric](18, 4) NULL,
	[PI_SBU] [nchar](4) NULL,
	[PI_REC_NO] [nvarchar](15) NULL,
	[PI_PRICE] [numeric](18, 4) NULL,
	[PI_PALLET] [nvarchar](12) NULL,
	[PI_PO_price] [numeric](18, 4) NULL,
	[PI_CONTRACT] [char](18) NULL,
	[PI_SEQ] [int] NULL,
	[PI_SEQ_CL] [int] NULL,
	[PI_IQC] [char](4) NULL,
	[PI_PO] [char](8) NULL,
	[PI_Taxcode] [char](16) NULL,
	[PI_ConnCode] [char](8) NULL,
	[pi_user] [char](8) NULL,
	[pi_cre_time] [datetime] NULL,
	[pi_ver] [int] NULL,
	[pi_mfgr] [char](8) NULL,
	[pi_mfgr_part] [char](40) NULL,
	[pi_mfgr_name] [char](40) NULL,
	[pi_Lic_req] [char](3) NULL,
	[pi_ori_PO_price] [numeric](18, 4) NULL,
	[pi_PO_curr] [char](8) NULL,
	[pi_curr_rate] [numeric](18, 4) NULL,
	[pi_us_rate] [numeric](18, 4) NULL,
	[pi_vend] [char](8) NULL,
 CONSTRAINT [PK_PI_DET_Remote] PRIMARY KEY CLUSTERED 
(
	[PI_NO] DESC,
	[PI_LINE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pi_det]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[OCR_mstr]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[Irh_comp]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[co_mstr]    Script Date: 09/19/2014 17:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[co_mstr](
	[ab] [nvarchar](50) NULL,
	[abc] [nvarchar](50) NULL,
	[num] [nvarchar](50) NULL,
	[iso_3166_2] [nvarchar](50) NULL,
	[iso_en] [nvarchar](50) NULL,
	[china] [nvarchar](50) NULL,
	[tw] [nvarchar](50) NULL,
	[hk] [nvarchar](50) NULL,
	[remark] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AD', N'AND', N'20', N'ISO 3166-2:AD', N' Andorra', N'安道尔', N'安道尔', N'安道尔', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AE', N'ARE', N'784', N'ISO 3166-2:AE', N' United Arab Emirates', N'阿联酋', N'阿联', N'阿联酋', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AF', N'AFG', N'4', N'ISO 3166-2:AF', N' Afghanistan', N'阿富汗', N'阿富汗', N'阿富汗', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AG', N'ATG', N'28', N'ISO 3166-2:AG', N' Antigua and Barbuda', N'安提瓜和巴布达', N'安提瓜和巴布达', N'安提瓜和巴布达', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AI', N'AIA', N'660', N'ISO 3166-2:AI', N' Anguilla', N'安圭拉', N'英属安圭拉', N'安圭拉岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AL', N'ALB', N'8', N'ISO 3166-2:AL', N' Albania', N'阿尔巴尼亚', N'阿尔巴尼亚', N'阿尔巴尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AM', N'ARM', N'51', N'ISO 3166-2:AM', N' Armenia', N'亚美尼亚', N'亚美尼亚', N'亚美尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AO', N'AGO', N'24', N'ISO 3166-2:AO', N' Angola', N'安哥拉', N'安哥拉', N'安哥拉', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AQ', N'ATA', N'10', N'ISO 3166-2:AQ', N' Antarctica', N'南极洲', N'南极洲', N'南极洲', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AR', N'ARG', N'32', N'ISO 3166-2:AR', N' Argentina', N'阿根廷', N'阿根廷', N'南极洲', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AS', N'ASM', N'16', N'ISO 3166-2:AS', N' American Samoa', N'美属萨摩亚', N'美属萨摩亚', N'美属萨摩亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AT', N'AUT', N'40', N'ISO 3166-2:AT', N' Austria', N'奥地利', N'奥地利', N'奥地利', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AU', N'AUS', N'36', N'ISO 3166-2:AU', N' Australia', N'澳大利亚', N'澳洲', N'澳洲', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AW', N'ABW', N'533', N'ISO 3166-2:AW', N' Aruba', N'阿鲁巴', N'阿鲁巴', N'阿鲁巴', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AX', N'ALA', N'248', N'ISO 3166-2:AX', N' Åaland Islands', N'奥兰群岛', N'奥兰群岛', N'亚兰群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'AZ', N'AZE', N'31', N'ISO 3166-2:AZ', N' Azerbaijan', N'阿塞拜疆', N'亚塞拜然', N'阿塞拜疆', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BA', N'BIH', N'70', N'ISO 3166-2:BA', N' Bosnia and Herzegovina', N'波黑', N'波赫', N'波黑', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BB', N'BRB', N'52', N'ISO 3166-2:BB', N' Barbados', N'巴巴多斯', N'巴贝多', N'巴巴多斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BD', N'BGD', N'50', N'ISO 3166-2:BD', N' Bangladesh', N'孟加拉国', N'孟加拉', N'孟加拉', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BE', N'BEL', N'56', N'ISO 3166-2:BE', N' Belgium', N'比利时', N'比利时', N'比利时', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BF', N'BFA', N'854', N'ISO 3166-2:BF', N' Burkina Faso', N'布基纳法索', N'布基纳法索', N'布基纳法索', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BG', N'BGR', N'100', N'ISO 3166-2:BG', N' Bulgaria', N'保加利亚', N'保加利亚', N'保加利亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BH', N'BHR', N'48', N'ISO 3166-2:BH', N' Bahrain', N'巴林', N'巴林', N'巴林', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BI', N'BDI', N'108', N'ISO 3166-2:BI', N' Burundi', N'布隆迪', N'蒲隆地', N'布隆迪', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BJ', N'BEN', N'204', N'ISO 3166-2:BJ', N' Benin', N'贝宁', N'贝南', N'贝宁', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BL', N'BLM', N'652', N'ISO 3166-2:BL', N' Saint Barthélemy', N'圣巴泰勒米岛', N'圣巴瑟米', N'圣巴托洛缪岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BM', N'BMU', N'60', N'ISO 3166-2:BM', N' Bermuda', N'百慕大', N'百慕达', N'百慕达', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BN', N'BRN', N'96', N'ISO 3166-2:BN', N' Brunei Darussalam', N'文莱', N'汶莱', N'汶莱', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BO', N'BOL', N'68', N'ISO 3166-2:BO', N' Bolivia Plurinational', N'玻利维亚', N'玻利维亚', N'玻利维亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BQ', N'BES', N'535', N'ISO 3166-2:BQ', N' Bonaire Sint Eustatius and Saba', N'荷兰加勒比区', N'荷兰加勒比区', N'荷兰加勒比区', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BR', N'BRA', N'76', N'ISO 3166-2:BR', N' Brazil', N'巴西', N'巴西', N'巴西', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BS', N'BHS', N'44', N'ISO 3166-2:BS', N' Bahamas', N'巴哈马', N'巴哈马', N'巴哈马', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BT', N'BTN', N'64', N'ISO 3166-2:BT', N' Bhutan', N'不丹', N'不丹', N'不丹', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BV', N'BVT', N'74', N'ISO 3166-2:BV', N' Bouvet Island', N'布韦岛', N'布威岛', N'鲍威特岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BW', N'BWA', N'72', N'ISO 3166-2:BW', N' Botswana', N'博茨瓦纳', N'波札那', N'博茨瓦纳', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BY', N'BLR', N'112', N'ISO 3166-2:BY', N' Belarus', N'白俄罗斯', N'白俄罗斯', N'白俄罗斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'BZ', N'BLZ', N'84', N'ISO 3166-2:BZ', N' Belize', N'伯利兹', N'伯利兹', N'伯利兹', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CA', N'CAN', N'124', N'ISO 3166-2:CA', N' Canada', N'加拿大', N'加拿大', N'加拿大', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CC', N'CCK', N'166', N'ISO 3166-2:CC', N' Cocos (Keeling) Islands', N'科科斯群岛', N'可可斯群岛', N'科科斯群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CD', N'COD', N'180', N'ISO 3166-2:CD', N' Congo the Democratic Republic of the', N'刚果（金）', N'民主刚果', N'民主刚果', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CF', N'CAF', N'140', N'ISO 3166-2:CF', N' Central African Republic', N'中非', N'中非', N'中非', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CG', N'COG', N'178', N'ISO 3166-2:CG', N' Congo', N'刚果（布）', N'刚果', N'刚果', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CH', N'CHE', N'756', N'ISO 3166-2:CH', N' Switzerland', N'瑞士', N'瑞士', N'瑞士', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CI', N'CIV', N'384', N'ISO 3166-2:CI', N' Côte d''Ivoire', N'科特迪瓦', N'象牙海岸', N'科特迪瓦', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CK', N'COK', N'184', N'ISO 3166-2:CK', N' Cook Islands', N'库克群岛', N'库克群岛', N'库克群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CL', N'CHL', N'152', N'ISO 3166-2:CL', N' Chile', N'智利', N'智利', N'智利', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CM', N'CMR', N'120', N'ISO 3166-2:CM', N' Cameroon', N'喀麦隆', N'喀麦隆', N'喀麦隆', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CN', N'CHN', N'156', N'ISO 3166-2:CN', N' China', N'中国(内地)', N'大陆(中国)', N'大陆(内地)', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CO', N'COL', N'170', N'ISO 3166-2:CO', N' Colombia', N'哥伦比亚', N'哥伦比亚', N'哥伦比亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CR', N'CRI', N'188', N'ISO 3166-2:CR', N' Costa Rica', N'哥斯达黎加', N'哥斯大黎加', N'哥斯达黎加', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CU', N'CUB', N'192', N'ISO 3166-2:CU', N' Cuba', N'古巴', N'古巴', N'古巴', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CV', N'CPV', N'132', N'ISO 3166-2:CV', N' Cape Verde', N'佛得角', N'维德角', N'佛得角', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CW', N'CUW', N'531', N'ISO 3166-2:CW', N' Curaçao', N'库拉索', N'库拉索', N'库拉索', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CX', N'CXR', N'162', N'ISO 3166-2:CX', N' Christmas Island', N'圣诞岛', N'圣诞岛', N'圣诞岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CY', N'CYP', N'196', N'ISO 3166-2:CY', N' Cyprus', N'塞浦路斯', N'塞普勒斯', N'塞浦路斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'CZ', N'CZE', N'203', N'ISO 3166-2:CZ', N' Czech Republic', N'捷克', N'捷克', N'捷克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'DE', N'DEU', N'276', N'ISO 3166-2:DE', N' Germany', N'德国', N'德国', N'德国', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'DJ', N'DJI', N'262', N'ISO 3166-2:DJ', N' Djibouti', N'吉布提', N'吉布地', N'吉布提', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'DK', N'DNK', N'208', N'ISO 3166-2:DK', N' Denmark', N'丹麦', N'丹麦', N'丹麦', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'DM', N'DMA', N'212', N'ISO 3166-2:DM', N' Dominica', N'多米尼克', N'多米尼克', N'多米尼克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'DO', N'DOM', N'214', N'ISO 3166-2:DO', N' Dominican Republic', N'多米尼加', N'多明尼加', N'多明尼加', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'DZ', N'DZA', N'12', N'ISO 3166-2:DZ', N' Algeria', N'阿尔及利亚', N'阿尔及利亚', N'阿尔及利亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'EC', N'ECU', N'218', N'ISO 3166-2:EC', N' Ecuador', N'厄瓜多尔', N'厄瓜多', N'厄瓜多尔', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'EE', N'EST', N'233', N'ISO 3166-2:EE', N' Estonia', N'爱沙尼亚', N'爱沙尼亚', N'爱沙尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'EG', N'EGY', N'818', N'ISO 3166-2:EG', N' Egypt', N'埃及', N'埃及', N'埃及', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'EH', N'ESH', N'732', N'ISO 3166-2:EH', N' Western Sahara', N'西撒哈拉', N'西撒哈拉', N'西撒哈拉', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ER', N'ERI', N'232', N'ISO 3166-2:ER', N' Eritrea', N'厄立特里亚', N'厄立垂亚', N'厄立特里亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ES', N'ESP', N'724', N'ISO 3166-2:ES', N' Spain', N'西班牙', N'西班牙', N'西班牙', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ET', N'ETH', N'231', N'ISO 3166-2:ET', N' Ethiopia', N'埃塞俄比亚', N'衣索比亚', N'埃塞俄比亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'FI', N'FIN', N'246', N'ISO 3166-2:FI', N' Finland', N'芬兰', N'芬兰', N'芬兰', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'FJ', N'FJI', N'242', N'ISO 3166-2:FJ', N' Fiji', N'斐济群岛', N'斐济', N'斐济', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'FK', N'FLK', N'238', N'ISO 3166-2:FK', N' Falkland Islands (Malvinas)', N'马尔维纳斯群岛（福克兰）', N'福克兰群岛', N'福克兰群岛（马尔维纳斯）', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'FM', N'FSM', N'583', N'ISO 3166-2:FM', N' Micronesia Federated States of', N'密克罗尼西亚联邦', N'密克罗尼西亚联邦', N'密克罗尼西亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'FO', N'FRO', N'234', N'ISO 3166-2:FO', N' Faroe Islands', N'法罗群岛', N'法罗群岛', N'法罗群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'FR', N'FRA', N'250', N'ISO 3166-2:FR', N' France', N'法国', N'法国', N'法国', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GA', N'GAB', N'266', N'ISO 3166-2:GA', N' Gabon', N'加蓬', N'加蓬', N'加蓬', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GB', N'GBR', N'826', N'ISO 3166-2:GB', N' United Kingdom', N'英国', N'英国', N'英国', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GD', N'GRD', N'308', N'ISO 3166-2:GD', N' Grenada', N'格林纳达', N'格林纳达', N'格林纳达', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GE', N'GEO', N'268', N'ISO 3166-2:GE', N' Georgia', N'格鲁吉亚', N'乔治亚', N'格鲁吉亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GF', N'GUF', N'254', N'ISO 3166-2:GF', N' French Guiana', N'法属圭亚那', N'法属圭亚那', N'法属圭亚那', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GG', N'GGY', N'831', N'ISO 3166-2:GG', N' Guernsey', N'根西岛', N'根息岛', N'根西岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GH', N'GHA', N'288', N'ISO 3166-2:GH', N' Ghana', N'加纳', N'加纳', N'加纳', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GI', N'GIB', N'292', N'ISO 3166-2:GI', N' Gibraltar', N'直布罗陀', N'直布罗陀', N'直布罗陀', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GL', N'GRL', N'304', N'ISO 3166-2:GL', N' Greenland', N'格陵兰', N'格陵兰', N'格陵兰', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GM', N'GMB', N'270', N'ISO 3166-2:GM', N' Gambia', N'冈比亚', N'冈比亚', N'冈比亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GN', N'GIN', N'324', N'ISO 3166-2:GN', N' Guinea', N'几内亚', N'几内亚', N'几内亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GP', N'GLP', N'312', N'ISO 3166-2:GP', N' Guadeloupe', N'瓜德罗普', N'瓜德鲁普岛', N'瓜德鲁普岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GQ', N'GNQ', N'226', N'ISO 3166-2:GQ', N' Equatorial Guinea', N'赤道几内亚', N'赤道几内亚', N'赤道几内亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GR', N'GRC', N'300', N'ISO 3166-2:GR', N' Greece', N'希腊', N'希腊', N'希腊', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GS', N'SGS', N'239', N'ISO 3166-2:GS', N' South Georgia and the South Sandwich Islands', N'南乔治亚岛和南桑威奇群岛', N'南乔治亚与南三明治群岛', N'南乔治亚岛与南桑威奇群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GT', N'GTM', N'320', N'ISO 3166-2:GT', N' Guatemala', N'危地马拉', N'危地马拉', N'危地马拉', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GU', N'GUM', N'316', N'ISO 3166-2:GU', N' Guam', N'关岛', N'关岛', N'关岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GW', N'GNB', N'624', N'ISO 3166-2:GW', N' Guinea-Bissau', N'几内亚比绍', N'几内亚比绍', N'几内亚比绍', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'GY', N'GUY', N'328', N'ISO 3166-2:GY', N' Guyana', N'圭亚那', N'圭亚那', N'圭亚那', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'HK', N'HKG', N'344', N'ISO 3166-2:HK', N' Hong Kong', N'香港', N'香港', N'香港', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'HM', N'HMD', N'334', N'ISO 3166-2:HM', N' Heard Island and McDonald Islands', N'赫德岛和麦克唐纳群岛', N'赫德及麦当劳群岛', N'赫德岛和麦克唐纳群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'HN', N'HND', N'340', N'ISO 3166-2:HN', N' Honduras', N'洪都拉斯', N'洪都拉斯', N'洪都拉斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'HR', N'HRV', N'191', N'ISO 3166-2:HR', N' Croatia', N'克罗地亚', N'克罗地亚', N'克罗地亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'HT', N'HTI', N'332', N'ISO 3166-2:HT', N' Haiti', N'海地', N'海地', N'海地', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'HU', N'HUN', N'348', N'ISO 3166-2:HU', N' Hungary', N'匈牙利', N'匈牙利', N'匈牙利', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ID', N'IDN', N'360', N'ISO 3166-2:ID', N' Indonesia', N'印尼', N'印尼', N'印尼', NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IE', N'IRL', N'372', N'ISO 3166-2:IE', N' Ireland', N'爱尔兰', N'爱尔兰', N'爱尔兰', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IL', N'ISR', N'376', N'ISO 3166-2:IL', N' Israel', N'以色列', N'以色列', N'以色列', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IM', N'IMN', N'833', N'ISO 3166-2:IM', N' Isle of Man', N'马恩岛', N'马恩岛', N'马恩岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IN', N'IND', N'356', N'ISO 3166-2:IN', N' India', N'印度', N'印度', N'印度', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IO', N'IOT', N'86', N'ISO 3166-2:IO', N' British Indian Ocean Territory', N'英属印度洋领地', N'英属印度洋地区', N'英属印度洋地区', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IQ', N'IRQ', N'368', N'ISO 3166-2:IQ', N' Iraq', N'伊拉克', N'伊拉克', N'伊拉克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IR', N'IRN', N'364', N'ISO 3166-2:IR', N' Iran Islamic Republic of', N'伊朗', N'伊朗', N'伊朗', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IS', N'ISL', N'352', N'ISO 3166-2:IS', N' Iceland', N'冰岛', N'冰岛', N'冰岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'IT', N'ITA', N'380', N'ISO 3166-2:IT', N' Italy', N'意大利', N'意大利', N'意大利', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'JE', N'JEY', N'832', N'ISO 3166-2:JE', N' Jersey', N'泽西岛', N'泽西岛', N'泽西', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'JM', N'JAM', N'388', N'ISO 3166-2:JM', N' Jamaica', N'牙买加', N'牙买加', N'牙买加', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'JO', N'JOR', N'400', N'ISO 3166-2:JO', N' Jordan', N'约旦', N'约旦', N'约旦', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'JP', N'JPN', N'392', N'ISO 3166-2:JP', N' Japan', N'日本', N'日本', N'日本', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KE', N'KEN', N'404', N'ISO 3166-2:KE', N' Kenya', N'肯尼亚', N'肯尼亚', N'肯尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KG', N'KGZ', N'417', N'ISO 3166-2:KG', N' Kyrgyzstan', N'吉尔吉斯斯坦', N'吉尔吉斯', N'吉尔吉斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KH', N'KHM', N'116', N'ISO 3166-2:KH', N' Cambodia', N'柬埔寨', N'柬埔寨', N'柬埔寨', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KI', N'KIR', N'296', N'ISO 3166-2:KI', N' Kiribati', N'基里巴斯', N'基里巴斯', N'基里巴斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KM', N'COM', N'174', N'ISO 3166-2:KM', N' Comoros', N'科摩罗', N'科摩罗', N'科摩罗', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KN', N'KNA', N'659', N'ISO 3166-2:KN', N' Saint Kitts and Nevis', N'圣基茨和尼维斯', N'圣基茨和尼维斯', N'圣基茨和尼维斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KP', N'PRK', N'408', N'ISO 3166-2:KP', N' Korea Democratic People''s Republic of', N'朝鲜(北朝鲜)', N'北朝鲜', N'朝鲜', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KR', N'KOR', N'410', N'ISO 3166-2:KR', N' Korea Republic of', N'韩国(南朝鲜)', N'韩国', N'韩国', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KW', N'KWT', N'414', N'ISO 3166-2:KW', N' Kuwait', N'科威特', N'科威特', N'科威特', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KY', N'CYM', N'136', N'ISO 3166-2:KY', N' Cayman Islands', N'开曼群岛', N'开曼群岛', N'开曼群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'KZ', N'KAZ', N'398', N'ISO 3166-2:KZ', N' Kazakhstan', N'哈萨克斯坦', N'哈萨克', N'哈萨克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LA', N'LAO', N'418', N'ISO 3166-2:LA', N' Lao People''s Democratic Republic', N'老挝', N'寮国', N'老挝', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LB', N'LBN', N'422', N'ISO 3166-2:LB', N' Lebanon', N'黎巴嫩', N'黎巴嫩', N'黎巴嫩', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LC', N'LCA', N'662', N'ISO 3166-2:LC', N' Saint Lucia', N'圣卢西亚', N'圣卢西亚', N'圣卢西亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LI', N'LIE', N'438', N'ISO 3166-2:LI', N' Liechtenstein', N'列支敦士登', N'列支敦士登', N'列支敦士登', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LK', N'LKA', N'144', N'ISO 3166-2:LK', N' Sri Lanka', N'斯里兰卡', N'斯里兰卡', N'斯里兰卡', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LR', N'LBR', N'430', N'ISO 3166-2:LR', N' Liberia', N'利比里亚', N'利比里亚', N'利比里亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LS', N'LSO', N'426', N'ISO 3166-2:LS', N' Lesotho', N'莱索托', N'莱索托', N'莱索托', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LT', N'LTU', N'440', N'ISO 3166-2:LT', N' Lithuania', N'立陶宛', N'立陶宛', N'立陶宛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LU', N'LUX', N'442', N'ISO 3166-2:LU', N' Luxembourg', N'卢森堡', N'卢森堡', N'卢森堡', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LV', N'LVA', N'428', N'ISO 3166-2:LV', N' Latvia', N'拉脱维亚', N'拉脱维亚', N'拉脱维亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'LY', N'LBY', N'434', N'ISO 3166-2:LY', N' Libya', N'利比亚', N'利比亚', N'利比亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MA', N'MAR', N'504', N'ISO 3166-2:MA', N' Morocco', N'摩洛哥', N'摩洛哥', N'摩洛哥', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MC', N'MCO', N'492', N'ISO 3166-2:MC', N' Monaco', N'摩纳哥', N'摩纳哥', N'摩纳哥', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MD', N'MDA', N'498', N'ISO 3166-2:MD', N' Moldova Republic of', N'摩尔多瓦', N'摩尔多瓦', N'摩尔多瓦', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ME', N'MNE', N'499', N'ISO 3166-2:ME', N' Montenegro', N'黑山', N'蒙特内哥罗', N'黑山', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MF', N'MAF', N'663', N'ISO 3166-2:MF', N' Saint Martin (French part)', N'法属圣马丁', N'法属圣马丁　', N'法属圣马丁', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MG', N'MDG', N'450', N'ISO 3166-2:MG', N' Madagascar', N'马达加斯加', N'马达加斯加', N'马达加斯加', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MH', N'MHL', N'584', N'ISO 3166-2:MH', N' Marshall islands', N'马绍尔群岛', N'马绍尔群岛', N'马绍尔群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MK', N'MKD', N'807', N'ISO 3166-2:MK', N' Macedonia the former Yugoslav Republic of', N'马其顿', N'马其顿', N'马其顿', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ML', N'MLI', N'466', N'ISO 3166-2:ML', N' Mali', N'马里', N'马利', N'马里', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MM', N'MMR', N'104', N'ISO 3166-2:MM', N' Myanmar', N'缅甸', N'缅甸', N'缅甸', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MN', N'MNG', N'496', N'ISO 3166-2:MN', N' Mongolia', N'蒙古国；蒙古', N'蒙古', N'蒙古国', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MO', N'MAC', N'446', N'ISO 3166-2:MO', N' Macao', N'澳门', N'澳门', N'澳门', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MP', N'MNP', N'580', N'ISO 3166-2:MP', N' Northern Mariana Islands', N'北马里亚纳群岛', N'北马里亚纳群岛', N'北马里亚纳群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MQ', N'MTQ', N'474', N'ISO 3166-2:MQ', N' Martinique', N'马提尼克', N'法属马丁尼克', N'马提尼克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MR', N'MRT', N'478', N'ISO 3166-2:MR', N' Mauritania', N'毛里塔尼亚', N'毛里塔尼亚', N'毛里塔尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MS', N'MSR', N'500', N'ISO 3166-2:MS', N' Montserrat', N'蒙塞拉特岛', N'蒙塞拉特岛', N'蒙塞拉特岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MT', N'MLT', N'470', N'ISO 3166-2:MT', N' Malta', N'马耳他', N'马耳他', N'马耳他', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MU', N'MUS', N'480', N'ISO 3166-2:MU', N' Mauritius', N'毛里求斯', N'毛里求斯', N'毛里求斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MV', N'MDV', N'462', N'ISO 3166-2:MV', N' Maldives', N'马尔代夫', N'马尔代夫', N'马尔代夫', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MW', N'MWI', N'454', N'ISO 3166-2:MW', N' Malawi', N'马拉维', N'马拉维', N'马拉维', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MX', N'MEX', N'484', N'ISO 3166-2:MX', N' Mexico', N'墨西哥', N'墨西哥', N'墨西哥', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MY', N'MYS', N'458', N'ISO 3166-2:MY', N' Malaysia', N'马来西亚', N'马来西亚', N'马来西亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'MZ', N'MOZ', N'508', N'ISO 3166-2:MZ', N' Mozambique', N'莫桑比克', N'莫桑比克', N'莫桑比克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NA', N'NAM', N'516', N'ISO 3166-2:NA', N' Namibia', N'纳米比亚', N'纳米比亚', N'纳米比亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NC', N'NCL', N'540', N'ISO 3166-2:NC', N' New Caledonia', N'新喀里多尼亚', N'新喀里多尼亚岛', N'新喀里多尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NE', N'NER', N'562', N'ISO 3166-2:NE', N' Niger', N'尼日尔', N'尼日', N'尼日尔', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NF', N'NFK', N'574', N'ISO 3166-2:NF', N' Norfolk Island', N'诺福克岛', N'诺福克岛', N'诺福克岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NG', N'NGA', N'566', N'ISO 3166-2:NG', N' Nigeria', N'尼日利亚', N'尼日利亚', N'尼日利亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NI', N'NIC', N'558', N'ISO 3166-2:NI', N' Nicaragua', N'尼加拉瓜', N'尼加拉瓜', N'尼加拉瓜', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NK', N'NKR', N'296', N'ISO 3166-2:NK', N' Nagorno-Karabakh', N'纳戈尔诺-卡拉巴赫', N'纳戈尔诺-卡拉巴赫', N'纳戈尔诺-卡拉巴赫', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NL', N'NLD', N'528', N'ISO 3166-2:NL', N' Netherlands', N'荷兰', N'荷兰', N'荷兰', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NO', N'NOR', N'578', N'ISO 3166-2:NO', N' Norway', N'挪威', N'挪威', N'挪威', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NP', N'NPL', N'524', N'ISO 3166-2:NP', N' Nepal', N'尼泊尔', N'尼泊尔', N'尼泊尔', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NR', N'NRU', N'520', N'ISO 3166-2:NR', N' Nauru', N'瑙鲁', N'瑙鲁', N'瑙鲁', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NU', N'NIU', N'570', N'ISO 3166-2:NU', N' Niue', N'纽埃', N'纽埃', N'纽埃', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'NZ', N'NZL', N'554', N'ISO 3166-2:NZ', N' New Zealand', N'新西兰', N'新西兰', N'新西兰', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'OM', N'OMN', N'512', N'ISO 3166-2:OM', N' Oman', N'阿曼', N'阿曼', N'阿曼', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PA', N'PAN', N'591', N'ISO 3166-2:PA', N' Panama', N'巴拿马', N'巴拿马', N'巴拿马', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PE', N'PER', N'604', N'ISO 3166-2:PE', N' Peru', N'秘鲁', N'秘鲁', N'秘鲁', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PF', N'PYF', N'258', N'ISO 3166-2:PF', N' French Polynesia', N'法属波利尼西亚', N'法属波利尼西亚', N'法属波利尼西亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PG', N'PNG', N'598', N'ISO 3166-2:PG', N' Papua New Guinea', N'巴布亚新几内亚', N'巴布亚新几内亚', N'巴布亚新几内亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PH', N'PHL', N'608', N'ISO 3166-2:PH', N' Philippines', N'菲律宾', N'菲律宾', N'菲律宾', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PK', N'PAK', N'586', N'ISO 3166-2:PK', N' Pakistan', N'巴基斯坦', N'巴基斯坦', N'巴基斯坦', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PL', N'POL', N'616', N'ISO 3166-2:PL', N' Poland', N'波兰', N'波兰', N'波兰', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PM', N'SPM', N'666', N'ISO 3166-2:PM', N' Saint Pierre and Miquelon', N'圣皮埃尔和密克隆', N'圣皮耶与密克隆群岛', N'圣皮埃尔岛和密克隆岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PN', N'PCN', N'612', N'ISO 3166-2:PN', N' Pitcairn Islands', N'皮特凯恩群岛', N'皮特康岛', N'皮特凯恩群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PR', N'PRI', N'630', N'ISO 3166-2:PR', N' Puerto Rico', N'波多黎各', N'波多黎各', N'波多黎各', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PS', N'PSE', N'275', N'ISO 3166-2:PS', N' Palestine State of', N'巴勒斯坦', N'巴勒斯坦', N'巴勒斯坦', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PT', N'PRT', N'620', N'ISO 3166-2:PT', N' Portugal', N'葡萄牙', N'葡萄牙', N'葡萄牙', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PW', N'PLW', N'585', N'ISO 3166-2:PW', N' Palau', N'帕劳', N'帕劳', N'帕劳；帕劳', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'PY', N'PRY', N'600', N'ISO 3166-2:PY', N' Paraguay', N'巴拉圭', N'巴拉圭', N'巴拉圭', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'QA', N'QAT', N'634', N'ISO 3166-2:QA', N' Qatar', N'卡塔尔', N'卡达', N'卡塔尔', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'RE', N'REU', N'638', N'ISO 3166-2:RE', N' Réunion', N'留尼汪', N'留尼汪', N'留尼汪', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'RO', N'ROU', N'642', N'ISO 3166-2:RO', N' Romania', N'罗马尼亚', N'罗马尼亚', N'罗马尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'RS', N'SRB', N'688', N'ISO 3166-2:RS', N' Serbia', N'塞尔维亚', N'塞尔维亚', N'塞尔维亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'RU', N'RUS', N'643', N'ISO 3166-2:RU', N' Russian Federation', N'俄罗斯', N'俄罗斯', N'俄罗斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'RW', N'RWA', N'646', N'ISO 3166-2:RW', N' Rwanda', N'卢旺达', N'卢旺达', N'卢旺达', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SA', N'SAU', N'682', N'ISO 3166-2:SA', N' Saudi Arabia', N'沙特阿拉伯', N'沙特阿拉伯', N'沙特阿拉伯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SB', N'SLB', N'90', N'ISO 3166-2:SB', N' Solomon Islands', N'所罗门群岛', N'所罗门群岛', N'所罗门群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SC', N'SYC', N'690', N'ISO 3166-2:SC', N' Seychelles', N'塞舌尔', N'塞舌尔', N'塞舌尔', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SD', N'SDN', N'729', N'ISO 3166-2:SD', N' Sudan', N'苏丹', N'苏丹', N'苏丹', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SE', N'SWE', N'752', N'ISO 3166-2:SE', N' Sweden', N'瑞典', N'瑞典', N'瑞典', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SG', N'SGP', N'702', N'ISO 3166-2:SG', N' Singapore', N'新加坡', N'新加坡(星加坡)', N'新加坡(星加坡)', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SH', N'SHN', N'654', N'ISO 3166-2:SH', N' Saint Helena Ascension and Tristan da Cunha', N'圣赫勒拿', N'圣赫勒拿岛', N'圣赫勒拿', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SI', N'SVN', N'705', N'ISO 3166-2:SI', N' Slovenia', N'斯洛文尼亚', N'斯洛文尼亚', N'斯洛文尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SJ', N'SJM', N'744', N'ISO 3166-2:SJ', N' Svalbard and Jan Mayen', N'斯瓦尔巴群岛和扬马延岛', N'斯瓦巴及尖棉岛', N'斯瓦尔巴特群岛', NULL)
GO
print 'Processed 200 total records'
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SK', N'SVK', N'703', N'ISO 3166-2:SK', N' Slovakia', N'斯洛伐克', N'斯洛伐克', N'斯洛伐克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SL', N'SLE', N'694', N'ISO 3166-2:SL', N' Sierra Leone', N'塞拉利昂', N'狮子山', N'塞拉利昂', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SM', N'SMR', N'674', N'ISO 3166-2:SM', N' San Marino', N'圣马力诺', N'圣马力诺', N'圣马力诺', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SN', N'SEN', N'686', N'ISO 3166-2:SN', N' Senegal', N'塞内加尔', N'塞内加尔', N'塞内加尔', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SO', N'SOM', N'706', N'ISO 3166-2:SO', N' Somalia', N'索马里', N'索马里', N'索马里', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SR', N'SUR', N'740', N'ISO 3166-2:SR', N' Suriname', N'苏里南', N'苏里南', N'苏里南', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SS', N'SSD', N'728', N'ISO 3166-2:SS', N' South Sudan', N'南苏丹', N'南苏丹', N'南苏丹', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ST', N'STP', N'678', N'ISO 3166-2:ST', N' Sao Tome and Principe', N'圣多美和普林西比', N'圣多美普林西比', N'圣多美及普林西比', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SV', N'SLV', N'222', N'ISO 3166-2:SV', N' El Salvador', N'萨尔瓦多', N'萨尔瓦多', N'萨尔瓦多', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SX', N'SXM', N'534', N'ISO 3166-2:SX', N' Sint Maarten (Dutch part)', N'荷属圣马丁', N'荷属圣马丁', N'荷属圣马丁', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SY', N'SYR', N'760', N'ISO 3166-2:SY', N' Syrian Arab Republic', N'叙利亚', N'叙利亚', N'叙利亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'SZ', N'SWZ', N'748', N'ISO 3166-2:SZ', N' Swaziland', N'斯威士兰', N'斯威士兰', N'斯威士兰', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TC', N'TCA', N'796', N'ISO 3166-2:TC', N' Turks and Caicos Islands', N'特克斯和凯科斯群岛', N'土克斯及开科斯群岛', N'特克斯和凯科斯群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TD', N'TCD', N'148', N'ISO 3166-2:TD', N' Chad', N'乍得', N'查德', N'乍得', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TF', N'ATF', N'260', N'ISO 3166-2:TF', N' French Southern Territories', N'法属南部领地', N'法属南部属地', N'法属南部地区', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TG', N'TGO', N'768', N'ISO 3166-2:TG', N' Togo', N'多哥', N'多哥', N'多哥', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TH', N'THA', N'764', N'ISO 3166-2:TH', N' Thailand', N'泰国', N'泰国', N'泰国', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TJ', N'TJK', N'762', N'ISO 3166-2:TJ', N' Tajikistan', N'塔吉克斯坦', N'塔吉克', N'塔吉克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TK', N'TKL', N'772', N'ISO 3166-2:TK', N' Tokelau', N'托克劳', N'托克劳群岛', N'托克劳群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TL', N'TLS', N'626', N'ISO 3166-2:TP', N' Timor-Leste', N'东帝汶', N'东帝汶', N'东帝汶', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TM', N'TKM', N'795', N'ISO 3166-2:TM', N' Turkmenistan', N'土库曼斯坦', N'土库曼', N'土库曼', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TN', N'TUN', N'788', N'ISO 3166-2:TN', N' Tunisia', N'突尼斯', N'突尼斯', N'突尼斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TO', N'TON', N'776', N'ISO 3166-2:TO', N' Tonga', N'汤加', N'东加', N'汤加', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TR', N'TUR', N'792', N'ISO 3166-2:TR', N' Turkey', N'土耳其', N'土耳其', N'土耳其', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TT', N'TTO', N'780', N'ISO 3166-2:TT', N' Trinidad and Tobago', N'特立尼达和多巴哥', N'特立尼达和多巴哥', N'特立尼达和多巴哥', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TV', N'TUV', N'798', N'ISO 3166-2:TV', N' Tuvalu', N'图瓦卢', N'吐瓦鲁', N'图瓦卢', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TW', N'TWN', N'158', N'ISO 3166-2:TW', N' Taiwan Province of China', N'台湾', N'台湾(中华民国)', N'台湾', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'TZ', N'TZA', N'834', N'ISO 3166-2:TZ', N' Tanzania United Republic of', N'坦桑尼亚', N'坦桑尼亚', N'坦桑尼亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'UA', N'UKR', N'804', N'ISO 3166-2:UA', N' Ukraine', N'乌克兰', N'乌克兰', N'乌克兰', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'UG', N'UGA', N'800', N'ISO 3166-2:UG', N' Uganda', N'乌干达', N'乌干达', N'乌干达', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'UM', N'UMI', N'581', N'ISO 3166-2:UM', N' United States Minor Outlying Islands', N'美国本土外小岛屿', N'美国边疆小岛', N'美国海外小岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'US', N'USA', N'840', N'ISO 3166-2:US', N' United States', N'美国', N'美国', N'美国', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'UY', N'URY', N'858', N'ISO 3166-2:UY', N' Uruguay', N'乌拉圭', N'乌拉圭', N'乌拉圭', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'UZ', N'UZB', N'860', N'ISO 3166-2:UZ', N' Uzbekistan', N'乌兹别克斯坦', N'乌兹别克', N'乌兹别克', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'VA', N'VAT', N'336', N'ISO 3166-2:VA', N' Holy See (Vatican City State)', N'梵蒂冈', N'梵蒂冈', N'梵蒂冈', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'VC', N'VCT', N'670', N'ISO 3166-2:VC', N' Saint Vincent and the Grenadines', N'圣文森特和格林纳丁斯', N'圣文森特和格林纳丁斯', N'圣文森特和格林纳丁斯', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'VE', N'VEN', N'862', N'ISO 3166-2:VE', N' Venezuela Bolivarian Republic of', N'委内瑞拉', N'委内瑞拉', N'委内瑞拉', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'VG', N'VGB', N'92', N'ISO 3166-2:VG', N' Virgin Islands U.S.', N'英属维尔京群岛', N'英属维尔京群岛', N'英属处女群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'VI', N'VIR', N'850', N'ISO 3166-2:VI', N' United States Virgin Islands', N'美属维尔京群岛', N'美属维尔京群岛', N'美属处女群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'VN', N'VNM', N'704', N'ISO 3166-2:VN', N' Vietnam', N'越南', N'越南', N'越南', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'VU', N'VUT', N'548', N'ISO 3166-2:VU', N' Vanuatu', N'瓦努阿图', N'瓦努阿图', N'瓦努阿图', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'WF', N'WLF', N'876', N'ISO 3166-2:WF', N' Wallis and Futuna', N'瓦利斯和富图纳', N'沃里斯与伏塔那岛', N'瓦利斯群岛和富图纳群岛', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'WS', N'WSM', N'882', N'ISO 3166-2:WS', N' Samoa', N'萨摩亚', N'萨摩亚', N'萨摩亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'YE', N'YEM', N'887', N'ISO 3166-2:YE', N' Yemen', N'也门', N'也门', N'也门', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'YT', N'MYT', N'175', N'ISO 3166-2:YT', N' Mayotte', N'马约特', N'美亚特', N'马约特', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ZA', N'ZAF', N'710', N'ISO 3166-2:ZA', N' South Africa', N'南非', N'南非', N'南非', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ZM', N'ZMB', N'894', N'ISO 3166-2:ZM', N' Zambia', N'赞比亚', N'赞比亚', N'赞比亚', NULL)
INSERT [dbo].[co_mstr] ([ab], [abc], [num], [iso_3166_2], [iso_en], [china], [tw], [hk], [remark]) VALUES (N'ZW', N'ZWE', N'716', N'ISO 3166-2:ZW', N' Zimbabwe', N'津巴布韦', N'津巴布韦', N'津巴布韦', NULL)
/****** Object:  Table [dbo].[ticketingPTMR]    Script Date: 09/19/2014 17:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ticketingPTMR](
	[t_id] [nvarchar](50) NOT NULL,
	[t_suppliers_id] [nvarchar](50) NOT NULL,
	[t_inDocTime] [datetime] NULL,
	[t_backTime] [datetime] NULL,
	[t_outWait] [nvarchar](50) NULL,
	[t_receTime] [datetime] NULL,
	[t_outAwayTime] [datetime] NULL,
	[t_waitTime] [datetime] NULL,
	[t_totalTime] [datetime] NULL,
	[t_time01] [datetime] NULL,
	[t_time02] [datetime] NULL,
	[t_cre_date] [datetime] NULL,
	[t_update_date] [datetime] NULL,
	[t_cre_user] [nvarchar](50) NULL,
	[t_user_ip] [nvarchar](50) NULL,
	[t_chr01] [nvarchar](50) NULL,
	[t_chr02] [nvarchar](50) NULL,
	[t_chr03] [nvarchar](50) NULL,
	[t_dec01] [decimal](18, 5) NULL,
	[t_dec02] [decimal](18, 5) NULL,
	[t_int01] [int] NULL,
	[t_int02] [int] NULL,
 CONSTRAINT [PK_TicketingProcessTimeMeasurement] PRIMARY KEY CLUSTERED 
(
	[t_id] DESC,
	[t_suppliers_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_userInrole]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  Table [dbo].[sys_user]    Script Date: 09/19/2014 17:32:43 ******/
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
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'demo', N'WWTS', N'87EC83741750EE520A044896A28B4DB5', N'', N'', CAST(0x0000A3AB00D4B5D0 AS DateTime), CAST(0x0000A38E00A2123C AS DateTime), N'', N'', N'142.2.47.149', N'142.2.47.149', N'T')
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'gx.li', N'WWTS', N'6F27AFF1C4FEDAD2CB6B439DA4DE9A56', N'', N'', CAST(0x0000A38D01044160 AS DateTime), CAST(0x0000A38D0103A844 AS DateTime), N'', N'', N'142.2.64.22', N'', N'T')
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'ling.xie', N'WWTS', N'681B03E018CB2B9CFEA8F119BA936A7C36D150E54B782C76', N'', N'', CAST(0x0000A3A800AA4960 AS DateTime), CAST(0x0000A38C01295BD4 AS DateTime), N'', N'', N'142.2.47.149', N'142.2.47.149', N'T')
/****** Object:  Table [dbo].[sys_role]    Script Date: 09/19/2014 17:32:43 ******/
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
/****** Object:  View [dbo].[vpi_report]    Script Date: 09/19/2014 17:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vpi_report]
AS
SELECT     a.PI_ID, a.pi_LineID, a.pi_wec_ctn, a.plr_LineID_tran, a.pi_deci1 AS pi_pallet_no, a.CartonNo, a.CartonID, a.pi_chr01, b.pisr_rir, b.pisr_invoice, b.pisr_part, 
                      b.Pisr_receiver, b.pisr_site, b.pisr_po_nbr, b.pisr_qty, b.pisr_curr, b.pisr_cost, b.pisr_base_cost, b.pisr_us_cost, b.pisr_seq, b.pisr_con_code, c.sq_name, 
                      b.pisr_net_wt, b.pisr_rec_type, b.pisr_abc, b.pisr_code, b.pisr_lic_req, b.pisr_sbu, b.pisr_vend, b.pisr_mfgr_name, b.pisr_dec01, b.pisr_dec02, a.pi_status, 
                      a.pi_pallet_no AS Pallet_TTL_NW, a.pi_cre_date
FROM         dbo.pi_det AS a LEFT OUTER JOIN
                      dbo.pisr_grr AS b ON a.pi_wec_ctn = b.pi_wec_ctn AND a.plr_LineID_tran = b.plr_LineID_tran LEFT OUTER JOIN
                      dbo.pi_sq AS c ON b.pisr_seq = c.sq_id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[22] 4[40] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 203
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 6
               Left = 241
               Bottom = 125
               Right = 406
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 6
               Left = 444
               Bottom = 125
               Right = 586
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vpi_report'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vpi_report'
GO
/****** Object:  View [dbo].[vpi_detApisr_grr]    Script Date: 09/19/2014 17:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vpi_detApisr_grr]
AS
SELECT     a.PI_ID, a.pi_LineID, a.pi_wec_ctn, a.plr_LineID_tran, a.pi_deci1 AS pi_pallet_no, a.CartonNo, a.CartonID, a.pi_chr01, b.pisr_rir, b.pisr_invoice, b.pisr_part, 
                      b.Pisr_receiver, b.pisr_site, b.pisr_po_nbr, b.pisr_qty, b.pisr_curr, b.pisr_cost, b.pisr_base_cost, b.pisr_us_cost, b.pisr_seq, b.pisr_con_code, c.sq_name, 
                      b.pisr_net_wt, b.pisr_rec_type, b.pisr_abc, b.pisr_code, b.pisr_lic_req, b.pisr_sbu, b.pisr_vend, b.pisr_mfgr_name, b.pisr_dec01, b.pisr_dec02, a.pi_status, 
                      a.pi_pallet_no AS Pallet_TTL_NW, a.pi_cre_date
FROM         dbo.pi_det AS a LEFT OUTER JOIN
                      dbo.pisr_grr AS b ON a.pi_wec_ctn = b.pi_wec_ctn AND a.plr_LineID_tran = b.plr_LineID_tran LEFT OUTER JOIN
                      dbo.pi_sq AS c ON b.pisr_seq = c.sq_id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 190
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 6
               Left = 241
               Bottom = 215
               Right = 406
            End
            DisplayFlags = 280
            TopColumn = 21
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 6
               Left = 444
               Bottom = 125
               Right = 586
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vpi_detApisr_grr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vpi_detApisr_grr'
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTID]    Script Date: 09/19/2014 17:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<xlgwr>
-- Create date: <06/10/2014>
-- Description:	<Generate Company info for packing list upload>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetTID]
(
 @TID varchar(11) output
)
AS
declare @max_TID varchar(11),
		@seq int,
		@iSeq int

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- gen location and company inforamtion here  BatchID Sample: R1406050003
    --select top 1 @max_TID = Batch_ID from plr_mstr order by Batch_ID desc,plr_cre_date desc
    --select top 1 @max_TID =  batch_id from [dbo].[plr_batch_mstr] order by batch_id desc, batch_cre_date desc
    select top 1 @seq = ctl_curr from dbo.pkey_ctl where t_name='ticketingPTMR' and t_value ='t_id'
    if @seq is null 
    begin
			set @TID = 'T' + right(convert(char(4),YEAR(GETDATE())),2) + cast( Right(100+Month(GetDate()),2) as char(2)) + cast( Right(100+Day(GetDate()),2)   as char(2)) + '0001'
			insert dbo.pkey_ctl (t_name,t_value,t_desc,ctl_curr) values ('ticketingPTMR','t_id',@TID,1)
	end
    else
    begin
		set @seq =@seq + 1
		
		if @seq>=9999
		    begin
			 update dbo.pkey_ctl set ctl_curr=1 where  t_name='ticketingPTMR' and t_value ='t_id'
			 set @seq=1
			end
			
		--select REPLICATE('0',4-len(cast(1 as varchar(4))))+cast(1 as varchar(4))
		set @TID = 'T' + right(convert(char(4),YEAR(GETDATE())),2) + cast( Right(100+Month(GetDate()),2) as char(2)) + cast( Right(100+Day(GetDate()),2)   as char(2))  + REPLICATE('0',4-len(cast(@seq as varchar(4))))+cast(@seq as varchar(4))
		update dbo.pkey_ctl set ctl_curr=@seq,t_desc=@TID where   t_name='ticketingPTMR' and t_value ='t_id'
	end
	
    return
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetPIID]    Script Date: 09/19/2014 17:32:46 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetBatchID]    Script Date: 09/19/2014 17:32:46 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Get_WecCtnPre]    Script Date: 09/19/2014 17:32:46 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GenCtn_Tran]    Script Date: 09/19/2014 17:32:46 ******/
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
/****** Object:  Default [DF_plr_batch_mstr_Batch_void]    Script Date: 09/19/2014 17:32:43 ******/
ALTER TABLE [dbo].[plr_batch_mstr] ADD  CONSTRAINT [DF_plr_batch_mstr_Batch_void]  DEFAULT ((1)) FOR [batch_void]
GO
/****** Object:  Default [DF_Plr_mstr_plr_void_status]    Script Date: 09/19/2014 17:32:43 ******/
ALTER TABLE [dbo].[plr_mstr] ADD  CONSTRAINT [DF_Plr_mstr_plr_void_status]  DEFAULT ((0)) FOR [plr_void_status]
GO
/****** Object:  Default [DF_Plr_mstr_err_plr_void_status]    Script Date: 09/19/2014 17:32:43 ******/
ALTER TABLE [dbo].[plr_mstr_err] ADD  CONSTRAINT [DF_Plr_mstr_err_plr_void_status]  DEFAULT ((1)) FOR [plr_void_status]
GO
