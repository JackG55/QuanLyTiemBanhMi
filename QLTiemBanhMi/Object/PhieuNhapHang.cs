using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class PhieuNhapHang
    {
        private string maphieunhap;
        private string mancc;
        private string manv;
        private string tongtien;
        private DateTime ngaytao;
        private bool xoa;

        public PhieuNhapHang()
        {
        }

        public PhieuNhapHang(string maphieunhap, string mancc, string manv, string tongtien, DateTime ngaytao)
        {
            this.maphieunhap = maphieunhap;
            this.mancc = mancc;
            this.manv = manv;
            this.tongtien = tongtien;
            this.ngaytao = ngaytao;
        }

        public string Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
    }
}
