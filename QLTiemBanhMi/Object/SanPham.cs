using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class SanPham
    {
        private string id;
        private string tensanpham;
        private string quycach;
        private string donviid;
        private string soluongton;
        private DateTime ngaytao;
        private bool xoa;
        private string ghichu;
        private string nguonnhap;

        public SanPham()
        {

        }

        public SanPham(string id, string tensanpham, string quycach, string donviid, string soluongton, DateTime ngaytao, string ghichu, string nguonnhap)
        {
            this.id = id;
            this.tensanpham = tensanpham;
            this.quycach = quycach;
            this.donviid = donviid;
            this.soluongton = soluongton;
            this.ngaytao = ngaytao;
            this.ghichu = ghichu;
            this.nguonnhap = nguonnhap;
        }

        public string Id { get => id; set => id = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public string Quycach { get => quycach; set => quycach = value; }
        public string Donviid { get => donviid; set => donviid = value; }
        public string Soluongton { get => soluongton; set => soluongton = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Nguonnhap { get => nguonnhap; set => nguonnhap = value; }
    }
}
