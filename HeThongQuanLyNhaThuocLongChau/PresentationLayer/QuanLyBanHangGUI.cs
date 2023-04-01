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
    public partial class QuanLyBanHangGUI : Form
    {
        public QuanLyBanHangGUI()
        {
            InitializeComponent();
        }

        private void QuanLyBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Tạo Form đích và hiển thị nó
                TrangChuGUI trangChu = new TrangChuGUI();
                trangChu.Show();
            }
        }
    }
}
