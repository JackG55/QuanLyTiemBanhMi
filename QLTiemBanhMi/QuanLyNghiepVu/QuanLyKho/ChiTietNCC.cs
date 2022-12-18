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
    public partial class ChiTietNCC : Form
    {
        public ChiTietNCC()
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
            //tb_mancc.Text = Program.chiTietLoaiNV.Id;
            //tb_tenncc.Text = Program.chiTietLoaiNV.Tenloai ;
            //tb_diachi.Text = Program.chiTietLoaiNV.Ghichu;

            //HienThongTinLenEditValue(gluegiaovien, list_magv, Quanlysv.ma_gv);
        }
       
        //public bool KiemTra()
        //{
        //    if (tb_mancc.Text == "" || tb_tenncc.Text == "")
        //    {
        //        DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    List<string> list_tenloainv = Program.Quanlynhanviensql.LayDSTenLoaiNV();
        //    if (Program.opt == 1)
        //    {
        //        if (list_tenloainv.Contains(tb_tenncc.Text))
        //        {
        //            DialogResult result = MessageBox.Show("Tên loại nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
     
        //    }
        //    if (Program.opt == 2)
        //    {

        //        list_tenloainv.Remove(Program.chiTietLoaiNV.Tenloai);
        //        if (list_tenloainv.Contains(tb_tenncc.Text))
        //        {
        //            DialogResult result = MessageBox.Show("Tên loại nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
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
            //        string sql = "Them_Loai_NV";
            //        string[] para = { "@tenloai", "@ghichu" };
            //        object[] values = { tb_tenncc.Text, Convert.ToString(tb_diachi.Text) };
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
            //        string sql = "Sua_Loai_NV";
            //        string[] para = {"@id", "@tenloai", "@ghichu" };
            //        object[] values = { Int32.Parse(tb_mancc.Text), tb_tenncc.Text, Convert.ToString(tb_diachi.Text) };
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

        private void ChiTietLoaiNV_Load(object sender, EventArgs e)
        {

            if (Program.opt == 1) //them
            {
               
                tb_tenncc.Text = "";
                tb_diachi.Text = "";
               
                tb_mancc.ReadOnly = true;

                tb_mancc.Text = Program.Quanlynhanviensql.TaoMaLoaiNhanVien().ToString();
            }
            if (Program.opt == 2) // sua
            {
                tb_mancc.ReadOnly = true;
                setThongTinVaoFormDeSua();
            }
        }

    }
}
