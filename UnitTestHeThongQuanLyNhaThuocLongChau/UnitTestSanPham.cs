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
        bool expected, actual;

        [TestInitialize]
        public void SetUp()
        {
            sanPhamDAL = new SanPhamDAL();
            sanPhamBLL = new SanPhamBLL();

            maSP = "SP002";
            tenSP = "Product 2";
            donViTinh = "Cái";
            hanDung = "1 năm";
            donGiaBan = "10000";
            maLoai = "L01";
            maNCC = "NCC01";

            tenLoai = "Thuốc giảm đau";
            tenNCC = "Công ty Cổ phần Dược liệu TW3";
        }

        #region CheckExist
        [TestMethod]
        public void TestCheckExistsNameAndCategoryWithTenSPAndLoaiSPNotExists()
        {
            tenSP = "Tiffy 2";
            tenLoai = "Thuốc kháng sinh 2";

            expected = true;
            bool actual = sanPhamBLL.checkExistsNameAndCategory(tenSP, tenLoai);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckExistsNameAndCategoryWithTenSPNotExistsAndLoaiSPExists()
        {
            tenSP = "Tiffy 2";
            tenLoai = "Thuốc kháng sinh";

            expected = true;
            bool actual = sanPhamBLL.checkExistsNameAndCategory(tenSP, tenLoai);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckExistsNameAndCategoryWithTenSPExistsAndLoaiSPNotExists()
        {
            tenSP = "Tiffy";
            tenLoai = "Thuốc kháng sinh 2";

            expected = true;
            bool actual = sanPhamBLL.checkExistsNameAndCategory(tenSP, tenLoai);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckExistsNameAndCategoryWithTenSPAndLoaiSPExists()
        {
            tenSP = "Tiffy";
            tenLoai = "Thuốc kháng sinh";

            expected = false;
            bool actual = sanPhamBLL.checkExistsNameAndCategory(tenSP, tenLoai);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Thêm sản phẩm
        [TestMethod]
        public void TestInsertWithAllParametersTrue()
        {
            maSP = "SP001";
            tenSP = "Product 1";

            expected = true;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithEmptyMaSP()
        {
            maSP = "";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithEmptyTenSP()
        {
            tenSP = "";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithEmptyDonViTinh()
        {
            donViTinh = "";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithEmptyHanDung()
        {
            hanDung = "";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithEmptyDonGiaBan()
        {
            donGiaBan = "";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithInvalidDonGiaBan()
        {
            donGiaBan = "abc";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithDonGiaBanLessThanZero()
        {
            donGiaBan = "-100";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithEmptyMaLoai()
        {
            maLoai = "";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInsertWithEmptyMaNCC()
        {
            maNCC = "";

            expected = false;
            actual = sanPhamBLL.insert(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Sửa sản phẩm
        [TestMethod]
        public void TestUpdateWithAllParametersTrue()
        {
            maSP = "SP001";
            tenSP = "Product 3";

            expected = true;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateWithEmptyMaSP()
        {
            maSP = "";
            tenSP = "Product 3";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateWithEmptyTenSP()
        {
            maSP = "SP001";
            tenSP = "";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateWithEmptyDonViTinh()
        {
            maSP = "SP001";
            donViTinh = "";
            tenSP = "Product 3";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateWithEmptyHanDung()
        {
            maSP = "SP001";
            hanDung = "";
            tenSP = "Product 3";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateWithEmptyDonGiaBan()
        {
            maSP = "SP001";
            donGiaBan = "";
            tenSP = "Product 3";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateWithInvalidDonGiaBan()
        {
            maSP = "SP001";
            donGiaBan = "abc";
            tenSP = "Product 3";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestUpdateWithDonGiaBanLessThanZero()
        {
            maSP = "SP001";
            donGiaBan = "-100";
            tenSP = "Product 3";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateWithEmptyMaLoai()
        {
            maSP = "SP001";
            maLoai = "";
            tenSP = "Product 3";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateWithEmptyMaNCC()
        {
            maSP = "SP001";
            maNCC = "";
            tenSP = "Product 3";

            expected = false;
            actual = sanPhamBLL.update(maSP, tenSP, donViTinh, hanDung, donGiaBan, maLoai, maNCC);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Xóa sản phẩm
        [TestMethod]
        public void TestDeleteWithEmptyMaSP()
        {
            maSP = "";

            expected = false;
            actual = sanPhamBLL.deleteById(maSP);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteWithMaSPNotExists()
        {
            maSP = "SP002";

            expected = false;
            actual = sanPhamBLL.deleteById(maSP);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteWithParametersTrue()
        {
            maSP = "SP001";

            expected = true;
            actual = sanPhamBLL.deleteById(maSP);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Tìm kiếm sản phẩm
        [TestMethod]
        public void TestSearchWithTenSPExists()
        {
            tenSP = "Product 1";
            donViTinh = "";
            hanDung = "";
            donGiaBan = "";
            tenLoai = "";
            tenNCC = "";

            expected = true;
            //Act
            actual = sanPhamBLL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC).Rows.Count > 0;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSearchWithTenSPNotExists()
        {
            tenSP = "Product 3";
            donViTinh = "";
            hanDung = "";
            donGiaBan = "";
            tenLoai = "";
            tenNCC = "";

            expected = false;
            actual = sanPhamBLL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC).Rows.Count > 0;
            
            Assert.AreEqual(expected, actual);
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

            DataTable expected = null;
            DataTable actual = sanPhamBLL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSearchWithGiaBanLessThanZero()
        {
            tenSP = "";
            donViTinh = "";
            hanDung = "";
            donGiaBan = "-100";
            tenLoai = "";
            tenNCC = "";

            DataTable expected = null;
            DataTable actual = sanPhamBLL.search(tenSP, donViTinh, hanDung, donGiaBan, tenLoai, tenNCC);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
