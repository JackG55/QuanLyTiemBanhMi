using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class HoaDon
    {
        private int mahd;
        private int manv;
        private int makh;
        private int mathanhtoan;
        private DateTime ngaytao;
        private string tongtien;       
        private bool xoa;

        public HoaDon()
        {

        }

        public int Mahd { get => mahd; set => mahd = value; }
        public int Manv { get => manv; set => manv = value; }
        public int Makh { get => makh; set => makh = value; }
        public int Mathanhtoan { get => mathanhtoan; set => mathanhtoan = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public bool Xoa { get => xoa; set => xoa = value; }

        //public HoaDon(string id, string tenhoadon, string congtyid, string nhanvienid, DateTime ngaylap, string tongtien, 
        //                string tongtiendathanhtoan, DateTime ngayhenthanhtoan, string tienloi, string hoahong, 
        //                string nguoinhanhoahongid,string ghichu)
        //{
        //    this.id = id;
        //    this.tenhoadon = tenhoadon;
        //    this.congtyid = congtyid;
        //    this.nhanvienid = nhanvienid;
        //    this.ngaylap = ngaylap;
        //    this.tongtien = tongtien;
        //    this.tongtiendathanhtoan = tongtiendathanhtoan;
        //    this.ngayhenthanhtoan = ngayhenthanhtoan;
        //    this.tienloi = tienloi;
        //    this.hoahong = hoahong;
        //    this.nguoinhanhoahongid = nguoinhanhoahongid;
        //    this.ghichu = ghichu;
        //}


    }
}
