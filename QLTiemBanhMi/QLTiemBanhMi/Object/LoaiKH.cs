using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class LoaiKH
    {
        private int maloaikh;
        private string tenloaikh;
        private bool xoa;
        private int sodiemtichluy;

        public LoaiKH()
        {

        }

        public int Maloaikh { get => maloaikh; set => maloaikh = value; }
        public string Tenloaikh { get => tenloaikh; set => tenloaikh = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public int Sodiemtichluy { get => sodiemtichluy; set => sodiemtichluy = value; }

        //public LoaiKH(string id, string tenloai, string ghichu)
        //{
        //    this.id = id;
        //    this.tenloai = tenloai;
        //    this.ghichu = ghichu;
        //}


    }
}
