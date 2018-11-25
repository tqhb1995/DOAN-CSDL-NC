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
            this.labelAdmin = new System.Windows.Forms.Label();
            this.buttonThemMoiNhanVien = new System.Windows.Forms.Button();
            this.btnThemKS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(101, 19);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(244, 25);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "QUẢN TRỊ HỆ THỐNG";
            // 
            // buttonThemMoiNhanVien
            // 
            this.buttonThemMoiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMoiNhanVien.Location = new System.Drawing.Point(12, 72);
            this.buttonThemMoiNhanVien.Name = "buttonThemMoiNhanVien";
            this.buttonThemMoiNhanVien.Size = new System.Drawing.Size(164, 27);
            this.buttonThemMoiNhanVien.TabIndex = 1;
            this.buttonThemMoiNhanVien.Text = "Thêm mới nhân viên";
            this.buttonThemMoiNhanVien.UseVisualStyleBackColor = true;
            this.buttonThemMoiNhanVien.Click += new System.EventHandler(this.buttonThemMoiNhanVien_Click);
            // 
            // btnThemKS
            // 
            this.btnThemKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKS.Location = new System.Drawing.Point(264, 72);
            this.btnThemKS.Name = "btnThemKS";
            this.btnThemKS.Size = new System.Drawing.Size(218, 26);
            this.btnThemKS.TabIndex = 1;
            this.btnThemKS.Text = "Thêm khách sạn mới";
            this.btnThemKS.UseVisualStyleBackColor = true;
            this.btnThemKS.Click += new System.EventHandler(this.btnThemKS_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemKS);
            this.Controls.Add(this.buttonThemMoiNhanVien);
            this.Controls.Add(this.labelAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button buttonThemMoiNhanVien;
        private System.Windows.Forms.Button btnThemKS;
    }
}