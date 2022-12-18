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
        private string mota;
        private int soluong;
        private int dongia;

        public ChiTietHoaDon()
        {
        }

        public int Mahd { get => mahd; set => mahd = value; }
        public int Masp { get => masp; set => masp = value; }
        public string Mota { get => mota; set => mota = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }

        //public ChiTietHoaDon(string id, string hoadonid, string sanphamid, string soluong, string giaban, string vat, string tienloi, bool xoa, string ghichu)
        //{
        //    this.id = id;
        //    this.hoadonid = hoadonid;
        //    this.sanphamid = sanphamid;
        //    this.soluong = soluong;
        //    this.giaban = giaban;
        //    this.vat = vat;
        //    this.tienloi = tienloi;
        //    this.xoa = xoa;
        //    this.ghichu = ghichu;
        //}


    }
}
