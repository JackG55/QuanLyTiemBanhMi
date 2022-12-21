using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class NguyenVatLieu
    {
        private string msnvl;
        private string tennvl;
        private string mota;
        private string slton;
        private bool xoa;
        private string dvt;

        public NguyenVatLieu()
        {
        }

        public NguyenVatLieu(string msnvl, string tennvl, string mota, string slton, string dvt)
        {
            this.msnvl = msnvl;
            this.tennvl = tennvl;
            this.mota = mota;
            this.slton = slton;
            this.dvt = dvt;
        }

        public string Msnvl { get => msnvl; set => msnvl = value; }
        public string Tennvl { get => tennvl; set => tennvl = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Slton { get => slton; set => slton = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Dvt { get => dvt; set => dvt = value; }
    }
}
