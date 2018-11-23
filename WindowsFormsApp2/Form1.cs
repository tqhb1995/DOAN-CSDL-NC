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
    public partial class ForInsertNewCustomer : Form
    {
        //public static string settext = "";
        // static string settext1 = "";

        public ForInsertNewCustomer()
        {
            InitializeComponent();
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtCMND.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" || txtMoTa.Text == "" || txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (txtMatKhau.Text != txtXNMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp! \nVui lòng nhập lại!", "Thông báo");
                return;
            }
            KhachHangDTO kh = new KhachHangDTO();
            kh.HoTen = txtHoTen.Text;
            kh.SoCMND = txtCMND.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SoDienThoai = txtSDT.Text;
            kh.MoTa = txtMoTa.Text;
            kh.Email = txtEmail.Text;
            kh.TenDangNhap = txtTenDangNhap.Text;
            kh.MatKhau = txtMatKhau.Text;

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


            /*if (KhachHangBUS.ThemKhachHang(kh) == true)
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                settext1 = txtHoTen.Text;
                this.Hide();
                LoginBook frm = new LoginBook();
                frm.Show();            }
            else
                MessageBox.Show("Lỗi!!!");*/
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Trần Văn A")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor = Color.Black;
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Text = "Trần Văn A";
                txtHoTen.ForeColor = Color.Silver;
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "số 01, đường A, phường B, quận C, TP.D")
            {
                txtDiaChi.Text = "";
                txtDiaChi.ForeColor = Color.Black;
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Text = "số 01, đường A, phường B, quận C, TP.D";
                txtDiaChi.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "tranvana@xyz.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "tranvana@xyz.com";
                txtEmail.ForeColor = Color.Silver;
            }
        }
        private void ForInsertNewCustomer_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            txtXNMK.UseSystemPasswordChar = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Home frm = new Home();
            //frm.Show();
        }

        private void cboHienThi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!cboHienThi.Checked)
                txtMatKhau.UseSystemPasswordChar = true; //hide
            else txtMatKhau.UseSystemPasswordChar = false;
        }

        private void cboHienThi2_CheckedChanged(object sender, EventArgs e)
        {
            if (!cboHienThi2.Checked)
                txtXNMK.UseSystemPasswordChar = true; //hide
            else txtXNMK.UseSystemPasswordChar = false;
        }

        






        //private void cboTinhTP_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<string> lstAnGiang = new List<string>(new string[] { "Thành phố Long Xuyên", "Thị xã Châu Đốc", "Huyện An Phú", "Huyện Tân Châu", "Huyện Phú Tân", "Huyện Tịnh Biên", "Huyện Tri Tôn", "Huyện Châu Phú", "Huyện Chợ Mới", "Huyện Châu Thành", "Huyện Thoại Sơn" });

        //    List<string> lstQuanHN = new List<string>(new string[]{ "Quận Hoàn Kiếm","Quận Ba Đình", "Quận Đống Đa", "Quận Tây Hồ","Quận Cầu Giấy"});

        //    List<string> lstQuanDN = new List<string>(new string[]{ "Quận Hải Châu", "Quận Sơn Trà", "Quận Ngũ Hành Sơn"});

        //    List<string> lstQuanSG = new List<string>(new string[] { "Quận 1", "Quận 2", "Quận Thủ Đức", "Quận Bình Chánh", "Huyện Nhà Bè", "Huyện Cần Giờ", "Quyện Tân Bình", "Quận Tân Phú" });

        //    List<string> lstCanTho = new List<string>(new string[] { "Quận Bình Thủy", "Quận Cái Răng", "Quận Ninh Kiểu", "Quận Ô Môn", "Quận Thốt Nốt", "Huyện Cờ Đỏ", "Huyện Phong Điền", "Huyện Thới Lai", "H.Vĩnh Thạnh" });

        //    List<string> lstHaiPhong = new List<string>(new string[] { "Quận Hồng Bàng","Quận Lê Chân", "Quận Ngô Quyền", "Quận Kiến An", "Quận Hải An", "Quận Đồ Sơn", "Huyện An Lão", "Huyện Kiến Thuỵ", "Huyện Thủy Nguyên",
        //        "Huyện An Dương", "Huyên Tiên Lãng","Huyện Vĩnh Bảo", "Huyện Cát Hải", "Huyện Bạch Long Vĩ", "Quận Dương Kinh" });

        //    //List<string> lst = new List<string>(new string[] { });

        //    List<string> lstBRVT = new List<string>(new string[] { "Thành phố Vũng Tàu", "Thị xã Bà Rịa", "Huyện Xuyên Mộc", "Huyện Long Điền", "Huyện Côn Đảo", "Huyện Tân Thành", "Huyện Châu Đức", "Huyện Đất Đỏ" });

        //    List<string> lstBacGiang = new List<string>(new string[] {"Thành phố Bắc Giang", "Huyện Yên Thế", "Huyện Lục Ngạn", "Huyện Sơn Động", "Huyện Lục Nam", "Huyện Tân Yên", "Huyện Hiệp Hoà", "Huyện Lạng Giang", "Huyện Việt Yên", "Huyện Yên Dũng" });

        //    List<string> lstBacKan = new List<string>(new string[] {"Thị xã Bắc Kạn", "Huyện Chợ Đồn", "Huyện Bạch Thông", "Huyện Na Rì", "Huyện Ngân Sơn", "Huyện Ba Bể", "Huyện Chợ Mới", "Huyện Pác Nặm" });

        //    object[] lstQuan = null;
        //    switch (cboTinhTP.SelectedItem)
        //    {
        //        case "Cần Thơ":
        //            lstQuan = lstCanTho.ToArray();
        //            break;
        //        case "Đà Nẵng" : lstQuan = lstQuanDN.ToArray();
        //            break;
        //        case "Hải Phỏng":
        //            lstQuan = lstHaiPhong.ToArray();
        //            break;
        //        case "Hà Nội":
        //            lstQuan = lstQuanHN.ToArray();
        //            break;
        //        case "TP.HCM":
        //            lstQuan = lstQuanSG.ToArray();
        //            break;
        //        case "An Giang":
        //            lstQuan = lstAnGiang.ToArray();
        //            break;
        //        case "Bà Rịa - Vũng Tàu":
        //            lstQuan = lstBRVT.ToArray();
        //            break;
        //        case "Bắc Giang":
        //            lstQuan = lstBacGiang.ToArray();
        //            break;


        //    };

        //    cboQuanHuyen.Items.Clear(); 
        //    cboQuanHuyen.Items.AddRange(lstQuan); 
        //}





    }



}

