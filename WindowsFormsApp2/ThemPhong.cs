﻿using System;
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
    public partial class ThemPhong : Form
    {
        static SqlConnection conn;
        public ThemPhong()
        {
            InitializeComponent();
            LoadCbo();
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (cboLoaiPhong.Text == "" || txt_maphong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            PhongDTO p = new PhongDTO();
            p.LoaiPhong = cboLoaiPhong.Text;
            p.MaPhong = txt_maphong.Text;
            p.SoPhong = int.Parse(txt_sophong.Text);
            int temp = PhongBUS.KiemTra(p);
            if (temp == 1)
            {
                MessageBox.Show("Mã phòng đã tồn tại, vui lòng nhập mã phòng khác", "Thông báo");
                return;
            }
            else if (temp == 2)
            {
                MessageBox.Show("Mã loại phòng không tồn tại!", "Thông báo");
                return;
            }
            else
            {
                if (PhongBUS.ThemPhong(p))
                {
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");
            }

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVienQuanLy n = new NhanVienQuanLy();
            n.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachPhong dsp = new DanhSachPhong();
            dsp.ShowDialog();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (cboLoaiPhong.Text == "" || txt_maphong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            PhongDTO p = new PhongDTO();
            p.LoaiPhong = cboLoaiPhong.Text;
            p.MaPhong = txt_maphong.Text;
            p.SoPhong = int.Parse(txt_sophong.Text);
            int temp = PhongBUS.KiemTraSua(p);
            if (temp == 1)
            {
                MessageBox.Show("Mã phòng không tồn tại trong danh sách", "Thông báo");
                return;
            }
            else if (temp == 2)
            {
                MessageBox.Show("Mã loại phòng không tồn tại!", "Thông báo");
                return;
            }
            else
            {
                if (PhongBUS.SuaPhong(p))
                {
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");
            }

        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {
            conn = DataProvider.OpenConnection();
            string TruyVan = "select * from LoaiPhong where maKS = (select MaKS from NhanVien where tenDangNhap = '" + Program.username + ")' ";
            SqlCommand cmd = new SqlCommand(TruyVan, conn);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            DataTable dt = DataProvider.GetDataTable(TruyVan, conn);
            //txt_maloaiphong.Text = dt.Rows[0][1].ToString();

            DataProvider.CloseConnection(conn);
        }

        private void LoadCbo()
        {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
