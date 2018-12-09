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
    public class HoaDonDAO
    {
        public static string lapHoaDon(DatPhongDTO dp)
        {

            try
            {
                SqlConnection conn;
                conn = DataProvider.OpenConnection();
                string procname = "lapHoaDon";
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;


                cmd.Parameters.Add("@maDP", SqlDbType.Char, 10);
                cmd.Parameters.Add(new SqlParameter("@maHD", SqlDbType.Char, 10));

                cmd.Parameters["@maDP"].Value = dp.MaDP;
                cmd.Parameters["@maHD"].Direction = ParameterDirection.Output;

                cmd.Parameters["@maHD"].Value = "";

                cmd.ExecuteNonQuery();
                DataProvider.CloseConnection(conn);

                string maHD = cmd.Parameters["@maHD"].Value.ToString();
                return maHD;
            }
            catch (Exception ex)
            {

                return null;
                //throw ex;
            }
        }
    }
}
