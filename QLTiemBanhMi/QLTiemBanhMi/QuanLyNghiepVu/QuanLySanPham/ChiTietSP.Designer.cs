
namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLySanPham
{
    partial class ChiTietSP
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
            this.tb_tensanpham = new System.Windows.Forms.TextBox();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.glue_danhmucsp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLưu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.glue_danhmucsp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 69;
            this.label5.Text = "Tên sản phẩm";
            // 
            // tb_tensanpham
            // 
            this.tb_tensanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tensanpham.Location = new System.Drawing.Point(229, 66);
            this.tb_tensanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tensanpham.Name = "tb_tensanpham";
            this.tb_tensanpham.Size = new System.Drawing.Size(304, 30);
            this.tb_tensanpham.TabIndex = 68;
            // 
            // tb_masp
            // 
            this.tb_masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_masp.Location = new System.Drawing.Point(229, 18);
            this.tb_masp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.ReadOnly = true;
            this.tb_masp.Size = new System.Drawing.Size(304, 30);
            this.tb_masp.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Mô Tả";
            // 
            // tb_mota
            // 
            this.tb_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mota.Location = new System.Drawing.Point(229, 172);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(304, 30);
            this.tb_mota.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 97;
            this.label7.Text = "Giá Bán";
            // 
            // tb_giaban
            // 
            this.tb_giaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giaban.Location = new System.Drawing.Point(229, 221);
            this.tb_giaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.Size = new System.Drawing.Size(304, 30);
            this.tb_giaban.TabIndex = 96;
            this.tb_giaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_giaban_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 99;
            this.label3.Text = "Danh Mục";
            // 
            // glue_danhmucsp
            // 
            this.glue_danhmucsp.Location = new System.Drawing.Point(229, 117);
            this.glue_danhmucsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glue_danhmucsp.Name = "glue_danhmucsp";
            this.glue_danhmucsp.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glue_danhmucsp.Properties.Appearance.Options.UseFont = true;
            this.glue_danhmucsp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_danhmucsp.Properties.PopupView = this.gridLookUpEdit1View;
            this.glue_danhmucsp.Size = new System.Drawing.Size(304, 32);
            this.glue_danhmucsp.TabIndex = 104;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.White;
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::QLTiemBanhMi.Properties.Resources.cancel_16x16;
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(295, 293);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(92, 45);
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
            this.buttonLưu.Location = new System.Drawing.Point(181, 293);
            this.buttonLưu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLưu.Name = "buttonLưu";
            this.buttonLưu.Size = new System.Drawing.Size(89, 45);
            this.buttonLưu.TabIndex = 88;
            this.buttonLưu.Text = "Lưu";
            this.buttonLưu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLưu.UseVisualStyleBackColor = false;
            this.buttonLưu.Click += new System.EventHandler(this.buttonLưu_Click);
            // 
            // ChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(557, 361);
            this.Controls.Add(this.glue_danhmucsp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_giaban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mota);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLưu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tensanpham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_masp);
            this.Name = "ChiTietSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Sản Phẩm";
            this.Load += new System.EventHandler(this.ChiTietSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glue_danhmucsp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tensanpham;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLưu;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_giaban;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit glue_danhmucsp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}