using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private string _maHD;
        private DateTime _ngayThanhToan;
        private string _tongTien;
        private string _maDP;
        public string MaHD
        {
            get { return _maHD; }
            set { _maHD = value; }
        }
        public DateTime NgayThanhToan
        {
            get { return _ngayThanhToan; }
            set { _ngayThanhToan = value; }
        }
        public string TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }
        public string MaDP
        {
            get { return _maDP; }
            set { _maDP = value; }
        }
    }
}
