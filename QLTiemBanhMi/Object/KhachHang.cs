using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class KhachHang
    {
        private int makh;
        private int maloaikh;
        private string hoten;
        private string ngaysinh;
        private string gioitinh;
        private string sdt;
        private int diemtichluy;
        private bool xoa;

        public int Makh { get => makh; set => makh = value; }
        public int Maloaikh { get => maloaikh; set => maloaikh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Diemtichluy { get => diemtichluy; set => diemtichluy = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
    }
}
