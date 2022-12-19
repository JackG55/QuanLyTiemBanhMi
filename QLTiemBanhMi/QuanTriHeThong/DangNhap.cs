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
using System.Data.SqlClient;
using QLTiemBanhMi.Object;


namespace QLTiemBanhMi.QuanTriHeThong
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        //User userLogin;
       /// internal User UserLogin { get => userLogin; set => userLogin = value; }
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnOK_MouseMove(object sender, MouseEventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.ForestGreen;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.Peru;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.Peru;
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.ForestGreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
            else
            {

                if (CheckLogin(txtUser.Text, txtPass.Text) == 1)
                {
                    if (checkEditNhoMatKhau.Checked == true)
                    {
                        Properties.Settings.Default.UserName = txtUser.Text;
                        Properties.Settings.Default.Password = txtPass.Text;
                        Properties.Settings.Default.Save();
                    }
                  
                    this.Hide();
                    
                    QuanLyChung quanLyChung = new QuanLyChung();
                    quanLyChung.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập sai!", "Lỗi");
                }

            }
        }



        int CheckLogin(string _name, string _pass)
        {
            int check = 0;
            List<NhanVien> list_nv = new List<NhanVien>();

            list_nv = Program.FillData.LayDSNhanVien();

            foreach (var value in list_nv)
            {

                if (value.Username.ToLower() == _name.ToLower() && _pass.ToLower() == value.Pass.ToLower())
                {
                    check = 1;
                    Program.user.Username = value.Username;
                    Program.user.Pass = value.Pass;
                    Program.user.Manv = value.Manv;
                    Program.user.Tennv = value.Tennv;
                    Program.user.Chucvu = value.Chucvu;
                    break;
                }
            }
            
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUser.Text = Properties.Settings.Default.UserName;
                txtPass.Text = Properties.Settings.Default.Password;
            }
        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHienMatKhau.Checked == true)

                txtPass.Properties.UseSystemPasswordChar = false;
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;

            }
        }


        
    }
}