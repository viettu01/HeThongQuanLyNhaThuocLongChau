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

        public bool insert(string maSP, string tenSP, string donViTinh, string hanDung, double donGiaBan, string maLoai)
        {
            return sanPhamDAL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai);
        }

        public bool update(string maSP, string tenSP, string donViTinh, string hanDung, double donGiaBan, string maLoai)
        {
            return sanPhamDAL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai);
        }

        public bool deleteById(string maSP)
        {
            return sanPhamDAL.deleteById(maSP);
        }

        public DataTable search(string maSP, string tenSP, string donViTinh, string hanDung, string soLuongTon, string donGiaBan, string tenLoai)
        {
            return sanPhamDAL.search(maSP, tenSP, donViTinh, hanDung, soLuongTon, donGiaBan, tenLoai);
        }

        public DataTable searchById(String maSP)
        {
            return sanPhamDAL.searchById(maSP);
        }
    }
}
