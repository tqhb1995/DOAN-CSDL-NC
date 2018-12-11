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
    public partial class DSLoaiPhong : Form
    {
       
        public DSLoaiPhong()
        {
            InitializeComponent();
        }
        private void DSLoaiPhong_Load(object sender, EventArgs e)
        {

            SqlConnection conn;
            conn = DataProvider.OpenConnection();

            string que1 = "select * from LoaiPhong";
            SqlCommand cmd1 = new SqlCommand(que1, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            table.DataSource = dt1;
            DataProvider.CloseConnection(conn);
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}