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

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyKho
{
    public partial class Kho: Form
    {
        List<string> tenquyen_hoadon = new List<string>() { "BanHang", "DanhSachHoaDon","SuaHoaDon", "SuaChiTietHoaDon" };
        public Kho()
        {
            InitializeComponent();
        }


        private void Kho_Load(object sender, EventArgs e)
        {
            
            //load lên datagridView Nhà cung cấp
            string sql1 = "SELECT * FROM dbo.NhaCungCap WHERE Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSNCC, sql1);

            //load lên datagridView Danh sách phiếu nhập hàng
            string sql2 = "SELECT MaPhieuNhap, TenNCC, TenNV, NgayTao, TongTien, NhaCungCap.MaNCC, NhanVien.MaNV FROM dbo.PhieuNhapHang " +
                          "JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = PhieuNhapHang.MaNCC " +
                          "JOIN dbo.NhanVien ON NhanVien.MaNV = PhieuNhapHang.MaNV " +
                          "WHERE PhieuNhapHang.Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSPNH, sql2);

            //load lên datagridView Nguyên Vật Liệu           
            string sql3 = "SELECT * FROM dbo.NguyenVatLieu WHERE Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSNVL, sql3);

            //load lên datagridView Chi tiết phiếu nhập hàng
            string maPhieuNhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
            string sql4 = "SELECT MaPhieuNhap, dbo.ChiTietPhieuNhapHang.MSNVL, TenNVL, DonGia, SL FROM dbo.ChiTietPhieuNhapHang " +
                           "JOIN dbo.NguyenVatLieu ON NguyenVatLieu.MSNVL = ChiTietPhieuNhapHang.MSNVL " +
                           "WHERE MaPhieuNhap = " + maPhieuNhap;
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSCTPNH, sql4);
        }

        private void dgv_DSNCC_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy các trường thông tin để nếu mà sửa thì sửa
            string mancc = dgv_DSNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            string tenncc = dgv_DSNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            string diachi = dgv_DSNCC.CurrentRow.Cells["DiaChi"].Value.ToString();
            string sdt = dgv_DSNCC.CurrentRow.Cells["SDT"].Value.ToString();

            //Tạo 1 Object để phục vụ cho thêm sửa xoá
            Program.nhaCungCap = new Object.NhaCungCap(mancc, tenncc, diachi, sdt);
        }

        private void dgv_DSNVL_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy các trường thông tin để nếu mà sửa thì sửa
            string msnvl = dgv_DSNVL.CurrentRow.Cells["MSNVL"].Value.ToString();
            string tennvl = dgv_DSNVL.CurrentRow.Cells["TenNVL"].Value.ToString();
            string mota = dgv_DSNVL.CurrentRow.Cells["MoTa"].Value.ToString();
            string slton = dgv_DSNVL.CurrentRow.Cells["SLTon"].Value.ToString();
            string dvt = dgv_DSNVL.CurrentRow.Cells["DVT"].Value.ToString();

            //Tạo 1 Object để phục vụ cho thêm sửa xoá
            Program.nguyenVatLieu = new Object.NguyenVatLieu(msnvl, tennvl, mota, slton, dvt);
        }

        private void dataGridViewPhieuNhapHang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            //load lại cái chi tiết phiếu nhập hàng
            string maPhieuNhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
            string sql4 = "SELECT ChiTietPhieuNhapHang.MSNVL, TenNVL, DonGia, SL FROM dbo.ChiTietPhieuNhapHang " +
                           "JOIN dbo.NguyenVatLieu ON NguyenVatLieu.MSNVL = ChiTietPhieuNhapHang.MSNVL WHERE MaPhieuNhap = " + maPhieuNhap;
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSCTPNH, sql4);

            //Lấy các trường thông tin để nếu mà sửa thì sửa
            string maphieunhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
            string mancc = dgv_DSPNH.CurrentRow.Cells["MaNhaCC"].Value.ToString();
            string manv = dgv_DSPNH.CurrentRow.Cells["MaNV"].Value.ToString();
            string tongtien = dgv_DSPNH.CurrentRow.Cells["TongTien"].Value.ToString();
            string ngaytao = dgv_DSPNH.CurrentRow.Cells["NgayTao"].Value.ToString();

            //Tạo 1 Object để phục vụ cho thêm sửa xoá
            Program.phieuNhapHang = new Object.PhieuNhapHang(maphieunhap, mancc, manv, tongtien,Convert.ToDateTime(ngaytao));

        }

        private void dtgv_DSChiTietPhieuNhapHang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy các trường thông tin để nếu  mà sửa thì sửa
            string maphieunhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
            string msnvl = dgv_DSCTPNH.CurrentRow.Cells["MSNVLL"].Value.ToString();
            string dongia = dgv_DSCTPNH.CurrentRow.Cells["DonGia"].Value.ToString();
            string sl = dgv_DSCTPNH.CurrentRow.Cells["SL"].Value.ToString();

            //Tạo 1 Object để phục vụ cho thêm sửa xoá
            Program.chiTietPhieuNhapHang = new Object.ChiTietPhieuNhapHang(maphieunhap, msnvl, dongia, sl);
        }


        #region ThemSuaXoa_NhaCungCap
        private void chiTietNCC_UpdateEventHandler1(object sender, ChiTietNCC.UpdateEventArgs args)
        {

            //load lên datagridView Nhà cung cấp
            string sql1 = "SELECT * FROM dbo.NhaCungCap WHERE Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSNCC, sql1);
        }

        private void btn_themncc_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ChiTietNCC chiTietNCC = new ChiTietNCC();
            chiTietNCC.UpdateEventHandler += chiTietNCC_UpdateEventHandler1;
            chiTietNCC.ShowDialog();
        }

        private void btn_suancc_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ChiTietNCC chiTietNCC = new ChiTietNCC();
            chiTietNCC.UpdateEventHandler += chiTietNCC_UpdateEventHandler1;
            chiTietNCC.ShowDialog();
        }

        private void btn_xoancc_Click(object sender, EventArgs e)
        {
            string sql = "Xoa_NCC";
            string[] para = { "@MaNCC" };

            string mancc = dgv_DSNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            object[] values = { Int32.Parse(mancc) };
            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            if (a != 0)
            {
                DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    //load lên datagridView Nhà cung cấp
                    string sql1 = "SELECT * FROM dbo.NhaCungCap WHERE Xoa = 0";
                    Program.FillData.LoadDS_Len_DataGridView(dgv_DSNCC, sql1);
                }
            }
            else
            {
                MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region ThemSuaXoa_NguyenVatLieu
        private void chiTietNVL_UpdateEventHandler1(object sender, ChiTietNVL.UpdateEventArgs args)
        {

            //load lên datagridView Nguyên Vật Liệu           
            string sql3 = "SELECT * FROM dbo.NguyenVatLieu WHERE Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSNVL, sql3);
        }
        private void btn_themnvl_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ChiTietNVL chiTietNVL = new ChiTietNVL();
            chiTietNVL.UpdateEventHandler += chiTietNVL_UpdateEventHandler1;
            chiTietNVL.ShowDialog();
        }

        private void btn_suanvl_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ChiTietNVL chiTietNVL = new ChiTietNVL();
            chiTietNVL.UpdateEventHandler += chiTietNVL_UpdateEventHandler1;
            chiTietNVL.ShowDialog();
        }

        private void btn_xoanvl_Click(object sender, EventArgs e)
        {
            string sql = "Xoa_NVL";
            string[] para = { "@MaNVL" };

            string manvl = dgv_DSNVL.CurrentRow.Cells["MSNVL"].Value.ToString();
            object[] values = { Int32.Parse(manvl) };
            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            if (a != 0)
            {
                DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    //load lên datagridView Nguyên Vật Liệu           
                    string sql3 = "SELECT * FROM dbo.NguyenVatLieu";
                    Program.FillData.LoadDS_Len_DataGridView(dgv_DSNVL, sql3);
                }
            }
            else
            {
                MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region ThemSuaXoa_PhieuNhapHang

        private void PhieuNhapHang_UpdateEventHandler1(object sender, ThongTinPhieuNhapHang.UpdateEventArgs args)
        {

            //load lên datagridView Danh sách phiếu nhập hàng
            string sql2 = "SELECT MaPhieuNhap, TenNCC, TenNV, NgayTao, TongTien, NhaCungCap.MaNCC, NhanVien.MaNV FROM dbo.PhieuNhapHang " +
                          "JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = PhieuNhapHang.MaNCC " +
                          "JOIN dbo.NhanVien ON NhanVien.MaNV = PhieuNhapHang.MaNV " +
                          "WHERE PhieuNhapHang.Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSPNH, sql2);
        }

        private void btn_themPhieuNhapHang_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ThongTinPhieuNhapHang phieuNhapHang = new ThongTinPhieuNhapHang();
            phieuNhapHang.UpdateEventHandler += PhieuNhapHang_UpdateEventHandler1;
            phieuNhapHang.ShowDialog();
        }

        private void btn_suaPhieuNhapHang_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ThongTinPhieuNhapHang phieuNhapHang = new ThongTinPhieuNhapHang();
            phieuNhapHang.UpdateEventHandler += PhieuNhapHang_UpdateEventHandler1;
            phieuNhapHang.ShowDialog();
        }




        #endregion

        #region ThemSuaXoa_ChitietPhieuNhapHang


        private void ChiTietPhieuNhapHang_UpdateEventHandler1(object sender, ChiTietPhieuNhapHang.UpdateEventArgs args)
        {
            //load lên datagridView Chi tiết phiếu nhập hàng
            string maPhieuNhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
            string sql4 = "SELECT MaPhieuNhap, dbo.ChiTietPhieuNhapHang.MSNVL, TenNVL, DonGia, SL FROM dbo.ChiTietPhieuNhapHang " +
                           "JOIN dbo.NguyenVatLieu ON NguyenVatLieu.MSNVL = ChiTietPhieuNhapHang.MSNVL " +
                           "WHERE MaPhieuNhap = " + maPhieuNhap;
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSCTPNH, sql4);
        }

        private void btn_xoachitietpnh_Click(object sender, EventArgs e)
        {
            string sql = "Xoa_ChiTietPhieuNhaphang";
            string[] para = { "@MaPhieuNhap", "@MSNVL" };

            string maphieunhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhapHang"].Value.ToString();
            string maNguyenvatlieu = dgv_DSCTPNH.CurrentRow.Cells["MSNVLL"].Value.ToString();
            object[] values = { Int32.Parse(maphieunhap), Int32.Parse(maphieunhap) };
            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            if (a != 0)
            {
                DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    //load lên datagridView Chi tiết phiếu nhập hàng
                    string maPhieuNhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
                    string sql4 = "SELECT MaPhieuNhap, dbo.ChiTietPhieuNhapHang.MSNVL, TenNVL, DonGia, SL FROM dbo.ChiTietPhieuNhapHang " +
                                   "JOIN dbo.NguyenVatLieu ON NguyenVatLieu.MSNVL = ChiTietPhieuNhapHang.MSNVL " +
                                   "WHERE MaPhieuNhap = " + maPhieuNhap;
                    Program.FillData.LoadDS_Len_DataGridView(dgv_DSCTPNH, sql4);

                    //load lên datagridView Danh sách phiếu nhập hàng
                    string sql2 = "SELECT MaPhieuNhap, TenNCC, TenNV, NgayTao, TongTien, NhaCungCap.MaNCC, NhanVien.MaNV FROM dbo.PhieuNhapHang " +
                                  "JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = PhieuNhapHang.MaNCC " +
                                  "JOIN dbo.NhanVien ON NhanVien.MaNV = PhieuNhapHang.MaNV " +
                                  "WHERE PhieuNhapHang.Xoa = 0";
                    Program.FillData.LoadDS_Len_DataGridView(dgv_DSPNH, sql2);
                }
            }
            else
            {
                MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_suachitietPhieuNhapHang_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ChiTietPhieuNhapHang chiTietPhieuNhapHang = new ChiTietPhieuNhapHang();
            chiTietPhieuNhapHang.UpdateEventHandler += ChiTietPhieuNhapHang_UpdateEventHandler1;
            chiTietPhieuNhapHang.ShowDialog();
        }

        private void btn_themchitietPhieuNhapHang_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ChiTietPhieuNhapHang chiTietPhieuNhapHang = new ChiTietPhieuNhapHang();
            chiTietPhieuNhapHang.UpdateEventHandler += ChiTietPhieuNhapHang_UpdateEventHandler1;
            chiTietPhieuNhapHang.ShowDialog();
        }

        #endregion

        
    }
}
