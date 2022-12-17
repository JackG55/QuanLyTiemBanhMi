using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class Key
    {
        private int id;
        private string timedateline;
        private bool xoa;

        public int Id { get => id; set => id = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Timedateline { get => timedateline; set => timedateline = value; }
    }
}
