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
using System.Diagnostics;
using System.IO;
using QLTiemBanhMi.Object;
namespace QLTiemBanhMi.QuanTriHeThong

{
    public partial class QuanLyChung : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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

        private void QuanLyChung_Load(object sender, EventArgs e)
        {

            if (Program.user.Chucvu == "Nhan Vien Ban Hang")
            {
                ribbonPageGroup_BanHang.Visible = true;
            }
            if (Program.user.Chucvu == "Nhan Vien Kho")
            {
                ribbonPageGroup_Kho.Visible = true;
            }
            if (Program.user.Chucvu == "Quan Ly")
            {
                ribbonPageGroup_SanPham.Visible = true;
                ribbonPageGroup_NhanVien.Visible = true;
            }
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

        private void barButtonItem_banhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyNghiepVu.QuanLyBanHang.BanHang banHang = new QuanLyNghiepVu.QuanLyBanHang.BanHang();
            banHang.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(banHang);
            banHang.Dock = DockStyle.Fill;
            banHang.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            banHang.Show();
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

        private void bbi_quanlykho_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyNghiepVu.QuanLyKho.Kho kho = new QuanLyNghiepVu.QuanLyKho.Kho();
            kho.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(kho);
            kho.Dock = DockStyle.Fill;
            kho.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kho.Show();
        }

       
    }
}