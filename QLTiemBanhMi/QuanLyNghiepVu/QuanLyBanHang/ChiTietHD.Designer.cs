
namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyBanHang
{
    partial class ChiTietHD 
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
            this.tb_masanpham = new System.Windows.Forms.TextBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLưu = new System.Windows.Forms.Button();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.glue_sanpham = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glue_sanpham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 69;
            this.label5.Text = "Mã Sản Phẩm";
            // 
            // tb_masanpham
            // 
            this.tb_masanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_masanpham.Location = new System.Drawing.Point(215, 101);
            this.tb_masanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_masanpham.Name = "tb_masanpham";
            this.tb_masanpham.ReadOnly = true;
            this.tb_masanpham.Size = new System.Drawing.Size(304, 30);
            this.tb_masanpham.TabIndex = 68;
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.White;
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::QLTiemBanhMi.Properties.Resources.cancel_16x16;
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(270, 265);
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
            this.buttonLưu.Location = new System.Drawing.Point(156, 265);
            this.buttonLưu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLưu.Name = "buttonLưu";
            this.buttonLưu.Size = new System.Drawing.Size(89, 50);
            this.buttonLưu.TabIndex = 88;
            this.buttonLưu.Text = "OK";
            this.buttonLưu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLưu.UseVisualStyleBackColor = false;
            this.buttonLưu.Click += new System.EventHandler(this.buttonLưu_Click);
            // 
            // tb_dongia
            // 
            this.tb_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dongia.Location = new System.Drawing.Point(215, 154);
            this.tb_dongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.ReadOnly = true;
            this.tb_dongia.Size = new System.Drawing.Size(304, 30);
            this.tb_dongia.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Số Lượng";
            // 
            // tb_soluong
            // 
            this.tb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluong.Location = new System.Drawing.Point(215, 207);
            this.tb_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(304, 30);
            this.tb_soluong.TabIndex = 96;
            this.tb_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soluong_KeyPress);
            // 
            // glue_sanpham
            // 
            this.glue_sanpham.Location = new System.Drawing.Point(215, 48);
            this.glue_sanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glue_sanpham.Name = "glue_sanpham";
            this.glue_sanpham.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glue_sanpham.Properties.Appearance.Options.UseFont = true;
            this.glue_sanpham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_sanpham.Properties.PopupView = this.gridView1;
            this.glue_sanpham.Size = new System.Drawing.Size(304, 32);
            this.glue_sanpham.TabIndex = 104;
            this.glue_sanpham.EditValueChanged += new System.EventHandler(this.glue_hang_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // ChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(557, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.glue_sanpham);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLưu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_masanpham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dongia);
            this.Name = "ChiTietHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hoá Đơn";
            this.Load += new System.EventHandler(this.ChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glue_sanpham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_masanpham;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLưu;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_soluong;
        private DevExpress.XtraEditors.GridLookUpEdit glue_sanpham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label4;
    }
}