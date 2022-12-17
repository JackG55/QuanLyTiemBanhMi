using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class NhapSanPham
    {
        private int id;
        private int sanphamid;
        private int soluong;
        private string gianhap;
        private int nhanvienid;
        private DateTime ngaynhap;
        private bool xoa;
        private string ghichu;

        public int Id { get => id; set => id = value; }
        public int Sanphamid { get => sanphamid; set => sanphamid = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Gianhap { get => gianhap; set => gianhap = value; }
        public int Nhanvienid { get => nhanvienid; set => nhanvienid = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
