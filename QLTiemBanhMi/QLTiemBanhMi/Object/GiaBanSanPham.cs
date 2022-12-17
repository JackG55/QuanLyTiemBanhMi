using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class GiaBanSanPham
    {
        private string id;
        private string sanphamid;
        private string giaban;
        private string nhanviencapnhatid;
        private DateTime ngaycapnhat;
        private bool xoa;
        private string ghichu;


        public GiaBanSanPham()
        {

        }

        public GiaBanSanPham(string id, string sanphamid, string giaban, string nhanviencapnhatid, DateTime ngaycapnhat, string ghichu)
        {
            this.id = id;
            this.sanphamid = sanphamid;
            this.giaban = giaban;
            this.nhanviencapnhatid = nhanviencapnhatid;
            this.ngaycapnhat = ngaycapnhat;
            this.ghichu = ghichu;
        }

        public string Id { get => id; set => id = value; }
        public string Sanphamid { get => sanphamid; set => sanphamid = value; }
        public string Giaban { get => giaban; set => giaban = value; }
        public string Nhanviencapnhatid { get => nhanviencapnhatid; set => nhanviencapnhatid = value; }
        public DateTime Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
