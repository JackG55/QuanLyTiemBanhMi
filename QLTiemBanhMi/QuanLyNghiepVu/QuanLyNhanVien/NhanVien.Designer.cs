
namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyNhanVien
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NgayLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xoanhanvien = new System.Windows.Forms.Button();
            this.btn_themnhanvien = new System.Windows.Forms.Button();
            this.dataGridViewDSNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_suanhanvien = new System.Windows.Forms.Button();
            this.cbbDSLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.button1);
            this.sidePanel1.Controls.Add(this.label2);
            this.sidePanel1.Controls.Add(this.dataGridView1);
            this.sidePanel1.Controls.Add(this.label3);
            this.sidePanel1.Controls.Add(this.btn_xoanhanvien);
            this.sidePanel1.Controls.Add(this.btn_themnhanvien);
            this.sidePanel1.Controls.Add(this.dataGridViewDSNhanVien);
            this.sidePanel1.Controls.Add(this.btn_suanhanvien);
            this.sidePanel1.Controls.Add(this.cbbDSLoaiNhanVien);
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Location = new System.Drawing.Point(79, 2);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1354, 645);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QLTiemBanhMi.Properties.Resources.add_16x16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1242, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 59;
            this.button1.Text = "Thêm Ca";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(946, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 34);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ca Làm ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLamViec,
            this.MaCaLam,
            this.BatDau,
            this.KetThuc});
            this.dataGridView1.Location = new System.Drawing.Point(946, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 570);
            this.dataGridView1.TabIndex = 57;
            // 
            // NgayLamViec
            // 
            this.NgayLamViec.DataPropertyName = "NgayLamViec";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLamViec.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayLamViec.Frozen = true;
            this.NgayLamViec.HeaderText = "Ngày Làm";
            this.NgayLamViec.MinimumWidth = 6;
            this.NgayLamViec.Name = "NgayLamViec";
            this.NgayLamViec.Width = 125;
            // 
            // MaCaLam
            // 
            this.MaCaLam.DataPropertyName = "MaCaLam";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaCaLam.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaCaLam.Frozen = true;
            this.MaCaLam.HeaderText = "Mã Ca Làm";
            this.MaCaLam.MinimumWidth = 6;
            this.MaCaLam.Name = "MaCaLam";
            this.MaCaLam.Visible = false;
            this.MaCaLam.Width = 50;
            // 
            // BatDau
            // 
            this.BatDau.DataPropertyName = "BatDau";
            this.BatDau.Frozen = true;
            this.BatDau.HeaderText = "Bắt đầu";
            this.BatDau.MinimumWidth = 6;
            this.BatDau.Name = "BatDau";
            this.BatDau.Width = 125;
            // 
            // KetThuc
            // 
            this.KetThuc.DataPropertyName = "KetThuc";
            this.KetThuc.Frozen = true;
            this.KetThuc.HeaderText = "Kết Thúc";
            this.KetThuc.MinimumWidth = 6;
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.Width = 125;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 34);
            this.label3.TabIndex = 56;
            this.label3.Text = "Danh Sách Nhân Viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_xoanhanvien
            // 
            this.btn_xoanhanvien.BackColor = System.Drawing.Color.White;
            this.btn_xoanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoanhanvien.Image = global::QLTiemBanhMi.Properties.Resources.cancel_16x16;
            this.btn_xoanhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoanhanvien.Location = new System.Drawing.Point(809, 43);
            this.btn_xoanhanvien.Name = "btn_xoanhanvien";
            this.btn_xoanhanvien.Size = new System.Drawing.Size(131, 30);
            this.btn_xoanhanvien.TabIndex = 22;
            this.btn_xoanhanvien.Text = "Xoá Nhân Viên";
            this.btn_xoanhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoanhanvien.UseVisualStyleBackColor = false;
            this.btn_xoanhanvien.Click += new System.EventHandler(this.btn_xxoanhanvien_Click);
            // 
            // btn_themnhanvien
            // 
            this.btn_themnhanvien.BackColor = System.Drawing.Color.White;
            this.btn_themnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themnhanvien.Image = global::QLTiemBanhMi.Properties.Resources.add_16x16;
            this.btn_themnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themnhanvien.Location = new System.Drawing.Point(524, 42);
            this.btn_themnhanvien.Name = "btn_themnhanvien";
            this.btn_themnhanvien.Size = new System.Drawing.Size(146, 31);
            this.btn_themnhanvien.TabIndex = 21;
            this.btn_themnhanvien.Text = "Thêm Nhân Viên";
            this.btn_themnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themnhanvien.UseVisualStyleBackColor = false;
            this.btn_themnhanvien.Click += new System.EventHandler(this.btn_themnhanvien_Click);
            // 
            // dataGridViewDSNhanVien
            // 
            this.dataGridViewDSNhanVien.AllowUserToAddRows = false;
            this.dataGridViewDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.UserName,
            this.GioiTinh,
            this.NamSinh,
            this.DiaChi,
            this.ChucVu});
            this.dataGridViewDSNhanVien.Location = new System.Drawing.Point(0, 73);
            this.dataGridViewDSNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDSNhanVien.Name = "dataGridViewDSNhanVien";
            this.dataGridViewDSNhanVien.RowHeadersWidth = 51;
            this.dataGridViewDSNhanVien.RowTemplate.Height = 24;
            this.dataGridViewDSNhanVien.Size = new System.Drawing.Size(940, 570);
            this.dataGridViewDSNhanVien.TabIndex = 9;
            this.dataGridViewDSNhanVien.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSNhanVien_CellEnter);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaNV.Frozen = true;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 75;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenNV.Frozen = true;
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 200;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.Frozen = true;
            this.UserName.HeaderText = "Tên Đăng Nhập";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.Frozen = true;
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 50;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamSinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.NamSinh.Frozen = true;
            this.NamSinh.HeaderText = "Ngày Sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Width = 120;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle6;
            this.DiaChi.Frozen = true;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.Frozen = true;
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 150;
            // 
            // btn_suanhanvien
            // 
            this.btn_suanhanvien.BackColor = System.Drawing.Color.White;
            this.btn_suanhanvien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_suanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suanhanvien.Image = global::QLTiemBanhMi.Properties.Resources.pictureshapeoutlinecolor_16x16;
            this.btn_suanhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suanhanvien.Location = new System.Drawing.Point(676, 43);
            this.btn_suanhanvien.Name = "btn_suanhanvien";
            this.btn_suanhanvien.Size = new System.Drawing.Size(127, 30);
            this.btn_suanhanvien.TabIndex = 20;
            this.btn_suanhanvien.Text = "Sửa Nhân Viên";
            this.btn_suanhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suanhanvien.UseVisualStyleBackColor = false;
            this.btn_suanhanvien.Click += new System.EventHandler(this.btn_suanhanvien_Click);
            // 
            // cbbDSLoaiNhanVien
            // 
            this.cbbDSLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDSLoaiNhanVien.FormattingEnabled = true;
            this.cbbDSLoaiNhanVien.Location = new System.Drawing.Point(94, 43);
            this.cbbDSLoaiNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDSLoaiNhanVien.Name = "cbbDSLoaiNhanVien";
            this.cbbDSLoaiNhanVien.Size = new System.Drawing.Size(308, 30);
            this.cbbDSLoaiNhanVien.TabIndex = 8;
            this.cbbDSLoaiNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbDSLoaiNhanVien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức vụ";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1566, 765);
            this.Controls.Add(this.sidePanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVien";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.DataGridView dataGridViewDSNhanVien;
        private System.Windows.Forms.ComboBox cbbDSLoaiNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_xoanhanvien;
        private System.Windows.Forms.Button btn_themnhanvien;
        private System.Windows.Forms.Button btn_suanhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCaLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.Button button1;
    }
}