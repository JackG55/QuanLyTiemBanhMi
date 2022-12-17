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

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyNhanVien
{
    public partial class ChiTietNV: Form
    {
        string loainhanvienid = "";
        public ChiTietNV(NhanVien nhanVien)
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


        public void setThongTinVaoFormDeSua(List<string> list_loainhanvienId)
        {

            tb_id.Text = Program.nhanvien.Id;
            tb_tendangnhap.Text = Program.nhanvien.Tendangnhap;
            tb_diachi.Text = Program.nhanvien.Diachi;
            tb_tendaydu.Text = Program.nhanvien.Tendaydu;
            tb_ghichu.Text = Program.nhanvien.Ghichu;
            tb_matkhau.Text = Program.nhanvien.Matkhau;

            HienThongTinLenEditValue(list_loainhanvienId, Program.nhanvien.Loainhanvienid.ToString());
        }

        private void HienThongTinLenEditValue(List<string> list_loainhanvienId, string loainhanvienId)
        {
            int index = list_loainhanvienId.BinarySearch(loainhanvienId);
            glue_loainhanvien.EditValue = glue_loainhanvien.Properties.GetKeyValue(index);
        }


        public bool KiemTra()
        {
            if (tb_tendangnhap.Text == ""||
            tb_diachi.Text == ""||
            tb_tendaydu.Text == ""||
            tb_matkhau.Text == ""||glue_loainhanvien.EditValue == null)
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
                    string sql = "Them_NV";
                    string[] para = {"@tendangnhap", "@matkhau", "@tendaydu", "@diachi", "@loainhanvienID", "@ghichu" };
                    object[] values = {tb_tendangnhap.Text, Convert.ToString(tb_matkhau.Text), Convert.ToString(tb_tendaydu.Text), Convert.ToString(tb_diachi.Text), glue_loainhanvien.EditValue.ToString(), Convert.ToString(tb_ghichu.Text) };
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
                    string sql = "Sua_NV";
                    string[] para = { "@id", "@tendangnhap", "@tendaydu", "@diachi", "@loainhanvienID", "@ghichu" };
                    object[] values = { Int32.Parse(tb_id.Text), Convert.ToString(tb_tendangnhap.Text), Convert.ToString(tb_tendaydu.Text), Convert.ToString(tb_diachi.Text), glue_loainhanvien.EditValue.ToString(), Convert.ToString(tb_ghichu.Text) };
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


        private void gluenhanvien_EditValueChanged(object sender, EventArgs e)
        {
            //gan gia tri
            loainhanvienid = glue_loainhanvien.EditValue.ToString();
        }

        private void ChiTietNV_Load(object sender, EventArgs e)
        {

            //load danh sach loai nhan vien
            List<string> list_loainhanvienId = Program.Quanlynhanviensql.LayDS_LoaiNhanVien(glue_loainhanvien);
            if (Program.opt == 1) //them
            {
                Random _random = new Random();
                tb_id.Text = "";
                tb_tendangnhap.Text = "";
                tb_diachi.Text = "";
                tb_tendaydu.Text = "";
                tb_ghichu.Text = "";
                tb_matkhau.Text = _random.Next(100000, 1000000).ToString();
                tb_matkhau.ReadOnly = true;
                tb_id.ReadOnly = true;

                
                tb_id.Text = Program.Quanlynhanviensql.TaoMaNhanVien().ToString();
            }
            if (Program.opt == 2) // sua
            {
                tb_id.ReadOnly = true;
                tb_matkhau.Visible = false;
                labelMK.Visible = false;
                setThongTinVaoFormDeSua(list_loainhanvienId);
            }
        }
    }
}
