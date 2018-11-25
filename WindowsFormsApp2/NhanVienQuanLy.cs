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
            //Admin ad = new Admin();
            //ad.ShowDialog();
            this.Close();
        }
    }
}
