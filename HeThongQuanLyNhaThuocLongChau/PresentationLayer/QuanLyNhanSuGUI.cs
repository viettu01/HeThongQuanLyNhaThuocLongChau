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
    public partial class QuanLyNhanSuGUI : Form
    {
        //ConvertDateToSecond convertDateToSecond = new ConvertDateToSecond();
        //NhanVienBLL nhanVienBLL = new NhanVienBLL();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        QuyenBLL quyenBLL = new QuyenBLL();
        string maNV = "";

        public QuanLyNhanSuGUI()
        {
            InitializeComponent();
        }

        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }

        public void loadDataQuyenCombox(ComboBox cmb)
        {
            DataTable dtNCC = quyenBLL.findAll();
            DataView v = new DataView(dtNCC);
            v.Sort = "Tên quyền";

            cmb.DataSource = v;
            cmb.DisplayMember = "Tên quyền";
            cmb.ValueMember = "Mã quyền";
        }

        public void loadDataChucVuCombox(ComboBox cmb)
        {
            DataTable dtNCC = quyenBLL.findAll();
            DataView v = new DataView(dtNCC);
            v.Sort = "Tên quyền";

            cmb.DataSource = v;
            cmb.DisplayMember = "Tên quyền";
            cmb.ValueMember = "Tên quyền";
        }

        private void QuanLyNhanSu_Load(object sender, EventArgs e)
        {
            //loadDataToDataGridView(dgvNV, nhanVienBLL.findAll());
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataChucVuCombox(cmbChucVu);
            loadDataQuyenCombox(cmbQuyen);

            maNV = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txtHoTenNV.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinhNV.Value = DateTime.Parse(dgvNV.CurrentRow.Cells[2].Value.ToString());
            txtCCCDNV.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            txtSDTNV.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            dtpNgayVaoLam.Value = DateTime.Parse(dgvNV.CurrentRow.Cells[5].Value.ToString());
            cmbChucVu.Text = dgvNV.CurrentRow.Cells[6].Value.ToString();
            txtTenTaiKhoan.Text = dgvNV.CurrentRow.Cells[9].Value.ToString();
            cmbQuyen.Text = dgvNV.CurrentRow.Cells[11].Value.ToString();

            if (dgvNV.CurrentRow.Cells[7].Value.ToString().Equals("Khóa"))
            {
                btnKhoaNV.Text = "Mở khóa";
            }
            else
            {
                btnKhoaNV.Text = "Khóa";
            }

            btnTimKiemNV.Enabled = false;
            btnThemNV.Enabled = false;
            btnSuaNV.Enabled = true;
            btnKhoaNV.Enabled = true;
            btnLamMoiNV.Enabled = true;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtHoTenNV.Text == "")
            {
                errorProviderNV.SetError(txtHoTenNV, "Họ và tên không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(txtHoTenNV, "");

            if (dtpNgaySinhNV.Text == " ")
            {
                errorProviderNV.SetError(dtpNgaySinhNV, "Ngày sinh không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(dtpNgaySinhNV, "");

            if (txtSDTNV.Text == "")
            {
                errorProviderNV.SetError(txtSDTNV, "Số điện thoại không được bỏ trống");
                check = false;
            }
            else if (!double.TryParse(txtSDTNV.Text, out _) || txtSDTNV.Text.Length < 10 || txtSDTNV.Text.Length > 10)
            {
                errorProviderNV.SetError(txtSDTNV, "Số điện thoại không đúng định dạng");
                check = false;
            }
            else
                errorProviderNV.SetError(txtSDTNV, "");

            if (txtCCCDNV.Text == "")
            {
                errorProviderNV.SetError(txtCCCDNV, "Số CCCD không được bỏ trống");
                check = false;
            }
            else if (!double.TryParse(txtCCCDNV.Text, out _) || txtCCCDNV.Text.Length < 12 || txtCCCDNV.Text.Length > 12)
            {
                errorProviderNV.SetError(txtSDTNV, "Số CCCD không đúng định dạng");
                check = false;
            }
            else
                errorProviderNV.SetError(txtCCCDNV, "");

            if (dtpNgayVaoLam.Text == " ")
            {
                errorProviderNV.SetError(dtpNgayVaoLam, "Ngày vào làm không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(dtpNgayVaoLam, "");

            if (cmbChucVu.Text == "")
            {
                errorProviderNV.SetError(cmbChucVu, "Chức vụ không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(cmbChucVu, "");

            if (txtTenTaiKhoan.Text == "")
            {
                errorProviderNV.SetError(txtTenTaiKhoan, "Tên tài khoản không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(txtTenTaiKhoan, "");

            if (txtMatKhau.Text == "")
            {
                errorProviderNV.SetError(txtMatKhau, "Mật khẩu không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(txtMatKhau, "");

            if (cmbQuyen.Text == "")
            {
                errorProviderNV.SetError(cmbQuyen, "Quyền không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(cmbQuyen, "");

            if (check)
            {
                //if (nhanVienBLL.insert("NV" + convertDateToSecond.convertDateToSecond(), txtHoTenNV.Text, dtpNgaySinhNV.Value,
                //                        txtCCCDNV.Text, txtSDTNV.Text, dtpNgayVaoLam.Value, cmbChucVu.Text,
                //                        "TK" + convertDateToSecond.convertDateToSecond(), txtTenTaiKhoan.Text, txtMatKhau.Text,
                //                        cmbQuyen.SelectedValue.ToString()))
                //{
                //    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    btnLamMoiNV_Click(sender, e);
                //}
                //else
                //{
                //    MessageBox.Show("Thêm nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtHoTenNV.Text == "")
            {
                errorProviderNV.SetError(txtHoTenNV, "Họ và tên không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(txtHoTenNV, "");

            if (dtpNgaySinhNV.Text == " ")
            {
                errorProviderNV.SetError(dtpNgaySinhNV, "Ngày sinh không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(dtpNgaySinhNV, "");

            if (txtSDTNV.Text == "")
            {
                errorProviderNV.SetError(txtSDTNV, "Số điện thoại không được bỏ trống");
                check = false;
            }
            else if (!double.TryParse(txtSDTNV.Text, out _) || txtSDTNV.Text.Length < 10 || txtSDTNV.Text.Length > 10)
            {
                errorProviderNV.SetError(txtSDTNV, "Số điện thoại không đúng định dạng");
                check = false;
            }
            else
                errorProviderNV.SetError(txtSDTNV, "");

            if (txtCCCDNV.Text == "")
            {
                errorProviderNV.SetError(txtCCCDNV, "Số CCCD không được bỏ trống");
                check = false;
            }
            else if (!double.TryParse(txtCCCDNV.Text, out _) || txtCCCDNV.Text.Length < 12 || txtCCCDNV.Text.Length > 12)
            {
                errorProviderNV.SetError(txtSDTNV, "Số CCCD không đúng định dạng");
                check = false;
            }
            else
                errorProviderNV.SetError(txtCCCDNV, "");

            if (dtpNgayVaoLam.Text == " ")
            {
                errorProviderNV.SetError(dtpNgayVaoLam, "Ngày vào làm không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(dtpNgayVaoLam, "");

            if (cmbChucVu.Text == "")
            {
                errorProviderNV.SetError(cmbChucVu, "Chức vụ không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(cmbChucVu, "");

            if (txtTenTaiKhoan.Text == "")
            {
                errorProviderNV.SetError(txtTenTaiKhoan, "Tên tài khoản không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(txtTenTaiKhoan, "");

            if (cmbQuyen.Text == "")
            {
                errorProviderNV.SetError(cmbQuyen, "Quyền không được bỏ trống");
                check = false;
            }
            else
                errorProviderNV.SetError(cmbQuyen, "");

            if (check)
            {
                //if (nhanVienBLL.update(maNV, txtHoTenNV.Text, dtpNgaySinhNV.Value, txtCCCDNV.Text, txtSDTNV.Text,
                //                    dtpNgayVaoLam.Value, cmbChucVu.Text, txtTenTaiKhoan.Text, txtMatKhau.Text,
                //                    cmbQuyen.SelectedValue.ToString()))
                //{
                //    MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    loadDataToDataGridView(dgvNV, nhanVienBLL.findAll());
                //    btnLamMoiNV_Click(sender, e);
                //}
                //else
                //{
                //    MessageBox.Show("Sửa nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void btnKhoaNV_Click(object sender, EventArgs e)
        {
            int status = 1;
            if (btnKhoaNV.Text.Equals("Khóa"))
            {
                status = 0;
            }
            if (MessageBox.Show("Bạn có chắc chắn " + btnKhoaNV.Text + " không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //if (nhanVienBLL.changeStatus(maNV, status))
                //{
                //    if (status == 1)
                //        MessageBox.Show("Đã mở khóa tài khoản nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    else
                //        MessageBox.Show("Đã khóa tài khoản nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    loadDataToDataGridView(dgvNV, nhanVienBLL.findAll());
                //    btnLamMoiNV_Click(sender, e);
                //}
                //else
                //{
                //    MessageBox.Show("Khóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtHoTenNV.Text == "" && dtpNgaySinhNV.Text == " " && txtSDTNV.Text == "" && txtCCCDNV.Text == ""
                && dtpNgayVaoLam.Text == " " && cmbChucVu.Text == "" && txtTenTaiKhoan.Text == "" && cmbQuyen.Text == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }

            if (check)
            {
                //DataTable dt = nhanVienBLL.search(txtHoTenNV.Text, dtpNgaySinhNV.Text, txtSDTNV.Text, txtCCCDNV.Text,
                //                                  dtpNgayVaoLam.Text, cmbChucVu.Text, txtTenTaiKhoan.Text, cmbQuyen.Text);
                //btnLamMoiNV.Enabled = true;
                //loadDataToDataGridView(dgvNV, dt);
                //if (dt.Rows.Count == 0)
                //{
                //    MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            maNV = "";
            txtHoTenNV.Text = "";
            txtCCCDNV.Text = "";
            txtSDTNV.Text = "";
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";

            //loadDataToDataGridView(dgvNV, nhanVienBLL.findAll());
            cmbChucVu.DataSource = null;
            cmbQuyen.DataSource = null;
            //cmbChucVu.Items.Clear();

            btnTimKiemNV.Enabled = true;
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = false;
            btnKhoaNV.Enabled = false;
            btnLamMoiNV.Enabled = false;
            btnKhoaNV.Text = "Khóa";

            dtpNgaySinhNV.CustomFormat = " ";
            dtpNgayVaoLam.CustomFormat = " ";
        }

        private void dtpNgaySinhNV_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinhNV.CustomFormat = "yyyy/MM/dd";
        }

        private void dtpNgayVaoLam_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayVaoLam.CustomFormat = "yyyy/MM/dd";
        }

        private void cmbChucVu_Click(object sender, EventArgs e)
        {
            loadDataChucVuCombox(cmbChucVu);
        }

        private void cmbQuyen_Click(object sender, EventArgs e)
        {
            loadDataQuyenCombox(cmbQuyen);
        }

        private void QuanLyNhanSu_FormClosing(object sender, FormClosingEventArgs e)
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
