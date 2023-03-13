using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class PhieuThuBLL
    {
        public string maPT { get; set; }
        public string tgLap { get; set; }
        public string maNguoiLap { get; set; }
        public string maKH { get; set; }
        public string hinhThucTT { get; set; }

        public PhieuThuBLL() { }

        public PhieuThuBLL(string maPT, string tgLap, string maNguoiLap, string maKH, string hinhThucTT)
        {
            this.maPT = maPT;
            this.tgLap = tgLap;
            this.maNguoiLap = maNguoiLap;
            this.maKH = maKH;
            this.hinhThucTT = hinhThucTT;
        }
    }
}
