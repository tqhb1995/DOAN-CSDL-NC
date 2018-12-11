namespace WindowsFormsApp2
{
    partial class ThemPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_maloaiphong = new System.Windows.Forms.TextBox();
            this.txt_sophong = new System.Windows.Forms.TextBox();
            this.thoat = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số phòng";
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(141, 8);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(261, 27);
            this.txt_maphong.TabIndex = 3;
            // 
            // txt_maloaiphong
            // 
            this.txt_maloaiphong.Location = new System.Drawing.Point(141, 41);
            this.txt_maloaiphong.Name = "txt_maloaiphong";
            this.txt_maloaiphong.Size = new System.Drawing.Size(261, 27);
            this.txt_maloaiphong.TabIndex = 4;
            // 
            // txt_sophong
            // 
            this.txt_sophong.Location = new System.Drawing.Point(141, 74);
            this.txt_sophong.Name = "txt_sophong";
            this.txt_sophong.Size = new System.Drawing.Size(261, 27);
            this.txt_sophong.TabIndex = 5;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(337, 178);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(65, 28);
            this.thoat.TabIndex = 6;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.them.Location = new System.Drawing.Point(264, 178);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(65, 28);
            this.them.TabIndex = 7;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sua.Location = new System.Drawing.Point(193, 178);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(65, 28);
            this.sua.TabIndex = 8;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Danh sách phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.txt_sophong);
            this.Controls.Add(this.txt_maloaiphong);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemPhong";
            this.Text = "ThemPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.TextBox txt_maloaiphong;
        private System.Windows.Forms.TextBox txt_sophong;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button button1;
    }
}