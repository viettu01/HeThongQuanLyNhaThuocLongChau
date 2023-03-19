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

        }

        private void comboBoxMaLoaiSP()
        {

        }

        private void comboBoxNCC()
        {

        }

        private void QuanLyKho_Load(object sender, EventArgs e)
        {

        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {

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

        }
    }
}
