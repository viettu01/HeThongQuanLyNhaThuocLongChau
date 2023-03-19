--sp_Khachhang
--vw
CREATE VIEW [dbo].[vv_Khachhang]
AS
	SELECT PK_sMaKH AS [Mã KH], sTenKH AS [Tên KH], sSDT AS [SĐT]
	FROM tbl_KhachHang
GO
--sp_them
CREATE PROCEDURE [dbo].[sp_ThemKhachHang] (@PK_sMaKH VARCHAR(10),@sTenKH VARCHAR(50),@sSDT NVARCHAR(10))
AS
BEGIN
    INSERT INTO tbl_KhachHang
    VALUES(@PK_sMaKH, @sTenKH, @sSDT)
END

GO
--sp_sua
create proc [dbo].[sp_SuaTTKhachHang](@PK_sMaKH VARCHAR(10),@sTenKH VARCHAR(50),@sSDT VARCHAR(10))
as
BEGIN
    UPDATE tbl_KhachHang
    SET sTenKH=@sTenKH,
		sSDT=@sSDT
    WHERE @PK_sMaKH=PK_sMaKH
END

GO
--sp_xoa
Create PROCEDURE [dbo].[sp_XoaKhachhang]
    @PK_sMaKH VARCHAR(10)
AS
BEGIN
	DELETE FROM tbl_PhieuThu
    WHERE  FK_sMaKH= @PK_sMaKH

    DELETE FROM tbl_KhachHang
    WHERE PK_sMaKH = @PK_sMaKH
END