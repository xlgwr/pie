USE [PIE]
GO
/****** Object:  Table [dbo].[plr_mstr_tran]    Script Date: 09/09/2014 17:27:00 ******/
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
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 1, 71, N'U', N'OK', N'330', N'330', N'100000000071', N'10733503', N'60153110R7GB', N'1', CAST(84 AS Decimal(18, 0)), CAST(84 AS Decimal(18, 0)), N'', N'20140909010', N'140909010', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'CANI00', N'60153110R7GB', N'', N'', CAST(0x0000A3A1010B20BA AS DateTime), N'', CAST(0x0000A3A101094833 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 2, 72, N'U', N'OK', N'331', N'331', N'100000000072', N'10734787', N'60247467R1F', N'1', CAST(8000 AS Decimal(18, 0)), CAST(8000 AS Decimal(18, 0)), N'', N'20140909010', N'140909010', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'cani00', N'60247467R1F', N'', N'', CAST(0x0000A3A1010B20BB AS DateTime), N'', CAST(0x0000A3A101094CCB AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 3, 73, N'U', N'OK', N'332', N'332', N'100000000073', N'10730695', N'60125090R1F', N'1', CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), N'', N'20140909010', N'140909010', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'CANI00', N'60125090R1F', N'', N'', CAST(0x0000A3A1010B20BD AS DateTime), N'', CAST(0x0000A3A10109506F AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 4, 74, N'U', N'OK', N'333', N'333', N'100000000074', N'10734226', N'60143310R3F', N'1', CAST(1000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), N'', N'20140909010', N'140909010', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'cani00', N'M0007158-01(Rev E)', N'', N'', CAST(0x0000A3A1010B20BF AS DateTime), N'', CAST(0x0000A3A1010953E6 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 5, 75, N'U', N'OK', N'334', N'334', N'100000000075', N'10733267', N'60115001R3F', N'1', CAST(2000 AS Decimal(18, 0)), CAST(2000 AS Decimal(18, 0)), N'', N'20140909010', N'140909010', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'CANI00', N'60115001R3F', N'', N'', CAST(0x0000A3A1010B20C1 AS DateTime), N'', CAST(0x0000A3A1010957F4 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 1, 30, N'U', N'OK', N'222', N'222', N'100000000030', N'10729558', N'57RM1-2321-00AR4F1', N'1', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), N'', N'20140909005', N'140909005', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'TAKN00', N'RM1-2321 HIS:004', N'', N'', CAST(0x0000A3A10106B2DD AS DateTime), N'', CAST(0x0000A3A10104F4B6 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'Yes', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 2, 30, N'U', N'OK', N'222', N'222', N'100000000030', N'10729558', N'57RM1-2321-00AR4F1', N'1', CAST(663 AS Decimal(18, 0)), CAST(663 AS Decimal(18, 0)), N'', N'20140909005', N'140909005', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'TAKN00', N'RM1-2321 HIS:004', N'', N'', CAST(0x0000A3A10106B2DF AS DateTime), N'', CAST(0x0000A3A10104F4B8 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'Yes', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 3, 30, N'U', N'OK', N'222', N'222', N'100000000030', N'10731057', N'57RM1-2321-000R1F1', N'1', CAST(1337 AS Decimal(18, 0)), CAST(1337 AS Decimal(18, 0)), N'', N'20140909005', N'140909005', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'TAKN00', N'RM1-2321 HIS:004', N'', N'', CAST(0x0000A3A10106B2E1 AS DateTime), N'', CAST(0x0000A3A10104F4BA AS DateTime), N'', N'142.2.47.149', 0, N'S', N'Yes', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 4, 30, N'U', N'OK', N'222', N'222', N'100000000030', N'10731057', N'57RM1-2390-00AR5F1', N'1', CAST(742 AS Decimal(18, 0)), CAST(742 AS Decimal(18, 0)), N'', N'20140909005', N'140909005', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'TAKN00', N'RM1-2390 HIS:005', N'', N'', CAST(0x0000A3A10106B2E2 AS DateTime), N'', CAST(0x0000A3A10104F4BB AS DateTime), N'', N'142.2.47.149', 0, N'S', N'Yes', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 5, 30, N'U', N'OK', N'222', N'222', N'100000000030', N'10731057', N'57RM1-2390-00AR5F1', N'1', CAST(18000 AS Decimal(18, 0)), CAST(18000 AS Decimal(18, 0)), N'', N'20140909005', N'140909005', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'TAKN00', N'RM1-2390 HIS:005', N'', N'', CAST(0x0000A3A10106B2E4 AS DateTime), N'', CAST(0x0000A3A10104F4BD AS DateTime), N'', N'142.2.47.149', 0, N'S', N'Yes', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 6, 30, N'U', N'OK', N'222', N'222', N'100000000030', N'10731057', N'57RM1-2390-00AR5F1', N'1', CAST(258 AS Decimal(18, 0)), CAST(258 AS Decimal(18, 0)), N'', N'20140909005', N'140909005', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'TAKN00', N'RM1-2390 HIS:005', N'', N'', CAST(0x0000A3A10106B2E6 AS DateTime), N'', CAST(0x0000A3A10104F4BE AS DateTime), N'', N'142.2.47.149', 0, N'S', N'Yes', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 1, 26, N'E', N'Already Exist Data', N'J1', N'J1', N'100000000026', N'10732382', N'61467633R1F', N'1', CAST(90 AS Decimal(18, 0)), CAST(90 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'gzsc00', N'61467633R1F', N'', N'', CAST(0x0000A3A101030DFA AS DateTime), N'', CAST(0x0000A3A1011694C6 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 2, 26, N'E', N'Already Exist Data', N'J1', N'J1', N'100000000026', N'10732531', N'61538370R3F', N'1', CAST(300 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61538370R3F', N'', N'', CAST(0x0000A3A101030E04 AS DateTime), N'', CAST(0x0000A3A1011694E7 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 3, 26, N'E', N'Already Exist Data', N'J1', N'J1', N'100000000026', N'10735022', N'61552451R1F', N'1', CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61552451R1F', N'', N'', CAST(0x0000A3A101030E06 AS DateTime), N'', CAST(0x0000A3A101169500 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 4, 27, N'E', N'Already Exist Data', N'J2', N'J2', N'100000000027', N'10730699', N'61552453R1F', N'1', CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61552453R1F', N'', N'', CAST(0x0000A3A101030E08 AS DateTime), N'', CAST(0x0000A3A101169508 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 5, 28, N'E', N'Already Exist Data', N'J3', N'J3', N'100000000028', N'10730699', N'61566461R1F', N'1', CAST(300 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61566461R1F', N'', N'', CAST(0x0000A3A101030E0C AS DateTime), N'', CAST(0x0000A3A101169512 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 6, 28, N'E', N'Already Exist Data', N'J3', N'J3', N'100000000028', N'10730699', N'61566461R1F', N'1', CAST(300 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61566461R1F', N'', N'', CAST(0x0000A3A101030E0E AS DateTime), N'', CAST(0x0000A3A10116951E AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 7, 29, N'E', N'Already Exist Data', N'J4', N'J4', N'100000000029', N'10730698', N'61427403R1F', N'1', CAST(400 AS Decimal(18, 0)), CAST(400 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61427403R1F', N'', N'', CAST(0x0000A3A101030E10 AS DateTime), N'', CAST(0x0000A3A101169526 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 8, 29, N'E', N'Already Exist Data', N'J4', N'J4', N'100000000029', N'10730241', N'61538372R3F', N'1', CAST(1500 AS Decimal(18, 0)), CAST(1500 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61538372R3F', N'', N'', CAST(0x0000A3A101030E12 AS DateTime), N'', CAST(0x0000A3A10116952F AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 9, 29, N'E', N'Already Exist Data', N'J4', N'J4', N'100000000029', N'10730241', N'61540970R2F', N'1', CAST(200 AS Decimal(18, 0)), CAST(200 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61540970R2F', N'', N'', CAST(0x0000A3A101030E14 AS DateTime), N'', CAST(0x0000A3A101169538 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 10, 29, N'E', N'Already Exist Data', N'J4', N'J4', N'100000000029', N'10730698', N'61527403R2F', N'1', CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61527403R2F', N'', N'', CAST(0x0000A3A101030E16 AS DateTime), N'', CAST(0x0000A3A101169540 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 11, 29, N'E', N'Already Exist Data', N'J4', N'J4', N'100000000029', N'10730240', N'61521729R4F', N'1', CAST(6 AS Decimal(18, 0)), CAST(6 AS Decimal(18, 0)), N'', N'20140909001', N'140909001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'CN', N'1431', N'GZSC00', N'61521729R4F', N'', N'', CAST(0x0000A3A101030E21 AS DateTime), N'', CAST(0x0000A3A101169548 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 1, N'E', N'PO QTY > OS PO Qty', N'C1', N'C1-10', N'100000000001', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D3 AS DateTime), N'', CAST(0x0000A3A1008CFFE6 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 2, N'E', N'PO QTY > OS PO Qty', N'C2', N'C1-10', N'100000000002', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D3 AS DateTime), N'', CAST(0x0000A3A1008D8C9D AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 3, N'E', N'PO QTY > OS PO Qty', N'C3', N'C1-10', N'100000000003', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D3 AS DateTime), N'', CAST(0x0000A3A1008D9341 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 4, N'E', N'PO QTY > OS PO Qty', N'C4', N'C1-10', N'100000000004', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D3 AS DateTime), N'', CAST(0x0000A3A1008D9839 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 5, N'E', N'PO QTY > OS PO Qty', N'C5', N'C1-10', N'100000000005', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D3 AS DateTime), N'', CAST(0x0000A3A100A7ED00 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 6, N'E', N'PO QTY > OS PO Qty', N'C6', N'C1-10', N'100000000006', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D3 AS DateTime), N'', CAST(0x0000A3A100A774D9 AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 7, N'E', N'PO QTY > OS PO Qty', N'C7', N'C1-10', N'100000000007', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D3 AS DateTime), N'', CAST(0x0000A3A100A7F4FD AS DateTime), N'', N'142.2.47.149', 0, N'S', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 8, N'E', N'PO QTY > OS PO Qty', N'C8', N'C1-10', N'100000000008', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D6 AS DateTime), N'', CAST(0x0000A3A1008CD1CF AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 9, N'E', N'PO QTY > OS PO Qty', N'C9', N'C1-10', N'100000000009', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D6 AS DateTime), N'', CAST(0x0000A3A1008CD1D7 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, 10, N'E', N'PO QTY > OS PO Qty', N'C10', N'C1-10', N'100000000010', N'10728415', N'10VR8-1610-181R1F6', N'10', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'1', CAST(0xFC380B00 AS Date), N'', N'PH', N'1412', N'WALS00', N'WR06X181JTL', N'', N'', CAST(0x0000A3A1008EC9D6 AS DateTime), N'', CAST(0x0000A3A1008CD1DF AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 2, 11, N'E', N'PO QTY > OS PO Qty', N'11', N'11', N'100000000011', N'10726588', N'10VR8-8520-152R1F1', N'1', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'2', CAST(0xFC380B00 AS Date), N'', N'PH', N'140325', N'WALS00', N'WR12X152JTL', N'', N'', CAST(0x0000A3A1008EC9E1 AS DateTime), N'', CAST(0x0000A3A1008CD1F0 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 3, 12, N'E', N'PO QTY > OS PO Qty', N'12', N'12', N'100000000012', N'10728424', N'10VR8-4080-272R1F1', N'1', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'2', CAST(0xFC380B00 AS Date), N'', N'PH', N'1402113', N'WALS00', N'WR06X272JTL', N'', N'', CAST(0x0000A3A1008EC9E3 AS DateTime), N'', CAST(0x0000A3A1008CD209 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 4, 12, N'E', N'PO QTY > OS PO Qty', N'12', N'12', N'100000000012', N'10728424', N'10VR8-4080-273R1F2', N'1', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'2', CAST(0xFC380B00 AS Date), N'', N'PH', N'140305', N'WALS00', N'WR06X273JTL', N'', N'', CAST(0x0000A3A1008EC9E6 AS DateTime), N'', CAST(0x0000A3A1008CD215 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 5, 13, N'E', N'PO QTY > OS PO Qty', N'13', N'13', N'100000000013', N'10728417', N'10VR8-1610-391R1F2', N'1', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'2', CAST(0xFC380B00 AS Date), N'', N'CN', N'140226', N'WALS00', N'WR06X391JTL', N'', N'', CAST(0x0000A3A1008EC9EB AS DateTime), N'', CAST(0x0000A3A1008CD227 AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 6, 13, N'E', N'PO QTY > OS PO Qty', N'13', N'13', N'100000000013', N'10728418', N'10VR8-1610-392R1F2', N'1', CAST(3500000 AS Decimal(18, 0)), CAST(3500000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'2', CAST(0xFC380B00 AS Date), N'', N'CN', N'140226', N'WALS00', N'WR06X392JTL', N'', N'', CAST(0x0000A3A1008EC9ED AS DateTime), N'', CAST(0x0000A3A1008CD237 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 7, 13, N'E', N'PO QTY > OS PO Qty', N'13', N'13', N'100000000013', N'10728417', N'10VR8-1610-362R1F2', N'1', CAST(1500000 AS Decimal(18, 0)), CAST(1500000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'2', CAST(0xFC380B00 AS Date), N'', N'CN', N'140226', N'WALS00', N'WR06X362JTL', N'', N'', CAST(0x0000A3A1008EC9EF AS DateTime), N'', CAST(0x0000A3A1008CD247 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 8, 13, N'E', N'PO QTY > OS PO Qty', N'13', N'13', N'100000000013', N'10728416', N'10VR8-1610-221R1F6', N'1', CAST(7000000 AS Decimal(18, 0)), CAST(7000000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'2', CAST(0xFC380B00 AS Date), N'', N'CN', N'140226', N'WALS00', N'WR06X221JTL', N'', N'', CAST(0x0000A3A1008EC9F1 AS DateTime), N'', CAST(0x0000A3A1008CD25B AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 9, 13, N'E', N'PO QTY > OS PO Qty', N'13', N'13', N'100000000013', N'10728414', N'10VR8-1610-100R1F6', N'1', CAST(110000 AS Decimal(18, 0)), CAST(110000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'2', CAST(0xFC380B00 AS Date), N'', N'CN', N'140226', N'WALS00', N'WR06X100JTL', N'', N'', CAST(0x0000A3A1008EC9F3 AS DateTime), N'', CAST(0x0000A3A1008CD272 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 10, 14, N'E', N'PO QTY > OS PO Qty', N'14', N'14', N'100000000014', N'10727515', N'11VR8-2756-343R1F3', N'1', CAST(4500000 AS Decimal(18, 0)), CAST(4500000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'140226', N'WALS00', N'WR08X6343FTL', N'', N'', CAST(0x0000A3A1008EC9F5 AS DateTime), N'', CAST(0x0000A3A1008CD28B AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 11, 14, N'E', N'PO QTY > OS PO Qty', N'14', N'14', N'100000000014', N'10728433', N'11VR8-2405-362R1F1', N'1', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X5362FL', N'', N'', CAST(0x0000A3A1008EC9F7 AS DateTime), N'', CAST(0x0000A3A1008CD29F AS DateTime), N'', N'142.2.47.149', 0, N'C', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 12, 14, N'E', N'PO QTY > OS PO Qty', N'14', N'14', N'100000000014', N'10728433', N'11VR8-2404-702R1F3', N'1', CAST(2000000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X4702FTL', N'', N'', CAST(0x0000A3A1008EC9F9 AS DateTime), N'', CAST(0x0000A3A1008CD2B4 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 13, 15, N'E', N'PO QTY > OS PO Qty', N'15', N'15', N'100000000015', N'10728418', N'10VR8-1610-472R1F6', N'1', CAST(415000 AS Decimal(18, 0)), CAST(415000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X472JTL', N'', N'', CAST(0x0000A3A1008EC9FB AS DateTime), N'', CAST(0x0000A3A1008CD2C5 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 14, 15, N'E', N'PO QTY > OS PO Qty', N'15', N'15', N'100000000015', N'10728414', N'10VR8-1610-114R1F2', N'1', CAST(2000000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X114JL', N'', N'', CAST(0x0000A3A1008EC9FD AS DateTime), N'', CAST(0x0000A3A1008CD2D5 AS DateTime), N'', N'142.2.47.149', 0, N' ', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 16, N'E', N'PO QTY > OS PO Qty', N'C16', N'C16-25', N'100000000016', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008EC9FF AS DateTime), N'', CAST(0x0000A3A1008CD2E3 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 17, N'E', N'PO QTY > OS PO Qty', N'C17', N'C16-25', N'100000000017', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008EC9FF AS DateTime), N'', CAST(0x0000A3A1008CD2ED AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 18, N'E', N'PO QTY > OS PO Qty', N'C18', N'C16-25', N'100000000018', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008EC9FF AS DateTime), N'', CAST(0x0000A3A1008CD2F5 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 19, N'E', N'PO QTY > OS PO Qty', N'C19', N'C16-25', N'100000000019', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008EC9FF AS DateTime), N'', CAST(0x0000A3A1008CD2FE AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 20, N'E', N'PO QTY > OS PO Qty', N'C20', N'C16-25', N'100000000020', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008EC9FF AS DateTime), N'', CAST(0x0000A3A1008CD306 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 21, N'E', N'PO QTY > OS PO Qty', N'C21', N'C16-25', N'100000000021', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008EC9FF AS DateTime), N'', CAST(0x0000A3A1008CD30E AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 22, N'E', N'PO QTY > OS PO Qty', N'C22', N'C16-25', N'100000000022', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008ECA00 AS DateTime), N'', CAST(0x0000A3A1008CD319 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 23, N'E', N'PO QTY > OS PO Qty', N'C23', N'C16-25', N'100000000023', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008ECA00 AS DateTime), N'', CAST(0x0000A3A1008CD322 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 24, N'E', N'PO QTY > OS PO Qty', N'C24', N'C16-25', N'100000000024', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008ECA00 AS DateTime), N'', CAST(0x0000A3A1008CD32A AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr_tran] ([Batch_ID], [LineID], [Wec_Ctn], [plr_status], [plr_status_msg], [CartonNo], [CartonID], [plr_wec_ctn], [plr_po], [plr_partno], [CartonType], [plr_carton_qty], [plr_qty], [plr_suppliers_id], [packingListID], [InvoiceID], [plr_rcp_date], [plr_pallet_no], [plr_deli_date], [plr_site], [plr_co], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [carton_id_prifix], [re_mark], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, 25, N'E', N'PO QTY > OS PO Qty', N'C25', N'C16-25', N'100000000025', N'10728418', N'10VR8-1610-471R1F4', N'10', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), N'', N'92997019', N'8234001', CAST(0xFC380B00 AS Date), N'3', CAST(0xFC380B00 AS Date), N'', N'CN', N'20140612', N'WALS00', N'WR06X471JTL', N'', N'', CAST(0x0000A3A1008ECA00 AS DateTime), N'', CAST(0x0000A3A1008CD332 AS DateTime), N'', N'142.2.47.149', 0, N'', N'', 0, CAST(0 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[plr_mstr_log]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[plr_mstr_err]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[plr_mstr]    Script Date: 09/09/2014 17:27:00 ******/
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
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 1, N'No', N'20140909010', N'140909010', N'1', N'1', N'330', N'10733503', N'CN', N'60153110R7GB', N'1431', N'CANI00', N'60153110R7GB', CAST(84 AS Decimal(18, 0)), CAST(84 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10108ED21 AS DateTime), NULL, CAST(0x0000A3A10108ED21 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 2, N'No', N'20140909010', N'140909010', N'1', N'1', N'331', N'10734787', N'CN', N'60247467R1F', N'1431', N'cani00', N'60247467R1F', CAST(8000 AS Decimal(18, 0)), CAST(8000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10108ED2E AS DateTime), NULL, CAST(0x0000A3A10108ED2E AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 3, N'No', N'20140909010', N'140909010', N'1', N'1', N'332', N'10730695', N'CN', N'60125090R1F', N'1431', N'CANI00', N'60125090R1F', CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10108ED30 AS DateTime), NULL, CAST(0x0000A3A10108ED30 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 4, N'No', N'20140909010', N'140909010', N'1', N'1', N'333', N'10734226', N'CN', N'60143310R3F', N'1431', N'cani00', N'M0007158-01(Rev E)', CAST(1000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10108ED31 AS DateTime), NULL, CAST(0x0000A3A10108ED31 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090004', 5, N'No', N'20140909010', N'140909010', N'1', N'1', N'334', N'10733267', N'CN', N'60115001R3F', N'1431', N'CANI00', N'60115001R3F', CAST(2000 AS Decimal(18, 0)), CAST(2000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10108ED33 AS DateTime), NULL, CAST(0x0000A3A10108ED33 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 1, N'No', N'20140909005', N'140909005', N'1', N'1', N'222', N'10729558', N'CN', N'57RM1-2321-00AR4F1', N'1431', N'TAKN00', N'RM1-2321 HIS:004', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A101047F58 AS DateTime), NULL, CAST(0x0000A3A101047F58 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 2, N'No', N'20140909005', N'140909005', N'1', N'1', N'222', N'10729558', N'CN', N'57RM1-2321-00AR4F1', N'1431', N'TAKN00', N'RM1-2321 HIS:004', CAST(663 AS Decimal(18, 0)), CAST(663 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A101047F5E AS DateTime), NULL, CAST(0x0000A3A101047F5E AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 3, N'No', N'20140909005', N'140909005', N'1', N'1', N'222', N'10731057', N'CN', N'57RM1-2321-000R1F1', N'1431', N'TAKN00', N'RM1-2321 HIS:004', CAST(1337 AS Decimal(18, 0)), CAST(1337 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A101047F60 AS DateTime), NULL, CAST(0x0000A3A101047F60 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 4, N'No', N'20140909005', N'140909005', N'1', N'1', N'222', N'10731057', N'CN', N'57RM1-2390-00AR5F1', N'1431', N'TAKN00', N'RM1-2390 HIS:005', CAST(742 AS Decimal(18, 0)), CAST(742 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A101047F62 AS DateTime), NULL, CAST(0x0000A3A101047F62 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 5, N'No', N'20140909005', N'140909005', N'1', N'1', N'222', N'10731057', N'CN', N'57RM1-2390-00AR5F1', N'1431', N'TAKN00', N'RM1-2390 HIS:005', CAST(18000 AS Decimal(18, 0)), CAST(18000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A101047F63 AS DateTime), NULL, CAST(0x0000A3A101047F63 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090003', 6, N'No', N'20140909005', N'140909005', N'1', N'1', N'222', N'10731057', N'CN', N'57RM1-2390-00AR5F1', N'1431', N'TAKN00', N'RM1-2390 HIS:005', CAST(258 AS Decimal(18, 0)), CAST(258 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A101047F65 AS DateTime), NULL, CAST(0x0000A3A101047F65 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 1, N'No', N'20140909001', N'140909001', N'1', N'1', N'J1', N'10732382', N'CN', N'61467633R1F', N'1431', N'gzsc00', N'61467633R1F', CAST(90 AS Decimal(18, 0)), CAST(90 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA48 AS DateTime), NULL, CAST(0x0000A3A10100DA48 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 2, N'No', N'20140909001', N'140909001', N'1', N'1', N'J1', N'10732531', N'CN', N'61538370R3F', N'1431', N'GZSC00', N'61538370R3F', CAST(300 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA8E AS DateTime), NULL, CAST(0x0000A3A10100DA8E AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 3, N'No', N'20140909001', N'140909001', N'1', N'1', N'J1', N'10735022', N'CN', N'61552451R1F', N'1431', N'GZSC00', N'61552451R1F', CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA91 AS DateTime), NULL, CAST(0x0000A3A10100DA91 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 4, N'No', N'20140909001', N'140909001', N'1', N'1', N'J2', N'10730699', N'CN', N'61552453R1F', N'1431', N'GZSC00', N'61552453R1F', CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA92 AS DateTime), NULL, CAST(0x0000A3A10100DA92 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 5, N'No', N'20140909001', N'140909001', N'1', N'1', N'J3', N'10730699', N'CN', N'61566461R1F', N'1431', N'GZSC00', N'61566461R1F', CAST(300 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA94 AS DateTime), NULL, CAST(0x0000A3A10100DA94 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 6, N'No', N'20140909001', N'140909001', N'1', N'1', N'J3', N'10730699', N'CN', N'61566461R1F', N'1431', N'GZSC00', N'61566461R1F', CAST(300 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA98 AS DateTime), NULL, CAST(0x0000A3A10100DA98 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 7, N'No', N'20140909001', N'140909001', N'1', N'1', N'J4', N'10730698', N'CN', N'61427403R1F', N'1431', N'GZSC00', N'61427403R1F', CAST(400 AS Decimal(18, 0)), CAST(400 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA9B AS DateTime), NULL, CAST(0x0000A3A10100DA9B AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 8, N'No', N'20140909001', N'140909001', N'1', N'1', N'J4', N'10730241', N'CN', N'61538372R3F', N'1431', N'GZSC00', N'61538372R3F', CAST(1500 AS Decimal(18, 0)), CAST(1500 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA9C AS DateTime), NULL, CAST(0x0000A3A10100DA9C AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 9, N'No', N'20140909001', N'140909001', N'1', N'1', N'J4', N'10730241', N'CN', N'61540970R2F', N'1431', N'GZSC00', N'61540970R2F', CAST(200 AS Decimal(18, 0)), CAST(200 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DA9F AS DateTime), NULL, CAST(0x0000A3A10100DA9F AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 10, N'No', N'20140909001', N'140909001', N'1', N'1', N'J4', N'10730698', N'CN', N'61527403R2F', N'1431', N'GZSC00', N'61527403R2F', CAST(500 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DAA1 AS DateTime), NULL, CAST(0x0000A3A10100DAA1 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090002', 11, N'No', N'20140909001', N'140909001', N'1', N'1', N'J4', N'10730240', N'CN', N'61521729R4F', N'1431', N'GZSC00', N'61521729R4F', CAST(6 AS Decimal(18, 0)), CAST(6 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A10100DAA2 AS DateTime), NULL, CAST(0x0000A3A10100DAA2 AS DateTime), NULL, N'142.2.48.7', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 1, N'No', N'92997019', N'8234001', N'1', N'10', N'C1-10', N'10728415', N'PH', N'10VR8-1610-181R1F6', N'1412', N'WALS00', N'WR06X181JTL', CAST(26000 AS Decimal(18, 0)), CAST(260000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C975A AS DateTime), NULL, CAST(0x0000A3A1008C975A AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 2, N'No', N'92997019', N'8234001', N'2', N'1', N'11', N'10726588', N'PH', N'10VR8-8520-152R1F1', N'140325', N'WALS00', N'WR12X152JTL', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C978A AS DateTime), NULL, CAST(0x0000A3A1008C978A AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 3, N'No', N'92997019', N'8234001', N'2', N'1', N'12', N'10728424', N'PH', N'10VR8-4080-272R1F1', N'1402113', N'WALS00', N'WR06X272JTL', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C9794 AS DateTime), NULL, CAST(0x0000A3A1008C9794 AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 4, N'No', N'92997019', N'8234001', N'2', N'1', N'12', N'10728424', N'PH', N'10VR8-4080-273R1F2', N'140305', N'WALS00', N'WR06X273JTL', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C9797 AS DateTime), NULL, CAST(0x0000A3A1008C9797 AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 5, N'No', N'92997019', N'8234001', N'2', N'1', N'13', N'10728417', N'CN', N'10VR8-1610-391R1F2', N'140226', N'WALS00', N'WR06X391JTL', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C979A AS DateTime), NULL, CAST(0x0000A3A1008C979A AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 6, N'No', N'92997019', N'8234001', N'2', N'1', N'13', N'10728418', N'CN', N'10VR8-1610-392R1F2', N'140226', N'WALS00', N'WR06X392JTL', CAST(3500000 AS Decimal(18, 0)), CAST(3500000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C979E AS DateTime), NULL, CAST(0x0000A3A1008C979E AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 7, N'No', N'92997019', N'8234001', N'2', N'1', N'13', N'10728417', N'CN', N'10VR8-1610-362R1F2', N'140226', N'WALS00', N'WR06X362JTL', CAST(1500000 AS Decimal(18, 0)), CAST(1500000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97A1 AS DateTime), NULL, CAST(0x0000A3A1008C97A1 AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 8, N'No', N'92997019', N'8234001', N'2', N'1', N'13', N'10728416', N'CN', N'10VR8-1610-221R1F6', N'140226', N'WALS00', N'WR06X221JTL', CAST(7000000 AS Decimal(18, 0)), CAST(7000000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97A3 AS DateTime), NULL, CAST(0x0000A3A1008C97A3 AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 9, N'No', N'92997019', N'8234001', N'2', N'1', N'13', N'10728414', N'CN', N'10VR8-1610-100R1F6', N'140226', N'WALS00', N'WR06X100JTL', CAST(110000 AS Decimal(18, 0)), CAST(110000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97A5 AS DateTime), NULL, CAST(0x0000A3A1008C97A5 AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 10, N'No', N'92997019', N'8234001', N'3', N'1', N'14', N'10727515', N'CN', N'11VR8-2756-343R1F3', N'140226', N'WALS00', N'WR08X6343FTL', CAST(4500000 AS Decimal(18, 0)), CAST(4500000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97A7 AS DateTime), NULL, CAST(0x0000A3A1008C97A7 AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 11, N'No', N'92997019', N'8234001', N'3', N'1', N'14', N'10728433', N'CN', N'11VR8-2405-362R1F1', N'20140612', N'WALS00', N'WR06X5362FL', CAST(5000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97A9 AS DateTime), NULL, CAST(0x0000A3A1008C97A9 AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 12, N'No', N'92997019', N'8234001', N'3', N'1', N'14', N'10728433', N'CN', N'11VR8-2404-702R1F3', N'20140612', N'WALS00', N'WR06X4702FTL', CAST(2000000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97AB AS DateTime), NULL, CAST(0x0000A3A1008C97AB AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 13, N'No', N'92997019', N'8234001', N'3', N'1', N'15', N'10728418', N'CN', N'10VR8-1610-472R1F6', N'20140612', N'WALS00', N'WR06X472JTL', CAST(415000 AS Decimal(18, 0)), CAST(415000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97AD AS DateTime), NULL, CAST(0x0000A3A1008C97AD AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 14, N'No', N'92997019', N'8234001', N'3', N'1', N'15', N'10728414', N'CN', N'10VR8-1610-114R1F2', N'20140612', N'WALS00', N'WR06X114JL', CAST(2000000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97AF AS DateTime), NULL, CAST(0x0000A3A1008C97AF AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[plr_mstr] ([Batch_ID], [LineID], [plr_status], [packingListID], [InvoiceID], [plr_pallet_no], [CartonType], [CartonID], [plr_po], [plr_co], [plr_partno], [plr_date_code], [plr_vend_mfgr], [Plr_vm_partno], [plr_carton_qty], [plr_qty], [plr_rcp_date], [plr_deli_date], [carton_id_prifix], [carton_id_from], [carton_id_to], [plr_doc_type], [re_mark], [plr_suppliers_id], [plr_site], [plr_ttl], [plr_um], [plr_nw], [plr_gw], [plr_um_w], [Plr_unitprice], [plr_msm], [plr_doc_no1], [plr_cre_date], [plr_cre_userid], [plr_update_date], [plr_edituser_id], [plr_user_ip], [plr_void_status], [plr_chr01], [plr_chr02], [plr_deci1], [plr_deci2]) VALUES (N'R1409090001', 15, N'No', N'92997019', N'8234001', N'3', N'10', N'C16-25', N'10728418', N'CN', N'10VR8-1610-471R1F4', N'20140612', N'WALS00', N'WR06X471JTL', CAST(185000 AS Decimal(18, 0)), CAST(1850000 AS Decimal(18, 0)), CAST(0xFC380B00 AS Date), CAST(0xFC380B00 AS Date), NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'e-Packing', NULL, N'', NULL, 0, NULL, NULL, NULL, NULL, CAST(0.0000 AS Decimal(10, 4)), NULL, NULL, CAST(0x0000A3A1008C97B1 AS DateTime), NULL, CAST(0x0000A3A1008C97B1 AS DateTime), NULL, N'142.2.47.149', 0, NULL, NULL, 0, CAST(0 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[plr_batch_mstr]    Script Date: 09/09/2014 17:27:00 ******/
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
INSERT [dbo].[plr_batch_mstr] ([batch_id], [plr_suppliers_id], [batch_doc], [batch_status], [batch_void], [batch_cre_date], [batch_update_date], [batch_cre_user], [batch_user_ip], [batch_chr01], [batch_dec01]) VALUES (N'R1409090004', N'', N'e-Packing', N'No', 0, CAST(0x0000A3A1010B20AC AS DateTime), CAST(0x0000A3A1010B20AC AS DateTime), NULL, N'142.2.48.7', NULL, CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[plr_batch_mstr] ([batch_id], [plr_suppliers_id], [batch_doc], [batch_status], [batch_void], [batch_cre_date], [batch_update_date], [batch_cre_user], [batch_user_ip], [batch_chr01], [batch_dec01]) VALUES (N'R1409090003', N'', N'e-Packing', N'No', 0, CAST(0x0000A3A10106B2CF AS DateTime), CAST(0x0000A3A10106B2CF AS DateTime), NULL, N'142.2.48.7', NULL, CAST(6 AS Decimal(18, 0)))
INSERT [dbo].[plr_batch_mstr] ([batch_id], [plr_suppliers_id], [batch_doc], [batch_status], [batch_void], [batch_cre_date], [batch_update_date], [batch_cre_user], [batch_user_ip], [batch_chr01], [batch_dec01]) VALUES (N'R1409090002', N'', N'e-Packing', N'No', 0, CAST(0x0000A3A101030DBA AS DateTime), CAST(0x0000A3A101030DBA AS DateTime), NULL, N'142.2.48.7', NULL, CAST(11 AS Decimal(18, 0)))
INSERT [dbo].[plr_batch_mstr] ([batch_id], [plr_suppliers_id], [batch_doc], [batch_status], [batch_void], [batch_cre_date], [batch_update_date], [batch_cre_user], [batch_user_ip], [batch_chr01], [batch_dec01]) VALUES (N'R1409090001', NULL, N'e-Packing', N'No', 1, CAST(0x0000A3A1008EC7E5 AS DateTime), CAST(0x0000A3A1008EC7E5 AS DateTime), NULL, N'142.2.47.149', NULL, CAST(15 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[pkey_ctl]    Script Date: 09/09/2014 17:27:00 ******/
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
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'pi_mstr', N'pi_id', NULL, NULL, NULL, NULL, NULL, CAST(4 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'plr_batch_mstr', N'batch_id', NULL, NULL, NULL, NULL, NULL, CAST(4 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[pkey_ctl] ([t_name], [t_value], [t_desc], [t_yyww], [prefix], [ctl_fro], [ctl_to], [ctl_curr], [ctl_curr_len], [ctl_len]) VALUES (N'Plr_mstr_tran', N'Wec_Ctn', NULL, NULL, NULL, NULL, NULL, CAST(75 AS Decimal(18, 0)), NULL, NULL)
/****** Object:  Table [dbo].[pisr_grr]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[pi_sq]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[PI_MSTR_Remote]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[pi_mstr]    Script Date: 09/09/2014 17:27:00 ******/
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
INSERT [dbo].[pi_mstr] ([PI_ID], [LineID], [Plant], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090004', 1, N'NW', N'Normal', N'No', NULL, NULL, CAST(0x0000A3A1010B7A38 AS DateTime), NULL, CAST(0x0000A3A1010B7A38 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pi_mstr] ([PI_ID], [LineID], [Plant], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090003', 1, N'NW', N'Normal', N'No', NULL, NULL, CAST(0x0000A3A1010726B2 AS DateTime), NULL, CAST(0x0000A3A1010726B2 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pi_mstr] ([PI_ID], [LineID], [Plant], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 1, N'NW', N'Normal', N'No', NULL, NULL, CAST(0x0000A3A101037571 AS DateTime), NULL, CAST(0x0000A3A101037571 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[pi_mstr] ([PI_ID], [LineID], [Plant], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090001', 1, N'NW', N'Normal', N'No', NULL, NULL, CAST(0x0000A3A1008F3225 AS DateTime), NULL, CAST(0x0000A3A1008F3225 AS DateTime), NULL, N'142.2.47.149', NULL, NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[PI_DET_Remote]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[pi_det]    Script Date: 09/09/2014 17:27:00 ******/
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
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090004', 1, N'100000000071', 1, N'1', N'330', N'330', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010B7A3A AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10733503', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090004', 2, N'100000000072', 2, N'1', N'331', N'331', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010B7ED5 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10734787', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090004', 3, N'100000000073', 3, N'1', N'332', N'332', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010B8273 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730695', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090004', 4, N'100000000074', 4, N'1', N'333', N'333', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010B85F0 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10734226', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090004', 5, N'100000000075', 5, N'1', N'334', N'334', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010B89F7 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10733267', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090003', 1, N'100000000030', 1, N'1', N'222', N'222', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010726B5 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10729558', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090003', 2, N'100000000030', 2, N'1', N'222', N'222', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010726B8 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10729558', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090003', 3, N'100000000030', 3, N'1', N'222', N'222', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010726B9 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10731057', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090003', 4, N'100000000030', 4, N'1', N'222', N'222', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010726BB AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10731057', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090003', 5, N'100000000030', 5, N'1', N'222', N'222', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010726BD AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10731057', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090003', 6, N'100000000030', 6, N'1', N'222', N'222', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010726BF AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10731057', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 1, N'100000000026', 1, N'1', N'J1', N'J1', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A101037576 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10732382', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 2, N'100000000026', 2, N'1', N'J1', N'J1', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A101037579 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10732531', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 3, N'100000000026', 3, N'1', N'J1', N'J1', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A10103757B AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10735022', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 4, N'100000000027', 4, N'1', N'J2', N'J2', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A101038084 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730699', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 5, N'100000000028', 5, N'1', N'J3', N'J3', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010384AC AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730699', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 6, N'100000000028', 6, N'1', N'J3', N'J3', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1010384AE AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730699', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 7, N'100000000029', 7, N'1', N'J4', N'J4', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A101038993 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730698', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 8, N'100000000029', 8, N'1', N'J4', N'J4', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A101038995 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730241', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 9, N'100000000029', 9, N'1', N'J4', N'J4', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A101038997 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730241', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 10, N'100000000029', 10, N'1', N'J4', N'J4', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A101038999 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730698', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090002', 11, N'100000000029', 11, N'1', N'J4', N'J4', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A10103899B AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'CN:中國', N'10730240', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090001', 1, N'100000000001', 1, N'1', N'C1', N'C1-10', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1008F3227 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'PH:菲律賓', N'10728415', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090001', 2, N'100000000002', 1, N'1', N'C2', N'C1-10', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1008FBED6 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'PH:菲律賓', N'10728415', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090001', 3, N'100000000003', 1, N'1', N'C3', N'C1-10', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1008FC57A AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'PH:菲律賓', N'10728415', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090001', 4, N'100000000004', 1, N'1', N'C4', N'C1-10', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A1008FCA72 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'PH:菲律賓', N'10728415', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090001', 5, N'100000000006', 1, N'1', N'C6', N'C1-10', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A100A9A6F2 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'PH:菲律賓', N'10728415', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090001', 6, N'100000000005', 1, N'1', N'C5', N'C1-10', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A100AA1F1E AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'PH:菲律賓', N'10728415', NULL, NULL)
INSERT [dbo].[pi_det] ([PI_ID], [pi_LineID], [pi_wec_ctn], [plr_LineID_tran], [pi_pallet_no], [CartonNo], [CartonID], [pi_type], [pi_status], [pi_status_msg], [pi_remark], [pi_cre_date], [pi_cre_userid], [pi_update_date], [pi_edituser_id], [pi_user_ip], [pi_void_status], [pi_chr01], [pi_chr02], [pi_deci1], [pi_deci2]) VALUES (N'P1409090001', 7, N'100000000007', 1, N'1', N'C7', N'C1-10', N'Normal', N'No', NULL, N'New', CAST(0x0000A3A100AA2719 AS DateTime), NULL, NULL, NULL, N'142.2.47.149', NULL, N'PH:菲律賓', N'10728415', NULL, NULL)
/****** Object:  Table [dbo].[OCR_mstr]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[Irh_comp]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[sys_userInrole]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  Table [dbo].[sys_user]    Script Date: 09/09/2014 17:27:00 ******/
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
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'demo', N'WWTS', N'87EC83741750EE520A044896A28B4DB5', N'', N'', CAST(0x0000A3A1011EFA5F AS DateTime), CAST(0x0000A38E00A2123C AS DateTime), N'', N'', N'142.2.47.149', N'142.2.47.149', N'T')
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'gx.li', N'WWTS', N'6F27AFF1C4FEDAD2CB6B439DA4DE9A56', N'', N'', CAST(0x0000A38D01044160 AS DateTime), CAST(0x0000A38D0103A844 AS DateTime), N'', N'', N'142.2.64.22', N'', N'T')
INSERT [dbo].[sys_user] ([user_name], [user_comp], [user_password], [user_email], [user_desc], [update_time], [create_time], [create_user_id], [update_user_id], [client_ip], [re_mark], [flag_status]) VALUES (N'ling.xie', N'WWTS', N'681B03E018CB2B9CFEA8F119BA936A7C36D150E54B782C76', N'', N'', CAST(0x0000A38E00A5FBCA AS DateTime), CAST(0x0000A38C01295BD4 AS DateTime), N'', N'', N'142.2.47.149', N'142.2.47.149', N'T')
/****** Object:  Table [dbo].[sys_role]    Script Date: 09/09/2014 17:27:00 ******/
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
/****** Object:  View [dbo].[vpi_report]    Script Date: 09/09/2014 17:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vpi_report]
AS
SELECT     a.PI_ID, a.pi_LineID, a.pi_wec_ctn, a.plr_LineID_tran, a.pi_pallet_no, a.CartonNo, a.CartonID, a.pi_chr01, b.pisr_rir, b.pisr_invoice, b.pisr_part, b.Pisr_receiver, 
                      b.pisr_site, b.pisr_po_nbr, b.pisr_qty, b.pisr_curr, b.pisr_cost, b.pisr_base_cost, b.pisr_us_cost, b.pisr_seq, b.pisr_con_code, c.sq_name, b.pisr_net_wt, 
                      b.pisr_rec_type, b.pisr_abc, b.pisr_code
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
            TopColumn = 0
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
/****** Object:  View [dbo].[vpi_detApisr_grr]    Script Date: 09/09/2014 17:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vpi_detApisr_grr]
AS
SELECT     a.PI_ID, a.pi_LineID, a.pi_wec_ctn, a.plr_LineID_tran, a.pi_pallet_no, a.CartonNo, a.CartonID, a.pi_chr01, b.pisr_rir, b.pisr_invoice, b.pisr_part, b.Pisr_receiver, 
                      b.pisr_site, b.pisr_po_nbr, b.pisr_qty, b.pisr_curr, b.pisr_cost, b.pisr_base_cost, b.pisr_us_cost, b.pisr_seq, b.pisr_con_code, c.sq_name, b.pisr_net_wt, 
                      b.pisr_rec_type, b.pisr_abc, b.pisr_code, b.pisr_lic_req, b.pisr_sbu, b.pisr_vend, b.pisr_mfgr_name, b.pisr_dec01, b.pisr_dec02, a.pi_status
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
            TopColumn = 6
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
/****** Object:  StoredProcedure [dbo].[sp_GetPIID]    Script Date: 09/09/2014 17:27:01 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetBatchID]    Script Date: 09/09/2014 17:27:01 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Get_WecCtnPre]    Script Date: 09/09/2014 17:27:01 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GenCtn_Tran]    Script Date: 09/09/2014 17:27:01 ******/
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
/****** Object:  Default [DF_plr_batch_mstr_Batch_void]    Script Date: 09/09/2014 17:27:00 ******/
ALTER TABLE [dbo].[plr_batch_mstr] ADD  CONSTRAINT [DF_plr_batch_mstr_Batch_void]  DEFAULT ((1)) FOR [batch_void]
GO
/****** Object:  Default [DF_Plr_mstr_plr_void_status]    Script Date: 09/09/2014 17:27:00 ******/
ALTER TABLE [dbo].[plr_mstr] ADD  CONSTRAINT [DF_Plr_mstr_plr_void_status]  DEFAULT ((0)) FOR [plr_void_status]
GO
/****** Object:  Default [DF_Plr_mstr_err_plr_void_status]    Script Date: 09/09/2014 17:27:00 ******/
ALTER TABLE [dbo].[plr_mstr_err] ADD  CONSTRAINT [DF_Plr_mstr_err_plr_void_status]  DEFAULT ((1)) FOR [plr_void_status]
GO
