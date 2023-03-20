using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public DataTable findAll()
        {
            return nhanVienDAL.findAll();
        }

        public bool insert(string maNV, string tenNV, DateTime ngaySinh,
                            string cccd, string sdt, DateTime ngayVaoLam, string chucvu,
                            string maTK, string tenTK, string matKhau, string maQuyen)
        {
            return nhanVienDAL.insert(maNV, tenNV, ngaySinh, cccd, sdt, ngayVaoLam, chucvu, maTK, tenTK, matKhau, maQuyen);
        }

        public bool update(string maNV, string tenNV, DateTime ngaySinh, string cccd,
                            string sdt, DateTime ngayVaoLam, string chucvu,
                            string tenTK, string matKhau, string maQuyen)
        {
            return nhanVienDAL.update(maNV, tenNV, ngaySinh, cccd, sdt, ngayVaoLam, chucvu, tenTK, matKhau, maQuyen);
        }

        public bool changeStatus(string maNV, int trangThai)
        {
            return nhanVienDAL.changeStatus(maNV, trangThai);
        }

        public DataTable search(string tenNV, string ngaySinh, string sdt, string cccd, string ngayVaoLam, string chucvu, string tenTK, string tenQuyen)
        {
            return nhanVienDAL.search(tenNV, ngaySinh, sdt, cccd, ngayVaoLam, chucvu, tenTK, tenQuyen);
        }
    }
}
