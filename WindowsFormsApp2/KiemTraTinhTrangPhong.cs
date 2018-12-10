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
            //LoadCbo();
        }

        private void LoadCbo()
        {
            //conn = DataProvider.OpenConnection();
            //string sql = "select * from LoaiPhong where maKS = (select maKS from NhanVien where tenDangNhap = ' " + cboLoaiPhong.ValueMember + "') ";
            //cboLoaiPhong.DataSource = DataProvider.GetDataTable(sql, conn);
            //cboLoaiPhong.DisplayMember = "maLoaiPhong";
            //cboLoaiPhong.ValueMember = "maLoaiPhong";
            //DataProvider.CloseConnection(conn);

            DataTable LP = LoaiPhongBUS.LoadDuLieuLoaiPhong(Program.username);
            cboLoaiPhong.DataSource = LP;
            //cboLoaiPhong.Items.Add(LP.)
            cboLoaiPhong.DisplayMember = "tenLoaiPhong";
            cboLoaiPhong.ValueMember = "maLoaiPhong";

        }

        private void LoadDGV()
        {

        }

        private void KiemTraTinhTrangPhong_Load(object sender, EventArgs e)
        {
            LoadCbo();
        }
    }
}
