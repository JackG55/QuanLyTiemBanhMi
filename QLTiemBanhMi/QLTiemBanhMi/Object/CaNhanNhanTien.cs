using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class CaNhanNhanTien
    {
        private string id;
        private string ten;
        private string dienthoai;
        private string fax;
        private string diachi;
        private bool xoa;
        private string ghichu;
        private string loaiid;

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Loaiid { get => loaiid; set => loaiid = value; }
    }
}
