USE [QLBN]
GO
/****** Object:  Table [dbo].[CT_KQXN]    Script Date: 7/3/2020 10:30:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_KQXN](
	[Ma_CT_KQXN] [char](10) NOT NULL,
	[MaKQ] [char](10) NULL,
	[Loai_XN] [char](10) NULL,
	[Glucose] [float] NULL,
	[Urê] [float] NULL,
	[Creatinin] [float] NULL,
	[Cholesterol] [float] NULL,
	[Triglycerid] [float] NULL,
	[HDL_Cholesterol] [float] NULL,
	[AST_GOT] [float] NULL,
	[ALT_GPT] [float] NULL,
	[GGT] [float] NULL,
	[Acid_Uric] [float] NULL,
 CONSTRAINT [PK_CT_KQXN] PRIMARY KEY CLUSTERED 
(
	[Ma_CT_KQXN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KQXN]    Script Date: 7/3/2020 10:30:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KQXN](
	[MaKQ] [char](10) NOT NULL,
	[MaBN] [char](10) NULL,
	[Khoa] [nvarchar](50) NULL,
	[Chuan_Doan] [nvarchar](255) NULL,
	[TG_NM] [datetime] NULL,
	[BS_ChiDinh] [nvarchar](50) NULL,
	[Loai_XN] [char](10) NULL,
 CONSTRAINT [PK_KQXN] PRIMARY KEY CLUSTERED 
(
	[MaKQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TT_BenhNhan]    Script Date: 7/3/2020 10:30:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TT_BenhNhan](
	[MaBN] [char](10) NOT NULL,
	[Ten_BN] [nvarchar](50) NULL,
	[Gioi_Tinh] [nvarchar](10) NULL,
	[Dia_Chi] [nvarchar](255) NULL,
	[Ngay_Sinh] [datetime] NULL,
	[So_BHYT] [nvarchar](20) NULL,
	[Loai_DV_Kham] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TT_BenhNhan] ([MaBN], [Ten_BN], [Gioi_Tinh], [Dia_Chi], [Ngay_Sinh], [So_BHYT], [Loai_DV_Kham]) VALUES (N'0001      ', N'Nguyễn Văn A', N'Nam', N'Tôn Đức Thắng, Q1', CAST(N'2020-11-11T00:00:00.000' AS DateTime), N'ABC123', N'Huyết Học')
INSERT [dbo].[TT_BenhNhan] ([MaBN], [Ten_BN], [Gioi_Tinh], [Dia_Chi], [Ngay_Sinh], [So_BHYT], [Loai_DV_Kham]) VALUES (N'0002      ', N'Trần Thị C', N'Nữ', N'Trường Trinh, Q Tân Bình', NULL, N'ABC124', N'Sinh Hóa')
INSERT [dbo].[TT_BenhNhan] ([MaBN], [Ten_BN], [Gioi_Tinh], [Dia_Chi], [Ngay_Sinh], [So_BHYT], [Loai_DV_Kham]) VALUES (N'0004      ', N'Nguyễn Văn A', N'Nam', N'Tôn Đức Thắng, Q1', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'ABC123', N'Huyết Học')
INSERT [dbo].[TT_BenhNhan] ([MaBN], [Ten_BN], [Gioi_Tinh], [Dia_Chi], [Ngay_Sinh], [So_BHYT], [Loai_DV_Kham]) VALUES (N'003       ', N'Nguyễn Văn A', N'Nam', N'Tôn Đức Thắng, Q1', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'ABC123', N'Huyết Học')
INSERT [dbo].[TT_BenhNhan] ([MaBN], [Ten_BN], [Gioi_Tinh], [Dia_Chi], [Ngay_Sinh], [So_BHYT], [Loai_DV_Kham]) VALUES (N'BN-070339 ', N'Nguyễn Văn A', N'Nam', N'Tôn Đức Thắng, Q1', CAST(N'2020-07-03T01:42:26.913' AS DateTime), N'ABC123', N'Huyết Học')
INSERT [dbo].[TT_BenhNhan] ([MaBN], [Ten_BN], [Gioi_Tinh], [Dia_Chi], [Ngay_Sinh], [So_BHYT], [Loai_DV_Kham]) VALUES (N'BN-070354 ', N'Nguyễn Văn A', N'Nam', N'Tôn Đức Thắng, Q1', CAST(N'2009-07-03T01:44:27.000' AS DateTime), N'ABC123', N'Huyết Học')
GO
