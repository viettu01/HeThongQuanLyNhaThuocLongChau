﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.DataAccessLayer
{
    class LoaiSanPhamDAL
    {
        string constr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public DataTable findAll()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_LoaiSanPham", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("vv_LoaiSanPham"))
                        {
                            ad.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool checkExistsByName(string tenLoaiSP)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from vv_LoaiSanPham", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (String.Equals(rd["Tên loại"].ToString(), tenLoaiSP, StringComparison.InvariantCultureIgnoreCase))
                                return false;
                        }
                        rd.Close();
                    }
                    cnn.Close();
                }
            }
            return true;
        }
    }
}