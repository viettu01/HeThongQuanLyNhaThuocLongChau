/* ----------------------------------------Loại sản phẩm---------------------------------------- */
--Thủ tục thêm loại sản phẩm
GO
CREATE PROC sp_ThemLoaiSanPham (@sMaLoai NVARCHAR(10), @sTenLoai NVARCHAR(100))
AS
BEGIN
    INSERT INTO dbo.tbl_LoaiSanPham (PK_sMaLoai, sTenLoai) VALUES (@sMaLoai, @sTenLoai)
END

--Thủ tục sửa loại sản phẩm
GO
CREATE PROC sp_SuaLoaiSanPham (@MaLoai NVARCHAR(10), @TenLoai NVARCHAR(100))
AS
BEGIN
    UPDATE dbo.tbl_LoaiSanPham
	SET sTenLoai = @TenLoai
	WHERE PK_sMaLoai = @MaLoai
END

--Thủ tục xóa loại sản phẩm
GO
CREATE PROC sp_XoaLoaiSanPham (@MaLoai NVARCHAR(10))
AS
BEGIN
	DELETE FROM dbo.tbl_LoaiSanPham WHERE PK_sMaLoai = @MaLoai
END

/* ----------------------------------------Sản phẩm---------------------------------------- */
--Thủ tục thêm sản phẩm
GO
CREATE PROC sp_ThemSanPham (@MaSP VARCHAR(10), @TenSP NVARCHAR(100), @DonViTinh NVARCHAR(10), 
							@HanDung NVARCHAR(10), @DonGiaBan FLOAT, @MaLoai VARCHAR(10))
AS
BEGIN
    INSERT INTO dbo.tbl_SanPham (PK_sMaSP, sTenSP, sDonViTinh, sHanDung, iSL, fDonGiaBan, FK_sMaLoai)
    VALUES (@MaSP, @TenSP, @DonViTinh, @HanDung, 0, @DonGiaBan, @MaLoai)
END;

--Thủ tục sửa sản phẩm
GO
CREATE PROC sp_SuaSanPham (@MaSP VARCHAR(10), @TenSP NVARCHAR(100), @DonViTinh NVARCHAR(10), @HanDung NVARCHAR(10), 
							@SoLuong INT, @DonGiaBan FLOAT, @MaLoai VARCHAR(10))
AS
BEGIN
    UPDATE dbo.tbl_SanPham
    SET sTenSP = @TenSP,
        sDonViTinh = @DonViTinh,
        sHanDung = @HanDung,
        iSL = @SoLuong,
        fDonGiaBan = @DonGiaBan,
        FK_sMaLoai = @MaLoai
    WHERE PK_sMaSP = @MaSP;
END

--Thủ tục xóa sản phẩm
GO
CREATE PROC sp_XoaSanPham @MaSP VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_SanPham WHERE PK_sMaSP = @MaSP
END

/* ----------------------------------------Nhà cung cấp---------------------------------------- */
--Thủ tục thêm nhà cung cấp
GO
CREATE PROCEDURE sp_ThemNhaCungCap
    @MaNCC VARCHAR(10),
    @TenNCC NVARCHAR(100),
    @DiaChi NVARCHAR(100),
    @SDT VARCHAR(10),
    @SoTK VARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_NhaCungCap (PK_sMaNCC, sTenNCC, sDiaChi, sSDT, sSoTK)
    VALUES (@MaNCC, @TenNCC, @DiaChi, @SDT, @SoTK)
END

--Thủ tục sửa nhà cung cấp
GO
CREATE PROCEDURE sp_SuaNhaCungCap
    @MaNCC VARCHAR(10),
    @TenNCC NVARCHAR(100),
    @DiaChi NVARCHAR(100),
    @SDT VARCHAR(10),
    @SoTK VARCHAR(20)
AS
BEGIN
    UPDATE tbl_NhaCungCap
    SET sTenNCC = @TenNCC,
        sDiaChi = @DiaChi,
        sSDT = @SDT,
        sSoTK = @SoTK
    WHERE PK_sMaNCC = @MaNCC
END

--Thủ tục xóa nhà cung cấp
GO
CREATE PROCEDURE sp_XoaNhaCungCap @MaNCC VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_NhaCungCap
    WHERE PK_sMaNCC = @MaNCC;
END

/* ----------------------------------------Khách hàng---------------------------------------- */
--Thủ tục thêm khách hàng
GO
CREATE PROCEDURE sp_ThemKhachHang
    @MaKH varchar(10),
    @TenKH nvarchar(50),
    @SDT varchar(10)
AS
BEGIN
    INSERT INTO tbl_KhachHang(PK_sMaKH, sTenKH, sSDT)
    VALUES (@MaKH, @TenKH, @SDT)
END


--Thủ tục sửa khách hàng
GO
CREATE PROCEDURE sp_SuaKhachHang
    @sMaKH VARCHAR(10),
    @sTenKH NVARCHAR(50),
    @sSDT VARCHAR(10)
AS
BEGIN
    UPDATE tbl_KhachHang
    SET sTenKH = @sTenKH,
        sSDT = @sSDT
    WHERE PK_sMaKH = @sMaKH
END


--Thủ tục xóa khách hàng
GO
CREATE PROCEDURE sp_XoaKhachHang
    @MaKH VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_KhachHang WHERE PK_sMaKH = @MaKH
END

/* ----------------------------------------Quyền---------------------------------------- */
--Thủ tục thêm quyền
GO
CREATE PROCEDURE sp_ThemQuyen
    @MaQuyen VARCHAR(10),
    @TenQuyen NVARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_Quyen (PK_sMaQuyen, sTenQuyen)
    VALUES (@MaQuyen, @TenQuyen);
END

--Thủ tục sửa quyền
GO
CREATE PROCEDURE sp_SuaQuyen
    @MaQuyen VARCHAR(10), @TenQuyen NVARCHAR(20)
AS
BEGIN
    UPDATE tbl_Quyen
    SET sTenQuyen = @TenQuyen
    WHERE PK_sMaQuyen = @MaQuyen;
END

--Thủ tục xóa quyền
GO
CREATE PROCEDURE sp_XoaQuyen @MaQuyen VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_Quyen WHERE PK_sMaQuyen = @MaQuyen
END

/* ----------------------------------------Tài khoản---------------------------------------- */
--Thủ tục thêm tài khoản
GO
CREATE PROCEDURE sp_ThemTaiKhoan
    @PK_sMaTK VARCHAR(10),
    @sTenTK VARCHAR(20),
    @sMK VARCHAR(20),
    @FK_sMaQuyen VARCHAR(10)
AS
BEGIN
    INSERT INTO tbl_TaiKhoan (PK_sMaTK, sTenTK, sMK, FK_sMaQuyen)
    VALUES (@PK_sMaTK, @sTenTK, @sMK, @FK_sMaQuyen)
END

--Thủ tục sửa tài khoản
GO
CREATE PROCEDURE sp_SuaTaiKhoan
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

--Thủ tục xóa tài khoản
GO
CREATE PROCEDURE sp_XoaTaiKhoan @MaTK VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_TaiKhoan WHERE PK_sMaTK = @MaTK;
END

/* ----------------------------------------Nhân viên---------------------------------------- */
--Thủ tục thêm nhân viên
GO
CREATE PROCEDURE sp_ThemNhanVien 
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

--Thủ tục sửa nhân viên
GO
CREATE PROCEDURE sp_SuaNhanVien
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

--Thủ tục xóa nhân viên
GO
CREATE PROCEDURE sp_XoaNhanVien
    @MaNV VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_NhanVien
    WHERE PK_sMaNV = @MaNV
END

/* ----------------------------------------Phiếu yêu cầu---------------------------------------- */
--Thủ tục thêm phiếu yêu cầu
GO
CREATE PROCEDURE sp_ThemPhieuYeuCau
	@sMaPYC VARCHAR(10),
	@sMaNguoiLap VARCHAR(10)
AS
BEGIN
	INSERT INTO tbl_PhieuYeuCau(PK_sMaPYC, FK_sMaNguoiLap)
	VALUES(@sMaPYC, @sMaNguoiLap)
END

--Thủ tục sửa phiếu yêu cầu
GO
CREATE PROCEDURE sp_SuaPhieuYeuCau
	@sMaPYC VARCHAR(10),
	@sMaNguoiLap VARCHAR(10)
AS
BEGIN
	UPDATE tbl_PhieuYeuCau
	SET FK_sMaNguoiLap = @sMaNguoiLap
	WHERE PK_sMaPYC = @sMaPYC
END

--Thủ tục xóa phiếu yêu cầu
GO
CREATE PROCEDURE sp_XoaPhieuYeuCau
	@sMaPYC VARCHAR(10)
AS
BEGIN
	DELETE FROM tbl_PhieuYeuCau
	WHERE PK_sMaPYC = @sMaPYC
END

/* ----------------------------------------Chi tiết phiếu yêu cầu---------------------------------------- */
--Thủ tục thêm chi tiết phiếu yêu cầu
GO
CREATE PROCEDURE sp_ThemCTPhieuYeuCau
    @sMaPYC VARCHAR(10),
    @sMaSP VARCHAR(10),
    @iSLCan INT,
    @iSLDuyet INT
AS
BEGIN
    INSERT INTO tbl_CTPhieuYeuCau (PK_FK_sMaPYC, PK_FK_sMaSP, iSLCan, iSLDuyet)
    VALUES (@sMaPYC, @sMaSP, @iSLCan, @iSLDuyet);
END

--Thủ tục sửa chi tiết phiếu yêu cầu
GO
CREATE PROCEDURE sp_SuaCTPhieuYeuCau
    @sMaPYC VARCHAR(10),
    @sMaSP VARCHAR(10),
    @iSLCan INT,
    @iSLDuyet INT
AS
BEGIN
    UPDATE tbl_CTPhieuYeuCau
    SET iSLCan = @iSLCan,
        iSLDuyet = @iSLDuyet
    WHERE PK_FK_sMaPYC = @sMaPYC AND PK_FK_sMaSP = @sMaSP;
END

--Thủ tục xóa chi tiết phiếu yêu cầu
GO
CREATE PROCEDURE sp_XoaCTPhieuYeuCau
    @sMaPYC VARCHAR(10),
    @sMaSP VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_CTPhieuYeuCau
    WHERE PK_FK_sMaPYC = @sMaPYC AND PK_FK_sMaSP = @sMaSP;
END

/* ----------------------------------------Phiếu đặt hàng---------------------------------------- */
--Thủ tục thêm phiếu đặt hàng
GO
CREATE PROCEDURE sp_ThemPhieuDatHang 
    @MaPDH VARCHAR(10),
    @MaPYC VARCHAR(10),
    @NgayLap DATETIME,
    @MaNV VARCHAR(10)
AS
BEGIN
    INSERT INTO tbl_PhieuDatHang(PK_sMaPDH, FK_sMaPYC, dTgLap, FK_sMaNguoiLap)
    VALUES(@MaPDH, @MaPYC, @NgayLap, @MaNV)
END

--Thủ tục sửa phiếu đặt hàng
GO
CREATE PROCEDURE sp_SuaPhieuDatHang 
    @MaPDH VARCHAR(10),
    @MaPYC VARCHAR(10),
    @NgayLap DATETIME,
    @MaNV VARCHAR(10)
AS
BEGIN
    UPDATE tbl_PhieuDatHang
    SET FK_sMaPYC = @MaPYC, dTgLap = @NgayLap, FK_sMaNguoiLap = @MaNV
    WHERE PK_sMaPDH = @MaPDH
END

--Thủ tục xóa phiếu đặt hàng
GO
CREATE PROCEDURE sp_XoaPhieuDatHang 
    @MaPDH VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_PhieuDatHang
    WHERE PK_sMaPDH = @MaPDH
END

/* ----------------------------------------Chi tiết phiếu đặt hàng---------------------------------------- */
--Thủ tục thêm Chi tiết phiếu đặt hàng
GO
CREATE PROCEDURE sp_ThemCTPhieuDatHang
    @MaPDH VARCHAR(10),
    @MaSP VARCHAR(10),
    @SoLuong INT
AS
BEGIN
    INSERT INTO tbl_CTPhieuDatHang (PK_FK_sMaPDH, PK_FK_sMaSP, iSL)
    VALUES (@MaPDH, @MaSP, @SoLuong)
END

--Thủ tục sửa chi tiết phiếu đặt hàng
GO
CREATE PROCEDURE sp_SuaCTPhieuDatHang
    @MaPDH VARCHAR(10),
    @MaSP VARCHAR(10),
    @SoLuong INT
AS
BEGIN
    UPDATE tbl_CTPhieuDatHang
    SET iSL = @SoLuong
    WHERE PK_FK_sMaPDH = @MaPDH AND PK_FK_sMaSP = @MaSP
END

--Thủ tục xóa chi tiết phiếu đặt hàng
GO
CREATE PROCEDURE sp_XoaCTPhieuDatHang
    @MaPDH VARCHAR(10),
    @MaSP VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_CTPhieuDatHang
    WHERE PK_FK_sMaPDH = @MaPDH AND PK_FK_sMaSP = @MaSP
END

/* ----------------------------------------Phiếu Thu---------------------------------------- */
--Thủ tục thêm phiếu thu
GO
CREATE PROCEDURE sp_ThemPhieuThu
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

--Thủ tục sửa phiếu thu
GO
CREATE PROCEDURE sp_SuaPhieuThu
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

--Thủ tục xóa phiếu thu
GO
CREATE PROCEDURE sp_XoaPhieuThu
    @sMaPT VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_CTPhieuThu
    WHERE PK_FK_sMaPT = @sMaPT
    
    DELETE FROM tbl_PhieuThu
    WHERE PK_sMaPT = @sMaPT
END

/* ----------------------------------------Chi tiết phiếu Thu---------------------------------------- */
--Thủ tục thêm phiếu thu
GO
CREATE PROCEDURE sp_ThemCTPhieuThu
    @sMaPT VARCHAR(10),
    @sMaSP VARCHAR(10),
    @iSL INT
AS
BEGIN
    INSERT INTO tbl_CTPhieuThu(PK_FK_sMaPT, PK_FK_sMaSP, iSL)
    VALUES(@sMaPT, @sMaSP, @iSL)
END

--Thủ tục sửa phiếu thu
GO
CREATE PROCEDURE sp_SuaCTPhieuThu
    @sMaPT VARCHAR(10),
    @sMaSP VARCHAR(10),
    @iSL INT
AS
BEGIN
    UPDATE tbl_CTPhieuThu
    SET iSL = @iSL
    WHERE PK_FK_sMaPT = @sMaPT AND PK_FK_sMaSP = @sMaSP
END

--Thủ tục xóa phiếu thu
GO
CREATE PROCEDURE sp_XoaCTPhieuThu
    @sMaPT VARCHAR(10),
    @sMaSP VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_CTPhieuThu
    WHERE PK_FK_sMaPT = @sMaPT AND PK_FK_sMaSP = @sMaSP
END