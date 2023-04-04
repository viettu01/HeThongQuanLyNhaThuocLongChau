using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HeThongQuanLyNhaThuocLongChau.PresentationLayer
{
    public partial class QuanLyKhoGUI : Form
    {
        private const string MS_004 = "Thêm sản phẩm thành công";
        private const string MS_005 = "Thêm sản phẩm thất bại";
        private const string MS_011 = "Sửa sản phẩm thành công";
        private const string MS_012 = "Sửa sản phẩm thất bại";
        private const string MS_023 = "Xóa sản phẩm thành công";
        private const string MS_024 = "Xóa sản phẩm thất bại";
        private const string MS_019 = "Giá bán phải là số lớn hơn 0";
        private const string MS_022 = "Bạn cần nhập thông tin muốn tìm";
        private const string MS_025 = "Không tìm thấy sản phẩm";
        private const string MS_030 = "Sản phẩm đã tồn tại";
        private const string MS_013 = "Tên sản phẩm không được bỏ trống";
        private const string MS_014 = "Nhà cung cấp không được bỏ trống";
        private const string MS_015 = "Loại sản phẩm không được bỏ trống";
        private const string MS_016 = "Đơn vị tính không được bỏ trống";
        private const string MS_017 = "Hạn dùng không được bỏ trống";
        private const string MS_018 = "Giá bán không được bỏ trống";
        private const string MS_Notify = "Thông báo";
        private const string MS_Error = "Lỗi";
        private const string MS_Confirm = "Bạn có chắc chắn xóa không?";
        private const string MS_Warn = "Cảnh báo";
        private const string MS_NotAccess = "Bạn không có quyền truy cập chức năng này";

        NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
        LoaiSanPhamBLL loaiSanPhamBLL = new LoaiSanPhamBLL();
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        string maSP = "";

        public QuanLyKhoGUI()
        {
            InitializeComponent();
        }

        private long convertDateToSecond()
        {
            long epochTicks = DateTime.Now.Ticks - new DateTime(2023, 1, 1).Ticks;
            long epochSeconds = epochTicks / TimeSpan.TicksPerSecond;

            return epochSeconds;
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
                errorProviderQLKho.SetError(txtTenSP, MS_013);
                check = false;
            }
            else
                errorProviderQLKho.SetError(txtTenSP, "");

            if (cmbNCC.Text == "")
            {
                errorProviderQLKho.SetError(cmbNCC, MS_014);
                check = false;
            }
            else
                errorProviderQLKho.SetError(cmbNCC, "");

            if (cmbLoaiSP.Text == "")
            {
                errorProviderQLKho.SetError(cmbLoaiSP, MS_015);
                check = false;
            }
            else
                errorProviderQLKho.SetError(cmbLoaiSP, "");

            if (txtDVT.Text == "")
            {
                errorProviderQLKho.SetError(txtDVT, MS_016);
                check = false;
            }
            else
                errorProviderQLKho.SetError(txtDVT, "");

            if (txtHanDung.Text == "")
            {
                errorProviderQLKho.SetError(txtHanDung, MS_017);
                check = false;
            }
            else
                errorProviderQLKho.SetError(txtHanDung, "");

            if (txtGiaBan.Text == "")
            {
                errorProviderQLKho.SetError(txtGiaBan, MS_018);
                check = false;
            }
            else if (!double.TryParse(txtGiaBan.Text, out _) || double.Parse(txtGiaBan.Text) <= 0)
            {
                errorProviderQLKho.SetError(txtGiaBan, MS_019);
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
                if (sanPhamBLL.checkExistsNameAndCategory(txtTenSP.Text, cmbLoaiSP.Text))
                {
                    if (sanPhamBLL.insert("SP" + convertDateToSecond(), txtTenSP.Text, txtDVT.Text, txtHanDung.Text, txtGiaBan.Text, cmbLoaiSP.SelectedValue.ToString(), cmbNCC.SelectedValue.ToString()))
                    {
                        MessageBox.Show(MS_004, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProviderQLKho.Clear();
                        loadDataToDataGridView(dgvSP, sanPhamBLL.findAll());
                        btnLamMoiSP_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(MS_005, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(MS_030, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (checkValidSanPham(sender, e))
            {
                if (sanPhamBLL.checkExistsNameAndCategory(txtTenSP.Text, cmbLoaiSP.Text))
                {
                    if (sanPhamBLL.update(maSP, txtTenSP.Text, txtDVT.Text, txtHanDung.Text, txtGiaBan.Text, cmbLoaiSP.SelectedValue.ToString(), cmbNCC.SelectedValue.ToString()))
                    {
                        MessageBox.Show(MS_011, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataToDataGridView(dgvSP, sanPhamBLL.findAll());
                        btnLamMoiSP_Click(sender, e);
                    }
                    else
                        MessageBox.Show(MS_012, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(MS_030, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MS_Confirm, MS_Warn, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (sanPhamBLL.deleteById(maSP))
                {
                    MessageBox.Show(MS_023, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToDataGridView(dgvSP, sanPhamBLL.findAll());
                    btnLamMoiSP_Click(sender, e);
                }
                else
                    MessageBox.Show(MS_024, MS_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtTenSP.Text == "" && txtDVT.Text == "" && txtHanDung.Text == "" && txtGiaBan.Text == "" && cmbLoaiSP.Text == "" && cmbNCC.Text == "")
            {
                MessageBox.Show(MS_022, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                check = false;
            }

            if (txtGiaBan.Text != "")
            {
                if (!double.TryParse(txtGiaBan.Text, out _) || double.Parse(txtGiaBan.Text) <= 0)
                {
                    MessageBox.Show(MS_019, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                }
            }

            if (check)
            {
                btnLamMoiSP.Enabled = true;
                DataTable dt = sanPhamBLL.search(txtTenSP.Text, txtDVT.Text, txtHanDung.Text, txtGiaBan.Text, cmbLoaiSP.Text, cmbNCC.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(MS_025, MS_Notify, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                TrangChuGUI trangChu = new TrangChuGUI();
                trangChu.Show();
            }
        }
    }
}
