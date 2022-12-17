using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class LoiHeThong
    {
        private int id;
        private string tenloi;
        private string tenham;
        private bool xoa;
        private string ghichu;

        public int Id { get => id; set => id = value; }
        public string Tenloi { get => tenloi; set => tenloi = value; }
        public string Tenham { get => tenham; set => tenham = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
