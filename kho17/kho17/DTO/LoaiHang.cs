using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    class LoaiHang
    {
        private string tenLoai;

        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }

        private string maLoai;

        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }
       
    }
}
