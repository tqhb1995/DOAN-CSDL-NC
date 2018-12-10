using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KhachHangBUS
    {
        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            
            return KhachHangDAO.ThemKhachHang(kh);
        }
        public static int KiemTraTonTai(KhachHangDTO temp)
        {
            return KhachHangDAO.KiemTraTonTai(temp);

        }

        public static bool SuaKhachHang(KhachHangDTO kh)
        {

            return KhachHangDAO.SuaKhachHang(kh);
        }
        public static int KiemTraSua(KhachHangDTO temp)
        {
            return KhachHangDAO.KiemTraSua(temp);

        }

    }
}
