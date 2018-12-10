using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PhongBUS
    {
        public static bool ThemPhong(PhongDTO lp)
        {
            return PhongDAO.ThemPhong(lp);
        }
        public static bool SuaPhong(PhongDTO lp)
        {
            return PhongDAO.SuaPhong(lp);
        }
        public static int KiemTra(PhongDTO lp)
        {
            return PhongDAO.KiemTra(lp);
        }
        public static int KiemTraSua(PhongDTO lp)
        {
            return PhongDAO.KiemTraSua(lp);
        }
    }
}
