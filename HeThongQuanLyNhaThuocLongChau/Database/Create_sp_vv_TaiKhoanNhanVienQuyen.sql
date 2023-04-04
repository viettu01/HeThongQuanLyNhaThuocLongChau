CREATE PROC sp_TimKiemTenTaiKhoan (@TenTK VARCHAR(10))
AS
BEGIN
    SELECT * FROM vv_TaiKhoanNhanVienQuyen WHERE [Tên tài khoản] = @TenTK
END