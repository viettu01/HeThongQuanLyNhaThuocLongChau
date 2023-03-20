using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using HeThongQuanLyNhaThuocLongChau.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyNhaThuocLongChau
{
    static class Program
    {
        public static string maQuyenQuanLy = "Q01";
        public static string maQuyenBanHang = "Q02";
        public static string maQuyenKho = "Q03";

        public static string tenNV, maTK, maQuyen, tenTK;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new QuanLyKho());

        }
    }
}
