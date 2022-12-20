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
    public partial class DanhMucSP : Form
    {
        private string magv;
        public DanhMucSP()
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
            //tb_madm.Text = Program.chiTietDonVi.Id;
            //tb_tendm.Text = Program.chiTietDonVi.Tendonvi;
           
        }

        private void HienThongTinLenEditValue(GridLookUpEdit grid, List<string> list, string ma)
        {
            //int index = list.BinarySearch(ma);
            //grid.EditValue = grid.Properties.GetKeyValue(index);
        }

        //public bool KiemTra()
        //{
        //    if (tb_madm.Text == "" || tb_tendm.Text == "")
        //    {
        //        DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    List<string> list_tenloaidv = Program.Quanlysanphamsql.LayDSTenLoaiDonVi();
        //    if (Program.opt == 1)
        //    {
        //        if (list_tenloaidv.Contains(tb_tendm.Text))
        //        {
        //            DialogResult result = MessageBox.Show("Tên loại đơn vị đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }

        //    }
        //    if (Program.opt == 2)
        //    {

        //        list_tenloaidv.Remove(Program.chiTietDonVi.Tendonvi);
        //        if (list_tenloaidv.Contains(tb_tendm.Text))
        //        {
        //            DialogResult result = MessageBox.Show("Tên loại đơn vị đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //        string sql = "Them_DonVi";
            //        string[] para = { "@tendonvi", "@ghichu" };
            //        object[] values = { tb_tendm.Text, Convert.ToString(tb_ghichu.Text) };
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
            //        string sql = "Sua_DonVi";
            //        string[] para = { "@id", "@tendonvi", "@ghichu" };
            //        object[] values = { Int32.Parse(tb_madm.Text), tb_tendm.Text, Convert.ToString(tb_ghichu.Text) };
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

        private void gluegiaovien_EditValueChanged(object sender, EventArgs e)
        {
            //gan gia tri
            //magv = gluegiaovien.EditValue.ToString();

            ////thay doi text box
            //tbmagv.Text = magv;
        }


        private void ChiTietDonVi_Load(object sender, EventArgs e)
        {

            if (Program.opt == 1) //them
            {
                tb_madm.Text = "";
                tb_tendm.Text = "";
                

                tb_madm.ReadOnly = true;

                //tb_madm.Text = Program.Quanlysanphamsql.TaoMaDonVi().ToString();
            }
            if (Program.opt == 2) // sua
            {
                tb_madm.ReadOnly = true;
                setThongTinVaoFormDeSua();
            }
        }
    }
}
