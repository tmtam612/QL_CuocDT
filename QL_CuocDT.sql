USE [master]
GO
/****** Object:  Database [QL_CuocDT]    Script Date: 12/1/2018 2:18:49 PM ******/
CREATE DATABASE [QL_CuocDT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_CuocDT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QL_CuocDT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_CuocDT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QL_CuocDT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QL_CuocDT] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_CuocDT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_CuocDT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_CuocDT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_CuocDT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_CuocDT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_CuocDT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_CuocDT] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_CuocDT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_CuocDT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_CuocDT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_CuocDT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_CuocDT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_CuocDT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_CuocDT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_CuocDT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_CuocDT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_CuocDT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_CuocDT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_CuocDT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_CuocDT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_CuocDT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_CuocDT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_CuocDT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_CuocDT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_CuocDT] SET  MULTI_USER 
GO
ALTER DATABASE [QL_CuocDT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_CuocDT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_CuocDT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_CuocDT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_CuocDT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_CuocDT] SET QUERY_STORE = OFF
GO
USE [QL_CuocDT]
GO
/****** Object:  Table [dbo].[CuocGoi]    Script Date: 12/1/2018 2:18:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuocGoi](
	[MaCuocGoi] [int] IDENTITY(1,1) NOT NULL,
	[MaSim] [int] NOT NULL,
	[TG_BatDau] [datetime] NOT NULL,
	[TG_KetThuc] [datetime] NOT NULL,
	[SoPhutSD] [int] NOT NULL,
	[trangthai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCuocGoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonDK]    Script Date: 12/1/2018 2:18:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonDK](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaSim] [int] NOT NULL,
	[TG_DangKy] [datetime] NOT NULL,
	[ChiPhi] [decimal](18, 0) NOT NULL,
	[MaKH] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonThanhToan]    Script Date: 12/1/2018 2:18:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonThanhToan](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaSim] [int] NOT NULL,
	[CuocThueBao] [decimal](18, 0) NOT NULL,
	[TG_TaoHoaDon] [datetime] NOT NULL,
	[ThanhToan] [bit] NOT NULL,
	[ThanhTien] [decimal](18, 0) NOT NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/1/2018 2:18:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[CMND] [nvarchar](50) NOT NULL,
	[NgheNghiep] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiCuoc]    Script Date: 12/1/2018 2:18:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiCuoc](
	[TG_BatDau] [time](7) NOT NULL,
	[TG_KetThuc] [time](7) NOT NULL,
	[GiaCuoc] [decimal](18, 0) NOT NULL,
	[Status] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sim]    Script Date: 12/1/2018 2:18:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sim](
	[MaSim] [int] IDENTITY(1,1) NOT NULL,
	[SoSim] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CuocGoi] ON 

INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3109, 2, CAST(N'2018-12-28T19:25:19.000' AS DateTime), CAST(N'2018-12-28T22:10:10.000' AS DateTime), 165, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3110, 7, CAST(N'2018-12-07T05:14:18.000' AS DateTime), CAST(N'2018-12-07T14:43:24.000' AS DateTime), 569, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3111, 9, CAST(N'2018-12-19T01:15:22.000' AS DateTime), CAST(N'2018-12-19T09:53:12.000' AS DateTime), 518, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3112, 8, CAST(N'2018-12-08T01:14:25.000' AS DateTime), CAST(N'2018-12-08T05:57:14.000' AS DateTime), 283, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3113, 20, CAST(N'2018-12-16T14:28:25.000' AS DateTime), CAST(N'2018-12-16T17:58:17.000' AS DateTime), 210, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3114, 20, CAST(N'2018-12-21T02:01:36.000' AS DateTime), CAST(N'2018-12-21T20:55:29.000' AS DateTime), 1134, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3115, 5, CAST(N'2018-12-30T09:29:21.000' AS DateTime), CAST(N'2018-12-30T13:39:18.000' AS DateTime), 250, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3116, 7, CAST(N'2018-12-22T18:13:10.000' AS DateTime), CAST(N'2018-12-22T19:22:39.000' AS DateTime), 69, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3117, 7, CAST(N'2018-12-10T00:39:43.000' AS DateTime), CAST(N'2018-12-10T12:04:37.000' AS DateTime), 685, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3118, 3, CAST(N'2018-12-17T06:31:35.000' AS DateTime), CAST(N'2018-12-17T15:43:53.000' AS DateTime), 552, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3119, 3, CAST(N'2018-12-28T10:56:48.000' AS DateTime), CAST(N'2018-12-28T15:53:54.000' AS DateTime), 297, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3120, 10, CAST(N'2018-12-24T10:38:02.000' AS DateTime), CAST(N'2018-12-24T21:04:54.000' AS DateTime), 627, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3121, 20, CAST(N'2018-12-04T02:33:48.000' AS DateTime), CAST(N'2018-12-04T17:46:28.000' AS DateTime), 913, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3122, 20, CAST(N'2018-12-14T07:58:01.000' AS DateTime), CAST(N'2018-12-14T16:57:29.000' AS DateTime), 539, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3123, 12, CAST(N'2018-12-09T18:10:48.000' AS DateTime), CAST(N'2018-12-09T19:40:01.000' AS DateTime), 89, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3124, 20, CAST(N'2018-12-09T03:02:24.000' AS DateTime), CAST(N'2018-12-09T08:43:55.000' AS DateTime), 342, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3125, 10, CAST(N'2018-12-01T03:00:14.000' AS DateTime), CAST(N'2018-12-01T18:00:04.000' AS DateTime), 900, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3126, 8, CAST(N'2018-12-26T15:12:01.000' AS DateTime), CAST(N'2018-12-26T21:43:35.000' AS DateTime), 392, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3127, 8, CAST(N'2018-12-07T19:37:14.000' AS DateTime), CAST(N'2018-12-07T20:53:37.000' AS DateTime), 76, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3128, 7, CAST(N'2018-12-02T07:49:01.000' AS DateTime), CAST(N'2018-12-02T23:37:09.000' AS DateTime), 948, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3129, 6, CAST(N'2018-12-13T11:14:14.000' AS DateTime), CAST(N'2018-12-13T23:47:10.000' AS DateTime), 753, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3130, 6, CAST(N'2018-12-23T16:39:27.000' AS DateTime), CAST(N'2018-12-23T22:57:12.000' AS DateTime), 378, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3131, 3, CAST(N'2018-12-09T14:51:35.000' AS DateTime), CAST(N'2018-12-09T22:40:46.000' AS DateTime), 469, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3132, 12, CAST(N'2018-12-01T00:12:19.000' AS DateTime), CAST(N'2018-12-01T17:32:05.000' AS DateTime), 1040, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3133, 8, CAST(N'2018-12-08T04:50:35.000' AS DateTime), CAST(N'2018-12-08T13:04:45.000' AS DateTime), 494, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3134, 3, CAST(N'2018-12-05T00:53:27.000' AS DateTime), CAST(N'2018-12-05T02:44:18.000' AS DateTime), 111, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3135, 8, CAST(N'2018-12-03T00:02:53.000' AS DateTime), CAST(N'2018-12-03T16:46:07.000' AS DateTime), 1003, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3136, 12, CAST(N'2018-12-29T01:45:12.000' AS DateTime), CAST(N'2018-12-29T11:16:29.000' AS DateTime), 571, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3137, 5, CAST(N'2018-12-27T18:27:45.000' AS DateTime), CAST(N'2018-12-27T23:27:03.000' AS DateTime), 299, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3138, 12, CAST(N'2018-12-02T01:19:53.000' AS DateTime), CAST(N'2018-12-02T04:57:54.000' AS DateTime), 218, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3139, 9, CAST(N'2018-12-23T16:26:31.000' AS DateTime), CAST(N'2018-12-23T22:09:50.000' AS DateTime), 343, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3140, 4, CAST(N'2018-12-15T04:34:44.000' AS DateTime), CAST(N'2018-12-15T20:48:26.000' AS DateTime), 974, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3141, 3, CAST(N'2018-12-22T06:25:31.000' AS DateTime), CAST(N'2018-12-22T14:33:49.000' AS DateTime), 488, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3142, 6, CAST(N'2018-12-17T08:08:49.000' AS DateTime), CAST(N'2018-12-17T09:03:11.000' AS DateTime), 54, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3143, 3, CAST(N'2018-12-17T02:37:49.000' AS DateTime), CAST(N'2018-12-17T17:15:11.000' AS DateTime), 877, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3144, 6, CAST(N'2018-12-20T01:10:53.000' AS DateTime), CAST(N'2018-12-20T10:38:34.000' AS DateTime), 568, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3145, 6, CAST(N'2018-12-01T05:35:06.000' AS DateTime), CAST(N'2018-12-01T10:48:35.000' AS DateTime), 313, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3146, 5, CAST(N'2018-12-12T09:00:20.000' AS DateTime), CAST(N'2018-12-12T09:58:37.000' AS DateTime), 58, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3147, 4, CAST(N'2018-12-07T19:02:27.000' AS DateTime), CAST(N'2018-12-07T23:39:54.000' AS DateTime), 277, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3148, 4, CAST(N'2018-12-17T02:37:19.000' AS DateTime), CAST(N'2018-12-17T12:51:10.000' AS DateTime), 614, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3149, 3, CAST(N'2018-12-28T06:02:33.000' AS DateTime), CAST(N'2018-12-28T11:01:12.000' AS DateTime), 299, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3150, 10, CAST(N'2018-12-29T03:14:21.000' AS DateTime), CAST(N'2018-12-29T22:20:45.000' AS DateTime), 1146, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3151, 9, CAST(N'2018-12-01T05:13:45.000' AS DateTime), CAST(N'2018-12-01T18:45:15.000' AS DateTime), 812, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3152, 12, CAST(N'2018-12-29T10:51:19.000' AS DateTime), CAST(N'2018-12-29T16:38:16.000' AS DateTime), 347, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3153, 12, CAST(N'2018-12-10T14:16:32.000' AS DateTime), CAST(N'2018-12-10T16:48:18.000' AS DateTime), 152, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3154, 10, CAST(N'2018-12-22T02:42:50.000' AS DateTime), CAST(N'2018-12-22T09:14:50.000' AS DateTime), 392, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3155, 9, CAST(N'2018-12-16T06:53:32.000' AS DateTime), CAST(N'2018-12-16T18:41:51.000' AS DateTime), 708, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3156, 9, CAST(N'2018-12-27T10:18:46.000' AS DateTime), CAST(N'2018-12-27T17:52:53.000' AS DateTime), 454, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3157, 9, CAST(N'2018-12-07T15:43:59.000' AS DateTime), CAST(N'2018-12-07T17:02:54.000' AS DateTime), 79, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3158, 7, CAST(N'2018-12-02T03:55:45.000' AS DateTime), CAST(N'2018-12-02T20:45:26.000' AS DateTime), 1010, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3159, 7, CAST(N'2018-12-13T07:20:59.000' AS DateTime), CAST(N'2018-12-13T19:55:28.000' AS DateTime), 754, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3160, 5, CAST(N'2018-12-08T19:32:45.000' AS DateTime), CAST(N'2018-12-08T22:38:59.000' AS DateTime), 186, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3161, 4, CAST(N'2018-12-10T03:00:00.000' AS DateTime), CAST(N'2018-12-10T22:57:40.000' AS DateTime), 1198, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3162, 5, CAST(N'2018-12-30T03:22:12.000' AS DateTime), CAST(N'2018-12-30T21:59:02.000' AS DateTime), 1117, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3163, 3, CAST(N'2018-12-25T15:34:58.000' AS DateTime), CAST(N'2018-12-25T23:42:34.000' AS DateTime), 488, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3164, 3, CAST(N'2018-12-06T19:59:12.000' AS DateTime), CAST(N'2018-12-06T23:52:35.000' AS DateTime), 233, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3165, 3, CAST(N'2018-12-16T00:24:25.000' AS DateTime), CAST(N'2018-12-16T23:02:37.000' AS DateTime), 1358, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3166, 7, CAST(N'2018-12-09T05:08:53.000' AS DateTime), CAST(N'2018-12-09T19:41:22.000' AS DateTime), 872, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3167, 10, CAST(N'2018-12-29T09:24:37.000' AS DateTime), CAST(N'2018-12-29T19:45:22.000' AS DateTime), 621, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3168, 2, CAST(N'2018-12-24T10:06:56.000' AS DateTime), CAST(N'2018-12-24T15:15:44.000' AS DateTime), 309, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3169, 10, CAST(N'2018-12-24T05:36:56.000' AS DateTime), CAST(N'2018-12-24T22:27:44.000' AS DateTime), 1011, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3170, 7, CAST(N'2018-12-23T00:05:56.000' AS DateTime), CAST(N'2018-12-23T06:39:44.000' AS DateTime), 394, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3171, 8, CAST(N'2018-12-04T00:15:24.000' AS DateTime), CAST(N'2018-12-04T05:42:16.000' AS DateTime), 327, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3172, 8, CAST(N'2018-12-15T04:40:38.000' AS DateTime), CAST(N'2018-12-15T05:52:18.000' AS DateTime), 72, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3173, 4, CAST(N'2018-12-18T15:47:14.000' AS DateTime), CAST(N'2018-12-18T17:33:05.000' AS DateTime), 106, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3174, 7, CAST(N'2018-12-18T06:26:10.000' AS DateTime), CAST(N'2018-12-18T22:43:45.000' AS DateTime), 978, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3175, 6, CAST(N'2018-12-01T01:42:51.000' AS DateTime), CAST(N'2018-12-01T07:56:53.000' AS DateTime), 374, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3176, 8, CAST(N'2018-12-08T12:42:52.000' AS DateTime), CAST(N'2018-12-08T15:44:48.000' AS DateTime), 182, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3177, 5, CAST(N'2018-12-08T07:11:52.000' AS DateTime), CAST(N'2018-12-08T23:56:48.000' AS DateTime), 1005, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3178, 2, CAST(N'2018-12-07T02:41:52.000' AS DateTime), CAST(N'2018-12-07T07:08:47.000' AS DateTime), 267, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3179, 2, CAST(N'2018-12-13T09:56:51.000' AS DateTime), CAST(N'2018-12-13T11:43:59.000' AS DateTime), 107, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3180, 12, CAST(N'2018-12-17T07:20:45.000' AS DateTime), CAST(N'2018-12-17T16:39:43.000' AS DateTime), 559, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3181, 10, CAST(N'2018-12-01T17:22:10.000' AS DateTime), CAST(N'2018-12-01T18:02:09.000' AS DateTime), 40, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3182, 12, CAST(N'2018-12-30T05:57:04.000' AS DateTime), CAST(N'2018-12-30T13:46:34.000' AS DateTime), 470, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3183, 12, CAST(N'2018-12-10T10:22:17.000' AS DateTime), CAST(N'2018-12-10T12:56:35.000' AS DateTime), 154, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3184, 3, CAST(N'2018-12-22T15:17:47.000' AS DateTime), CAST(N'2018-12-22T16:14:52.000' AS DateTime), 57, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3185, 9, CAST(N'2018-12-16T02:59:17.000' AS DateTime), CAST(N'2018-12-16T14:50:09.000' AS DateTime), 711, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3186, 9, CAST(N'2018-12-27T06:24:30.000' AS DateTime), CAST(N'2018-12-27T14:00:10.000' AS DateTime), 456, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3187, 6, CAST(N'2018-12-13T05:22:29.000' AS DateTime), CAST(N'2018-12-13T23:47:46.000' AS DateTime), 1105, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3188, 9, CAST(N'2018-12-16T01:28:06.000' AS DateTime), CAST(N'2018-12-16T11:20:13.000' AS DateTime), 592, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3189, 7, CAST(N'2018-12-14T03:26:44.000' AS DateTime), CAST(N'2018-12-14T16:03:45.000' AS DateTime), 757, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3190, 5, CAST(N'2018-12-09T14:38:30.000' AS DateTime), CAST(N'2018-12-09T18:47:16.000' AS DateTime), 249, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3191, 6, CAST(N'2018-12-10T16:10:25.000' AS DateTime), CAST(N'2018-12-10T22:14:34.000' AS DateTime), 364, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3192, 4, CAST(N'2018-12-15T06:15:30.000' AS DateTime), CAST(N'2018-12-15T21:40:50.000' AS DateTime), 925, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3193, 3, CAST(N'2018-12-25T11:40:43.000' AS DateTime), CAST(N'2018-12-25T20:50:51.000' AS DateTime), 550, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3194, 3, CAST(N'2018-12-06T15:05:56.000' AS DateTime), CAST(N'2018-12-06T20:00:53.000' AS DateTime), 295, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3195, 2, CAST(N'2018-12-01T03:17:43.000' AS DateTime), CAST(N'2018-12-01T22:44:24.000' AS DateTime), 1167, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3196, 20, CAST(N'2018-12-23T12:07:10.000' AS DateTime), CAST(N'2018-12-23T21:04:28.000' AS DateTime), 537, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3197, 5, CAST(N'2018-12-07T10:38:00.000' AS DateTime), CAST(N'2018-12-07T22:05:45.000' AS DateTime), 688, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3198, 20, CAST(N'2018-12-24T18:45:21.000' AS DateTime), CAST(N'2018-12-24T22:44:38.000' AS DateTime), 239, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3199, 5, CAST(N'2018-12-08T06:38:07.000' AS DateTime), CAST(N'2018-12-08T13:20:35.000' AS DateTime), 402, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3200, 2, CAST(N'2018-12-15T05:22:12.000' AS DateTime), CAST(N'2018-12-15T21:33:17.000' AS DateTime), 971, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3201, 8, CAST(N'2018-12-15T00:46:23.000' AS DateTime), CAST(N'2018-12-15T01:01:35.000' AS DateTime), 15, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3202, 20, CAST(N'2018-12-28T04:16:32.000' AS DateTime), CAST(N'2018-12-28T07:05:37.000' AS DateTime), 169, 0)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3203, 9, CAST(N'2018-12-14T05:39:58.000' AS DateTime), CAST(N'2018-12-14T12:20:21.000' AS DateTime), 400, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3204, 6, CAST(N'2018-12-13T00:08:58.000' AS DateTime), CAST(N'2018-12-13T20:32:20.000' AS DateTime), 1223, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3205, 10, CAST(N'2018-12-09T01:51:16.000' AS DateTime), CAST(N'2018-12-09T15:02:42.000' AS DateTime), 791, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3206, 7, CAST(N'2018-12-08T20:20:16.000' AS DateTime), CAST(N'2018-12-08T23:14:42.000' AS DateTime), 174, 1)
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3207, 3, CAST(N'2018-12-03T00:37:22.000' AS DateTime), CAST(N'2018-12-03T08:41:15.000' AS DateTime), 484, 1)
GO
INSERT [dbo].[CuocGoi] ([MaCuocGoi], [MaSim], [TG_BatDau], [TG_KetThuc], [SoPhutSD], [trangthai]) VALUES (3208, 3, CAST(N'2018-12-14T05:02:35.000' AS DateTime), CAST(N'2018-12-14T07:51:16.000' AS DateTime), 169, 1)
SET IDENTITY_INSERT [dbo].[CuocGoi] OFF
SET IDENTITY_INSERT [dbo].[HoaDonDK] ON 

INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (0, 2, CAST(N'2016-09-29T11:00:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 0)
INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (2, 4, CAST(N'2016-12-15T13:23:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 2)
INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (3, 5, CAST(N'2016-12-29T16:30:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 3)
INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (4, 6, CAST(N'2017-04-28T15:58:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 4)
INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (5, 7, CAST(N'2018-06-22T00:00:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 5)
INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (6, 8, CAST(N'2017-09-21T11:25:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 6)
INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (7, 9, CAST(N'2017-06-26T17:45:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 7)
INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (8, 10, CAST(N'2016-10-21T18:00:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 7)
INSERT [dbo].[HoaDonDK] ([MaHD], [MaSim], [TG_DangKy], [ChiPhi], [MaKH]) VALUES (19, 3, CAST(N'2018-06-12T08:45:20.000' AS DateTime), CAST(50000 AS Decimal(18, 0)), 11)
SET IDENTITY_INSERT [dbo].[HoaDonDK] OFF
SET IDENTITY_INSERT [dbo].[HoaDonThanhToan] ON 

INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (257, 0, 2, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.217' AS DateTime), 0, CAST(618250 AS Decimal(18, 0)), 1)
INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (258, 2, 4, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.283' AS DateTime), 0, CAST(820300 AS Decimal(18, 0)), 1)
INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (259, 3, 5, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.303' AS DateTime), 0, CAST(823650 AS Decimal(18, 0)), 1)
INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (260, 4, 6, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.323' AS DateTime), 0, CAST(925450 AS Decimal(18, 0)), 1)
INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (261, 5, 7, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.347' AS DateTime), 0, CAST(1364750 AS Decimal(18, 0)), 1)
INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (262, 6, 8, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.367' AS DateTime), 0, CAST(556650 AS Decimal(18, 0)), 1)
INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (263, 7, 9, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.383' AS DateTime), 0, CAST(1007250 AS Decimal(18, 0)), 1)
INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (264, 7, 10, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.407' AS DateTime), 0, CAST(1099950 AS Decimal(18, 0)), 1)
INSERT [dbo].[HoaDonThanhToan] ([MaHD], [MaKH], [MaSim], [CuocThueBao], [TG_TaoHoaDon], [ThanhToan], [ThanhTien], [Status]) VALUES (265, 11, 3, CAST(50000 AS Decimal(18, 0)), CAST(N'2018-12-01T13:09:09.423' AS DateTime), 0, CAST(1241750 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[HoaDonThanhToan] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (0, N'CTY TNHH THƯƠNG MẠI HOA LỢI', N'25400649', N'Kinh Doanh', N'284/6, NGUYỄN TRỌNG TUYỂN, P.10, PHÚ NHUẬN', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (2, N'NGUYỄN NGỌC HUỲNH NHƯ', N'25454976', N'Bán Hàng', N'30/32 - NGUYỄN BỈNH KHIÊM - P.1 - GÒ VẤP - TP HCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (3, N'ĐÀO VĂN PHÚC', N'25446098', N'Nội Trợ', N'58/647, NGUYỄN OANH, P.17, GÒ VẤP', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (4, N'CTY TNHH TM DV VẬN TẢI DƯƠNG THÀNH', N'25433339', N'Kinh Doanh', N'46/1, HÙNG VƯƠNG, P.1, Q.10', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (5, N'PHẠM THỊ VÂN KHÁNH', N'25488912', N'Giảng Viên', N'326, NGUYỄN CHÍ THANH, P.5, Q.10', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (6, N'TRỊNH THỊ HỒNG', N'25494671', N'Sinh Viên', N'161/3F, HÙNG VƯƠNG, P.6, Q.06', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (7, N'NGUYỄN THANH THẠCH', N'25450784', N'Văn Phòng', N'20, KHU 1, TÂN SƠN NHÌ, TÂN SƠN NHÌ, TÂN PHÚ', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (9, N'VÕ THANH BÌNH', N'25458659
', N'Bán Hàng', N'232/6, VÕ THỊ SÁU, P.7, Q.03', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (10, N'LÊ THỊ THU CÚC', N'25423812
', N'Sinh Viên', N'338A, NƠ TRANG LONG, P.13, BÌNH THẠNH', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (11, N'Trần Minh Tâm', N'025546728', N'Sinh viên', N'107/100/5 Quang Trung', 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (12, N'bc', N'a', N'a', N'a', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (13, N'admina', N'2198129481a', N'11290419a', N'1312313a', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (14, N'sfa', N'fafa', N'fafa', N'aga', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (15, N'dda', N'dadaeqwewq', N'dadada', N'dada', 0)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [CMND], [NgheNghiep], [DiaChi], [Status]) VALUES (17, N'dadad', N'dadadada', N'dadadada', N'dadada', 0)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiCuoc] ([TG_BatDau], [TG_KetThuc], [GiaCuoc], [Status]) VALUES (CAST(N'07:00:00' AS Time), CAST(N'23:00:00' AS Time), CAST(200 AS Decimal(18, 0)), 1)
INSERT [dbo].[LoaiCuoc] ([TG_BatDau], [TG_KetThuc], [GiaCuoc], [Status]) VALUES (CAST(N'23:00:00' AS Time), CAST(N'07:00:00' AS Time), CAST(150 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[Sim] ON 

INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (2, N'84913805266', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (3, N'841236969334', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (4, N'84913919143', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (5, N'84918725997', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (6, N'84913905878', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (7, N'84918588499', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (8, N'84948021619', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (9, N'84918015588', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (10, N'84913750047', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (12, N'112', 1)
INSERT [dbo].[Sim] ([MaSim], [SoSim], [Status]) VALUES (20, N'123', 1)
SET IDENTITY_INSERT [dbo].[Sim] OFF
ALTER TABLE [dbo].[CuocGoi]  WITH CHECK ADD  CONSTRAINT [FK_CuocGoi_Sim] FOREIGN KEY([MaSim])
REFERENCES [dbo].[Sim] ([MaSim])
GO
ALTER TABLE [dbo].[CuocGoi] CHECK CONSTRAINT [FK_CuocGoi_Sim]
GO
ALTER TABLE [dbo].[HoaDonDK]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonDK_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonDK] CHECK CONSTRAINT [FK_HoaDonDK_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonDK]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonDK_Sim] FOREIGN KEY([MaSim])
REFERENCES [dbo].[Sim] ([MaSim])
GO
ALTER TABLE [dbo].[HoaDonDK] CHECK CONSTRAINT [FK_HoaDonDK_Sim]
GO
ALTER TABLE [dbo].[HoaDonThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonThanhToan_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonThanhToan] CHECK CONSTRAINT [FK_HoaDonThanhToan_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonThanhToan_Sim] FOREIGN KEY([MaSim])
REFERENCES [dbo].[Sim] ([MaSim])
GO
ALTER TABLE [dbo].[HoaDonThanhToan] CHECK CONSTRAINT [FK_HoaDonThanhToan_Sim]
GO
USE [master]
GO
ALTER DATABASE [QL_CuocDT] SET  READ_WRITE 
GO
