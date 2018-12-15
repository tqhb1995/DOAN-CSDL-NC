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
    public partial class NhanVienQuanLy : Form
    {
        public NhanVienQuanLy()
        {
            InitializeComponent();
        }

        private void btnSuaKhachSan_Click(object sender, EventArgs e)
        {
            this.Hide();

            NhanVienQuanLy n = new NhanVienQuanLy();
            n.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
            this.Close();
            Program.username = "";
        }

        private void btnKiemTraTinhTrangPhong_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            KiemTraTinhTrangPhong tc = new KiemTraTinhTrangPhong();
            tc.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            frmLapHoaDon n = new frmLapHoaDon();
            n.ShowDialog();
            
        }

        private void btnDuyetPhong_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chưa cài đặt");
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemPhong a = new ThemPhong();
            a.Show();
            this.Close();
        }
    }
}
