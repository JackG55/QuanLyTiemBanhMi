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
    class quanlynhanviensql:connection
    {
        public List<NhanVien> LayDSNhanVien()
        {
            string sql = "SELECT dbo.NhanVien.*,TenLoai from dbo.NhanVien JOIN dbo.LoaiNhanVien ON LoaiNhanVien.ID = NhanVien.LoaiNhanVienID WHERE NhanVien.Xoa = 0";
            SqlConnection con = new SqlConnection();
            con = connection.Getconnection();
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Connection = con;
            try
            {

                IDataReader data = command.ExecuteReader();
                return PopulateObjectFromReader(data);
            }
            catch (Exception ex)
            {
                connection.Getconnection().Close();
                command.Dispose();
                throw new Exception("user::SelectAll::Error occured.", ex);
            }
            finally
            {
                connection.Getconnection().Close();
                command.Dispose();
            }

        }

        internal void PopulatePlayerFromReader(NhanVien nhanvien, IDataReader data)
        {
            //nhanvien.Tendangnhap = data.GetString(data.GetOrdinal(NhanVien.NhanVienFields.TenDangNhap.ToString()));

            //if (!data.IsDBNull(data.GetOrdinal(NhanVien.NhanVienFields.MatKhau.ToString())))
            //{
            //    nhanvien.Matkhau = data.GetString(data.GetOrdinal(NhanVien.NhanVienFields.MatKhau.ToString()));
            //}
            //if (!data.IsDBNull(data.GetOrdinal(NhanVien.NhanVienFields.ID.ToString())))
            //{
            //    nhanvien.Id = data.GetInt32(data.GetOrdinal(NhanVien.NhanVienFields.ID.ToString())).ToString();
            //}

            //if (!data.IsDBNull(data.GetOrdinal(NhanVien.NhanVienFields.TenLoai.ToString())))
            //{
            //    nhanvien.Tenloai = data.GetString(data.GetOrdinal(NhanVien.NhanVienFields.TenLoai.ToString())).ToString();
            //}

            //if (!data.IsDBNull(data.GetOrdinal(NhanVien.NhanVienFields.TenDayDu.ToString())))
            //{
            //    nhanvien.Tendaydu = data.GetString(data.GetOrdinal(NhanVien.NhanVienFields.TenDayDu.ToString())).ToString();
            //}

        }


        internal List<NhanVien> PopulateObjectFromReader(IDataReader data)
        {
            List<NhanVien> list = new List<NhanVien>();
            while (data.Read())
            {
                NhanVien nhanVien = new NhanVien();
                PopulatePlayerFromReader(nhanVien, data);
                list.Add(nhanVien);
            }
            return list;
        }

        public void LayDSNhanVien(DataGridView dataGridView)
        {
            string sql = @"SELECT dbo.NhanVien.*,TenLoai 
                            FROM dbo.NhanVien JOIN dbo.LoaiNhanVien ON LoaiNhanVien.ID = NhanVien.LoaiNhanVienID
                            WHERE NhanVien.Xoa=0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }

       
        public void LayDSLoaiNhanVien(System.Windows.Forms.ComboBox comboBox)
        {
            string sql = @"SELECT * FROM dbo.LoaiNhanVien where Xoa = 0 
                            UNION ALL
                            SELECT 0 AS ID, N'Tất cả' AS TenLoai, 0 AS Xoa, 'Tất cả' AS GhiChu";
            comboBox.Refresh();
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            comboBox.DisplayMember = "TenLoai";
            comboBox.ValueMember = "ID";
            comboBox.DataSource = dataTable;
        }

        public void LayDSNhanVien(DataGridView dataGridView, string tenloai)
        {
            string sql = "";
            if (tenloai == "Tất cả")
            {
                sql = @"select NhanVien.*,TenLoai
                        from NhanVien join LoaiNhanVien on NhanVien.LoaiNhanVienID = LoaiNhanVien.ID
                        where NhanVien.Xoa = 0";
            }
            else
            {
                sql = @"select NhanVien.*,TenLoai
                        from NhanVien join LoaiNhanVien on NhanVien.LoaiNhanVienID = LoaiNhanVien.ID
                        where NhanVien.Xoa = 0 and TenLoai = N'" + tenloai + "'";
            }
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }

        public int TaoMaNhanVien()
        {
            string sql = "SELECT MAX(ID) FROM dbo.NhanVien";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }

        public int TaoMaLoaiNhanVien()
        {
            string sql = "SELECT MAX(ID) FROM dbo.LoaiNhanVien";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }

        public List<string> LayDS_LoaiNhanVien(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = "SELECT ID, Tenloai, GhiChu from dbo.LoaiNhanVien WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            grid.Properties.DataSource = null;
            grid.Properties.DataSource = dataTable;
            grid.Properties.DisplayMember = "Tenloai";
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


        public DataTable LayDS_LoaiNhanVien(string id)
        {
            string query = "SELECT ID, Tenloai, GhiChu from dbo.LoaiNhanVien WHERE Xoa = 0 AND ID='"+id+"'";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);
            return dataTable;
        }

        public List<string> LayDSTenLoaiNV()
        {
            List<string> list_tenloainv = new List<string>();
            string query = "SELECT ID, Tenloai, GhiChu from dbo.LoaiNhanVien WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);
            string field1 = "TenLoai";
           
            foreach (DataRow row in dataTable.Rows)
            {
                list_tenloainv.Add(row[field1].ToString());
               
            }
            return list_tenloainv;
        }


    }
}
