using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class ChiTietHoaDon
    {
        private string id;
        private string hoadonid;
        private string sanphamid;
        private string soluong;
        private string giaban;
        private string vat;
        private string tienloi;
        private bool xoa;
        private string ghichu;

        public ChiTietHoaDon()
        {
        }

        public ChiTietHoaDon(string id, string hoadonid, string sanphamid, string soluong, string giaban, string vat, string tienloi, bool xoa, string ghichu)
        {
            this.id = id;
            this.hoadonid = hoadonid;
            this.sanphamid = sanphamid;
            this.soluong = soluong;
            this.giaban = giaban;
            this.vat = vat;
            this.tienloi = tienloi;
            this.xoa = xoa;
            this.ghichu = ghichu;
        }

        public string Id { get => id; set => id = value; }
        public string Hoadonid { get => hoadonid; set => hoadonid = value; }
        public string Sanphamid { get => sanphamid; set => sanphamid = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Giaban { get => giaban; set => giaban = value; }
        public string Vat { get => vat; set => vat = value; }
        public string Tienloi { get => tienloi; set => tienloi = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
