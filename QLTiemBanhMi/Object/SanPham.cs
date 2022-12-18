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
        private string anhsp;
        
        private bool xoa;

        public SanPham()
        {

        }

        public int Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Mota { get => mota; set => mota = value; }
        public int Madm { get => madm; set => madm = value; }
        public string Anhsp { get => anhsp; set => anhsp = value; }
        public bool Xoa { get => xoa; set => xoa = value; }

        //public SanPham(string id, string tensanpham, string quycach, string donviid, string soluongton, DateTime ngaytao, string ghichu, string nguonnhap)
        //{
        //    this.id = id;
        //    this.tensanpham = tensanpham;
        //    this.quycach = quycach;
        //    this.donviid = donviid;
        //    this.soluongton = soluongton;
        //    this.ngaytao = ngaytao;
        //    this.ghichu = ghichu;
        //    this.nguonnhap = nguonnhap;
        //}


    }
}
