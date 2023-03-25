using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    class NhaCungCapBLL
    {
        NhaCungCapDAL nhaCungCapDAL = new NhaCungCapDAL();

        public DataTable findAll()
        {
            return nhaCungCapDAL.findAll();
        }
    }
}
