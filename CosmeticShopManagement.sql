USE [CosmeticsShopManagement]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 23/02/2024 5:03:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Email] [varchar](100) NOT NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [varchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CosmeticCategory]    Script Date: 23/02/2024 5:03:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CosmeticCategory](
	[CategoryID] [varchar](10) NOT NULL,
	[CategoryName] [nvarchar](100) NULL,
	[Description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_CosmeticCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cosmetics]    Script Date: 23/02/2024 5:03:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cosmetics](
	[CosmeticID] [varchar](10) NOT NULL,
	[CosmeticName] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Price] [int] NOT NULL,
	[Quality] [int] NOT NULL,
	[CategoryID] [varchar](10) NULL,
 CONSTRAINT [PK_Cosmetics] PRIMARY KEY CLUSTERED 
(
	[CosmeticID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Accounts] ([Email], [Username], [Password], [RoleID]) VALUES (N'staff@gmail.com', N'Staff', N'88888', 2)
INSERT [dbo].[Accounts] ([Email], [Username], [Password], [RoleID]) VALUES (N'vantcii@gmail.com', N'vantcii', N'666666', 3)
INSERT [dbo].[Accounts] ([Email], [Username], [Password], [RoleID]) VALUES (N'viet@gmail.co', N'viet', N'686868', 1)
GO
INSERT [dbo].[CosmeticCategory] ([CategoryID], [CategoryName], [Description]) VALUES (N'EL', N'Eye liner', N'Các loại kẻ mắt của các hãng ')
INSERT [dbo].[CosmeticCategory] ([CategoryID], [CategoryName], [Description]) VALUES (N'KCN', N'Kem chống nắng', N'Các lại kem chống nắng, bao gồm cả chống nắng da mặt, body, toàn thân, v.v')
INSERT [dbo].[CosmeticCategory] ([CategoryID], [CategoryName], [Description]) VALUES (N'SM', N'Son môi', N'Các loại son của các hãng trong toàn nước')
INSERT [dbo].[CosmeticCategory] ([CategoryID], [CategoryName], [Description]) VALUES (N'SRM', N'Sửa rửa mặt', N'Các sản phẩm sửa rửa mặt cho các loại da')
INSERT [dbo].[CosmeticCategory] ([CategoryID], [CategoryName], [Description]) VALUES (N'TT', N'Nước tẩy trang', N'Các sản phẩm nước tẩy trang của các nhãn hàng ')
GO
INSERT [dbo].[Cosmetics] ([CosmeticID], [CosmeticName], [Description], [Price], [Quality], [CategoryID]) VALUES (N'C001', N'Cetaphil Dịu Lành Cho Da', N'Sửa rửa mặt dịu nhẹ dành cho da nhạy cảm và tất cả loại da', 329000, 1, N'SRM')
INSERT [dbo].[Cosmetics] ([CosmeticID], [CosmeticName], [Description], [Price], [Quality], [CategoryID]) VALUES (N'C002', N'La Roche Porsay Kiềm Dầu', N'Kem chống nắng kiểm soát dầu', 395000, 2, N'KCN')
GO
