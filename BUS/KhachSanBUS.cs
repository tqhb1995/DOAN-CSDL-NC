using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;


namespace BUS
{
    public class KhachSanBUS
    {
        public static bool ThemKhachSan(KhachSanDTO ks)
        {

            return KhachSanDAO.ThemKhachSan(ks);
        }
        /*
        public static int KiemTraTonTai(KhachSanDTO temp)
        {
            return KhachSanDAO.KiemTraTonTai(temp);

        }
        */
    }
}
