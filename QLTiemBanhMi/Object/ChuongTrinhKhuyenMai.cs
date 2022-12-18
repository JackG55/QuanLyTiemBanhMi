using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class ChuongTrinhKhuyenMai
    {
        private int makm;
        private string tenkm;
        private int phantramgiamgia;
        private bool xoa;
        private DateTime ngaybatdau;
        private DateTime ngayketthuc;

        public int Makm { get => makm; set => makm = value; }
        public string Tenkm { get => tenkm; set => tenkm = value; }
        public int Phantramgiamgia { get => phantramgiamgia; set => phantramgiamgia = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public DateTime Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public DateTime Ngayketthuc { get => ngayketthuc; set => ngayketthuc = value; }
    }
}
