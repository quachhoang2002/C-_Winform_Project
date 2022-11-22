USE [ok]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccID] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[EmpID] [nvarchar](50) NOT NULL,
	[Permission] [int] NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cake]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cake](
	[CakeID] [nvarchar](50) NOT NULL,
	[CakeName] [nvarchar](50) NOT NULL,
	[CategoryID] [nvarchar](50) NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Img] [nvarchar](50) NULL,
	[isDeleted] [int] NOT NULL,
 CONSTRAINT [PK_Cake] PRIMARY KEY CLUSTERED 
(
	[CakeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [nvarchar](50) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CusID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DoB] [date] NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpID] [nvarchar](50) NOT NULL,
	[EmpName] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Import]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import](
	[ImportID] [nvarchar](50) NOT NULL,
	[SuppID] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[EmployeeID] [nvarchar](50) NOT NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_Import] PRIMARY KEY CLUSTERED 
(
	[ImportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportDetail]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetail](
	[ImportDetailID] [nvarchar](50) NOT NULL,
	[ImportID] [nvarchar](50) NOT NULL,
	[CakeID] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_ImportDetail] PRIMARY KEY CLUSTERED 
(
	[ImportDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [nvarchar](50) NOT NULL,
	[CusID] [nvarchar](50) NOT NULL,
	[EmpID] [nvarchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailID] [nvarchar](50) NOT NULL,
	[OrderID] [nvarchar](50) NOT NULL,
	[CakeID] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/21/2022 9:56:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SuppID] [nvarchar](50) NOT NULL,
	[SuppName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[isDeleted] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[ContactPerson] [nvarchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SuppID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([AccID], [UserName], [Password], [EmpID], [Permission], [isDeleted]) VALUES (N'acc1', N'admin', N'admin', N'nv1', 0, 1)
INSERT [dbo].[Account] ([AccID], [UserName], [Password], [EmpID], [Permission], [isDeleted]) VALUES (N'acc2', N'dongocluongtuan', N'12345', N'nv2', 1, 1)
INSERT [dbo].[Account] ([AccID], [UserName], [Password], [EmpID], [Permission], [isDeleted]) VALUES (N'acc3', N'onhauyennhi', N'12345', N'nv3', 1, 1)
INSERT [dbo].[Account] ([AccID], [UserName], [Password], [EmpID], [Permission], [isDeleted]) VALUES (N'acc4', N'tuongvy', N'12345', N'nv4', 1, 1)
INSERT [dbo].[Account] ([AccID], [UserName], [Password], [EmpID], [Permission], [isDeleted]) VALUES (N'acc5', N'xuanhoang', N'12345', N'nv5', 1, 1)
INSERT [dbo].[Account] ([AccID], [UserName], [Password], [EmpID], [Permission], [isDeleted]) VALUES (N'acc6', N'huynhxiem', N'12345', N'nv6', 1, 1)
INSERT [dbo].[Account] ([AccID], [UserName], [Password], [EmpID], [Permission], [isDeleted]) VALUES (N'Acc7', N'test', N'123', N'nv2', 1, 0)
INSERT [dbo].[Account] ([AccID], [UserName], [Password], [EmpID], [Permission], [isDeleted]) VALUES (N'Acc8', N'huynhxiem', N'12345', N'nv6', 1, 1)
GO
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C1', N'Yogurt cup', N'L3', 32000, 109, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C10', N'Đan mạch phô mai hạnh nhân', N'L1', 22000, 79, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C11', N'Đan mạch thơm hạnh nhân', N'L1', 20000, 90, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C12', N'Blueberry spaceship', N'L1', 17000, 110, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C13', N'Mexico cafe', N'L1', 17000, 120, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C14', N'Pizza chay', N'L6', 30000, 110, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C15', N'Patechaud', N'L6', 18000, 80, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C16', N'Pizza foccacia', N'L6', 30000, 110, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C2', N'Oreo cheese cake', N'L3', 40000, 243, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C3', N'Almond chocolate', N'L3', 40000, 94, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C4', N'Passion honey sweetie', N'L3', 35000, 120, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C5', N'Earl grey lychee mousse cake', N'L3', 35000, 67, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C6', N'Bánh sốt nấm', N'L2', 17000, 120, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C7', N'Xúc xích chà bông', N'L2', 17000, 140, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C8', N'Chà bông phô mai', N'L2', 17000, 89, NULL, 1)
INSERT [dbo].[Cake] ([CakeID], [CakeName], [CategoryID], [UnitPrice], [Quantity], [Img], [isDeleted]) VALUES (N'C9', N'Croissant hạt dẻ', N'L1', 30000, 67, NULL, 1)
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [isDeleted]) VALUES (N'L1', N'Bánh ngọt', 1)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [isDeleted]) VALUES (N'L2', N'Bánh mặn', 1)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [isDeleted]) VALUES (N'L3', N'Bánh kem', 1)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [isDeleted]) VALUES (N'L4', N'Bánh chay', 1)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [isDeleted]) VALUES (N'L5', N'Bánh donut', 1)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [isDeleted]) VALUES (N'L6', N'Pizza', 1)
GO
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH1', N'Tran Thu Hang', CAST(N'1999-11-11' AS Date), N'0932448576', N'Nu', N'TPHCM', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH10', N'Nguyễn Kim Ngân', CAST(N'2002-06-02' AS Date), N'0135842543', N'Nữ', N'TPHCM', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH11', N'VYY', CAST(N'2022-11-21' AS Date), N'123', N'Nữ', N'TPHCM', 0)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH12', N'Vii', CAST(N'2022-11-21' AS Date), N'908200456', N'Nữ', N'Long An', 0)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH13', N'vy', CAST(N'2022-11-21' AS Date), N'703392404', N'Nữ', N'long an', 0)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH2', N'Nguyễn Văn Tộ', CAST(N'1995-03-25' AS Date), N'0987351982', N'Nam', N'TPHCM', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH3', N'Nguyễn Văn Trọng', CAST(N'1996-02-10' AS Date), N'0906736781', N'Nam', N'Tân Bình', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH4', N'Le Van Sy', CAST(N'2000-02-20' AS Date), N'0368076678', N'Nam', N'Đồng Nai', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH5', N'Lý Thị Tư', CAST(N'2000-03-06' AS Date), N'0908339010', N'Nữ', N'TPHCM', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH6', N'Lê Thị Như', CAST(N'2002-06-06' AS Date), N'0876359120', N'Nữ', N'Quảng Ngãi', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH7', N'Lê Đức Trọng', CAST(N'1992-07-25' AS Date), N'0790321346', N'Nam', N'Tân Phú', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH8', N'Nguyễn Thi Sỉ', CAST(N'2003-08-22' AS Date), N'0102350463', N'Nam', N'TPHCM', 1)
INSERT [dbo].[Customer] ([CusID], [Name], [DoB], [Phone], [Sex], [Address], [isDeleted]) VALUES (N'KH9', N'Lê Đại Nghĩa', CAST(N'1993-05-08' AS Date), N'0324056624', N'Nam', N'Cà Mau', 1)
GO
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Position], [Sex], [Phone], [Address], [isDeleted]) VALUES (N'nv1', N'Võ Trần Tấn Lộc', N'NV quan ly', N'Nam', N'0932447520', N'Quang Ngai', 1)
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Position], [Sex], [Phone], [Address], [isDeleted]) VALUES (N'nv2', N'Đỗ Ngọc Lương Tuấn', N'NV', N'Nam', N'0908773513', N'Tan Binh', 1)
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Position], [Sex], [Phone], [Address], [isDeleted]) VALUES (N'nv3', N'Ôn Hà Uyển Nhi', N'NV', N'Nu', N'0', N'0', 1)
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Position], [Sex], [Phone], [Address], [isDeleted]) VALUES (N'nv4', N'Tường Vy', N'NV', N'Nu', N'0', N'0', 1)
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Position], [Sex], [Phone], [Address], [isDeleted]) VALUES (N'nv5', N'Xuân Hoàng', N'NV', N'Nam', N'0', N'0', 1)
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Position], [Sex], [Phone], [Address], [isDeleted]) VALUES (N'nv6', N'Huỳnh Xiêm', N'NV', N'Nam', N'0', N'0', 1)
INSERT [dbo].[Employee] ([EmpID], [EmpName], [Position], [Sex], [Phone], [Address], [isDeleted]) VALUES (N'nv7', N'Tường Vy', N'NV', N'Nữ', N'0703392400', N'TPHCM', 0)
GO
INSERT [dbo].[Import] ([ImportID], [SuppID], [Date], [EmployeeID], [isDeleted]) VALUES (N'IMP1', N'Sup1', CAST(N'2002-12-07' AS Date), N'nv1', 1)
GO
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'HD11', N'KH9', N'nv4', CAST(N'2022-11-18T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'O1', N'KH1', N'nv1', CAST(N'2022-11-11T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'O2', N'KH3', N'nv1', CAST(N'2022-09-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'O3', N'KH7', N'nv1', CAST(N'2022-11-11T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'O4', N'KH1', N'nv1', CAST(N'2022-11-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'O5', N'KH4', N'nv1', CAST(N'2022-10-14T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'O6', N'KH8', N'nv1', CAST(N'2022-11-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'O7', N'KH4', N'nv1', CAST(N'2022-12-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([OrderID], [CusID], [EmpID], [Date], [isDeleted]) VALUES (N'O8', N'KH1', N'nv1', CAST(N'2022-10-14T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CakeID], [Quantity], [Price], [isDeleted]) VALUES (N'OD1', N'O1', N'C1', 12, 384000, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CakeID], [Quantity], [Price], [isDeleted]) VALUES (N'OD2', N'O1', N'C2', 7, 280000, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CakeID], [Quantity], [Price], [isDeleted]) VALUES (N'OD3', N'O1', N'C1', 12, 384000, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CakeID], [Quantity], [Price], [isDeleted]) VALUES (N'OD4', N'O1', N'C6', 9, 153000, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CakeID], [Quantity], [Price], [isDeleted]) VALUES (N'OD5', N'O1', N'C1', 7, 224000, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CakeID], [Quantity], [Price], [isDeleted]) VALUES (N'OD6', N'O1', N'C3', 3, 120000, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CakeID], [Quantity], [Price], [isDeleted]) VALUES (N'OD7', N'O1', N'C9', 23, 690000, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CakeID], [Quantity], [Price], [isDeleted]) VALUES (N'OD8', N'O1', N'C1', 9, 288000, 1)
GO
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup1', N'Công ty bánh kẹo ABC', N'Quảng Ngãi', 1, N'abc@gmail.com', N'0901 69 8911', N'Tường Vy')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup10', N'Công ty bánh kẹo Hải Hà', N'Đà Nẵng', 0, N'haiha@gmail.com', N'0901 69 8920', N'Huỳnh Xiêm')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup11', N'Công ty bánh kẹo ADV', N'Vũng Tàu', 0, N'adv@gmail.com', N'0901 69 8918', N'Huỳnh Xiêm')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup12', N'Công ty bánh kẹo hải hà', N'Vũng Tàu', 0, N'haiha@gmail.com', N'901698917', N'Huỳnh Xiêm')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup13', N'vi', N'long an', 0, N'vi@gmail.com', N'703392400', N'vii')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup14', N'vii', N'an lạc', 0, N'vii@gmail.com', N'790023457', N'vy')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup2', N'Công ty bánh kẹo ABD', N'TPHCM', 1, N'abd@gmail.com', N'0901 69 8912', N'Tường Vy')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup3', N'Công bánh kẹo ABF', N'Quảng Bình', 1, N'abf@gmail.com', N'0901 69 8913', N'Tường Vy')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup4', N'Công ty bánh kẹo AKL', N'Huế', 1, N'akl@gmail.com', N'0901 69 8914', N'Uyển Nhi')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup5', N'Công ty bánh kẹo ATG', N'TPHCM', 1, N'atg@gmail.com', N'0901 69 8915', N'Uyển Nhi')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup6', N'Công ty bánh kẹo ATY', N'Tân Bình', 1, N'aty@gmail.com', N'0901 69 8916', N'Uyển Nhi')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup7', N'Công ty bánh kẹo AGF', N'Quảng Trị', 1, N'agf@gmail.com', N'0901 69 8917', N'Uyển Nhi')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup8', N'Công ty bánh kẹo ABF', N'abf@gmail.com', 0, N'Hải Phòng', N'0901 69 8918', N'Huỳnh Xiêm')
INSERT [dbo].[Supplier] ([SuppID], [SuppName], [Address], [isDeleted], [Email], [Phone], [ContactPerson]) VALUES (N'Sup9', N'Công ty bánh kẹo ABV', N'Quảng Ngãi', 0, N'abv@gmail.com', N'0901 69 8918', N'Xuân Hoàng')
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [Acc_EmpID_FK] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [Acc_EmpID_FK]
GO
ALTER TABLE [dbo].[Cake]  WITH CHECK ADD  CONSTRAINT [Cake_CateID_FK] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Cake] CHECK CONSTRAINT [Cake_CateID_FK]
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD  CONSTRAINT [Import_SuppID_FK] FOREIGN KEY([SuppID])
REFERENCES [dbo].[Supplier] ([SuppID])
GO
ALTER TABLE [dbo].[Import] CHECK CONSTRAINT [Import_SuppID_FK]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [ImpDe_CakeID_FK] FOREIGN KEY([CakeID])
REFERENCES [dbo].[Cake] ([CakeID])
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [ImpDe_CakeID_FK]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [ImpDe_ImportID_FK] FOREIGN KEY([ImportID])
REFERENCES [dbo].[Import] ([ImportID])
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [ImpDe_ImportID_FK]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [Order_CusID_FK] FOREIGN KEY([CusID])
REFERENCES [dbo].[Customer] ([CusID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [Order_CusID_FK]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [Order_EmpID_FK] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [Order_EmpID_FK]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [OrDe_CakeID_FK] FOREIGN KEY([CakeID])
REFERENCES [dbo].[Cake] ([CakeID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [OrDe_CakeID_FK]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [OrDe_OrderID_FK] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [OrDe_OrderID_FK]
GO
