USE [master]
GO
/****** Object:  Database [DTDD]    Script Date: 07/19/2020 8:20:41 AM ******/
CREATE DATABASE [DTDD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DTDD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DTDD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DTDD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DTDD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DTDD] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DTDD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DTDD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DTDD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DTDD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DTDD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DTDD] SET ARITHABORT OFF 
GO
ALTER DATABASE [DTDD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DTDD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DTDD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DTDD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DTDD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DTDD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DTDD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DTDD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DTDD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DTDD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DTDD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DTDD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DTDD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DTDD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DTDD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DTDD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DTDD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DTDD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DTDD] SET  MULTI_USER 
GO
ALTER DATABASE [DTDD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DTDD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DTDD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DTDD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DTDD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DTDD] SET QUERY_STORE = OFF
GO
USE [DTDD]
GO
/****** Object:  Table [dbo].[BAOHANH]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOHANH](
	[MABAOHANH] [int] NOT NULL,
	[MAKH] [char](20) NOT NULL,
	[NGAYBAOHANH] [datetime] NULL,
	[NGAYBAOHANHXONG] [datetime] NULL,
	[MALOIND] [char](21) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ct_bH]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ct_bH](
	[MABAOHANH] [int] NOT NULL,
	[MANDBH] [int] NOT NULL,
	[MALK] [char](20) NOT NULL,
 CONSTRAINT [PK_ct_bH] PRIMARY KEY CLUSTERED 
(
	[MABAOHANH] ASC,
	[MANDBH] ASC,
	[MALK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_HOADON_LINHKIEN]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HOADON_LINHKIEN](
	[MALINHKIEN] [char](20) NOT NULL,
	[MAHD] [int] NOT NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_CT_HOADON_LINHKIEN_1] PRIMARY KEY CLUSTERED 
(
	[MALINHKIEN] ASC,
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ct_mua_SP]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ct_mua_SP](
	[MaHD] [int] NOT NULL,
	[MaKH] [char](20) NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[SL] [nchar](10) NULL,
 CONSTRAINT [PK_Ct_mua_SP_1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaKH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ct_mua_sp_lk]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ct_mua_sp_lk](
	[MaHD] [int] NOT NULL,
	[MaKH] [char](20) NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[MALINHKIEN] [char](20) NOT NULL,
	[SL] [nchar](10) NULL,
 CONSTRAINT [PK_ct_mua_sp_lk] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaKH] ASC,
	[MaSP] ASC,
	[MALINHKIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_NHAP_LK]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_NHAP_LK](
	[MALINHKIEN] [nchar](20) NULL,
	[MANHAP] [char](20) NULL,
	[MANCC] [char](20) NULL,
	[SL] [int] NULL,
	[DONGIA] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_NHAP_SP]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_NHAP_SP](
	[MANHAP] [char](20) NOT NULL,
	[MASP] [char](20) NOT NULL,
	[MANCC] [char](20) NOT NULL,
	[SL] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_CT_NHAP_SP] PRIMARY KEY CLUSTERED 
(
	[MANHAP] ASC,
	[MASP] ASC,
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATHANG]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATHANG](
	[MADAT] [char](20) NOT NULL,
	[MAKH] [char](20) NOT NULL,
	[SL] [int] NULL,
	[NGAYDAT] [char](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATHANG_SP]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATHANG_SP](
	[MADAT] [char](20) NOT NULL,
	[MASP] [char](20) NOT NULL,
	[SL] [int] NULL,
 CONSTRAINT [PK_DATHANG_SP] PRIMARY KEY CLUSTERED 
(
	[MADAT] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOITRA]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOITRA](
	[MADOITRA] [char](21) NOT NULL,
	[MAKH] [char](20) NOT NULL,
	[NGAYDOI] [char](21) NULL,
	[TENDOITRA] [nvarchar](51) NULL,
	[SPLay] [char](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOITRA_SP]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOITRA_SP](
	[MADOITRA] [char](21) NOT NULL,
	[MASP] [char](20) NOT NULL,
	[MALOIND] [char](21) NOT NULL,
	[MALOISX] [char](20) NOT NULL,
 CONSTRAINT [PK_DOITRA_SP] PRIMARY KEY CLUSTERED 
(
	[MADOITRA] ASC,
	[MASP] ASC,
	[MALOIND] ASC,
	[MALOISX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [int] IDENTITY(1,1) NOT NULL,
	[MANCC] [char](20) NOT NULL,
	[MALOAIHD] [char](20) NOT NULL,
	[NGAYLAP] [datetime] NULL,
	[MaTraGop] [char](20) NULL,
	[MaNV] [char](20) NULL,
	[ChenhLech] [char](20) NULL,
	[MaDoiTra] [char](21) NULL,
	[MaBaoHanh] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [char](20) NOT NULL,
	[TENKH] [nvarchar](50) NULL,
	[SDT] [char](11) NULL,
	[DIACHI] [char](51) NULL,
	[CMND] [char](13) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[MAKHO] [char](20) NOT NULL,
	[SL] [int] NULL,
	[MASP] [char](20) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[MALINHKIEN] [char](20) NOT NULL,
 CONSTRAINT [PK_KHO_1] PRIMARY KEY CLUSTERED 
(
	[MAKHO] ASC,
	[MASP] ASC,
	[MALINHKIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUYENMAI]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUYENMAI](
	[MAKHUYENMAI] [char](20) NOT NULL,
	[MASP] [char](20) NOT NULL,
	[MALINHKIEN] [char](20) NOT NULL,
	[TENKHUYENMAI] [nvarchar](50) NULL,
	[NGAYBD] [datetime] NULL,
	[NGAYKT] [datetime] NULL,
	[GIATRI] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LINHKIEN]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LINHKIEN](
	[MALINHKIEN] [char](20) NOT NULL,
	[TENLINHKIEN] [nvarchar](51) NULL,
	[DONGIA] [int] NULL,
	[MAKHO] [char](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHOADON]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHOADON](
	[MALOAIHD] [char](20) NOT NULL,
	[TENLOAIHD] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MALOAI] [char](20) NOT NULL,
	[TENLOAI] [nvarchar](51) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOIDONGUOIDUNG]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOIDONGUOIDUNG](
	[MALOIND] [char](21) NOT NULL,
	[TENLOIND] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOIDONHASX]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOIDONHASX](
	[MALOISX] [char](20) NOT NULL,
	[TENLOISX] [nvarchar](51) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MANHINH]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MANHINH](
	[MAMANHINH] [char](20) NOT NULL,
	[TENMANHINH] [nvarchar](51) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NDBaoHanh]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NDBaoHanh](
	[MANDBH] [int] NOT NULL,
	[TenNDBH] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_NDBaoHanh] PRIMARY KEY CLUSTERED 
(
	[MANDBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [char](20) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[DIACHI] [char](51) NULL,
	[SDT] [char](11) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [char](20) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [char](20) NULL,
	[DIACHI] [char](51) NULL,
	[SDT] [char](11) NULL,
	[GIOITINH] [char](4) NULL,
	[CMND] [char](13) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAPHANG]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPHANG](
	[MANHAP] [char](20) NOT NULL,
	[MANV] [char](20) NOT NULL,
	[NGAYNHAP] [char](20) NULL,
	[TrangThai] [nchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHOMNGUOIDUNG]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMNGUOIDUNG](
	[MANHOM] [char](20) NOT NULL,
	[TENNHOM] [nvarchar](50) NOT NULL,
	[GhiChu] [char](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MANHOM] [char](20) NOT NULL,
	[MAMANHINH] [char](20) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[MANHOM] ASC,
	[MAMANHINH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [char](20) NOT NULL,
	[MALOAI] [char](20) NOT NULL,
	[MAKHO] [char](20) NOT NULL,
	[TENSP] [nvarchar](51) NULL,
	[TINHTRANG] [char](4) NULL,
	[DonGia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SP_LOI]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SP_LOI](
	[MASP] [char](20) NOT NULL,
	[NGAYTHU] [nchar](10) NULL,
	[SOSERIES] [char](20) NOT NULL,
	[MALINHKIEN] [char](20) NOT NULL,
	[MADOITRA] [char](21) NOT NULL,
 CONSTRAINT [PK_SP_LOI] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC,
	[SOSERIES] ASC,
	[MALINHKIEN] ASC,
	[MADOITRA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TENDANGNHAP] [char](20) NOT NULL,
	[MANV] [char](20) NOT NULL,
	[MATKHAU] [char](31) NULL,
	[HOATDONG] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhTrangTT]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangTT](
	[MaHD] [int] NOT NULL,
	[TinhTrangThanhToan] [nchar](10) NULL,
	[NgayTT] [datetime] NOT NULL,
	[NgayTTTiepTheo] [datetime] NULL,
	[MANHAP] [char](20) NULL,
 CONSTRAINT [PK_TinhTrangTT] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[NgayTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tk_NND]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tk_NND](
	[TENDANGNHAP] [char](20) NOT NULL,
	[MANHOM] [char](20) NOT NULL,
 CONSTRAINT [PK_tk_NND] PRIMARY KEY CLUSTERED 
(
	[TENDANGNHAP] ASC,
	[MANHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraGop]    Script Date: 07/19/2020 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraGop](
	[MaTraGop] [char](20) NOT NULL,
	[SoTienPhaiTra] [int] NULL,
	[SoTienConLai] [int] NULL,
	[NgayTra] [date] NOT NULL,
	[deadline] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (1, N'KH01                ', CAST(N'2020-05-22T14:06:14.917' AS DateTime), NULL, N'1                    ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (2, N'KH01                ', CAST(N'2020-06-17T14:27:52.420' AS DateTime), NULL, N'1                    ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (3, N'KH01                ', CAST(N'2020-06-17T14:29:56.580' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (4, N'KH01                ', CAST(N'2020-06-17T14:49:36.740' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (5, N'KH01                ', CAST(N'2020-06-17T15:36:28.953' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (7, N'KH01                ', CAST(N'2020-06-27T10:53:11.680' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (8, N'KH01                ', CAST(N'2020-06-27T10:53:50.460' AS DateTime), NULL, N'1                    ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (9, N'KH01                ', CAST(N'2020-06-27T10:54:48.597' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (10, N'KH01                ', CAST(N'2020-06-27T10:56:04.657' AS DateTime), NULL, N'1                    ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (11, N'KH01                ', CAST(N'2020-06-27T10:56:59.027' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (12, N'KH01                ', CAST(N'2020-06-27T10:57:34.697' AS DateTime), NULL, N'1                    ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (13, N'KH01                ', CAST(N'2020-07-03T08:48:06.333' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (14, N'KH06                ', CAST(N'2020-07-05T12:11:22.640' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (15, N'KH06                ', CAST(N'2020-07-05T12:14:00.303' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (16, N'KH07                ', CAST(N'2020-07-05T12:15:42.917' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (17, N'KH06                ', CAST(N'2020-07-05T12:19:24.683' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (18, N'KH04                ', CAST(N'2020-07-05T12:23:01.040' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (19, N'KH02                ', CAST(N'2020-07-05T12:23:01.040' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (20, N'KH02                ', CAST(N'2020-07-05T12:25:03.073' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (21, N'KH05                ', CAST(N'2020-07-05T12:25:55.463' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (22, N'KH06                ', CAST(N'2020-07-05T12:28:45.987' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (23, N'KH01                ', CAST(N'2020-07-05T12:29:19.363' AS DateTime), NULL, N'1                    ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (24, N'KH06                ', CAST(N'2020-07-05T12:37:31.157' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (25, N'KH06                ', CAST(N'2020-07-05T12:37:31.157' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (26, N'KH03                ', CAST(N'2020-07-05T12:41:04.350' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (27, N'KH04                ', CAST(N'2020-07-05T12:41:04.350' AS DateTime), NULL, N'khong                ')
INSERT [dbo].[BAOHANH] ([MABAOHANH], [MAKH], [NGAYBAOHANH], [NGAYBAOHANHXONG], [MALOIND]) VALUES (6, N'KH01                ', CAST(N'2020-06-17T21:49:10.303' AS DateTime), NULL, N'1                    ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (1, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (1, 1, N'TEMP                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (1, 2, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (2, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (3, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (4, 2, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (5, 2, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (6, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (13, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (14, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (15, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (16, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (17, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (18, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (19, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (20, 2, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (21, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (22, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (23, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (24, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (25, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (26, 1, N'LK01                ')
INSERT [dbo].[ct_bH] ([MABAOHANH], [MANDBH], [MALK]) VALUES (27, 1, N'LK01                ')
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK01                ', 213, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK01                ', 214, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK01                ', 215, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK01                ', 216, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK01                ', 217, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK01                ', 218, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK02                ', 213, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK02                ', 215, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK02                ', 216, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK03                ', 215, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK03                ', 216, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK03                ', 217, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK03                ', 218, 1)
INSERT [dbo].[CT_HOADON_LINHKIEN] ([MALINHKIEN], [MAHD], [SL]) VALUES (N'LK03                ', 271, 1)
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (14, N'KH01                ', N'SP01      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (19, N'KH01                ', N'SP01      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (20, N'KH01                ', N'SP01      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (21, N'KH04                ', N'SP01      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (22, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (23, N'KH01                ', N'SP02      ', N'10        ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (24, N'KH01                ', N'SP01      ', N'6         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (25, N'KH01                ', N'SP01      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (26, N'KH01                ', N'SP01      ', N'2         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (27, N'KH01                ', N'SP01      ', N'2         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (28, N'KH01                ', N'SP01      ', N'2         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (29, N'KH01                ', N'SP01      ', N'3         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (30, N'KH01                ', N'SP01      ', N'2         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (42, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (43, N'KH05                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (44, N'KH05                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (45, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (46, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (47, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (48, N'KH01                ', N'sp01      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (49, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (50, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (51, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (51, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (52, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (52, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (53, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (60, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (62, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (63, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (63, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (64, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (66, N'KH01                ', N'SP04      ', N'3         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (67, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (68, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (70, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (71, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (72, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (74, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (76, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (78, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (80, N'KH01                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (82, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (82, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (84, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (86, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (87, N'KH03                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (88, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (90, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (92, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (92, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (93, N'KH01                ', N'SP03      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (93, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (94, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (95, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (96, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (97, N'KH01                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (98, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (98, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (99, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (100, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (101, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (102, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (103, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (104, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (105, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (134, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (135, N'KH01                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (136, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (137, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (137, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (139, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (140, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (141, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (146, N'KH01                ', N'SP03      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (146, N'KH01                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (147, N'KH04                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (148, N'KH04                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (148, N'KH04                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (149, N'KH01                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (150, N'KH01                ', N'SP9       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (151, N'KH01                ', N'SP9       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (156, N'KH06                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (161, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (164, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (165, N'KH05                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (166, N'KH05                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (167, N'KH06                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (168, N'KH04                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (169, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (170, N'KH03                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (171, N'KH02                ', N'SP02      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (172, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (173, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (174, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (175, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (176, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (177, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (178, N'KH01                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (178, N'KH01                ', N'SP5       ', N'1         ')
GO
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (179, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (179, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (180, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (180, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (181, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (181, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (182, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (182, N'KH01                ', N'SP6       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (191, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (206, N'KH01                ', N'SP01      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (206, N'KH01                ', N'SP10      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (207, N'KH01                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (208, N'KH01                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (209, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (210, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (211, N'KH01                ', N'SP03      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (212, N'KH01                ', N'SP03      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (219, N'KH04                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (220, N'KH03                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (220, N'KH03                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (221, N'KH03                ', N'SP03      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (221, N'KH03                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (222, N'KH02                ', N'SP03      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (222, N'KH02                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (223, N'KH06                ', N'SP03      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (223, N'KH06                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (224, N'KH03                ', N'SP03      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (224, N'KH03                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (225, N'KH02                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (226, N'KH02                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (227, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (228, N'KH04                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (229, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (237, N'KH01                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (237, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (248, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (249, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (250, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (251, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (252, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (253, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (254, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (255, N'KH01                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (256, N'KH04                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (270, N'KH07                ', N'SP5       ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (272, N'KH07                ', N'SP04      ', N'1         ')
INSERT [dbo].[Ct_mua_SP] ([MaHD], [MaKH], [MaSP], [SL]) VALUES (272, N'KH07                ', N'SP5       ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (213, N'KH01                ', N'SP5       ', N'LK01                ', N'2         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (214, N'KH01                ', N'SP5       ', N'LK01                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (289, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (290, N'KH06                ', N'khong     ', N'LK01                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (290, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (291, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (291, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (292, N'KH06                ', N'SP5       ', N'                    ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (293, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (294, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (295, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (295, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (296, N'KH06                ', N'khong     ', N'LK02                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (297, N'KH06                ', N'khong     ', N'LK01                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (298, N'KH06                ', N'khong     ', N'LK02                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (299, N'KH06                ', N'khong     ', N'LK02                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (299, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (300, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (300, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (301, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (301, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (302, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (302, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (303, N'KH03                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (303, N'KH03                ', N'SP5       ', N'TEMP                ', N'2         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (304, N'KH03                ', N'SP5       ', N'TEMP                ', N'2         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (305, N'KH03                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (306, N'KH03                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (306, N'KH03                ', N'SP04      ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (307, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (308, N'KH04                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (309, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (309, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (310, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (310, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (311, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (311, N'KH06                ', N'TEMP      ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (312, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (312, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (313, N'KH05                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (313, N'KH05                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (314, N'KH06                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (314, N'KH06                ', N'SP03      ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (314, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (328, N'KH01                ', N'khong     ', N'LK03                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (328, N'KH01                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (329, N'KH01                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (341, N'KH07                ', N'khong     ', N'LK02                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (341, N'KH07                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[ct_mua_sp_lk] ([MaHD], [MaKH], [MaSP], [MALINHKIEN], [SL]) VALUES (342, N'KH06                ', N'SP5       ', N'TEMP                ', N'1         ')
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK01                ', N'PN35                ', N'NCC001              ', 2, 2000000)
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK03                ', N'PN38                ', N'NCC001              ', 1, 200000)
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK01                ', N'PN55                ', N'NCC001              ', 10, 100000)
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK02                ', N'PN55                ', N'NCC001              ', 10, 100000)
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK02                ', N'PN56                ', N'NCC001              ', 20, 100000)
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK01                ', N'PN005               ', N'NCC001              ', 10, 100000)
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK01                ', N'PN57                ', N'NCC001              ', 5, 100000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN001               ', N'SP5                 ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN005               ', N'SP02                ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN005               ', N'SP03                ', N'NCC001              ', 1, 1)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN005               ', N'SP5                 ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN007               ', N'SP5                 ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN14                ', N'SP04                ', N'NCC001              ', 20, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN14                ', N'SP5                 ', N'NCC001              ', 20, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN15                ', N'SP5                 ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN16                ', N'SP02                ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN16                ', N'SP04                ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN16                ', N'SP5                 ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN16                ', N'SP6                 ', N'NCC001              ', 5, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN17                ', N'SP5                 ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN18                ', N'SP5                 ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN19                ', N'SP5                 ', N'NCC001              ', 2, 3)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN20                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN21                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN22                ', N'SP5                 ', N'NCC001              ', 2, 2000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN23                ', N'SP5                 ', N'NCC001              ', 2, 2000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN25                ', N'SP5                 ', N'NCC001              ', 2, 4000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN26                ', N'SP5                 ', N'NCC001              ', 2, 3000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN27                ', N'SP5                 ', N'NCC001              ', 2, 3000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN28                ', N'SP5                 ', N'NCC001              ', 2, 20000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN30                ', N'SP6                 ', N'NCC001              ', 10, 12000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN31                ', N'SP5                 ', N'NCC001              ', 2, 30000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN32                ', N'SP5                 ', N'NCC001              ', 10, 15000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN33                ', N'SP5                 ', N'NCC001              ', 5, 15000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN34                ', N'SP5                 ', N'NCC001              ', 2, 3000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN39                ', N'SP5                 ', N'NCC001              ', 100, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN40                ', N'SP5                 ', N'NCC001              ', 100, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN41                ', N'SP5                 ', N'NCC001              ', 100, 12000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN42                ', N'SP5                 ', N'NCC001              ', 6, 12000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN43                ', N'SP5                 ', N'NCC001              ', 50, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN44                ', N'SP5                 ', N'NCC001              ', 10, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN45                ', N'SP02                ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN45                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN46                ', N'SP03                ', N'NCC001              ', 200, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN46                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN47                ', N'SP02                ', N'NCC001              ', 10, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN47                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN48                ', N'SP03                ', N'NCC001              ', 2, 1000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN48                ', N'SP5                 ', N'NCC001              ', 2, 1000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN49                ', N'SP5                 ', N'NCC001              ', 2, 13000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN50                ', N'SP04                ', N'NCC001              ', 3, 9000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN50                ', N'SP5                 ', N'NCC001              ', 3, 9000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN51                ', N'SP03                ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN51                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN52                ', N'SP02                ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN52                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN53                ', N'SP02                ', N'NCC001              ', 2, 8000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN53                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN54                ', N'SP5                 ', N'NCC001              ', 2, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN57                ', N'SP02                ', N'NCC001              ', 10, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN57                ', N'SP5                 ', N'NCC001              ', 10, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN58                ', N'SP02                ', N'NCC001              ', 10, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN58                ', N'SP5                 ', N'NCC001              ', 10, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN59                ', N'SP02                ', N'NCC001              ', 10, 10000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN59                ', N'SP5                 ', N'NCC001              ', 10, 10000000)
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'1                    ', N'KH01                ', N'06/05/2020           ', N'Ð?i máy khác', NULL)
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'2                    ', N'KH01                ', N'07/05/2020           ', N'Ð?i máy khác', NULL)
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'3                    ', N'KH01                ', N'07/22/2020           ', N'doi may khac', NULL)
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'4                    ', N'KH05                ', N'07-05-2020           ', N'Đổi máy', N'                    ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'12                   ', N'KH05                ', N'07-05-2020           ', N'Đổi máy', N'SP9                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'13                   ', N'KH05                ', N'07-05-2020           ', N'Đổi máy', N'                    ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'5                    ', N'KH01                ', N'07-05-2020           ', N'Đổi máy', N'                    ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'6                    ', N'KH01                ', N'07-05-2020           ', N'Đổi máy', N'                    ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'7                    ', N'KH01                ', N'07-05-2020           ', N'Đổi máy', N'SP01                ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'8                    ', N'KH01                ', N'07-05-2020           ', N'Đổi máy', N'                    ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'9                    ', N'KH03                ', N'07-05-2020           ', N'Đổi máy', N'SP01                ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'10                   ', N'KH01                ', N'07-05-2020           ', N'Đổi máy', N'                    ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'11                   ', N'KH01                ', N'07-05-2020           ', N'Đổi máy', N'SP9                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'14                   ', N'KH01                ', N'01-06-2020           ', N'Đổi máy', N'SP6                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'15                   ', N'KH01                ', N'01-06-2020           ', N'Đổi máy', N'SP6                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'16                   ', N'KH01                ', N'01-06-2020           ', N'Đổi máy', N'SP6                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'17                   ', N'KH01                ', N'01-06-2020           ', N'Đổi máy', N'SP6                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'18                   ', N'KH01                ', N'01-06-2020           ', N'Đổi máy', N'SP6                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'19                   ', N'KH01                ', N'01-06-2020           ', N'Đổi máy', N'SP6                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'20                   ', N'KH01                ', N'26-06-2020           ', N'Đổi máy', N'SP5                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'21                   ', N'KH01                ', N'26-06-2020           ', N'Đổi máy', N'SP9                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'22                   ', N'KH01                ', N'26-06-2020           ', N'Đổi máy', N'SP5                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'23                   ', N'KH01                ', N'26-06-2020           ', N'Đổi máy', N'SP9                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'24                   ', N'KH01                ', N'26-06-2020           ', N'Đổi máy', N'SP03                ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'25                   ', N'KH01                ', N'27-06-2020           ', N'Đổi máy', N'SP02                ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'26                   ', N'KH01                ', N'27-06-2020           ', N'Đổi máy', N'SP9                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'27                   ', N'KH01                ', N'02-07-2020           ', N'Đổi máy', N'SP03                ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'28                   ', N'KH01                ', N'02-07-2020           ', N'Đổi máy', N'SP02                ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'29                   ', N'KH01                ', N'02-07-2020           ', N'Đổi máy', N'SP5                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'30                   ', N'KH01                ', N'02-07-2020           ', N'Đổi máy', N'SP5                 ')
INSERT [dbo].[DOITRA] ([MADOITRA], [MAKH], [NGAYDOI], [TENDOITRA], [SPLay]) VALUES (N'31                   ', N'KH01                ', N'02-07-2020           ', N'Đổi máy', N'SP10                ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'1                    ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'10                   ', N'SP6                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'10                   ', N'SP6                 ', N'khong                ', N'2                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'11                   ', N'SP6                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'11                   ', N'SP6                 ', N'khong                ', N'2                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'12                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'12                   ', N'SP5                 ', N'khong                ', N'2                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'13                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'14                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'15                   ', N'SP01                ', N'khong                ', N'2                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'16                   ', N'SP01                ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'17                   ', N'SP5                 ', N'khong                ', N'2                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'18                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'19                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'19                   ', N'SP5                 ', N'khong                ', N'khong               ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'20                   ', N'SP02                ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'20                   ', N'SP02                ', N'khong                ', N'2                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'21                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'22                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'23                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'24                   ', N'SP6                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'25                   ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'26                   ', N'SP02                ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'27                   ', N'SP9                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'28                   ', N'SP04                ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'29                   ', N'SP5                 ', N'khong                ', N'2                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'30                   ', N'SP02                ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'31                   ', N'SP02                ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'6                    ', N'SP04                ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'6                    ', N'SP6                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'7                    ', N'SP5                 ', N'khong                ', N'1                   ')
INSERT [dbo].[DOITRA_SP] ([MADOITRA], [MASP], [MALOIND], [MALOISX]) VALUES (N'9                    ', N'SP5                 ', N'khong                ', N'1                   ')
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (10, N'NCC001              ', N'MLHD01              ', CAST(N'2019-11-23T20:06:20.000' AS DateTime), NULL, N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (14, N'NCC001              ', N'MLHD01              ', CAST(N'2019-11-23T00:00:00.000' AS DateTime), NULL, N'NV01                ', NULL, NULL, 6)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (13, N'NCC001              ', N'MLHD01              ', CAST(N'2019-11-23T00:00:00.000' AS DateTime), NULL, N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (19, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'10                  ', N'3                    ', 9)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (20, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'12600000            ', N'15                   ', 6)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (23, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'                    ', N'20                   ', 13)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (24, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'12600000            ', N'16                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (25, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, 11)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (26, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, 23)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (27, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, 12)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (28, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (29, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (30, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (32, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (33, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (34, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (35, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (36, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (37, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (38, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (39, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (41, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (42, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (43, N'temp                ', N'MLHD02              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-5000000            ', N'9                    ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (44, N'temp                ', N'MLHD02              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'8000000             ', N'12                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (45, N'temp                ', N'MLHD02              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (46, N'temp                ', N'MLHD02              ', CAST(N'2020-04-22T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (47, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'7000000             ', N'17                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (48, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (49, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'7000000             ', N'14                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (50, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-5000000            ', N'7                    ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (51, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'2000000             ', N'22                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (52, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'8999960             ', N'31                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (53, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (55, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (56, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'2                   ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (57, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (58, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (59, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (60, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (71, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (72, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (73, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (74, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'6                   ', N'NV01                ', N'4000000             ', N'26                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (75, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (76, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'7                   ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (77, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (81, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (82, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'10                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (85, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (86, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'12                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (87, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (88, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'7000000             ', N'17                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (89, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (90, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'13                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (91, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (92, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (93, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'14                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (94, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (95, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'15                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (21, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (22, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'9999960             ', N'30                   ', 4)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (31, N'temp                ', N'MLHD02              ', CAST(N'2020-04-20T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (61, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (62, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'3                   ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (63, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'8000000             ', N'23                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (64, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-11999950           ', N'24                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (65, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (66, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'4                   ', N'NV01                ', N'8000000             ', N'11                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (67, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (68, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (69, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (70, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'5                   ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (78, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'8                   ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (79, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (80, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'9                   ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (83, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (84, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'11                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (101, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'18                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (102, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'19                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (106, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (107, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (108, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (109, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (110, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (113, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (132, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-27T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (133, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-27T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (134, N'temp                ', N'MLHD02              ', CAST(N'2020-04-29T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (135, N'temp                ', N'MLHD02              ', CAST(N'2020-04-29T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (136, N'temp                ', N'MLHD02              ', CAST(N'2020-04-29T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-7999950            ', N'27                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (137, N'temp                ', N'MLHD02              ', CAST(N'2020-04-29T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (138, N'temp                ', N'MLHD02              ', CAST(N'2020-04-29T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (139, N'temp                ', N'MLHD02              ', CAST(N'2020-04-29T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (140, N'temp                ', N'MLHD02              ', CAST(N'2020-04-29T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (141, N'temp                ', N'MLHD02              ', CAST(N'2020-04-29T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (142, N'NCC001              ', N'MLHD01              ', CAST(N'2020-05-03T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (143, N'NCC001              ', N'MLHD01              ', CAST(N'2020-05-03T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (144, N'NCC001              ', N'MLHD01              ', CAST(N'2020-05-03T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
GO
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (145, N'NCC001              ', N'MLHD01              ', CAST(N'2020-05-03T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (146, N'temp                ', N'MLHD02              ', CAST(N'2020-05-05T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (147, N'temp                ', N'MLHD02              ', CAST(N'2020-05-05T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (148, N'temp                ', N'MLHD02              ', CAST(N'2020-05-05T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (149, N'temp                ', N'MLHD02              ', CAST(N'2020-05-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-7999950            ', N'28                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (150, N'temp                ', N'MLHD02              ', CAST(N'2020-05-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'2200000             ', N'27                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (151, N'temp                ', N'MLHD02              ', CAST(N'2020-05-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (96, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'7000000             ', N'14                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (97, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (98, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'16                  ', N'NV01                ', N'8000000             ', N'23                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (99, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'7000000             ', N'18                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (100, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'17                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (103, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'22                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (104, N'temp                ', N'MLHD02              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (105, N'temp                ', N'MLHD04              ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), N'24                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (114, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (115, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (116, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (117, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (118, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (120, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (121, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (122, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (123, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (124, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (125, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (126, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (127, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (128, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (129, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (130, N'NCC001              ', N'MLHD01              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (131, N'NCC001              ', N'MLHD03              ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (152, N'NCC001              ', N'MLHD01              ', CAST(N'2020-05-18T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (153, N'NCC001              ', N'MLHD01              ', CAST(N'2020-05-18T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (154, N'NCC001              ', N'MLHD01              ', CAST(N'2020-05-18T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (155, N'NCC001              ', N'MLHD03              ', CAST(N'2020-05-18T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (156, N'temp                ', N'MLHD02              ', CAST(N'2020-05-18T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, 17)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (158, N'NCC001              ', N'MLHD01              ', CAST(N'2020-05-19T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (159, N'NCC001              ', N'MLHD03              ', CAST(N'2020-05-19T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (160, N'NCC001              ', N'MLHD03              ', CAST(N'2020-05-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (161, N'temp                ', N'MLHD02              ', CAST(N'2020-06-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'7000000             ', N'19                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (162, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-01T00:00:00.000' AS DateTime), N'temp                ', N'admin               ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (163, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (164, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'8000000             ', N'21                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (165, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (166, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (167, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (169, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (170, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (171, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, 19)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (172, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (173, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'2000000             ', N'29                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (175, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (176, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (177, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (178, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (179, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (180, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (181, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (182, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (168, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (174, N'temp                ', N'MLHD02              ', CAST(N'2020-06-06T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (184, N'khong               ', N'MLHD05              ', CAST(N'2020-06-17T14:29:56.580' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 3)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (186, N'khong               ', N'MLHD05              ', CAST(N'2020-06-17T15:36:28.953' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 5)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (185, N'khong               ', N'MLHD05              ', CAST(N'2020-06-17T14:49:36.740' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 4)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (187, N'khong               ', N'MLHD05              ', CAST(N'2020-06-17T21:46:32.647' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 6)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (188, N'khong               ', N'MLHD05              ', CAST(N'2020-06-17T21:47:26.460' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 6)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (191, N'temp                ', N'MLHD02              ', CAST(N'2020-06-17T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (192, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (193, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (194, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (195, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (213, N'temp                ', N'MLHD02              ', CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (214, N'temp                ', N'MLHD02              ', CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (215, N'temp                ', N'MLHD02              ', CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (216, N'temp                ', N'MLHD02              ', CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (217, N'temp                ', N'MLHD02              ', CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (218, N'temp                ', N'MLHD02              ', CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (219, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, 27)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (220, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (221, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (222, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, 20)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (223, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, 25)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (224, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (225, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (226, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (227, N'temp                ', N'MLHD02              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (228, N'temp                ', N'MLHD04              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'38                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (229, N'temp                ', N'MLHD04              ', CAST(N'2020-06-26T00:00:00.000' AS DateTime), N'39                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (230, N'khong               ', N'MLHD05              ', CAST(N'2020-06-27T10:53:11.680' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 7)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (231, N'khong               ', N'MLHD05              ', CAST(N'2020-06-27T10:53:50.460' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 8)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (232, N'khong               ', N'MLHD05              ', CAST(N'2020-06-27T10:54:48.597' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 9)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (233, N'khong               ', N'MLHD05              ', CAST(N'2020-06-27T10:56:04.657' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 10)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (234, N'khong               ', N'MLHD05              ', CAST(N'2020-06-27T10:56:59.027' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 11)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (235, N'khong               ', N'MLHD05              ', CAST(N'2020-06-27T10:57:34.697' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 12)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (236, N'temp                ', N'MLHD06              ', CAST(N'2020-06-27T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'2999960             ', N'26                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (237, N'temp                ', N'MLHD02              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (238, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (240, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (244, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
GO
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (245, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (248, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (249, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (250, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (251, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (252, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (253, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-7999950            ', N'25                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (254, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (255, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (256, N'temp                ', N'MLHD02              ', CAST(N'2020-07-01T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (257, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'2200000             ', N'27                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (258, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-7999950            ', N'28                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (259, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-7999950            ', N'25                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (189, N'khong               ', N'MLHD05              ', CAST(N'2020-06-17T21:48:38.647' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 6)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (190, N'khong               ', N'MLHD05              ', CAST(N'2020-06-17T21:49:10.303' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 6)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (239, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (260, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-7999950            ', N'27                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (261, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'8000000             ', N'21                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (262, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'-5000000            ', N'7                    ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (263, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'4000000             ', N'26                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (264, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'8000000             ', N'21                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (265, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'2000000             ', N'22                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (266, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'2000000             ', N'29                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (267, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'9999960             ', N'30                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (268, N'temp                ', N'MLHD06              ', CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', N'8999960             ', N'31                   ', NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (269, N'khong               ', N'MLHD05              ', CAST(N'2020-07-03T08:48:06.333' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 13)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (270, N'temp                ', N'MLHD02              ', CAST(N'2020-07-03T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (271, N'temp                ', N'MLHD02              ', CAST(N'2020-07-03T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (272, N'temp                ', N'MLHD04              ', CAST(N'2020-07-03T00:00:00.000' AS DateTime), N'42                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (273, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-04T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (274, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-04T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (275, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:11:22.640' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 14)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (276, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:14:00.303' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 15)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (277, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:15:42.917' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 16)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (278, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:19:24.683' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 17)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (279, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:23:01.040' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 18)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (280, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:23:01.040' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 19)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (281, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:25:03.073' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 20)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (282, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:25:55.463' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 21)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (283, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:28:45.987' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 22)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (284, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:29:19.363' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 23)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (285, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:37:31.157' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 24)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (286, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:37:31.157' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 25)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (287, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:41:04.350' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 26)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (288, N'khong               ', N'MLHD05              ', CAST(N'2020-07-05T12:41:04.350' AS DateTime), N'                    ', N'NV01                ', N'                    ', N'                     ', 27)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (289, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (290, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (291, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (292, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (293, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (294, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (295, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (296, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (297, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (298, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (299, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (300, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (301, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (302, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (303, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (304, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (307, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (308, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV04                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (309, N'temp                ', N'MLHD04              ', CAST(N'2020-07-08T00:00:00.000' AS DateTime), N'49                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (310, N'temp                ', N'MLHD04              ', CAST(N'2020-07-08T00:00:00.000' AS DateTime), N'50                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (311, N'temp                ', N'MLHD04              ', CAST(N'2020-07-08T00:00:00.000' AS DateTime), N'51                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (196, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (197, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (198, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (200, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (201, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (202, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (203, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (204, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (205, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (206, N'temp                ', N'MLHD02              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (207, N'temp                ', N'MLHD02              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (208, N'temp                ', N'MLHD02              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (209, N'temp                ', N'MLHD02              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (210, N'temp                ', N'MLHD02              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (211, N'temp                ', N'MLHD02              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (212, N'temp                ', N'MLHD02              ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (305, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (306, N'temp                ', N'MLHD02              ', CAST(N'2020-07-07T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (312, N'temp                ', N'MLHD04              ', CAST(N'2020-07-08T00:00:00.000' AS DateTime), N'52                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (313, N'temp                ', N'MLHD04              ', CAST(N'2020-07-08T00:00:00.000' AS DateTime), N'53                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (314, N'temp                ', N'MLHD04              ', CAST(N'2020-07-08T00:00:00.000' AS DateTime), N'56                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (315, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (316, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (317, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (318, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (319, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (320, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (321, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (322, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (323, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (324, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (325, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (326, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (327, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-11T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
GO
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (328, N'temp                ', N'MLHD02              ', CAST(N'2020-07-12T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (329, N'temp                ', N'MLHD04              ', CAST(N'2020-07-12T00:00:00.000' AS DateTime), N'58                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (330, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-13T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (331, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-13T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (332, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-13T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (333, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-13T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (334, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-13T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (336, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (337, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (339, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (340, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (341, N'temp                ', N'MLHD04              ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), N'59                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (342, N'temp                ', N'MLHD04              ', CAST(N'2020-07-19T00:00:00.000' AS DateTime), N'61                  ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (242, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (243, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (335, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-13T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (338, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (246, N'NCC001              ', N'MLHD01              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (247, N'NCC001              ', N'MLHD03              ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'khong               ', N'tempHoaDonNhap                                    ', N'khong      ', N'khong                                              ', N'khong        ')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH01                ', N'Lý Thiện Thanh', N'0397299292 ', N'TPHCM                                              ', N'3432117      ')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH02                ', N'Phạm Tấn Dũng', N'0123456789 ', N'TPHCM                                              ', N'3298115      ')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH03                ', N'Nguyễn Văn A', N'0979829117 ', N'TN                                                 ', N'1173432      ')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH04                ', N'Nguyễn Thị Thu Hằng', N'0358694856 ', N'HN                                                 ', N'291175665    ')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH05                ', N'Pham Tan Dung', N'0353497478 ', N'HCM                                                ', N'362504076    ')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH06                ', N'Pham Tan Dung', N'0123456    ', N'HCM                                                ', N'362504076    ')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH07                ', N'Nguyễn Hải Yến', N'021548521  ', N'HCM                                                ', N'362504076    ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', -135, N'SP01                ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', -99, N'SP02                ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 273, N'SP03                ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 70, N'SP04                ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', -127, N'SP10                ', N'tphcm', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', -129, N'SP11                ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP14                ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 66, N'SP5                 ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', -131, N'SP6                 ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 110, N'TEMP                ', N'TPHCM', 397299292, N'LK01                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 124, N'TEMP                ', N'TPHCM', 397299292, N'LK02                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO12               ', 0, N'SP5                 ', N'HN', 1584451114, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO13               ', 0, N'SP5                 ', N'QN', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO14               ', 0, N'SP5                 ', N'QN', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO2                ', 62, N'SP01                ', N'HN', 175248263, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO2                ', 0, N'SP14                ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO2                ', 111, N'SP5                 ', N'TPHCM', 397299292, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO6                ', 0, N'SP5                 ', N'LA', 123456789, N'TEMP                ')
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM1                 ', N'SP5                 ', N'TEMP                ', N'KHUYEN MAI 500', CAST(N'2020-12-04T00:00:00.000' AS DateTime), CAST(N'2020-12-05T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM2                 ', N'SP5                 ', N'TEMP                ', N'50', CAST(N'2020-04-28T00:00:00.000' AS DateTime), CAST(N'2020-04-30T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM3                 ', N'SP5                 ', N'LK03                ', N'TANG KEM PK', CAST(N'2020-04-28T00:00:00.000' AS DateTime), CAST(N'2020-04-30T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM4                 ', N'SP5                 ', N'TEMP                ', N'50', CAST(N'2020-04-28T00:00:00.000' AS DateTime), CAST(N'2020-04-30T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM05                ', N'SP5                 ', N'TEMP                ', N'KHUYEN MAI 500', CAST(N'2020-12-04T00:00:00.000' AS DateTime), CAST(N'2020-12-05T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM06                ', N'SP5                 ', N'TEMP                ', N'KHUYEN MAI 500', CAST(N'2020-06-01T00:00:00.000' AS DateTime), CAST(N'2020-06-30T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM07                ', N'SP5                 ', N'TEMP                ', N'KHUYEN MAI 500', CAST(N'2020-06-01T00:00:00.000' AS DateTime), CAST(N'2020-06-30T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM08                ', N'TEMP                ', N'LK03                ', N'KHUYEN MAI 500', CAST(N'2020-06-01T00:00:00.000' AS DateTime), CAST(N'2020-06-30T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM09                ', N'SP02                ', N'TEMP                ', N'KHUYEN MAI 50', CAST(N'2020-12-04T00:00:00.000' AS DateTime), CAST(N'2020-12-05T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM09                ', N'SP5                 ', N'TEMP                ', N'KHUYEN MAI 500', CAST(N'2020-12-04T00:00:00.000' AS DateTime), CAST(N'2020-12-05T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM10                ', N'SP02                ', N'TEMP                ', N'KHUYEN MAI 50', CAST(N'2020-06-27T00:00:00.000' AS DateTime), CAST(N'2020-06-30T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM10                ', N'SP5                 ', N'TEMP                ', N'KHUYEN MAI 50', CAST(N'2020-06-27T00:00:00.000' AS DateTime), CAST(N'2020-06-30T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM10                ', N'SP04                ', N'TEMP                ', N'KHUYEN MAI 50', CAST(N'2020-06-27T00:00:00.000' AS DateTime), CAST(N'2020-06-30T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM11                ', N'SP5                 ', N'TEMP                ', N'50', CAST(N'2020-07-01T00:00:00.000' AS DateTime), CAST(N'2020-07-02T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM12                ', N'SP03                ', N'temp                ', N'20', CAST(N'2020-07-04T00:00:00.000' AS DateTime), CAST(N'2020-07-31T00:00:00.000' AS DateTime), 20)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM13                ', N'SP5                 ', N'temp                ', N'50', CAST(N'2020-07-02T00:00:00.000' AS DateTime), CAST(N'2020-07-31T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM14                ', N'SP5                 ', N'LK01                ', N'50', CAST(N'2020-07-04T00:00:00.000' AS DateTime), CAST(N'2020-07-31T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM14                ', N'SP04                ', N'LK01                ', N'50', CAST(N'2020-07-04T00:00:00.000' AS DateTime), CAST(N'2020-07-31T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[KHUYENMAI] ([MAKHUYENMAI], [MASP], [MALINHKIEN], [TENKHUYENMAI], [NGAYBD], [NGAYKT], [GIATRI]) VALUES (N'KM09                ', N'SP03                ', N'TEMP                ', N'KHUYEN MAI 500', CAST(N'2020-12-04T00:00:00.000' AS DateTime), CAST(N'2020-12-05T00:00:00.000' AS DateTime), 50)
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK01                ', N'Man Hinh j7 prime                                  ', 200000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK02                ', N'headphone ipod', 1300000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK03                ', N'headphone sony', 200000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'TEMP                ', N'TEMP', 0, N'KHO1                ')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD01              ', N'HDNCC               ')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD02              ', N'Bán Hàng')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD04              ', N'Bán Hàng Trả góp')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD03              ', N'CH tra gop cho ncc')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD05              ', N'Bảo hành')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD06              ', N'đổi trả')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAI]) VALUES (N'LSP01               ', N'DT SamSung                                         ')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAI]) VALUES (N'LSP07               ', N'DT Sony                                            ')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAI]) VALUES (N'L3                  ', N'rog                                    ')
INSERT [dbo].[LOIDONGUOIDUNG] ([MALOIND], [TENLOIND]) VALUES (N'khong                ', N'khong')
INSERT [dbo].[LOIDONGUOIDUNG] ([MALOIND], [TENLOIND]) VALUES (N'1                    ', N'hỏng màn hình')
INSERT [dbo].[LOIDONHASX] ([MALOISX], [TENLOISX]) VALUES (N'1                   ', N'Lỗi màn hinh')
INSERT [dbo].[LOIDONHASX] ([MALOISX], [TENLOISX]) VALUES (N'2                   ', N'loi cam ung')
INSERT [dbo].[LOIDONHASX] ([MALOISX], [TENLOISX]) VALUES (N'khong               ', N'khong')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000001', N'NguoiDung                                          ')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000002', N'NhomNguoiDung                                      ')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000003', N'PhanQuyen                                          ')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000004', N'NhapHang                                           ')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000023', N'quan ly khach hang')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000005', N'San Pham')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000006', N'Nha cung cap')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000007', N'linh kien')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000008', N'nhap hang')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000009', N'nhap linh kien')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000010', N'ban hang')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000020', N'bao hanh')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000021', N'loi sx')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000022', N'loi nd')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000018', N'km san pham')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000019', N'km linh kien')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000012', N'tinh doanh thu')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000013', N'tra gop')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000011', N'thong ke san pham')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000014', N'san pham khuyen mai')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000015', N'tim kiem khach hang')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000016', N'tim kiem san pham')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000017', N'tim kiem san pham khuyen mai')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000024', N'tạo phiểu nhập sản phẩm')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000025', N'lưu sản phẩm vào kho')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000026', N'lưu linh kiện vào kho')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000027', N'thanh toán trả góp')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000028', N'Bảo hành')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000029', N'ban linh kien')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000030', N'trả góp nhà cung cấp')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000031', N'thống kê top 5 và top 10')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000032', N'thống kê theo loại sp')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000033', N'thống kê sl trong kho')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000034', N'thong ke loi nhuan')
INSERT [dbo].[NDBaoHanh] ([MANDBH], [TenNDBH], [DonGia]) VALUES (1, N'Vệ Sinh', 50000)
INSERT [dbo].[NDBaoHanh] ([MANDBH], [TenNDBH], [DonGia]) VALUES (2, N'Thay Linh Kiện', 0)
INSERT [dbo].[NDBaoHanh] ([MANDBH], [TenNDBH], [DonGia]) VALUES (3, N'Sữa Chữa', 50000)
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC001              ', N'Sony', N'TPHCM                                              ', N'0123456789 ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'temp                ', N'khong', N'khong                                              ', N'khong      ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC002              ', N'xxx', N'TPHCM                                              ', N'0123456789 ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'khong               ', N'khong', N'khong                                              ', N'khong      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV01                ', N'admin                          ', N'01/01/2000          ', N'TN                                                 ', N'0397299292 ', N'Nam ', N'3497117      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV02                ', N'THái', N'01/01/2000          ', N'HCM                                                ', N'0123456789 ', N'N?  ', N'0322131      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV03                ', N'123', N'01/01/2000          ', N'HCM                                                ', N'0123456789 ', N'Nam ', N'0322131      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV04                ', N'Lý Thiên Thanh', N'01/01/2000          ', N'HN                                                 ', N'0156132155 ', N'Nam ', N'0231565      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV05                ', N'YEN', N'01/01/2000          ', N'NA                                                 ', N'0124514511 ', N'N?  ', N'0235151      ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN005               ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN006               ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN007               ', N'NV01                ', N'11/23/2019          ', N'50%                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN001               ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN003               ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN0011              ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN008               ', N'NV01                ', N'11/28/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN009               ', N'NV01                ', N'11/28/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN0010              ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN0013              ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN0012              ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN0014              ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN0015              ', N'NV01                ', N'11/23/2019          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN14                ', N'NV01                ', N'04/22/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN15                ', N'NV01                ', N'04/22/2020          ', N'50%                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN16                ', N'NV01                ', N'04/22/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN17                ', N'NV01                ', N'04/24/2020          ', N'60                  ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN18                ', N'NV01                ', N'04/25/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN19                ', N'NV01                ', N'04/26/2020          ', N'70                  ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN24                ', N'NV01                ', N'04/24/2020          ', N'Chưa lưu            ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN28                ', N'NV01                ', N'04/27/2020          ', N'70                  ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN29                ', N'NV01                ', N'04/27/2020          ', N'Chưa lưu            ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN30                ', N'NV01                ', N'05/03/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN31                ', N'NV01                ', N'05/04/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN20                ', N'NV01                ', N'04/24/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN21                ', N'NV01                ', N'04/24/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN22                ', N'NV01                ', N'04/24/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN23                ', N'NV01                ', N'04/24/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN25                ', N'NV01                ', N'04/24/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN26                ', N'NV01                ', N'04/24/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN27                ', N'NV01                ', N'04/24/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN32                ', N'NV01                ', N'05/18/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN33                ', N'NV01                ', N'05/19/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN34                ', N'NV01                ', N'05/19/2020          ', N'60                  ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN35                ', N'NV01                ', N'05/26/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN36                ', N'NV01                ', N'05/26/2020          ', N'Chưa lưu            ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN37                ', N'NV01                ', N'05/27/2020          ', N'Chưa lưu            ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN38                ', N'NV01                ', N'05/26/2020          ', N'90                  ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN39                ', N'NV01                ', N'06/24/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN40                ', N'NV01                ', N'06/24/2020          ', N'10000001            ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN41                ', N'NV01                ', N'06/24/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN42                ', N'NV01                ', N'06/24/2020          ', N'50%                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN43                ', N'NV01                ', N'06/24/2020          ', N'51                  ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN44                ', N'NV01                ', N'06/24/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN45                ', N'NV01                ', N'06/28/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN46                ', N'NV01                ', N'06/28/2020          ', N'50%                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN47                ', N'NV01                ', N'06/28/2020          ', N'50%                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN48                ', N'NV01                ', N'06/29/2020          ', N'91                  ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN49                ', N'NV01                ', N'07/04/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN50                ', N'NV01                ', N'07/10/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN51                ', N'NV01                ', N'07/11/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN52                ', N'NV01                ', N'07/11/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN53                ', N'NV01                ', N'07/11/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN54                ', N'NV01                ', N'07/11/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN55                ', N'NV01                ', N'07/13/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN56                ', N'NV01                ', N'07/13/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN58                ', N'NV01                ', N'07/17/2020          ', N'90%                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN59                ', N'NV01                ', N'07/17/2020          ', N'90%                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN57                ', N'NV01                ', N'07/13/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHOMNGUOIDUNG] ([MANHOM], [TENNHOM], [GhiChu]) VALUES (N'N001                ', N'Quản Lý', NULL)
INSERT [dbo].[NHOMNGUOIDUNG] ([MANHOM], [TENNHOM], [GhiChu]) VALUES (N'N002                ', N'Bán Hàng', NULL)
INSERT [dbo].[NHOMNGUOIDUNG] ([MANHOM], [TENNHOM], [GhiChu]) VALUES (N'N003                ', N'Kỹ Thuật', NULL)
INSERT [dbo].[NHOMNGUOIDUNG] ([MANHOM], [TENNHOM], [GhiChu]) VALUES (N'N004                ', N'Kế Toán', NULL)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000001', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000002', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000003', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000004', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000005', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000006', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000007', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000008', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000009', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000010', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000011', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000012', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000013', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000014', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000015', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000016', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000017', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000018', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000019', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000020', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000021', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000022', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000023', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000024', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000025', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000026', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000027', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000028', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000029', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000030', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000031', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000032', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000033', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000034', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N002                ', N'MH000000000000000010', 1)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP5                 ', N'LSP01               ', N'KHO1                ', N'S9                                                 ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP02                ', N'LSP01               ', N'KHO1                ', N'S8                                                 ', N'new ', 50)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP03                ', N'LSP07               ', N'KHO1                ', N'Xperia A1 plust                                    ', N'new ', 50)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP04                ', N'LSP01               ', N'KHO1                ', N's7                                                 ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'khong               ', N'LSP01               ', N'KHO1                ', N'tempHoaDonNhap                                     ', N'new ', 0)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP6                 ', N'LSP01               ', N'KHO1                ', N'S10', N'new ', 15000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'TEMP                ', N'LSP01               ', N'KHO1                ', N'0', N'0   ', 0)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP01                ', N'LSP01               ', N'KHO1                ', N'S6', N'NEW ', 3000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP9                 ', N'LSP01               ', N'KHO1                ', N'S20', N'new ', 16000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP10                ', N'LSP01               ', N'KHO1                ', N'S9 old                                             ', N'OLD ', 9000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP11                ', N'LSP01               ', N'KHO1                ', N'S6 old', N'old ', 2000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP5                 ', N'LSP01               ', N'KHO2                ', N'S9                                                 ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP13                ', N'LSP01               ', N'KHO1                ', N'A1                                                 ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP14                ', N'LSP07               ', N'KHO1                ', N'XA3                                                ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP15                ', N'L3                  ', N'KHO1                ', N'rog 2                                         ', N'new ', 10000000)
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP02                ', N'27/06/2020', N'12313215656         ', N'TEMP                ', N'26                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP02                ', N'02/07/2020', N'1848715152152       ', N'TEMP                ', N'31                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP02                ', N'02/07/2020', N'9754241144          ', N'TEMP                ', N'30                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP04                ', N'02/07/2020', N'1215151524          ', N'TEMP                ', N'28                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP5                 ', N'26/06/2020', N'12315654655         ', N'TEMP                ', N'23                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP5                 ', N'02/07/2020', N'1267845621          ', N'TEMP                ', N'7                    ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP5                 ', N'02/07/2020', N'14587454112         ', N'TEMP                ', N'25                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP5                 ', N'02/07/2020', N'151121912           ', N'TEMP                ', N'22                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP5                 ', N'02/07/2020', N'1515102312          ', N'TEMP                ', N'29                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP5                 ', N'02/07/2020', N'15481112186         ', N'TEMP                ', N'21                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP5                 ', N'02/07/2020', N'15655645            ', N'TEMP                ', N'21                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP5                 ', N'02/07/2020', N'784695641           ', N'TEMP                ', N'27                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP6                 ', N'02/07/2020', N'154886246511        ', N'TEMP                ', N'26                   ')
INSERT [dbo].[SP_LOI] ([MASP], [NGAYTHU], [SOSERIES], [MALINHKIEN], [MADOITRA]) VALUES (N'SP9                 ', N'02/07/2020', N'1454581414          ', N'TEMP                ', N'27                   ')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'admin               ', N'NV01                ', N'admin                          ', 1)
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'banhang             ', N'NV02                ', N'banhang                        ', 1)
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'admin1              ', N'NV04                ', N'admin1                         ', 1)
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'yennh               ', N'NV05                ', N'123                            ', 0)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (60, N'100       ', CAST(N'2020-04-23T00:00:00.000' AS DateTime), CAST(N'2020-04-24T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (110, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-24T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (113, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-24T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (114, N'61        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-24T00:00:00.000' AS DateTime), N'PN17                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (115, N'20        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-26T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (116, N'100       ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-26T00:00:00.000' AS DateTime), N'PN18                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (117, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-28T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (118, N'70        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-28T00:00:00.000' AS DateTime), N'PN19                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (120, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (121, N'100       ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-04-25T00:00:00.000' AS DateTime), N'PN20                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (122, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (123, N'100       ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-20T00:00:00.000' AS DateTime), N'PN22                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (124, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (125, N'100       ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-12T00:00:00.000' AS DateTime), N'PN23                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (126, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (127, N'100       ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-07T00:00:00.000' AS DateTime), N'PN25                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (128, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-08T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (129, N'100       ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-08T00:00:00.000' AS DateTime), N'PN26                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (130, N'50        ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (131, N'100       ', CAST(N'2020-04-24T00:00:00.000' AS DateTime), CAST(N'2020-12-07T00:00:00.000' AS DateTime), N'PN27                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (132, N'50        ', CAST(N'2020-04-27T00:00:00.000' AS DateTime), CAST(N'2020-12-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (133, N'70        ', CAST(N'2020-04-27T00:00:00.000' AS DateTime), CAST(N'2020-12-12T00:00:00.000' AS DateTime), N'PN28                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (154, N'50        ', CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-05-31T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (155, N'100       ', CAST(N'2020-05-18T00:00:00.000' AS DateTime), CAST(N'2020-05-31T00:00:00.000' AS DateTime), N'PN33                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (158, N'50        ', CAST(N'2020-05-19T00:00:00.000' AS DateTime), CAST(N'2020-05-06T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (159, N'60        ', CAST(N'2020-05-19T00:00:00.000' AS DateTime), CAST(N'2020-05-06T00:00:00.000' AS DateTime), N'PN34                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (162, N'50        ', CAST(N'2020-06-01T00:00:00.000' AS DateTime), CAST(N'2020-06-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (163, N'90        ', CAST(N'2020-06-01T00:00:00.000' AS DateTime), CAST(N'2020-06-01T00:00:00.000' AS DateTime), N'PN38                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (192, N'50        ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (193, N'100       ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'PN39                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (194, N'5000000   ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (195, N'10000001  ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'PN40                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (196, N'50        ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (197, N'100       ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'PN41                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (200, N'50        ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (201, N'50        ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'PN42                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (202, N'50        ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (203, N'51        ', CAST(N'2020-06-24T00:00:00.000' AS DateTime), CAST(N'2020-06-25T00:00:00.000' AS DateTime), N'PN43                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (242, N'50        ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), CAST(N'2020-06-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (243, N'50        ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), CAST(N'2020-06-29T00:00:00.000' AS DateTime), N'PN46                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (244, N'50        ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), CAST(N'2020-06-28T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (245, N'50        ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), CAST(N'2020-06-28T00:00:00.000' AS DateTime), N'PN47                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (246, N'50        ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), CAST(N'2020-06-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (247, N'91        ', CAST(N'2020-06-28T00:00:00.000' AS DateTime), CAST(N'2020-06-29T00:00:00.000' AS DateTime), N'PN48                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (337, N'90        ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), CAST(N'2020-07-18T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (338, N'90        ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), CAST(N'2020-07-18T00:00:00.000' AS DateTime), N'PN58                ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (339, N'90        ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), CAST(N'2020-07-18T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (340, N'90        ', CAST(N'2020-07-17T00:00:00.000' AS DateTime), CAST(N'2020-07-18T00:00:00.000' AS DateTime), N'PN59                ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'admin               ', N'N001                ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'admin1              ', N'N001                ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'banhang             ', N'N002                ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'yennh               ', N'N002                ')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'1                   ', 5000025, 5000025, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'10                  ', 5000000, 5000000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'10                  ', 50, 4999930, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'11                  ', 5000025, 5000025, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'12                  ', 5000000, 5000000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'13                  ', 5000000, 5000000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'14                  ', 7500025, 7500025, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'15                  ', 7500000, 7500000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'15                  ', 50, 4999930, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'16                  ', 12500000, 12500000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'16                  ', 50, 4999930, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'17                  ', 7500000, 7500000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'17                  ', 50, 4999930, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'18                  ', 7500000, 7500000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'18                  ', 500000, 7000000, CAST(N'2020-04-24' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'18                  ', 2000000, 5500000, CAST(N'2020-05-25' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'19                  ', 5000000, 5000000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'19                  ', 2000000, 3000000, CAST(N'2020-04-24' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'19                  ', 50, 2999950, CAST(N'2020-07-03' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'2                   ', 5000000, 5000000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'22                  ', 5000000, 5000000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'22                  ', 20, 4999980, CAST(N'2020-04-24' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'24                  ', 25, 25, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'24                  ', 25, 0, CAST(N'2020-05-03' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'3                   ', 5000000, 4999980, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'3                   ', 80, 4999900, CAST(N'2020-05-25' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'3                   ', 5000, 4994980, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'3                   ', 980, 4994000, CAST(N'2020-06-26' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'38                  ', 2500000, 2500000, CAST(N'2020-06-26' AS Date), N'2020-07-26')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'39                  ', 2500000, 2500000, CAST(N'2020-06-26' AS Date), N'2020-07-26')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'4                   ', 7500000, 7450000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'4                   ', 450000, 4549980, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'4                   ', 980, 4549000, CAST(N'2020-06-26' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'42                  ', 7500000, 7500000, CAST(N'2020-07-03' AS Date), N'2020-08-02')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'5                   ', 5000000, 5000000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'5                   ', 4000000, 999980, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'6                   ', 5000000, 5000000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'6                   ', 1000000, 3999980, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'7                   ', 7500000, 7500000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'7                   ', 500000, 4499980, CAST(N'2020-06-18' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'8                   ', 7500000, 7500000, CAST(N'2020-04-23' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'8                   ', 500000, 7000000, CAST(N'2020-06-01' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'temp                ', 0, 0, CAST(N'2020-04-23' AS Date), N'2020-04-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'42                  ', 3500000, 4000000, CAST(N'2020-07-03' AS Date), N'2020-08-02')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'42                  ', 500, 7499500, CAST(N'2020-07-03' AS Date), N'2020-08-02')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'10                  ', 30, 4999900, CAST(N'2020-07-08' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'10                  ', 900, 4999000, CAST(N'2020-07-08' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'10                  ', 9000, 4990000, CAST(N'2020-07-08' AS Date), N'2020-05-23')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'58                  ', 2500000, 2500000, CAST(N'2020-07-12' AS Date), N'2020-08-11')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'59                  ', 3150000, 3150000, CAST(N'2020-07-17' AS Date), N'2020-08-16')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'59                  ', 3150000, 0, CAST(N'2020-07-17' AS Date), N'2020-08-16')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'61                  ', 2500000, 2500000, CAST(N'2020-07-19' AS Date), N'2020-08-18')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'61                  ', 2500000, 0, CAST(N'2020-07-19' AS Date), N'2020-08-18')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'49                  ', 2600000, 2600000, CAST(N'2020-07-08' AS Date), N'2020-08-07')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'50                  ', 2600000, 2600000, CAST(N'2020-07-08' AS Date), N'2020-08-07')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'51                  ', 2500000, 2500000, CAST(N'2020-07-08' AS Date), N'2020-08-07')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'52                  ', 2600000, 2600000, CAST(N'2020-07-08' AS Date), N'2020-08-07')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'53                  ', 2600000, 2600000, CAST(N'2020-07-08' AS Date), N'2020-08-07')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'53                  ', 600000, 2000000, CAST(N'2020-07-08' AS Date), N'2020-08-07')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'52                  ', 1000000, 1600000, CAST(N'2020-07-08' AS Date), N'2020-08-07')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'56                  ', 2600020, 2600020, CAST(N'2020-07-08' AS Date), N'2020-08-07')
INSERT [dbo].[TraGop] ([MaTraGop], [SoTienPhaiTra], [SoTienConLai], [NgayTra], [deadline]) VALUES (N'53                  ', 600000, 1400000, CAST(N'2020-07-08' AS Date), N'2020-08-07')
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_BAOHANH]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[BAOHANH] ADD  CONSTRAINT [PK_BAOHANH] PRIMARY KEY NONCLUSTERED 
(
	[MABAOHANH] ASC,
	[MALOIND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_DATHANG]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[DATHANG] ADD  CONSTRAINT [PK_DATHANG] PRIMARY KEY NONCLUSTERED 
(
	[MADAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_DOITRA]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[DOITRA] ADD  CONSTRAINT [PK_DOITRA] PRIMARY KEY NONCLUSTERED 
(
	[MADOITRA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_HOADON]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [PK_HOADON] PRIMARY KEY NONCLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_KHACHHANG]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [PK_KHACHHANG] PRIMARY KEY NONCLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_KHUYENMAI]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[KHUYENMAI] ADD  CONSTRAINT [PK_KHUYENMAI] PRIMARY KEY NONCLUSTERED 
(
	[MAKHUYENMAI] ASC,
	[MASP] ASC,
	[MALINHKIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LINHKIEN]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[LINHKIEN] ADD  CONSTRAINT [PK_LINHKIEN] PRIMARY KEY NONCLUSTERED 
(
	[MALINHKIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LOAIHOADON]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[LOAIHOADON] ADD  CONSTRAINT [PK_LOAIHOADON] PRIMARY KEY NONCLUSTERED 
(
	[MALOAIHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LOAISANPHAM]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[LOAISANPHAM] ADD  CONSTRAINT [PK_LOAISANPHAM] PRIMARY KEY NONCLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LOIDONGUOIDUNG]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[LOIDONGUOIDUNG] ADD  CONSTRAINT [PK_LOIDONGUOIDUNG] PRIMARY KEY NONCLUSTERED 
(
	[MALOIND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LOIDONHASX]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[LOIDONHASX] ADD  CONSTRAINT [PK_LOIDONHASX] PRIMARY KEY NONCLUSTERED 
(
	[MALOISX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_MANHINH]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[MANHINH] ADD  CONSTRAINT [PK_MANHINH] PRIMARY KEY NONCLUSTERED 
(
	[MAMANHINH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_NHACUNGCAP]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[NHACUNGCAP] ADD  CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY NONCLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_NHANVIEN]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [PK_NHANVIEN] PRIMARY KEY NONCLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_NHAPHANG]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[NHAPHANG] ADD  CONSTRAINT [PK_NHAPHANG] PRIMARY KEY NONCLUSTERED 
(
	[MANHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_NHOMNGUOIDUNG]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[NHOMNGUOIDUNG] ADD  CONSTRAINT [PK_NHOMNGUOIDUNG] PRIMARY KEY NONCLUSTERED 
(
	[MANHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_SANPHAM]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[SANPHAM] ADD  CONSTRAINT [PK_SANPHAM] PRIMARY KEY NONCLUSTERED 
(
	[MASP] ASC,
	[MAKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_TAIKHOAN]    Script Date: 07/19/2020 8:20:41 AM ******/
ALTER TABLE [dbo].[TAIKHOAN] ADD  CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY NONCLUSTERED 
(
	[TENDANGNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BAOHANH]  WITH CHECK ADD  CONSTRAINT [FK_BAOHANH_CO5_KHACHHAN] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[BAOHANH] CHECK CONSTRAINT [FK_BAOHANH_CO5_KHACHHAN]
GO
ALTER TABLE [dbo].[CT_HOADON_LINHKIEN]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADO_CT_HOADON_HOADON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[CT_HOADON_LINHKIEN] CHECK CONSTRAINT [FK_CT_HOADO_CT_HOADON_HOADON]
GO
ALTER TABLE [dbo].[CT_HOADON_LINHKIEN]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADO_CT_HOADON_LINHKIEN] FOREIGN KEY([MALINHKIEN])
REFERENCES [dbo].[LINHKIEN] ([MALINHKIEN])
GO
ALTER TABLE [dbo].[CT_HOADON_LINHKIEN] CHECK CONSTRAINT [FK_CT_HOADO_CT_HOADON_LINHKIEN]
GO
ALTER TABLE [dbo].[Ct_mua_SP]  WITH CHECK ADD  CONSTRAINT [FK_Ct_mua_SP_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[Ct_mua_SP] CHECK CONSTRAINT [FK_Ct_mua_SP_HOADON]
GO
ALTER TABLE [dbo].[Ct_mua_SP]  WITH CHECK ADD  CONSTRAINT [FK_Ct_mua_SP_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[Ct_mua_SP] CHECK CONSTRAINT [FK_Ct_mua_SP_KHACHHANG]
GO
ALTER TABLE [dbo].[CT_NHAP_SP]  WITH CHECK ADD  CONSTRAINT [FK_CT_NHAP__CT_NHAP_S_NHACUNGC] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[CT_NHAP_SP] CHECK CONSTRAINT [FK_CT_NHAP__CT_NHAP_S_NHACUNGC]
GO
ALTER TABLE [dbo].[CT_NHAP_SP]  WITH CHECK ADD  CONSTRAINT [FK_CT_NHAP__CT_NHAP_S_NHAPHANG] FOREIGN KEY([MANHAP])
REFERENCES [dbo].[NHAPHANG] ([MANHAP])
GO
ALTER TABLE [dbo].[CT_NHAP_SP] CHECK CONSTRAINT [FK_CT_NHAP__CT_NHAP_S_NHAPHANG]
GO
ALTER TABLE [dbo].[DATHANG]  WITH CHECK ADD  CONSTRAINT [FK_DATHANG_CO_THE_DA_KHACHHAN] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[DATHANG] CHECK CONSTRAINT [FK_DATHANG_CO_THE_DA_KHACHHAN]
GO
ALTER TABLE [dbo].[DATHANG_SP]  WITH CHECK ADD  CONSTRAINT [FK_DATHANG__DATHANG_S_DATHANG] FOREIGN KEY([MADAT])
REFERENCES [dbo].[DATHANG] ([MADAT])
GO
ALTER TABLE [dbo].[DATHANG_SP] CHECK CONSTRAINT [FK_DATHANG__DATHANG_S_DATHANG]
GO
ALTER TABLE [dbo].[DOITRA]  WITH CHECK ADD  CONSTRAINT [FK_DOITRA_DOI_KHACHHAN] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[DOITRA] CHECK CONSTRAINT [FK_DOITRA_DOI_KHACHHAN]
GO
ALTER TABLE [dbo].[DOITRA_SP]  WITH CHECK ADD  CONSTRAINT [FK_DOITRA_S_DOITRA_SP_DOITRA] FOREIGN KEY([MADOITRA])
REFERENCES [dbo].[DOITRA] ([MADOITRA])
GO
ALTER TABLE [dbo].[DOITRA_SP] CHECK CONSTRAINT [FK_DOITRA_S_DOITRA_SP_DOITRA]
GO
ALTER TABLE [dbo].[DOITRA_SP]  WITH CHECK ADD  CONSTRAINT [FK_DOITRA_S_DOITRA_SP_LOIDONGU] FOREIGN KEY([MALOIND])
REFERENCES [dbo].[LOIDONGUOIDUNG] ([MALOIND])
GO
ALTER TABLE [dbo].[DOITRA_SP] CHECK CONSTRAINT [FK_DOITRA_S_DOITRA_SP_LOIDONGU]
GO
ALTER TABLE [dbo].[DOITRA_SP]  WITH CHECK ADD  CONSTRAINT [FK_DOITRA_S_DOITRA_SP_LOIDONHA] FOREIGN KEY([MALOISX])
REFERENCES [dbo].[LOIDONHASX] ([MALOISX])
GO
ALTER TABLE [dbo].[DOITRA_SP] CHECK CONSTRAINT [FK_DOITRA_S_DOITRA_SP_LOIDONHA]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_LOAIHOADON] FOREIGN KEY([MALOAIHD])
REFERENCES [dbo].[LOAIHOADON] ([MALOAIHD])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_LOAIHOADON]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHACUNGCAP] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHACUNGCAP]
GO
ALTER TABLE [dbo].[KHO]  WITH CHECK ADD  CONSTRAINT [FK_KHO_LINHKIEN] FOREIGN KEY([MALINHKIEN])
REFERENCES [dbo].[LINHKIEN] ([MALINHKIEN])
GO
ALTER TABLE [dbo].[KHO] CHECK CONSTRAINT [FK_KHO_LINHKIEN]
GO
ALTER TABLE [dbo].[KHUYENMAI]  WITH CHECK ADD  CONSTRAINT [FK_KHUYENMA_CT_KM_LK_LINHKIEN] FOREIGN KEY([MALINHKIEN])
REFERENCES [dbo].[LINHKIEN] ([MALINHKIEN])
GO
ALTER TABLE [dbo].[KHUYENMAI] CHECK CONSTRAINT [FK_KHUYENMA_CT_KM_LK_LINHKIEN]
GO
ALTER TABLE [dbo].[NHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_NHAPHANG_CO_THE_NH_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[NHAPHANG] CHECK CONSTRAINT [FK_NHAPHANG_CO_THE_NH_NHANVIEN]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYE_PHANQUYEN_MANHINH] FOREIGN KEY([MAMANHINH])
REFERENCES [dbo].[MANHINH] ([MAMANHINH])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PHANQUYE_PHANQUYEN_MANHINH]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYE_PHANQUYEN_NHOMNGUO] FOREIGN KEY([MANHOM])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MANHOM])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PHANQUYE_PHANQUYEN_NHOMNGUO]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_THUOC_VE2_LOAISANP] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAISANPHAM] ([MALOAI])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_THUOC_VE2_LOAISANP]
GO
ALTER TABLE [dbo].[SP_LOI]  WITH CHECK ADD  CONSTRAINT [FK_SP_LOI_LINHKIEN] FOREIGN KEY([MALINHKIEN])
REFERENCES [dbo].[LINHKIEN] ([MALINHKIEN])
GO
ALTER TABLE [dbo].[SP_LOI] CHECK CONSTRAINT [FK_SP_LOI_LINHKIEN]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_CO_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_CO_NHANVIEN]
GO
ALTER TABLE [dbo].[TinhTrangTT]  WITH CHECK ADD  CONSTRAINT [FK_TinhTrangTT_NHAPHANG] FOREIGN KEY([MANHAP])
REFERENCES [dbo].[NHAPHANG] ([MANHAP])
GO
ALTER TABLE [dbo].[TinhTrangTT] CHECK CONSTRAINT [FK_TinhTrangTT_NHAPHANG]
GO
ALTER TABLE [dbo].[tk_NND]  WITH CHECK ADD  CONSTRAINT [FK_tk_NND_NHOMNGUOIDUNG] FOREIGN KEY([MANHOM])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MANHOM])
GO
ALTER TABLE [dbo].[tk_NND] CHECK CONSTRAINT [FK_tk_NND_NHOMNGUOIDUNG]
GO
ALTER TABLE [dbo].[tk_NND]  WITH CHECK ADD  CONSTRAINT [FK_tk_NND_TAIKHOAN] FOREIGN KEY([TENDANGNHAP])
REFERENCES [dbo].[TAIKHOAN] ([TENDANGNHAP])
GO
ALTER TABLE [dbo].[tk_NND] CHECK CONSTRAINT [FK_tk_NND_TAIKHOAN]
GO
USE [master]
GO
ALTER DATABASE [DTDD] SET  READ_WRITE 
GO
