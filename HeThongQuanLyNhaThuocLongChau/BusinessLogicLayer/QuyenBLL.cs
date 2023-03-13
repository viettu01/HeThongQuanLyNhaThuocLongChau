using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    class QuyenBLL
    {
        public string maQuyen { get; set; }
        public string tenQuyen { get; set; }

        public QuyenBLL() { }

        public QuyenBLL(string maQuyen, string tenQuyen)
        {
            this.maQuyen = maQuyen;
            this.tenQuyen = tenQuyen;
        }
    }
}
