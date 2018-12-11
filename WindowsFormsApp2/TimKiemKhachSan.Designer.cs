namespace WindowsFormsApp2
{
    partial class TimKiemKhachSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemKhachSan));
            this.btBack = new System.Windows.Forms.Button();
            this.tbPrice1 = new System.Windows.Forms.TextBox();
            this.tbPrice2 = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lbPrice1 = new System.Windows.Forms.Label();
            this.lbPrice2 = new System.Windows.Forms.Label();
            this.lbSao = new System.Windows.Forms.Label();
            this.lbTP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSao = new System.Windows.Forms.ComboBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbSuaThongTin = new System.Windows.Forms.Button();
            this.dgvtk = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtk)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(694, 480);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Quay lại";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // tbPrice1
            // 
            this.tbPrice1.Location = new System.Drawing.Point(97, 35);
            this.tbPrice1.Name = "tbPrice1";
            this.tbPrice1.Size = new System.Drawing.Size(100, 20);
            this.tbPrice1.TabIndex = 0;
            // 
            // tbPrice2
            // 
            this.tbPrice2.Location = new System.Drawing.Point(335, 35);
            this.tbPrice2.Name = "tbPrice2";
            this.tbPrice2.Size = new System.Drawing.Size(100, 20);
            this.tbPrice2.TabIndex = 1;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(97, 132);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 3;
            // 
            // lbPrice1
            // 
            this.lbPrice1.AutoSize = true;
            this.lbPrice1.Location = new System.Drawing.Point(31, 38);
            this.lbPrice1.Name = "lbPrice1";
            this.lbPrice1.Size = new System.Drawing.Size(35, 13);
            this.lbPrice1.TabIndex = 5;
            this.lbPrice1.Text = "Giá từ";
            // 
            // lbPrice2
            // 
            this.lbPrice2.AutoSize = true;
            this.lbPrice2.Location = new System.Drawing.Point(289, 38);
            this.lbPrice2.Name = "lbPrice2";
            this.lbPrice2.Size = new System.Drawing.Size(27, 13);
            this.lbPrice2.TabIndex = 6;
            this.lbPrice2.Text = "Đến";
            // 
            // lbSao
            // 
            this.lbSao.AutoSize = true;
            this.lbSao.Location = new System.Drawing.Point(25, 88);
            this.lbSao.Name = "lbSao";
            this.lbSao.Size = new System.Drawing.Size(53, 13);
            this.lbSao.TabIndex = 7;
            this.lbSao.Text = "Hạng sao";
            // 
            // lbTP
            // 
            this.lbTP.AutoSize = true;
            this.lbTP.Location = new System.Drawing.Point(25, 135);
            this.lbTP.Name = "lbTP";
            this.lbTP.Size = new System.Drawing.Size(59, 13);
            this.lbTP.TabIndex = 8;
            this.lbTP.Text = "Thành phố";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSao);
            this.groupBox1.Controls.Add(this.lbTP);
            this.groupBox1.Controls.Add(this.lbSao);
            this.groupBox1.Controls.Add(this.lbPrice2);
            this.groupBox1.Controls.Add(this.lbPrice1);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Controls.Add(this.tbPrice2);
            this.groupBox1.Controls.Add(this.tbPrice1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm khách sạn";
            // 
            // cbSao
            // 
            this.cbSao.FormattingEnabled = true;
            this.cbSao.Location = new System.Drawing.Point(97, 85);
            this.cbSao.Name = "cbSao";
            this.cbSao.Size = new System.Drawing.Size(121, 21);
            this.cbSao.TabIndex = 9;
            // 
            // btSearch
            // 
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Location = new System.Drawing.Point(360, 88);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 65);
            this.btSearch.TabIndex = 4;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btbSuaThongTin);
            this.groupBox2.Location = new System.Drawing.Point(618, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 109);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.User003_Edit_512;
            this.pictureBox1.Location = new System.Drawing.Point(73, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btbSuaThongTin
            // 
            this.btbSuaThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSuaThongTin.Location = new System.Drawing.Point(16, 68);
            this.btbSuaThongTin.Name = "btbSuaThongTin";
            this.btbSuaThongTin.Size = new System.Drawing.Size(121, 33);
            this.btbSuaThongTin.TabIndex = 3;
            this.btbSuaThongTin.Text = "Sửa thông tin";
            this.btbSuaThongTin.UseVisualStyleBackColor = true;
            this.btbSuaThongTin.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvtk
            // 
            this.dgvtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtk.Location = new System.Drawing.Point(28, 187);
            this.dgvtk.Name = "dgvtk";
            this.dgvtk.Size = new System.Drawing.Size(727, 287);
            this.dgvtk.TabIndex = 7;
            this.dgvtk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtk_CellDoubleClick);
            // 
            // TimKiemKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 512);
            this.Controls.Add(this.dgvtk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiemKhachSan";
            this.Text = "TimKiemKhachSan";
            this.Load += new System.EventHandler(this.TimKiemKhachSan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TextBox tbPrice1;
        private System.Windows.Forms.TextBox tbPrice2;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbPrice1;
        private System.Windows.Forms.Label lbPrice2;
        private System.Windows.Forms.Label lbSao;
        private System.Windows.Forms.Label lbTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbSuaThongTin;
        private System.Windows.Forms.ComboBox cbSao;
        private System.Windows.Forms.DataGridView dgvtk;
    }
}