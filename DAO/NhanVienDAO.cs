using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class NhanVienDAO
    {
        static SqlConnection conn;
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            try
            {
                string procname = "ThemNhanVien";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tenDangNhap", SqlDbType.VarChar);
                cmd.Parameters.Add("@matKhau", SqlDbType.VarChar);
                cmd.Parameters.Add("@maKS", SqlDbType.Char);

                //Truyền giá trị vào tham số.
                cmd.Parameters["@hoTen"].Value = nv.HoTen;
                cmd.Parameters["@tenDangNhap"].Value = nv.TenDangNhap;
                cmd.Parameters["@matnvau"].Value = nv.MatKhau;
                cmd.Parameters["@maKS"].Value = nv.MaKS;

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
        public static int KiemTraTonTai(NhanVienDTO temp)
        {
            int kq = 0;
            conn = DataProvider.OpenConnection();

            string sTruyVan3 = "select * from NhanVien where tenDangNhap = '" + temp.TenDangNhap + "' ";
            SqlCommand cmd3 = new SqlCommand(sTruyVan3, conn);
            cmd3.Connection = conn;
            cmd3.ExecuteNonQuery();
            DataTable dt3 = DataProvider.GetDataTable(sTruyVan3, conn);
            if (dt3.Rows.Count > 0)
                kq = 1;

            DataProvider.CloseConnection(conn);
            return kq;
        }
        

    }

    

}
