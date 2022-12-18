using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class CaLam
    {
        private int macalam;
        private string batdau;
        private string ketthuc;
        private bool xoa;

        public int Macalam { get => macalam; set => macalam = value; }
        public string Batdau { get => batdau; set => batdau = value; }
        public string Ketthuc { get => ketthuc; set => ketthuc = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
    }
}
