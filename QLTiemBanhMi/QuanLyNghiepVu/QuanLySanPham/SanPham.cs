using QLTiemBanhMi.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTiemBanhMi.Object;

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLySanPham
{
    public partial class SanPham : Form
    {
        string masp = "";
       public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            //load lên datagridView Danh Sach San Pham
            string sql1 = "SELECT SanPham.* FROM dbo.SanPham Where Xoa=0 ";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSSanPham, sql1);

            //load lên datagridView Chuong trinh Khuyen Mai
            string sql2 = "SELECT * FROM dbo.ChuongTrinhKhuyenMai";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSKhuyenMai, sql2);

            //load danh mục len combobox
            Program.FillData.LayDS_Len_ComBoBox(cbb_danhmucsp, "TenDanhMuc", "MaDM");

        }

        private void dataGridViewDSSanPham_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            masp = dgv_DSSanPham.CurrentRow.Cells["MaSP"].Value.ToString();
            string tensp = dgv_DSSanPham.CurrentRow.Cells["TenSP"].Value.ToString();
            string mota = dgv_DSSanPham.CurrentRow.Cells["MoTa"].Value.ToString();
            string giaban = dgv_DSSanPham.CurrentRow.Cells["GiaBan"].Value.ToString();
            string madm= dgv_DSSanPham.CurrentRow.Cells["MaDM"].Value.ToString();
           
            //tạo object để truyền qua form Chi tiết
            Program.sanPham = new Object.SanPham(int.Parse(masp), tensp,mota,int.Parse(madm),int.Parse(giaban));
        }

        private void chiTietSP_UpdateEventHandler1(object sender, ChiTietSP.UpdateEventArgs args)
        {

            string sql1 = "SELECT * FROM dbo.SanPham JOIN dbo.DanhMucSanPham ON DanhMucSanPham.MaDM = SanPham.MaDM where SanPham.Xoa=0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSSanPham, sql1);

        }

        private void btn_suaSanPham_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ChiTietSP chiTietSP = new ChiTietSP(this);
            chiTietSP.UpdateEventHandler += chiTietSP_UpdateEventHandler1;
            chiTietSP.ShowDialog();
        }

        private void btn_themSanPham_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ChiTietSP chiTietSP = new ChiTietSP(this);
           
            chiTietSP.UpdateEventHandler += chiTietSP_UpdateEventHandler1;
            chiTietSP.ShowDialog();
        }
        private void btn_xoasanpham_Click(object sender, EventArgs e)
        {
            string sql = "Xoa_SP";
            string[] para = { "@MaSP" };
            object[] values = { Int32.Parse(masp) };
            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            if (a != 0)
            {
                DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    string sql1 = "SELECT SanPham.* FROM dbo.SanPham Where Xoa=0 ";
                    Program.FillData.LoadDS_Len_DataGridView(dgv_DSSanPham, sql1);
                }
            }
            else
            {
                MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cbb_danhmucsp_SelectedIndexChanged(object sender, EventArgs e)
        {

            Program.FillData.LayDSSanPhamTheoDanhMuc(dgv_DSSanPham, int.Parse(cbb_danhmucsp.SelectedValue.ToString()));
            //load danh sach danh mục theo mã được chọn ở combobox
            DataTable list_danhmuc = Program.FillData.LayDS_DanhMuc(int.Parse(cbb_danhmucsp.SelectedValue.ToString()));

            //tạo 1 Object Danh Mục Sản Phẩm de luu gia tri
            Program.danhMucSanPham = new Object.DanhMucSanPham(int.Parse(list_danhmuc.Rows[0]["ID"].ToString()), list_danhmuc.Rows[0]["TenDanhMuc"].ToString());

        }
        private void danhMucSP_UpdateEventHandler1(object sender, DanhMucSP.UpdateEventArgs args)
        {

            Program.FillData.LayDS_Len_ComBoBox(cbb_danhmucsp, "TenDanhMuc", "MaDM");

        }
        private void btn_suadm_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            DanhMucSP danhMucSP = new DanhMucSP(this);
            danhMucSP.UpdateEventHandler += danhMucSP_UpdateEventHandler1;
            danhMucSP.ShowDialog();
        }

        private void btn_themdm_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            DanhMucSP danhMucSP = new DanhMucSP(this);

            danhMucSP.UpdateEventHandler += danhMucSP_UpdateEventHandler1;
            danhMucSP.ShowDialog();
        }
        private void chiTietKM_UpdateEventHandler1(object sender, ChiTietKM.UpdateEventArgs args)
        {

            string sql2 = "SELECT * FROM dbo.ChuongTrinhKhuyenMai";
            Program.FillData.LoadDS_Len_DataGridView(dgv_DSKhuyenMai, sql2);

        }

        private void btn_themctkm_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ChiTietKM chiTietKM = new ChiTietKM(this);
            chiTietKM.UpdateEventHandler += chiTietKM_UpdateEventHandler1;
            chiTietKM.ShowDialog();
        }

        private void btn_suactkm_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ChiTietKM chiTietKM = new ChiTietKM(this);
            chiTietKM.UpdateEventHandler += chiTietKM_UpdateEventHandler1;
            chiTietKM.ShowDialog();
        }

        private void dgv_DSKhuyenMai_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string makm = dgv_DSKhuyenMai.CurrentRow.Cells["MaKM"].Value.ToString();
            string tenkm = dgv_DSKhuyenMai.CurrentRow.Cells["TenKM"].Value.ToString();
            string phantramgiamgia = dgv_DSKhuyenMai.CurrentRow.Cells["PhanTramGiamGia"].Value.ToString();
            string ngaybatdau = dgv_DSKhuyenMai.CurrentRow.Cells["NgayBatDau"].Value.ToString();
            string ngayketthuc = dgv_DSKhuyenMai.CurrentRow.Cells["NgayKetThuc"].Value.ToString();

            //tạo object để truyền qua form Chi tiết
            Program.chuongTrinhKhuyenMai = new Object.ChuongTrinhKhuyenMai(int.Parse(makm), tenkm, int.Parse(phantramgiamgia), Convert.ToDateTime(ngaybatdau), Convert.ToDateTime(ngayketthuc));
        }
    }
}
