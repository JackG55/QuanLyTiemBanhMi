using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class ChiTietThanhToan
    {
        private int id;
        private int hoadonid;
        private string tienthanhtoan;
        private DateTime ngaythanhtoan;
        private DateTime ngaythanhtoantieptheo;
        private bool xoa;
        private string ghichu;

        public int Id { get => id; set => id = value; }
        public int Hoadonid { get => hoadonid; set => hoadonid = value; }
        public string Tienthanhtoan { get => tienthanhtoan; set => tienthanhtoan = value; }
        public DateTime Ngaythanhtoan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public DateTime Ngaythanhtoantieptheo { get => ngaythanhtoantieptheo; set => ngaythanhtoantieptheo = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
