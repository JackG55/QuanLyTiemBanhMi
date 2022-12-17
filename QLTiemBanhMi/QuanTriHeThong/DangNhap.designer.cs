namespace QLTiemBanhMi.QuanTriHeThong
{
    partial class DangNhap
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditNhoMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.lbPass = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.lbUser = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNhoMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(215, 324);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseMove);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(91, 324);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Đăng nhập";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            this.btnOK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseMove);
            // 
            // checkEditNhoMatKhau
            // 
            this.checkEditNhoMatKhau.Location = new System.Drawing.Point(61, 252);
            this.checkEditNhoMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkEditNhoMatKhau.Name = "checkEditNhoMatKhau";
            this.checkEditNhoMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditNhoMatKhau.Properties.Appearance.Options.UseFont = true;
            this.checkEditNhoMatKhau.Properties.Caption = "Nhớ mật khẩu";
            this.checkEditNhoMatKhau.Size = new System.Drawing.Size(144, 24);
            this.checkEditNhoMatKhau.TabIndex = 5;
            // 
            // checkEditHienMatKhau
            // 
            this.checkEditHienMatKhau.Location = new System.Drawing.Point(272, 221);
            this.checkEditHienMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkEditHienMatKhau.Name = "checkEditHienMatKhau";
            this.checkEditHienMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditHienMatKhau.Properties.Appearance.Options.UseFont = true;
            this.checkEditHienMatKhau.Properties.Caption = "Hiện mật khẩu";
            this.checkEditHienMatKhau.Size = new System.Drawing.Size(139, 24);
            this.checkEditHienMatKhau.TabIndex = 4;
            this.checkEditHienMatKhau.CheckedChanged += new System.EventHandler(this.checkEditHienMatKhau_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(59, 216);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(207, 32);
            this.txtPass.TabIndex = 3;
            // 
            // lbPass
            // 
            this.lbPass.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Appearance.Options.UseFont = true;
            this.lbPass.Location = new System.Drawing.Point(61, 192);
            this.lbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(84, 24);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(61, 144);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Size = new System.Drawing.Size(207, 32);
            this.txtUser.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Appearance.Options.UseFont = true;
            this.lbUser.Location = new System.Drawing.Point(61, 120);
            this.lbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(144, 24);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(80, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 446);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiệm Bánh Mì Masstige";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.lbPass);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.checkEditNhoMatKhau);
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Controls.Add(this.checkEditHienMatKhau);
            this.panel2.Location = new System.Drawing.Point(509, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 446);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log In";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLTiemBanhMi.Properties.Resources.key_icon;
            this.pictureBox2.Location = new System.Drawing.Point(18, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QLTiemBanhMi.Properties.Resources.user_32x321;
            this.panel3.Location = new System.Drawing.Point(18, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(37, 35);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTiemBanhMi.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ TIỆM BÁNH MÌ MASSTIGE";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNhoMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.CheckEdit checkEditNhoMatKhau;
        private DevExpress.XtraEditors.CheckEdit checkEditHienMatKhau;
        public DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl lbPass;
        public DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl lbUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}