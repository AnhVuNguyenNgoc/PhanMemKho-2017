using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
      public  class KhachHang
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int dienThoai;

        public int DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        private string diaChiKh;

        public string DiaChiKh
        {
            get { return diaChiKh; }
            set { diaChiKh = value; }
        }

        private string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

     
        private string maKh;

        public string MaKh
        {
            get { return maKh; }
            set { maKh = value; }
        }

    }
}
