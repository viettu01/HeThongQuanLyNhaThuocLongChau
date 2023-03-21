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
    public partial class BanHang : Form
    {
        BanHangBLL banHangDLL = new BanHangBLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        List<SanPham> listSanPhamThem;
        SanPham sanPhanChon;

        public BanHang()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            Load_cbSDTKH();
            Load_cbMaSP();
            listSanPhamThem = new List<SanPham>();
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
            if (!String.IsNullOrEmpty(cbSDTKH.Text))
            {
                DataTable khacHangs = banHangDLL.findKhachHangByPhone(cbSDTKH.Text);
                DataView v = new DataView(khacHangs);
                if (v.Count > 0)
                {
                    tbTenKH.Text = (string)v[0]["Tên KH"];
                    tbTenKH.Enabled = false;
                }
                else
                {
                    tbTenKH.Text = "";
                    tbTenKH.Enabled = true;
                }
            }
            else tbTenKH.Enabled = false;
        }

        private void cbSDTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable khacHangs = banHangDLL.findKhachHangByPhone(cbSDTKH.Text);
            DataView v = new DataView(khacHangs);
            if (v.Count > 0)
            {
                tbTenKH.Text = (string)v[0]["Tên KH"];
                tbTenKH.Enabled = false;
            }
            else
            {
                tbTenKH.Text = "";
                tbTenKH.Enabled = true;
            }
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable khacHangs = banHangDLL.findSanPhamByMaSP(cbMaSP.Text);
            DataView v = new DataView(khacHangs);
            if (v.Count > 0)
            {
                txtDVT.Text = (string)v[0]["sDonViTinh"];
                txtDG.Text = v[0]["fDonGiaBan"].ToString();

                sanPhanChon = new SanPham();
                sanPhanChon.maSP = (string)v[0]["PK_sMaSP"];
                sanPhanChon.tenSP = (string)v[0]["sTenSP"];
                sanPhanChon.donGia = float.Parse(v[0]["fDonGiaBan"].ToString());
            }
            else
            {
                txtDVT.Text = "";
                txtDG.Text = "";
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbSDTKH.Text = "";
            tbTenKH.Text = "";
            tbTenKH.Enabled = false;
            cbMaSP.Text = "";
            txtDVT.Text = "";
            txtDG.Text = "";
            nudSoLuong.Value = 1;
        }

        private class SanPham
        {
            public String maSP { set; get; }
            public String tenSP { set; get; }
            public int soLuong { set; get; }
            public float donGia { set; get; }
            public float thanhTien { set; get; }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (sanPhanChon != null)
            {
                SanPham sanPhamThem = new SanPham();
                sanPhamThem.maSP = sanPhanChon.maSP;
                sanPhamThem.tenSP = sanPhanChon.tenSP;
                sanPhamThem.donGia = sanPhanChon.donGia;
                sanPhamThem.soLuong = (int)nudSoLuong.Value;
                sanPhamThem.thanhTien = sanPhamThem.soLuong * sanPhamThem.donGia;

                listSanPhamThem.Add(sanPhamThem);

                BindingSource binding = new BindingSource();
                binding.DataSource = listSanPhamThem;

                dtgvDSSP.DataSource = binding;

                cbMaSP.Text = "";
                txtDVT.Text = "";
                txtDG.Text = "";
                nudSoLuong.Value = 1;

                float tongTien = 0;
                foreach(SanPham sp in listSanPhamThem){
                    tongTien += sp.thanhTien;
                }

                lbTongTien.Text = tongTien.ToString();

                sanPhanChon = null;
                btnThanhToan.Enabled = true;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (listSanPhamThem.Count != 0)
            {
                if (String.IsNullOrEmpty(cbSDTKH.Text))
                {
                    cbSDTKH.Focus();
                    return;
                }

                if (String.IsNullOrEmpty(cmbHinhThucThanhToan.Text)){
                    cmbHinhThucThanhToan.Focus();
                    return;
                }

                DataTable khacHangs = banHangDLL.findKhachHangByPhone(tbTenKH.Text);
                DataView vKachHangs = new DataView(khacHangs);
                int idKH;
                bool insertKhachHangSuccess = false;
                if (vKachHangs.Count > 0)
                {
                    idKH = int.Parse(vKachHangs[0]["Mã KH"].ToString());
                    insertKhachHangSuccess = true;
                }
                else
                {
                    DataTable khachHangCuoi = banHangDLL.getIdMaKhachHangCuoi();
                    DataView vKachHangCuoi = new DataView(khachHangCuoi);
                    if (vKachHangCuoi.Count > 0)
                        idKH = int.Parse(vKachHangCuoi[0]["PK_sMaKH"].ToString());
                    else
                        idKH = 0;

                    idKH++;
                    insertKhachHangSuccess = khachHangBLL.insert(idKH.ToString(), tbTenKH.Text, cbSDTKH.Text);
                }

                if (!insertKhachHangSuccess)
                {
                    cbSDTKH.Focus();
                    return;
                }

                DataTable phieuThuCuoi = banHangDLL.getIdMaPhieuThuCuoi();
                DataView vPhieuThuCuoi = new DataView(phieuThuCuoi);
                int idPT;
                if (vPhieuThuCuoi.Count != 0)
                    idPT = int.Parse(vPhieuThuCuoi[0]["PK_sMaPT"].ToString());
                else
                    idPT = 0;

                idPT++;

                bool insertPhieuThuSuccess = banHangDLL.insertPhieuThu(idPT.ToString(), "20220202", 
                    Program.maNV, idKH.ToString(), cmbHinhThucThanhToan.Text);

                if (!insertPhieuThuSuccess)
                {
                    cbMaSP.Focus();
                    return;
                }

                foreach(SanPham sp in listSanPhamThem)
                {
                    banHangDLL.insertCTPhieuThu(idPT.ToString(), sp.maSP, sp.soLuong);
                }

                cbSDTKH.Text = "";
                tbTenKH.Text = "";
                tbTenKH.Enabled = false;
                cbMaSP.Text = "";
                txtDVT.Text = "";
                txtDG.Text = "";
                nudSoLuong.Value = 1;
                lbTongTien.Text = "0";
                listSanPhamThem.Clear();
                BindingSource binding = new BindingSource();
                binding.DataSource = listSanPhamThem;

                dtgvDSSP.DataSource = binding;
            }
        }
    }
}
