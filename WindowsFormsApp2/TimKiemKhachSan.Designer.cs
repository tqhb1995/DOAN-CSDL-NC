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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbPrice1 = new System.Windows.Forms.Label();
            this.lbPrice2 = new System.Windows.Forms.Label();
            this.lbSao = new System.Windows.Forms.Label();
            this.lbTP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(693, 22);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Quay lại";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(335, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
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
            this.groupBox1.Controls.Add(this.lbTP);
            this.groupBox1.Controls.Add(this.lbSao);
            this.groupBox1.Controls.Add(this.lbPrice2);
            this.groupBox1.Controls.Add(this.lbPrice1);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm khách sạn";
            // 
            // TimKiemKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiemKhachSan";
            this.Text = "TimKiemKhachSan";
            this.Load += new System.EventHandler(this.TimKiemKhachSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbPrice1;
        private System.Windows.Forms.Label lbPrice2;
        private System.Windows.Forms.Label lbSao;
        private System.Windows.Forms.Label lbTP;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}