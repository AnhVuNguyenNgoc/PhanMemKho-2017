using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    class ChiTietPhieuXuat
    {
        private float thanhTien;

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        private string maCTXUAT;

        public string MaCTXUAT
        {
            get { return maCTXUAT; }
            set { maCTXUAT = value; }
        }

        private string soPhieuXuat;

        public string SoPhieuXuat
        {
            get { return soPhieuXuat; }
            set { soPhieuXuat = value; }
        }

        
    }
}
