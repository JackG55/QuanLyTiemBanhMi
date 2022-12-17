using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QLTiemBanhMi.QuanLyNghiepVu.QuanLyNhanVien;
using QLTiemBanhMi.QuanLyNghiepVu.QuanLySanPham;
using QLTiemBanhMi.QuanLyNghiepVu.QuanLyHoaDon;
using System.Diagnostics;
using System.IO;
using QLTiemBanhMi.Object;
namespace QLTiemBanhMi.QuanTriHeThong

{
    public partial class QuanLyChung : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<string> tenquyen_hethong = new List<string>() { "PhanQuyen"};
        List<string> tenquyen_sanpham = new List<string>() { "ThemSanPham", "DanhSachSanPham", "QuanLyGiaSanPham", 
            "QuanLyDonVi","SuaSanPham","XoaSanPham" };
        List<string> tenquyen_nhanvien = new List<string>() { "DanhSachNhanVien", "ThemNhanVien", "ThemLoaiNhanVien",
            "SuaNhanVien", "SuaLoaiNhanVien", "XoaNhanVien","XoaLoaiNhanVien" };
        List<string> tenquyen_hoadon = new List<string>() { "BanHang", "SuaHoaDon","SuaChiTietHoaDon" };
        int chk = 0;
        public QuanLyChung()
        {
            InitializeComponent();
            // kich hoat cac button theo chuc vu
            
            //barButtonItemqllop
        }
        private void barButtonItemdanguat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                chk = 1;
                DangNhap frmLogin = new DangNhap();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void barButtonItemDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
        }

        private void QuanLyChung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chk == 0)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.dangnhap.Close();
                }
            }
            else
            {
                Program.dangnhap.Close();
            }
        }

        
        private void barButtonItemphanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Phanquyen phanquyen = new Phanquyen();

            phanquyen.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(phanquyen);
            phanquyen.Dock = DockStyle.Fill;
            phanquyen.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            phanquyen.Show();
        }

        public void barButtonItemQLSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyNghiepVu.QuanLySanPham.SanPham sanpham = new QuanLyNghiepVu.QuanLySanPham.SanPham();
            sanpham.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(sanpham);
            sanpham.Dock = DockStyle.Fill;
            sanpham.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sanpham.Show();
        }

      
        private void barButtonItem_qlhoadon_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyNghiepVu.QuanLyHoaDon.HoaDon hoaDon = new QuanLyNghiepVu.QuanLyHoaDon.HoaDon();
            hoaDon.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(hoaDon);
            hoaDon.Dock = DockStyle.Fill;
            hoaDon.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hoaDon.Show();
        }

        private bool KiemTraQuyen(List<string> list1, List<string> tenquyenlist)
        {
            foreach (string i in list1)
            {
                if (tenquyenlist.Contains(i))
                    return true;
            }
            return false;
        }
        
        private void QuanLyChung_Load(object sender, EventArgs e)
        {
            List<string> tenquyenlist = Program.PhanQuyenList.Select(o => o.Tenquyen).ToList();
        
            if (KiemTraQuyen(tenquyen_hethong,tenquyenlist))
            {
                ribbonPageGroup_Phanquyen.Visible = true;
            }
            if (KiemTraQuyen(tenquyen_sanpham, tenquyenlist))
            {
                ribbonPageGroup_SanPham.Visible = true;
            }
            if (KiemTraQuyen(tenquyen_hoadon, tenquyenlist))
            {
                ribbonPageGroup_HoaDon.Visible = true;
            }
            if (KiemTraQuyen(tenquyen_nhanvien, tenquyenlist))
            {
                ribbonPageGroup_NhanVien.Visible = true;
            }

           

        }

        private void barButtonItem_qlnhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyNghiepVu.QuanLyNhanVien.NhanVien nhanvien = new QuanLyNghiepVu.QuanLyNhanVien.NhanVien();
            nhanvien.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(nhanvien);
            nhanvien.Dock = DockStyle.Fill;
            nhanvien.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            nhanvien.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}