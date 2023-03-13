using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class LoaiSanPhamBLL
    {
        public string maLoai { get; set; }
        public string tenLoai { get; set; }

        public LoaiSanPhamBLL() { }

        public LoaiSanPhamBLL(string maLoai, string tenLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
        }
    }
}
