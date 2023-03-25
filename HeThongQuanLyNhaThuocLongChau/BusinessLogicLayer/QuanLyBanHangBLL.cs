using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer
{
    class QuanLyBanHangBLL
    {
        public static bool findAllPhieuThuSuccess(out DataTable data, out String message)
        {
            data = PhieuThuDAL.findAllPhieuThu();
            if (data == null)
            {
                message = "Lỗi khi load data";
                return false;
            }

            message = "Thành công";
            return true;
        }

        public static bool findChiTietPhieuThuSuccess(String maPT, out DataTable data, out String message)
        {
            data = PhieuThuDAL.findChiTietPhieuThuByMaPT(maPT);
            if (data == null)
            {
                message = "Lỗi khi load data";
                return false;
            }

            message = "Thành công";
            return true;
        }

        public static bool findPhieuThuByInfosSuccess(String maPT, String tenNV, DateTime ngayBD, DateTime ngayKT, out DataTable data, out String message)
        {
            String query = "SELECT * FROM vv_PhieuThu AS pt WHERE (1=1) ";
            if (!String.IsNullOrEmpty(maPT))
                query += " AND pt.PK_sMaPT LIKE '%"+maPT+"%'";

            if (!String.IsNullOrEmpty(tenNV))
                query += " AND pt.sHoTen LIKE '%" + tenNV + "%'";

            if (ngayBD != null)
                query += " AND pt.dTgLap >= '" + ngayBD.ToString("yyyyMMdd") + "'";

            if (ngayKT != null)
                query += " AND pt.dTgLap <= '" + ngayKT.ToString("yyyyMMdd") + "'";

            data = PhieuThuDAL.findPhieuThuWithCustomQuery(query);
            if (data == null)
            {
                message = "Lỗi khi load data";
                return false;
            }

            message = "Thành công";
            return true;
        }

        public static bool deleteByMaPT(string maPT, out String message)
        {
            if (String.IsNullOrEmpty(maPT)){
                message = "Bạn chưa chọn phiếu cần xóa!";
                return false;
            }

            int numOfAffected = PhieuThuDAL.deleteByMaPT(maPT);

            if (numOfAffected < 0)
            {
                message = "Mã sản phẩm không tồn tại!";
                return false;
            }

            message = "Thành công";
            return true;
        }
    }
}
