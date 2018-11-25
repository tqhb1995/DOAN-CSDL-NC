﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachSanDTO
    {
        private string _maKS;
        private string _tenKS;
        private string _soSao;
        private string _soNha;
        private string _duong;
        private string _quan;
        private string _thanhPho;
        private int _giaTB;
        private string _moTa;

        public string MaKS
        {
            get { return _maKS; }
            set { _maKS = value; }
        }
        public string TenKS
        {
            get { return _tenKS; }
            set { _tenKS = value; }
        }
        public string SoSao
        {
            get { return _soSao; }
            set { _soSao = value; }
        }
        public string SoNha
        {
            get { return _soNha; }
            set { _soNha = value; }
        }
        public string Duong
        {
            get { return _duong; }
            set { _duong = value; }
        }
        public string Quan
        {
            get { return _quan; }
            set { _quan = value; }
        }
        public string ThanhPho
        {
            get { return _thanhPho; }
            set { _thanhPho = value; }
        }
        public int GiaTB
        {
            get { return _giaTB; }
            set { _giaTB = value; }
        }
        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

    }
}
