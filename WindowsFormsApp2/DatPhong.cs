using BUS;
using DTO;
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
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            //if (txt == "" || txtCMND.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtMoTa.Text == "" || txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtDiaChi.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            //    return;
            //}

            //if (txtMatKhau.Text != txtXNMK.Text)
            //{
            //    MessageBox.Show("Mật khẩu không khớp! \nVui lòng nhập lại!", "Thông báo");
            //    return;
            //}
            KhachHangDTO kh = new KhachHangDTO();
            DatPhongDTO dp = new DatPhongDTO();
            LoaiPhongDTO lp = new LoaiPhongDTO();
            KhachSanDTO ks = new KhachSanDTO();

            ks.TenKS = txtTenKS.Text;
            ks.Quan = txtQuan.Text;
            ks.ThanhPho = txtTP.Text;
            lp.TenLoaiPhong = txtLP.Text;
            kh.SoDienThoai = txtSDT.Text;
            dp.NgayBatDau = this.dtpNgayBatDau.Text;
            dp.NgayTraPhong = this.dtpNgayTraPhong.Text;
            dp.MoTa = txtMoTa.Text;
            if (DatPhongBUS.DatPhong(dp) == true)
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
            //kh.HoTen = txtHoTen.Text;
            //kh.SoCMND = txtCMND.Text;
            //kh.DiaChi = txtDiaChi.Text;
            //kh.SoDienThoai = txtSDT.Text;
            //kh.MoTa = txtMoTa.Text;
            //kh.Email = txtEmail.Text;
            //kh.TenDangNhap = txtTenDangNhap.Text;
            //kh.MatKhau = txtMatKhau.Text;
        }

        private void btnHuyDP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
