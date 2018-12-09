using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DatPhongBUS
    {
        public static bool DatPhong(DatPhongDTO dp, KhachSanDTO ks, KhachHangDTO kh)
        {
            return DatPhongDAO.DatPhong(dp, ks, kh);
        }
        public static int KiemTraTonTai(KhachHangDTO kh)
        {
            return DatPhongDAO.KiemTraTonTai(kh);
        }

    }
}
