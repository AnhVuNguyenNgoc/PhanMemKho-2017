using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    class NguoiDung
    {
        private int dienThoai;

        public int DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        private string diaChiND;

        public string DiaChiND
        {
            get { return diaChiND; }
            set { diaChiND = value; }
        }

        private string tenND;

        public string TenND
        {
            get { return tenND; }
            set { tenND = value; }
        }

        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string tenDangNhap;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
    }
}
