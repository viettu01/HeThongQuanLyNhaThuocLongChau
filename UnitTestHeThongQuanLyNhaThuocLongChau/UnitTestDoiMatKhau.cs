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
        bool expected, actual;

        [TestInitialize]
        public void SetUp()
        {
            taiKhoanDAL = new TaiKhoanDAL();
            taiKhoanBLL = new TaiKhoanBLL();
        }

        [TestMethod]
        public void TestMethodDALFindByUsernameWithUsernameNotExists()
        {
            expected = false;
            actual = taiKhoanDAL.findByUsername("admin123").Rows.Count > 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDALFindByUsernameWithUsernameExists()
        {
            expected = true;
            actual = taiKhoanDAL.findByUsername("admin").Rows.Count > 0;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethodBLLCheckPasswordWithPasswordFalse()
        {
            expected = false; //Kết quả mong đợi
            actual = taiKhoanBLL.checkPassword("admin", "123"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLCheckPasswordWithPasswordTrue()
        {
            expected = true; //Kết quả mong đợi
            actual = taiKhoanBLL.checkPassword("admin", "Phamtu123"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethodBLLChangePasswordWithUsernameEmpty()
        {
            expected = false; //Kết quả mong đợi
            actual = taiKhoanBLL.changePassword("", "123"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLChangePasswordWithUsernameNotExists()
        {
            expected = false; //Kết quả mong đợi
            actual = taiKhoanBLL.changePassword("admin123", "Phamtu123"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLChangePasswordWithPasswordEmpty()
        {
            expected = false; //Kết quả mong đợi
            actual = taiKhoanBLL.changePassword("admin", ""); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLChangePasswordWithPasswordNotStrength()
        {
            expected = false; //Kết quả mong đợi
            actual = taiKhoanBLL.changePassword("admin", "Phamtu"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBLLChangePasswordWithUsernameAndPasswordTrue()
        {
            expected = true; //Kết quả mong đợi
            actual = taiKhoanBLL.changePassword("admin", "Phamtu1234"); //Kết quả thực tế

            Assert.AreEqual(expected, actual);
        }
    }
}
