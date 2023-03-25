using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using HeThongQuanLyNhaThuocLongChau.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    class BanHangBLL
    {
        BanHangDAL banHangDAL = new BanHangDAL();
        KhachhangDAL khachhangDAL = new KhachhangDAL();

        public DataTable findAllKhachHang() => banHangDAL.findAllKhachHang();


        public DataTable findAllMaSP() => banHangDAL.findAllMaSP();

        public bool isNotPhone(String phone)
        {
            return !Regex.Match(phone, Const.REGEX_PHONE).Success;
        }

        public String findNameOfUserByPhone(String phone)
        {
            if (String.IsNullOrEmpty(phone))
                return "";

            DataTable dataTable = banHangDAL.findKhachHangByPhone(phone);
            DataView dataView = new DataView(dataTable);

            if (dataView.Count <= 0)
                return "";

            return (String)dataView[0]["Tên KH"];
        }

        public SanPhamDTO findProductByCode(String code)
        {
            if (String.IsNullOrEmpty(code))
                return null;

            DataTable dataTable = banHangDAL.findSanPhamByMaSP(code);
            DataView dataView = new DataView(dataTable);

            if (dataView.Count <= 0)
                return null;

            SanPhamDTO dto = new SanPhamDTO();
            dto.sMaSP = (string)dataView[0]["PK_sMaSP"];
            dto.sTenSP = (string)dataView[0]["sTenSP"];
            dto.sDonViTinh = (string)dataView[0]["sDonViTinh"];
            dto.sHanDung = (string)dataView[0]["sHanDung"];
            dto.iSL = (int)dataView[0]["iSL"];
            dto.fDonGiaBan = float.Parse(dataView[0]["fDonGiaBan"].ToString());
            dto.sMaLoai = (string)dataView[0]["FK_sMaLoai"];
            dto.sNhaCungCap = (string)dataView[0]["FK_sNhaCungCap"];

            return dto;
        }

        public bool saveReceiptInfo(KhachHangDTO khachHang, List<SanPhamDTO> sanPhams, String payments, out String message, out String receiptCode)
        {
            try
            {
                String maKH = getOrCreateNewUserCode(khachHang);

                String maPT = createNewReceiptCode(maKH, payments);
                receiptCode = maPT;

                foreach (SanPhamDTO sanPham in sanPhams)
                    banHangDAL.insertCTPhieuThu(maPT, sanPham.sMaSP, sanPham.iSL);
            }
            catch (Exception e)
            {
                message = e.Message;
                receiptCode = "";
                return false;
            }

            message = "Thành Công";
            return true;
        }

        private String getOrCreateNewUserCode(KhachHangDTO khachHang)
        {
            DataTable dataTableKH = banHangDAL.findKhachHangByPhone(khachHang.sSDT);
            DataView dataViewKH = new DataView(dataTableKH);
            if (dataViewKH.Count > 0)
                return dataViewKH[0]["Mã KH"].ToString();

            String maKh = "0";

            DataTable dataTableLastRow = banHangDAL.getIdMaKhachHangCuoi();
            DataView dataViewLastRow = new DataView(dataTableLastRow);
            if (dataViewLastRow.Count > 0)
            {
                int ma = int.Parse(dataViewLastRow[0]["PK_sMaKH"].ToString());
                ma++;
                maKh = ma.ToString();
            }

            khachhangDAL.insert(maKh, khachHang.sTenKH, khachHang.sSDT);

            return maKh;
        }

        private String createNewReceiptCode(String userCode, String payments)
        {
            String maRec = "0";
            DataTable dataTable = banHangDAL.getIdMaPhieuThuCuoi();
            DataView dataView = new DataView(dataTable);

            if (dataView.Count != 0)
            {
                int ma = int.Parse(dataView[0]["PK_sMaPT"].ToString());
                ma++;
                maRec = ma.ToString();
            }

            banHangDAL.insertPhieuThu(maRec, DateTime.Now.ToString("yyyyMMdd"), Program.maNV, userCode, payments);

            return maRec;
        }
    }
}
