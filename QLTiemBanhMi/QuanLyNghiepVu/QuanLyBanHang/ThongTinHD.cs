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

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyBanHang
{
    public partial class ThongTinHD : Form
    {
        private string magv;
        public ThongTinHD(BanHang banHang)
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

  

        private void ThongTinHD_Load(object sender, EventArgs e)
        {
            tb_mahd.Text = Program.FillData.SinhMaTuDong("MaKH", "KhachHang").ToString();
            tb_ngaylap.Text = DateTime.Now.ToString();
            List<string> list_kh_id = Program.FillData.LayDS_Len_GridLookUpEdit(glue_khachhang, "KhachHang", "HoTen", "MaKH");
            List<string> list_hinhthuctt_id = Program.FillData.LayDS_Len_GridLookUpEdit(glue_hinhthuctt, "HinhThucThanhToan", "TenLoaiHinhThucThanhToan", "MaThanhToan");
            tb_nhanvien.Text = Program.user.Tennv;

            ////load danh sach công ty
            //List<string> list_congtyid = Program.Quanlyhoadonsql.LayDS_CongTy(glue_khachhang);
            ////load danh sach nhân viên
            //List<string> list_nhanvienid = Program.Quanlyhoadonsql.LayDS_NhanVien(glue_nhanvien);
            ////load danh sach nguoi nhan hoa hong
            //List<string> list_nguoinhanhoahongid = Program.Quanlyhoadonsql.LayDS_NguoiNhanHoaHong(glue_nguoinhanhoahong);

            //if (Program.opt == 1) //them
            //{
            //    dtp_ngayhenthanhtoan.Enabled = true;
            //    tb_tienloi.Text = "0";
            //    tb_soluong.Text = "0";
            //    tb_ngaylap.Text = "0";
            //    tb_hoahong.Text = "0";

            //    tb_id.Text = Program.Quanlyhoadonsql.TaoMaHoaDon().ToString();
            //    HienThongTinLenEditValue(list_nhanvienid, Program.user.Id, glue_nhanvien);



            //}
            //if (Program.opt == 2) // sua
            //{
            //    dtp_ngayhenthanhtoan.Enabled = false;
            //    tb_tienloi.ReadOnly = false;
            //    tb_ngaylap.ReadOnly = false;
            //    tb_hoahong.ReadOnly = false;
            //    glue_nguoinhanhoahong.ReadOnly = false;

            //    setThongTinVaoFormDeSua(list_congtyid, list_nhanvienid, list_nguoinhanhoahongid);
            //}
        }

        public void setThongTinVaoFormDeSua(List<string> list_congtyid, List<string> list_nhanvienid, List<string> list_nguoinhanhoahongid)
        {

            //tb_id.Text = Program.hoaDon.Id;
            //tb_tenhoadon.Text = Program.hoaDon.Tenhoadon;
            //tb_soluong.Text = Program.hoaDon.Tongtien;
            //tb_ngaylap.Text = Program.hoaDon.Tongtiendathanhtoan;
            //tb_tienloi.Text = Program.hoaDon.Tienloi;
            //tb_hoahong.Text = Program.hoaDon.Hoahong;
            //tb_ghichu.Text = Program.hoaDon.Ghichu;
           
            //if(Program.hoaDon.Ngayhenthanhtoan == null)
            //{
            //    dtp_ngayhenthanhtoan.Value = System.DateTime.Now;
            //}
            //else
            //{
            //    try
            //    {
            //        dtp_ngayhenthanhtoan.Value = Convert.ToDateTime(Program.hoaDon.Ngayhenthanhtoan);
            //    }
            //    catch
            //    {
            //        dtp_ngayhenthanhtoan.Value = System.DateTime.Now;
            //    }

            //}
       
            //HienThongTinLenEditValue(list_congtyid, Program.hoaDon.Congtyid, glue_khachhang);
            //HienThongTinLenEditValue(list_nguoinhanhoahongid, Program.hoaDon.Nguoinhanhoahongid, glue_nguoinhanhoahong);
            //HienThongTinLenEditValue(list_nhanvienid, Program.user.Id, glue_nhanvien);

        }

       
        private void HienThongTinLenEditValue(List<string> list, string id, GridLookUpEdit gridLookUpEdit)
        {
            int index1 = list.IndexOf(id);
           
            gridLookUpEdit.EditValue = gridLookUpEdit.Properties.GetKeyValue(index1);
        }

        //public bool Kiemtra_HoaDon()
        //{
        //    //if (tb_soluong.Text == "" || tb_ngaylap.Text == "" || tb_tienloi.Text == "" || congtyid =="")
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
        //    //    tb_soluong.Text = dtp_ngayhenthanhtoan.Value.ToString();
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
            //            values = new object[] {Convert.ToString(tb_tenhoadon.Text), Int32.Parse(congtyid), Int64.Parse(tb_soluong.Text), Int32.Parse(Program.user.Id),
            //            Int64.Parse(tb_ngaylap.Text),dtp_ngayhenthanhtoan.Value, Int64.Parse(tb_tienloi.Text), Int64.Parse(tb_hoahong.Text),
            //            Int32.Parse(hoahongid),Convert.ToString(tb_ghichu.Text) };
            //        }
            //        else
            //        {
            //            sql = "ThemHoaDon_KoHoaHong";
            //            para = new string[] {"@tenhd", "@congtyid", "@tongtien", "@nhanvienid", "@ttthanhtoan", "@ngayhentt", "@tienloi", "@ghichu" };
            //            values = new object[] {Convert.ToString(tb_tenhoadon.Text), Int32.Parse(congtyid), Int64.Parse(tb_soluong.Text), Int32.Parse(Program.user.Id),
            //            Int64.Parse(tb_ngaylap.Text),dtp_ngayhenthanhtoan.Value, Int64.Parse(tb_tienloi.Text),
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
            //            values = new object[] { Int32.Parse(tb_id.Text),tb_tenhoadon.Text, Int32.Parse(congtyid), Int64.Parse(tb_soluong.Text),
            //            Int64.Parse(tb_ngaylap.Text),dtp_ngayhenthanhtoan.Value, Int64.Parse(tb_tienloi.Text), Int64.Parse(tb_hoahong.Text),
            //            Int32.Parse(hoahongid),0,tb_ghichu.Text };
            //        }    
            //        else
            //        {
            //            sql = "SuaHoaDon_KoHoaHong";
            //            para = new string[] { "@id", "@tenhd", "@congtyid", "@tongtien", "@ttthanhtoan", "@ngayhentt", "@tienloi", "@xoa", "@ghichu" };
            //            values = new object[] { Int32.Parse(tb_id.Text),tb_tenhoadon.Text, Int32.Parse(congtyid), Int64.Parse(tb_soluong.Text),
            //            Int64.Parse(tb_ngaylap.Text),dtp_ngayhenthanhtoan.Value, Int64.Parse(tb_tienloi.Text), 0,
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
        private void glue_congty_EditValueChanged_1(object sender, EventArgs e)
        {
            congtyid = glue_khachhang.EditValue.ToString();
        }

        private void glue_km_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void glue_hinhthuctt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}
