using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class LoaiPhongDAO
    {
        static SqlConnection conn;
        public static bool ThemLoaiPhong(LoaiPhongDTO lp)
        {
            try
            {
                string procname = "ThemLoaiPhong";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@malp", SqlDbType.Char);
                cmd.Parameters.Add("@TenLP", SqlDbType.NVarChar);
                cmd.Parameters.Add("@MaKS", SqlDbType.Char);
                cmd.Parameters.Add("@DonGia", SqlDbType.Float);
                cmd.Parameters.Add("@sltrong", SqlDbType.Int);
                cmd.Parameters.Add("@mota", SqlDbType.NVarChar);
                //Truyền giá trị vào tham số.
                cmd.Parameters["@malp"].Value = lp.MaLoaiPhong;
                cmd.Parameters["@TenLP"].Value = lp.TenLoaiPhong;
                cmd.Parameters["@MaKS"].Value = lp.MaKS;
                cmd.Parameters["@DonGia"].Value = lp.DonGia;
                cmd.Parameters["@sltrong"].Value = lp.SlTrong;
                cmd.Parameters["@mota"].Value = lp.MoTa;

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool SuaLoaiPhong(LoaiPhongDTO lp)
        {
            try
            {
                string procname = "SuaLoaiPhong";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@malp", SqlDbType.Char);
                cmd.Parameters.Add("@TenLP", SqlDbType.NVarChar);
                cmd.Parameters.Add("@MaKS", SqlDbType.Char);
                cmd.Parameters.Add("@DonGia", SqlDbType.Float);
                cmd.Parameters.Add("@sltrong", SqlDbType.Int);
                cmd.Parameters.Add("@mota", SqlDbType.NVarChar);
                //Truyền giá trị vào tham số.
                cmd.Parameters["@malp"].Value = lp.MaLoaiPhong;
                cmd.Parameters["@TenLP"].Value = lp.TenLoaiPhong;
                cmd.Parameters["@MaKS"].Value = lp.MaKS;
                cmd.Parameters["@DonGia"].Value = lp.DonGia;
                cmd.Parameters["@sltrong"].Value = lp.SlTrong;
                cmd.Parameters["@mota"].Value = lp.MoTa;

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static int KiemTra(LoaiPhongDTO lp)
        {
            conn = DataProvider.OpenConnection();

            string que1 = "select * from LoaiPhong where maLoaiPhong = '" + lp.MaLoaiPhong + "' ";
            SqlCommand cmd1 = new SqlCommand(que1, conn);
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();
            DataTable dt1 = DataProvider.GetDataTable(que1, conn);
            if (dt1.Rows.Count > 0)
                return 1;
            string que2 = "select * from KhachSan where maKS = '" + lp.MaKS + "' ";
            SqlCommand cmd2 = new SqlCommand(que2, conn);
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();
            DataTable dt2 = DataProvider.GetDataTable(que2, conn);
            DataProvider.CloseConnection(conn);
            if (dt2.Rows.Count == 0)
                return 2;
            return 0;
            
        }

        public static int KiemTraSua(LoaiPhongDTO lp)
        {
            conn = DataProvider.OpenConnection();

            string que1 = "select * from LoaiPhong where maLoaiPhong = '" + lp.MaLoaiPhong + "' ";
            SqlCommand cmd1 = new SqlCommand(que1, conn);
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();
            DataTable dt1 = DataProvider.GetDataTable(que1, conn);
            if (dt1.Rows.Count == 0)
                return 1;
            string que2 = "select * from KhachSan where maKS = '" + lp.MaKS + "' ";
            SqlCommand cmd2 = new SqlCommand(que2, conn);
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();
            DataTable dt2 = DataProvider.GetDataTable(que2, conn);
            DataProvider.CloseConnection(conn);
            if (dt2.Rows.Count == 0)
                return 2;
            return 0;

        }

    }
}
