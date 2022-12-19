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

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyKho
{
    public partial class ChiTietNCC : Form
    {
        public ChiTietNCC()
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

        private void ChiTietNCC_Load(object sender, EventArgs e)
        {
            if (Program.opt == 1) //them
            {
                tb_tenncc.Text = "";
                tb_diachi.Text = "";
                tb_sdt.Text = "";

                tb_mancc.ReadOnly = true;

                tb_mancc.Text = Program.FillData.SinhMaTuDong("MaNCC", "NhaCungCap").ToString();
            }
            if (Program.opt == 2) // sua
            {
                tb_mancc.ReadOnly = true;
                setThongTinVaoFormDeSua();
            }
        }

        public void setThongTinVaoFormDeSua()
        {
            tb_mancc.Text = Program.nhaCungCap.Mancc;
            tb_tenncc.Text = Program.nhaCungCap.Tenncc ;
            tb_diachi.Text = Program.nhaCungCap.Diachi;
            tb_sdt.Text = Program.nhaCungCap.Sdt;
        }

        public bool KiemTra()
        {
            if (tb_mancc.Text == "" || tb_tenncc.Text == "")
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            List<string> list_tenNCC = Program.FillData.LayDSTen("TenNCC", "NhaCungCap");
            if (Program.opt == 1)
            {
                if (list_tenNCC.Contains(tb_tenncc.Text))
                {
                    DialogResult result = MessageBox.Show("Tên loại nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            if (Program.opt == 2)
            {

                list_tenNCC.Remove(Program.nhaCungCap.Tenncc);
                if (list_tenNCC.Contains(tb_tenncc.Text))
                {
                    DialogResult result = MessageBox.Show("Tên loại nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
                return;
            else
            {
                string[] para = { "@MaNCC", "@TenNCC", "@DiaChi", "@SDT"};
                object[] values = { Int32.Parse(tb_mancc.Text), tb_tenncc.Text, tb_diachi.Text, tb_sdt.Text };
                if (Program.opt == 1) //them
                {
                    string sql = "Them_NCC";
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
                    string sql = "Sua_NCC";
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

      
    }
}
