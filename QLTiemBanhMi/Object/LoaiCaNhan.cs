using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class LoaiCaNhan
    {
        private string id;
        private string tenloai;
        private DateTime ngaytao;
        private bool xoa;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
