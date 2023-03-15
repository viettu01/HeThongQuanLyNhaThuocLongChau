USE [master]
GO
/****** Object:  Database [db_QuanLyHeThongNhaThuocLongChau]    Script Date: 2023/03/15 3:55:58 PM ******/
CREATE DATABASE [db_QuanLyHeThongNhaThuocLongChau]
GO
/****** Object:  Table [dbo].[tbl_LoaiSanPham]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LoaiSanPham](
	[PK_sMaLoai] [varchar](10) NOT NULL,
	[sTenLoai] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_sMaLoai] PRIMARY KEY CLUSTERED 
(
	[PK_sMaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_SanPham]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SanPham](
	[PK_sMaSP] [varchar](10) NOT NULL,
	[sTenSP] [nvarchar](100) NOT NULL,
	[sDonViTinh] [nvarchar](10) NOT NULL,
	[sHanDung] [nvarchar](10) NOT NULL,
	[iSL] [int] NOT NULL,
	[fDonGiaBan] [float] NOT NULL,
	[FK_sMaLoai] [varchar](10) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[PK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vv_SanPham]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vv_SanPham]
AS
	SELECT a.PK_sMaSP AS [Mã SP], a.sTenSP AS [Tên SP], b.sTenLoai AS [Loại], a.sDonViTinh AS [Đơn vị tính],
			a.sHanDung AS [Hạn dùng], a.iSL AS [Số lượng tồn], a.fDonGiaBan AS [Giá bán]
	FROM dbo.tbl_SanPham a JOIN dbo.tbl_LoaiSanPham b ON b.PK_sMaLoai = a.FK_sMaLoai
GO
/****** Object:  Table [dbo].[tbl_BienBanHuy]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BienBanHuy](
	[PK_sMaBBH] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
	[sDiaDiemHuy] [nvarchar](100) NOT NULL,
	[dTgBatDau] [datetime] NOT NULL,
	[dTgKetThuc] [datetime] NOT NULL,
	[sPhuongThucHuy] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_BienBanHuy] PRIMARY KEY CLUSTERED 
(
	[PK_sMaBBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_BienBanKiemKe]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BienBanKiemKe](
	[PK_sMaBBK] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
	[sDiaDiemKiem] [nvarchar](100) NOT NULL,
	[dTgBatDau] [datetime] NOT NULL,
	[dTgKetThuc] [datetime] NOT NULL,
 CONSTRAINT [PK_BienBanKiemKe] PRIMARY KEY CLUSTERED 
(
	[PK_sMaBBK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTBienBanHuy]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTBienBanHuy](
	[PK_FK_sMaBBH] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[iSL] [int] NOT NULL,
	[sLyDo] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_CTBienBanHuy] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaBBH] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTBienBanKiemKe]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTBienBanKiemKe](
	[PK_FK_sMaBBK] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[iSL] [int] NOT NULL,
 CONSTRAINT [PK_CTBienBanKiemKe] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaBBK] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTHopDongCungCap]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTHopDongCungCap](
	[PK_FK_sMaHD] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[fDonGia] [float] NOT NULL,
 CONSTRAINT [PK_CTHopDongCungCap] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaHD] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTPhieuChi]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTPhieuChi](
	[PK_FK_sMaPChi] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CTPhieuChi] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaPChi] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTPhieuDatHang]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTPhieuDatHang](
	[PK_FK_sMaPDH] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[iSL] [int] NOT NULL,
 CONSTRAINT [PK_CTPhieuDatHang] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaPDH] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTPhieuGiao]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTPhieuGiao](
	[PK_FK_sMaPGH] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[iSL] [int] NOT NULL,
 CONSTRAINT [PK_CTPhieuGiao] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaPGH] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTPhieuNhapKho]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTPhieuNhapKho](
	[PK_FK_sMaPN] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[iSL] [int] NOT NULL,
	[sGhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_CTPhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaPN] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTPhieuThu]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTPhieuThu](
	[PK_FK_sMaPT] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[iSL] [int] NOT NULL,
 CONSTRAINT [PK_CTPhieuThu] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaPT] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTPhieuXuatKho]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTPhieuXuatKho](
	[PK_FK_sMaPX] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[iSLYC] [int] NOT NULL,
	[iSLX] [int] NOT NULL,
	[sGhiChu] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CTPhieuYeuCau]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTPhieuYeuCau](
	[PK_FK_sMaPYC] [varchar](10) NOT NULL,
	[PK_FK_sMaSP] [varchar](10) NOT NULL,
	[iSLCan] [int] NOT NULL,
	[iSLDuyet] [int] NOT NULL,
 CONSTRAINT [PK_CTPhieuYeuCau] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaPYC] ASC,
	[PK_FK_sMaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_HopDongCungCap]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HopDongCungCap](
	[PK_sMaHD] [varchar](10) NOT NULL,
	[FK_sMaNCC] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
	[dNgayBatDau] [datetime] NOT NULL,
	[dNgayketThuc] [datetime] NOT NULL,
 CONSTRAINT [PK_HopDongCungCap] PRIMARY KEY CLUSTERED 
(
	[PK_sMaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[PK_sMaKH] [varchar](10) NOT NULL,
	[sTenKH] [nvarchar](50) NOT NULL,
	[sSDT] [varchar](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[PK_sMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_NhaCungCap]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhaCungCap](
	[PK_sMaNCC] [varchar](10) NOT NULL,
	[sTenNCC] [nvarchar](100) NOT NULL,
	[sDiaChi] [nvarchar](100) NULL,
	[sSDT] [varchar](10) NOT NULL,
	[sSoTK] [varchar](20) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[PK_sMaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[PK_sMaNV] [varchar](10) NOT NULL,
	[FK_sMaTK] [varchar](10) NOT NULL,
	[sHoTen] [nvarchar](50) NOT NULL,
	[dNgaySinh] [datetime] NOT NULL,
	[sCCCD] [varchar](12) NOT NULL,
	[sSDT] [varchar](10) NOT NULL,
	[dNgayVaoLam] [datetime] NOT NULL,
	[sCVu] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[PK_sMaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuChi]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuChi](
	[PK_sMaPChi] [varchar](10) NOT NULL,
	[FK_sMaPN] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
	[sHinhThucTT] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PhieuChi] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuDatHang]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuDatHang](
	[PK_sMaPDH] [varchar](10) NOT NULL,
	[FK_sMaPYC] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
 CONSTRAINT [PK_PhieuDatHang] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuGiaoHang]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuGiaoHang](
	[PK_sMaPGH] [varchar](10) NOT NULL,
	[FK_sMaPDH] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
	[sHoTenGH] [nvarchar](50) NOT NULL,
	[sSDTGH] [varchar](10) NOT NULL,
 CONSTRAINT [PK_PhieuGiaoHang] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuNhapKho]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuNhapKho](
	[PK_sMaPN] [varchar](10) NOT NULL,
	[FK_sMaPGH] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
 CONSTRAINT [PK_PhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuThu]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuThu](
	[PK_sMaPT] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
	[FK_sMaKH] [varchar](10) NOT NULL,
	[sHinhThucTT] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PhieuThu] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuXuatKho]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuXuatKho](
	[PK_sMaPX] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
	[FK_sMaNguoiLay] [varchar](10) NOT NULL,
 CONSTRAINT [PK_PhieuXuatKho] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuYeuCau]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuYeuCau](
	[PK_sMaPYC] [varchar](10) NOT NULL,
	[dTgLap] [datetime] NOT NULL,
	[FK_sMaNguoiLap] [varchar](10) NOT NULL,
 CONSTRAINT [PK_PhieuYeuCau] PRIMARY KEY CLUSTERED 
(
	[PK_sMaPYC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Quyen]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Quyen](
	[PK_sMaQuyen] [varchar](10) NOT NULL,
	[sTenQuyen] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[PK_sMaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_TaiKhoan]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TaiKhoan](
	[PK_sMaTK] [varchar](10) NOT NULL,
	[sTenTK] [varchar](20) NOT NULL,
	[sMK] [varchar](20) NOT NULL,
	[FK_sMaQuyen] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[PK_sMaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ThanhVienHuy]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ThanhVienHuy](
	[PK_FK_MaBBH] [varchar](10) NOT NULL,
	[PK_FK_sMaNguoiHuy] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ThanhVienHuy] PRIMARY KEY CLUSTERED 
(
	[PK_FK_MaBBH] ASC,
	[PK_FK_sMaNguoiHuy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ThanhVienKiemKe]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ThanhVienKiemKe](
	[PK_FK_sMaBBK] [varchar](10) NOT NULL,
	[PK_FK_sMaNguoiKiem] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ThanhVienKiemKe] PRIMARY KEY CLUSTERED 
(
	[PK_FK_sMaBBK] ASC,
	[PK_FK_sMaNguoiKiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_BienBanHuy] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_BienBanKiemKe] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_CTBienBanHuy] ADD  DEFAULT ((1)) FOR [iSL]
GO
ALTER TABLE [dbo].[tbl_CTPhieuDatHang] ADD  DEFAULT ((1)) FOR [iSL]
GO
ALTER TABLE [dbo].[tbl_CTPhieuNhapKho] ADD  DEFAULT ((1)) FOR [iSL]
GO
ALTER TABLE [dbo].[tbl_CTPhieuThu] ADD  DEFAULT ((1)) FOR [iSL]
GO
ALTER TABLE [dbo].[tbl_CTPhieuYeuCau] ADD  DEFAULT ((1)) FOR [iSLCan]
GO
ALTER TABLE [dbo].[tbl_HopDongCungCap] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_PhieuChi] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_PhieuGiaoHang] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_PhieuNhapKho] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_PhieuThu] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_PhieuXuatKho] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_PhieuYeuCau] ADD  DEFAULT (getdate()) FOR [dTgLap]
GO
ALTER TABLE [dbo].[tbl_SanPham] ADD  DEFAULT ((0)) FOR [iSL]
GO
ALTER TABLE [dbo].[tbl_BienBanHuy]  WITH CHECK ADD  CONSTRAINT [FK_BienBanHuy_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_BienBanHuy] CHECK CONSTRAINT [FK_BienBanHuy_NhanVien]
GO
ALTER TABLE [dbo].[tbl_BienBanKiemKe]  WITH CHECK ADD  CONSTRAINT [FK_BienBanKiemKe_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_BienBanKiemKe] CHECK CONSTRAINT [FK_BienBanKiemKe_NhanVien]
GO
ALTER TABLE [dbo].[tbl_CTBienBanHuy]  WITH CHECK ADD  CONSTRAINT [FK_CTBienBanHuy_BienBanHuy] FOREIGN KEY([PK_FK_sMaBBH])
REFERENCES [dbo].[tbl_BienBanHuy] ([PK_sMaBBH])
GO
ALTER TABLE [dbo].[tbl_CTBienBanHuy] CHECK CONSTRAINT [FK_CTBienBanHuy_BienBanHuy]
GO
ALTER TABLE [dbo].[tbl_CTBienBanHuy]  WITH CHECK ADD  CONSTRAINT [FK_CTBienBanHuy_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTBienBanHuy] CHECK CONSTRAINT [FK_CTBienBanHuy_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTBienBanKiemKe]  WITH CHECK ADD  CONSTRAINT [FK_CTBienBanKiemKe_BienBanKiemKe] FOREIGN KEY([PK_FK_sMaBBK])
REFERENCES [dbo].[tbl_BienBanKiemKe] ([PK_sMaBBK])
GO
ALTER TABLE [dbo].[tbl_CTBienBanKiemKe] CHECK CONSTRAINT [FK_CTBienBanKiemKe_BienBanKiemKe]
GO
ALTER TABLE [dbo].[tbl_CTBienBanKiemKe]  WITH CHECK ADD  CONSTRAINT [FK_CTBienBanKiemKe_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTBienBanKiemKe] CHECK CONSTRAINT [FK_CTBienBanKiemKe_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTHopDongCungCap]  WITH CHECK ADD  CONSTRAINT [FK_CTHopDongCungCap_HopDongCungCap] FOREIGN KEY([PK_FK_sMaHD])
REFERENCES [dbo].[tbl_HopDongCungCap] ([PK_sMaHD])
GO
ALTER TABLE [dbo].[tbl_CTHopDongCungCap] CHECK CONSTRAINT [FK_CTHopDongCungCap_HopDongCungCap]
GO
ALTER TABLE [dbo].[tbl_CTHopDongCungCap]  WITH CHECK ADD  CONSTRAINT [FK_CTHopDongCungCap_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTHopDongCungCap] CHECK CONSTRAINT [FK_CTHopDongCungCap_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTPhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuChi_PhieuChi] FOREIGN KEY([PK_FK_sMaPChi])
REFERENCES [dbo].[tbl_PhieuChi] ([PK_sMaPChi])
GO
ALTER TABLE [dbo].[tbl_CTPhieuChi] CHECK CONSTRAINT [FK_CTPhieuChi_PhieuChi]
GO
ALTER TABLE [dbo].[tbl_CTPhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuChi_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTPhieuChi] CHECK CONSTRAINT [FK_CTPhieuChi_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTPhieuDatHang]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuDatHang_PhieuDatHang] FOREIGN KEY([PK_FK_sMaPDH])
REFERENCES [dbo].[tbl_PhieuDatHang] ([PK_sMaPDH])
GO
ALTER TABLE [dbo].[tbl_CTPhieuDatHang] CHECK CONSTRAINT [FK_CTPhieuDatHang_PhieuDatHang]
GO
ALTER TABLE [dbo].[tbl_CTPhieuDatHang]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuDatHang_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTPhieuDatHang] CHECK CONSTRAINT [FK_CTPhieuDatHang_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTPhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuGiao_PhieuGiaoHang] FOREIGN KEY([PK_FK_sMaPGH])
REFERENCES [dbo].[tbl_PhieuGiaoHang] ([PK_sMaPGH])
GO
ALTER TABLE [dbo].[tbl_CTPhieuGiao] CHECK CONSTRAINT [FK_CTPhieuGiao_PhieuGiaoHang]
GO
ALTER TABLE [dbo].[tbl_CTPhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuGiao_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTPhieuGiao] CHECK CONSTRAINT [FK_CTPhieuGiao_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhapKho_PhieuNhapKho] FOREIGN KEY([PK_FK_sMaPN])
REFERENCES [dbo].[tbl_PhieuNhapKho] ([PK_sMaPN])
GO
ALTER TABLE [dbo].[tbl_CTPhieuNhapKho] CHECK CONSTRAINT [FK_CTPhieuNhapKho_PhieuNhapKho]
GO
ALTER TABLE [dbo].[tbl_CTPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhapKho_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTPhieuNhapKho] CHECK CONSTRAINT [FK_CTPhieuNhapKho_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTPhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuThu_PhieuThu] FOREIGN KEY([PK_FK_sMaPT])
REFERENCES [dbo].[tbl_PhieuThu] ([PK_sMaPT])
GO
ALTER TABLE [dbo].[tbl_CTPhieuThu] CHECK CONSTRAINT [FK_CTPhieuThu_PhieuThu]
GO
ALTER TABLE [dbo].[tbl_CTPhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuThu_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTPhieuThu] CHECK CONSTRAINT [FK_CTPhieuThu_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTPhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuXuatKho_PhieuXuatKho] FOREIGN KEY([PK_FK_sMaPX])
REFERENCES [dbo].[tbl_PhieuXuatKho] ([PK_sMaPX])
GO
ALTER TABLE [dbo].[tbl_CTPhieuXuatKho] CHECK CONSTRAINT [FK_CTPhieuXuatKho_PhieuXuatKho]
GO
ALTER TABLE [dbo].[tbl_CTPhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuXuatKho_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTPhieuXuatKho] CHECK CONSTRAINT [FK_CTPhieuXuatKho_SanPham]
GO
ALTER TABLE [dbo].[tbl_CTPhieuYeuCau]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuYeuCau_PhieuYeuCau] FOREIGN KEY([PK_FK_sMaPYC])
REFERENCES [dbo].[tbl_PhieuYeuCau] ([PK_sMaPYC])
GO
ALTER TABLE [dbo].[tbl_CTPhieuYeuCau] CHECK CONSTRAINT [FK_CTPhieuYeuCau_PhieuYeuCau]
GO
ALTER TABLE [dbo].[tbl_CTPhieuYeuCau]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuYeuCau_SanPham] FOREIGN KEY([PK_FK_sMaSP])
REFERENCES [dbo].[tbl_SanPham] ([PK_sMaSP])
GO
ALTER TABLE [dbo].[tbl_CTPhieuYeuCau] CHECK CONSTRAINT [FK_CTPhieuYeuCau_SanPham]
GO
ALTER TABLE [dbo].[tbl_HopDongCungCap]  WITH CHECK ADD  CONSTRAINT [FK_HopDongCungCap_NhaCungCap] FOREIGN KEY([FK_sMaNCC])
REFERENCES [dbo].[tbl_NhaCungCap] ([PK_sMaNCC])
GO
ALTER TABLE [dbo].[tbl_HopDongCungCap] CHECK CONSTRAINT [FK_HopDongCungCap_NhaCungCap]
GO
ALTER TABLE [dbo].[tbl_HopDongCungCap]  WITH CHECK ADD  CONSTRAINT [FK_HopDongCungCap_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_HopDongCungCap] CHECK CONSTRAINT [FK_HopDongCungCap_NhanVien]
GO
ALTER TABLE [dbo].[tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([FK_sMaTK])
REFERENCES [dbo].[tbl_TaiKhoan] ([PK_sMaTK])
GO
ALTER TABLE [dbo].[tbl_NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[tbl_PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_PhieuChi_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuChi] CHECK CONSTRAINT [FK_PhieuChi_NhanVien]
GO
ALTER TABLE [dbo].[tbl_PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_PhieuChi_PhieuNhap] FOREIGN KEY([FK_sMaPN])
REFERENCES [dbo].[tbl_PhieuNhapKho] ([PK_sMaPN])
GO
ALTER TABLE [dbo].[tbl_PhieuChi] CHECK CONSTRAINT [FK_PhieuChi_PhieuNhap]
GO
ALTER TABLE [dbo].[tbl_PhieuDatHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatHang_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuDatHang] CHECK CONSTRAINT [FK_PhieuDatHang_NhanVien]
GO
ALTER TABLE [dbo].[tbl_PhieuDatHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatHang_PhieuYeuCau] FOREIGN KEY([FK_sMaPYC])
REFERENCES [dbo].[tbl_PhieuYeuCau] ([PK_sMaPYC])
GO
ALTER TABLE [dbo].[tbl_PhieuDatHang] CHECK CONSTRAINT [FK_PhieuDatHang_PhieuYeuCau]
GO
ALTER TABLE [dbo].[tbl_PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_NhanVien]
GO
ALTER TABLE [dbo].[tbl_PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_PhieuDatHang] FOREIGN KEY([FK_sMaPDH])
REFERENCES [dbo].[tbl_PhieuDatHang] ([PK_sMaPDH])
GO
ALTER TABLE [dbo].[tbl_PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_PhieuDatHang]
GO
ALTER TABLE [dbo].[tbl_PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_NhanVien]
GO
ALTER TABLE [dbo].[tbl_PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_PhieuGiaoHang] FOREIGN KEY([FK_sMaPGH])
REFERENCES [dbo].[tbl_PhieuGiaoHang] ([PK_sMaPGH])
GO
ALTER TABLE [dbo].[tbl_PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_PhieuGiaoHang]
GO
ALTER TABLE [dbo].[tbl_PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThu_KhachHang] FOREIGN KEY([FK_sMaKH])
REFERENCES [dbo].[tbl_KhachHang] ([PK_sMaKH])
GO
ALTER TABLE [dbo].[tbl_PhieuThu] CHECK CONSTRAINT [FK_PhieuThu_KhachHang]
GO
ALTER TABLE [dbo].[tbl_PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThu_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuThu] CHECK CONSTRAINT [FK_PhieuThu_NhanVien]
GO
ALTER TABLE [dbo].[tbl_PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_NhanVienLap] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_NhanVienLap]
GO
ALTER TABLE [dbo].[tbl_PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_NhanVienLay] FOREIGN KEY([FK_sMaNguoiLay])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_NhanVienLay]
GO
ALTER TABLE [dbo].[tbl_PhieuYeuCau]  WITH CHECK ADD  CONSTRAINT [FK_PhieuYeuCau_NhanVien] FOREIGN KEY([FK_sMaNguoiLap])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuYeuCau] CHECK CONSTRAINT [FK_PhieuYeuCau_NhanVien]
GO
ALTER TABLE [dbo].[tbl_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([FK_sMaLoai])
REFERENCES [dbo].[tbl_LoaiSanPham] ([PK_sMaLoai])
GO
ALTER TABLE [dbo].[tbl_SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[tbl_TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_Quyen] FOREIGN KEY([FK_sMaQuyen])
REFERENCES [dbo].[tbl_Quyen] ([PK_sMaQuyen])
GO
ALTER TABLE [dbo].[tbl_TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_Quyen]
GO
ALTER TABLE [dbo].[tbl_ThanhVienHuy]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVienHuy_BienBanHuy] FOREIGN KEY([PK_FK_MaBBH])
REFERENCES [dbo].[tbl_BienBanHuy] ([PK_sMaBBH])
GO
ALTER TABLE [dbo].[tbl_ThanhVienHuy] CHECK CONSTRAINT [FK_ThanhVienHuy_BienBanHuy]
GO
ALTER TABLE [dbo].[tbl_ThanhVienHuy]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVienHuy_NhanVien] FOREIGN KEY([PK_FK_sMaNguoiHuy])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_ThanhVienHuy] CHECK CONSTRAINT [FK_ThanhVienHuy_NhanVien]
GO
ALTER TABLE [dbo].[tbl_ThanhVienKiemKe]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVienKiemKe_BienBanKiemKe] FOREIGN KEY([PK_FK_sMaBBK])
REFERENCES [dbo].[tbl_BienBanKiemKe] ([PK_sMaBBK])
GO
ALTER TABLE [dbo].[tbl_ThanhVienKiemKe] CHECK CONSTRAINT [FK_ThanhVienKiemKe_BienBanKiemKe]
GO
ALTER TABLE [dbo].[tbl_ThanhVienKiemKe]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVienKiemKe_NhanVien] FOREIGN KEY([PK_FK_sMaNguoiKiem])
REFERENCES [dbo].[tbl_NhanVien] ([PK_sMaNV])
GO
ALTER TABLE [dbo].[tbl_ThanhVienKiemKe] CHECK CONSTRAINT [FK_ThanhVienKiemKe_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaCTPhieuThu]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SuaCTPhieuThu]
    @sMaPT VARCHAR(10),
    @sMaSP VARCHAR(10),
    @iSL INT
AS
BEGIN
    UPDATE tbl_CTPhieuThu
    SET iSL = @iSL
    WHERE PK_FK_sMaPT = @sMaPT AND PK_FK_sMaSP = @sMaSP
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhanVien]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SuaNhanVien]
    @MaNV VARCHAR(10),
    @MaTK VARCHAR(10),
    @HoTen NVARCHAR(50),
    @NgaySinh DATETIME,
    @CCCD VARCHAR(12),
    @SDT VARCHAR(10),
    @NgayVaoLam DATETIME,
    @ChucVu NVARCHAR(20)
AS
BEGIN
    UPDATE tbl_NhanVien
    SET FK_sMaTK = @MaTK, sHoTen = @HoTen, dNgaySinh = @NgaySinh, sCCCD = @CCCD, sSDT = @SDT, dNgayVaoLam = @NgayVaoLam, sCVu = @ChucVu
    WHERE PK_sMaNV = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaPhieuThu]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SuaPhieuThu]
    @sMaPT VARCHAR(10),
    @dTgLap DATETIME,
    @sMaNV VARCHAR(10),
    @sMaKH VARCHAR(10),
    @sHinhThucTT NVARCHAR(20)
AS
BEGIN
    UPDATE tbl_PhieuThu
    SET dTgLap = @dTgLap,
        FK_sMaNguoiLap = @sMaNV,
        FK_sMaKH = @sMaKH,
        sHinhThucTT = @sHinhThucTT
    WHERE PK_sMaPT = @sMaPT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaSanPham]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaSanPham] (@MaSP VARCHAR(10), @TenSP NVARCHAR(100), @DonViTinh NVARCHAR(10), @HanDung NVARCHAR(10), 
						   @DonGiaBan FLOAT, @MaLoai VARCHAR(10))
AS
BEGIN
    UPDATE dbo.tbl_SanPham
    SET sTenSP = @TenSP,
        sDonViTinh = @DonViTinh,
        sHanDung = @HanDung,
        fDonGiaBan = @DonGiaBan,
        FK_sMaLoai = @MaLoai
    WHERE PK_sMaSP = @MaSP;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaTaiKhoan]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SuaTaiKhoan]
    @maTK VARCHAR(10),
    @tenTK VARCHAR(20),
    @matKhau VARCHAR(20),
    @maQuyen VARCHAR(10)
AS
BEGIN
    UPDATE tbl_TaiKhoan
    SET sTenTK = @tenTK,
        sMK = @matKhau,
        FK_sMaQuyen = @maQuyen
    WHERE PK_sMaTK = @maTK
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemCTPhieuThu]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemCTPhieuThu]
    @sMaPT VARCHAR(10),
    @sMaSP VARCHAR(10),
    @iSL INT
AS
BEGIN
    INSERT INTO tbl_CTPhieuThu(PK_FK_sMaPT, PK_FK_sMaSP, iSL)
    VALUES(@sMaPT, @sMaSP, @iSL)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanVien]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemNhanVien] 
    @MaNV VARCHAR(10),
    @MaTK VARCHAR(10),
    @HoTen NVARCHAR(50),
    @NgaySinh DATETIME,
    @CCCD VARCHAR(12),
    @SDT VARCHAR(10),
    @NgayVaoLam DATETIME,
    @ChucVu NVARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_NhanVien(PK_sMaNV, FK_sMaTK, sHoTen, dNgaySinh, sCCCD, sSDT, dNgayVaoLam, sCVu)
    VALUES(@MaNV, @MaTK, @HoTen, @NgaySinh, @CCCD, @SDT, @NgayVaoLam, @ChucVu)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemPhieuThu]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemPhieuThu]
    @sMaPT VARCHAR(10),
    @dTgLap DATETIME,
    @sMaNV VARCHAR(10),
    @sMaKH VARCHAR(10),
    @sHinhThucTT NVARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_PhieuThu(PK_sMaPT, dTgLap, FK_sMaNguoiLap, FK_sMaKH, sHinhThucTT)
    VALUES(@sMaPT, @dTgLap, @sMaNV, @sMaKH, @sHinhThucTT)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSanPham]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemSanPham] (@MaSP VARCHAR(10), @TenSP NVARCHAR(100), @DonViTinh NVARCHAR(10), 
							@HanDung NVARCHAR(10), @DonGiaBan FLOAT, @MaLoai VARCHAR(10))
AS
BEGIN
    INSERT INTO dbo.tbl_SanPham (PK_sMaSP, sTenSP, sDonViTinh, sHanDung, iSL, fDonGiaBan, FK_sMaLoai)
    VALUES (@MaSP, @TenSP, @DonViTinh, @HanDung, 0, @DonGiaBan, @MaLoai)
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemTaiKhoan]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ThemTaiKhoan]
    @PK_sMaTK VARCHAR(10),
    @sTenTK VARCHAR(20),
    @sMK VARCHAR(20),
    @FK_sMaQuyen VARCHAR(10)
AS
BEGIN
    INSERT INTO tbl_TaiKhoan (PK_sMaTK, sTenTK, sMK, FK_sMaQuyen)
    VALUES (@PK_sMaTK, @sTenTK, @sMK, @FK_sMaQuyen)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaCTPhieuThu]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaCTPhieuThu]
    @sMaPT VARCHAR(10),
    @sMaSP VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_CTPhieuThu
    WHERE PK_FK_sMaPT = @sMaPT AND PK_FK_sMaSP = @sMaSP
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaPhieuThu]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaPhieuThu]
    @sMaPT VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_CTPhieuThu
    WHERE PK_FK_sMaPT = @sMaPT
    
    DELETE FROM tbl_PhieuThu
    WHERE PK_sMaPT = @sMaPT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSanPham]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaSanPham] @MaSP VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_SanPham WHERE PK_sMaSP = @MaSP
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaTaiKhoan]    Script Date: 2023/03/15 3:55:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaTaiKhoan] @MaTK VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_TaiKhoan WHERE PK_sMaTK = @MaTK;
END
GO
USE [master]
GO
ALTER DATABASE [db_QuanLyHeThongNhaThuocLongChau] SET  READ_WRITE 
GO
