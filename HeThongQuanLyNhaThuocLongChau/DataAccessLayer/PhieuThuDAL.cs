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
    class PhieuThuDAL
    {
        private static string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public static DataTable findAllPhieuThu()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_PhieuThu", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            DataTable dt = new DataTable("vv_PhieuThu");
                            ad.Fill(dt);
                            return dt;
                        }
                        catch (Exception e)
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static DataTable findChiTietPhieuThuByMaPT(String maPT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ChiTietPhieuThu";
                    cmd.Parameters.AddWithValue("@sMaPT", maPT);
                    cnn.Open();
                    try
                    {
                        DataTable data = new DataTable();
                        data.Load(cmd.ExecuteReader());
                        cnn.Close();
                        return data;
                    }
                    catch (Exception e)
                    {
                        cnn.Close();
                        return null;
                    }
                }
            }
        }

        public static DataTable findPhieuThuWithCustomQuery(String query)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            DataTable dt = new DataTable("vv_PhieuThu");
                            ad.Fill(dt);
                            return dt;
                        }
                        catch (Exception e)
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static int deleteByMaPT(string maPT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_XoaPhieuThu";
                    cmd.Parameters.AddWithValue("@sMaPT", maPT);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    return i;
                }
            }
        }
    }
}
