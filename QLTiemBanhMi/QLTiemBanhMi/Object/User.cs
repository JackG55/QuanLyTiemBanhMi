using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    public class User
    {
        private string id;
        private string tendangnhap;
        private string matkhau;
        private string tendaydu;
        private string tenloai;
        List<string> quyenid;

        public string Id { get => id; set => id = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Tendaydu { get => tendaydu; set => tendaydu = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public List<string> Quyenid { get => quyenid; set => quyenid = value; }
    }
}
