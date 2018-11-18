using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DataProvider
    {
        
        // Ket noi
        public static SqlConnection OpenConnection()
        {
            string connectionString = @"Data Source=DESKTOP-BIT0Q7A\SQLEXPRESS;Initial Catalog=DatKhachSanOnline;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // Dong ket noi
        public static void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }

        // Lay ket qua tra ve DataTable
        public static DataTable GetDataTable(string sTruyVan, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /*public DataTable LoadData()
        {
            string connectionString = @"Data Source=DESKTOP-BIT0Q7A\SQLEXPRESS;Initial Catalog=DatKhachSanOnline;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            OpenConnection();
            string procname = "TimKiemKhachSan";
            SqlCommand cmd = new SqlCommand(procname, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnection(conn);
            return dt;

        }
        public DataTable Timkiem(string sql, string ChuoiTimKiem)
        {
            string connectionString = @"Data Source=DESKTOP-BIT0Q7A\SQLEXPRESS;Initial Catalog=DatKhachSanOnline;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            OpenConnection();
            
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnection(conn);
            return dt;
        }*/
        
        public static DataTable taobang(string sql)
        {

            SqlConnection conn = OpenConnection();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;


        }

    }
}
