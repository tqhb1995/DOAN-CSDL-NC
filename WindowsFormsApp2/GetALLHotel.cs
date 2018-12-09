using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class GetALLHotel : Form
    {
        static SqlConnection conn;
        public GetALLHotel()
        {
            InitializeComponent();
        }

        private void ketnoicsdl()
        {
            conn = DataProvider.OpenConnection();
            string sql = "select * from KhachSan";  // lay het du lieu trong bang khách sạn
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            DataProvider.CloseConnection(conn);  // đóng kết nối
            dgvGetKS.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void GetALLHotel_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void dgvGetKS_Click(object sender, EventArgs e)
        {
            frmDatPhong frm = new frmDatPhong();

        }

        private void dgvGetKS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDatPhong frm = new frmDatPhong();

            frm.txtmaKS.Text = this.dgvGetKS.CurrentRow.Cells[0].Value.ToString();
            frm.txtTenKS.Text = this.dgvGetKS.CurrentRow.Cells[1].Value.ToString();
            frm.txtSoSao.Text = this.dgvGetKS.CurrentRow.Cells[2].Value.ToString();
            frm.txtSoNha.Text = this.dgvGetKS.CurrentRow.Cells[3].Value.ToString();
            frm.txtDuong.Text = this.dgvGetKS.CurrentRow.Cells[4].Value.ToString();
            frm.txtQuan.Text = this.dgvGetKS.CurrentRow.Cells[5].Value.ToString();
            frm.txtTP.Text = this.dgvGetKS.CurrentRow.Cells[6].Value.ToString();
            frm.txtGia.Text = this.dgvGetKS.CurrentRow.Cells[7].Value.ToString();
            this.Hide();
            frm.ShowDialog();
        }

    }
}
