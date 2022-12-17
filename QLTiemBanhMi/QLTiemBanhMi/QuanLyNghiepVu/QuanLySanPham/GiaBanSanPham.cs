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
    public partial class GiaBanSanPham: Form
    {
        public GiaBanSanPham(SanPham sp)
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

        private void GiaBanSanPham_Load(object sender, EventArgs e)
        {
            if (Program.opt == 1) //them
            {
                tb_id.Text = "";
                tb_giaban.Text = "";
                tb_ghichu.Text = "";
                

                tb_id.ReadOnly = true;
                tb_tennhanvien.ReadOnly = true;

                tb_tennhanvien.Text = Program.user.Tendaydu.ToString();
                tb_id.Text = Program.sanpham.Id;
            }
           
        }

      
        public bool KiemTra()
        {
            if (tb_id.Text == "" || tb_giaban.Text == "")
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
                string sql = "Them_GiaBan";
                string[] para = { "@sanphamID", "@giaban", "@nhanviencapnhatID","@ghichu" };
                object[] values = { Int32.Parse(Program.sanpham.Id), Int64.Parse(tb_giaban.Text), Int32.Parse(Program.user.Id.ToString()), Convert.ToString(tb_ghichu.Text) };
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

    }
}
