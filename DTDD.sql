USE [master]
GO
/****** Object:  Database [DTDD]    Script Date: 07/25/2020 12:45:44 PM ******/
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
/****** Object:  Table [dbo].[BAOHANH]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[ct_bH]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[CT_HOADON_LINHKIEN]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[Ct_mua_SP]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[ct_mua_sp_lk]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[CT_NHAP_LK]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[CT_NHAP_SP]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[DATHANG]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[DATHANG_SP]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[DOITRA]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[DOITRA_SP]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[HOADON]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[KHO]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[KHUYENMAI]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[LINHKIEN]    Script Date: 07/25/2020 12:45:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LINHKIEN](
	[MALINHKIEN] [char](20) NOT NULL,
	[TENLINHKIEN] [nvarchar](100) NULL,
	[DONGIA] [int] NULL,
	[MAKHO] [char](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHOADON]    Script Date: 07/25/2020 12:45:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHOADON](
	[MALOAIHD] [char](20) NOT NULL,
	[TENLOAIHD] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 07/25/2020 12:45:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MALOAI] [char](20) NOT NULL,
	[TENLOAI] [nvarchar](51) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOIDONGUOIDUNG]    Script Date: 07/25/2020 12:45:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOIDONGUOIDUNG](
	[MALOIND] [char](21) NOT NULL,
	[TENLOIND] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOIDONHASX]    Script Date: 07/25/2020 12:45:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOIDONHASX](
	[MALOISX] [char](20) NOT NULL,
	[TENLOISX] [nvarchar](51) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MANHINH]    Script Date: 07/25/2020 12:45:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MANHINH](
	[MAMANHINH] [char](20) NOT NULL,
	[TENMANHINH] [nvarchar](51) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NDBaoHanh]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[NHAPHANG]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[NHOMNGUOIDUNG]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[SP_LOI]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[TinhTrangTT]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[tk_NND]    Script Date: 07/25/2020 12:45:45 PM ******/
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
/****** Object:  Table [dbo].[TraGop]    Script Date: 07/25/2020 12:45:45 PM ******/
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
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK01                ', N'PN5                 ', N'NCC001              ', 10, 50000)
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK01                ', N'PN6                 ', N'NCC001              ', 10, 50000)
INSERT [dbo].[CT_NHAP_LK] ([MALINHKIEN], [MANHAP], [MANCC], [SL], [DONGIA]) VALUES (N'LK01                ', N'PN7                 ', N'NCC001              ', 10, 50000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN1                 ', N'SP5                 ', N'NCC001              ', 10, 9000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN2                 ', N'SP5                 ', N'NCC001              ', 10, 9000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN3                 ', N'SP02                ', N'NCC001              ', 10, 9000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN3                 ', N'SP03                ', N'NCC001              ', 10, 8000000)
INSERT [dbo].[CT_NHAP_SP] ([MANHAP], [MASP], [MANCC], [SL], [DonGia]) VALUES (N'PN4                 ', N'SP6                 ', N'NCC001              ', 10, 9000000)
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (345, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (346, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (357, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (358, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'admin               ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (360, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'admin               ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (361, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'admin               ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (362, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (363, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'admin               ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (364, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (359, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'admin               ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (348, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (349, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (350, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (351, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (352, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (353, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (354, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (355, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (356, N'NCC001              ', N'MLHD03              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
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
GO
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
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (343, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (344, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-23T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MAHD], [MANCC], [MALOAIHD], [NGAYLAP], [MaTraGop], [MaNV], [ChenhLech], [MaDoiTra], [MaBaoHanh]) VALUES (347, N'NCC001              ', N'MLHD01              ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'temp                ', N'NV01                ', NULL, NULL, NULL)
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
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH06                ', N'Phạm Văn Toan', N'0123456    ', N'HCM                                                ', N'362504076    ')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [DIACHI], [CMND]) VALUES (N'KH07                ', N'Nguyễn Hải Yến', N'021548521  ', N'HCM                                                ', N'362504076    ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP01                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 10, N'SP02                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 10, N'SP03                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP04                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP10                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP11                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP13                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP14                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP15                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP16                ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 20, N'SP5                 ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 10, N'SP6                 ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'SP9                 ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'temp                ', N'HCM', 315485615, N'LK01                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO1                ', 0, N'temp                ', N'HCM', 315485615, N'LK02                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO2                ', 0, N'SP15                ', N'HN', 151648165, N'TEMP                ')
INSERT [dbo].[KHO] ([MAKHO], [SL], [MASP], [DiaChi], [SDT], [MALINHKIEN]) VALUES (N'KHO2                ', 0, N'SP5                 ', N'HCM', 315485615, N'TEMP                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK01                ', N'Man Hinh j7 prime                                  ', 55000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK02                ', N'headphone ipod', 1300000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK03                ', N'headphone sony', 110000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'TEMP                ', N'TEMP', 0, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK04                ', N'Tai nghe chụp tai Gaming 7.1 Rapoo VH510 Đen', 799000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK05                ', N'Tai nghe Bluetooth True Wireless Mozard T302A Đen', 1250000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK09                ', N' Bluetooth True Wireless Mozard DS635-WB Đen', 950000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK06                ', N'Tai nghe Bluetooth True Wireless Mozard AT15', 800000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK07                ', N'Pin sạc Polymer 10.000mAh Type C PD QC3.0 P68D', 700000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK08                ', N'pin sac Polymer 10.000mAh Type C Xmobile PJ JP190ST', 200000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK010               ', N'10.000 mAh Lightning Xmobile LJ JP90S', 700000, N'KHO1                ')
INSERT [dbo].[LINHKIEN] ([MALINHKIEN], [TENLINHKIEN], [DONGIA], [MAKHO]) VALUES (N'LK011               ', N'Man Hinh j7 prime                                  ', 200000, N'KHO1                ')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD01              ', N'HDNCC               ')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD02              ', N'Bán Hàng')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD04              ', N'Bán Hàng Trả góp')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD03              ', N'CH tra gop cho ncc')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD05              ', N'Bảo hành')
INSERT [dbo].[LOAIHOADON] ([MALOAIHD], [TENLOAIHD]) VALUES (N'MLHD06              ', N'đổi trả')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAI]) VALUES (N'LSP01               ', N'DT SamSung                                         ')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAI]) VALUES (N'LSP07               ', N'DT Sony                                            ')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAI]) VALUES (N'L3                  ', N'ROG                             ')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAI]) VALUES (N'L4                  ', N'DT OPPO')
INSERT [dbo].[LOIDONGUOIDUNG] ([MALOIND], [TENLOIND]) VALUES (N'khong                ', N'khong')
INSERT [dbo].[LOIDONGUOIDUNG] ([MALOIND], [TENLOIND]) VALUES (N'1                    ', N'hỏng màn hình')
INSERT [dbo].[LOIDONHASX] ([MALOISX], [TENLOISX]) VALUES (N'1                   ', N'Lỗi màn hinh')
INSERT [dbo].[LOIDONHASX] ([MALOISX], [TENLOISX]) VALUES (N'2                   ', N'loi cam ung')
INSERT [dbo].[LOIDONHASX] ([MALOISX], [TENLOISX]) VALUES (N'khong               ', N'khong')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000001', N'Người Dùng')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000002', N'Nhóm người dùng')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000003', N'Phân Quyền')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000004', N'Phục hồi dữ liệu')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000023', N'Quản lý khách hàng')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000005', N'Sản phẩm')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000006', N'Nhà cung cấp')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000007', N'linh kiện')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000009', N'tạo phiếu nhập linh kiện')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000010', N'bán hàng')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000020', N'Đổi trả')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000021', N'lõi sản xuất')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000022', N'lõi người dùng')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000018', N'km sản phẩm linh kiện')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000012', N'thống kê doanh thu')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000013', N'thống kê trả góp')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000014', N'thống kê sản phẩm km')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000024', N'tạo phiểu nhập sản phẩm')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000025', N'lưu sản phẩm vào kho')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000026', N'lưu linh kiện vào kho')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000027', N'thanh toán trả góp')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000028', N'Bảo hành')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000030', N'trả góp nhà cung cấp')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000031', N'thống kê top 5 và top 10')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000032', N'thống kê theo loại sp')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000033', N'thống kê sl trong kho')
INSERT [dbo].[MANHINH] ([MAMANHINH], [TENMANHINH]) VALUES (N'MH000000000000000034', N'thống kê lợi nhuận')
INSERT [dbo].[NDBaoHanh] ([MANDBH], [TenNDBH], [DonGia]) VALUES (1, N'Vệ Sinh', 50000)
INSERT [dbo].[NDBaoHanh] ([MANDBH], [TenNDBH], [DonGia]) VALUES (2, N'Thay Linh Kiện', 0)
INSERT [dbo].[NDBaoHanh] ([MANDBH], [TenNDBH], [DonGia]) VALUES (3, N'Sữa Chữa', 50000)
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC001              ', N'Sony', N'TPHCM                                              ', N'0123456789 ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'temp                ', N'khong', N'khong                                              ', N'khong      ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC002              ', N'SAMSUNG', N'TPHCM                                              ', N'0123456789 ')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'khong               ', N'khong', N'khong                                              ', N'khong      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV01                ', N'admin                          ', N'01/01/2000          ', N'TN                                                 ', N'0397299292 ', N'Nam ', N'3497117      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV02                ', N'THái', N'01/01/2000          ', N'HCM                                                ', N'0123456789 ', N'N?  ', N'0322131      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV03                ', N'123', N'01/01/2000          ', N'HCM                                                ', N'0123456789 ', N'Nam ', N'0322131      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV04                ', N'Lý Thiên Thanh', N'01/01/2000          ', N'HN                                                 ', N'0156132155 ', N'Nam ', N'0231565      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV05                ', N'YEN', N'01/01/2000          ', N'NA                                                 ', N'0124514511 ', N'N?  ', N'0235151      ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [DIACHI], [SDT], [GIOITINH], [CMND]) VALUES (N'NV06                ', N'toan', N'09/02/1998          ', N'QN                                                 ', N'015854155  ', N'Nu  ', N'0212155      ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN1                 ', N'NV01                ', N'07/25/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN2                 ', N'NV01                ', N'07/25/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN3                 ', N'NV01                ', N'07/25/2020          ', N'50%                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN4                 ', N'NV01                ', N'07/25/2020          ', N'60000000            ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN5                 ', N'NV01                ', N'07/25/2020          ', N'Đã lưu              ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN6                 ', N'NV01                ', N'07/25/2020          ', N'100                 ')
INSERT [dbo].[NHAPHANG] ([MANHAP], [MANV], [NGAYNHAP], [TrangThai]) VALUES (N'PN7                 ', N'NV01                ', N'07/25/2020          ', N'300000              ')
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
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000009', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000010', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000012', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000013', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000014', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000018', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000020', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000021', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000022', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000023', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000024', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000025', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000026', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000027', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000028', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000030', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000031', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000032', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000033', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N001                ', N'MH000000000000000034', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N002                ', N'MH000000000000000005', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N002                ', N'MH000000000000000007', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N002                ', N'MH000000000000000010', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N002                ', N'MH000000000000000027', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N002                ', N'MH000000000000000030', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N002                ', N'MH000000000000000033', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N003                ', N'MH000000000000000020', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N003                ', N'MH000000000000000028', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N004                ', N'MH000000000000000012', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N004                ', N'MH000000000000000013', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N004                ', N'MH000000000000000014', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N004                ', N'MH000000000000000030', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N004                ', N'MH000000000000000031', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N004                ', N'MH000000000000000032', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N004                ', N'MH000000000000000033', 1)
INSERT [dbo].[PHANQUYEN] ([MANHOM], [MAMANHINH], [CoQuyen]) VALUES (N'N004                ', N'MH000000000000000034', 1)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP5                 ', N'LSP01               ', N'KHO1                ', N'S9                                                 ', N'new ', 9900000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP02                ', N'LSP01               ', N'KHO1                ', N's8                                                 ', N'new ', 9900000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP03                ', N'LSP07               ', N'KHO1                ', N'Xperia A1 plust                                    ', N'new ', 9900000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP04                ', N'LSP01               ', N'KHO1                ', N's7                                                 ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'khong               ', N'LSP01               ', N'KHO1                ', N'tempHoaDonNhap                                     ', N'new ', 0)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP6                 ', N'LSP01               ', N'KHO1                ', N'S10', N'new ', 9900000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'TEMP                ', N'LSP01               ', N'KHO1                ', N'0', N'0   ', 0)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP01                ', N'LSP01               ', N'KHO1                ', N'S6', N'NEW ', 3000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP9                 ', N'LSP01               ', N'KHO1                ', N'S20', N'new ', 16000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP10                ', N'LSP01               ', N'KHO1                ', N'S9 old                                             ', N'OLD ', 9000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP11                ', N'LSP01               ', N'KHO1                ', N'S6 old', N'old ', 2000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP5                 ', N'LSP01               ', N'KHO2                ', N'S9                                                 ', N'new ', 9900000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP13                ', N'LSP01               ', N'KHO1                ', N'A1                                                 ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP14                ', N'LSP07               ', N'KHO1                ', N'XA3                                                ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP15                ', N'L3                  ', N'KHO1                ', N'rog 2                                         ', N'new ', 10000000)
INSERT [dbo].[SANPHAM] ([MASP], [MALOAI], [MAKHO], [TENSP], [TINHTRANG], [DonGia]) VALUES (N'SP16                ', N'L4                  ', N'KHO1                ', N'A92                                       ', N'new ', 5699000)
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'admin               ', N'NV01                ', N'admin                          ', 1)
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'banhang             ', N'NV02                ', N'banhang                        ', 1)
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'admin1              ', N'NV04                ', N'admin1                         ', 1)
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'yennh               ', N'NV05                ', N'123                            ', 0)
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANV], [MATKHAU], [HOATDONG]) VALUES (N'toan                ', N'NV06                ', N'toan1                          ', 1)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (351, N'50        ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-26T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (352, N'100       ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-26T00:00:00.000' AS DateTime), N'PN2                 ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (353, N'50        ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-26T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (354, N'50        ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-26T00:00:00.000' AS DateTime), N'PN3                 ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (355, N'45000000  ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (356, N'60000000  ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'PN4                 ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (361, N'50        ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (362, N'100       ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-25T00:00:00.000' AS DateTime), N'PN6                 ')
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (363, N'250000    ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-26T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TinhTrangTT] ([MaHD], [TinhTrangThanhToan], [NgayTT], [NgayTTTiepTheo], [MANHAP]) VALUES (364, N'300000    ', CAST(N'2020-07-25T00:00:00.000' AS DateTime), CAST(N'2020-07-26T00:00:00.000' AS DateTime), N'PN7                 ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'admin               ', N'N001                ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'admin1              ', N'N001                ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'banhang             ', N'N002                ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'toan                ', N'N003                ')
INSERT [dbo].[tk_NND] ([TENDANGNHAP], [MANHOM]) VALUES (N'yennh               ', N'N004                ')
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_BAOHANH]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[BAOHANH] ADD  CONSTRAINT [PK_BAOHANH] PRIMARY KEY NONCLUSTERED 
(
	[MABAOHANH] ASC,
	[MALOIND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_DATHANG]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[DATHANG] ADD  CONSTRAINT [PK_DATHANG] PRIMARY KEY NONCLUSTERED 
(
	[MADAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_DOITRA]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[DOITRA] ADD  CONSTRAINT [PK_DOITRA] PRIMARY KEY NONCLUSTERED 
(
	[MADOITRA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_HOADON]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [PK_HOADON] PRIMARY KEY NONCLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_KHACHHANG]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [PK_KHACHHANG] PRIMARY KEY NONCLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_KHUYENMAI]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[KHUYENMAI] ADD  CONSTRAINT [PK_KHUYENMAI] PRIMARY KEY NONCLUSTERED 
(
	[MAKHUYENMAI] ASC,
	[MASP] ASC,
	[MALINHKIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LINHKIEN]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[LINHKIEN] ADD  CONSTRAINT [PK_LINHKIEN] PRIMARY KEY NONCLUSTERED 
(
	[MALINHKIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LOAIHOADON]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[LOAIHOADON] ADD  CONSTRAINT [PK_LOAIHOADON] PRIMARY KEY NONCLUSTERED 
(
	[MALOAIHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LOAISANPHAM]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[LOAISANPHAM] ADD  CONSTRAINT [PK_LOAISANPHAM] PRIMARY KEY NONCLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LOIDONGUOIDUNG]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[LOIDONGUOIDUNG] ADD  CONSTRAINT [PK_LOIDONGUOIDUNG] PRIMARY KEY NONCLUSTERED 
(
	[MALOIND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_LOIDONHASX]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[LOIDONHASX] ADD  CONSTRAINT [PK_LOIDONHASX] PRIMARY KEY NONCLUSTERED 
(
	[MALOISX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_MANHINH]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[MANHINH] ADD  CONSTRAINT [PK_MANHINH] PRIMARY KEY NONCLUSTERED 
(
	[MAMANHINH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_NHACUNGCAP]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[NHACUNGCAP] ADD  CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY NONCLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_NHANVIEN]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [PK_NHANVIEN] PRIMARY KEY NONCLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_NHAPHANG]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[NHAPHANG] ADD  CONSTRAINT [PK_NHAPHANG] PRIMARY KEY NONCLUSTERED 
(
	[MANHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_NHOMNGUOIDUNG]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[NHOMNGUOIDUNG] ADD  CONSTRAINT [PK_NHOMNGUOIDUNG] PRIMARY KEY NONCLUSTERED 
(
	[MANHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_SANPHAM]    Script Date: 07/25/2020 12:45:45 PM ******/
ALTER TABLE [dbo].[SANPHAM] ADD  CONSTRAINT [PK_SANPHAM] PRIMARY KEY NONCLUSTERED 
(
	[MASP] ASC,
	[MAKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PK_TAIKHOAN]    Script Date: 07/25/2020 12:45:45 PM ******/
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
