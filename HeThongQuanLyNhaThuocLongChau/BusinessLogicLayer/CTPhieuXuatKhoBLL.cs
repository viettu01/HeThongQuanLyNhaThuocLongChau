using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class CTPhieuXuatKhoBLL
    {
        public string maPX { get; set; }
        public string maSP { get; set; }
        public long soLuongYeuCau { get; set; }
        public long soLuongXuat { get; set; }
        public string ghiChu { get; set; }

        public CTPhieuXuatKhoBLL() { }

        public CTPhieuXuatKhoBLL(string maPX, string maSP, long soLuongYeuCau, long soLuongXuat, string ghiChu)
        {
            this.maPX = maPX;
            this.maSP = maSP;
            this.soLuongYeuCau = soLuongYeuCau;
            this.soLuongXuat = soLuongXuat;
            this.ghiChu = ghiChu;
        }
    }
}
