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
using DAO;
using BUS;
using DTO;


namespace WindowsFormsApp2
{
    public partial class SuaKhachHang : Form
    {
        static SqlConnection conn;
        public SuaKhachHang()
        {
            InitializeComponent();
        }

        private void sua_Click(object sender, EventArgs e)
        {   

            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = txt_makhachhang.Text;
            kh.TenDangNhap = txt_tendangnhap.Text;
            kh.HoTen = txt_tenkhachhang.Text;
            kh.MatKhau = txt_matkhau.Text;
            kh.SoCMND = txt_socmnd.Text;
            kh.DiaChi = txt_diachi.Text;
            kh.SoDienThoai = txt_sodt.Text;
            kh.Email = txt_email.Text;
            kh.MoTa = txt_mota.Text;
            int x = KhachHangBUS.KiemTraSua(kh);
            if (KhachHangDAO.isEmail(txt_email.Text) == false)
            {
                MessageBox.Show("Email không đúng định dạng", "Thông báo");
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
                if (KhachHangBUS.SuaKhachHang(kh) == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");

        }

        private void SuaKhachHang_Load(object sender, EventArgs e)
        {

            conn = DataProvider.OpenConnection();
            string TruyVan = "select * from KhachHang where tenDangNhap = '" + Program.username + "' ";
            SqlCommand cmd = new SqlCommand(TruyVan, conn);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            DataTable dt = DataProvider.GetDataTable(TruyVan, conn);
            txt_makhachhang.Text = dt.Rows[0][0].ToString();
            txt_tenkhachhang.Text = dt.Rows[0][1].ToString();
            txt_tendangnhap.Text = dt.Rows[0][2].ToString();
            txt_matkhau.Text = dt.Rows[0][3].ToString();
            txt_socmnd.Text = dt.Rows[0][4].ToString();
            txt_diachi.Text = dt.Rows[0][5].ToString();
            txt_sodt.Text = dt.Rows[0][6].ToString();
            txt_mota.Text = dt.Rows[0][7].ToString();
            txt_email.Text = dt.Rows[0][8].ToString();
            DataProvider.CloseConnection(conn);

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimKiemKhachSan tk = new TimKiemKhachSan();
            tk.ShowDialog();
            this.Close();
        }
    }
}
