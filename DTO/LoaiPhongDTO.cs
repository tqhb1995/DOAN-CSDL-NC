using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongDTO
    {
        private string _maLoaiPhong;
        private string _tenLoaiPhong;
        private string _maKS;
        private float _donGia;
        private string _moTa;
        private int _slTrong;

        public string MaLoaiPhong
        {
            get { return _maLoaiPhong; }
            set { _maLoaiPhong = value; }
        }
        public string TenLoaiPhong
        {
            get { return _tenLoaiPhong; }
            set { _tenLoaiPhong = value; }
        }
        public string MaKS
        {
            get { return _maKS; }
            set { _maKS = value; }
        }
        public float DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        public int SlTrong
        {
            get { return _slTrong; }
            set { _slTrong = value; }
        }
    }
}
