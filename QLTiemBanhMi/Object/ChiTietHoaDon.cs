using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class ChiTietHoaDon
    {
        private int mahd;
        private int masp;
        private string tensp;
        private int soluong;
        private int dongia;

        public ChiTietHoaDon()
        {

        }

        public ChiTietHoaDon(int masp, string tensp, int soluong, int dongia)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.soluong = soluong;
            this.dongia = dongia;
        }

        public int Mahd { get => mahd; set => mahd = value; }
        public int Masp { get => masp; set => masp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Tensp { get => tensp; set => tensp = value; }
    }
}
