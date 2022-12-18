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
        List<string> tenquyen_nhanvien = new List<string>() { "DanhSachNhanVien", "ThemNhanVien", "ThemLoaiNhanVien", 
            "SuaNhanVien", "SuaLoaiNhanVien", "XoaNhanVien","XoaLoaiNhanVien" };
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            //foreach (QuyenThaoTac q in Program.PhanQuyenList)
            //{
            //    if (q.Tenquyen == tenquyen_nhanvien[0])
            //    {
                   

            //    }
            //    if (q.Tenquyen == tenquyen_nhanvien[1])
            //    {
            //        btn_themnhanvien.Visible = true;


            //    }
            //    if (q.Tenquyen == tenquyen_nhanvien[2])
            //    {
            //        btnThemLoaiNV.Visible = true;

            //    }
            //    if (q.Tenquyen == tenquyen_nhanvien[3])
            //    {
            //        btn_suanhanvien.Visible = true;

            //    }
            //    if (q.Tenquyen == tenquyen_nhanvien[4])
            //    {
            //        btnSuaLoaiNV.Visible = true;


            //    }
            //    if (q.Tenquyen == tenquyen_nhanvien[5])
            //    {
            //        btn_xoanhanvien.Visible = true;

            //    }
            //    if (q.Tenquyen == tenquyen_nhanvien[6])
            //    {
            //        btnXoaLoaiNV.Visible = true;

            //    }


            //}
            //Program.Quanlynhanviensql.LayDSNhanVien(dataGridViewDSNhanVien);
            //Program.Quanlynhanviensql.LayDSLoaiNhanVien(cbbDSLoaiNhanVien);
        }

        private void dataGridViewDSNhanVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //truyền từ grid lên text
           // tb_id.Text = dataGridViewDSNhanVien.CurrentRow.Cells["ID"].Value.ToString();
           // tb_tendangnhap.Text = dataGridViewDSNhanVien.CurrentRow.Cells["TenDangNhap"].Value.ToString();
           // tb_tendaydu.Text = dataGridViewDSNhanVien.CurrentRow.Cells["TenDayDu"].Value.ToString();
           // tb_diachi.Text = dataGridViewDSNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
           // tb_ngaytao.Text = dataGridViewDSNhanVien.CurrentRow.Cells["NgayTao"].Value.ToString();
           // tb_loainhanvienid.Text = dataGridViewDSNhanVien.CurrentRow.Cells["LoaiNhanVienID"].Value.ToString();
           // tb_ghichu.Text = dataGridViewDSNhanVien.CurrentRow.Cells["GhiChu"].Value.ToString();

           // string matkhau = "";
           // matkhau = dataGridViewDSNhanVien.CurrentRow.Cells["MatKhau"].Value.ToString();

           // //tạo 1 Object Nhan vien để lưu giá trị
           //Program.nhanvien = new Object.NhanVien(tb_id.Text, tb_tendangnhap.Text, matkhau, tb_tendaydu.Text, tb_diachi.Text, Convert.ToDateTime(tb_ngaytao.Text),
           // tb_ghichu.Text, tb_loainhanvienid.Text);


        }
        private void chiTietNV_UpdateEventHandler1(object sender, ChiTietNV.UpdateEventArgs args)
        {

            Program.Quanlynhanviensql.LayDSNhanVien(dataGridViewDSNhanVien);

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

        private void cbbDSLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Program.Quanlynhanviensql.LayDSNhanVien(dataGridViewDSNhanVien, cbbDSLoaiNhanVien.Text);
           // if (cbbDSLoaiNhanVien.SelectedValue.ToString() == "0" || cbbDSLoaiNhanVien.SelectedValue.ToString() == "1")
           // {
           //     btnSuaLoaiNV.Enabled = false;
           //     btnXoaLoaiNV.Enabled = false;
           // }
           // else
           // {
           //     btnSuaLoaiNV.Enabled = true;
           //     btnXoaLoaiNV.Enabled = true;
           //     //gán giá trị vào Object
           //     //load danh sach loai nhan vien
           //     DataTable list_loainhanvienId = Program.Quanlynhanviensql.LayDS_LoaiNhanVien(cbbDSLoaiNhanVien.SelectedValue.ToString());


           //     //tạo 1 Object Loai Nhan Vien de luu gia tri
           //     Program.chiTietLoaiNV = new Object.LoaiNhanVien(list_loainhanvienId.Rows[0]["ID"].ToString(), list_loainhanvienId.Rows[0]["Tenloai"].ToString(), list_loainhanvienId.Rows[0]["Ghichu"].ToString());
           // }
            

           //;
        }
  
       

        private void btn_xxoanhanvien_Click(object sender, EventArgs e)
        {
            //string sql = "Xoa_NV";
            //string[] para = { "@id"};
            //object[] values = { Int32.Parse(tb_id.Text)};
            //int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //if (a != 0)
            //{
            //    DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    if (result2 == DialogResult.OK)
            //    {
            //        Program.Quanlynhanviensql.LayDSNhanVien(dataGridViewDSNhanVien);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnXoaLoaiNV_Click(object sender, EventArgs e)
        {
            string sql = "Xoa_Loai_NV";
            string[] para = { "@id" };
            object[] values = { Int32.Parse(cbbDSLoaiNhanVien.SelectedValue.ToString()) };
            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            if (a != 0)
            {
                DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    Program.Quanlynhanviensql.LayDSLoaiNhanVien(cbbDSLoaiNhanVien);
                    
                }
            }
            else
            {
                MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
