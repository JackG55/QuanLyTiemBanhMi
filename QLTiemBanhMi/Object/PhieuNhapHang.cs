using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class PhieuNhapHang
    {
        private int maphieunhap;
        private int mancc;
        private int manv;
        private int tongtien;
        private DateTime ngaytao;
        private bool xoa;

        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public int Mancc { get => mancc; set => mancc = value; }
        public int Manv { get => manv; set => manv = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
    }
}
