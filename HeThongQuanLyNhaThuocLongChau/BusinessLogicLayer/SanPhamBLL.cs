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
            string sql = "SELECT * FROM vv_SanPham";
            return sanPhamDAL.findAll(sql);
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

        public DataTable search(string tenSP, string donViTinh, string hanDung, string donGiaBan, string tenLoai, string tenNCC)
        {
            string sqlSearchPrice = "";
            if (donGiaBan != "" && double.TryParse(donGiaBan, out _))
            {
                sqlSearchPrice = "AND [Giá bán] = " + double.Parse(donGiaBan) + " ";
            }
            String sql = "SELECT * FROM vv_SanPham " +
                "WHERE [Tên SP] LIKE N'%" + tenSP + "%' " +
                    "AND [Loại] LIKE N'%" + tenLoai + "%' " +
                    "AND [Đơn vị tính] LIKE N'%" + donViTinh + "%' " +
                    "AND [Hạn dùng] LIKE N'%" + hanDung + "%' " +
                    "AND [Tên NCC] LIKE N'%" + tenNCC + "%' " +
                    sqlSearchPrice;

            return sanPhamDAL.findAll(sql);
        }

        public bool checkExistsNameAndCategory(string tenSP, string tenLoai)
        {
            string sql = "SELECT * FROM vv_SanPham";
            DataTable dt = sanPhamDAL.findAll(sql);

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["Tên SP"].ToString(), tenSP, StringComparison.InvariantCultureIgnoreCase) &&
                    String.Equals(dr["Loại"].ToString(), tenLoai, StringComparison.InvariantCultureIgnoreCase))
                    return false;
            }

            return true;
        }

        public bool checkExistsNameAndCategoryForUpdate(string maSP, string tenSP, string tenLoai)
        {
            string sql = "SELECT * FROM vv_SanPham";
            DataTable dt = sanPhamDAL.findAll(sql);

            foreach (DataRow dr in dt.Rows)
            {
                if (!String.Equals(dr["Mã SP"].ToString(), maSP, StringComparison.InvariantCultureIgnoreCase))
                    if (String.Equals(dr["Tên SP"].ToString(), tenSP, StringComparison.InvariantCultureIgnoreCase) &&
                        String.Equals(dr["Loại"].ToString(), tenLoai, StringComparison.InvariantCultureIgnoreCase))
                        return false;
            }

            return true;
        }
    }
}
