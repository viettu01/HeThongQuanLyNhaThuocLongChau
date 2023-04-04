using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyNhaThuocLongChau.DataAccessLayer
{
    public class SanPhamDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ShowViewSanPham";
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool insert(string maSP, string tenSP, string donViTinh, string hanDung, double donGiaBan, string maLoai, string maNCC)
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
                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public bool update(string maSP, string tenSP, string donViTinh, string hanDung, double donGiaBan, string maLoai, string maNCC)
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
                    cmd.Parameters.AddWithValue("@MaNCC", maNCC);
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

        public DataTable search(string tenSP, string donViTinh, string hanDung, string donGiaBan, string tenLoai, string tenNCC)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_TimKiemSanPham";
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                    cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                    cmd.Parameters.AddWithValue("@HanDung", hanDung);
                    cmd.Parameters.AddWithValue("@DonGiaBan", donGiaBan);
                    cmd.Parameters.AddWithValue("@TenLoai", tenLoai);
                    cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
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
