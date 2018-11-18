using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string _hoTen;
        private string _tenDangNhap;
        private string _matKhau;
        private string _soCMND;
        private string _soDienThoai;
        private string _moTa;
        private string _email;
        private string _maKH;
        private string _diaChi;
        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
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

        public string SoCMND
        {
            get { return _soCMND; }
            set { _soCMND = value; }
        }

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }



        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

    }
}
