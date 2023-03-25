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
    public partial class QuanLyBanHang : Form
    {
        public QuanLyBanHang()
        {
            InitializeComponent();
        }

        private void QuanLyBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Tạo Form đích và hiển thị nó
                TrangChu trangChu = new TrangChu();
                trangChu.Show();
            }
        }

        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {
            Load_PhieuThu();
            dtpNgayBDPT.Value = DateTime.Today.AddMonths(-1);
            dtpNgayKTPT.Value = DateTime.Today;
        }

        private void Load_PhieuThu()
        {
            DataTable dataTable;
            String message;
            if (!QuanLyBanHangBLL.findAllPhieuThuSuccess(out dataTable, out message))
            {
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                return;
            }

            dgvPT.DataSource = dataTable;
        }

        private void dgvPT_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvPT.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                String maPT = (string)dgvPT.Rows[e.RowIndex].Cells[1].Value;
                DataTable dataTable;
                String message;
                if (!QuanLyBanHangBLL.findChiTietPhieuThuSuccess(maPT, out dataTable, out message))
                {
                    MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                    return;
                }

                dgvSPPT.DataSource = dataTable;

                cmbMaSPPT.DataSource = dataTable;
                cmbMaSPPT.DisplayMember = "PK_sMaSP";
                cmbMaSPPT.ValueMember = "PK_sMaSP";
                cmbMaSPPT.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbMaSPPT.AutoCompleteSource = AutoCompleteSource.ListItems;

                btnXoaPT.Enabled = true;
            }
        }

        private void btnTimKiemPT_Click(object sender, EventArgs e)
        {
            DataTable dataTable;
            String message;
            if (!QuanLyBanHangBLL.findPhieuThuByInfosSuccess(txtMaPT.Text, txtTenNVPT.Text, dtpNgayBDPT.Value, dtpNgayKTPT.Value, out dataTable, out message))
            {
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                return;
            }

            dgvPT.DataSource = dataTable;
        }

        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            String message;
            String maPT = "";

            if (dgvPT.SelectedRows.Count > 0)
                maPT = dgvPT.SelectedRows[0].Cells[1].Value.ToString();

            if (!QuanLyBanHangBLL.deleteByMaPT(maPT, out message))
            {
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                return;
            }

            clearAll();
        }

        private void btnLamMoiPT_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            cmbMaSPPT.DataSource = null;
            cmbMaSPPT.Items.Clear();
            cmbMaSPPT.Refresh();
            dgvSPPT.DataSource = null;
            dgvSPPT.Rows.Clear();
            dgvSPPT.Refresh();
            txtTenSPPT.Clear();
            txtMaPT.Clear();
            txtTenNVPT.Clear();
            dtpNgayBDPT.Value = DateTime.Today.AddMonths(-1);
            dtpNgayKTPT.Value = DateTime.Today;
            Load_PhieuThu();
            btnXoaPT.Enabled = false;
        }

        private void btnTimKiemSPPT_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvSPPT.DataSource;
            bs.Filter = "[" + dgvSPPT.Columns[0].DataPropertyName + "] LIKE '%" + cmbMaSPPT.Text + "%' AND [" + dgvSPPT.Columns[1].DataPropertyName + "] LIKE '%" + txtTenSPPT.Text + "%'";
            dgvSPPT.DataSource = bs;
        }
    }
}
