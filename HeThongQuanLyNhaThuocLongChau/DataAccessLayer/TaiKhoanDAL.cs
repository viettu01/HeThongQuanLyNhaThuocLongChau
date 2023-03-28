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
        public string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findByUsername(string tenTK)
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

        public bool changePassword(string tenTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DoiMatKhau";
                    cmd.Parameters.AddWithValue("@tenTK", tenTK);
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
