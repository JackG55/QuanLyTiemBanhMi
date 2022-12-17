using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLTiemBanhMi.Connector;

namespace QLTiemBanhMi.QuanTriHeThong
{
    public partial class DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtReNewPass.Text == "")
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Lỗi");
            else if (txtReNewPass.Text != txtNewPass.Text)
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng!", "Lỗi");
            else if (Program.user.Matkhau != txtOldPass.Text)
            {
                XtraMessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi");
            }
            else
            {
                string sql = "DoiMatKhau";
                string[] para = { "@tendangnhap", "@matkhau"};
                object[] values = { Program.user.Tendangnhap, txtNewPass.Text};
                int a = connection.Excute_Sql(sql, CommandType.StoredProcedure, para, values);
                if (a != 0)
                {
                    XtraMessageBox.Show("Đổi mật khẩu thành công!");
                    Program.user.Matkhau = txtNewPass.Text;
                }   
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}