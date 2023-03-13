using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class CTPhieuThuBLL
    {
        public string maPT { get; set; }
        public string maSP { get; set; }
        public string soLuongBan { get; set; }

        public CTPhieuThuBLL() { }

        public CTPhieuThuBLL(string maPT, string maSP, string soLuongBan)
        {
            this.maPT = maPT;
            this.maSP = maSP;
            this.soLuongBan = soLuongBan;
        }
    }
}
