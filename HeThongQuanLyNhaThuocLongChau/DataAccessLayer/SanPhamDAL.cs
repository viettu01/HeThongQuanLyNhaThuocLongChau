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
    public class SanPhamDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM vv_SanPham", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_SanPham"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string maSP, string tenSP, string donViTinh, string hanDung, double donGiaBan, string maLoai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemSanPham";
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                    cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                    cmd.Parameters.AddWithValue("@HanDung", hanDung);
                    cmd.Parameters.AddWithValue("@DonGiaBan", donGiaBan);
                    cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool update(string maSP, string tenSP, string donViTinh, string hanDung, double donGiaBan, string maLoai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaSanPham";
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                    cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                    cmd.Parameters.AddWithValue("@HanDung", hanDung);
                    cmd.Parameters.AddWithValue("@DonGiaBan", donGiaBan);
                    cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool deleteById(string maSP)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaSanPham";
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable search(string maSP, string tenSP, string donViTinh, string hanDung, string soLuongTon, string donGiaBan, string tenLoai)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string sqlSearchPrice = "", sqlSearchQuality = "";
                if (donGiaBan != "")
                {
                    sqlSearchPrice = "AND [Giá] >= " + double.Parse(donGiaBan) + " ";
                }
                if (soLuongTon != "")
                {
                    sqlSearchQuality = "AND [Số lượng tồn] >= " + int.Parse(soLuongTon) + " ";
                }
                String sql = "SELECT * FROM vv_SanPham " +
                    "WHERE [Mã SP] LIKE N'%" + maSP + "%' " +
                        "AND [Tên SP] LIKE N'%" + tenSP + "%' " +
                        "AND [Loại] LIKE N'%" + tenLoai + "%' " +
                        "AND [Đơn vị tính] LIKE N'%" + donViTinh + "%' " +
                        "AND [Hạn dùng] LIKE N'%" + hanDung + "%' " +
                        sqlSearchQuality +
                        sqlSearchPrice;
                
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_SanPham"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public DataTable searchById(String maSP)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_SanPham WHERE [Mã SP] LIKE '" + maSP + "' ";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_SanPham"))
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
