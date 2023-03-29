USE [db_QuanLyHeThongNhaThuocLongChau]
GO
ALTER PROC [dbo].[sp_DoiMatKhau] (@tenTK VARCHAR(20), @MK VARCHAR(20))
AS
BEGIN
    UPDATE dbo.tbl_TaiKhoan 
	SET sMK = @MK
	WHERE sTenTK = @tenTK
END