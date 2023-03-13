using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class KhachHangBLL
    {
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string SDT { get; set; }

        public KhachHangBLL() { }

        public KhachHangBLL(string maKH, string tenKH, string sDT)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            SDT = sDT;
        }
    }
}
