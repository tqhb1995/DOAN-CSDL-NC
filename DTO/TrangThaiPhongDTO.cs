using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThaiPhongDTO
    {
        private string _maPhong;
        private string _ngay;
        private string _tinhTrang;

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }
        public string Ngay
        {
            get { return _ngay; }
            set { _ngay = value; }
        }
        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
    }
}
