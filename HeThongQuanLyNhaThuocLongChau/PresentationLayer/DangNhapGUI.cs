using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
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
    public partial class DangNhapGUI : Form
    {
        private const string MS_001 = "Vui lòng nhập đủ thông tin";
        private const string MS_002 = "Sai tên tài khoản";
        private const string MS_003 = "Sai mật khẩu";

        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public DangNhapGUI()
        {
            InitializeComponent();
        }

        public bool checkValidDangNhap(string tenTK, string matKhau)
        {
            if (tenTK.Equals("") || matKhau.Equals(""))
                return false;

            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!checkValidDangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text))
            {
                errorProviderLogin.SetError(txtTenTaiKhoan, MS_001);
                errorProviderLogin.SetError(txtMatKhau, MS_001);
            }
            else
            {
                errorProviderLogin.Clear();

                if (taiKhoanBLL.login(txtTenTaiKhoan.Text, txtMatKhau.Text) == 0)
                    errorProviderLogin.SetError(txtTenTaiKhoan, MS_002);
                else if (taiKhoanBLL.login(txtTenTaiKhoan.Text, txtMatKhau.Text) == 2)
                {
                    errorProviderLogin.SetError(txtMatKhau, MS_003);
                    txtMatKhau.Text = "";
                }
                else if (taiKhoanBLL.login(txtTenTaiKhoan.Text, txtMatKhau.Text) == 1)
                {
                    new TrangChuGUI().Show();
                    this.Hide();
                }
            }
        }
    }
}
