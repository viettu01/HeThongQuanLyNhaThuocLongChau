CREATE VIEW vv_TaiKhoanNhanVienQuyen
AS
	SELECT a.PK_sMaNV AS [Mã NV], a.sHoTen AS [Tên NV], a.dNgaySinh AS [Ngày sinh], a.sCCCD AS [CCCD],
			a.sSDT AS [SĐT], a.dNgayVaoLam AS [Ngày vào làm], a.sCVu AS [Chức vụ], a.bTrangThai AS [Trạng thái],
			a.FK_sMaTK AS [Mã TK], b.sTenTK AS [Tên tài khoản], b.sMK AS [Mật khẩu], b.FK_sMaQuyen AS [Mã quyền]
	FROM dbo.tbl_NhanVien a 
			JOIN dbo.tbl_TaiKhoan b ON b.PK_sMaTK = a.FK_sMaTK
			JOIN dbo.tbl_Quyen c ON c.PK_sMaQuyen = b.FK_sMaQuyen