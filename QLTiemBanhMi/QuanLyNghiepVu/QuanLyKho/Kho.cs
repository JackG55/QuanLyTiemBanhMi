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
            string sql1 = "SELECT * FROM dbo.NhaCungCap";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSNCC, sql1);

            //load lên datagridView Danh sách phiếu nhập hàng
            string sql2 = "SELECT MaPhieuNhap, TenNCC, TenNV, NgayTao, TongTien FROM dbo.PhieuNhapHang " +
                          "JOIN dbo.NhaCungCap ON NhaCungCap.MaNCC = PhieuNhapHang.MaNCC " +
                          "JOIN dbo.NhanVien ON NhanVien.MaNV = PhieuNhapHang.MaNV";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSPNH, sql2);

            //load lên datagridView Nguyên Vật Liệu           
            string sql3 = "SELECT * FROM dbo.NguyenVatLieu";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSNVL, sql3);

            //load lên datagridView Chi tiết phiếu nhập hàng
            string maPhieuNhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
            string sql4 = "SELECT ChiTietPhieuNhapHang.MSNVL, TenNVL, DonGia, SL FROM dbo.ChiTietPhieuNhapHang " +
                           "JOIN dbo.NguyenVatLieu ON NguyenVatLieu.MSNVL = ChiTietPhieuNhapHang.MSNVL WHERE MaPhieuNhap = " + maPhieuNhap;
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

        private void dataGridViewPhieuNhapHang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            //load lại cái chi tiết hoá đơn
            string maPhieuNhap = dgv_DSPNH.CurrentRow.Cells["MaPhieuNhap"].Value.ToString();
            string sql4 = "SELECT ChiTietPhieuNhapHang.MSNVL, TenNVL, DonGia, SL FROM dbo.ChiTietPhieuNhapHang " +
                           "JOIN dbo.NguyenVatLieu ON NguyenVatLieu.MSNVL = ChiTietPhieuNhapHang.MSNVL WHERE MaPhieuNhap = " + maPhieuNhap;
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSCTPNH, sql4);

            //Tạo 1 Object để phục vụ cho thêm sửa xoá
            
        }

        private void dataGridViewDSHoaDon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //string nhanvienid, congtyid, nguoinhanhoahongid = "";
            //tb_id.Text = dataGridViewDSHoaDon.CurrentRow.Cells["ID"].Value.ToString();
            //tb_hoadon.Text = dataGridViewDSHoaDon.CurrentRow.Cells["TenHoaDon"].Value.ToString();
            //tb_congty.Text = dataGridViewDSHoaDon.CurrentRow.Cells["TenCongTy"].Value.ToString();
            //tb_nhanvien.Text = dataGridViewDSHoaDon.CurrentRow.Cells["TenNV"].Value.ToString();
            //tb_tienthanhtoan.Text = dataGridViewDSHoaDon.CurrentRow.Cells["TongTienDaThanhToan"].Value.ToString();
            //tb_ngayhenthanhtoan.Text = dataGridViewDSHoaDon.CurrentRow.Cells["NgayHenThanhToan"].Value.ToString();
            //tb_nguoinhanhoahong.Text = dataGridViewDSHoaDon.CurrentRow.Cells["NguoiNhanHH"].Value.ToString();
            //tb_ngaylap.Text = dataGridViewDSHoaDon.CurrentRow.Cells["NgayLap"].Value.ToString();
            //tb_tienloi.Text = dataGridViewDSHoaDon.CurrentRow.Cells["TienLoi"].Value.ToString();
            //tb_tongtien.Text = dataGridViewDSHoaDon.CurrentRow.Cells["TongTien"].Value.ToString();
            //tb_hoahong.Text = dataGridViewDSHoaDon.CurrentRow.Cells["HoaHong"].Value.ToString();
            //tb_ghichu.Text = dataGridViewDSHoaDon.CurrentRow.Cells["GhiChu"].Value.ToString();
            //nhanvienid = dataGridViewDSHoaDon.CurrentRow.Cells["NhanVienID"].Value.ToString();
            //congtyid = dataGridViewDSHoaDon.CurrentRow.Cells["CongTyID"].Value.ToString();
            //nguoinhanhoahongid = dataGridViewDSHoaDon.CurrentRow.Cells["NguoiNhanHoaHongID"].Value.ToString();


            //Program.hoaDon = new Object.HoaDon(tb_id.Text, tb_hoadon.Text, congtyid, nhanvienid, Convert.ToDateTime(tb_ngaylap.Text),
            //    tb_tongtien.Text, tb_tienthanhtoan.Text, Convert.ToDateTime(tb_ngayhenthanhtoan.Text), tb_tienloi.Text,
            //    tb_hoahong.Text, nguoinhanhoahongid, tb_ghichu.Text);
            //Program.Quanlyhoadonsql.LayDSChiTietHoaDon(dtgv_DSChiTietHoaDon, tb_id.Text);
        }
        //private void chiTietHD_UpdateEventHandler1(object sender, ThongTinHD.UpdateEventArgs args)
        //{
        //    string sql = @"SELECT dbo.HoaDon.*, TenDayDu AS TenNV, TenCongTy AS TenCongTy,Ten AS NguoiNhanHH 
        //                   FROM dbo.HoaDon left JOIN dbo.CaNhanNhanTien ON CaNhanNhanTien.ID = HoaDon.NguoiNhanHoaHongID
        //                   JOIN dbo.NhanVien ON NhanVien.ID = HoaDon.NhanVienID 
        //                   JOIN dbo.CongTy ON CongTy.ID = HoaDon.CongTyID
        //                   WHERE HoaDon.Xoa = 0";
        //    DataTable dataTable = new DataTable();
        //    dataTable = connection.FillDataSet(sql, CommandType.Text);
        //    dataGridViewDSHoaDon.AutoGenerateColumns = false;
        //    dataGridViewDSHoaDon.DataSource = dataTable;
        //}

        //private void ThanhToanHD_UpdateEventHandler1(object sender, ThanhToanHD.UpdateEventArgs args)
        //{
        //    string sql = @"SELECT dbo.HoaDon.*, TenDayDu AS TenNV, TenCongTy AS TenCongTy,Ten AS NguoiNhanHH 
        //                   FROM dbo.HoaDon left JOIN dbo.CaNhanNhanTien ON CaNhanNhanTien.ID = HoaDon.NguoiNhanHoaHongID
        //                   JOIN dbo.NhanVien ON NhanVien.ID = HoaDon.NhanVienID 
        //                   JOIN dbo.CongTy ON CongTy.ID = HoaDon.CongTyID
        //                   WHERE HoaDon.Xoa = 0";
        //    DataTable dataTable = new DataTable();
        //    dataTable = connection.FillDataSet(sql, CommandType.Text);
        //    dataGridViewDSHoaDon.AutoGenerateColumns = false;
        //    dataGridViewDSHoaDon.DataSource = dataTable;
        //}

        //private void chiTietHD_SP_UpdateEventHandler1(object sender, ChiTietHD_SP.UpdateEventArgs args)
        //{
        //    string sql = @"SELECT dbo.HoaDon.*, TenDayDu AS TenNV, TenCongTy AS TenCongTy,Ten AS NguoiNhanHH 
        //                   FROM dbo.HoaDon left JOIN dbo.CaNhanNhanTien ON CaNhanNhanTien.ID = HoaDon.NguoiNhanHoaHongID
        //                   JOIN dbo.NhanVien ON NhanVien.ID = HoaDon.NhanVienID 
        //                   JOIN dbo.CongTy ON CongTy.ID = HoaDon.CongTyID
        //                   WHERE HoaDon.Xoa = 0";
        //    DataTable dataTable = new DataTable();
        //    dataTable = connection.FillDataSet(sql, CommandType.Text);
        //    dataGridViewDSHoaDon.AutoGenerateColumns = false;
        //    dataGridViewDSHoaDon.DataSource = dataTable;

        //    int id_hd = Int32.Parse(tb_id.Text);
        //    sql = @"SELECT  dbo.ChiTietHoaDon.* , TenSanPham
        //                    FROM dbo.HoaDon JOIN dbo.ChiTietHoaDon ON ChiTietHoaDon.HoaDonID = HoaDon.ID
        //                    JOIN dbo.SanPham ON SanPham.ID = ChiTietHoaDon.SanPhamID
        //                    WHERE dbo.HoaDon.ID = '" + id_hd + "' AND dbo.ChiTietHoaDon.Xoa = 0";
        //    DataTable dataTable1 = new DataTable();
        //    dataTable1 = connection.FillDataSet(sql, CommandType.Text);
        //    dtgv_DSChiTietHoaDon.AutoGenerateColumns = false;
        //    dtgv_DSChiTietHoaDon.DataSource = dataTable1;
        //}
        private void btn_suahoadon_Click(object sender, EventArgs e)
        {
            //Program.opt = 2;
            //ThongTinHD chiTietHD = new ThongTinHD(this);
            //chiTietHD.UpdateEventHandler += chiTietHD_UpdateEventHandler1;
            //chiTietHD.ShowDialog();
           
        }

        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            //Program.opt = 1;
            //ThongTinHD chiTietHD = new ThongTinHD(this);
            //chiTietHD.UpdateEventHandler += chiTietHD_UpdateEventHandler1;
            //chiTietHD.ShowDialog();
        }

        private void btn_chitietthanhtoan_Click(object sender, EventArgs e)
        {
            //XemThanhToanHD xemThanhToanHD = new XemThanhToanHD();

            //xemThanhToanHD.ShowDialog();
        }

        private void dtgv_DSChiTietHoaDon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            //Program.chiTietHoaDon.Id = dtgv_DSChiTietHoaDon.CurrentRow.Cells["IDD"].Value.ToString();
            //Program.chiTietHoaDon.Hoadonid = tb_id.Text;
            //Program.chiTietHoaDon.Sanphamid = dtgv_DSChiTietHoaDon.CurrentRow.Cells["SanPhamID"].Value.ToString();
            //Program.chiTietHoaDon.Soluong = dtgv_DSChiTietHoaDon.CurrentRow.Cells["SoLuong"].Value.ToString();
            //Program.chiTietHoaDon.Giaban = dtgv_DSChiTietHoaDon.CurrentRow.Cells["GiaBan"].Value.ToString();
            //Program.chiTietHoaDon.Vat = dtgv_DSChiTietHoaDon.CurrentRow.Cells["VAT"].Value.ToString();
            //Program.chiTietHoaDon.Tienloi = dtgv_DSChiTietHoaDon.CurrentRow.Cells["TienLoii"].Value.ToString();
            //Program.chiTietHoaDon.Ghichu = dtgv_DSChiTietHoaDon.CurrentRow.Cells["GhiChuGSP"].Value.ToString();
           
        }

        private void btn_suachitiethoadon_Click(object sender, EventArgs e)
        {
            //Program.opt = 2;
            //ChiTietHD_SP chiTietHD_SP = new ChiTietHD_SP(this);
            //chiTietHD_SP.UpdateEventHandler += chiTietHD_SP_UpdateEventHandler1;
            //chiTietHD_SP.ShowDialog();
        }

        private void btn_themchitiethoadon_Click(object sender, EventArgs e)
        {
            //Program.opt = 1;
            //ChiTietHD_SP chiTietHD_SP = new ChiTietHD_SP(this);
            //chiTietHD_SP.UpdateEventHandler += chiTietHD_SP_UpdateEventHandler1;
            //chiTietHD_SP.ShowDialog();
        }

        private void btn_thanhtoanhd_Click(object sender, EventArgs e)
        {
            //ThanhToanHD chiTietThanhToan = new ThanhToanHD(this);
            //chiTietThanhToan.UpdateEventHandler += ThanhToanHD_UpdateEventHandler1;
            //chiTietThanhToan.ShowDialog();
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
            string sql3 = "SELECT * FROM dbo.NguyenVatLieu";
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

            string manvl = dgv_DSNVL.CurrentRow.Cells["MaNVL"].Value.ToString();
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
    }
}
