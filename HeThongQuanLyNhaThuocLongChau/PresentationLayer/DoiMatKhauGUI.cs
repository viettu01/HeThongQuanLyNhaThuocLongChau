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
    public partial class DoiMatKhauGUI : Form
    {
        private const string MS_001 = "Vui lòng nhập đủ thông tin";
        private const string MS_006 = "Mật khẩu cần có 8 ký tự trở lên, tối đa 20 ký tự, bao gồm chữ số, chữ thường, chữ hoa";
        private const string MS_007 = "Mật khẩu nhập lại không đúng";
        private const string MS_008 = "Mật khẩu cũ không đúng";
        private const string MS_009 = "Đổi mật khẩu thành công";
        private const string MS_010 = "Đổi mật khẩu thất bại";
        private const string MS_Notify = "Thông báo";

        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public DoiMatKhauGUI()
        {
            InitializeComponent();
        }

        private int checkingPasswordStrength(string matKhau)
        {
            int score = 0;

            //Độ dài mật khẩu phải từ 8-20 ký tự
            if (matKhau.Length >= 8 && matKhau.Length <= 20)
                score++;

            //Check xem mật khẩu có số hay không
            if (Regex.IsMatch(matKhau, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;

            //Chekc xem mật khẩu có chữ thường không
            if (Regex.IsMatch(matKhau, @"^(?=.*[a-z]).+$", RegexOptions.ECMAScript)) //lower
                score++;

            //Chekc xem mật khẩu có chữ hoa không
            if (Regex.IsMatch(matKhau, @"^(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //upper case
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
                errorProviderDoiMatKhau.SetError(txtMatKhauCu, MS_001);
                check = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauCu, "");
            }

            if (txtMatKhauMoi.Text.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauMoi, MS_001);
                check = false;
            }
            else if (checkingPasswordStrength(txtMatKhauMoi.Text) < 4)
            {
                MessageBox.Show(MS_006, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }
            else
            {
                errorProviderDoiMatKhau.SetError(txtMatKhauMoi, "");
            }

            if (txtNhapLaiMatKhauMoi.Text.Equals(""))
            {
                errorProviderDoiMatKhau.SetError(txtNhapLaiMatKhauMoi, MS_001);
                check = false;
            }
            else if (txtNhapLaiMatKhauMoi.Text != txtMatKhauMoi.Text)
            {
                errorProviderDoiMatKhau.SetError(txtNhapLaiMatKhauMoi, MS_007);
                txtNhapLaiMatKhauMoi.Text = "";
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
                    MessageBox.Show(MS_008, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (taiKhoanBLL.changePassword(Program.tenTK, nhapLaiMatKhauMoi))
                    {
                        MessageBox.Show(MS_009, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new DangNhapGUI().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(MS_010, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnVeTrangChu_Click(object sender, EventArgs e)
        {
            new TrangChuGUI().Show();
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
                TrangChuGUI trangChu = new TrangChuGUI();
                trangChu.Show();
            }
        }
    }
}
