GO
CREATE VIEW vv_NhaCungCap
AS
	SELECT PK_sMaNCC AS [Mã NCC], sTenNCC AS [Tên NCC], sDiaChi AS [Địa chỉ], sSDT AS [SĐT], sSoTK AS [Số TK]
	FROM dbo.tbl_NhaCungCap