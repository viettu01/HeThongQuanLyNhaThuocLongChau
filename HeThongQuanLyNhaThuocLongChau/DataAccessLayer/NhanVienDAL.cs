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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_NhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_NhanVien"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string maNV, string maTK, string tenNV, DateTime ngaySinh, string cccd, string sdt, DateTime ngayVaoLam, string chucvu)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemNhanVien";
                    cmd.Parameters.AddWithValue("@PK_sMaNV", maNV);
                    cmd.Parameters.AddWithValue("@FK_sMaTK", maTK);
                    cmd.Parameters.AddWithValue("@sHoTen", tenNV);
                    cmd.Parameters.AddWithValue("@dNgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@sCCCD", cccd);
                    cmd.Parameters.AddWithValue("@sSDT", sdt);
                    cmd.Parameters.AddWithValue("@dNgayVaoLam", ngayVaoLam);
                    cmd.Parameters.AddWithValue("@sCVu", chucvu);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool update(string maNV, string maTK, string tenNV, DateTime ngaySinh, string cccd, string sdt, DateTime ngayVaoLam, string chucvu)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaNhanVien";
                    cmd.Parameters.AddWithValue("@PK_sMaNV", maNV);
                    cmd.Parameters.AddWithValue("@FK_sMaTK", maTK);
                    cmd.Parameters.AddWithValue("@sHoTen", tenNV);
                    cmd.Parameters.AddWithValue("@dNgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@sCCCD", cccd);
                    cmd.Parameters.AddWithValue("@sSDT", sdt);
                    cmd.Parameters.AddWithValue("@dNgayVaoLam", ngayVaoLam);
                    cmd.Parameters.AddWithValue("@sCVu", chucvu);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool deleteById(string maNV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaNhanVien";
                    cmd.Parameters.AddWithValue("@PK_sMaNV", maNV);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }


        public DataTable searchById(String maNV)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM tbl_NhanVien WHERE [Mã NV] LIKE '" + maNV + "' ";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_NhanVien"))
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
