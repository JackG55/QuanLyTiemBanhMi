using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTiemBanhMi.QuanLyNghiepVu;
using QLTiemBanhMi.QuanTriHeThong;
using QLTiemBanhMi.Object;
using QLTiemBanhMi.Connector;

namespace QLTiemBanhMi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int opt;
        
        public static DangNhap dangnhap;
        public static User user;
        public static fillData FillData;


        /// <summary>
        /// Khai báo các biến static liên quan đến Kho
        /// </summary>
        public static NhaCungCap nhaCungCap;
        public static NguyenVatLieu nguyenVatLieu;
        public static PhieuNhapHang phieuNhapHang;
        public static ChiTietPhieuNhapHang chiTietPhieuNhapHang;

        /// <summary>
        /// Khai báo các biến static liên quan đến NhanVien
        /// </summary>
        public static NhanVien nhanvien;

        /// <summary>
        /// Khai báo các biến static liên quan đến KhachHang
        /// </summary>
        public static KhachHang khachHang;

        /// <summary>
        /// Khai báo các biến static liên quan đến BanHang
        /// </summary>
        public static ChiTietHoaDon chiTietHoaDon;




        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dangnhap = new DangNhap();

            //khai báo sql
            FillData = new fillData();

            //khai báo object để sử dụng
            user = new User();

            //KHO
            //Nhà cung cấp
            nhaCungCap = new NhaCungCap();

            //Nguyên vật liệu
            nguyenVatLieu = new NguyenVatLieu();

            //Phiếu nhập hàng
            phieuNhapHang = new PhieuNhapHang();

            //Chi tiết phiếu nhập hàng
            chiTietPhieuNhapHang = new ChiTietPhieuNhapHang();

            //NHÂN VIÊN
            //Nhân viên
            nhanvien = new NhanVien();

            //BÁN HÀNG
            //Khách hàng
            khachHang = new KhachHang();
            chiTietHoaDon = new ChiTietHoaDon();


            Application.Run(new QuanTriHeThong.DangNhap());
        }
    }
}
