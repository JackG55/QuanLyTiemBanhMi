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

namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyHoaDon
{
    public partial class XemThanhToanHD : Form
    {

        public XemThanhToanHD()
        {
            InitializeComponent();
        }
     
        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            tb_hoadonid.Text = Program.hoaDon.Id;
            Program.Quanlyhoadonsql.LayDSChiTietThanhToanHoaDon(dtgvDSThanhToanHD, tb_hoadonid.Text);

        }

       
    }
}
