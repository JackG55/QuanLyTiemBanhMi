using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace QLTiemBanhMi.Connector
{
    class quanlyhoadonsql: connection
    {
        public void LayDSHoaDon(DataGridView dataGridView)
        {
            string sql = @"SELECT dbo.HoaDon.*, TenDayDu AS TenNV, TenCongTy AS TenCongTy,Ten AS NguoiNhanHH 
                           FROM dbo.HoaDon left JOIN dbo.CaNhanNhanTien ON CaNhanNhanTien.ID = HoaDon.NguoiNhanHoaHongID
                           JOIN dbo.NhanVien ON NhanVien.ID = HoaDon.NhanVienID 
                           JOIN dbo.CongTy ON CongTy.ID = HoaDon.CongTyID
                           WHERE HoaDon.Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql,CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }

        

        public void LayDSChiTietHoaDon(DataGridView dataGridView,string hoadonid)
        {
            int id_hd = Int32.Parse(hoadonid);
            string sql = @"SELECT  dbo.ChiTietHoaDon.* , TenSanPham
                            FROM dbo.HoaDon JOIN dbo.ChiTietHoaDon ON ChiTietHoaDon.HoaDonID = HoaDon.ID
                            JOIN dbo.SanPham ON SanPham.ID = ChiTietHoaDon.SanPhamID
                            WHERE dbo.HoaDon.ID = '" + id_hd+"' AND dbo.ChiTietHoaDon.Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }

        public void LayDSChiTietThanhToanHoaDon(DataGridView dataGridView, string hoadonid)
        {
            int id_hd = Int32.Parse(hoadonid);
            string sql = @"SELECT ID, TienThanhToan, NgayThanhToan, NgayThanhToanTiepTheo, GhiChu
                            FROM dbo.ChiTietThanhToan WHERE HoaDonID = '"+id_hd+"' AND Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }

        public List<string> LayDS_CongTy(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = "SELECT ID,TenCongTy,DiaChi,SoDienThoai,Fax,NgayTao,GhiChu FROM dbo.CongTy WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            grid.Properties.DataSource = null;
            grid.Properties.DataSource = dataTable;
            grid.Properties.DisplayMember = "TenCongTy";
            grid.Properties.ValueMember = "ID";
            grid.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            //tu động mở popup khi co ket qua
            grid.Properties.ImmediatePopup = true;

            //setup co the nhap vao grid
            grid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            string field = "ID";
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;

        }

        public List<string> LayDS_SanPham(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = @"SELECT dbo.SanPham.ID,TenSanPham,QuyCach, TenDonVi,SoLuongTon 
                            FROM dbo.SanPham JOIN dbo.DonVi ON DonVi.ID = SanPham.DonViID
                            WHERE dbo.SanPham.Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            grid.Properties.DataSource = null;
            grid.Properties.DataSource = dataTable;
            grid.Properties.DisplayMember = "TenSanPham";
            grid.Properties.ValueMember = "ID";
            grid.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            //tu động mở popup khi co ket qua
            grid.Properties.ImmediatePopup = true;

            //setup co the nhap vao grid
            grid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            string field = "ID";
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;

        }

        public List<string> LayDS_NhanVien(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = @"SELECT dbo.NhanVien.ID, TenDayDu,DiaChi, TenLoai, NgayTao,NhanVien.GhiChu 
                            FROM dbo.NhanVien JOIN dbo.LoaiNhanVien ON LoaiNhanVien.ID = NhanVien.LoaiNhanVienID
                            WHERE dbo.NhanVien.Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            grid.Properties.DataSource = null;
            grid.Properties.DataSource = dataTable;
            grid.Properties.DisplayMember = "TenDayDu";
            grid.Properties.ValueMember = "ID";
            grid.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            //tu động mở popup khi co ket qua
            grid.Properties.ImmediatePopup = true;

            //setup co the nhap vao grid
            grid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            string field = "ID";
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;

        }

        public List<string> LayDS_NguoiNhanHoaHong(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = @"SELECT CaNhanNhanTien.ID,Ten,DiaChi,DienThoai,Fax, TenLoai, CaNhanNhanTien.GhiChu
                                FROM dbo.CaNhanNhanTien JOIN dbo.LoaiCaNhan ON LoaiCaNhan.ID = CaNhanNhanTien.LoaiID
                                WHERE dbo.CaNhanNhanTien.Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            grid.Properties.DataSource = null;
            grid.Properties.DataSource = dataTable;
            grid.Properties.DisplayMember = "Ten";
            grid.Properties.ValueMember = "ID";
            grid.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            //tu động mở popup khi co ket qua
            grid.Properties.ImmediatePopup = true;

            //setup co the nhap vao grid
            grid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            string field = "ID";
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;

        }

        public int TaoMaHoaDon()
        {
            string sql = "SELECT MAX(ID) FROM dbo.HoaDon";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }


        public int TaoMaHoaDon_SP()
        {
            string sql = "SELECT MAX(ID) FROM dbo.ChiTietHoaDon";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }

        public int LaySoLuongTonTheoIDSanPham(int sanphamid)
        {
            string sql = "SELECT SoLuongTon FROM dbo.SanPham WHERE ID = '"+sanphamid+"'";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }

        public int TaoMaThanhHoaDon()
        {
            string sql = "SELECT MAX(ID) FROM dbo.ChiTietThanhToan";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }


    }
}
