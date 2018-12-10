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
    public class PhongDAO
    {
        static SqlConnection conn;
        public static bool ThemPhong(PhongDTO p)
        {
            try
            {
                string procname = "ThemPhong";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@mp", SqlDbType.Char);
                cmd.Parameters.Add("@lp", SqlDbType.Char);
                cmd.Parameters.Add("@sophong", SqlDbType.Int);
                //Truyền giá trị vào tham số.
                cmd.Parameters["@mp"].Value = p.MaPhong;
                cmd.Parameters["@lp"].Value = p.LoaiPhong;
                cmd.Parameters["@sophong"].Value = p.SoPhong;

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool SuaPhong(PhongDTO p)
        {
            try
            {
                string procname = "SuaPhong";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@ma", SqlDbType.Char);
                cmd.Parameters.Add("@lp", SqlDbType.Char);
                cmd.Parameters.Add("@sophong", SqlDbType.Int);
                //Truyền giá trị vào tham số.
                cmd.Parameters["@ma"].Value = p.MaPhong;
                cmd.Parameters["@lp"].Value = p.LoaiPhong;
                cmd.Parameters["@sophong"].Value = p.SoPhong;

                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static int KiemTra(PhongDTO p)
        {
            conn = DataProvider.OpenConnection();

            string que1 = "select * from Phong where maPhong = '" + p.MaPhong + "' ";
            SqlCommand cmd1 = new SqlCommand(que1, conn);
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();
            DataTable dt1 = DataProvider.GetDataTable(que1, conn);
            if (dt1.Rows.Count > 0)
                return 1;
            string que2 = "select * from LoaiPhong where maLoaiPhong = '" + p.LoaiPhong + "' ";
            SqlCommand cmd2 = new SqlCommand(que2, conn);
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();
            DataTable dt2 = DataProvider.GetDataTable(que2, conn);
            DataProvider.CloseConnection(conn);
            if (dt2.Rows.Count == 0)
                return 2;
            return 0;

        }

        public static int KiemTraSua(PhongDTO p)
        {
            conn = DataProvider.OpenConnection();

            string que1 = "select * from Phong where maPhong = '" + p.MaPhong + "' ";
            SqlCommand cmd1 = new SqlCommand(que1, conn);
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();
            DataTable dt1 = DataProvider.GetDataTable(que1, conn);
            if (dt1.Rows.Count == 0)
                return 1;
            string que2 = "select * from LoaiPhong where maLoaiPhong = '" + p.LoaiPhong + "' ";
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
