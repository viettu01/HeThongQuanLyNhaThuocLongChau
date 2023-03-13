using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    class NhaCungCapBLLcs
    {
        public string maNCC { get; set; }
        public string tenNCC { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public string soTK { get; set; }

        public NhaCungCapBLLcs() { }

        public NhaCungCapBLLcs(string maNCC, string tenNCC, string diaChi, string sDT, string soTK)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            SDT = sDT;
            this.soTK = soTK;
        }
    }
}