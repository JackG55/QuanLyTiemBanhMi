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

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLySanPham
{
    public partial class ChiTietKM : Form
    {
        public ChiTietKM(SanPham sanPham)
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

        public void setThongTinVaoFormDeSua()
        {
            tb_makm.Text = Program.chuongTrinhKhuyenMai.Makm.ToString();
            tb_tenkm.Text = Program.chuongTrinhKhuyenMai.Tenkm;
            tb_giamgia.Text = Program.chuongTrinhKhuyenMai.Phantramgiamgia.ToString();
            dtpngaybatdau.Value = Program.chuongTrinhKhuyenMai.Ngaybatdau.Date;

            dtpngayketthuc.Value = Program.chuongTrinhKhuyenMai.Ngayketthuc.Date;
           
        }


        public bool KiemTra()
        {
            if (tb_tenkm.Text == "" || tb_giamgia.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpngaybatdau.Value.Date > dtpngayketthuc.Value.Date)
            {
                MessageBox.Show("Ngày không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }    
            return true;
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
                return;
            else
            {
                if (Program.opt == 1) //them
                {
                    string sql = "Them_CTKM";
                    string[] para = { "@MaKM", "@TenKM", "@PhanTramGiamGia", "@NgayBatDau", "@NgayKetThuc"};
                    object[] values = { int.Parse(tb_makm.Text), tb_tenkm.Text, Int32.Parse(tb_giamgia.Text), dtpngaybatdau.Value.Date, dtpngayketthuc.Value.Date };
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
                    string sql = "Sua_CTKM";
                    string[] para = { "@MaKM", "@TenKM", "@PhanTramGiamGia", "@NgayBatDau", "@NgayKetThuc" };
                    object[] values = { int.Parse(tb_makm.Text), tb_tenkm.Text, Int32.Parse(tb_giamgia.Text), dtpngaybatdau.Value.Date, dtpngayketthuc.Value.Date }; 
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

        private void ChiTietSP_Load(object sender, EventArgs e)
        {

           if (Program.opt == 1) //them
           {
                tb_makm.Text = "";
                tb_tenkm.Text = "";
                tb_giamgia.Text = "1";
                //sql lấy mã
                tb_makm.Text = Program.FillData.SinhMaTuDong("MaKM", "ChuongTrinhKhuyenMai").ToString();
            }
            if (Program.opt == 2) // sua
            {
                setThongTinVaoFormDeSua();
            }
        }

      
        private void tb_giamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
