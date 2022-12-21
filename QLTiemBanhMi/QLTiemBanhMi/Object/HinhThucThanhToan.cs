using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class HinhThucThanhToan
    {
        private int mathanhtoan;
        private string tenloaihinhthucthanhtoan;
        private bool xoa;


        public HinhThucThanhToan()
        {

        }

        public int Mathanhtoan { get => mathanhtoan; set => mathanhtoan = value; }
        public string Tenloaihinhthucthanhtoan { get => tenloaihinhthucthanhtoan; set => tenloaihinhthucthanhtoan = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
    }
}
