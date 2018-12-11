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
    public partial class AddLoaiPhong : Form
    {
        public AddLoaiPhong()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (txt_MaLP.Text == "" || txt_Maks.Text == "" || txt_Dongia.Text == "" || txt_TenLP.Text == "" || txt_Sltrong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            LoaiPhongDTO lp = new LoaiPhongDTO();
            lp.MaLoaiPhong = txt_MaLP.Text;
            lp.MaKS = txt_Maks.Text;
            lp.DonGia = float.Parse(txt_Dongia.Text);
            lp.TenLoaiPhong = txt_TenLP.Text;
            lp.SlTrong = int.Parse(txt_Sltrong.Text);
            lp.MoTa = txt_Mota.Text;
            int temp = LoaiPhongBUS.KiemTra(lp);
            if (temp == 1)
            {
                MessageBox.Show("Mã loại phòng đã tồn tại, vui lòng nhập mã loại phòng khác", "Thông báo");
                return;
            }
            else if (temp == 2) 
            {
                MessageBox.Show("Mã khách sạn không tồn tại!", "Thông báo");
                return;
            }
            else
            {
                if (LoaiPhongBUS.ThemLoaiPhong(lp))
                {
                    MessageBox.Show("Thêm loại phòng thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");
            }

        }

        private void AddLoaiPhong_Load(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dsLoaiphong_Click(object sender, EventArgs e)
        {
            DSLoaiPhong dslp = new DSLoaiPhong();
            dslp.ShowDialog();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaLP.Text == "" || txt_Maks.Text == "" || txt_Dongia.Text == "" || txt_TenLP.Text == "" || txt_Sltrong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            LoaiPhongDTO lp = new LoaiPhongDTO();
            lp.MaLoaiPhong = txt_MaLP.Text;
            lp.MaKS = txt_Maks.Text;
            lp.DonGia = float.Parse(txt_Dongia.Text);
            lp.TenLoaiPhong = txt_TenLP.Text;
            lp.SlTrong = int.Parse(txt_Sltrong.Text);
            lp.MoTa = txt_Mota.Text;
            int temp = LoaiPhongBUS.KiemTraSua(lp);
            if (temp == 1)
            {
                MessageBox.Show("Mã loại phòng không tồn tại trong danh sách", "Thông báo");
                return;
            }
            else if (temp == 2)
            {
                MessageBox.Show("Mã khách sạn không tồn tại!", "Thông báo");
                return;
            }
            else
            {
                if (LoaiPhongBUS.SuaLoaiPhong(lp))
                {
                    MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo");
                }
                else
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");
            }

        }
    }
}
