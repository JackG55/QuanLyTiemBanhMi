using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class CongTy
    {
        private string id;
        private string tencongty;
        private string diachi;
        private string sodienthoai;
        private string fax;
        private DateTime ngaytao;
        private bool xoa;
        private string ghichu;

        public string Id { get => id; set => id = value; }
        public string Tencongty { get => tencongty; set => tencongty = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Fax { get => fax; set => fax = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
