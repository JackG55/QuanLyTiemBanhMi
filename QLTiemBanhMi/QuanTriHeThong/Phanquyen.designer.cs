namespace QLTiemBanhMi.QuanTriHeThong
{
    partial class Phanquyen
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
            this.components = new System.ComponentModel.Container();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panelVaitro = new System.Windows.Forms.Panel();
            this.glue_nhanvien = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelVaitro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLưu = new System.Windows.Forms.Button();
            this.sidePanelQuanLy = new DevExpress.XtraEditors.SidePanel();
            this.dtgvDSQuyen = new System.Windows.Forms.DataGridView();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panelVaitro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glue_nhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.sidePanelQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVaitro
            // 
            this.panelVaitro.Controls.Add(this.glue_nhanvien);
            this.panelVaitro.Controls.Add(this.labelVaitro);
            this.panelVaitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVaitro.Location = new System.Drawing.Point(0, 0);
            this.panelVaitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVaitro.Name = "panelVaitro";
            this.panelVaitro.Size = new System.Drawing.Size(966, 64);
            this.panelVaitro.TabIndex = 0;
            // 
            // glue_nhanvien
            // 
            this.glue_nhanvien.Location = new System.Drawing.Point(149, 11);
            this.glue_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.glue_nhanvien.Name = "glue_nhanvien";
            this.glue_nhanvien.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.False;
            this.glue_nhanvien.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glue_nhanvien.Properties.Appearance.Options.UseFont = true;
            this.glue_nhanvien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glue_nhanvien.Properties.PopupView = this.gridLookUpEdit1View;
            this.glue_nhanvien.Size = new System.Drawing.Size(304, 32);
            this.glue_nhanvien.TabIndex = 75;
            this.glue_nhanvien.EditValueChanged += new System.EventHandler(this.glue_nhanvien_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelVaitro
            // 
            this.labelVaitro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVaitro.Location = new System.Drawing.Point(17, 14);
            this.labelVaitro.Name = "labelVaitro";
            this.labelVaitro.Size = new System.Drawing.Size(126, 32);
            this.labelVaitro.TabIndex = 0;
            this.labelVaitro.Text = "Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLưu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 639);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(966, 69);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // buttonLưu
            // 
            this.buttonLưu.BackColor = System.Drawing.Color.White;
            this.buttonLưu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLưu.Image = global::QLTiemBanhMi.Properties.Resources.save_16x16;
            this.buttonLưu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLưu.Location = new System.Drawing.Point(439, 22);
            this.buttonLưu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLưu.Name = "buttonLưu";
            this.buttonLưu.Size = new System.Drawing.Size(89, 41);
            this.buttonLưu.TabIndex = 89;
            this.buttonLưu.Text = "Lưu";
            this.buttonLưu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLưu.UseVisualStyleBackColor = false;
            this.buttonLưu.Click += new System.EventHandler(this.buttonLưu_Click);
            // 
            // sidePanelQuanLy
            // 
            this.sidePanelQuanLy.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.sidePanelQuanLy.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanelQuanLy.Appearance.Options.UseBackColor = true;
            this.sidePanelQuanLy.Appearance.Options.UseBorderColor = true;
            this.sidePanelQuanLy.Controls.Add(this.dtgvDSQuyen);
            this.sidePanelQuanLy.Controls.Add(this.panelVaitro);
            this.sidePanelQuanLy.Controls.Add(this.groupBox2);
            this.sidePanelQuanLy.Location = new System.Drawing.Point(436, 78);
            this.sidePanelQuanLy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidePanelQuanLy.Name = "sidePanelQuanLy";
            this.sidePanelQuanLy.Size = new System.Drawing.Size(966, 708);
            this.sidePanelQuanLy.TabIndex = 14;
            this.sidePanelQuanLy.Text = "sidePanel1";
            // 
            // dtgvDSQuyen
            // 
            this.dtgvDSQuyen.AllowUserToAddRows = false;
            this.dtgvDSQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.ID,
            this.TenQuyen});
            this.dtgvDSQuyen.Location = new System.Drawing.Point(0, 54);
            this.dtgvDSQuyen.Name = "dtgvDSQuyen";
            this.dtgvDSQuyen.RowHeadersWidth = 51;
            this.dtgvDSQuyen.RowTemplate.Height = 24;
            this.dtgvDSQuyen.Size = new System.Drawing.Size(966, 578);
            this.dtgvDSQuyen.TabIndex = 16;
            // 
            // Chk
            // 
            this.Chk.HeaderText = "";
            this.Chk.MinimumWidth = 6;
            this.Chk.Name = "Chk";
            this.Chk.Width = 75;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 200;
            // 
            // TenQuyen
            // 
            this.TenQuyen.DataPropertyName = "TenQuyen";
            this.TenQuyen.HeaderText = "Tên Quyền";
            this.TenQuyen.MinimumWidth = 6;
            this.TenQuyen.Name = "TenQuyen";
            this.TenQuyen.Width = 500;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieuDe.Location = new System.Drawing.Point(779, 36);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(277, 23);
            this.labelTieuDe.TabIndex = 15;
            this.labelTieuDe.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            // 
            // Phanquyen
            // 
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 793);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.sidePanelQuanLy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Phanquyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.Phanquyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panelVaitro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glue_nhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.sidePanelQuanLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Panel panelVaitro;
        private System.Windows.Forms.Label labelVaitro;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SidePanel sidePanelQuanLy;
        private System.Windows.Forms.Label labelTieuDe;
        private DevExpress.XtraEditors.GridLookUpEdit glue_nhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Button buttonLưu;
        private System.Windows.Forms.DataGridView dtgvDSQuyen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyen;
    }
}