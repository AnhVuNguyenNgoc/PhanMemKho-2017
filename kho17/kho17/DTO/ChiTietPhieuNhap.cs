using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    class ChiTietPhieuNhap
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

        private string maCTNHAP;

        public string MaCTNHAP
        {
            get { return maCTNHAP; }
            set { maCTNHAP = value; }
        }


        private string soPhieuNhap;

        public string SoPhieuNhap
        {
            get { return soPhieuNhap; }
            set { soPhieuNhap = value; }
        }
    }
}
