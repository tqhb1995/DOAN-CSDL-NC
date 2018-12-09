using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using System.Data.SqlClient;
using BUS;
namespace WindowsFormsApp2
{
    public partial class frmLapHoaDon : Form
    {
        public frmLapHoaDon()
        {
            InitializeComponent();
        }
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            DatPhongDTO dp = new DatPhongDTO();

            dp.MaDP = txt_maDP.Text;
            string maHD = HoaDonBUS.HoaDon(dp);
            if (maHD != null)
            {
                SqlConnection conn1;
                conn1 = DataProvider.OpenConnection();
                string query = "SELECT * FROM HoaDon WHERE maHD = '" + maHD + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn1);
                //DataSet dtset = new DataSet("HoaDon");
                DataTable dt = new DataTable("HoaDon");
                da.Fill(dt);
                da.Dispose();
                DataProvider.CloseConnection(conn1);
                dataGridView1.DataSource = dt;
                //MessageBox.Show("Lập hóa đơn thành công!", "Thông báo");

                //this.Hide();
            }
            else
            {
                MessageBox.Show("Lỗi, vui lòng thử lại!\n", "Thông báo");
            }
        }

        private void btnThoatLapHD_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
