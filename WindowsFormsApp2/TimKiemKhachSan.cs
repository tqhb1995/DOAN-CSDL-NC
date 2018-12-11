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
    public partial class TimKiemKhachSan : Form
    {
        public TimKiemKhachSan()
        {
            InitializeComponent();

        }

        private void TimKiemKhachSan_Load(object sender, EventArgs e)
        {
            loadSao();
            loadTP();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void loadSao()
        {
            DataTable dataSao = new DataTable();
            string query = "select distinct soSao from KhachSan";
            SqlConnection conn;
            conn = DataProvider.OpenConnection();
            SqlDataAdapter adapterSao = new SqlDataAdapter(query, conn);
            adapterSao.Fill(dataSao);

            cbSao.DataSource = dataSao;
            cbSao.DisplayMember = "soSao";

            cbSao.ResetText();
            cbSao.SelectedIndex = -1;

            DataProvider.CloseConnection(conn);
        }
        private void cbSao_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSao();
        }
        void loadTP()
        {
            DataTable data = new DataTable();
            string query = "select distinct thanhPho from KhachSan";
            SqlConnection conn;
            conn = DataProvider.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(data);

            cbCity.DataSource = data;
            cbCity.DisplayMember = "thanhPho";

            cbCity.ResetText();
            cbCity.SelectedIndex = -1;

            DataProvider.CloseConnection(conn);
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaKhachHang skh = new SuaKhachHang();
            skh.ShowDialog();
            this.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
            this.Close();
        }

        private void btSearch_Click_1(object sender, EventArgs e)
        {
            string procname = "search_KS";
            SqlConnection conn;
            conn = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand(procname, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (string.IsNullOrEmpty(tbPrice1.Text))
                cmd.Parameters.Add("@gia1", SqlDbType.Int).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@gia1", SqlDbType.Int).Value = int.Parse(tbPrice1.Text);
            if (string.IsNullOrEmpty(tbPrice2.Text))
                cmd.Parameters.Add("@gia2", SqlDbType.Int).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@gia2", SqlDbType.Int).Value = int.Parse(tbPrice2.Text);
            if (cbSao.SelectedIndex == -1)
                cmd.Parameters.Add("@sao", SqlDbType.VarChar).Value = DBNull.Value;
            else
            {
                string dataSao = this.cbSao.GetItemText(this.cbSao.SelectedItem);
                cmd.Parameters.Add("@sao", SqlDbType.VarChar).Value = dataSao;
            }

            if (cbCity.SelectedIndex == -1)
                cmd.Parameters.Add("@tp", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@tp", SqlDbType.NVarChar).Value = this.cbCity.GetItemText(this.cbCity.SelectedItem);



            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = data;

            DataProvider.CloseConnection(conn);
        }
    }
}
