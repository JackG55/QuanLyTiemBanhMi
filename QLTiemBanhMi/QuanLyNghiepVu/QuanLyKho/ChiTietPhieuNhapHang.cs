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
    public partial class ChiTietPhieuNhapHang : Form
    {

        public ChiTietPhieuNhapHang()
        {
            InitializeComponent();
        }
        string sanphamid;
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

        List<string> list_malhp= new List<string>();
        List<string> list_tenlhp = new List<string>();
      
        private void ChiTietPhieuNhapHang_Load(object sender, EventArgs e)
        {
            ////load danh sach san pham
            //List<string> list_sanphamid = Program.Quanlyhoadonsql.LayDS_SanPham(glue_nguyenvatlieu);
            
            //if (Program.opt == 1) //them
            //{
            //    tb_tienloi.Text = "0";
            //    tb_soluong.Text = "0";
            //    tb_dongia.Text = "0";
            //    tb_VAT.Text = "0";
            //    tb_id.Text = Program.Quanlyhoadonsql.TaoMaHoaDon_SP().ToString();
            //    tb_maphieunhap.Text = Program.hoaDon.Id;

            //}
            //if (Program.opt == 2) // sua
            //{
                
            //    setThongTinVaoFormDeSua(list_sanphamid);
            //}
        }

        public void setThongTinVaoFormDeSua(List<string> list_sanphamid)
        {
            //tb_id.Text = Program.chiTietHoaDon.Id;
            //tb_maphieunhap.Text = Program.chiTietHoaDon.Hoadonid;
            //tb_soluong.Text = Program.chiTietHoaDon.Soluong;
            //tb_dongia.Text = Program.chiTietHoaDon.Giaban;
            //if (Program.chiTietHoaDon.Tienloi == "")
            //    tb_tienloi.Text = "0";
            //else
            //    tb_tienloi.Text = Program.chiTietHoaDon.Tienloi;
            //if (Program.chiTietHoaDon.Vat == "")
            //    tb_VAT.Text = "0";
            //else
            //    tb_VAT.Text = Program.chiTietHoaDon.Vat;
           
            //tb_ghichu.Text = Program.chiTietHoaDon.Ghichu;
            //sanphamid = Program.chiTietHoaDon.Sanphamid;
            //HienThongTinLenEditValue(list_sanphamid, Program.chiTietHoaDon.Sanphamid, glue_nguyenvatlieu);
            
        }

       
        private void HienThongTinLenEditValue(List<string> list, string id, GridLookUpEdit gridLookUpEdit)
        {
            int index1 = list.BinarySearch(id);
            gridLookUpEdit.EditValue = gridLookUpEdit.Properties.GetKeyValue(index1);
        }

        public bool KiemTraNgayHenThanhToan(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Value.Date < DateTime.Now.Date)
                return false;
            else
                return true;
        }


        //public bool Kiemtra_HoaDonSP()
        //{
        //    //if (sanphamid == "" || tb_dongia.Text == "" || tb_tienloi.Text == "" || tb_VAT.Text =="" ||tb_soluong.Text =="")
        //    //{
        //    //    DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //    return false;
        //    //}
        //    //if(Program.opt ==1) // ktra so luong khi them
        //    //{
        //    //    if (Int32.Parse(tb_soluong.Text) > Program.Quanlyhoadonsql.LaySoLuongTonTheoIDSanPham(Int32.Parse(sanphamid)))
        //    //    {
        //    //        DialogResult result = MessageBox.Show("Số lượng phải ít hơn số lượng tồn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //        return false;

        //    //    }
        //    //}    
            
        //    //return true;
        //}

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            //if (!Kiemtra_HoaDonSP())
            //    return;
            //else
            //{
            //    if (Program.opt == 1) //them
            //    {
            //        //string sql = "ThemHoaDon_SanPham";
            //        //string[] para = { "@hoadonid", "@sanphamid", "@soluong", "@giaban", "@vat", "@tienloi","@ghichu" };
            //        //object[] values = { Int32.Parse(tb_maphieunhap.Text),Int32.Parse(sanphamid), Int32.Parse(tb_soluong.Text), Int32.Parse(tb_dongia.Text), Int32.Parse(tb_VAT.Text), Int32.Parse(tb_tienloi.Text),Convert.ToString(tb_ghichu.Text) };
            //        //int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //        //if (a != 0)
            //        //{
            //        //    DialogResult result2 = MessageBox.Show("Thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //    if (result2 == DialogResult.OK)
            //        //    {
            //        //        this.Close();
            //        //        edit();
            //        //    }
            //        //}
            //        //else
            //        //{
            //        //    MessageBox.Show("Thêm thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        //}

            //    }
            //    if (Program.opt == 2) //sua
            //    {
            //        //string sql = "SuaHoaDon_SanPham";
            //        //string[] para = { "@id", "@sanphamid", "@soluong", "@giaban", "@vat", "@tienloi", "@ghichu" };
            //        //object[] values = { Int32.Parse(Program.chiTietHoaDon.Id), Int32.Parse(sanphamid), Int32.Parse(tb_soluong.Text), Int32.Parse(tb_dongia.Text), Int32.Parse(tb_VAT.Text), Int32.Parse(tb_tienloi.Text), Convert.ToString(tb_ghichu.Text) };
            //        //int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //        //if (a != 0)
            //        //{
            //        //    DialogResult result2 = MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //    if (result2 == DialogResult.OK)
            //        //    {
            //        //        this.Close();
            //        //        edit();
            //        //    }
            //        //}
            //        //else
            //        //{
            //        //    MessageBox.Show("Sửa thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        //}
            //    }

            //}
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void tb_tienloi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void glue_sanpham_EditValueChanged(object sender, EventArgs e)
        {
            sanphamid = glue_nguyenvatlieu.EditValue.ToString();
        }

        private void tb_VAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        
    }
}
