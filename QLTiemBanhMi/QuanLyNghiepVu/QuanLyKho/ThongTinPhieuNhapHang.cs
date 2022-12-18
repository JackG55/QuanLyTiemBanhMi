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
        public ThongTinPhieuNhapHang()
        {
            InitializeComponent();
        }
        string nccid = "";
        string nhanvienid="";

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
                tb_ngaytao.Text = "";
                tb_tongtien.Text = "";

                tb_maphieunhap.ReadOnly = true;
                tb_maphieunhap.Text = Program.FillData.SinhMaTuDong("MaPhieuNhap", "PhieuNhapHang").ToString();

                HienThongTinLenEditValue(list_NhaCungCapId, Program.phieuNhapHang.Mancc, glue_ncc);
                HienThongTinLenEditValue(list_NhanVienid, Program.phieuNhapHang.Manv, glue_nhanvien);


            }
            if (Program.opt == 2) // sua
            {
                tb_maphieunhap.ReadOnly = true;

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


        //public bool Kiemtra_HoaDon()
        //{
        //    //if (tb_tongtien.Text == "" || tb_tienthanhtoan.Text == "" || tb_tienloi.Text == "" || congtyid =="")
        //    //{
        //    //    DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    return false;
        //    //}
        //    //if(Int32.Parse(tb_hoahong.Text)!= 0)
        //    //{
        //    //    if(hoahongid=="")
        //    //    {
        //    //        DialogResult result = MessageBox.Show("Người nhận hoa hồng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //        return false;
        //    //    }    
        //    //}    
        //    //if (KiemTraNgayHenThanhToan(dtp_ngayhenthanhtoan)==false)
        //    //{
        //    //    tb_tongtien.Text = dtp_ngayhenthanhtoan.Value.ToString();
        //    //    DialogResult result = MessageBox.Show("Ngày hẹn thanh toán không không hợp lệ", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    return false;
        //    //}
        //    //return true;
        //}

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            //if (!Kiemtra_HoaDon())
            //    return;
            //else
            //{
            //    if (Program.opt == 1) //them
            //    {
            //        string sql = "";
            //        string[] para;
            //        object[] values;
            //        if (Int64.Parse(tb_hoahong.Text) != 0)
            //        {
            //            sql = "ThemHoaDon_CoHoaHong";
            //            para = new string[] {"@tenhd", "@congtyid", "@tongtien", "@nhanvienid", "@ttthanhtoan", "@ngayhentt", "@tienloi", "@hoahong", "@nguoinhanhh", "@ghichu" };
            //            values = new object[] {Convert.ToString(tb_tenhoadon.Text), Int32.Parse(congtyid), Int64.Parse(tb_tongtien.Text), Int32.Parse(Program.user.Id),
            //            Int64.Parse(tb_tienthanhtoan.Text),dtp_ngayhenthanhtoan.Value, Int64.Parse(tb_tienloi.Text), Int64.Parse(tb_hoahong.Text),
            //            Int32.Parse(hoahongid),Convert.ToString(tb_ghichu.Text) };
            //        }
            //        else
            //        {
            //            sql = "ThemHoaDon_KoHoaHong";
            //            para = new string[] {"@tenhd", "@congtyid", "@tongtien", "@nhanvienid", "@ttthanhtoan", "@ngayhentt", "@tienloi", "@ghichu" };
            //            values = new object[] {Convert.ToString(tb_tenhoadon.Text), Int32.Parse(congtyid), Int64.Parse(tb_tongtien.Text), Int32.Parse(Program.user.Id),
            //            Int64.Parse(tb_tienthanhtoan.Text),dtp_ngayhenthanhtoan.Value, Int64.Parse(tb_tienloi.Text),
            //            Convert.ToString(tb_ghichu.Text) };
            //        }

                 
            //        int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //        if (a != 0)
            //        {
            //            DialogResult result2 = MessageBox.Show("Thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            if (result2 == DialogResult.OK)
            //            {
            //                this.Close();
            //                edit();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Thêm thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

            //    }
            //    if (Program.opt == 2) //sua
            //    {
            //        string sql = "";
            //        string[] para;
            //        object[] values;
            //        if(Int64.Parse(tb_hoahong.Text)!=0)
            //        {
            //            sql = "SuaHoaDon_CoHoaHong";
            //            para = new string[] { "@id", "@tenhd", "@congtyid", "@tongtien", "@ttthanhtoan", "@ngayhentt", "@tienloi", "@hoahong", "@nguoinhanhh", "@xoa", "@ghichu" };
            //            values = new object[] { Int32.Parse(tb_maphieunhap.Text),tb_tenhoadon.Text, Int32.Parse(congtyid), Int64.Parse(tb_tongtien.Text),
            //            Int64.Parse(tb_tienthanhtoan.Text),dtp_ngayhenthanhtoan.Value, Int64.Parse(tb_tienloi.Text), Int64.Parse(tb_hoahong.Text),
            //            Int32.Parse(hoahongid),0,tb_ghichu.Text };
            //        }    
            //        else
            //        {
            //            sql = "SuaHoaDon_KoHoaHong";
            //            para = new string[] { "@id", "@tenhd", "@congtyid", "@tongtien", "@ttthanhtoan", "@ngayhentt", "@tienloi", "@xoa", "@ghichu" };
            //            values = new object[] { Int32.Parse(tb_maphieunhap.Text),tb_tenhoadon.Text, Int32.Parse(congtyid), Int64.Parse(tb_tongtien.Text),
            //            Int64.Parse(tb_tienthanhtoan.Text),dtp_ngayhenthanhtoan.Value, Int64.Parse(tb_tienloi.Text), 0,
            //            0,tb_ghichu.Text };
            //        }    
                   
            //        int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //        if (a != 0)
            //        {
            //            DialogResult result2 = MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            if (result2 == DialogResult.OK)
            //            {
            //                this.Close();
            //                edit();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Sửa thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }

            //}
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gluenhanvien_EditValueChanged(object sender, EventArgs e)
        {
            //lấy gia tri mã nhân viên
            //Program.hoaDon.Nhanvienid = glue_nhanvien.EditValue.ToString();
            nhanvienid = glue_nhanvien.EditValue.ToString();
        }

     
      
        
       
        private void tb_tongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void glue_congty_EditValueChanged_1(object sender, EventArgs e)
        {
            nccid = glue_ncc.EditValue.ToString();
        }

    }
}
