using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    public class User
    {
        private int manv;
        private string username;
        private string pass;
        private string chucvu;
        private string tennv;

        public int Manv { get => manv; set => manv = value; }
        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Tennv { get => tennv; set => tennv = value; }
    }
}
