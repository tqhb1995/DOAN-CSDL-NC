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
    public partial class TimKiemKhachSan : Form
    {
        public TimKiemKhachSan()
        {
            InitializeComponent();
        }

        private void TimKiemKhachSan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaKhachHang skh = new SuaKhachHang();
            skh.ShowDialog();
            this.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
            this.Close();
        }
    }
}
