
namespace QLTiemBanhMi.QuanLyNghiepVu.QuanLyNhanVien
{
    partial class CaLam
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
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLưu = new System.Windows.Forms.Button();
            this.glue_calam = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ngaylam = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.glue_calam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.White;
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Image = global::QLTiemBanhMi.Properties.Resources.cancel_16x16;
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(270, 160);
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
            this.buttonLưu.Location = new System.Drawing.Point(156, 160);
            this.buttonLưu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLưu.Name = "buttonLưu";
            this.buttonLưu.Size = new System.Drawing.Size(89, 50);
            this.buttonLưu.TabIndex = 88;
            this.buttonLưu.Text = "Lưu";
            this.buttonLưu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLưu.UseVisualStyleBackColor = false;
            this.buttonLưu.Click += new System.EventHandler(this.buttonLưu_Click);
            // 
            // glue_calam
            // 
            this.glue_calam.Location = new System.Drawing.Point(220, 90);
            this.glue_calam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glue_calam.Name = "glue_calam";
            this.glue_calam.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glue_calam.Properties.Appearance.Options.UseFont = true;
            this.glue_calam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_calam.Properties.PopupView = this.gridView1;
            this.glue_calam.Size = new System.Drawing.Size(304, 32);
            this.glue_calam.TabIndex = 104;
            this.glue_calam.EditValueChanged += new System.EventHandler(this.glue_calam_EditValueChanged);
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
            this.label9.Location = new System.Drawing.Point(33, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 103;
            this.label9.Text = "Ngày Làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "Ca Làm";
            // 
            // dtp_ngaylam
            // 
            this.dtp_ngaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaylam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaylam.Location = new System.Drawing.Point(220, 39);
            this.dtp_ngaylam.Name = "dtp_ngaylam";
            this.dtp_ngaylam.Size = new System.Drawing.Size(304, 30);
            this.dtp_ngaylam.TabIndex = 109;
            // 
            // CaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(557, 229);
            this.Controls.Add(this.dtp_ngaylam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.glue_calam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLưu);
            this.Name = "CaLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Công Ca Làm";
            this.Load += new System.EventHandler(this.ChiTietHD_SP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glue_calam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLưu;
        private DevExpress.XtraEditors.GridLookUpEdit glue_calam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ngaylam;
    }
}