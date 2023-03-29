using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HeThongQuanLyNhaThuocLongChau;
using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System.Data;

namespace UnitTestHeThongQuanLyNhaThuocLongChau
{
    [TestClass]
    public class UnitTestDoiMatKhau
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
            bool expected, actual;
            expected = true;
            actual = taiKhoanDAL.findByUsername("admin").Rows.Count > 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLCheckPassword()
        {
            bool expected, actual;
            expected = true; //Kết quả mong đợi
            actual = taiKhoanBLL.checkPassword("admin", "Phamtu123"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLChangePassword()
        {
            bool expected, actual;
            expected = true; //Kết quả mong đợi
            actual = taiKhoanBLL.changePassword("admin", "Phamtu123"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }
    }
}
