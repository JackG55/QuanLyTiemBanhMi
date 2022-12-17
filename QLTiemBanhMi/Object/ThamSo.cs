using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class ThamSo
    {
        private int id;
        private int giatri;
        private bool xoa;
        private string ghichu;
        private int sanphamid;

        public int Id { get => id; set => id = value; }
        public int Giatri { get => giatri; set => giatri = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public int Sanphamid { get => sanphamid; set => sanphamid = value; }
    }
}
