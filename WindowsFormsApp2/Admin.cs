using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonThemMoiNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemNhanVien tnv = new ThemNhanVien();
            tnv.ShowDialog();
            this.Close();

        }

        private void btnThemKS_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemKhachSan tnv = new ThemKhachSan();
            tnv.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datKhachSanOnlineDataSet_All_NV.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.datKhachSanOnlineDataSet_All_NV.NhanVien);
            // TODO: This line of code loads data into the 'datKhachSanOnlineDataSet_All_KS.KhachSan' table. You can move, or remove it, as needed.
            this.khachSanTableAdapter1.Fill(this.datKhachSanOnlineDataSet_All_KS.KhachSan);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
