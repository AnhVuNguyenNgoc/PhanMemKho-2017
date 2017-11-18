using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    class HangHoa
    {
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private float donGia;

        public float DonGia
        {
          get { return donGia; }
          set { donGia = value; }
        }

        private string maDv;

        public string MaDv
        {
            get { return maDv; }
            set { maDv = value; }
        }

        private string maLoai;

        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        private string tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
    }
}
