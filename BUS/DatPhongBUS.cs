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
        public static bool DatPhong(DatPhongDTO dp)
        {

            return DatPhongDAO.DatPhongKhachSan(dp);
        }
    }
}
