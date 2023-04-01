CREATE PROC sp_ShowViewSanPham
AS
BEGIN
	SELECT * FROM vv_SanPham
END

GO
CREATE PROC sp_TimKiemSanPham (@TenSP NVARCHAR(100), @DonViTinh NVARCHAR(10), 
							  @HanDung NVARCHAR(10), @DonGiaBan VARCHAR(MAX),
							  @TenLoai NVARCHAR(100), @TenNCC NVARCHAR(100))
AS
BEGIN
	SELECT * 
	FROM dbo.vv_SanPham
	WHERE (@TenSP IS NULL OR [Tên SP] LIKE '%' + @TenSP + '%')
			AND (@DonViTinh IS NULL OR [Đơn vị tính] LIKE '%' + @DonViTinh + '%')
			AND (@HanDung IS NULL OR [Hạn dùng] LIKE '%' + @HanDung + '%')
			AND (@DonGiaBan IS NULL OR @DonGiaBan = '' OR [Giá bán] = CONVERT(FLOAT, @DonGiaBan))
			AND (@TenLoai IS NULL OR [Loại] LIKE '%' + @TenLoai + '%')
			AND (@TenNCC IS NULL OR [Tên NCC] LIKE '%' + @TenNCC + '%')
END