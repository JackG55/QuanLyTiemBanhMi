using DevExpress.XtraEditors;
using QLTiemBanhMi.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyBanHang
{
    public partial class ChiTietHD : Form
    {
        string tensp = "";
        public ChiTietHD(ThongTinHD thongTinHD)
        {
            InitializeComponent();
        }
        string masp;
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void edit()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            //load danh sach san pham
            List<string> list_sanpham_id = Program.FillData.LayDS_Len_GridLookUpEdit(glue_sanpham,"SanPham","TenSP","MaSP");
            tb_soluong.Text = "1";

        }

        public bool Kiemtra()
        {
            if (int.Parse(tb_soluong.Text)<1 || masp == "" )
            {
                MessageBox.Show("Thông tin không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!Kiemtra())
                return;
            else
            {
                Program.chiTietHoaDon = new Object.ChiTietHoaDon(int.Parse(tb_masanpham.Text), tensp, int.Parse(tb_soluong.Text), int.Parse(tb_dongia.Text));
                edit();
                this.Close();
                

            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void glue_hang_EditValueChanged(object sender, EventArgs e)
        {
            tb_masanpham.Text = glue_sanpham.EditValue.ToString();
            masp = tb_masanpham.Text;
            tensp = Program.FillData.LayGiaTriTheoMa("MaSP", masp, "SanPham", "TenSP").ToString();
            tb_dongia.Text = Program.FillData.LayGiaTriTheoMa("MaSP", masp, "SanPham", "GiaBan").ToString();
        }
    }
}
