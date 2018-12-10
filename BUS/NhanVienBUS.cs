using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        public static bool ThemNhanVien(NhanVienDTO nv)
        {

            return NhanVienDAO.ThemNhanVien(nv);
        }
        
        public static int KiemTraTonTai(NhanVienDTO temp)
        {
            return NhanVienDAO.KiemTraTonTai(temp);

        }


        public static string LayMaNV(string tdn)
        {
            string s = ""; 
            return s = NhanVienDAO.LayMaNV(tdn);
        }

    }
}
