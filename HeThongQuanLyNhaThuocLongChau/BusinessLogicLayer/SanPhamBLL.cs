using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.Model
{
    public class SanPhamBLL
    {
        SanPhamDAL sanPhamDAL = new SanPhamDAL();

        public DataTable findAll()
        {
            return sanPhamDAL.findAll();
        }

        public bool insert(string maSP, string tenSP, string donViTinh, string hanDung, double donGiaBan, string maLoai, string maNCC)
        {
            return sanPhamDAL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
        }

        public bool update(string maSP, string tenSP, string donViTinh, string hanDung, double donGiaBan, string maLoai, string maNCC)
        {
            return sanPhamDAL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
        }

        public bool deleteById(string maSP)
        {
            return sanPhamDAL.deleteById(maSP);
        }

        public DataTable search(string maSP, string tenSP, string donViTinh, string hanDung, string donGiaBan, string tenLoai, string tenNCC)
        {
            return sanPhamDAL.search(maSP, tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC);
        }

        public DataTable searchById(String maSP)
        {
            return sanPhamDAL.searchById(maSP);
        }
    }
}
