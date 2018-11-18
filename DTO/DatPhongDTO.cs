using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatPhongDTO
    {
        private string _maDP;
        private string _maLoaiPhong;
        private string _maKH;
        private string _ngayBatDau;
        private string _ngayTraPhong;
        private string _ngayDat;
        private string _donGia;
        private string _moTa;
        private string _tinhTrang;

        public string MaDP
        {
            get { return _maDP; }
            set { _maDP = value; }
        }
        public string MaLoaiPhong
        {
            get { return _maLoaiPhong; }
            set { _maLoaiPhong = value; }
        }
        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }
        public string NgayBatDau
        {
            get { return _ngayBatDau; }
            set { _ngayBatDau = value; }
        }
        public string NgayTraPhong
        {
            get { return _ngayTraPhong; }
            set { _ngayTraPhong = value; }
        }
        public string NgayDat
        {
            get { return _ngayDat; }
            set { _ngayDat = value; }
        }
        public string DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
    }
}
