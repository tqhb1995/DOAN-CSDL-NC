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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(695, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NhanVienQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}