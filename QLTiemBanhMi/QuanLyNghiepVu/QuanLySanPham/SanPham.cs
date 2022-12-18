using QLTiemBanhMi.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTiemBanhMi.Object;

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLySanPham
{
    public partial class SanPham : Form
    {
        List<string> tenquyen_sanpham = new List<string>() { "ThemSanPham", "DanhSachSanPham", "QuanLyGiaSanPham", "QuanLyDonVi", "SuaSanPham", "XoaSanPham" };
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            //tim kiem cac quyen ma nguoi dung duoc phep
            //foreach (QuyenThaoTac q in Program.PhanQuyenList)
            //{
            //    if (q.Tenquyen == tenquyen_sanpham[0])
            //    {
                    
            //        btn_themsanpham.Visible = true;
                    

            //    }
            //    if (q.Tenquyen == tenquyen_sanpham[1])
            //    {
                    

            //    }
            //    if (q.Tenquyen == tenquyen_sanpham[2])
            //    {
            //        btn_themgiaban.Visible = true;
            //        btn_xoagiaban.Visible = true;

            //    }
            //    if (q.Tenquyen == tenquyen_sanpham[3])
            //    {
            //        btnSuaDonVi.Visible = true;
            //        btnThemDonVi.Visible = true;
            //        btnXoaDonVi.Visible = true;

            //    }
            //    if (q.Tenquyen == tenquyen_sanpham[4])
            //    {
            //        btn_suasanpham.Visible = true;

            //    }
            //    if (q.Tenquyen == tenquyen_sanpham[5])
            //    {
            //        btn_xoasanpham.Visible = true;

            //    }

            //}

          
            //Program.Quanlysanphamsql.LayDSSanPham(dataGridViewDSSanPham);
            //Program.Quanlysanphamsql.LayDSDonVi(cbbDSDonVi);
        }

        private void dataGridViewDSSanPham_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //tb_id.Text = dataGridViewDSSanPham.CurrentRow.Cells["ID"].Value.ToString();
            //tb_tensanpham.Text = dataGridViewDSSanPham.CurrentRow.Cells["TenSanPham"].Value.ToString();
            //tb_quycach.Text = dataGridViewDSSanPham.CurrentRow.Cells["QuyCach"].Value.ToString();
            //tb_donviid.Text = dataGridViewDSSanPham.CurrentRow.Cells["DonViID"].Value.ToString();
            //tb_soluongton.Text = dataGridViewDSSanPham.CurrentRow.Cells["SoLuongTon"].Value.ToString();
            //tb_ngaytao.Text = dataGridViewDSSanPham.CurrentRow.Cells["NgayTao"].Value.ToString();
            //tb_nguonnhap.Text = dataGridViewDSSanPham.CurrentRow.Cells["NguonNhap"].Value.ToString();
            //tb_ghichu.Text = dataGridViewDSSanPham.CurrentRow.Cells["GhiChu"].Value.ToString();


            ////tạo object để truyền qua form Chi tiết
            //Program.sanpham = new Object.SanPham(tb_id.Text, tb_tensanpham.Text, tb_quycach.Text, tb_donviid.Text, tb_soluongton.Text, 
            //    Convert.ToDateTime(tb_ngaytao.Text), tb_ghichu.Text, tb_nguonnhap.Text);

            ////load nhap san pham
            //Program.Quanlysanphamsql.LayDSGiaBanSP(dtgv_DSGiaBanSP, tb_id.Text);
        }

        private void chiTietSP_UpdateEventHandler1(object sender, ChiTietSP.UpdateEventArgs args)
        {

            Program.Quanlysanphamsql.LayDSSanPham(dataGridViewDSSanPham);

        }

        private void btn_suaSanPham_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ChiTietSP chiTietSP = new ChiTietSP(this);
            chiTietSP.UpdateEventHandler += chiTietSP_UpdateEventHandler1;
            chiTietSP.ShowDialog();
        }

        private void btn_themSanPham_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ChiTietSP chiTietSP = new ChiTietSP(this);
           
            chiTietSP.UpdateEventHandler += chiTietSP_UpdateEventHandler1;
            chiTietSP.ShowDialog();
        }
        private void btn_xoasanpham_Click(object sender, EventArgs e)
        {
            //string sql = "Xoa_SP";
            //string[] para = { "@id" };
            //object[] values = { Int32.Parse(tb_id.Text) };
            //int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //if (a != 0)
            //{
            //    DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    if (result2 == DialogResult.OK)
            //    {
            //        Program.Quanlysanphamsql.LayDSSanPham(dataGridViewDSSanPham);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }



        private void cbbDSDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Program.Quanlysanphamsql.LayDSSanPham(dataGridViewDSSanPham, cbbDSDonVi.SelectedValue.ToString());

            //if(cbbDSDonVi.SelectedValue.ToString() == "0")
            //{
            //    btnSuaDonVi.Enabled = false;
            //    btnXoaDonVi.Enabled = false;
            //}    
            //else
            //{
            //    btnSuaDonVi.Enabled = true;
            //    btnXoaDonVi.Enabled = true;
            //    //load danh sach don vi
            //    DataTable list_donvi = Program.Quanlysanphamsql.LayDS_DonVi(cbbDSDonVi.SelectedValue.ToString());

            //    //tạo 1 Object Don Vi de luu gia tri
            //    Program.chiTietDonVi = new Object.DonVi(list_donvi.Rows[0]["ID"].ToString(), list_donvi.Rows[0]["TenDonVi"].ToString(), list_donvi.Rows[0]["Ghichu"].ToString());
            //}    
           
        }
        private void chiTietDV_UpdateEventHandler1(object sender, DanhMucSP.UpdateEventArgs args)
        {

            Program.Quanlysanphamsql.LayDSDonVi(cbbDSDonVi);

        }
        private void btnSuaDonVi_Click(object sender, EventArgs e)
        {
            //Program.opt = 2;
            //DanhMucSP chiTietDonVi = new ChiTietDonVi(this);
            //chiTietDonVi.UpdateEventHandler += chiTietDV_UpdateEventHandler1;
            //chiTietDonVi.ShowDialog();
        }

        private void btnThemDonVi_Click(object sender, EventArgs e)
        {
            //Program.opt = 1;
            //DanhMucSP chiTietDonVi = new ChiTietDonVi(this);
           
            //chiTietDonVi.UpdateEventHandler += chiTietDV_UpdateEventHandler1;
            //chiTietDonVi.ShowDialog();
        }

       
        private void btnXoaDonVi_Click(object sender, EventArgs e)
        {
            string sql = "Xoa_DonVi";
            string[] para = { "@id" };
            object[] values = { Int32.Parse(cbbDSDonVi.SelectedValue.ToString()) };
            int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            if (a != 0)
            {
                DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    
                    Program.Quanlysanphamsql.LayDSDonVi(cbbDSDonVi);
                    //edit();
                }
            }
            else
            {
                MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void giabanSanPham_UpdateEventHandler1(object sender, GiaBanSanPham.UpdateEventArgs args)
        //{

        //    Program.Quanlysanphamsql.LayDSGiaBanSP(dtgv_DSGiaBanSP, tb_id.Text);

        //}
        //private void btn_themgiaban_Click(object sender, EventArgs e)
        //{
        //    Program.opt = 1;
        //    GiaBanSanPham giabanSanPham = new GiaBanSanPham(this);
          
        //    giabanSanPham.UpdateEventHandler += giabanSanPham_UpdateEventHandler1;
        //    giabanSanPham.ShowDialog();
        //}

        private void btn_xoagiaban_Click(object sender, EventArgs e)
        {
            //string sql = "Xoa_GiaBanSanPham";
            //string[] para = { "@id" };
            //object[] values = { Int32.Parse(dtgv_DSGiaBanSP.CurrentRow.Cells["IDD"].Value.ToString()) };
            //int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
            //if (a != 0)
            //{
            //    DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    if (result2 == DialogResult.OK)
            //    {
            //        Program.Quanlysanphamsql.LayDSGiaBanSP(dtgv_DSGiaBanSP, tb_id.Text);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Xoá thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
