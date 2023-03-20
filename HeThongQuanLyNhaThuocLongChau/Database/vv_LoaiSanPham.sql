GO
CREATE VIEW vv_LoaiSanPham
AS
	SELECT PK_sMaLoai AS [Mã loại], sTenLoai AS [Tên loại]
	FROM dbo.tbl_LoaiSanPham