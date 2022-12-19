using DevExpress.XtraEditors;
using QLTiemBanhMi.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyBanHang
{
    public partial class ChiTietKH : Form
    {

        public ChiTietKH(BanHang banHang)
        {
            InitializeComponent();
        }
        string maloaikh;
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
        private void ChiTietKH_Load(object sender, EventArgs e)
        {
            //load danh sach san pham
            List<string> list_loaikh_id = Program.FillData.LayDS_Len_GridLookUpEdit(glue_hang,"LoaiKH","TenLoaiKH","MaLoaiKH");

            if (Program.opt == 1) //them
            {
                tb_makh.Text = Program.FillData.SinhMaTuDong("MaKH", "KhachHang").ToString();
                tb_hoten.Text = "";
                tb_dtl.Text = "0";
                HienThongTinLenEditValue(list_loaikh_id, "5", glue_hang);
            }
            if (Program.opt == 2) // sua
            {

                setThongTinVaoFormDeSua(list_loaikh_id);
            }
        }

        public void setThongTinVaoFormDeSua(List<string> list_loaikh_id)
        {
            tb_makh.Text = Program.khachHang.Makh.ToString();
            tb_hoten.Text = Program.khachHang.Hoten;
            tb_dtl.Text = Program.khachHang.Diemtichluy.ToString();
            cbb_gioitinh.Text = Program.khachHang.Gioitinh;
            tb_sdt.Text = Program.khachHang.Sdt;
            HienThongTinLenEditValue(list_loaikh_id, Program.khachHang.Maloaikh.ToString(), glue_hang);

        }


        private void HienThongTinLenEditValue(List<string> list, string id, GridLookUpEdit gridLookUpEdit)
        {
            int index1 = list.BinarySearch(id);
            gridLookUpEdit.EditValue = gridLookUpEdit.Properties.GetKeyValue(index1);
        }

        public bool KiemTraNgayHenThanhToan(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Value.Date < DateTime.Now.Date)
                return false;
            else
                return true;
        }


        public bool Kiemtra()
        {
            if (maloaikh == "" || tb_hoten.Text == "" ||cbb_gioitinh.Text == "" || tb_sdt.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtp_ngaysinh.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (Program.opt == 1) //them
                {
                    string sql = "Them_KH";
                    string[] para = { "@MaKH", "@HoTen", "@NgaySinh", "@SDT", "@GioiTinh"};
                    object[] values = { Int32.Parse(tb_makh.Text),tb_hoten.Text, dtp_ngaysinh.Value.Date, tb_sdt.Text, cbb_gioitinh.Text};
                    int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
                    if (a != 0)
                    {
                        DialogResult result2 = MessageBox.Show("Thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result2 == DialogResult.OK)
                        {
                            this.Close();
                            edit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (Program.opt == 2) //sua
                {
                    string sql = "Sua_KH";
                    string[] para = { "@MaKH", "@HoTen", "@NgaySinh", "@SDT", "@GioiTinh" };
                    object[] values = { Int32.Parse(tb_makh.Text), tb_hoten.Text, dtp_ngaysinh.Value.Date, tb_sdt.Text, cbb_gioitinh.Text };
                    int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
                    if (a != 0)
                    {
                        DialogResult result2 = MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result2 == DialogResult.OK)
                        {
                            this.Close();
                            edit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void glue_hang_EditValueChanged(object sender, EventArgs e)
        {
            maloaikh = glue_hang.EditValue.ToString();
        }
    }
}
