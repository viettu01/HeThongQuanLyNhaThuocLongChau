using CrystalDecisions.CrystalReports.Engine;
using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
using HeThongQuanLyNhaThuocLongChau.DTO;
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
    public partial class BanHang : Form
    {
        BanHangBLL banHangDLL = new BanHangBLL();

        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            Load_cbSDTKH();
            Load_cbMaSP();
            cmbHinhThucThanhToan.SelectedIndex = 0;
            //listSanPhamThem = new List<SanPham>();
        }

        private void Load_cbMaSP()
        {
            DataTable dtNCC = banHangDLL.findAllMaSP();
            DataView v = new DataView(dtNCC);
            v.Sort = "Mã SP";

            cbMaSP.DataSource = v;
            cbMaSP.DisplayMember = "Mã SP";
            cbMaSP.ValueMember = "Mã SP";
            cbMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbMaSP.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Load_cbSDTKH()
        {
            DataTable khacHangs = banHangDLL.findAllKhachHang();
            DataView v = new DataView(khacHangs);
            v.Sort = "SĐT";

            cbSDTKH.DataSource = v;
            cbSDTKH.DisplayMember = "SĐT";
            cbSDTKH.ValueMember = "SĐT";
            cbSDTKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSDTKH.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Tạo Form đích và hiển thị nó
                TrangChu trangChu = new TrangChu();
                trangChu.Show();
            }
        }

        private void cbSDTKH_TextChanged(object sender, EventArgs e)
        {
            if (banHangDLL.isNotPhone(cbSDTKH.Text))
            {
                errorSDT.SetError(cbSDTKH, Messages.PHONE_ERROR);
                tbTenKH.Enabled = false;
                return;
            }

            errorSDT.Clear();
            String nameOfUser = banHangDLL.findNameOfUserByPhone(cbSDTKH.Text);
            tbTenKH.Text = nameOfUser;
            tbTenKH.Enabled = String.IsNullOrEmpty(nameOfUser);
        }

        private void cbSDTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorSDT.Clear();
            String nameOfUser = banHangDLL.findNameOfUserByPhone(cbSDTKH.Text);
            tbTenKH.Text = nameOfUser;
            tbTenKH.Enabled = String.IsNullOrEmpty(nameOfUser);
        }

        private void cbMaSP_TextChanged(object sender, EventArgs e)
        {
            errorMaSP.Clear();
            SanPhamDTO data = banHangDLL.findProductByCode(cbMaSP.Text);
            if (data == null)
            {
                txtDVT.Clear();
                txtDG.Clear();
                return;
            }

            txtDVT.Text = data.sDonViTinh;
            txtDG.Text = data.fDonGiaBan.ToString();
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorMaSP.Clear();
            btnSua.Enabled = false;
            SanPhamDTO data = banHangDLL.findProductByCode(cbMaSP.Text);
            if (data == null)
            {
                txtDVT.Clear();
                txtDG.Clear();
                return;
            }

            txtDVT.Text = data.sDonViTinh;
            txtDG.Text = data.fDonGiaBan.ToString();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            cbSDTKH.Text = "";
            tbTenKH.Text = "";
            tbTenKH.Enabled = false;
            cbMaSP.Text = "";
            txtDVT.Text = "";
            txtDG.Text = "";
            nudSoLuong.Value = 1;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;

            SanPhamDTO sanPham = banHangDLL.findProductByCode(cbMaSP.Text);
            if (sanPham == null)
            {
                errorMaSP.SetError(cbMaSP, Messages.PRODUCT_CODE_ERROR);
                return;
            }

            sanPham.iSL = (int)nudSoLuong.Value;
            sanPham.fThanhTien = sanPham.iSL * sanPham.fDonGiaBan;

            bool isNewRow = true;
            float totalMoney = 0;

            foreach (DataGridViewRow row in dtgvDSSP.Rows)
            {
                if (row.Cells["maSP"].Value.ToString() == sanPham.sMaSP)
                {
                    isNewRow = false;

                    int quatity = (int)row.Cells["soLuong"].Value;
                    quatity += sanPham.iSL;
                    row.Cells["soLuong"].Value = quatity;
                    row.Cells["thanhTien"].Value = quatity * sanPham.fDonGiaBan;
                }

                totalMoney += (float)row.Cells["thanhTien"].Value;
            }

            if (isNewRow)
            {
                dtgvDSSP.Rows.Add(sanPham.sMaSP, sanPham.sTenSP, sanPham.sDonViTinh, sanPham.iSL, sanPham.fDonGiaBan, sanPham.fThanhTien);
                totalMoney += sanPham.fThanhTien;
            }

            cbMaSP.Text = "";
            txtDVT.Clear();
            txtDG.Clear();
            nudSoLuong.Value = 1;
            lbTongTien.Text = totalMoney.ToString();
            btnThanhToan.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            if (banHangDLL.isNotPhone(cbSDTKH.Text))
            {
                errorSDT.SetError(cbSDTKH, Messages.PHONE_ERROR);
                return;
            }

            if (String.IsNullOrEmpty(tbTenKH.Text))
            {
                errorTenKH.SetError(tbTenKH, Messages.NAME_OF_USER_ERROR);
                return;
            }

            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.sTenKH = tbTenKH.Text;
            khachHang.sSDT = cbSDTKH.Text;

            float totalMoney = float.Parse(lbTongTien.Text);
            String payments = cmbHinhThucThanhToan.Text;

            List<SanPhamDTO> sanPhams = new List<SanPhamDTO>();

            foreach (DataGridViewRow row in dtgvDSSP.Rows)
            {
                SanPhamDTO sanPham = new SanPhamDTO();
                sanPham.sMaSP = row.Cells["maSP"].Value.ToString();
                sanPham.sTenSP = row.Cells["tenSP"].Value.ToString();
                sanPham.sDonViTinh = row.Cells["donViTinh"].Value.ToString();
                sanPham.iSL = (int)row.Cells["soLuong"].Value;
                sanPham.fDonGiaBan = (float)row.Cells["donGia"].Value;
                sanPham.fThanhTien = (float)row.Cells["thanhTien"].Value;

                sanPhams.Add(sanPham);
            }

            String message;
            String receiptCode;

            bool result = banHangDLL.saveReceiptInfo(khachHang, sanPhams, payments, out message, out receiptCode);

            MessageBox.Show(message, "Message", MessageBoxButtons.OK);

            if (result)
            {
                cbSDTKH.Text = "";
                tbTenKH.Text = "";
                tbTenKH.Enabled = false;
                cbMaSP.Text = "";
                txtDVT.Text = "";
                txtDG.Text = "";
                nudSoLuong.Value = 1;
                lbTongTien.Text = "0";
                cmbHinhThucThanhToan.Text = "";
                dtgvDSSP.Rows.Clear();
                btnThanhToan.Enabled = false;

                showCrystalReport(khachHang, receiptCode, sanPhams, payments, totalMoney);
            }
        }

        private void showCrystalReport(KhachHangDTO khachHang, String receiptCode, List<SanPhamDTO> sanPhams, String payments, float totalMoney)
        {
            DataTable data = convertListSanPhamDtoToTable(sanPhams);
            ReportClass phieuThu = new CrystalReportPhieuThu();
            phieuThu.SetDataSource(data);
            crvPhieuThu.ReportSource = phieuThu;
            SetTextCrystal(phieuThu, "Section1", "rptMaPhieuThu", receiptCode);
            SetTextCrystal(phieuThu, "Section1", "rptDiaChi", "Sô 123 Thanh Xuân, Hà Nội");
            SetTextCrystal(phieuThu, "Section1", "rptDienThoaiCuaHang", "0123456789");
            SetTextCrystal(phieuThu, "Section1", "rptNguoiLap", Program.tenNV);
            SetTextCrystal(phieuThu, "Section1", "rptKhachHang", khachHang.sTenKH);
            SetTextCrystal(phieuThu, "Section1", "rptSoDienThoaiKhachHang", khachHang.sSDT);
            SetTextCrystal(phieuThu, "Section1", "rptHinhThucThanhToan", payments);
            SetTextCrystal(phieuThu, "Section3", "rptTongTien", totalMoney.ToString());
        }

        private void SetTextCrystal(ReportClass reportClass, string section, string Name, string value)
        {
            TextObject textObject = (TextObject)reportClass.ReportDefinition.Sections[section].ReportObjects[Name];
            textObject.Text = value;
        }

        private DataTable convertListSanPhamDtoToTable(List<SanPhamDTO> sanPhams)
        {
            DataTable data = new DataTable("dtPhieuThu");
            data.Columns.Add("maSP");
            data.Columns.Add("tenSP");
            data.Columns.Add("donViTinh");
            data.Columns.Add("soLuong");
            data.Columns.Add("DonGia");
            data.Columns.Add("ThanhTien");

            foreach (SanPhamDTO sanPham in sanPhams)
            {
                DataRow row = data.NewRow();
                row[0] = sanPham.sMaSP;
                row[1] = sanPham.sTenSP;
                row[2] = sanPham.sDonViTinh;
                row[3] = sanPham.iSL;
                row[4] = sanPham.fDonGiaBan;
                row[5] = sanPham.fThanhTien;

                data.Rows.Add(row);
            }

            return data;
        }

        private void dtgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0
                && dtgvDSSP.Columns[e.ColumnIndex].Name == "Delete"
                && MessageBox.Show("Delete", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataGridViewRow row = dtgvDSSP.Rows[e.RowIndex];
                float tongTien = float.Parse(lbTongTien.Text) - (float)row.Cells["thanhTien"].Value;
                lbTongTien.Text = tongTien.ToString();

                dtgvDSSP.Rows.RemoveAt(dtgvDSSP.SelectedRows[0].Index);

                if (dtgvDSSP.Rows.Count == 0)
                    btnThanhToan.Enabled = false;
            }

            if (e.RowIndex >= 0
                && dtgvDSSP.Columns[e.ColumnIndex].Name != "Delete")
            {
                btnSua.Enabled = true;
                DataGridViewRow rowEdit = dtgvDSSP.Rows[e.RowIndex];
                cbMaSP.Text = (string)rowEdit.Cells["maSP"].Value;
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            errorSoLuong.Clear();
        }

        private void cmbHinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorHinhThucTT.Clear();
        }

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {
            errorTenKH.Clear();
        }
    }
}
