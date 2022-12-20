using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class ChiTietPhieuNhapHang
    {
        private string maphieunhap;
        private string msnvl;
        private string dongia;
        private string sl;

        public ChiTietPhieuNhapHang()
        {
        }

        public ChiTietPhieuNhapHang(string maphieunhap, string msnvl, string dongia, string sl)
        {
            this.maphieunhap = maphieunhap;
            this.msnvl = msnvl;
            this.dongia = dongia;
            this.sl = sl;
        }

        public string Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public string Msnvl { get => msnvl; set => msnvl = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Sl { get => sl; set => sl = value; }
    }
}
