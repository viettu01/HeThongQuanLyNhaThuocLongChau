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
    public partial class TrangChuGUI : Form
    {
        public TrangChuGUI()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            lbTaiKhoanDangDangNhap.Text = "Tài khoản đang đăng nhập: " + Program.tenTK;
            if (Program.maQuyen.Equals(Program.maQuyenBanHang))
            {
                tsmiQuanLyKho.Visible = false;
                tsmiQuanLyKeToan.Visible = false;
                tsmiQuanLyNhanSu.Visible = false;
                tsmiBaoCao.Visible = false;
            }

            if (Program.maQuyen.Equals(Program.maQuyenKeToan))
            {
                tsmiQuanLyKho.Visible = false;
                tsmiQuanLyBanHang.Visible = false;
                tsmiQuanLyNhanSu.Visible = false;
                tsmiBaoCao.Visible = false;
                tsmiBanHang.Visible = false;
            }

            if (Program.maQuyen.Equals(Program.maQuyenKho))
            {
                tsmiQuanLyKeToan.Visible = false;
                tsmiQuanLyBanHang.Visible = false;
                tsmiQuanLyNhanSu.Visible = false;
                tsmiBanHang.Visible = false;
                tsmiBaoCao.Visible = false;
            }

            //if (Program.maQuyen.Equals(Program.maQuyenBanHang))
            //{
            //    tsmiBaoCao.Visible = false;
            //}

            //if (Program.maQuyen.Equals(Program.maQuyenKeToan))
            //{
            //    tsmiBanHang.Visible = false;
            //}
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            Program.maTK = "";
            Program.maQuyen = "";
            Program.tenTK = "";
            new DangNhapGUI().Show();
            this.Hide();
        }

        private void tsmiBanHang_Click(object sender, EventArgs e)
        {
            BanHangGUI banHang = new BanHangGUI();
            banHang.Show();
            this.Hide();
        }

        private void tsmiQuanLyKho_Click(object sender, EventArgs e)
        {
            QuanLyKhoGUI quanLyKho = new QuanLyKhoGUI();
            quanLyKho.Show();
            this.Hide();
        }

        private void tsmiDoiMatKhau_Click(object sender, EventArgs e)
        {
            new DoiMatKhauGUI().Show();
            this.Hide();
        }

        private void tsmiQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            QuanLyNhanSuGUI quanLyNhanSu = new QuanLyNhanSuGUI();
            quanLyNhanSu.Show();
            this.Hide();
        }

        private void tsmiQuanLyBanHang_Click(object sender, EventArgs e)
        {
            QuanLyBanHangGUI quanLyBanHang = new QuanLyBanHangGUI();
            quanLyBanHang.Show();
            this.Hide();
        }

        private void tsmiQuanLyKeToan_Click(object sender, EventArgs e)
        {
            QuanLyKeToanGUI quanLyKeToan = new QuanLyKeToanGUI();
            quanLyKeToan.Show();
            this.Hide();
        }

        private void tsmiBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoGUI baoCao = new BaoCaoGUI();
            baoCao.Show();
            this.Hide();
        }
    }
}
