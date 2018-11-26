using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace WindowsFormsApp2
{
    public partial class ThemKhachSan : Form
    {
        public ThemKhachSan()
        {
            InitializeComponent();
        }

        private void btnThemKS_Click(object sender, EventArgs e)
        {
            if (txtTenKS.Text == "" || txtSoSao.Text == "" || txtTP.Text == "" || txtQuan.Text == ""
                || txtDuong.Text == "" || txtMoTa.Text == "" || txtGiaTB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            KhachSanDTO ks = new KhachSanDTO();
            ks.TenKS = txtTenKS.Text;
            ks.SoSao = txtSoSao.Text;
            ks.ThanhPho = txtTP.Text;
            ks.Quan = txtQuan.Text;
            ks.Duong = txtDuong.Text;
            ks.SoNha = txtSoNha.Text;
            ks.GiaTB = Convert.ToInt32(txtGiaTB.Text);
            ks.MoTa = txtMoTa.Text;

            //int x = KhachSanBUS.KiemTraTonTai(ks);

            
            //if (x == 0)
                if (KhachSanBUS.ThemKhachSan(ks) == true)
                {
                    // KhachSanDTO p = new KhachSanDTO();
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    this.Hide();
                }
                else
                    MessageBox.Show("Lỗi, vui lòng thử lại! \n ", "Thông báo");


            /*if (KhachHangBUS.ThemKhachHang(kh) == true)
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                settext1 = txtHoTen.Text;
                this.Hide();
                LoginBook frm = new LoginBook();
                frm.Show();            }
            else
           
        }
    }

 
    }

    */
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.ShowDialog();
            this.Close();
        }
    }
}