namespace WindowsFormsApp2
{
    partial class Admin
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
            this.buttonThemMoiNhanVien = new System.Windows.Forms.Button();
            this.btnThemKS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl_Admin = new System.Windows.Forms.TabControl();
            this.tabPage_NV = new System.Windows.Forms.TabPage();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dataGridView_NV = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datKhachSanOnlineDataSet_All_NV = new WindowsFormsApp2.DatKhachSanOnlineDataSet_All_NV();
            this.tabPage_KS = new System.Windows.Forms.TabPage();
            this.dataGridView_KS = new System.Windows.Forms.DataGridView();
            this.maKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachSanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.datKhachSanOnlineDataSet_All_KS = new WindowsFormsApp2.DatKhachSanOnlineDataSet_All_KS();
            this.khachSanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.datKhachSanOnlineDataSet = new WindowsFormsApp2.DatKhachSanOnlineDataSet();
            this.datKhachSanOnlineDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachSanTableAdapter = new WindowsFormsApp2.DatKhachSanOnlineDataSetTableAdapters.KhachSanTableAdapter();
            this.datKhachSanOnlineDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khachSanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khachSanTableAdapter1 = new WindowsFormsApp2.DatKhachSanOnlineDataSet_All_KSTableAdapters.KhachSanTableAdapter();
            this.nhanVienTableAdapter = new WindowsFormsApp2.DatKhachSanOnlineDataSet_All_NVTableAdapters.NhanVienTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_Admin.SuspendLayout();
            this.tabPage_NV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet_All_NV)).BeginInit();
            this.tabPage_KS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet_All_KS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThemMoiNhanVien
            // 
            this.buttonThemMoiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMoiNhanVien.Location = new System.Drawing.Point(351, 10);
            this.buttonThemMoiNhanVien.Name = "buttonThemMoiNhanVien";
            this.buttonThemMoiNhanVien.Size = new System.Drawing.Size(168, 26);
            this.buttonThemMoiNhanVien.TabIndex = 1;
            this.buttonThemMoiNhanVien.Text = "Thêm mới nhân viên";
            this.buttonThemMoiNhanVien.UseVisualStyleBackColor = true;
            this.buttonThemMoiNhanVien.Click += new System.EventHandler(this.buttonThemMoiNhanVien_Click);
            // 
            // btnThemKS
            // 
            this.btnThemKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKS.Location = new System.Drawing.Point(348, 15);
            this.btnThemKS.Name = "btnThemKS";
            this.btnThemKS.Size = new System.Drawing.Size(180, 26);
            this.btnThemKS.TabIndex = 1;
            this.btnThemKS.Text = "Thêm khách sạn mới";
            this.btnThemKS.UseVisualStyleBackColor = true;
            this.btnThemKS.Click += new System.EventHandler(this.btnThemKS_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(751, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl_Admin
            // 
            this.tabControl_Admin.Controls.Add(this.tabPage_NV);
            this.tabControl_Admin.Controls.Add(this.tabPage_KS);
            this.tabControl_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Admin.Location = new System.Drawing.Point(12, 1);
            this.tabControl_Admin.Name = "tabControl_Admin";
            this.tabControl_Admin.SelectedIndex = 0;
            this.tabControl_Admin.Size = new System.Drawing.Size(854, 327);
            this.tabControl_Admin.TabIndex = 3;
            // 
            // tabPage_NV
            // 
            this.tabPage_NV.Controls.Add(this.txtTimKiem);
            this.tabPage_NV.Controls.Add(this.lblTimKiem);
            this.tabPage_NV.Controls.Add(this.dataGridView_NV);
            this.tabPage_NV.Controls.Add(this.buttonThemMoiNhanVien);
            this.tabPage_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_NV.Location = new System.Drawing.Point(4, 29);
            this.tabPage_NV.Name = "tabPage_NV";
            this.tabPage_NV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NV.Size = new System.Drawing.Size(846, 294);
            this.tabPage_NV.TabIndex = 1;
            this.tabPage_NV.Text = "Nhân Viên";
            this.tabPage_NV.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(84, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(236, 26);
            this.txtTimKiem.TabIndex = 4;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(6, 13);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(71, 20);
            this.lblTimKiem.TabIndex = 3;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // dataGridView_NV
            // 
            this.dataGridView_NV.AutoGenerateColumns = false;
            this.dataGridView_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.maKSDataGridViewTextBoxColumn1});
            this.dataGridView_NV.DataSource = this.nhanVienBindingSource;
            this.dataGridView_NV.Location = new System.Drawing.Point(7, 53);
            this.dataGridView_NV.Name = "dataGridView_NV";
            this.dataGridView_NV.Size = new System.Drawing.Size(580, 210);
            this.dataGridView_NV.TabIndex = 2;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "maNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "maNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "tenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "tenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "matKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "matKhau";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // maKSDataGridViewTextBoxColumn1
            // 
            this.maKSDataGridViewTextBoxColumn1.DataPropertyName = "maKS";
            this.maKSDataGridViewTextBoxColumn1.HeaderText = "maKS";
            this.maKSDataGridViewTextBoxColumn1.Name = "maKSDataGridViewTextBoxColumn1";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.datKhachSanOnlineDataSet_All_NV;
            // 
            // datKhachSanOnlineDataSet_All_NV
            // 
            this.datKhachSanOnlineDataSet_All_NV.DataSetName = "DatKhachSanOnlineDataSet_All_NV";
            this.datKhachSanOnlineDataSet_All_NV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage_KS
            // 
            this.tabPage_KS.Controls.Add(this.textBox1);
            this.tabPage_KS.Controls.Add(this.label1);
            this.tabPage_KS.Controls.Add(this.dataGridView_KS);
            this.tabPage_KS.Controls.Add(this.btnThemKS);
            this.tabPage_KS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_KS.Location = new System.Drawing.Point(4, 29);
            this.tabPage_KS.Name = "tabPage_KS";
            this.tabPage_KS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_KS.Size = new System.Drawing.Size(846, 294);
            this.tabPage_KS.TabIndex = 0;
            this.tabPage_KS.Text = "Khách Sạn";
            this.tabPage_KS.UseVisualStyleBackColor = true;
            // 
            // dataGridView_KS
            // 
            this.dataGridView_KS.AutoGenerateColumns = false;
            this.dataGridView_KS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKSDataGridViewTextBoxColumn,
            this.tenKSDataGridViewTextBoxColumn,
            this.soSaoDataGridViewTextBoxColumn,
            this.soNhaDataGridViewTextBoxColumn,
            this.duongDataGridViewTextBoxColumn,
            this.quanDataGridViewTextBoxColumn,
            this.thanhPhoDataGridViewTextBoxColumn,
            this.giaTBDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn});
            this.dataGridView_KS.DataSource = this.khachSanBindingSource3;
            this.dataGridView_KS.Location = new System.Drawing.Point(6, 71);
            this.dataGridView_KS.Name = "dataGridView_KS";
            this.dataGridView_KS.Size = new System.Drawing.Size(844, 235);
            this.dataGridView_KS.TabIndex = 3;
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
            // khachSanBindingSource3
            // 
            this.khachSanBindingSource3.DataMember = "KhachSan";
            this.khachSanBindingSource3.DataSource = this.datKhachSanOnlineDataSet_All_KS;
            // 
            // datKhachSanOnlineDataSet_All_KS
            // 
            this.datKhachSanOnlineDataSet_All_KS.DataSetName = "DatKhachSanOnlineDataSet_All_KS";
            this.datKhachSanOnlineDataSet_All_KS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachSanBindingSource2
            // 
            this.khachSanBindingSource2.DataMember = "KhachSan";
            this.khachSanBindingSource2.DataSource = this.datKhachSanOnlineDataSet_All_KS;
            // 
            // datKhachSanOnlineDataSet
            // 
            this.datKhachSanOnlineDataSet.DataSetName = "DatKhachSanOnlineDataSet";
            this.datKhachSanOnlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datKhachSanOnlineDataSetBindingSource
            // 
            this.datKhachSanOnlineDataSetBindingSource.DataSource = this.datKhachSanOnlineDataSet;
            this.datKhachSanOnlineDataSetBindingSource.Position = 0;
            // 
            // khachSanBindingSource
            // 
            this.khachSanBindingSource.DataMember = "KhachSan";
            this.khachSanBindingSource.DataSource = this.datKhachSanOnlineDataSetBindingSource;
            // 
            // khachSanTableAdapter
            // 
            this.khachSanTableAdapter.ClearBeforeFill = true;
            // 
            // datKhachSanOnlineDataSetBindingSource1
            // 
            this.datKhachSanOnlineDataSetBindingSource1.DataSource = this.datKhachSanOnlineDataSet;
            this.datKhachSanOnlineDataSetBindingSource1.Position = 0;
            // 
            // khachSanBindingSource1
            // 
            this.khachSanBindingSource1.DataMember = "KhachSan";
            this.khachSanBindingSource1.DataSource = this.datKhachSanOnlineDataSet_All_KS;
            // 
            // khachSanTableAdapter1
            // 
            this.khachSanTableAdapter1.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 370);
            this.Controls.Add(this.tabControl_Admin);
            this.Controls.Add(this.button1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl_Admin.ResumeLayout(false);
            this.tabPage_NV.ResumeLayout(false);
            this.tabPage_NV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet_All_NV)).EndInit();
            this.tabPage_KS.ResumeLayout(false);
            this.tabPage_KS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet_All_KS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datKhachSanOnlineDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachSanBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonThemMoiNhanVien;
        private System.Windows.Forms.Button btnThemKS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl_Admin;
        private System.Windows.Forms.TabPage tabPage_KS;
        private System.Windows.Forms.TabPage tabPage_NV;
        private System.Windows.Forms.BindingSource datKhachSanOnlineDataSetBindingSource;
        private DatKhachSanOnlineDataSet datKhachSanOnlineDataSet;
        private System.Windows.Forms.BindingSource khachSanBindingSource;
        private DatKhachSanOnlineDataSetTableAdapters.KhachSanTableAdapter khachSanTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_KS;
        private System.Windows.Forms.BindingSource datKhachSanOnlineDataSetBindingSource1;
        private DatKhachSanOnlineDataSet_All_KS datKhachSanOnlineDataSet_All_KS;
        private System.Windows.Forms.BindingSource khachSanBindingSource1;
        private DatKhachSanOnlineDataSet_All_KSTableAdapters.KhachSanTableAdapter khachSanTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource khachSanBindingSource2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private System.Windows.Forms.BindingSource khachSanBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView_NV;
        private DatKhachSanOnlineDataSet_All_NV datKhachSanOnlineDataSet_All_NV;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DatKhachSanOnlineDataSet_All_NVTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}