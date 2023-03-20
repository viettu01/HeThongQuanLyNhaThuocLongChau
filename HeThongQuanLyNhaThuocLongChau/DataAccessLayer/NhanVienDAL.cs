using HeThongQuanLyNhaThuocLongChau.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.DataAccessLayer
{
    class NhanVienDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_TaiKhoanNhanVienQuyenKhongMatKhau", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_TaiKhoanNhanVienQuyenKhongMatKhau"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string maNV, string tenNV, DateTime ngaySinh, string cccd,
                            string sdt, DateTime ngayVaoLam, string chucvu,
                            string maTK, string tenTK, string matKhau, string maQuyen)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemNhanVien";
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaTK", maTK);
                    cmd.Parameters.AddWithValue("@HoTen", tenNV);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@CCCD", cccd);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@NgayVaoLam", ngayVaoLam);
                    cmd.Parameters.AddWithValue("@ChucVu", chucvu);

                    cmd.Parameters.AddWithValue("@TenTK", tenTK);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@MaQuyen", maQuyen);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool update(string maNV, string tenNV, DateTime ngaySinh,
                            string cccd, string sdt, DateTime ngayVaoLam, string chucvu,
                            string tenTK, string matKhau, string maQuyen)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaNhanVien";
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@HoTen", tenNV);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@CCCD", cccd);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@NgayVaoLam", ngayVaoLam);
                    cmd.Parameters.AddWithValue("@ChucVu", chucvu);

                    cmd.Parameters.AddWithValue("@TenTK", tenTK);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@MaQuyen", maQuyen);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool changeStatus(string maNV, int trangThai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sql = "UPDATE dbo.tbl_NhanVien SET bTrangThai = " + trangThai + " WHERE PK_sMaNV = '" + maNV + "'";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable search(string tenNV, string ngaySinh, string sdt, string cccd, string ngayVaoLam, string chucvu, string tenTK, string tenQuyen)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSearchNgaySinh = "", sqlSearchNgayVaoLam = "";

                if (ngaySinh != " ")
                {
                    sqlSearchNgaySinh = "AND [Ngày sinh] >= '" + DateTime.Parse(ngaySinh) + "' ";
                }

                if (ngayVaoLam != " ")
                {
                    sqlSearchNgayVaoLam = "AND [Ngày vào làm] >= '" + DateTime.Parse(ngayVaoLam) + "' ";
                }

                string sql = "SELECT * FROM vv_TaiKhoanNhanVienQuyen " +
                    "WHERE [Tên NV] LIKE N'%" + tenNV + "%' " +
                        sqlSearchNgaySinh +
                        "AND [SĐT] LIKE N'%" + sdt + "%' " +
                        "AND [CCCD] LIKE N'%" + cccd + "%' " +
                        sqlSearchNgayVaoLam +
                        "AND [Chức vụ] LIKE N'%" + chucvu + "%' " +
                        "AND [Tên tài khoản] LIKE N'%" + tenTK + "%' " +
                        "AND [Tên quyền] LIKE N'%" + tenQuyen + "%' ";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_TaiKhoanNhanVienQuyen"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
    }
}
