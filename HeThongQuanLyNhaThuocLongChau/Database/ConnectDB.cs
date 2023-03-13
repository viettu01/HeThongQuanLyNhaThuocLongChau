using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.Database
{
    public class ConnectDB
    {
        public string ConnectString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        
        public DataTable ExecuteQuery(string query, Object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection cnn = new SqlConnection(ConnectString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (parameters != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                cnn.Close();
            }
            return data;
        }

        // Hàm trả về số dòng bị ảnh hưởng bởi truy vấn (VD: update)
        public int ExecuteNonQuery(string query, Object[] parameters = null)
        {
            int data = 0;
            using (SqlConnection cnn = new SqlConnection(ConnectString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (parameters != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            return data;
        }

        public Object ExecuteScalar(string query, Object[] parameters = null)
        {
            Object data = 0;
            using (SqlConnection cnn = new SqlConnection(ConnectString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(query, cnn);
                if (parameters != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                cnn.Close();
            }

            return data;
        }

        public DataTable ExecuteProc(string nameProc, String[] parameterNames = null, Object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection cnn = new SqlConnection(ConnectString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(nameProc, cnn);
                if (parameters != null && parameterNames != null && parameters.Length == parameterNames.Length)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = 0;
                    foreach (string item in parameterNames)
                    {
                        cmd.Parameters.AddWithValue(parameterNames[i], parameters[i]);
                        i++;
                    }

                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                cnn.Close();
            }
            return data;
        }

        public int ExecuteNonProc(string nameProc, String[] parameterNames = null, Object[] parameters = null)
        {
            int data = 0;
            using (SqlConnection cnn = new SqlConnection(ConnectString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(nameProc, cnn);
                if (parameters != null && parameterNames != null && parameters.Length == parameterNames.Length)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = 0;
                    foreach (string item in parameterNames)
                    {
                        cmd.Parameters.AddWithValue(parameterNames[i], parameters[i]);
                        i++;
                    }

                }
                data = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            return data;
        }
    }
}
