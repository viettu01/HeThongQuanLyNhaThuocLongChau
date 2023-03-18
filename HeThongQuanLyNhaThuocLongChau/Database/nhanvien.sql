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


/*******Sửa****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaNhanVien] (@MaNV VARCHAR(100), @MaTK NVARCHAR(100), @TenNV NVARCHAR(100), @NgaySinh DateTime, @CCCD NVARCHAR(10), @SDT NVARCHAR(10),
						   @NgayVaoLam DateTime, @ChucVu VARCHAR(100))
AS
BEGIN
    UPDATE dbo.tbl_NhanVien
    SET FK_sMaTK = @MaTK,
        sHoTen = @TenNV,
        dNgaySinh = @NgaySinh,
        sCCCD = @CCCD,
        sSDT = @SDT,
        dNgayVaoLam = @NgayVaoLam,
        sCVu = @ChucVu
    WHERE PK_sMaNV= @MaNV;
END
GO


/*******Xóa**/

Create PROCEDURE [dbo].[sp_XoaNhanVien]
    @MaNV VARCHAR(10)
AS
BEGIN
    DELETE FROM tbl_NhanVien
    WHERE PK_sMaNV = @MaNV
END


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vv_NhanVien]
AS
	SELECT PK_sMaNV AS [Mã NV], FK_sMaTK AS [TK NV], sHoTen AS [Họ Tên], dNgaySinh AS [Ngày sinh], sCCCD AS [CCCD], sSDT AS [SĐT], dNgayVaoLam AS [Ngày vào làm],  sCVu AS [Chức vụ]
	FROM tbl_NhanVien
GO


SELECT * FROM tbl_NhanVien