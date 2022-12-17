using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class LoaiNhanVien
    {
        private string id;
        private string tenloai;
        private bool xoa;
        private string ghichu;

        public LoaiNhanVien()
        {

        }

        public LoaiNhanVien(string id, string tenloai, string ghichu)
        {
            this.id = id;
            this.tenloai = tenloai;
            this.ghichu = ghichu;
        }

        public string Id { get => id; set => id = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
