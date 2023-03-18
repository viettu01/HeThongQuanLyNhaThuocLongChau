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

        public int login(string tenTK, string matKhau)
        {
            return taiKhoanDAL.login(tenTK, matKhau);
        }
    }
}
