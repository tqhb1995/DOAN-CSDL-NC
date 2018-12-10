using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiPhongBUS
    {
        public static bool ThemLoaiPhong(LoaiPhongDTO lp)
        {
            return LoaiPhongDAO.ThemLoaiPhong(lp);
        }
        public static int KiemTra(LoaiPhongDTO lp)
        {
            return LoaiPhongDAO.KiemTra(lp);
        }
        public static int KiemTraSua(LoaiPhongDTO lp)
        {
            return LoaiPhongDAO.KiemTraSua(lp);
        }
        public static bool SuaLoaiPhong(LoaiPhongDTO lp)
        {
            return LoaiPhongDAO.SuaLoaiPhong(lp);
        }
    }
}
