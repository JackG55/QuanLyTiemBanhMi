using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class DonVi
    {
        private string id;
        private string tendonvi;
        private bool xoa;
        private string ghichu;

        public DonVi()
        {

        }

        public DonVi(string id, string tendonvi, string ghichu)
        {
            this.id = id;
            this.tendonvi = tendonvi;
            this.ghichu = ghichu;
        }

        public string Id { get => id; set => id = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }
    }
}
