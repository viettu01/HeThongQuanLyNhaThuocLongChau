using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyNhaThuocLongChau.PresentationLayer
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            lbTaiKhoanDangDangNhap.Text = "Tài khoản đang đăng nhập: " + Program.tenTK;
            if (!Program.maQuyen.Equals(Program.maQuyenQuanLy))
            {
                tsmiQuanLy.Visible = false;
            }
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            Program.maTK = "";
            Program.maQuyen = "";
            Program.tenTK = "";
            new DangNhap().Show();
            this.Hide();
        }

        private void tsmiBanHang_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            banHang.Show();
            this.Hide();
        }

        private void tsmiQuanLyKho_Click(object sender, EventArgs e)
        {
            QuanLyKho quanLyKho = new QuanLyKho();
            quanLyKho.Show();
            this.Hide();
        }

        private void tsmiDoiMatKhau_Click(object sender, EventArgs e)
        {
            new DoiMatKhau().Show();
            this.Hide();
        }

        private void tsmiQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            QuanLyNhanSu quanLyNhanSu = new QuanLyNhanSu();
            quanLyNhanSu.Show();
            this.Hide();
        }

        private void tsmiQuanLyBanHang_Click(object sender, EventArgs e)
        {
            QuanLyBanHang quanLyBanHang = new QuanLyBanHang();
            quanLyBanHang.Show();
            this.Hide();
        }

        private void tsmiQuanLyKeToan_Click(object sender, EventArgs e)
        {
            QuanLyKeToan quanLyKeToan = new QuanLyKeToan();
            quanLyKeToan.Show();
            this.Hide();
        }

        private void tsmiBaoCao_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            baoCao.Show();
            this.Hide();
        }
    }
}
