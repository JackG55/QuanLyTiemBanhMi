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
    public partial class ThongTinPhieuNhapHang : Form
    {
        private string magv;
        public ThongTinPhieuNhapHang(Kho kho)
        {
            InitializeComponent();
        }
        string nccid = "";

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

  

        private void ThongTinPhieuNhapHang_Load(object sender, EventArgs e)
        {
            //load danh sach nhà cung cấp
            List<string> list_NhaCungCapId = Program.FillData.LayDS_Len_GridLookUpEdit(glue_ncc, "NhaCungCap", "TenNCC", "MaNCC");
            //load danh sach nhân viên
            List<string> list_NhanVienid = Program.FillData.LayDS_Len_GridLookUpEdit(glue_nhanvien, "NhanVien", "TenNV", "MaNV");

            if (Program.opt == 1) //them
            {
                tb_ngaytao.Text = DateTime.Now.Date.ToString();
                tb_tongtien.Text = "0";
                tb_maphieunhap.Text = Program.FillData.SinhMaTuDong("MaPhieuNhap", "PhieuNhapHang").ToString();

                HienThongTinLenEditValue(list_NhanVienid, Program.user.Manv.ToString(), glue_nhanvien);


            }
            if (Program.opt == 2) // sua
            {

                setThongTinVaoFormDeSua(list_NhaCungCapId, list_NhanVienid);
            }
        }

        public void setThongTinVaoFormDeSua(List<string> list_NhaCungCapId, List<string> list_NhanVienid)
        {
            tb_maphieunhap.Text = Program.phieuNhapHang.Maphieunhap;
            tb_ngaytao.Text = Program.phieuNhapHang.Ngaytao.ToString();
            tb_tongtien.Text = Program.phieuNhapHang.Tongtien;

            HienThongTinLenEditValue(list_NhaCungCapId, Program.phieuNhapHang.Mancc, glue_ncc);
            HienThongTinLenEditValue(list_NhanVienid, Program.phieuNhapHang.Manv, glue_nhanvien);
            

        }

       
        private void HienThongTinLenEditValue(List<string> list, string id, GridLookUpEdit gridLookUpEdit)
        {
            int index1 = list.IndexOf(id);
           
            gridLookUpEdit.EditValue = gridLookUpEdit.Properties.GetKeyValue(index1);
        }

        public bool KiemTraNgayHenThanhToan(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Value < DateTime.Now)
                return false;
            else
                return true;
        }


        public bool KiemTra()
        {
            if (nccid == "")
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
                    string sql = "Them_PhieuNhapHang";
                    string[] para = new string[] { "@MaPhieuNhap", "@NgayTao", "@MaNCC", "@MaNV"};
                    object[] values = new object[] { Int32.Parse(tb_maphieunhap.Text), Convert.ToDateTime(tb_ngaytao.Text), Int32.Parse(nccid), Program.user.Manv};
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
                    string sql = "Sua_PhieuNhapHang";
                    string[] para = new string[] { "@MaPhieuNhap", "@MaNCC" };
                    object[] values = new object[] { Int32.Parse(tb_maphieunhap.Text), Convert.ToDateTime(tb_ngaytao.Text), Int32.Parse(nccid), Program.user.Manv };
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
        
        private void glue_congty_EditValueChanged_1(object sender, EventArgs e)
        {
            nccid = glue_ncc.EditValue.ToString();
        }

    }
}
