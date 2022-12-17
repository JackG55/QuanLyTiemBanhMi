using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class NguoiDaiDien
    {
        private int id;
        private string tennguoidaidien;
        private string dienthoai;
        private int congtyid;
        private DateTime ngaytao;
        private bool xoa;
        private string ghichu;

        public int Id { get => id; set => id = value; }
        public string Tennguoidaidien { get => tennguoidaidien; set => tennguoidaidien = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public int Congtyid { get => congtyid; set => congtyid = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
