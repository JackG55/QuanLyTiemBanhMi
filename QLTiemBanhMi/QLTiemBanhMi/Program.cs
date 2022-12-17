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
        public static QuanLyChung quanlychung;
        
        public static DangNhap dangnhap;
        public static User user;
        public static quanlynhanviensql Quanlynhanviensql;
        public static quanlysanphamsql Quanlysanphamsql;
        public static quantrihethongsql Quantrihethongsql;
        public static quanlyhoadonsql Quanlyhoadonsql;

        public static List<QuyenThaoTac> PhanQuyenList;
        public static NhanVien nhanvien;
        public static LoaiNhanVien chiTietLoaiNV;

        public static HoaDon hoaDon;
        public static ChiTietHoaDon chiTietHoaDon;
        public static SanPham sanpham;
        public static DonVi chiTietDonVi;
        public static GiaBanSanPham giabanSanPham;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dangnhap = new DangNhap();

            //khai báo sql
            Quanlynhanviensql = new quanlynhanviensql();
            Quanlyhoadonsql = new quanlyhoadonsql();
            Quanlysanphamsql = new quanlysanphamsql();
            Quantrihethongsql = new quantrihethongsql();

            //khai báo object để sử dụng
            hoaDon = new HoaDon();
            chiTietHoaDon = new ChiTietHoaDon();

            nhanvien = new NhanVien();
            chiTietLoaiNV = new LoaiNhanVien();

            sanpham = new SanPham();
            chiTietDonVi = new DonVi();
            giabanSanPham = new GiaBanSanPham();
            user = new User();

            PhanQuyenList = new List<QuyenThaoTac>();

            Application.Run(new QuanLyNghiepVu.QuanLyKho.Kho());
        }
    }
}
