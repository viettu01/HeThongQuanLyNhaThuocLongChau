using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class TaiKhoanBLL
    {
        public string maTK { get; set; }
        public string tenTK { get; set; }
        public string matKhau { get; set; }
        public string maQuyen { get; set; }

        public TaiKhoanBLL() { }

        public TaiKhoanBLL(string maTK, string tenTK, string matKhau, string maQuyen)
        {
            this.maTK = maTK;
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.maQuyen = maQuyen;
        }
    }
}
