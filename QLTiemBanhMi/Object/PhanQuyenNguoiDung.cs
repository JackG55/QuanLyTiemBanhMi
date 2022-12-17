using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class PhanQuyenNguoiDung
    {
        private string id;
        private bool xoa;
        private string quyenthaotacid;
        private string nhanvienid;
        private string tenquyen;

        
        public string Id { get => id; set => id = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Quyenthaotacid { get => quyenthaotacid; set => quyenthaotacid = value; }
        public string Nhanvienid { get => nhanvienid; set => nhanvienid = value; }
        public string Tenquyen { get => tenquyen; set => tenquyen = value; }
    }
}
