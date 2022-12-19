using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class NhanVien
    {
        private int manv;
        private string tennv;
        private string username;
        private string pass;
        private string namsinh;
       
        private bool xoa;
        private string diachi;
        private string chucvu;
        private string gioitinh;

        public int Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }

        
        public NhanVien()
        {

        }

        public NhanVien(int manv, string tennv, string username, string pass, string namsinh, string diachi, string chucvu, string gioitinh)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.username = username;
            this.pass = pass;
            this.namsinh = namsinh;
            this.diachi = diachi;
            this.chucvu = chucvu;
            this.gioitinh = gioitinh;
        }
    }
}
