using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanhMi.Object;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace QLTiemBanhMi.Connector
{
    class quanlysanphamsql
    {
        public void LayDSSanPham(DataGridView dataGridView)
        {
            string sql = @"SELECT dbo.SanPham.*, TenDonVi FROM dbo.SanPham JOIN dbo.DonVi ON DonVi.ID = SanPham.DonViID
                            WHERE SanPham.Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }


        public void LayDSGiaBanSP(DataGridView dataGridView, string sanphamid)
        {
            int id_sp = Int32.Parse(sanphamid);
            string sql = @"SELECT * FROM dbo.GiaBanSanPham WHERE SanPhamID= '" + id_sp + "' AND dbo.GiaBanSanPham.Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }


        public int TaoMaSanPham()
        {
            string sql = "SELECT MAX(ID) FROM dbo.SanPham";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }

        public int TaoMaDonVi()
        {
            string sql = "SELECT MAX(ID) FROM dbo.DonVi";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }


        public void LayDSSanPham(DataGridView dataGridView, string DonViId)
        {
            string sql = "";
            if(DonViId == "0")
            {
                sql = @"SELECT dbo.SanPham.*,TenDonVi FROM dbo.SanPham JOIN dbo.DonVi ON DonVi.ID = SanPham.DonViID
                                WHERE SanPham.Xoa = 0";
            } 
            else
            {
                sql = @"SELECT dbo.SanPham.*,TenDonVi FROM dbo.SanPham JOIN dbo.DonVi ON DonVi.ID = SanPham.DonViID
                                WHERE SanPham.Xoa = 0 AND DonViID = '" + DonViId + "'";
            }    
            
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }


        public void LayDSDonVi(System.Windows.Forms.ComboBox comboBox)
        {
            string sql = @"SELECT * FROM dbo.DonVi WHERE Xoa =0
                            UNION ALL
                            SELECT 0 AS ID, N'Tất cả' AS TenDonVi, 0 AS Xoa, 'Tất cả' AS GhiChu";
            comboBox.Refresh();
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            comboBox.DisplayMember = "TenDonVi";
            comboBox.ValueMember = "ID";
            comboBox.DataSource = dataTable;
            
        }


        public DataTable LayDS_DonVi(string id)
        {
            string query = "SELECT ID, TenDonVi, GhiChu from dbo.DonVi WHERE Xoa = 0 AND ID='" + id + "'";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);
            return dataTable;
        }

        public List<string> LayDS_DonVi(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = "SELECT ID, TenDonVi, GhiChu FROM dbo.DonVi WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            grid.Properties.DataSource = null;
            grid.Properties.DataSource = dataTable;
            grid.Properties.DisplayMember = "TenDonVi";
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

        public List<string> LayDSTenLoaiDonVi()
        {
            List<string> list_tenloainv = new List<string>();
            string query = "SELECT ID, TenDonVi, GhiChu FROM dbo.DonVi WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);
            string field1 = "TenDonVi";

            foreach (DataRow row in dataTable.Rows)
            {
                list_tenloainv.Add(row[field1].ToString());

            }
            return list_tenloainv;
        }
    }

    
}
