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

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyNhanVien
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            //load lên datagridView Nhân viên
            string sql1 = "SELECT * FROM dbo.NhanVien WHERE Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_dsnv, sql1);
          
        }

        private void dataGridViewDSNhanVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy các trường thông tin để nếu mà sửa thì sửa
            string manv = dgv_dsnv.CurrentRow.Cells["MaNV"].Value.ToString();
            string tennv = dgv_dsnv.CurrentRow.Cells["TenNV"].Value.ToString();
            string username = dgv_dsnv.CurrentRow.Cells["UserName"].Value.ToString();
            string gioitinh = dgv_dsnv.CurrentRow.Cells["GioiTinh"].Value.ToString();
            string namsinh = dgv_dsnv.CurrentRow.Cells["NamSinh"].Value.ToString();
            string chucvu = dgv_dsnv.CurrentRow.Cells["ChucVu"].Value.ToString();
            string diachi = dgv_dsnv.CurrentRow.Cells["DiaChi"].Value.ToString();
            string pass = dgv_dsnv.CurrentRow.Cells["Pass"].Value.ToString();
            //Tạo 1 Object để phục vụ cho thêm sửa xoá
            Program.nhanvien = new Object.NhanVien(int.Parse(manv), tennv, username,pass,namsinh,diachi,chucvu,gioitinh);

            //Lay ds chi tiet lịch làm việc của mỗi nv
            string sql = @"SELECT NgayLamViec,BatDau,KetThuc FROM dbo.NhanVien, dbo.LichLamViec, dbo.CaLam WHERE NhanVien.MaNV = " + int.Parse(manv) + "AND NhanVien.MaNV = LichLamViec.MaNV AND LichLamViec.MaCaLam = CaLam.MaCaLam";
            Program.FillData.LoadDS_Len_DataGridView(dgv_calam,sql);



        }
        private void chiTietNV_UpdateEventHandler1(object sender, ChiTietNV.UpdateEventArgs args)
        {

            string sql1 = "SELECT * FROM dbo.NhanVien WHERE Xoa = 0";
            Program.FillData.LoadDS_Len_DataGridView(dgv_dsnv, sql1);

        }

        private void caLam_UpdateEventHandler1(object sender, CaLam.UpdateEventArgs args)
        {

            string sql = @"SELECT NgayLamViec,BatDau,KetThuc FROM dbo.NhanVien, dbo.LichLamViec, dbo.CaLam WHERE NhanVien.MaNV = " + int.Parse(manv) + "AND NhanVien.MaNV = LichLamViec.MaNV AND LichLamViec.MaCaLam = CaLam.MaCaLam";
            Program.FillData.LoadDS_Len_DataGridView(dgv_calam, sql);

        }


        private void btn_suanhanvien_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ChiTietNV chiTietNV = new ChiTietNV(this);
            chiTietNV.UpdateEventHandler += chiTietNV_UpdateEventHandler1;
            chiTietNV.ShowDialog();
        }

        private void btn_themnhanvien_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ChiTietNV chiTietNV = new ChiTietNV(this);
            chiTietNV.UpdateEventHandler += chiTietNV_UpdateEventHandler1;
            chiTietNV.ShowDialog();
        }
        private void btn_xxoanhanvien_Click(object sender, EventArgs e)
        {
            string sql = "Xoa_NhanVien";
            string[] para = { "@MaNV" };
            string manv = dgv_dsnv.CurrentRow.Cells["MaNV"].Value.ToString();
            object[] values = { Int32.Parse(manv) };
            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            if (a != 0)
            {
                DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    string sql1 = "SELECT * FROM dbo.NhanVien WHERE Xoa = 0";
                    Program.FillData.LoadDS_Len_DataGridView(dgv_dsnv, sql1);
                }
            }
            else
            {
                MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_themca_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            CaLam caLam = new CaLam(this);
            caLam.UpdateEventHandler += caLam_UpdateEventHandler1;
            caLam.ShowDialog();
        }
    }
}
