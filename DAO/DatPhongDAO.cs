using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DatPhongDAO
    {
        static SqlConnection conn;
        public static bool DatPhongKhachSan(DatPhongDTO dp)
        {
            try
            {
                KhachSanDTO ks = new KhachSanDTO();
                LoaiPhongDTO lp = new LoaiPhongDTO();
                KhachHangDTO kh = new KhachHangDTO();
                string procname = "proc_DatPhong";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //Truyền tham số.
                cmd.Parameters.Add("@TenKS", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Quan", SqlDbType.NVarChar);
                cmd.Parameters.Add("@ThanhPho", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tenLoaiPhong", SqlDbType.VarChar);
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime);
                cmd.Parameters.Add("@NgayTraPhong", SqlDbType.DateTime);
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar);
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar);

                //Truyền giá trị vào tham số.
                cmd.Parameters["@TenKS"].Value = ks.TenKS;
                cmd.Parameters["@Quan"].Value = ks.Quan;
                cmd.Parameters["@ThanhPho"].Value = ks.ThanhPho;
                cmd.Parameters["@tenLoaiPhong"].Value = lp.TenLoaiPhong;
                cmd.Parameters["@NgayBatDau"].Value = dp.NgayBatDau;
                cmd.Parameters["@NgayTraPhong"].Value = dp.NgayTraPhong;
                cmd.Parameters["@MoTa"].Value = dp.MoTa;
                cmd.Parameters["@SDT"].Value = kh.SoDienThoai;


                cmd.ExecuteNonQuery();

                DataProvider.CloseConnection(conn);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
