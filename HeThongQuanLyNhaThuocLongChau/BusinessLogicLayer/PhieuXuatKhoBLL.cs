using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class PhieuXuatKhoBLL
    {
        public string maPX { get; set; }
        public string tgLap { get; set; }
        public string maNguoiLap { get; set; }
        public string maNguoiLay { get; set; }

        public PhieuXuatKhoBLL() { }

        public PhieuXuatKhoBLL(string maPX, string tgLap, string maNguoiLap, string maNguoiLay)
        {
            this.maPX = maPX;
            this.tgLap = tgLap;
            this.maNguoiLap = maNguoiLap;
            this.maNguoiLay = maNguoiLay;
        }
    }
}
