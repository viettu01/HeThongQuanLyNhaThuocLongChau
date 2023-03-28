using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HeThongQuanLyNhaThuocLongChau;
using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System.Data;

namespace UnitTestHeThongQuanLyNhaThuocLongChau
{
    [TestClass]
    public class UnitTestTaiKhoan
    {
        [TestMethod]
        public void TestMethodDALLogin()
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            bool expected = true;
            bool actual = taiKhoanDAL.findByUsername("admin").Rows.Count > 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLLogin()
        {
            TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
            int expected, actual;
            expected = 2; //Kết quả mong đợi
            actual = taiKhoanBLL.login("admin", "123"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDALFindByUsername()
        {
            TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            int expected, actual;
            expected = 1; //Kết quả mong đợi
            actual = taiKhoanDAL.findByUsername("admin").Rows.Count; //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }
    }
}
