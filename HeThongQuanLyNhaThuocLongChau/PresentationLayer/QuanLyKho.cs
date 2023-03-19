using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyNhaThuocLongChau.PresentationLayer
{
    public partial class QuanLyKho : Form
    {
        public QuanLyKho()
        {
            InitializeComponent();
        }
        //Quản lý sản phẩm
        private void Load_dgvSanPham(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QuanLyHeThongNhaThuocLongChau"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from vv_SanPham", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);
                        dgvSP.DataSource = tb;
                    }
                }
            }
        }
        private void comboBoxMaLoaiSP()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QuanLyHeThongNhaThuocLongChau"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_LoaiSanPham", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMaloai.DataSource = dt;
                        cbMaloai.DisplayMember = "Loại";
                        cbMaloai.ValueMember = "PK_sMaLoai";
                    }
                }
            }
        }
        private void comboBoxNCC()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QuanLyHeThongNhaThuocLongChau"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_NhaCungCap", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMaloai.DataSource = dt;
                        cbMaloai.DisplayMember = "NCC";
                        cbMaloai.ValueMember = "PK_sMaNCC";
                    }
                }
            }
        }
        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            Load_dgvSanPham(sender, e);
            comboBoxMaLoaiSP();
            comboBoxNCC();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvSP.CurrentRow.Cells["Mã SP"].Value.ToString();
            txtTenSP.Text = dgvSP.CurrentRow.Cells["Tên SP"].Value.ToString();
            txtDVT.Text = dgvSP.CurrentRow.Cells["Đơn vị tính"].Value.ToString();
            mtbGiaBan.Text = dgvSP.CurrentRow.Cells["Giá bán"].Value.ToString();
            cmbNCC.Text = dgvSP.CurrentRow.Cells["NCC"].Value.ToString();
            txtHanDung.Text = dgvSP.CurrentRow.Cells["Hạn dùng"].Value.ToString();
            //cbMaloai.Text = dgvSP.CurrentRow.Cells["Loại"].Value.ToString();

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QuanLyHeThongNhaThuocLongChau"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "dbo.sp_ThemSanPham";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@DonViTinh", txtDVT.Text);
                    cmd.Parameters.AddWithValue("@HanDung", txtHanDung.Text);
                    cmd.Parameters.AddWithValue("@DonGiaBan", mtbGiaBan.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", cbMaloai.Text);
                    cmd.Parameters.AddWithValue("@NhaCungCap", cmbNCC.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    Load_dgvSanPham(sender, e);
                }
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QuanLyHeThongNhaThuocLongChau"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_XoaSanPham";
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    Load_dgvSanPham(sender,e);
                    MessageBox.Show("Bạn đã xóa sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QuanLyHeThongNhaThuocLongChau"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandText = "dbo.sp_SuaSanPham";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@DonViTinh", txtDVT.Text);
                    cmd.Parameters.AddWithValue("@HanDung", txtHanDung.Text);
                    cmd.Parameters.AddWithValue("@DonGiaBan", mtbGiaBan.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", cbMaloai.Text);
                    cmd.Parameters.AddWithValue("@NhaCungCap", cmbNCC.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    Load_dgvSanPham(sender,e);
                    MessageBox.Show("Bạn đã sửa sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtHanDung.Text = "";
            txtDVT.Text = "";
            mtbGiaBan.Text = "";
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string sqlTimKiem = "SELECT * FROM vv_SanPham WHERE [Mã SP] LIKE '" + maSP + "' ";
            string constr = ConfigurationManager.ConnectionStrings["db_QuanLyHeThongNhaThuocLongChau"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlTimKiem, cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvLoaiSP.DataSource = dt;
                    }
                }
            }
        }
    }
}
