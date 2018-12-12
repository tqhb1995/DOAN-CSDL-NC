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
using DAO;

namespace WindowsFormsApp2
{
    public partial class KiemTraTinhTrangPhong : Form
    {
        static SqlConnection conn;
        public KiemTraTinhTrangPhong()
        {
            InitializeComponent();
            LoadCbo();
        }

        private void LoadCbo()
        { /*
            DataTable LP = LoaiPhongBUS.LoadDuLieuLoaiPhong(Program.username);
            cboLoaiPhong.DataSource = LP;
            //cboLoaiPhong.Items.Add(LP.)
            cboLoaiPhong.DisplayMember = "tenLoaiPhong";
            cboLoaiPhong.ValueMember = "maLoaiPhong";
            */
            DataTable data = new DataTable();
            string query = "select distinct tenLoaiPhong from LoaiPhong";
            SqlConnection conn;
            conn = DataProvider.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(data);

            cboLoaiPhong.DataSource = data;
            cboLoaiPhong.DisplayMember = "tenLoaiPhong";

            cboLoaiPhong.ResetText();
            cboLoaiPhong.SelectedIndex = -1;

            DataProvider.CloseConnection(conn);
            
        }

        private void KiemTraTinhTrangPhong_Load(object sender, EventArgs e)
        {
            LoadCbo();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hide();
            NhanVienQuanLy n = new NhanVienQuanLy();
            n.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            string procname = "KiemTraTinhTrangPhong";
            SqlConnection conn;
            conn = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand(procname, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            string TruyVan = "select * from NhanVien where tenDangNhap = '" + Program.username + "' ";
            SqlCommand command = new SqlCommand(TruyVan, conn);
            command.Connection = conn;
            command.ExecuteNonQuery();
            DataTable dt = DataProvider.GetDataTable(TruyVan, conn);

            cmd.Parameters.Add("@manv", SqlDbType.Char).Value = dt.Rows[0][0].ToString();
            cmd.Parameters.Add("@tenloaiphong", SqlDbType.NVarChar).Value = this.cboLoaiPhong.GetItemText(this.cboLoaiPhong.SelectedItem);
            cmd.Parameters.Add("@ngaydat", SqlDbType.DateTime).Value = dtpNgay.Value;

            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);

            viewPhongTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewPhongTrong.DataSource = data;

            DataProvider.CloseConnection(conn);
        }

        private void cboLoaiPhong_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
