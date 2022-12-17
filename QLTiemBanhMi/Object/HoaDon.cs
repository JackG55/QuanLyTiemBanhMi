using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class HoaDon
    {
        private string id;
        private string tenhoadon;
        private string congtyid;
        private string nhanvienid;
        private DateTime ngaylap;
        private string tongtien;
        private string tongtiendathanhtoan;
        private DateTime ngayhenthanhtoan;
        private string tienloi;
        private string hoahong;
        private string nguoinhanhoahongid;
        private bool xoa;
        private string ghichu;

        public HoaDon()
        {

        }

        public HoaDon(string id, string tenhoadon, string congtyid, string nhanvienid, DateTime ngaylap, string tongtien, 
                        string tongtiendathanhtoan, DateTime ngayhenthanhtoan, string tienloi, string hoahong, 
                        string nguoinhanhoahongid,string ghichu)
        {
            this.id = id;
            this.tenhoadon = tenhoadon;
            this.congtyid = congtyid;
            this.nhanvienid = nhanvienid;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.tongtiendathanhtoan = tongtiendathanhtoan;
            this.ngayhenthanhtoan = ngayhenthanhtoan;
            this.tienloi = tienloi;
            this.hoahong = hoahong;
            this.nguoinhanhoahongid = nguoinhanhoahongid;
            this.ghichu = ghichu;
        }

        public string Id { get => id; set => id = value; }
        public string Tenhoadon { get => tenhoadon; set => tenhoadon = value; }
        public string Congtyid { get => congtyid; set => congtyid = value; }
        public string Nhanvienid { get => nhanvienid; set => nhanvienid = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string Tongtiendathanhtoan { get => tongtiendathanhtoan; set => tongtiendathanhtoan = value; }
        public DateTime Ngayhenthanhtoan { get => ngayhenthanhtoan; set => ngayhenthanhtoan = value; }
        public string Tienloi { get => tienloi; set => tienloi = value; }
        public string Hoahong { get => hoahong; set => hoahong = value; }
        public string Nguoinhanhoahongid { get => nguoinhanhoahongid; set => nguoinhanhoahongid = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
