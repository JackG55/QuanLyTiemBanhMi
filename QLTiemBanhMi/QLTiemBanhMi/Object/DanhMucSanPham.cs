using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class DanhMucSanPham
    {
        private int madm;
        private string tendanhmuc;
        private bool xoa;

        public DanhMucSanPham()
        {

        }

        public DanhMucSanPham(int madm, string tendanhmuc)
        {
            this.madm = madm;
            this.tendanhmuc = tendanhmuc;
        }

        public int Madm { get => madm; set => madm = value; }
        public string Tendanhmuc { get => tendanhmuc; set => tendanhmuc = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
    }
}
