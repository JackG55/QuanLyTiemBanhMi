using DevExpress.XtraEditors;
using QLTiemBanhMi.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyNhanVien
{
    public partial class CaLam : Form
    {
        string macalam = "";
        public CaLam(NhanVien nhanVien)
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

      

        private void ChiTietHD_SP_Load(object sender, EventArgs e)
        {
            //load danh sach ca lam
            List<string> list_calam = Program.FillData.LayDS_Len_GridLookUpEdit(glue_calam, "CaLam", "MaCaLam", "MaCaLam");
        }

      
        public bool KiemTraNgayLam(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Value.Date < DateTime.Now.Date)
                return false;
            else
                return true;
        }


        public bool Kiemtra()
        {
            if (macalam == "")
            {
                MessageBox.Show("Bạn chưa chọn ca làm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtp_ngaylam.Value.Date < DateTime.Now.Date) // ktra so luong khi them
            {
                MessageBox.Show("Ngày làm không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string sql = "Them_LichLamViec";
                    string[] para = { "@MaNV", "@MaCaLam", "@NgayLamViec"};
                    object[] values = { Program.nhanvien.Manv, int.Parse(macalam), dtp_ngaylam.Value.Date};
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
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void glue_calam_EditValueChanged(object sender, EventArgs e)
        {
            macalam = glue_calam.EditValue.ToString();
        }
    }
}
