GO
CREATE VIEW vv_Quyen
AS
	SELECT PK_sMaQuyen AS [Mã quyền], sTenQuyen AS [Tên quyền]
	FROM dbo.tbl_Quyen