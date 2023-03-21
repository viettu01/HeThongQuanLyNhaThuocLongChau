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
    public partial class DangNhap : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public DangNhap()
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
            string tenTK = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            if (!checkValidDangNhap(tenTK, matKhau))
            {
                errorProviderLogin.SetError(txtTenTaiKhoan, "Vui lòng nhập đủ thông tin");
                errorProviderLogin.SetError(txtMatKhau, "Vui lòng nhập đủ thông tin");
            }
            else
            {
                errorProviderLogin.SetError(txtTenTaiKhoan, "");
                errorProviderLogin.SetError(txtMatKhau, "");

                if (taiKhoanBLL.login(tenTK, matKhau) == 0)
                    errorProviderLogin.SetError(txtTenTaiKhoan, "Sai tên tài khoản");
                else if (taiKhoanBLL.login(tenTK, matKhau) == 2)
                {
                    errorProviderLogin.SetError(txtMatKhau, "Sai mật khẩu");
                    txtMatKhau.Text = "";
                }
                else if (taiKhoanBLL.login(tenTK, matKhau) == 1)
                {
                    new TrangChu().Show();
                    this.Hide();
                }
            }
        }
    }
}
