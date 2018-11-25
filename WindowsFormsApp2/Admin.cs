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
    }
}
