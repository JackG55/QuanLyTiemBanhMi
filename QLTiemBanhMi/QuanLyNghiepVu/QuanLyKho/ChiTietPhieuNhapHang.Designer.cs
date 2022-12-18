
namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyKho
{
    partial class ChiTietPhieuNhapHang
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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_maphieunhap = new System.Windows.Forms.TextBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLưu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.glue_nguyenvatlieu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glue_nguyenvatlieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 69;
            this.label5.Text = "Phiếu Nhập Hàng";
            // 
            // tb_maphieunhap
            // 
            this.tb_maphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maphieunhap.Location = new System.Drawing.Point(226, 27);
            this.tb_maphieunhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_maphieunhap.Name = "tb_maphieunhap";
            this.tb_maphieunhap.ReadOnly = true;
            this.tb_maphieunhap.Size = new System.Drawing.Size(304, 30);
            this.tb_maphieunhap.TabIndex = 68;
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.White;
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::QLTiemBanhMi.Properties.Resources.cancel_16x16;
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(278, 233);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(92, 50);
            this.buttonHuy.TabIndex = 89;
            this.buttonHuy.Text = "Huỷ";
            this.buttonHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonLưu
            // 
            this.buttonLưu.BackColor = System.Drawing.Color.White;
            this.buttonLưu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLưu.Image = global::QLTiemBanhMi.Properties.Resources.save_16x16;
            this.buttonLưu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLưu.Location = new System.Drawing.Point(164, 233);
            this.buttonLưu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLưu.Name = "buttonLưu";
            this.buttonLưu.Size = new System.Drawing.Size(89, 50);
            this.buttonLưu.TabIndex = 88;
            this.buttonLưu.Text = "Lưu";
            this.buttonLưu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLưu.UseVisualStyleBackColor = false;
            this.buttonLưu.Click += new System.EventHandler(this.buttonLưu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Đơn Giá";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dongia.Location = new System.Drawing.Point(226, 178);
            this.tb_dongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(304, 30);
            this.tb_dongia.TabIndex = 92;
            this.tb_dongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_giaban_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 99;
            this.label3.Text = "Số Lượng";
            // 
            // tb_soluong
            // 
            this.tb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluong.Location = new System.Drawing.Point(226, 126);
            this.tb_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(304, 30);
            this.tb_soluong.TabIndex = 98;
            this.tb_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soluong_KeyPress);
            // 
            // glue_nguyenvatlieu
            // 
            this.glue_nguyenvatlieu.Location = new System.Drawing.Point(226, 75);
            this.glue_nguyenvatlieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glue_nguyenvatlieu.Name = "glue_nguyenvatlieu";
            this.glue_nguyenvatlieu.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glue_nguyenvatlieu.Properties.Appearance.Options.UseFont = true;
            this.glue_nguyenvatlieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_nguyenvatlieu.Properties.PopupView = this.gridView1;
            this.glue_nguyenvatlieu.Size = new System.Drawing.Size(304, 32);
            this.glue_nguyenvatlieu.TabIndex = 104;
            this.glue_nguyenvatlieu.EditValueChanged += new System.EventHandler(this.glue_sanpham_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 103;
            this.label9.Text = "Nguyên Vật Liệu";
            // 
            // ChiTietPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(557, 308);
            this.Controls.Add(this.glue_nguyenvatlieu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dongia);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLưu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_maphieunhap);
            this.Name = "ChiTietPhieuNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Nhập Hàng";
            this.Load += new System.EventHandler(this.ChiTietHD_SP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glue_nguyenvatlieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_maphieunhap;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLưu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_soluong;
        private DevExpress.XtraEditors.GridLookUpEdit glue_nguyenvatlieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label9;
    }
}