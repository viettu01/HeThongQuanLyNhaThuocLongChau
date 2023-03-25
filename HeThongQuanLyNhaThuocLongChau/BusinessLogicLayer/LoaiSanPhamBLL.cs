using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL loaiSanPhamDAL = new LoaiSanPhamDAL();

        public DataTable findAll()
        {
            return loaiSanPhamDAL.findAll();
        }
    }
}
