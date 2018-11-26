using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;


namespace WindowsFormsApp2
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btn_ThemNhanVienMoi_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || cboMaKS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            /*
            if (txtMatKhau.Text != txtXNMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp! \nVui lòng nhập lại!", "Thông báo");
                return;
            }
            */
            string s = cboMaKS.Text;

            NhanVienDTO nv = new NhanVienDTO();
            nv.HoTen = txtHoTen.Text;
            nv.TenDangNhap = txtTenDangNhap.Text;
            nv.MatKhau = txtMatKhau.Text;
            nv.MaKS = s;

            int x = NhanVienBUS.KiemTraTonTai(nv);

            if (x == 1)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.\nKhông thể thêm mới.", "Thông báo");
                return;
            }

            if (x == 0)
                if (NhanVienBUS.ThemNhanVien(nv) == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    this.Close();
                    
                }
                else
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");

        }

        private void cboMaKS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datKhachSanOnlineDataSet.KhachSan1' table. You can move, or remove it, as needed.
            this.khachSan1TableAdapter.Fill(this.datKhachSanOnlineDataSet.KhachSan1);

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.ShowDialog();
            this.Close();
        }
    }
}
