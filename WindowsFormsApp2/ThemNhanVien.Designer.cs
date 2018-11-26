namespace WindowsFormsApp2
{
    partial class ThemNhanVien
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
            this.cboMaKS = new System.Windows.Forms.ComboBox();
            this.khachSan1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datKhachSanOnlineDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datKhachSanOnlineDataSet = new WindowsFormsApp2.DatKhachSanOnlineDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btn_ThemNhanVienMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new WindowsFormsApp2.DatKhachSanOnlineDataSetTableAdapters.HoaDonTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachSan1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachSan1TableAdapter = new WindowsFormsApp2.DatKhachSanOnlineDataSetTableAdapters.KhachSan1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khachSan1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSan1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaKS
            // 
            this.cboMaKS.DataSource = this.khachSan1BindingSource1;
            this.cboMaKS.DisplayMember = "maKS";
            this.cboMaKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKS.FormattingEnabled = true;
            this.cboMaKS.Location = new System.Drawing.Point(142, 181);
            this.cboMaKS.Name = "cboMaKS";
            this.cboMaKS.Size = new System.Drawing.Size(197, 28);
            this.cboMaKS.TabIndex = 18;
            this.cboMaKS.SelectedIndexChanged += new System.EventHandler(this.cboMaKS_SelectedIndexChanged);
            // 
            // khachSan1BindingSource1
            // 
            this.khachSan1BindingSource1.DataMember = "KhachSan1";
            this.khachSan1BindingSource1.DataSource = this.datKhachSanOnlineDataSetBindingSource;
            // 
            // datKhachSanOnlineDataSetBindingSource
            // 
            this.datKhachSanOnlineDataSetBindingSource.DataSource = this.datKhachSanOnlineDataSet;
            this.datKhachSanOnlineDataSetBindingSource.Position = 0;
            // 
            // datKhachSanOnlineDataSet
            // 
            this.datKhachSanOnlineDataSet.DataSetName = "DatKhachSanOnlineDataSet";
            this.datKhachSanOnlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Khách Sạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ và tên";
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.Location = new System.Drawing.Point(597, 387);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(106, 37);
            this.btn_DangKy.TabIndex = 15;
            this.btn_DangKy.Text = "THOÁT";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(142, 144);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(197, 26);
            this.txtMatKhau.TabIndex = 13;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(142, 109);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(197, 26);
            this.txtTenDangNhap.TabIndex = 11;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(12, 109);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(116, 20);
            this.lbl_UserName.TabIndex = 10;
            this.lbl_UserName.Text = "Tên đăng nhập";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(142, 76);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(197, 26);
            this.txtHoTen.TabIndex = 19;
            // 
            // btn_ThemNhanVienMoi
            // 
            this.btn_ThemNhanVienMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ThemNhanVienMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNhanVienMoi.Location = new System.Drawing.Point(468, 387);
            this.btn_ThemNhanVienMoi.Name = "btn_ThemNhanVienMoi";
            this.btn_ThemNhanVienMoi.Size = new System.Drawing.Size(112, 37);
            this.btn_ThemNhanVienMoi.TabIndex = 14;
            this.btn_ThemNhanVienMoi.Text = "THÊM";
            this.btn_ThemNhanVienMoi.UseVisualStyleBackColor = false;
            this.btn_ThemNhanVienMoi.Click += new System.EventHandler(this.btn_ThemNhanVienMoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "THÊM NHÂN VIÊN MỚI";
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.datKhachSanOnlineDataSet;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKSDataGridViewTextBoxColumn,
            this.tenKSDataGridViewTextBoxColumn,
            this.soSaoDataGridViewTextBoxColumn,
            this.soNhaDataGridViewTextBoxColumn,
            this.duongDataGridViewTextBoxColumn,
            this.quanDataGridViewTextBoxColumn,
            this.thanhPhoDataGridViewTextBoxColumn,
            this.giaTBDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachSan1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // maKSDataGridViewTextBoxColumn
            // 
            this.maKSDataGridViewTextBoxColumn.DataPropertyName = "maKS";
            this.maKSDataGridViewTextBoxColumn.HeaderText = "maKS";
            this.maKSDataGridViewTextBoxColumn.Name = "maKSDataGridViewTextBoxColumn";
            this.maKSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKSDataGridViewTextBoxColumn
            // 
            this.tenKSDataGridViewTextBoxColumn.DataPropertyName = "tenKS";
            this.tenKSDataGridViewTextBoxColumn.HeaderText = "tenKS";
            this.tenKSDataGridViewTextBoxColumn.Name = "tenKSDataGridViewTextBoxColumn";
            this.tenKSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soSaoDataGridViewTextBoxColumn
            // 
            this.soSaoDataGridViewTextBoxColumn.DataPropertyName = "soSao";
            this.soSaoDataGridViewTextBoxColumn.HeaderText = "soSao";
            this.soSaoDataGridViewTextBoxColumn.Name = "soSaoDataGridViewTextBoxColumn";
            this.soSaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soNhaDataGridViewTextBoxColumn
            // 
            this.soNhaDataGridViewTextBoxColumn.DataPropertyName = "soNha";
            this.soNhaDataGridViewTextBoxColumn.HeaderText = "soNha";
            this.soNhaDataGridViewTextBoxColumn.Name = "soNhaDataGridViewTextBoxColumn";
            this.soNhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duongDataGridViewTextBoxColumn
            // 
            this.duongDataGridViewTextBoxColumn.DataPropertyName = "duong";
            this.duongDataGridViewTextBoxColumn.HeaderText = "duong";
            this.duongDataGridViewTextBoxColumn.Name = "duongDataGridViewTextBoxColumn";
            this.duongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quanDataGridViewTextBoxColumn
            // 
            this.quanDataGridViewTextBoxColumn.DataPropertyName = "quan";
            this.quanDataGridViewTextBoxColumn.HeaderText = "quan";
            this.quanDataGridViewTextBoxColumn.Name = "quanDataGridViewTextBoxColumn";
            this.quanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhPhoDataGridViewTextBoxColumn
            // 
            this.thanhPhoDataGridViewTextBoxColumn.DataPropertyName = "thanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.HeaderText = "thanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.Name = "thanhPhoDataGridViewTextBoxColumn";
            this.thanhPhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaTBDataGridViewTextBoxColumn
            // 
            this.giaTBDataGridViewTextBoxColumn.DataPropertyName = "giaTB";
            this.giaTBDataGridViewTextBoxColumn.HeaderText = "giaTB";
            this.giaTBDataGridViewTextBoxColumn.Name = "giaTBDataGridViewTextBoxColumn";
            this.giaTBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "moTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "moTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // khachSan1BindingSource
            // 
            this.khachSan1BindingSource.DataMember = "KhachSan1";
            this.khachSan1BindingSource.DataSource = this.datKhachSanOnlineDataSet;
            // 
            // khachSan1TableAdapter
            // 
            this.khachSan1TableAdapter.ClearBeforeFill = true;
            // 
            // ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cboMaKS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.btn_ThemNhanVienMoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "ThemNhanVien";
            this.Text = "ThemNhanVien";
            this.Load += new System.EventHandler(this.ThemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachSan1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSan1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaKS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btn_ThemNhanVienMoi;
        private System.Windows.Forms.Label label4;
        private DatKhachSanOnlineDataSet datKhachSanOnlineDataSet;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private DatKhachSanOnlineDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.BindingSource datKhachSanOnlineDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource khachSan1BindingSource;
        private DatKhachSanOnlineDataSetTableAdapters.KhachSan1TableAdapter khachSan1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource khachSan1BindingSource1;
    }
}