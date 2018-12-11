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
using DTO;

namespace WindowsFormsApp2
{
    

    public partial class TrangChu : Form
    {
        
        public TrangChu()
        {
            
            InitializeComponent();
            
        }
       
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_PassWord.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            SqlConnection conn;
            conn = DataProvider.OpenConnection();

            int temp;
            if (checkBoxNhanVien.Checked)
                temp = 1;
            else temp = 0;

            string proc = "DangNhapHeThong";
            SqlCommand cmd = new SqlCommand(proc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Connection = cn;
                cmd.Parameters.Add("@tenDangNhap", SqlDbType.NVarChar).Value = txt_UserName.Text;
                cmd.Parameters.Add("@matKhau", SqlDbType.VarChar).Value = txt_PassWord.Text;
                cmd.Parameters.Add("@isNhanVien", SqlDbType.Int).Value = temp;
                //Doc du lieu cua Procedure
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    MessageBox.Show("Đăng nhập thành công!\nXin chào " + (string)(reader[1]));
                    Program.username = txt_UserName.Text;
                    if (checkBoxNhanVien.Checked)
                    {
                      
                        this.Hide();
                        NhanVienQuanLy nvql = new NhanVienQuanLy();
                        nvql.ShowDialog();
                        DataProvider.CloseConnection(conn);
                        this.Close();
                    }
                    
                    else
                    {
                        if (txt_UserName.Text != "admin")
                        {
                            this.Hide();
                            TimKiemKhachSan tkks = new TimKiemKhachSan();
                            tkks.ShowDialog();
                            DataProvider.CloseConnection(conn);

                            this.Close();
                        }
                        
                        else
                        {
                            this.Hide();
                            Admin ad = new Admin();
                            ad.ShowDialog();
                            DataProvider.CloseConnection(conn);
                            this.Close();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không đúng.Vui lòng kiểm tra lại", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_PassWord.Text = "";
                    txt_UserName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKiKhachHang dkkh = new DangKiKhachHang();
            dkkh.ShowDialog();
            this.Close();
        }
    }
}
