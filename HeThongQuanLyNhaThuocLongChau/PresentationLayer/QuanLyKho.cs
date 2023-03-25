using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
using HeThongQuanLyNhaThuocLongChau.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace HeThongQuanLyNhaThuocLongChau.PresentationLayer
{
    public partial class QuanLyKho : Form
    {
        ConvertDateToSecond convertDateToSecond = new ConvertDateToSecond();
        NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
        LoaiSanPhamBLL loaiSanPhamBLL = new LoaiSanPhamBLL();
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        string maSP = "";

        public QuanLyKho()
        {
            InitializeComponent();
        }

        private void loadDataToDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }

        public void loadDataNCCCombox(ComboBox cmb)
        {
            DataTable dtNCC = nhaCungCapBLL.findAll();
            DataView v = new DataView(dtNCC);
            v.Sort = "Tên NCC";

            cmb.DataSource = v;
            cmb.DisplayMember = "Tên NCC";
            cmb.ValueMember = "Mã NCC";
        }

        public void loadDataLoaiSPCombox(ComboBox cmb)
        {
            DataTable dtLoaiSP = loaiSanPhamBLL.findAll();
            DataView v = new DataView(dtLoaiSP);
            v.Sort = "Tên loại";

            cmb.DataSource = v;
            cmb.DisplayMember = "Tên loại";
            cmb.ValueMember = "Mã loại";
        }

        private bool checkValidSanPham(object sender, EventArgs e)
        {
            bool check = true;

            if (txtTenSP.Text == "")
            {
                errorProviderQLKho.SetError(txtTenSP, "Tên sản phẩm không được bỏ trống");
                check = false;
            }
            else
                errorProviderQLKho.SetError(txtTenSP, "");

            if (cmbNCC.Text == "")
            {
                errorProviderQLKho.SetError(cmbNCC, "Nhà cung cấp không được bỏ trống");
                check = false;
            }
            else
                errorProviderQLKho.SetError(cmbNCC, "");

            if (cmbLoaiSP.Text == "")
            {
                errorProviderQLKho.SetError(cmbLoaiSP, "Loại sản phẩm không được bỏ trống");
                check = false;
            }
            else
                errorProviderQLKho.SetError(cmbLoaiSP, "");

            if (txtDVT.Text == "")
            {
                errorProviderQLKho.SetError(txtDVT, "Đơn vị tính không được bỏ trống");
                check = false;
            }
            else
                errorProviderQLKho.SetError(txtDVT, "");

            if (txtHanDung.Text == "")
            {
                errorProviderQLKho.SetError(txtHanDung, "Hạn dùng không được bỏ trống");
                check = false;
            }
            else
                errorProviderQLKho.SetError(txtHanDung, "");

            if (txtGiaBan.Text == "")
            {
                errorProviderQLKho.SetError(txtGiaBan, "Giá bán không được bỏ trống");
                check = false;
            }
            else if (!double.TryParse(txtGiaBan.Text, out _) || double.Parse(txtGiaBan.Text) <= 0)
            {
                errorProviderQLKho.SetError(txtGiaBan, "Giá bán phải là số lớn hơn 0");
                check = false;
            }
            else
                errorProviderQLKho.SetError(txtGiaBan, "");

            return check;
        }

        //Quản lý sản phẩm
        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            loadDataToDataGridView(dgvSP, sanPhamBLL.findAll());
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataNCCCombox(cmbNCC);
            loadDataLoaiSPCombox(cmbLoaiSP);

            maSP = dgvSP.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvSP.CurrentRow.Cells[1].Value.ToString();
            cmbNCC.Text = dgvSP.CurrentRow.Cells[2].Value.ToString();
            cmbLoaiSP.Text = dgvSP.CurrentRow.Cells[3].Value.ToString();
            txtDVT.Text = dgvSP.CurrentRow.Cells[4].Value.ToString();
            txtHanDung.Text = dgvSP.CurrentRow.Cells[5].Value.ToString();
            txtGiaBan.Text = dgvSP.CurrentRow.Cells[7].Value.ToString();

            btnSuaSP.Enabled = true;
            btnXoaSP.Enabled = true;
            btnLamMoiSP.Enabled = true;
            btnThemSP.Enabled = false;
            btnTimKiemSP.Enabled = false;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (checkValidSanPham(sender, e))
            {
                if (sanPhamBLL.insert("SP" + convertDateToSecond.convertDateToSecond(), txtTenSP.Text, txtDVT.Text, txtHanDung.Text, double.Parse(txtGiaBan.Text), cmbLoaiSP.SelectedValue.ToString(), cmbNCC.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProviderQLKho.Clear();
                    loadDataToDataGridView(dgvSP, sanPhamBLL.findAll());
                    btnLamMoiSP_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (checkValidSanPham(sender, e))
            {
                if (sanPhamBLL.update(maSP, txtTenSP.Text, txtDVT.Text, txtHanDung.Text, double.Parse(txtGiaBan.Text), cmbLoaiSP.SelectedValue.ToString(), cmbNCC.SelectedValue.ToString()))
                {
                    MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvSP, sanPhamBLL.findAll());
                    btnLamMoiSP_Click(sender, e);
                }
                else
                    MessageBox.Show("Sửa sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (sanPhamBLL.deleteById(maSP))
                {
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvSP, sanPhamBLL.findAll());
                    btnLamMoiSP_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtTenSP.Text == "" && txtDVT.Text == "" && txtHanDung.Text == "" && txtGiaBan.Text == "" && cmbLoaiSP.Text == "" && cmbNCC.Text == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }

            if (txtGiaBan.Text != "")
            {
                if (!double.TryParse(txtGiaBan.Text, out _) || double.Parse(txtGiaBan.Text) <= 0)
                {
                    MessageBox.Show("Giá bán phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
            }

            if (check)
            {
                MessageBox.Show("abc");
                btnLamMoiSP.Enabled = true;
                DataTable dt = sanPhamBLL.search(txtTenSP.Text, txtDVT.Text, txtHanDung.Text, txtGiaBan.Text, cmbLoaiSP.Text, cmbNCC.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadDataToDataGridView(dgvSP, dt);
            }
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = "";
            txtHanDung.Text = "";
            txtDVT.Text = "";
            txtGiaBan.Text = "";
            maSP = "";
            btnSuaSP.Enabled = false;
            btnXoaSP.Enabled = false;
            btnLamMoiSP.Enabled = false;
            btnThemSP.Enabled = true;
            btnTimKiemSP.Enabled = true;

            loadDataToDataGridView(dgvSP, sanPhamBLL.findAll());
            cmbLoaiSP.DataSource = null;
            cmbNCC.DataSource = null;
        }

        private void cmbNCC_Click(object sender, EventArgs e)
        {
            loadDataNCCCombox(cmbNCC);
        }

        private void cmbLoaiSP_Click(object sender, EventArgs e)
        {
            loadDataLoaiSPCombox(cmbLoaiSP);
        }

        private void QuanLyKho_FormClosing(object sender, FormClosingEventArgs e)
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
