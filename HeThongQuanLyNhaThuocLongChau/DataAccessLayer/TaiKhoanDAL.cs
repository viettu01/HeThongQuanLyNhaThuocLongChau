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

        public bool deleteById(string maTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaTaiKhoan";
                    cmd.Parameters.AddWithValue("@MaTK", maTK);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
    }
}
