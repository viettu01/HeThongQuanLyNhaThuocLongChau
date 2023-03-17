using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    public class KhachHangBLL
    {
        KhachhangDAL KhachhangDAL = new KhachhangDAL();
        public DataTable findAll()
        {
            return KhachhangDAL.findAll();
        }

        public bool insert(string PK_sMaKH, string sTenKH, string sSDT)
        {
            return KhachhangDAL.insert(PK_sMaKH, sTenKH, sSDT);
        }

        public bool update(string PK_sMaKH, string sTenKH, string sSDT)
        {
            return KhachhangDAL.update(PK_sMaKH, sTenKH, sSDT);
        }

        public bool deleteById(string PK_sMaKH)
        {
            return KhachhangDAL.deleteById(PK_sMaKH);
        }


        public DataTable searchById(String PK_sMaKH)
        {
            return KhachhangDAL.searchById(PK_sMaKH);
        }
    }
}
