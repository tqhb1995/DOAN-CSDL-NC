using BUS;
using DTO;
using DAO;
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
namespace WindowsFormsApp2
{
    public partial class frmDatPhong : Form
    {
        static SqlConnection conn;
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            //txtmaKS.Text = maks;
            if (cboLP.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            //string sql = DataProvider.GetDataTable("SELECT maKH FROM KhachHang WHERE soDienThoai = '" + SoDienThoai + "'", conn);
            //frmDatPhong.maks = txtmaKS.Text;
            //frmDatPhong.makh = txtSDT.Text;

            KhachHangDTO kh = new KhachHangDTO();
            DatPhongDTO dp = new DatPhongDTO();
            KhachSanDTO ks = new KhachSanDTO();

            ks.MaKS = txtmaKS.Text;
            dp.MaLoaiPhong = cboLP.Text;
            kh.SoDienThoai = txtSDT.Text;
            dp.NgayBatDau = this.dtpNgayBatDau.Text;
            dp.NgayTraPhong = this.dtpNgayTraPhong.Text;
            dp.MoTa = txtMoTa.Text;

            int x = DatPhongBUS.KiemTraTonTai(kh);

            if (x == 0)
            {
                MessageBox.Show("Khách hàng không tồn tại.\nKhông thể thêm mới.", "Thông báo");
                return;
            }

            if (x == 1)
            {
                if (DatPhongBUS.DatPhong(dp, ks, kh) == true)
                {
                    MessageBox.Show("Đặt phòng thành công!\n Cảm ơn bạn đã sử dụng dịch vụ!", "Thông báo");
                    this.Close();
                    TimKiemKhachSan n = new TimKiemKhachSan();
                    n.Show();
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");
                    TimKiemKhachSan n = new TimKiemKhachSan();
                    n.Show();
                }
            }
        }

        private void btnHuyDP_Click(object sender, EventArgs e)
        {
            Close();
            TimKiemKhachSan n = new TimKiemKhachSan();
            n.Show();
            Hide();
           
            
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            conn = DataProvider.OpenConnection();
            string sql = "select * from LoaiPhong";
            cboLP.DataSource = DataProvider.GetDataTable(sql, conn);
            cboLP.DisplayMember = "maLoaiPhong";
            cboLP.ValueMember = "maLoaiPhong";
            DataProvider.CloseConnection(conn);
            //disable
            txtmaKS.Enabled = false;
            txtTenKS.Enabled = false;
            txtSoSao.Enabled = false;
            txtSoNha.Enabled = false;
            txtDuong.Enabled = false;
            txtQuan.Enabled = false;
            txtTP.Enabled = false;
            txtGia.Enabled = false;
            // txtmaKS.Text = maks;
        }

        private void linkLoaiPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chưa  cài đặt");
        }
    }
}
