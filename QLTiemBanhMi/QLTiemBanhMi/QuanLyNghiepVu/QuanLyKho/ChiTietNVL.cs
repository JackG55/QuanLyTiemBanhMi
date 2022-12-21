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
    public partial class ChiTietNVL : Form
    {
        public ChiTietNVL()
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
        private void ChiTietNVL_Load(object sender, EventArgs e)
        {
            if (Program.opt == 1) //them
            {

                tb_tennvl.Text = "";
                tb_mota.Text = "";
                tb_dvt.Text = "";
                tb_slt.Text = "";

                tb_msnvl.ReadOnly = true;

                tb_msnvl.Text = Program.FillData.SinhMaTuDong("MSNVL", "NguyenVatLieu").ToString();
            }
            if (Program.opt == 2) // sua
            {
                tb_msnvl.ReadOnly = true;
                setThongTinVaoFormDeSua();
            }
        }


        public void setThongTinVaoFormDeSua()
        {
            tb_msnvl.Text = Program.nguyenVatLieu.Msnvl;
            tb_tennvl.Text = Program.nguyenVatLieu.Tennvl; 
            tb_mota.Text = Program.nguyenVatLieu.Mota; 
            tb_dvt.Text = Program.nguyenVatLieu.Dvt; 
            tb_slt.Text = Program.nguyenVatLieu.Slton; 

        }

        public bool KiemTra()
        {
            if (tb_msnvl.Text == "" || tb_tennvl.Text == "")
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            List<string> list_tenNVL = Program.FillData.LayDSTen("TenNVL", "NguyenVatLieu");
            if (Program.opt == 1)
            {
                if (list_tenNVL.Contains(tb_tennvl.Text))
                {
                    DialogResult result = MessageBox.Show("Tên loại nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            if (Program.opt == 2)
            {

                list_tenNVL.Remove(Program.nguyenVatLieu.Tennvl);
                if (list_tenNVL.Contains(tb_tennvl.Text))
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
                string[] para = { "@MaNVL", "@TenNVL", "@Mota", "@DVT", "@SLTon" };
                object[] values = { Int32.Parse(tb_msnvl.Text), tb_tennvl.Text, tb_mota.Text, tb_dvt.Text, Int32.Parse(tb_slt.Text) };
                if (Program.opt == 1) //them
                {
                    string sql = "Them_NVL";
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
                    string sql = "Sua_NVL";
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
