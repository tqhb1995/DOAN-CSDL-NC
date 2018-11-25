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
    public class KhachSanDAO
    {
        static SqlConnection conn;
        public static bool ThemKhachSan(KhachSanDTO ks)
        {
            try
            {
                string procname = "ThemKhachSan";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@tenKS", SqlDbType.NVarChar);
                cmd.Parameters.Add("@soSao", SqlDbType.Char);
                cmd.Parameters.Add("@soNha", SqlDbType.VarChar);
                cmd.Parameters.Add("@duong", SqlDbType.NVarChar);
                cmd.Parameters.Add("@quan", SqlDbType.NVarChar);
                cmd.Parameters.Add("@thanhPho", SqlDbType.NVarChar);
                cmd.Parameters.Add("@moTa", SqlDbType.NVarChar);
                cmd.Parameters.Add("@giaTB", SqlDbType.Int);

                //Truyền giá trị vào tham số.
                cmd.Parameters["@tenKS"].Value = ks.TenKS;
                cmd.Parameters["@soSao"].Value = ks.SoSao;
                cmd.Parameters["@soNha"].Value = ks.SoNha;
                cmd.Parameters["@duong"].Value = ks.Duong;
                cmd.Parameters["@quan"].Value = ks.Quan;
                cmd.Parameters["@thanhPho"].Value = ks.ThanhPho;
                cmd.Parameters["@moTa"].Value = ks.MoTa;
                cmd.Parameters["@giaTB"].Value = ks.GiaTB;


                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /*
        public static int KiemTraTonTai(KhachSanDTO temp)
        {
            int kq = 0;
            conn = DataProvider.OpenConnection();

            string sTruyVan3 = "select * from KhachHang where tenKS = '" + temp.TenKS + "' and  ";
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
        */
    }
}
