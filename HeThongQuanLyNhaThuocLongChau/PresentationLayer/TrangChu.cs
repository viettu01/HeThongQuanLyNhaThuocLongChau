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

        }

        private void tsmiQuanLyKho_Click(object sender, EventArgs e)
        {

        }
    }
}
