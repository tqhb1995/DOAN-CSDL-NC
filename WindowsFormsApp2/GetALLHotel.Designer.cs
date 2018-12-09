namespace WindowsFormsApp2
{
    partial class GetALLHotel
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
            this.dgvGetKS = new System.Windows.Forms.DataGridView();
            this.maKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetKS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGetKS
            // 
            this.dgvGetKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKS,
            this.tenKS,
            this.soSao,
            this.soNha,
            this.duong,
            this.quan,
            this.thanhPho,
            this.giaTB,
            this.moTa});
            this.dgvGetKS.Location = new System.Drawing.Point(12, 108);
            this.dgvGetKS.Name = "dgvGetKS";
            this.dgvGetKS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGetKS.Size = new System.Drawing.Size(943, 245);
            this.dgvGetKS.TabIndex = 1;
            this.dgvGetKS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGetKS_CellDoubleClick);
            // 
            // maKS
            // 
            this.maKS.DataPropertyName = "maKS";
            this.maKS.HeaderText = "Mã khách sạn";
            this.maKS.Name = "maKS";
            // 
            // tenKS
            // 
            this.tenKS.DataPropertyName = "tenKS";
            this.tenKS.HeaderText = "Tên KS";
            this.tenKS.Name = "tenKS";
            // 
            // soSao
            // 
            this.soSao.DataPropertyName = "soSao";
            this.soSao.HeaderText = "Số sao";
            this.soSao.Name = "soSao";
            // 
            // soNha
            // 
            this.soNha.DataPropertyName = "soNha";
            this.soNha.HeaderText = "Số nhà";
            this.soNha.Name = "soNha";
            // 
            // duong
            // 
            this.duong.DataPropertyName = "duong";
            this.duong.HeaderText = "Đường";
            this.duong.Name = "duong";
            // 
            // quan
            // 
            this.quan.DataPropertyName = "quan";
            this.quan.HeaderText = "Quận";
            this.quan.Name = "quan";
            // 
            // thanhPho
            // 
            this.thanhPho.DataPropertyName = "thanhPho";
            this.thanhPho.HeaderText = "Thành Phố";
            this.thanhPho.Name = "thanhPho";
            // 
            // giaTB
            // 
            this.giaTB.DataPropertyName = "giaTB";
            this.giaTB.HeaderText = "Giá TB";
            this.giaTB.Name = "giaTB";
            // 
            // moTa
            // 
            this.moTa.DataPropertyName = "moTa";
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            // 
            // GetALLHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 474);
            this.Controls.Add(this.dgvGetKS);
            this.Name = "GetALLHotel";
            this.Text = "GetALLHotel";
            this.Load += new System.EventHandler(this.GetALLHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetKS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGetKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSao;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn duong;
        private System.Windows.Forms.DataGridViewTextBoxColumn quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
    }
}