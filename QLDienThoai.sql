USE [QLDienThoai]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 1/1/2022 4:57:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[Masp] [nvarchar](50) NULL,
	[sl] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/1/2022 4:57:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[Masp] [nvarchar](50) NOT NULL,
	[Tensp] [nvarchar](50) NULL,
	[Soluong] [int] NULL,
	[Gia] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[Masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TK]    Script Date: 1/1/2022 4:57:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TK](
	[id] [nchar](10) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_TK] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [SDT], [Masp], [sl]) VALUES (N'hd1', N'kh1', N'user1', 1234, N'sp1', 12)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [SDT], [Masp], [sl]) VALUES (N'hd2', N'kh2', N'user2', 23456, N'sp2', 45)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [SDT], [Masp], [sl]) VALUES (N'hd1', N'kh1', N'user1', 1234, N'sp9', 30)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [SDT], [Masp], [sl]) VALUES (N'hd3', N'kh3', N'user3', 34567, N'sp10', 60)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [SDT], [Masp], [sl]) VALUES (N'hd4', N'kh4', N'user4', 1234, N'sp5', 12)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [SDT], [Masp], [sl]) VALUES (N'hd6', N'kh6', N'user6', 1234, N'sp4', 30)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [SDT], [Masp], [sl]) VALUES (N'hd8', N'kh8', N'user8', 3456, N'sp8', 20)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [TenKH], [SDT], [Masp], [sl]) VALUES (N'hd7', N'kh7', N'user7', 1234, N'sp7', 15)
GO
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Gia]) VALUES (N'sp1', N'ÐT Samsung', 239, 4500000)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Gia]) VALUES (N'sp2', N'ÐT Iphone', 800, 10000000)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Gia]) VALUES (N'sp3', N'ÐT Realme', 800, 7500000)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Gia]) VALUES (N'sp4', N'ĐT Oppo', 670, 4000000)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Gia]) VALUES (N'sp5', N'ÐT Nokia', 500, 2000000)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Gia]) VALUES (N'sp6', N'ÐT Lenovo', 100, 3500000)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Gia]) VALUES (N'sp7', N'ÐT Vsmart', 275, 3000000)
INSERT [dbo].[SanPham] ([Masp], [Tensp], [Soluong], [Gia]) VALUES (N'sp8', N'ÐT Vivo', 130, 3400000)
GO
INSERT [dbo].[TK] ([id], [username], [password]) VALUES (N'1         ', N'admin1', N'1')
INSERT [dbo].[TK] ([id], [username], [password]) VALUES (N'2         ', N'admin2', N'2')
INSERT [dbo].[TK] ([id], [username], [password]) VALUES (N'3         ', N'admin3', N'3')
GO
