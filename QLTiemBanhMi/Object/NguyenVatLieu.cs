using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class NguyenVatLieu
    {
        private int msnvl;
        private string tennvl;
        private string mota;
        private int slton;
        private bool xoa;
        private string dvt;

        public int Msnvl { get => msnvl; set => msnvl = value; }
        public string Tennvl { get => tennvl; set => tennvl = value; }
        public string Mota { get => mota; set => mota = value; }
        public int Slton { get => slton; set => slton = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Dvt { get => dvt; set => dvt = value; }
    }
}
