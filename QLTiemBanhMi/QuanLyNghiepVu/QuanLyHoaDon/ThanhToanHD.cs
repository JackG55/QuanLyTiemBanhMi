using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using QLTiemBanhMi.Connector;

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyHoaDon
{
    public partial class ThanhToanHD : Form
    {
        public ThanhToanHD(HoaDon hoaDon)
        {
            InitializeComponent();
        }
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
            tb_id.Text = Program.Quanlyhoadonsql.TaoMaThanhHoaDon().ToString();
            tb_hoadonid.Text = Program.hoaDon.Id;
            tb_tienthanhtoan.Text = "0";

        }

      
        public bool KiemTraNgayHenThanhToan()
        {
            if (dtp_ngaythanhtoantieptheo.Value.Date < DateTime.Now.Date)
                return false;

            else
                return true;
        }


        public bool Kiemtra_ThanhToanHoaDon()
        {
            if (tb_tienthanhtoan.Text == "0")
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
            if (!KiemTraNgayHenThanhToan())
            {
                DialogResult result = MessageBox.Show("Ngày hẹn thanh toán không không hợp lệ", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!Kiemtra_ThanhToanHoaDon())
                return;
            else
            {
                string sql = "ThemThanhToanHoaDon";
                string[] para = { "@hoadonid", "@tienthanhtoan", "@ngaythanhtoantieptheo", "@ghichu" };
                object[] values = {Int32.Parse(tb_hoadonid.Text), Int32.Parse(tb_tienthanhtoan.Text),dtp_ngaythanhtoantieptheo.Value, Convert.ToString(tb_ghichu.Text) };
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
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_tienthanhtoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       
      
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
