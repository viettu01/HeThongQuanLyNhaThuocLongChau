using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyNhaThuocLongChau.PresentationLayer
{
    public partial class DoiMatKhau : Form
    {

        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private int CheckingPasswordStrength(string password)
        {
            int score = 0;

            //Độ dài mật khẩu phải từ 8-20 ký tự
            if (password.Length >= 8 && password.Length <= 20)
                score++;

            //Check xem mật khẩu có số hay không
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;

            //Chekc xem mật khẩu có chữ thường không
            if (Regex.IsMatch(password, @"^(?=.*[a-z]).+$", RegexOptions.ECMAScript)) //lower
                score++;

            //Chekc xem mật khẩu có chữ hoa không
            if (Regex.IsMatch(password, @"^(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //upper case
                score++;

            //Chekc xem mật khẩu có ký tự đặc biệt hay không
            //if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
            //    score++;

            return score;
        }

        private bool checkValidDoiMatKhau(object sender, EventArgs e)
        {
            bool check = true;

            if (txtMatKhauCu.Text.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauCu, "Vui lòng nhập mật khẩu cũ");
                check = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauCu, "");
            }

            if (txtMatKhauMoi.Text.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauMoi, "Vui lòng nhập mật khẩu mới");
                check = false;
            }
            else if (CheckingPasswordStrength(txtMatKhauMoi.Text) < 4)
            {
                MessageBox.Show("Mật khẩu cần có 8 ký tự trở lên, tối đa 20 ký tự, bao gồm chữ số, chữ thường, chữ hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauMoi, "");
            }

            if (txtNhapLaiMatKhauMoi.Text.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(txtNhapLaiMatKhauMoi, "Vui lòng nhập lại mật khẩu mới");
                check = false;
            }
            else if (txtNhapLaiMatKhauMoi.Text != txtMatKhauMoi.Text)
            {
                errorProviderDoiMatKhau.SetError(txtNhapLaiMatKhauMoi, "Mật khẩu nhập lại không đúng");
                check = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(txtNhapLaiMatKhauMoi, "");
            }

            return check;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text;
            string nhapLaiMatKhauMoi = txtNhapLaiMatKhauMoi.Text;

            if (checkValidDoiMatKhau(sender, e))
            {
                if (!taiKhoanBLL.checkPassword(Program.tenTK, matKhauCu))
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (taiKhoanBLL.changePassword(Program.tenTK, nhapLaiMatKhauMoi))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new DangNhap().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnVeTrangChu_Click(object sender, EventArgs e)
        {
            new TrangChu().Show();
            this.Hide();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMatKhauMoi.Text = "";
            errorProviderDoiMatKhau.Clear();
        }

        private void DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Tạo Form đích và hiển thị nó
                TrangChu trangChu = new TrangChu();
                trangChu.Show();
            }
        }
    }
}
