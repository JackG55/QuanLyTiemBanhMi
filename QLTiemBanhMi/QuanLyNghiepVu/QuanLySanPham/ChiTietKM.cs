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
    public partial class ChiTietKM : Form
    {
        public ChiTietKM()
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

        public void setThongTinVaoFormDeSua(List<string> list_donvi)
        {
            //tb_id.Text = Program.sanpham.Id;
            //tb_tensanpham.Text = Program.sanpham.Tensanpham;
            //tb_quycach.Text = Program.sanpham.Quycach;
            //tb_soluongton.Text = Program.sanpham.Soluongton;
          
            //tb_nguonnhap.Text = Program.sanpham.Nguonnhap;
            //tb_ghichu.Text = Program.sanpham.Ghichu;

            //HienThongTinLenEditValue(list_donvi, Program.sanpham.Donviid.ToString());
        }

        private void HienThongTinLenEditValue(List<string> list_donvi, string donviID)
        {
            int index = list_donvi.BinarySearch(donviID);
          //  glue_donvi.EditValue = glue_donvi.Properties.GetKeyValue(index);
        }

        //public bool KiemTra()
        //{
        //    if (tb_id.Text == "" || tb_tensanpham.Text == "" ||
        //    tb_quycach.Text == "" ||
        //    tb_nguonnhap.Text == "" || tb_soluongton.Text == ""|| glue_donvi.EditValue.ToString() == "")
        //    {
        //        DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    return true;
        //}

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            //if (!KiemTra())
            //    return;
            //else
            //{
            //    if (Program.opt == 1) //them
            //    {
            //        string sql = "Them_SP";
            //        string[] para = { "@tensanpham", "@quycach", "@donviID", "@soluongton", "@nguonnhap", "@ghichu" };
            //        object[] values = { tb_tensanpham.Text, Convert.ToString(tb_quycach.Text), Int32.Parse(glue_donvi.EditValue.ToString()), Int32.Parse(tb_soluongton.Text), Convert.ToString(tb_nguonnhap.Text), Convert.ToString(tb_ghichu.Text) };
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
            //        string sql = "Sua_SP";
            //        string[] para = { "@id", "@tensanpham", "@quycach", "@donviID", "@soluongton", "@nguonnhap", "@ghichu" };
            //        object[] values = { Int32.Parse(tb_id.Text) ,tb_tensanpham.Text, tb_quycach.Text, Int32.Parse(glue_donvi.EditValue.ToString()), Int32.Parse(tb_soluongton.Text), tb_nguonnhap.Text, Convert.ToString(tb_ghichu.Text) };
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

        private void ChiTietSP_Load(object sender, EventArgs e)
        {

            //load danh sach loai nhan vien
            //List<string> list_donvi = Program.Quanlysanphamsql.LayDS_DonVi(glue_donvi);
            //if (Program.opt == 1) //them
            //{
            //    tb_id.Text = "";
            //    tb_tensanpham.Text = "";
            //    tb_quycach.Text = "";
            //    tb_soluongton.Text = "";
               
            //    tb_nguonnhap.Text = "";
            //    tb_ghichu.Text = "";

            //    //mã tự tạo
            //    tb_id.ReadOnly = true;


            //    //sql lấy mã
            //    tb_id.Text = Program.Quanlysanphamsql.TaoMaSanPham().ToString();
            //}
            //if (Program.opt == 2) // sua
            //{
            //    tb_id.ReadOnly = true;
            //    setThongTinVaoFormDeSua(list_donvi);
            //}
        }

        private void glue_donvi_EditValueChanged(object sender, EventArgs e)
        {
            //gan gia tri
           // Program.sanpham.Donviid = glue_donvi.EditValue.ToString();
        }
    }
}
