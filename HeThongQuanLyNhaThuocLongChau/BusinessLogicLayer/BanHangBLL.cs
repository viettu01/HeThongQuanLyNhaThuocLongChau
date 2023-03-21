using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    class BanHangBLL
    {
        BanHangDAL banHangDAL = new BanHangDAL();

        public DataTable findAllKhachHang() => banHangDAL.findAllKhachHang();

        public DataTable findKhachHangByPhone(String phone) => banHangDAL.findKhachHangByPhone(phone);

        public DataTable findAllMaSP() => banHangDAL.findAllMaSP();

        public DataTable findSanPhamByMaSP(String maSP) => banHangDAL.findSanPhamByMaSP(maSP);

        public DataTable getIdMaKhachHangCuoi() => banHangDAL.getIdMaKhachHangCuoi();

        public DataTable getIdMaPhieuThuCuoi() => banHangDAL.getIdMaPhieuThuCuoi();

        public Boolean insertPhieuThu(String maPT, String tg, String maNV, String maKH, String hinhThucTT) => banHangDAL.insertPhieuThu(maPT, tg, maNV, maKH, hinhThucTT);
        public Boolean insertCTPhieuThu(String maPT, String maSP, int soLuong) => banHangDAL.insertCTPhieuThu(maPT, maSP, soLuong);
    }
}
