using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTiemBanhMi.Object
{
    class NhanVien
    {
        private string id;
        private string tendangnhap;
        private string matkhau;
        private string tendaydu;
        private string diachi;
        private DateTime ngaytao;
        private bool xoa;
        private string ghichu;
        private string loainhanvienid;
        private string tenloai;
        public enum NhanVienFields
        {
            ID,
            TenDangNhap,
            MatKhau,
            TenDayDu,
            DiaChi,
            NgayTao,
            Xoa,
            GhiChu,
            LoaiNhanVienID,
            TenLoai
        }

        public NhanVien()
        {

        }

        public NhanVien(string id, string tendangnhap, string matkhau, string tendaydu, string diachi, DateTime ngaytao, string ghichu, string loainhanvienid)
        {
            this.id = id;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.tendaydu = tendaydu;
            this.diachi = diachi;
            this.ngaytao = ngaytao;
            this.ghichu = ghichu;
            this.loainhanvienid = loainhanvienid;
        }

        public string Id { get => id; set => id = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Tendaydu { get => tendaydu; set => tendaydu = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public bool Xoa { get => xoa; set => xoa = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Loainhanvienid { get => loainhanvienid; set => loainhanvienid = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
    }
}
