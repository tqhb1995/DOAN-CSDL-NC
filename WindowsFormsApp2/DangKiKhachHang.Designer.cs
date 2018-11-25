using System;

namespace WindowsFormsApp2
{
    partial class ForInsertNewCustomer
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gboTTCN = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gboTTDN = new System.Windows.Forms.GroupBox();
            this.cboHienThi2 = new System.Windows.Forms.CheckBox();
            this.cboHienThi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.datKhachSanOnlineDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gboTTCN.SuspendLayout();
            this.gboTTDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(24, 41);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(77, 20);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.ForeColor = System.Drawing.Color.Silver;
            this.txtHoTen.Location = new System.Drawing.Point(126, 38);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(285, 29);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Text = "Trần Văn A";
            this.txtHoTen.Enter += new System.EventHandler(this.txtHoTen_Enter);
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            // 
            // gboTTCN
            // 
            this.gboTTCN.Controls.Add(this.txtDiaChi);
            this.gboTTCN.Controls.Add(this.txtCMND);
            this.gboTTCN.Controls.Add(this.lblSoCMND);
            this.gboTTCN.Controls.Add(this.txtMoTa);
            this.gboTTCN.Controls.Add(this.lblMoTa);
            this.gboTTCN.Controls.Add(this.txtEmail);
            this.gboTTCN.Controls.Add(this.lblEmail);
            this.gboTTCN.Controls.Add(this.txtSDT);
            this.gboTTCN.Controls.Add(this.lblSDT);
            this.gboTTCN.Controls.Add(this.lblDiaChi);
            this.gboTTCN.Controls.Add(this.lblHoTen);
            this.gboTTCN.Controls.Add(this.txtHoTen);
            this.gboTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTTCN.Location = new System.Drawing.Point(14, 66);
            this.gboTTCN.Margin = new System.Windows.Forms.Padding(5);
            this.gboTTCN.Name = "gboTTCN";
            this.gboTTCN.Padding = new System.Windows.Forms.Padding(5);
            this.gboTTCN.Size = new System.Drawing.Size(419, 305);
            this.gboTTCN.TabIndex = 6;
            this.gboTTCN.TabStop = false;
            this.gboTTCN.Text = "Thông tin cá nhân";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.Color.Silver;
            this.txtDiaChi.Location = new System.Drawing.Point(124, 110);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(285, 77);
            this.txtDiaChi.TabIndex = 18;
            this.txtDiaChi.Text = "số 01, đường A, phường B, quận C, TP.D";
            this.txtDiaChi.Enter += new System.EventHandler(this.txtDiaChi_Enter);
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // txtCMND
            // 
            this.txtCMND.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCMND.Location = new System.Drawing.Point(126, 74);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(5);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(285, 29);
            this.txtCMND.TabIndex = 17;
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCMND.Location = new System.Drawing.Point(24, 77);
            this.lblSoCMND.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(80, 20);
            this.lblSoCMND.TabIndex = 16;
            this.lblSoCMND.Text = "Số CMND";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(126, 233);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(5);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(285, 29);
            this.txtMoTa.TabIndex = 15;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(24, 236);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(49, 20);
            this.lblMoTa.TabIndex = 14;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(126, 269);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 29);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "tranvana@xyz.com";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(24, 272);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(126, 197);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(285, 29);
            this.txtSDT.TabIndex = 11;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(24, 196);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 20);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "SĐT";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(24, 110);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsert.Location = new System.Drawing.Point(690, 304);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(101, 33);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Đăng kí";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gboTTDN
            // 
            this.gboTTDN.Controls.Add(this.cboHienThi2);
            this.gboTTDN.Controls.Add(this.cboHienThi);
            this.gboTTDN.Controls.Add(this.label2);
            this.gboTTDN.Controls.Add(this.txtXNMK);
            this.gboTTDN.Controls.Add(this.lblMatKhau);
            this.gboTTDN.Controls.Add(this.txtMatKhau);
            this.gboTTDN.Controls.Add(this.txtTenDangNhap);
            this.gboTTDN.Controls.Add(this.lblTenDangNhap);
            this.gboTTDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTTDN.Location = new System.Drawing.Point(461, 66);
            this.gboTTDN.Margin = new System.Windows.Forms.Padding(5);
            this.gboTTDN.Name = "gboTTDN";
            this.gboTTDN.Padding = new System.Windows.Forms.Padding(5);
            this.gboTTDN.Size = new System.Drawing.Size(514, 152);
            this.gboTTDN.TabIndex = 8;
            this.gboTTDN.TabStop = false;
            this.gboTTDN.Text = "Thông tin đăng nhập";
            // 
            // cboHienThi2
            // 
            this.cboHienThi2.AutoSize = true;
            this.cboHienThi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHienThi2.Location = new System.Drawing.Point(423, 101);
            this.cboHienThi2.Name = "cboHienThi2";
            this.cboHienThi2.Size = new System.Drawing.Size(82, 24);
            this.cboHienThi2.TabIndex = 8;
            this.cboHienThi2.Text = "Hiển thị";
            this.cboHienThi2.UseVisualStyleBackColor = true;
            this.cboHienThi2.CheckedChanged += new System.EventHandler(this.cboHienThi2_CheckedChanged);
            // 
            // cboHienThi
            // 
            this.cboHienThi.AutoSize = true;
            this.cboHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHienThi.Location = new System.Drawing.Point(423, 65);
            this.cboHienThi.Name = "cboHienThi";
            this.cboHienThi.Size = new System.Drawing.Size(82, 24);
            this.cboHienThi.TabIndex = 7;
            this.cboHienThi.Text = "Hiển thị";
            this.cboHienThi.UseVisualStyleBackColor = true;
            this.cboHienThi.CheckedChanged += new System.EventHandler(this.cboHienThi_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Xác nhận Mật khẩu";
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(183, 99);
            this.txtXNMK.Margin = new System.Windows.Forms.Padding(5);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.Size = new System.Drawing.Size(226, 29);
            this.txtXNMK.TabIndex = 5;
            this.txtXNMK.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(24, 66);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(75, 20);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(183, 63);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(226, 29);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(183, 27);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(226, 29);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(24, 30);
            this.lblTenDangNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(116, 20);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Location = new System.Drawing.Point(801, 304);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 33);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "ĐĂNG KÍ THÔNG TIN KHÁCH HÀNG";
            // 
            // ForInsertNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(989, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gboTTDN);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gboTTCN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ForInsertNewCustomer";
            this.Text = "Thêm Khách Hàng Mới";
            this.gboTTCN.ResumeLayout(false);
            this.gboTTCN.PerformLayout();
            this.gboTTDN.ResumeLayout(false);
            this.gboTTDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox gboTTCN;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;



        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox gboTTDN;
        
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        //private DatKhachSanOnlineDataSet datKhachSanOnlineDataSet;
        private System.Windows.Forms.BindingSource datKhachSanOnlineDataSetBindingSource;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cboHienThi2;
        private System.Windows.Forms.CheckBox cboHienThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXNMK;
    }
}

