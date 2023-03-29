using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HeThongQuanLyNhaThuocLongChau;
using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System.Data;

namespace UnitTestHeThongQuanLyNhaThuocLongChau
{
    [TestClass]
    public class UnitTestDangNhap
    {
        TaiKhoanDAL taiKhoanDAL;
        TaiKhoanBLL taiKhoanBLL;

        [TestInitialize]
        public void SetUp()
        {
            taiKhoanDAL = new TaiKhoanDAL();
            taiKhoanBLL = new TaiKhoanBLL();
        }

        [TestMethod]
        public void TestMethodDALFindByUsername()
        {
            bool expected = true;
            bool actual = taiKhoanDAL.findByUsername("admin").Rows.Count > 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLLogin()
        {
            int expected, actual;
            expected = 2; //Kết quả mong đợi
            actual = taiKhoanBLL.login("admin", "123"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }
    }
}
