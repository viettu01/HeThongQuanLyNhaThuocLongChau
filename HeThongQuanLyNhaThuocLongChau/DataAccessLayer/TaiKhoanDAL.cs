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

        public int login(string tenTK, string matKhau)
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
                            if (dt.Rows.Count == 0)
                                return 0; //Tên đăng nhập không tồn tại
                            else
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    if (dr["Mật khẩu"].Equals(matKhau))
                                    {
                                        Program.maTK = dr["Mã TK"].ToString();
                                        Program.maQuyen = dr["Mã Quyền"].ToString();
                                        Program.tenTK = dr["Tên tài khoản"].ToString();
                                        Program.tenNV = dr["Tên NV"].ToString();
                                        return 1; //Đúng mật khẩu và tên đăng nhập
                                    }
                                    else
                                        return 2; //Đúng tên dăng nhập nhưng Sai mật khẩu 
                                }
                            }
                        }
                    }
                    return -1;
                }
            }
        }

        public bool checkPassword(string maTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_TaiKhoanNhanVienQuyen where [Mã TK] = '" + maTK + "'", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (String.Equals(rd["Mật khẩu"].ToString(), matKhau, StringComparison.InvariantCultureIgnoreCase))
                                return true;
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return false;
        }

        public bool checkStatus(string tenTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_TaiKhoanNhanVienQuyen where [Tên đăng nhập] = '" + tenTK + "'", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (bool.Parse(rd["Trạng thái"].ToString()))
                                return true;
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return false;
        }

        public bool changePassword(string maTK, string matKhau)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                String sql = "UPDATE dbo.tbl_TaiKhoan SET sMK = '" + matKhau + "' WHERE PK_sMaTK = '" + maTK + "'";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
    }
}
