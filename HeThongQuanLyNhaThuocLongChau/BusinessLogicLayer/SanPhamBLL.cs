using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class SanPhamBLL
    {
        SanPhamDAL sanPhamDAL = new SanPhamDAL();

        public DataTable findAll()
        {
            return sanPhamDAL.findAll();
        }

        public bool insert(string maSP, string tenSP, string donViTinh, string hanDung, string donGiaBan, string maLoai, string maNCC)
        {
            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(hanDung)
                || string.IsNullOrEmpty(donGiaBan) || string.IsNullOrEmpty(maLoai) || string.IsNullOrEmpty(maNCC))
                return false;
            else if (!double.TryParse(donGiaBan, out _) || double.Parse(donGiaBan) <= 0)
                return false;
            else
                return sanPhamDAL.insert(maSP, tenSP, donViTinh, hanDung, double.Parse(donGiaBan), maLoai, maNCC);
        }

        public bool update(string maSP, string tenSP, string donViTinh, string hanDung, string donGiaBan, string maLoai, string maNCC)
        {
            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(hanDung)
                || string.IsNullOrEmpty(donGiaBan) || string.IsNullOrEmpty(maLoai) || string.IsNullOrEmpty(maNCC))
                return false;
            else if (!double.TryParse(donGiaBan, out _) || double.Parse(donGiaBan) <= 0)
                return false;
            else
                return sanPhamDAL.update(maSP, tenSP, donViTinh, hanDung, double.Parse(donGiaBan), maLoai, maNCC);
        }

        public bool deleteById(string maSP)
        {
            if (string.IsNullOrEmpty(maSP))
            {
                return false;
            }
            return sanPhamDAL.deleteById(maSP);
        }

        public DataTable search(string tenSP, string donViTinh, string hanDung, string donGiaBan, string tenLoai, string tenNCC)
        {
            if (string.IsNullOrEmpty(tenSP) && string.IsNullOrEmpty(donViTinh) && string.IsNullOrEmpty(hanDung)
                && string.IsNullOrEmpty(donGiaBan) && string.IsNullOrEmpty(tenLoai) && string.IsNullOrEmpty(tenNCC))
                return null;
            else if (!string.IsNullOrEmpty(donGiaBan))
                if (!double.TryParse(donGiaBan, out _) || double.Parse(donGiaBan) <= 0)
                    return null;

            return sanPhamDAL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC);
        }

        public bool checkExistsNameAndCategory(string tenSP, string tenLoai)
        {
            DataTable dt = sanPhamDAL.findAll();

            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["Tên SP"].ToString(), tenSP, StringComparison.InvariantCultureIgnoreCase) &&
                    String.Equals(dr["Loại"].ToString(), tenLoai, StringComparison.InvariantCultureIgnoreCase))
                    return false;
            }

            return true;
        }

        //public bool checkExistsNameAndCategoryForUpdate(string maSP, string tenSP, string tenLoai)
        //{
        //    string sql = "SELECT * FROM vv_SanPham";
        //    DataTable dt = sanPhamDAL.findAll(sql);

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        if (!String.Equals(dr["Mã SP"].ToString(), maSP, StringComparison.InvariantCultureIgnoreCase))
        //            if (String.Equals(dr["Tên SP"].ToString(), tenSP, StringComparison.InvariantCultureIgnoreCase) &&
        //                String.Equals(dr["Loại"].ToString(), tenLoai, StringComparison.InvariantCultureIgnoreCase))
        //                return false;
        //    }

        //    return true;
        //}
    }
}