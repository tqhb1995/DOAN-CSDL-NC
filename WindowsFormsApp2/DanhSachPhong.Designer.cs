﻿namespace WindowsFormsApp2
{
    partial class DanhSachPhong
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
            this.table = new System.Windows.Forms.DataGridView();
            this.Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(13, 58);
            this.table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(433, 498);
            this.table.TabIndex = 0;
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(269, 570);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(177, 51);
            this.Thoat.TabIndex = 1;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách phòng:";
            // 
            // DanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DanhSachPhong";
            this.Text = "DanhSachPhong";
            this.Load += new System.EventHandler(this.DanhSachPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label label1;
    }
}