using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyNhaThuocLongChau.Model
{
    public class SanPham
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string donViTinh { get; set; }
        public string hanSuDung { get; set; }
        public long soLuongTon { get; set; }
        public double donGiaBan { get; set; }
        public string maLoai { get; set; }

        public SanPham() { }

        public SanPham(string maSP, string tenSP, string donViTinh, string hanSuDung, long soLuongTon, double donGiaBan, string maLoai)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donViTinh = donViTinh;
            this.hanSuDung = hanSuDung;
            this.soLuongTon = soLuongTon;
            this.donGiaBan = donGiaBan;
            this.maLoai = maLoai;
        }
    }
}
