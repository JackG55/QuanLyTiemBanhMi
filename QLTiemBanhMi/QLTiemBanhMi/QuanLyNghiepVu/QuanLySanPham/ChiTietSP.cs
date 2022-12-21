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
    public partial class ChiTietSP : Form
    {
        public ChiTietSP(SanPham sp)
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

        public void setThongTinVaoFormDeSua(List<string> list_danhmuc_id)
        {
            tb_masp.Text = Program.sanPham.Masp.ToString();
            tb_tensanpham.Text = Program.sanPham.Tensp;
            tb_giaban.Text = Program.sanPham.Giaban.ToString();
            tb_mota.Text = Program.sanPham.Mota;

            HienThongTinLenEditValue(list_danhmuc_id, Program.sanPham.Madm.ToString());
        }

        private void HienThongTinLenEditValue(List<string> list_danhmuc_id, string madm)
        {
            int index = list_danhmuc_id.BinarySearch(madm);
            glue_danhmucsp.EditValue = glue_danhmucsp.Properties.GetKeyValue(index);
        }

        public bool KiemTra()
        {
            if (tb_tensanpham.Text == "" || tb_giaban.Text == "" || tb_mota.Text == "" || glue_danhmucsp.EditValue.ToString() == "")
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string sql = "Them_SP";
                    string[] para = { "@MaSP", "@TenSP", "@MaDM", "@MoTa", "@GiaBan"};
                    object[] values = { int.Parse(tb_masp.Text), tb_tensanpham.Text, Int32.Parse(glue_danhmucsp.EditValue.ToString()), tb_mota.Text, int.Parse(tb_giaban.Text) };
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
                    string sql = "Sua_SP";
                    string[] para = { "@MaSP", "@TenSP", "@MaDM", "@MoTa", "@GiaBan" };
                    object[] values = { int.Parse(tb_masp.Text), tb_tensanpham.Text, Int32.Parse(glue_danhmucsp.EditValue.ToString()), tb_mota.Text, int.Parse(tb_giaban.Text) };
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

            //load danh sach danh mục
            List<string> list_danhmuc_id = Program.FillData.LayDS_Len_GridLookUpEdit(glue_danhmucsp,"DanhMucSanPham","TenDanhMuc","MaDM");
            if (Program.opt == 1) //them
            {
                tb_tensanpham.Text = "";
                tb_mota.Text = "";
                tb_giaban.Text = "0";
                //sql lấy mã
                tb_masp.Text = Program.FillData.SinhMaTuDong("MaSP","SanPham").ToString();
            }
            if (Program.opt == 2) // sua
            {
                setThongTinVaoFormDeSua(list_danhmuc_id);
            }
        }
        private void tb_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
