using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace DAO
{
    public class KhachHangDAO
    {
        static SqlConnection conn;
        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            try
            {
                string procname = "DangKiKH";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tenDangNhap", SqlDbType.VarChar);
                cmd.Parameters.Add("@matKhau", SqlDbType.VarChar);
                cmd.Parameters.Add("@soCMND", SqlDbType.VarChar);
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@soDienThoai", SqlDbType.VarChar);
                cmd.Parameters.Add("@moTa", SqlDbType.NVarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);

                //Truyền giá trị vào tham số.
                cmd.Parameters["@hoTen"].Value = kh.HoTen;
                cmd.Parameters["@tenDangNhap"].Value = kh.TenDangNhap;
                cmd.Parameters["@matKhau"].Value = kh.MatKhau;
                cmd.Parameters["@soCMND"].Value = kh.SoCMND;
                cmd.Parameters["@diaChi"].Value = kh.DiaChi;
                cmd.Parameters["@soDienThoai"].Value = kh.SoDienThoai;
                cmd.Parameters["@moTa"].Value = kh.MoTa;
                cmd.Parameters["@email"].Value = kh.Email;


                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool SuaKhachHang(KhachHangDTO kh)
        {
            try
            {
                string procname = "SuaKhachHang";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@makh", SqlDbType.Char);
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tendangnhap", SqlDbType.VarChar);
                cmd.Parameters.Add("@matkhau", SqlDbType.VarChar);
                cmd.Parameters.Add("@CMND", SqlDbType.VarChar);
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar);
                cmd.Parameters.Add("@sodienthoai", SqlDbType.VarChar);
                cmd.Parameters.Add("@moto", SqlDbType.NVarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);

                //Truyền giá trị vào tham số.
                cmd.Parameters["@makh"].Value = kh.MaKH;
                cmd.Parameters["@hoten"].Value = kh.HoTen;
                cmd.Parameters["@tendangnhap"].Value = kh.TenDangNhap;
                cmd.Parameters["@matkhau"].Value = kh.MatKhau;
                cmd.Parameters["@CMND"].Value = kh.SoCMND;
                cmd.Parameters["@diachi"].Value = kh.DiaChi;
                cmd.Parameters["@sodienthoai"].Value = kh.SoDienThoai;
                cmd.Parameters["@moto"].Value = kh.MoTa;
                cmd.Parameters["@email"].Value = kh.Email;


                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static int KiemTraTonTai(KhachHangDTO temp)
        {
            int kq = 0;
            conn = DataProvider.OpenConnection();

            string sTruyVan3 = "select * from KhachHang where tenDangNhap = '" + temp.TenDangNhap + "' ";
            SqlCommand cmd3 = new SqlCommand(sTruyVan3, conn);
            cmd3.Connection = conn;
            cmd3.ExecuteNonQuery();
            DataTable dt3 = DataProvider.GetDataTable(sTruyVan3, conn);
            if (dt3.Rows.Count > 0)
                kq = 4;

            string sTruyVan = "select * from KhachHang where soCMND = '" + temp.SoCMND + "' ";
            SqlCommand cmd = new SqlCommand(sTruyVan, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, conn);

            if (dt.Rows.Count > 0)
                kq = 1;

            string sTruyVan1 = "select * from KhachHang where email = '" + temp.Email + "' ";
            SqlCommand cmd1 = new SqlCommand(sTruyVan1, conn);
            cmd1.ExecuteNonQuery();
            DataTable dt1 = DataProvider.GetDataTable(sTruyVan1, conn);
            if (dt1.Rows.Count > 0)
                kq = 2;


            string sTruyVan2 = "select * from KhachHang where soDienThoai = '" + temp.SoDienThoai + "' ";
            SqlCommand cmd2 = new SqlCommand(sTruyVan2, conn);
            cmd2.Connection = conn;
            cmd2.ExecuteNonQuery();
            DataTable dt2 = DataProvider.GetDataTable(sTruyVan2, conn);
            if (dt2.Rows.Count > 0)
                kq = 3;


            DataProvider.CloseConnection(conn);
            return kq;
        }
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        /*
        public static KhachHangDTO DangNhap(KhachHangDTO khDTO)
        {
            string procname = "DangNhapHeThong";
            conn = DataProvider.OpenConnection();
            SqlCommand cmd = new SqlCommand(procname);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            //Truyền tham số.
            cmd.Parameters.Add("@tenDangNhap", SqlDbType.VarChar);
            cmd.Parameters.Add("@matKhau", SqlDbType.VarChar);
            //Truyền giá trị.
            cmd.Parameters["@tenDangNhap"].Value = khDTO.TenDangNhap;
            cmd.Parameters["@matKhau"].Value = khDTO.MatKhau;

            SqlDataReader dr = cmd.ExecuteReader();
            KhachHangDTO q = null;
            if (dr.Read())
            {
                q = new KhachHangDTO();
                q.MaKH = (String)dr["maKH"];
                q.HoTen = (String)dr["hoTen"];
                q.TenDangNhap = khDTO.TenDangNhap;
                q.MatKhau = khDTO.MatKhau;
                q.SoCMND = (String)dr["soCMND"];
                q.DiaChi = (String)dr["diaChi"];
                q.SoDienThoai = (String)dr["soDienThoai"];
                q.MoTa = (String)dr["moTa"];
                q.Email = (String)dr["email"];
            }
            DataProvider.CloseConnection(conn);
            return q;
        }
        */
        public static int KiemTraSua(KhachHangDTO temp)
        {
            int kq = 0;
            conn = DataProvider.OpenConnection();
            string sTruyVan = "select * from KhachHang where soCMND = '" + temp.SoCMND + "' and maKH != " + "'" + temp.MaKH + "' ";
            SqlCommand cmd = new SqlCommand(sTruyVan, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = DataProvider.GetDataTable(sTruyVan, conn);

            if (dt.Rows.Count > 0)
                kq = 1;

            string sTruyVan1 = "select * from KhachHang where email = '" + temp.Email + "' and maKH != " + "'" + temp.MaKH + "' ";
            SqlCommand cmd1 = new SqlCommand(sTruyVan1, conn);
            cmd1.ExecuteNonQuery();
            DataTable dt1 = DataProvider.GetDataTable(sTruyVan1, conn);
            if (dt1.Rows.Count > 0)
                kq = 2;


            string sTruyVan2 = "select * from KhachHang where soDienThoai = '" + temp.SoDienThoai + "' and maKH != " + "'" + temp.MaKH + "' ";
            SqlCommand cmd2 = new SqlCommand(sTruyVan2, conn);
            cmd2.Connection = conn;
            cmd2.ExecuteNonQuery();
            DataTable dt2 = DataProvider.GetDataTable(sTruyVan2, conn);
            if (dt2.Rows.Count > 0)
                kq = 3;


            DataProvider.CloseConnection(conn);
            return kq;
        }
    }
}
