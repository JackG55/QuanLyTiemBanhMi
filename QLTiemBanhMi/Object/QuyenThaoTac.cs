using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class QuyenThaoTac
    {
        private string id;
        private string tenquyen;
        private bool xoa;
        private string ghichu;
        public enum QuyenThaoTacFields
        {
            ID,
            TenQuyen,
            Xoa,
            GhiChu
        }
        public bool Check { get; set; }
        public string Id { get => id; set => id = value; }
        public string Tenquyen { get => tenquyen; set => tenquyen = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
