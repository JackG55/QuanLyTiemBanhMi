using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTiemBanhMi.Object;
using QLTiemBanhMi.Connector;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Collections.Generic;

namespace QLTiemBanhMi.Connector
{
    class fillData
    {
        /// <summary>
        ///  Hàm này dùng để lấy 1 danh sách truy vấn từ câu lệnh sql cho lên datagridview
        /// </summary>
        /// <param name="dataGridView">Tên của DataGridView</param>
        /// <param name="sql">chuỗi truy vấn</param>
        public void LoadDS_Len_DataGridView(DataGridView dataGridView, string sql)
        {
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }

        /// <summary>
        /// Hàm này dùng để lấy mã tự động
        /// </summary>
        /// <param name="tenMa"></param>
        /// <param name="tenBang"></param>
        /// <returns></returns>
        public int SinhMaTuDong(string tenMa, string tenBang)
        {
            string sql = $"SELECT MAX({tenMa}) FROM dbo.{tenBang}";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }

        /// <summary>
        /// Hàm này dùng để lấy giá trị của một cột theo khoá chính
        /// </summary>
        /// <param name="tenMa"></param>
        /// <param name="tenBang"></param>
        /// <param name="tenTruong"></param>
        /// <param name="giatri"></param>
        /// <returns></returns>
        public string LayGiaTriTheoMa(string tenMa, string giatri, string tenBang, string tenTruong)
        {
            string sql = $"SELECT {tenTruong} FROM dbo.{tenBang} where {tenMa} = {giatri}";
            object result = connection.docGiaTri(sql);
            return result.ToString();
        }

        /// <summary>
        /// hàm này lấy danh sách Tên trong Bảng để phục vụ việc kiểm tra xem có trùng hay không
        /// </summary>
        /// <param name="tenTruong">Tên trường cần lấy</param>
        /// <param name="tenBang">Tên Bảng cần lấy</param>
        /// <returns></returns>
        public List<string> LayDSTen(string tenTruong, string tenBang)
        {
            List<string> list_tenloainv = new List<string>();
            string query = $"SELECT * FROM dbo.{tenBang} WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                list_tenloainv.Add(row[tenTruong].ToString());

            }
            return list_tenloainv;
        }



        /// <summary>
        /// Hàm này để truyền thông tin lên grid lookup edit và trả lại 1 list chứa mảng
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="tenBang">Tên Bảng</param>
        /// <param name="tenHienThi">Tên hiển thị lên</param>
        /// <param name="maCanLay">Mã tương ứng với Tên</param>
        /// <returns>Trả về một list các mã </returns>
        public List<string> LayDS_Len_GridLookUpEdit(GridLookUpEdit grid, string tenBang, string tenHienThi, string maCanLay)
        {
            List<string> list = new List<string>();
            string query = $"SELECT * FROM dbo.{tenBang} WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            grid.Properties.DataSource = null;
            grid.Properties.DataSource = dataTable;
            grid.Properties.DisplayMember = tenHienThi;
            grid.Properties.ValueMember = maCanLay;
            grid.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            //tu động mở popup khi co ket qua
            grid.Properties.ImmediatePopup = true;

            //setup co the nhap vao grid
            grid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            string field = maCanLay;
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;

        }

        /// <summary>
        /// Hàm này để truyền thông tin lên grid lookup edit các row thoả mãn 1 đk và trả lại 1 list chứa mảng
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="V">Tên Bảng</param>
        /// <param name="tenHienThi">Tên hiển thị lên</param>
        /// <param name="maCanLay">Mã tương ứng với Tên</param>
        /// <returns>Trả về một list các mã </returns>
        public List<string> LayDS_Len_GridLookUpEdit_DK(GridLookUpEdit grid, string query, string tenHienThi, string maCanLay)
        {
            List<string> list = new List<string>();
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            grid.Properties.DataSource = null;
            grid.Properties.DataSource = dataTable;
            grid.Properties.DisplayMember = tenHienThi;
            grid.Properties.ValueMember = maCanLay;
            grid.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

            //tu động mở popup khi co ket qua
            grid.Properties.ImmediatePopup = true;

            //setup co the nhap vao grid
            grid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            string field = maCanLay;
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;

        }

        /// <summary>
        /// Hàm này để lấy danh sách đối tượng là Nhân viên để kiểm tra thông tin đăng nhập
        /// </summary>

        /// <returns>Trả về một list các mã </returns>
        public List<NhanVien> LayDSNhanVien()
        {
            List<NhanVien> list_nv = new List<NhanVien>();
            string query = $"SELECT * FROM dbo.NhanVien WHERE Xoa = 0";
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nv = new NhanVien();
                nv.Manv = int.Parse(row["MaNV"].ToString());
                nv.Tennv = row["TenNV"].ToString();
                nv.Username = row["UserName"].ToString();
                nv.Pass = row["Pass"].ToString();
                nv.Chucvu = row["ChucVu"].ToString();
                list_nv.Add(nv);
            }
            return list_nv;

        }

        /// <summary>
        /// Hàm này để truyền thông tin lên combobox
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="tenHienThi">Tên hiển thị lên</param>
        /// <param name="maCanLay">Mã tương ứng với Tên</param>
        /// <returns></returns>
        public void LayDS_Len_ComBoBox(System.Windows.Forms.ComboBox comboBox, string tenHienThi,string maCanLay)
        {
            string sql = @"SELECT * FROM dbo.DanhMucSanPham WHERE Xoa =0
                            UNION ALL
                            SELECT 0 AS MaDM, N'Tất cả' AS TenDanhMuc, 0 AS Xoa";
            comboBox.Refresh();
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            comboBox.DisplayMember =tenHienThi;
            comboBox.ValueMember = maCanLay;
            comboBox.DataSource = dataTable;


        }

        /// <summary>
        /// Hàm này để truyền thông tin lên combobox
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="madm">Mã danh mục</param>
        /// <returns></returns>
        public void LayDSSanPhamTheoDanhMuc(DataGridView dataGridView, int madm)
        {
            string sql = "";
            if (madm == 0)
            {
                sql = @"SELECT dbo.SanPham.*,TenDanhMuc
                            FROM dbo.SanPham JOIN dbo.DanhMucSanPham ON DanhMucSanPham.MaDM = SanPham.MaDM
                            WHERE SanPham.Xoa = 0";
            }
            else
            {   
                sql = @"SELECT dbo.SanPham.*,TenDanhMuc
                            FROM dbo.SanPham JOIN dbo.DanhMucSanPham ON DanhMucSanPham.MaDM = SanPham.MaDM
                            WHERE SanPham.Xoa = 0 and DanhMucSanPham.MaDM='" + madm + "'";
            }

            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(sql, CommandType.Text);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dataTable;
        }

        /// <summary>
        /// Hàm để lấy Ds bảng Danh mục theo mã danh mục
        /// </summary>
        /// <param name="madm">Mã danh mục</param>
        /// <returns></returns>
        public DataTable LayDS_DanhMuc(int madm)
        {
            string query = "";
            if(madm==0)
            {
                query = "SELECT MaDM, TenDanhMuc from dbo.DanhMucSanPham WHERE Xoa = 0";
            }   
            else
            {
                query = "SELECT MaDM, TenDanhMuc from dbo.DanhMucSanPham WHERE Xoa = 0 AND MaDM='" + madm + "'";
            }    
            
            DataTable dataTable = new DataTable();
            dataTable = connection.FillDataSet(query, CommandType.Text);
            return dataTable;
        }
    }
}
