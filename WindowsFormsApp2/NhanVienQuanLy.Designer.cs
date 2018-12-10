namespace WindowsFormsApp2
{
    partial class NhanVienQuanLy
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
            this.labelQuanLyKhachSan = new System.Windows.Forms.Label();
            this.btnSuaKhachSan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnKiemTraTinhTrangPhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuanLyKhachSan
            // 
            this.labelQuanLyKhachSan.AutoSize = true;
            this.labelQuanLyKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuanLyKhachSan.Location = new System.Drawing.Point(46, 9);
            this.labelQuanLyKhachSan.Name = "labelQuanLyKhachSan";
            this.labelQuanLyKhachSan.Size = new System.Drawing.Size(277, 29);
            this.labelQuanLyKhachSan.TabIndex = 0;
            this.labelQuanLyKhachSan.Text = "QUẢN LÝ KHÁCH SẠN";
            // 
            // btnSuaKhachSan
            // 
            this.btnSuaKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhachSan.Location = new System.Drawing.Point(32, 63);
            this.btnSuaKhachSan.Name = "btnSuaKhachSan";
            this.btnSuaKhachSan.Size = new System.Drawing.Size(202, 31);
            this.btnSuaKhachSan.TabIndex = 1;
            this.btnSuaKhachSan.Text = "Sửa thông tin khách sạn";
            this.btnSuaKhachSan.UseVisualStyleBackColor = true;
            this.btnSuaKhachSan.Click += new System.EventHandler(this.btnSuaKhachSan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(695, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.Location = new System.Drawing.Point(330, 63);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(209, 30);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnKiemTraTinhTrangPhong
            // 
            this.btnKiemTraTinhTrangPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTraTinhTrangPhong.Location = new System.Drawing.Point(32, 117);
            this.btnKiemTraTinhTrangPhong.Name = "btnKiemTraTinhTrangPhong";
            this.btnKiemTraTinhTrangPhong.Size = new System.Drawing.Size(202, 31);
            this.btnKiemTraTinhTrangPhong.TabIndex = 4;
            this.btnKiemTraTinhTrangPhong.Text = "Kiểm tra tình trạng phòng";
            this.btnKiemTraTinhTrangPhong.UseVisualStyleBackColor = true;
            this.btnKiemTraTinhTrangPhong.Click += new System.EventHandler(this.btnKiemTraTinhTrangPhong_Click);
            // 
            // NhanVienQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnKiemTraTinhTrangPhong);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuaKhachSan);
            this.Controls.Add(this.labelQuanLyKhachSan);
            this.Name = "NhanVienQuanLy";
            this.Text = "NhanVienQuanLy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuanLyKhachSan;
        private System.Windows.Forms.Button btnSuaKhachSan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnKiemTraTinhTrangPhong;
    }
}