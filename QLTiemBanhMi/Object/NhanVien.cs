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

        public enum NhanVienFields
        {
            MaNV,
            TenNV,
            UserName,
            Pass,
            NamSinh,
            DiaChi,
            Xoa,
            ChucVu,
            GioiTinh
        }

        public NhanVien()
        {

        }


        //public NhanVien(string id, string tendangnhap, string matkhau, string tendaydu, string diachi, DateTime ngaytao, string ghichu, string loainhanvienid)
        //{
        //    this.id = id;
        //    this.tendangnhap = tendangnhap;
        //    this.matkhau = matkhau;
        //    this.tendaydu = tendaydu;
        //    this.diachi = diachi;
        //    this.ngaytao = ngaytao;
        //    this.ghichu = ghichu;
        //    this.loainhanvienid = loainhanvienid;
        //}

     
    }
}
