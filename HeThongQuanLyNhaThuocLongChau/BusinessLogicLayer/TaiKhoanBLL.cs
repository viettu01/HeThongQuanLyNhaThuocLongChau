using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Data;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public bool insert(string maTK, string tenTK, string matKhau, string maQuyen)
        {
            return taiKhoanDAL.insert(maTK, tenTK, matKhau, maQuyen);
        }

        public bool update(string maTK, string tenTK, string matKhau, string maQuyen)
        {
            return taiKhoanDAL.update(maTK, tenTK, matKhau, maQuyen);
        }

        public int login(string tenTK, string matKhau)
        {
            using (DataTable dt = taiKhoanDAL.login(tenTK, matKhau))
            {
                if (dt.Rows.Count == 0)
                    return 0; //Tên đăng nhập không tồn tại
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (String.Equals(dr["Mật khẩu"].ToString(), matKhau, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Program.maTK = dr["Mã TK"].ToString();
                            Program.maQuyen = dr["Mã Quyền"].ToString();
                            Program.tenTK = dr["Tên tài khoản"].ToString();
                            Program.tenNV = dr["Tên NV"].ToString();
                            return 1; //Đúng mật khẩu và tên đăng nhập
                        }
                        else
                            return 2; //Đúng tên dăng nhập nhưng Sai mật khẩu 
                    }
                }
            }
            return -1;
        }

        public bool checkPassword(string maTK, string matKhau)
        {
            using (DataTable dt = taiKhoanDAL.checkPassword(maTK, matKhau))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (String.Equals(dr["Mật khẩu"].ToString(), matKhau, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool changePassword(string maTK, string matKhau)
        {
            return taiKhoanDAL.changePassword(maTK, matKhau);
        }
    }
}
