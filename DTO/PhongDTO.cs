using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        private string _maPhong;
        private string _loaiPhong;
        private int _soPhong;

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }
        public string LoaiPhong
        {
            get { return _loaiPhong; }
            set { _loaiPhong = value; }
        }
        public int SoPhong
        {
            get { return _soPhong; }
            set { _soPhong = value; }
        }
    }
}
