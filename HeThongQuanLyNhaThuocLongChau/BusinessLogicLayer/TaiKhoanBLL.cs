using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return taiKhoanDAL.login(tenTK, matKhau);
        }

        public bool checkPassword(string maTK, string matKhau)
        {
            return taiKhoanDAL.checkPassword(maTK, matKhau);
        }

        public bool checkStatus(string tenTK)
        {
            return taiKhoanDAL.checkStatus(tenTK);
        }

        public bool changePassword(string maTK, string matKhau)
        {
            return taiKhoanDAL.changePassword(maTK, matKhau);
        }
    }
}
