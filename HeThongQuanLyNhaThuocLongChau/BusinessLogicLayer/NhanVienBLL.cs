using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class NhanVienBLL
    {
        public string maNV { get; set; }
        public string maTK { get; set; }
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string ngayVaoLam { get; set; }
        public string cVu { get; set; }

        public NhanVienBLL() { }

        public NhanVienBLL(string maNV, string maTK, string hoTen, string ngaySinh, string cCCD, string sDT, string ngayVaoLam, string cVu)
        {
            this.maNV = maNV;
            this.maTK = maTK;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            CCCD = cCCD;
            SDT = sDT;
            this.ngayVaoLam = ngayVaoLam;
            this.cVu = cVu;
        }
    }
}
