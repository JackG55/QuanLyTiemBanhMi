using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class SanPham
    {
        private int masp;
        private string tensp;
        private string mota;
        private int madm;
        private int giaban;
        
        private bool xoa;

        public SanPham()
        {

        }

        public SanPham(int masp, string tensp, string mota, int madm, int giaban)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.mota = mota;
            this.madm = madm;
            this.giaban = giaban;
        }

        public int Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Mota { get => mota; set => mota = value; }
        public int Madm { get => madm; set => madm = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public bool Xoa { get => xoa; set => xoa = value; }

    }
}
