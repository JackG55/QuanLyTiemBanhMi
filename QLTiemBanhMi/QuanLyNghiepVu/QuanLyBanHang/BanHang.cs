using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTiemBanhMi.Connector;
using QLTiemBanhMi.Object;

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyBanHang
{
    public partial class BanHang: Form
    {
        
        public BanHang()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            //load lên datagridView khách hàng
            string sql1 = @"SELECT dbo.KhachHang.*, TenLoaiKH
                            FROM dbo.KhachHang, dbo.LoaiKH
                            WHERE KhachHang.MaLoaiKH = LoaiKH.MaLoaiKH AND KhachHang.Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_khachhang, sql1);

            //load lên datagridView hoá đơn
            string sql2 = @"SELECT dbo.HoaDon.*, dbo.HinhThucThanhToan.*,dbo.KhachHang.HoTen
                    FROM dbo.HoaDon JOIN dbo.HinhThucThanhToan ON HinhThucThanhToan.MaThanhToan = HoaDon.MaThanhToan 
                    JOIN dbo.KhachHang ON KhachHang.MaKH = HoaDon.MaKH WHERE HoaDon.Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_hoadon, sql2);
        }

        private void dataGridViewDSHoaDon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = dgv_hoadon.CurrentRow.Cells["MaHD"].Value.ToString();
            //Lay ds chi tiet lịch làm việc của mỗi nv
            string sql = @"SELECT dbo.ChiTietHoaDon.*, TenSP
                            FROM dbo.HoaDon, dbo.ChiTietHoaDon, dbo.SanPham
                            WHERE ChiTietHoaDon.MaHD=HoaDon.MaHD AND ChiTietHoaDon.MaSP = SanPham.MaSP AND HoaDon.MaHD = "+int.Parse(mahd)+"";
            Program.FillData.LoadDS_Len_DataGridView(dgv_chitiethoadon, sql);
        }

        private void chiTietKH_UpdateEventHandler1(object sender, ChiTietKH.UpdateEventArgs args)
        {

            string sql1 = @"SELECT dbo.KhachHang.*, TenLoaiKH
                            FROM dbo.KhachHang, dbo.LoaiKH
                            WHERE KhachHang.MaLoaiKH = LoaiKH.MaLoaiKH AND KhachHang.Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_khachhang, sql1);

        }
        private void thongTinHD_UpdateEventHandler1(object sender, ThongTinHD.UpdateEventArgs args)
        {
            string sql2 = @"SELECT dbo.HoaDon.*, dbo.HinhThucThanhToan.*,dbo.KhachHang.HoTen
                    FROM dbo.HoaDon JOIN dbo.HinhThucThanhToan ON HinhThucThanhToan.MaThanhToan = HoaDon.MaThanhToan 
                    JOIN dbo.KhachHang ON KhachHang.MaKH = HoaDon.MaKH WHERE HoaDon.Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_hoadon, sql2);

        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ChiTietKH chiTietKH = new ChiTietKH(this);
            chiTietKH.UpdateEventHandler += chiTietKH_UpdateEventHandler1;
            chiTietKH.ShowDialog();
        }

        private void btn_suakh_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ChiTietKH chiTietKH = new ChiTietKH(this);
            chiTietKH.UpdateEventHandler += chiTietKH_UpdateEventHandler1;
            chiTietKH.ShowDialog();
        }

        private void btn_taohd_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ThongTinHD thongTinHD = new ThongTinHD(this);
            thongTinHD.UpdateEventHandler += thongTinHD_UpdateEventHandler1;
            thongTinHD.ShowDialog();
        }

        private void dgv_khachhang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy các trường thông tin để nếu mà sửa thì sửa
            string makh = dgv_khachhang.CurrentRow.Cells["MaKH"].Value.ToString();
            string maloaikh = dgv_khachhang.CurrentRow.Cells["MaLoaiKH"].Value.ToString();
            string hoten = dgv_khachhang.CurrentRow.Cells["HoTen"].Value.ToString();
            string ngaysinh = dgv_khachhang.CurrentRow.Cells["NgaySinh"].Value.ToString();
            string gioitinh = dgv_khachhang.CurrentRow.Cells["GioiTinh"].Value.ToString();
            string sdt = dgv_khachhang.CurrentRow.Cells["SDT"].Value.ToString();
            string diemtichluy = dgv_khachhang.CurrentRow.Cells["DiemTichLuy"].Value.ToString();

            //Tạo 1 Object để phục vụ cho thêm sửa xoá
            Program.khachHang = new Object.KhachHang(int.Parse(makh),int.Parse(maloaikh),hoten,ngaysinh,gioitinh,sdt,int.Parse(diemtichluy),false);
        }
    }
}
