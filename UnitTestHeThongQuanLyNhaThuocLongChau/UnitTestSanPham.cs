using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HeThongQuanLyNhaThuocLongChau;
using HeThongQuanLyNhaThuocLongChau.BusinessLogicLayer;
using HeThongQuanLyNhaThuocLongChau.DataAccessLayer;
using System.Data;

namespace UnitTestHeThongQuanLyNhaThuocLongChau
{
    [TestClass]
    public class UnitTestSanPham
    {
        SanPhamDAL sanPhamDAL;
        SanPhamBLL sanPhamBLL;
        string maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC, tenLoai, tenNCC;

        [TestInitialize]
        public void SetUp()
        {
            sanPhamDAL = new SanPhamDAL();
            sanPhamBLL = new SanPhamBLL();

            maSP = "SP001";
            tenSP = "Product 1";
            donViTinh = "Cái";
            hanDung = "1 năm";
            donGiaBan = "10000";
            maLoai = "L01";
            maNCC = "NCC01";

            tenLoai = "Thuốc giảm đau";
            tenNCC = "Công ty Cổ phần Dược liệu TW3";
        }


        [TestMethod]
        public void TestCheckTenSPAndLoaiSPIsExists()
        {
            tenSP = "Product 1";
            tenLoai = "Thuốc hướng tâm thần";

            //Act
            bool result = sanPhamBLL.checkExistsNameAndCategory(tenSP, tenLoai);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertWithAllParametersTrue()
        {
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestInsertWithEmptyMaSP()
        {
            maSP = "";
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertWithEmptyTenSP()
        {
            tenSP = "";
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertWithEmptyDonViTinh()
        {
            donViTinh = "";
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertWithEmptyHanDung()
        {
            hanDung = "";
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertWithEmptyDonGiaBan()
        {
            donGiaBan = "";
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertWithInvalidDonGiaBan()
        {
            donGiaBan = "abc";
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertWithEmptyMaLoai()
        {
            maLoai = "";
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestInsertWithEmptyMaNCC()
        {
            maNCC = "";
            //Act
            bool result = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void TestUpdateWithAllParametersTrue()
        {
            maSP = "SP6737806";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestUpdateWithEmptyMaSP()
        {
            maSP = "";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateWithEmptyTenSP()
        {
            tenSP = "";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateWithEmptyDonViTinh()
        {
            donViTinh = "";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateWithEmptyHanDung()
        {
            hanDung = "";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateWithEmptyDonGiaBan()
        {
            donGiaBan = "";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateWithInvalidDonGiaBan()
        {
            donGiaBan = "abc";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateWithEmptyMaLoai()
        {
            maLoai = "";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUpdateWithEmptyMaNCC()
        {
            maNCC = "";
            //Act
            bool result = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            //Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void TestDeleteWithEmptyMaSP()
        {
            maSP = "";
            //Act
            bool result = sanPhamBLL.deleteById(maSP);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestDeleteWithParametersTrue()
        {
            //Act
            bool result = sanPhamBLL.deleteById(maSP);
            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void TestSearchWithParametersTrueReturnRecord()
        {
            tenSP = "p";
            donViTinh = "";
            hanDung = "";
            donGiaBan = "";
            tenLoai = "";
            tenNCC = "";
            //Act
            var result = sanPhamBLL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC).Rows.Count;
            //Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TestSearchWithParametersTrueReturnNull()
        {
            tenSP = "z";
            donViTinh = "";
            hanDung = "";
            donGiaBan = "";
            tenLoai = "";
            tenNCC = "";
            //Act
            var result = sanPhamBLL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC).Rows.Count;
            //Assert
            Assert.IsFalse(result > 0);
        }

        [TestMethod]
        public void TestSearchWithAllParametersEmpty()
        {
            tenSP = "";
            donViTinh = "";
            hanDung = "";
            donGiaBan = "";
            tenLoai = "";
            tenNCC = "";
            //Act
            var result = sanPhamBLL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC);
            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestSearchWithLessThan0()
        {
            tenSP = "";
            donViTinh = "";
            hanDung = "";
            donGiaBan = "-1000";
            tenLoai = "";
            tenNCC = "";
            //Act
            var result = sanPhamBLL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC);
            //Assert
            Assert.IsNull(result);
        }
    }
}
