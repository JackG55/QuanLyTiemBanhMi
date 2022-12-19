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


        public void setThongTinVaoFormDeSua()
        {

            tb_manv.Text = Program.nhanvien.Manv.ToString(); ;
            tb_username.Text = Program.nhanvien.Username;
            tb_diachi.Text = Program.nhanvien.Diachi;
            tb_tennv.Text = Program.nhanvien.Tennv;
            if (Program.nhanvien.Namsinh == null)
            {
                dtp_ngaysinh.Value = System.DateTime.Now;
            }
            else
            {
                try
                {
                    dtp_ngaysinh.Value = Convert.ToDateTime(Program.nhanvien.Namsinh);
                }
                catch
                {
                    dtp_ngaysinh.Value = System.DateTime.Now;
                }

            }
            cbb_gioitinh.ValueMember = Program.nhanvien.Gioitinh;
            cbbChucVu.ValueMember = Program.nhanvien.Chucvu;
        }
        public bool KiemTra()
        {
            if (tb_username.Text == ""|| tb_tennv.Text == "" || cbbChucVu.Text=="" || cbb_gioitinh.Text=="" || tb_diachi.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(dtp_ngaysinh.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string[] para = {"@MaNV" ,"@TenNV","@UserName","@Pass","@NamSinh","@DiaChi","@ChucVu","@GioiTinh"};
                    object[] values = { int.Parse(tb_manv.Text), tb_tennv.Text, tb_username.Text, tb_matkhau.Text, dtp_ngaysinh.Value,tb_diachi.Text,cbbChucVu.Text,cbb_gioitinh.Text};
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
                    string[] para = { "@MaNV", "@TenNV", "@NamSinh", "@DiaChi", "@ChucVu", "@GioiTinh" };
                    object[] values = { int.Parse(tb_manv.Text), tb_tennv.Text, dtp_ngaysinh.Value, tb_diachi.Text, cbbChucVu.Text, cbb_gioitinh.Text };
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


    
        private void ChiTietNV_Load(object sender, EventArgs e)
        {

            //load danh sach loai nhan vien
           //List<string> list_loainhanvienId = Program.Quanlynhanviensql.LayDS_LoaiNhanVien(glue_loainhanvien);
            if (Program.opt == 1) //them
            {
                Random _random = new Random();
                tb_manv.Text = "";
                tb_username.Text = "";
                tb_diachi.Text = "";
                tb_tennv.Text = "";
               // tb_ghichu.Text = "";
                tb_matkhau.Text = _random.Next(100000, 1000000).ToString();
                tb_matkhau.ReadOnly = true;
                tb_manv.ReadOnly = true;
                tb_manv.Text = Program.FillData.SinhMaTuDong("MaNV", "NhanVien").ToString();
            }
            if (Program.opt == 2) // sua
            {
                tb_manv.ReadOnly = true;
                tb_matkhau.Visible = false;
                labelMK.Visible = false;
                setThongTinVaoFormDeSua();
            }
        }
    }
}
