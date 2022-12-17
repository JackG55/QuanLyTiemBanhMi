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
    class quantrihethongsql: connection
    {
        public List<QuyenThaoTac> LayDSPhanQuyenTheoNVID(string nhanvienid)
        {
            SqlConnection con = new SqlConnection();
            con = Getconnection();
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "LayDSPhanQuyenTheoNVID";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            // Use connection object of base class
            
            try
            {
                command.Parameters.Add(new SqlParameter("@nhanvienid", Int32.Parse(nhanvienid)));
                IDataReader dataReader = command.ExecuteReader();

                return PopulateObjectFromReader(dataReader);

            }
            catch (Exception ex)
            {
                connection.Getconnection().Close();
                command.Dispose();
                throw new Exception("Quyen::LayQuyenTheoNhanVienID::Error occured.", ex);
            }
            finally
            {
                connection.Getconnection().Close();
                command.Dispose();
            }


        }



        public List<string> LayDSMaQuyenTheoNVID(string nhanvienid)
        {
            List<string> list = new List<string>();
            string query = @"SELECT QuyenThaoTacID, TenQuyen 
                        FROM dbo.PhanQuyenNguoiDung JOIN dbo.QuyenThaoTac ON QuyenThaoTac.ID = PhanQuyenNguoiDung.QuyenThaoTacID

                        JOIN dbo.NhanVien ON NhanVien.ID = PhanQuyenNguoiDung.NhanVienID

                        WHERE NhanVienID = '"+Int32.Parse(nhanvienid)+"' AND dbo.PhanQuyenNguoiDung.Xoa = 0";
            DataTable data = new DataTable();
            data = connection.FillDataSet(query, CommandType.Text);
            string field = "QuyenThaoTacID";
            foreach (DataRow row in data.Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;
        }

        public void SelectAll(DataGridView dataGridView)
        {
            string sql = @"SELECT ID, TenQuyen FROM dbo.QuyenThaoTac WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }


        public List<QuyenThaoTac> SelectAll()
        {
            SqlConnection con = new SqlConnection();
            con = Getconnection();
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ID, TenQuyen FROM dbo.QuyenThaoTac WHERE Xoa = 0";
            command.CommandType = CommandType.Text;
            command.Connection = con;
            // Use connection object of base class

            try
            {

                IDataReader dataReader = command.ExecuteReader();
                return PopulateObjectFromReader(dataReader);

            }
            catch (Exception ex)
            {
                connection.Getconnection().Close();
                command.Dispose();
                throw new Exception("Quyen::LayQuyenThaoTac::Error occured.", ex);
            }
            finally
            {
                connection.Getconnection().Close();
                command.Dispose();
            }

        }



        internal void PopulatePlayerFromReader(QuyenThaoTac quyenThaoTac, IDataReader data)
        {
           
            if (!data.IsDBNull(data.GetOrdinal(QuyenThaoTac.QuyenThaoTacFields.TenQuyen.ToString())))
            {
                quyenThaoTac.Tenquyen = data.GetString(data.GetOrdinal(QuyenThaoTac.QuyenThaoTacFields.TenQuyen.ToString()));
            }
            if (!data.IsDBNull(data.GetOrdinal(QuyenThaoTac.QuyenThaoTacFields.ID.ToString())))
            {
                quyenThaoTac.Id = data.GetInt32(data.GetOrdinal(QuyenThaoTac.QuyenThaoTacFields.ID.ToString())).ToString();
            }

        }

        internal List<QuyenThaoTac> PopulateObjectFromReader(IDataReader data)
        {
            List<QuyenThaoTac> list = new List<QuyenThaoTac>();
            while (data.Read())
            {
                QuyenThaoTac quyen = new QuyenThaoTac();
                PopulatePlayerFromReader(quyen, data);
                list.Add(quyen);
            }
            return list;
        }
    }
}
