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
            this.lblMaKS = new System.Windows.Forms.Label();
            this.lblHovaTen = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btn_ThemNhanVienMoi = new System.Windows.Forms.Button();
            this.lblTHEMNHANVIENMOI = new System.Windows.Forms.Label();
            this.cboMaKS = new System.Windows.Forms.ComboBox();
            this.khachSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datKhachSanOnlineDataSet_KS_notin_NV = new WindowsFormsApp2.DatKhachSanOnlineDataSet_KS_notin_NV();
            this.khachSanTableAdapter = new WindowsFormsApp2.DatKhachSanOnlineDataSet_KS_notin_NVTableAdapters.KhachSanTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet_KS_notin_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaKS
            // 
            this.lblMaKS.AutoSize = true;
            this.lblMaKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKS.Location = new System.Drawing.Point(12, 116);
            this.lblMaKS.Name = "lblMaKS";
            this.lblMaKS.Size = new System.Drawing.Size(113, 20);
            this.lblMaKS.TabIndex = 17;
            this.lblMaKS.Text = "Mã Khách Sạn";
            // 
            // lblHovaTen
            // 
            this.lblHovaTen.AutoSize = true;
            this.lblHovaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHovaTen.Location = new System.Drawing.Point(12, 76);
            this.lblHovaTen.Name = "lblHovaTen";
            this.lblHovaTen.Size = new System.Drawing.Size(77, 20);
            this.lblHovaTen.TabIndex = 16;
            this.lblHovaTen.Text = "Họ và tên";
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
            this.txtMatKhau.Location = new System.Drawing.Point(540, 110);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(197, 26);
            this.txtMatKhau.TabIndex = 13;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(418, 116);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(75, 20);
            this.lblMatKhau.TabIndex = 12;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(540, 73);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(197, 26);
            this.txtTenDangNhap.TabIndex = 11;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(418, 76);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(116, 20);
            this.lbl_UserName.TabIndex = 10;
            this.lbl_UserName.Text = "Tên đăng nhập";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(131, 76);
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
            // lblTHEMNHANVIENMOI
            // 
            this.lblTHEMNHANVIENMOI.AutoSize = true;
            this.lblTHEMNHANVIENMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTHEMNHANVIENMOI.Location = new System.Drawing.Point(34, 22);
            this.lblTHEMNHANVIENMOI.Name = "lblTHEMNHANVIENMOI";
            this.lblTHEMNHANVIENMOI.Size = new System.Drawing.Size(286, 29);
            this.lblTHEMNHANVIENMOI.TabIndex = 20;
            this.lblTHEMNHANVIENMOI.Text = "THÊM NHÂN VIÊN MỚI";
            // 
            // cboMaKS
            // 
            this.cboMaKS.DataSource = this.khachSanBindingSource;
            this.cboMaKS.DisplayMember = "maKS";
            this.cboMaKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKS.FormattingEnabled = true;
            this.cboMaKS.Location = new System.Drawing.Point(131, 108);
            this.cboMaKS.Name = "cboMaKS";
            this.cboMaKS.Size = new System.Drawing.Size(197, 28);
            this.cboMaKS.TabIndex = 21;
            // 
            // khachSanBindingSource
            // 
            this.khachSanBindingSource.DataMember = "KhachSan";
            this.khachSanBindingSource.DataSource = this.datKhachSanOnlineDataSet_KS_notin_NV;
            // 
            // datKhachSanOnlineDataSet_KS_notin_NV
            // 
            this.datKhachSanOnlineDataSet_KS_notin_NV.DataSetName = "DatKhachSanOnlineDataSet_KS_notin_NV";
            this.datKhachSanOnlineDataSet_KS_notin_NV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachSanTableAdapter
            // 
            this.khachSanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.DataSource = this.khachSanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(903, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // maKSDataGridViewTextBoxColumn
            // 
            this.maKSDataGridViewTextBoxColumn.DataPropertyName = "maKS";
            this.maKSDataGridViewTextBoxColumn.HeaderText = "maKS";
            this.maKSDataGridViewTextBoxColumn.Name = "maKSDataGridViewTextBoxColumn";
            // 
            // tenKSDataGridViewTextBoxColumn
            // 
            this.tenKSDataGridViewTextBoxColumn.DataPropertyName = "tenKS";
            this.tenKSDataGridViewTextBoxColumn.HeaderText = "tenKS";
            this.tenKSDataGridViewTextBoxColumn.Name = "tenKSDataGridViewTextBoxColumn";
            // 
            // soSaoDataGridViewTextBoxColumn
            // 
            this.soSaoDataGridViewTextBoxColumn.DataPropertyName = "soSao";
            this.soSaoDataGridViewTextBoxColumn.HeaderText = "soSao";
            this.soSaoDataGridViewTextBoxColumn.Name = "soSaoDataGridViewTextBoxColumn";
            // 
            // soNhaDataGridViewTextBoxColumn
            // 
            this.soNhaDataGridViewTextBoxColumn.DataPropertyName = "soNha";
            this.soNhaDataGridViewTextBoxColumn.HeaderText = "soNha";
            this.soNhaDataGridViewTextBoxColumn.Name = "soNhaDataGridViewTextBoxColumn";
            // 
            // duongDataGridViewTextBoxColumn
            // 
            this.duongDataGridViewTextBoxColumn.DataPropertyName = "duong";
            this.duongDataGridViewTextBoxColumn.HeaderText = "duong";
            this.duongDataGridViewTextBoxColumn.Name = "duongDataGridViewTextBoxColumn";
            // 
            // quanDataGridViewTextBoxColumn
            // 
            this.quanDataGridViewTextBoxColumn.DataPropertyName = "quan";
            this.quanDataGridViewTextBoxColumn.HeaderText = "quan";
            this.quanDataGridViewTextBoxColumn.Name = "quanDataGridViewTextBoxColumn";
            // 
            // thanhPhoDataGridViewTextBoxColumn
            // 
            this.thanhPhoDataGridViewTextBoxColumn.DataPropertyName = "thanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.HeaderText = "thanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.Name = "thanhPhoDataGridViewTextBoxColumn";
            // 
            // giaTBDataGridViewTextBoxColumn
            // 
            this.giaTBDataGridViewTextBoxColumn.DataPropertyName = "giaTB";
            this.giaTBDataGridViewTextBoxColumn.HeaderText = "giaTB";
            this.giaTBDataGridViewTextBoxColumn.Name = "giaTBDataGridViewTextBoxColumn";
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "moTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "moTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            // 
            // ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboMaKS);
            this.Controls.Add(this.lblTHEMNHANVIENMOI);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblMaKS);
            this.Controls.Add(this.lblHovaTen);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.btn_ThemNhanVienMoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "ThemNhanVien";
            this.Text = "ThemNhanVien";
            this.Load += new System.EventHandler(this.ThemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet_KS_notin_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMaKS;
        private System.Windows.Forms.Label lblHovaTen;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btn_ThemNhanVienMoi;
        private System.Windows.Forms.Label lblTHEMNHANVIENMOI;
        private System.Windows.Forms.ComboBox cboMaKS;
        private DatKhachSanOnlineDataSet_KS_notin_NV datKhachSanOnlineDataSet_KS_notin_NV;
        private System.Windows.Forms.BindingSource khachSanBindingSource;
        private DatKhachSanOnlineDataSet_KS_notin_NVTableAdapters.KhachSanTableAdapter khachSanTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
    }
}