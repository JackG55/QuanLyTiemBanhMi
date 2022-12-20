
namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLySanPham
{
    partial class SanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_xoasanpham = new System.Windows.Forms.Button();
            this.btn_themsanpham = new System.Windows.Forms.Button();
            this.btn_suasanpham = new System.Windows.Forms.Button();
            this.btn_themdm = new System.Windows.Forms.Button();
            this.btn_suadm = new System.Windows.Forms.Button();
            this.dgv_DSSanPham = new System.Windows.Forms.DataGridView();
            this.MaSPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_danhmucsp = new System.Windows.Forms.ComboBox();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.btn_suactkm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_DSKhuyenMai = new System.Windows.Forms.DataGridView();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themctkm = new System.Windows.Forms.Button();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSanPham)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Mục";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.label14);
            this.sidePanel1.Controls.Add(this.btn_xoasanpham);
            this.sidePanel1.Controls.Add(this.btn_themsanpham);
            this.sidePanel1.Controls.Add(this.btn_suasanpham);
            this.sidePanel1.Controls.Add(this.btn_themdm);
            this.sidePanel1.Controls.Add(this.btn_suadm);
            this.sidePanel1.Controls.Add(this.dgv_DSSanPham);
            this.sidePanel1.Controls.Add(this.cbb_danhmucsp);
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Location = new System.Drawing.Point(13, 3);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(899, 647);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(58, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(328, 34);
            this.label14.TabIndex = 54;
            this.label14.Text = "Danh Sách Sản Phẩm";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_xoasanpham
            // 
            this.btn_xoasanpham.BackColor = System.Drawing.Color.White;
            this.btn_xoasanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoasanpham.Image = global::QLTiemBanhMi.Properties.Resources.cancel_16x16;
            this.btn_xoasanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoasanpham.Location = new System.Drawing.Point(743, 597);
            this.btn_xoasanpham.Name = "btn_xoasanpham";
            this.btn_xoasanpham.Size = new System.Drawing.Size(138, 30);
            this.btn_xoasanpham.TabIndex = 39;
            this.btn_xoasanpham.Text = "Xoá Sản Phẩm";
            this.btn_xoasanpham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoasanpham.UseVisualStyleBackColor = false;
            this.btn_xoasanpham.Click += new System.EventHandler(this.btn_xoasanpham_Click);
            // 
            // btn_themsanpham
            // 
            this.btn_themsanpham.BackColor = System.Drawing.Color.White;
            this.btn_themsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themsanpham.Image = global::QLTiemBanhMi.Properties.Resources.add_16x16;
            this.btn_themsanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themsanpham.Location = new System.Drawing.Point(573, 597);
            this.btn_themsanpham.Name = "btn_themsanpham";
            this.btn_themsanpham.Size = new System.Drawing.Size(150, 31);
            this.btn_themsanpham.TabIndex = 38;
            this.btn_themsanpham.Text = "Thêm Sản Phẩm";
            this.btn_themsanpham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themsanpham.UseVisualStyleBackColor = false;
            this.btn_themsanpham.Click += new System.EventHandler(this.btn_themSanPham_Click);
            // 
            // btn_suasanpham
            // 
            this.btn_suasanpham.BackColor = System.Drawing.Color.White;
            this.btn_suasanpham.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_suasanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suasanpham.Image = global::QLTiemBanhMi.Properties.Resources.pictureshapeoutlinecolor_16x16;
            this.btn_suasanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suasanpham.Location = new System.Drawing.Point(415, 598);
            this.btn_suasanpham.Name = "btn_suasanpham";
            this.btn_suasanpham.Size = new System.Drawing.Size(135, 30);
            this.btn_suasanpham.TabIndex = 37;
            this.btn_suasanpham.Text = "Sửa Sản Phẩm";
            this.btn_suasanpham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suasanpham.UseVisualStyleBackColor = false;
            this.btn_suasanpham.Click += new System.EventHandler(this.btn_suaSanPham_Click);
            // 
            // btn_themdm
            // 
            this.btn_themdm.BackColor = System.Drawing.Color.White;
            this.btn_themdm.Image = global::QLTiemBanhMi.Properties.Resources.add_16x16;
            this.btn_themdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themdm.Location = new System.Drawing.Point(567, 44);
            this.btn_themdm.Name = "btn_themdm";
            this.btn_themdm.Size = new System.Drawing.Size(85, 31);
            this.btn_themdm.TabIndex = 11;
            this.btn_themdm.Text = "Thêm";
            this.btn_themdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themdm.UseVisualStyleBackColor = false;
            this.btn_themdm.Click += new System.EventHandler(this.btn_themdm_Click);
            // 
            // btn_suadm
            // 
            this.btn_suadm.BackColor = System.Drawing.Color.White;
            this.btn_suadm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_suadm.Image = global::QLTiemBanhMi.Properties.Resources.pictureshapeoutlinecolor_16x16;
            this.btn_suadm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suadm.Location = new System.Drawing.Point(486, 45);
            this.btn_suadm.Name = "btn_suadm";
            this.btn_suadm.Size = new System.Drawing.Size(75, 30);
            this.btn_suadm.TabIndex = 10;
            this.btn_suadm.Text = "Sửa";
            this.btn_suadm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suadm.UseVisualStyleBackColor = false;
            this.btn_suadm.Click += new System.EventHandler(this.btn_suadm_Click);
            // 
            // dgv_DSSanPham
            // 
            this.dgv_DSSanPham.AllowUserToAddRows = false;
            this.dgv_DSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSPP,
            this.TenSP,
            this.MoTa,
            this.GiaBan,
            this.TenDanhMuc,
            this.MaDM});
            this.dgv_DSSanPham.Location = new System.Drawing.Point(65, 81);
            this.dgv_DSSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSSanPham.Name = "dgv_DSSanPham";
            this.dgv_DSSanPham.RowHeadersWidth = 51;
            this.dgv_DSSanPham.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DSSanPham.RowTemplate.Height = 24;
            this.dgv_DSSanPham.Size = new System.Drawing.Size(831, 499);
            this.dgv_DSSanPham.TabIndex = 9;
            this.dgv_DSSanPham.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSSanPham_CellEnter);
            // 
            // MaSPP
            // 
            this.MaSPP.DataPropertyName = "MaSP";
            this.MaSPP.Frozen = true;
            this.MaSPP.HeaderText = "Mã Sản Phẩm";
            this.MaSPP.MinimumWidth = 6;
            this.MaSPP.Name = "MaSPP";
            this.MaSPP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSP.DefaultCellStyle = dataGridViewCellStyle1;
            this.TenSP.Frozen = true;
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 225;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTa.DefaultCellStyle = dataGridViewCellStyle2;
            this.MoTa.Frozen = true;
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 250;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.Frozen = true;
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 75;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.Frozen = true;
            this.TenDanhMuc.HeaderText = "Danh Mục";
            this.TenDanhMuc.MinimumWidth = 6;
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.Width = 125;
            // 
            // MaDM
            // 
            this.MaDM.DataPropertyName = "MaDM";
            this.MaDM.Frozen = true;
            this.MaDM.HeaderText = "MaDM";
            this.MaDM.MinimumWidth = 6;
            this.MaDM.Name = "MaDM";
            this.MaDM.Visible = false;
            this.MaDM.Width = 125;
            // 
            // cbb_danhmucsp
            // 
            this.cbb_danhmucsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_danhmucsp.FormattingEnabled = true;
            this.cbb_danhmucsp.Location = new System.Drawing.Point(166, 45);
            this.cbb_danhmucsp.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_danhmucsp.Name = "cbb_danhmucsp";
            this.cbb_danhmucsp.Size = new System.Drawing.Size(295, 30);
            this.cbb_danhmucsp.TabIndex = 8;
            this.cbb_danhmucsp.SelectedIndexChanged += new System.EventHandler(this.cbb_danhmucsp_SelectedIndexChanged);
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.btn_suactkm);
            this.sidePanel2.Controls.Add(this.label2);
            this.sidePanel2.Controls.Add(this.dgv_DSKhuyenMai);
            this.sidePanel2.Controls.Add(this.btn_themctkm);
            this.sidePanel2.Location = new System.Drawing.Point(918, 3);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(514, 588);
            this.sidePanel2.TabIndex = 3;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // btn_suactkm
            // 
            this.btn_suactkm.BackColor = System.Drawing.Color.White;
            this.btn_suactkm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_suactkm.Image = global::QLTiemBanhMi.Properties.Resources.pictureshapeoutlinecolor_16x16;
            this.btn_suactkm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suactkm.Location = new System.Drawing.Point(409, 45);
            this.btn_suactkm.Name = "btn_suactkm";
            this.btn_suactkm.Size = new System.Drawing.Size(75, 30);
            this.btn_suactkm.TabIndex = 55;
            this.btn_suactkm.Text = "Sửa";
            this.btn_suactkm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suactkm.UseVisualStyleBackColor = false;
            this.btn_suactkm.Click += new System.EventHandler(this.btn_suactkm_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 34);
            this.label2.TabIndex = 55;
            this.label2.Text = "Danh Sách Chương Trình Khuyến Mãi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_DSKhuyenMai
            // 
            this.dgv_DSKhuyenMai.AllowUserToAddRows = false;
            this.dgv_DSKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.TenKM,
            this.PhanTramGiamGia,
            this.NgayBatDau,
            this.NgayKetThuc});
            this.dgv_DSKhuyenMai.Location = new System.Drawing.Point(0, 81);
            this.dgv_DSKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSKhuyenMai.Name = "dgv_DSKhuyenMai";
            this.dgv_DSKhuyenMai.RowHeadersWidth = 51;
            this.dgv_DSKhuyenMai.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DSKhuyenMai.RowTemplate.Height = 24;
            this.dgv_DSKhuyenMai.Size = new System.Drawing.Size(511, 499);
            this.dgv_DSKhuyenMai.TabIndex = 14;
            this.dgv_DSKhuyenMai.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSKhuyenMai_CellEnter);
            // 
            // MaKM
            // 
            this.MaKM.DataPropertyName = "MaKM";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKM.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaKM.Frozen = true;
            this.MaKM.HeaderText = "Mã Khuyến Mãi";
            this.MaKM.MinimumWidth = 6;
            this.MaKM.Name = "MaKM";
            this.MaKM.Width = 50;
            // 
            // TenKM
            // 
            this.TenKM.DataPropertyName = "TenKM";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKM.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenKM.Frozen = true;
            this.TenKM.HeaderText = "Tên Khuyến Mãi";
            this.TenKM.MinimumWidth = 6;
            this.TenKM.Name = "TenKM";
            this.TenKM.Width = 150;
            // 
            // PhanTramGiamGia
            // 
            this.PhanTramGiamGia.DataPropertyName = "PhanTramGiamGia";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhanTramGiamGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.PhanTramGiamGia.Frozen = true;
            this.PhanTramGiamGia.HeaderText = "% Giảm Giá";
            this.PhanTramGiamGia.MinimumWidth = 6;
            this.PhanTramGiamGia.Name = "PhanTramGiamGia";
            this.PhanTramGiamGia.Width = 75;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayBatDau.DefaultCellStyle = dataGridViewCellStyle6;
            this.NgayBatDau.Frozen = true;
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Width = 125;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.Frozen = true;
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Width = 125;
            // 
            // btn_themctkm
            // 
            this.btn_themctkm.BackColor = System.Drawing.Color.White;
            this.btn_themctkm.Image = global::QLTiemBanhMi.Properties.Resources.add_16x16;
            this.btn_themctkm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themctkm.Location = new System.Drawing.Point(318, 46);
            this.btn_themctkm.Name = "btn_themctkm";
            this.btn_themctkm.Size = new System.Drawing.Size(85, 30);
            this.btn_themctkm.TabIndex = 15;
            this.btn_themctkm.Text = "Thêm";
            this.btn_themctkm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themctkm.UseVisualStyleBackColor = false;
            this.btn_themctkm.Click += new System.EventHandler(this.btn_themctkm_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1436, 765);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SanPham";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSanPham)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSKhuyenMai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.Button btn_themdm;
        private System.Windows.Forms.Button btn_suadm;
        private System.Windows.Forms.DataGridView dgv_DSSanPham;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private System.Windows.Forms.Button btn_xoasanpham;
        private System.Windows.Forms.Button btn_themsanpham;
        private System.Windows.Forms.Button btn_suasanpham;
        private System.Windows.Forms.DataGridView dgv_DSKhuyenMai;
        private System.Windows.Forms.Button btn_themctkm;
        public System.Windows.Forms.ComboBox cbb_danhmucsp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.Button btn_suactkm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDM;
    }
}