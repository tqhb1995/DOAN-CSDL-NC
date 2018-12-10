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
    public partial class SuaKhachHang : Form
    {
        public SuaKhachHang()
        {
            InitializeComponent();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (txt_tenkhachhang.Text == "" || txt_socmnd.Text == "" || txt_sodt.Text == "" || txt_email.Text == "" || txt_tendangnhap.Text == "" || txt_matkhau.Text == "" || txt_xacnhanmk.Text == "") 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (txt_matkhau.Text != txt_xacnhanmk.Text)
            {
                MessageBox.Show("Mật khẩu không khớp! \nVui lòng nhập lại!", "Thông báo");
                return;
            }
            KhachHangDTO kh = new KhachHangDTO();
            //kh.HoTen = txtHoTen.Text;
            //kh.SoCMND = txtCMND.Text;
            //kh.DiaChi = txtDiaChi.Text;
            //kh.SoDienThoai = txtSDT.Text;
            //kh.MoTa = txtMoTa.Text;
            //kh.Email = txtEmail.Text;
            //kh.TenDangNhap = txtTenDangNhap.Text;
            //kh.MatKhau = txtMatKhau.Text;

            int x = KhachHangBUS.KiemTraTonTai(kh);

            if (x == 4)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.\nKhông thể đăng kí.", "Thông báo");
                return;
            }
            if (x == 1)
            {
                MessageBox.Show("Số CMND đã tồn tại.\nKhông thể đăng kí.", "Thông báo");
                return;
            }
            if (x == 2)
            {
                MessageBox.Show("Email đã tồn tại.\nKhông thể đăng kí.", "Thông báo");
                return;
            }
            if (x == 3)
            {
                MessageBox.Show("Số điện thoại đã tồn tại.\nKhông thể đăng kí.", "Thông báo");
                return;
            }

            if (x == 0)
                if (KhachHangBUS.ThemKhachHang(kh) == true)
                {
                    // KhachHangDTO p = new KhachHangDTO();
                    MessageBox.Show("Đăng kí thành công!", "Thông báo");
                    //settext = p.MaKH;
                    //settext1 = p.HoTen;
                    this.Hide();
                    // DangNhap frm = new DangNhap();
                    //frm.Show();
                }
                else
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");

        }
    }
}
