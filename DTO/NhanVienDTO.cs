using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string _hoTen;
        private string _tenDangNhap;
        private string _matKhau;
        private string _maNV;
        private string _maKS;
        public string MaKS
        {
            get { return _maKS; }
            set { _maKS = value; }
        }

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

    }
}
