USE [master]
GO
/****** Object:  Database [EShoppingDB]    Script Date: 6/12/2025 10:59:08 AM ******/
CREATE DATABASE [EShoppingDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EShopping', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\EShopping.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EShopping_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\EShopping_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [EShoppingDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EShoppingDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EShoppingDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EShoppingDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EShoppingDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EShoppingDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EShoppingDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EShoppingDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EShoppingDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EShoppingDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EShoppingDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EShoppingDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EShoppingDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EShoppingDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EShoppingDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EShoppingDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EShoppingDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EShoppingDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EShoppingDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EShoppingDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EShoppingDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EShoppingDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EShoppingDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EShoppingDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EShoppingDB] SET RECOVERY FULL 
GO
ALTER DATABASE [EShoppingDB] SET  MULTI_USER 
GO
ALTER DATABASE [EShoppingDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EShoppingDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EShoppingDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EShoppingDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EShoppingDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EShoppingDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EShoppingDB', N'ON'
GO
ALTER DATABASE [EShoppingDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [EShoppingDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [EShoppingDB]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 6/12/2025 10:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](1000) NULL,
	[Password] [nvarchar](50) NULL,
	[RoleId] [int] NULL,
	[IsActive] [int] NULL,
 CONSTRAINT [PK_tblLogin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOrder]    Script Date: 6/12/2025 10:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [nvarchar](50) NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[UserId] [int] NULL,
	[OrderStatus] [int] NULL,
	[IsPayment] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_tblOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOrderDetails]    Script Date: 6/12/2025 10:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 2) NULL,
	[OrderId] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_tblOrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPayment]    Script Date: 6/12/2025 10:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPayment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[PaymentMode] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
	[TransactionID] [nvarchar](1000) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_tblPayment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 6/12/2025 10:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](1000) NULL,
	[ProductDescription] [nvarchar](2000) NULL,
	[Size] [nvarchar](50) NULL,
	[Color] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedOn] [datetime] NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRole]    Script Date: 6/12/2025 10:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUserDetail]    Script Date: 6/12/2025 10:59:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[Gender] [int] NULL,
 CONSTRAINT [PK_tblUserDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblLogin] ON 

INSERT [dbo].[tblLogin] ([ID], [UserName], [Password], [RoleId], [IsActive]) VALUES (1, N'vikash@test.com', N'123456', 1, 1)
INSERT [dbo].[tblLogin] ([ID], [UserName], [Password], [RoleId], [IsActive]) VALUES (2, N'practiceaws8882@gmail.com', N'123456', 1, 1)
SET IDENTITY_INSERT [dbo].[tblLogin] OFF
GO
SET IDENTITY_INSERT [dbo].[tblOrder] ON 

INSERT [dbo].[tblOrder] ([Id], [OrderNumber], [TotalPrice], [Discount], [UserId], [OrderStatus], [IsPayment], [CreatedOn], [UpdatedOn], [UpdatedBy]) VALUES (1, N'ORD1', CAST(2000.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 1, 1, 1, CAST(N'2025-06-10T09:48:54.593' AS DateTime), NULL, NULL)
INSERT [dbo].[tblOrder] ([Id], [OrderNumber], [TotalPrice], [Discount], [UserId], [OrderStatus], [IsPayment], [CreatedOn], [UpdatedOn], [UpdatedBy]) VALUES (2, N'ORD2', CAST(2000.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 1, 1, 1, CAST(N'2025-06-10T10:11:38.823' AS DateTime), NULL, NULL)
INSERT [dbo].[tblOrder] ([Id], [OrderNumber], [TotalPrice], [Discount], [UserId], [OrderStatus], [IsPayment], [CreatedOn], [UpdatedOn], [UpdatedBy]) VALUES (3, N'ORD3', CAST(2000.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 1, 1, 1, CAST(N'2025-06-10T10:37:30.053' AS DateTime), NULL, NULL)
INSERT [dbo].[tblOrder] ([Id], [OrderNumber], [TotalPrice], [Discount], [UserId], [OrderStatus], [IsPayment], [CreatedOn], [UpdatedOn], [UpdatedBy]) VALUES (4, N'ORD4', CAST(2000.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 1, 1, 1, CAST(N'2025-06-10T10:46:57.760' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[tblOrderDetails] ON 

INSERT [dbo].[tblOrderDetails] ([Id], [ProductId], [Quantity], [Price], [OrderId], [CreatedDate], [UpdateDate], [UpdatedBy]) VALUES (1, 1, 2, CAST(1000.00 AS Decimal(18, 2)), 1, CAST(N'2025-06-10T09:48:56.727' AS DateTime), NULL, NULL)
INSERT [dbo].[tblOrderDetails] ([Id], [ProductId], [Quantity], [Price], [OrderId], [CreatedDate], [UpdateDate], [UpdatedBy]) VALUES (2, 1, 2, CAST(1000.00 AS Decimal(18, 2)), 2, CAST(N'2025-06-10T10:11:40.543' AS DateTime), NULL, NULL)
INSERT [dbo].[tblOrderDetails] ([Id], [ProductId], [Quantity], [Price], [OrderId], [CreatedDate], [UpdateDate], [UpdatedBy]) VALUES (3, 1, 2, CAST(1000.00 AS Decimal(18, 2)), 3, CAST(N'2025-06-10T10:37:30.473' AS DateTime), NULL, NULL)
INSERT [dbo].[tblOrderDetails] ([Id], [ProductId], [Quantity], [Price], [OrderId], [CreatedDate], [UpdateDate], [UpdatedBy]) VALUES (4, 1, 2, CAST(1000.00 AS Decimal(18, 2)), 4, CAST(N'2025-06-10T10:46:58.200' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblOrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[tblProduct] ON 

INSERT [dbo].[tblProduct] ([Id], [ProductName], [ProductDescription], [Size], [Color], [Quantity], [Price], [Discount], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (1, N'Nike T-SHirt', N'Nike T-SHirt Description', N'XL', N'Black', 12, CAST(1000.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUserDetail] ON 

INSERT [dbo].[tblUserDetail] ([Id], [UserId], [FirstName], [LastName], [Gender]) VALUES (1, 1, N'Vikash', N'Verma', 1)
INSERT [dbo].[tblUserDetail] ([Id], [UserId], [FirstName], [LastName], [Gender]) VALUES (2, 2, N'Raj', N'Kumar', 1)
SET IDENTITY_INSERT [dbo].[tblUserDetail] OFF
GO
USE [master]
GO
ALTER DATABASE [EShoppingDB] SET  READ_WRITE 
GO
