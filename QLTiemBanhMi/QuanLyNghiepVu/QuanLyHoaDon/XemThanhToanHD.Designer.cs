
namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyHoaDon
{
    partial class XemThanhToanHD
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
            this.dtgvDSThanhToanHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_hoadonid = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToanTiepTheo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSThanhToanHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSThanhToanHD
            // 
            this.dtgvDSThanhToanHD.AllowUserToAddRows = false;
            this.dtgvDSThanhToanHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSThanhToanHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TienThanhToan,
            this.NgayThanhToan,
            this.NgayThanhToanTiepTheo,
            this.GhiChu});
            this.dtgvDSThanhToanHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDSThanhToanHD.Location = new System.Drawing.Point(0, 61);
            this.dtgvDSThanhToanHD.Name = "dtgvDSThanhToanHD";
            this.dtgvDSThanhToanHD.RowHeadersWidth = 51;
            this.dtgvDSThanhToanHD.RowTemplate.Height = 24;
            this.dtgvDSThanhToanHD.Size = new System.Drawing.Size(844, 288);
            this.dtgvDSThanhToanHD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoá Đơn";
            // 
            // tb_hoadonid
            // 
            this.tb_hoadonid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hoadonid.Location = new System.Drawing.Point(107, 19);
            this.tb_hoadonid.Name = "tb_hoadonid";
            this.tb_hoadonid.ReadOnly = true;
            this.tb_hoadonid.Size = new System.Drawing.Size(119, 30);
            this.tb_hoadonid.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // TienThanhToan
            // 
            this.TienThanhToan.DataPropertyName = "TienThanhToan";
            this.TienThanhToan.HeaderText = "Tiền Thanh Toán";
            this.TienThanhToan.MinimumWidth = 6;
            this.TienThanhToan.Name = "TienThanhToan";
            this.TienThanhToan.Width = 125;
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.DataPropertyName = "NgayThanhToan";
            this.NgayThanhToan.HeaderText = "Ngày Thanh Toán";
            this.NgayThanhToan.MinimumWidth = 6;
            this.NgayThanhToan.Name = "NgayThanhToan";
            this.NgayThanhToan.Width = 150;
            // 
            // NgayThanhToanTiepTheo
            // 
            this.NgayThanhToanTiepTheo.DataPropertyName = "NgayThanhToanTiepTheo";
            this.NgayThanhToanTiepTheo.HeaderText = "Ngày Thanh Toán Tiếp Theo";
            this.NgayThanhToanTiepTheo.MinimumWidth = 6;
            this.NgayThanhToanTiepTheo.Name = "NgayThanhToanTiepTheo";
            this.NgayThanhToanTiepTheo.Width = 150;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // XemThanhToanHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 349);
            this.Controls.Add(this.tb_hoadonid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDSThanhToanHD);
            this.Name = "XemThanhToanHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Thanh Toán Hoá Đơn";
            this.Load += new System.EventHandler(this.ChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSThanhToanHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSThanhToanHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_hoadonid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToanTiepTheo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}