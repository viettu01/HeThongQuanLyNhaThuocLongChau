--Thêm trạng thái vào một số bảng
ALTER TABLE dbo.tbl_PhieuDatHang ADD bTrangThai BIT NOT NULL
ALTER TABLE dbo.tbl_PhieuYeuCau ADD bTrangThai BIT NOT NULL
ALTER TABLE dbo.tbl_BienBanHuy ADD bTrangThai BIT NOT NULL
ALTER TABLE dbo.tbl_BienBanKiemKe ADD bTrangThai BIT NOT NULL
ALTER TABLE dbo.tbl_NhanVien ADD bTrangThai BIT NOT NULL

--Thêm mã nhà cung cấp vào bẳng sản phẩm
ALTER TABLE dbo.tbl_SanPham ADD sNhaCungCap VARCHAR(10) NOT NULL CONSTRAINT FK_SanPham_NhaCungCap FOREIGN KEY REFERENCES dbo.tbl_NhaCungCap(PK_sMaNCC)