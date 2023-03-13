using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class LoaiSanPham
    {
        public string maLoaiSP { get; set; }
        public string tenLoaiSP { get; set; }

        public LoaiSanPham()
        {
        }

        public LoaiSanPham(string maLoaiSP, string tenLoaiSP)
        {
            this.maLoaiSP = maLoaiSP;
            this.tenLoaiSP = tenLoaiSP;
        }
    }
}
