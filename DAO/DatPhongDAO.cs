using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DatPhongDAO
    {
        static SqlConnection conn;
        public static bool DatPhong(DatPhongDTO dp, KhachSanDTO ks, KhachHangDTO kh)
        {
            try
            {
                string procname = "proc_DatPhong";
                conn = DataProvider.OpenConnection();
                SqlCommand cmd = new SqlCommand(procname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                //-----------------------------------



                //Truyền tham số.
                cmd.Parameters.Add("@maKS", SqlDbType.VarChar);
                cmd.Parameters.Add("@maLoaiPhong", SqlDbType.VarChar);
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime);
                cmd.Parameters.Add("@NgayTraPhong", SqlDbType.DateTime);
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar);
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar);

                //Truyền giá trị vào tham số.
                cmd.Parameters["@maKS"].Value = ks.MaKS;
                cmd.Parameters["@maLoaiPhong"].Value = dp.MaLoaiPhong;
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
        public static int KiemTraTonTai(KhachHangDTO temp)
        {
            int kq = 0;
            conn = DataProvider.OpenConnection();

            string sTruyVan3 = "select * from KhachHang where soDienThoai = '" + temp.SoDienThoai + "' ";
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
