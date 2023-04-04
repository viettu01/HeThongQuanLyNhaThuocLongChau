using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public int login(string tenTK, string matKhau)
        {
            DataTable dt = taiKhoanDAL.findByUsername(tenTK);
            if (dt.Rows.Count == 0)
                return 0; //Tên đăng nhập không tồn tại
            else
            {
                if (String.Equals(dt.Rows[0]["Mật khẩu"].ToString(), matKhau))
                {
                    Program.setSession(dt.Rows[0]["Mã TK"].ToString(), dt.Rows[0]["Mã Quyền"].ToString(), dt.Rows[0]["Tên tài khoản"].ToString());

                    return 1;
                } 
                return 2; //Đúng tên dăng nhập nhưng Sai mật khẩu
            }
        }

        public bool checkPassword(string tenTK, string matKhau)
        {
            DataTable dt = taiKhoanDAL.findByUsername(tenTK);
            foreach (DataRow dr in dt.Rows)
            {
                if (String.Equals(dr["Mật khẩu"].ToString(), matKhau))
                {
                    return true;
                }
            }
            return false;
        }

        public bool changePassword(string tenTK, string matKhau)
        {
            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                return false;
            }

            if (checkingPasswordStrength(matKhau) < 4)
            {
                return false;
            }

            return taiKhoanDAL.changePassword(tenTK, matKhau);
        }

        private int checkingPasswordStrength(string password)
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
    }
}
