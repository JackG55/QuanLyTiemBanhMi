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

    }
}
