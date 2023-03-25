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
    public class TaiKhoanDAL
    {
        private string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public bool insert(string maTK, string tenTK, string matKhau, string maQuyen)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ThemTaiKhoan";
                    cmd.Parameters.AddWithValue("@MaTK", maTK);
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

        public bool update(string maTK, string tenTK, string matKhau, string maQuyen)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_SuaTaiKhoan";
                    cmd.Parameters.AddWithValue("@PK_sMaTK", maTK);
                    cmd.Parameters.AddWithValue("@sTenTK", tenTK);
                    cmd.Parameters.AddWithValue("@sMK", matKhau);
                    cmd.Parameters.AddWithValue("@FK_sMaQuyen", maQuyen);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        public DataTable login(string tenTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "SELECT * FROM vv_TaiKhoanNhanVienQuyen WHERE [Tên tài khoản] = '" + tenTK + "'";
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

        public DataTable checkPassword(string maTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "Select * from vv_TaiKhoanNhanVienQuyen where [Mã TK] = '" + maTK + "'";
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

        public bool changePassword(string maTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DoiMatKhau";
                    cmd.Parameters.AddWithValue("@maTK", maTK);
                    cmd.Parameters.AddWithValue("@MK", matKhau);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
    }
}
