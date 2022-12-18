using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class NhaCungCap
    {
        private int mancc;
        private string tenncc;
        private string diachi;
        private string sdt;     
        private bool xoa;

        public int Mancc { get => mancc; set => mancc = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
    }
}
