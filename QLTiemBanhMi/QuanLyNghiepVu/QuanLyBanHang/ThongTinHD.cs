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
        private string makh = "";
        private string makm = "";
        private string matt = "";
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
            dgv_DSCTHD.Columns["SL"].ReadOnly = false;
        }
        public bool Kiemtra_HoaDon()
        {
            if (makh== "" || int.Parse(tb_soluong.Text) == 0 || matt== "")
            {
                MessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!Kiemtra_HoaDon())
                return;
            else
            {
                if (Program.opt == 1) //them
                {
                    string sql = "";
                    string[] para;
                    object[] values;
                    sql = "Them_HoaDon";
                    para = new string[] { "@MaHD","@MaNV","@NgayTao","@MaKH","@MaThanhToan","@TongTien"};
                    values = new object[] {Convert.ToString(tb_mahd.Text), Program.user.Manv, Convert.ToDateTime(tb_ngaylap.Text), Int32.Parse(makh),Int32.Parse(matt),Int32.Parse(tb_tongtien.Text)};
                    int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
                    int dem_them_cthd = 0;
                    for (int i = 0; i < dgv_DSCTHD.Rows.Count; i++)
                    {
                        int masp_ct,dongia,sl;
                        int.TryParse(dgv_DSCTHD.Rows[i].Cells["MaSP"].Value.ToString(), out masp_ct);
                        int.TryParse(dgv_DSCTHD.Rows[i].Cells["DonGia"].Value.ToString(), out dongia);
                        int.TryParse(dgv_DSCTHD.Rows[i].Cells["SL"].Value.ToString(), out sl);
                        sql = "Them_CTHD";
                        para = new string[] { "@MaHD", "@MaSP", "@SL", "@DonGia" };
                        values = new object[] { Convert.ToString(tb_mahd.Text), masp_ct,sl,dongia};
                        int b = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
                        if(b!=0)
                        {
                            dem_them_cthd++;
                        }    
                    }
                    
                    if(makm != "")
                    {
                        sql = "Them_CTKM";
                        para = new string[] { "@MaHD", "@MaKM", "@MaKH" };
                        values = new object[] { Convert.ToString(tb_mahd.Text), int.Parse(makm), int.Parse(makh) };
                        int b = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
                        if (a != 0 && dem_them_cthd == dgv_DSCTHD.Rows.Count && b!=0)
                        {
                            DialogResult result2 = MessageBox.Show("Tạo hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    else
                    {
                        if (a != 0 && dem_them_cthd == dgv_DSCTHD.Rows.Count)
                        {
                            DialogResult result2 = MessageBox.Show("Tạo hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void glue_khachhang_EditValueChanged(object sender, EventArgs e)
        {
            makh = glue_khachhang.EditValue.ToString();
            string sql = @"SELECT dbo.ChuongTrinhKhuyenMai.*
                            FROM dbo.ChuongTrinhKhuyenMai, dbo.ChiTietKhuyenMai,dbo.KhachHang
                            WHERE ChuongTrinhKhuyenMai.MaKM=ChuongTrinhKhuyenMai.MaKM AND ChiTietKhuyenMai.MAKH=KhachHang.MaKH
                            AND ChuongTrinhKhuyenMai.MaKM NOT IN (SELECT DISTINCT MaKM FROM dbo.ChiTietKhuyenMai WHERE MAKH = '" + makh + "') " +
                            " AND NgayBatDau <= GETDATE() AND GETDATE()<=NgayKetThuc";
            List<string> list_km_id = Program.FillData.LayDS_Len_GridLookUpEdit_DK(glue_km, sql, "PhanTramGiamGia", "MaKM");

        }

        private void glue_km_EditValueChanged(object sender, EventArgs e)
        {
            if(makh=="")
            {
                MessageBox.Show("Bạn phải chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                makm = glue_km.EditValue.ToString();
                object displayValue = glue_km.Properties.GetDisplayValueByKeyValue(glue_km.EditValue);
                int phantram = Convert.ToInt32(displayValue);
                int tamtinh = int.Parse(tb_tamtinh.Text);
                tb_tongtien.Text = (tamtinh - phantram * tamtinh / 100).ToString();
            }    
           
        }

        private void glue_hinhthuctt_EditValueChanged(object sender, EventArgs e)
        {
            matt = glue_hinhthuctt.EditValue.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(rowindex==-1)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            dgv_DSCTHD.Rows.RemoveAt(rowindex);

        }

      
         private void chiTietHD_UpdateEventHandler1(object sender, ChiTietHD.UpdateEventArgs args)
         {
            var index = dgv_DSCTHD.Rows.Add();
            dgv_DSCTHD.Rows[index].Cells["MaSP"].Value = Program.chiTietHoaDon.Masp;
            dgv_DSCTHD.Rows[index].Cells["TenSP"].Value = Program.chiTietHoaDon.Tensp;
            dgv_DSCTHD.Rows[index].Cells["DonGia"].Value = Program.chiTietHoaDon.Dongia.ToString();
            dgv_DSCTHD.Rows[index].Cells["SL"].Value = Program.chiTietHoaDon.Soluong.ToString();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            ChiTietHD chiTietHD = new ChiTietHD(this);
            chiTietHD.UpdateEventHandler += chiTietHD_UpdateEventHandler1;
            chiTietHD.ShowDialog();
        }

        private void dgv_DSCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tb_soluong.Text = dgv_DSCTHD.Rows.Cast<DataGridViewRow>()
               .Sum(t => Convert.ToInt32(t.Cells["SL"].Value)).ToString();
            int sum = 0;
            for (int i = 0; i < dgv_DSCTHD.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgv_DSCTHD.Rows[i].Cells["DonGia"].Value) * Convert.ToInt32(dgv_DSCTHD.Rows[i].Cells["SL"].Value);
            }
            tb_tamtinh.Text = sum.ToString();
            if (dgv_DSCTHD.Columns[e.ColumnIndex].Name == "SL")
            {
                tb_soluong.Text = dgv_DSCTHD.Rows.Cast<DataGridViewRow>()
              .Sum(t => Convert.ToInt32(t.Cells["SL"].Value)).ToString();
                sum = 0;
                for (int i = 0; i < dgv_DSCTHD.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dgv_DSCTHD.Rows[i].Cells["DonGia"].Value) * Convert.ToInt32(dgv_DSCTHD.Rows[i].Cells["SL"].Value);
                }
                tb_tamtinh.Text = sum.ToString();
            }

            //if (dgv_DSCTHD.Columns[e.ColumnIndex].Name == "DonGia")
            //{


            //}
        }
        int rowindex = -1;
        private void dgv_DSCTHD_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = dgv_DSCTHD.CurrentCell.RowIndex;
        }

        private void dgv_DSCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
