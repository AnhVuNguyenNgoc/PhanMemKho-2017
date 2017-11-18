using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    class NhaPhanPhoi
    {
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        private int dienThoai;

        public int DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        private string diaChiNPP;

        public string DiaChiNPP
        {
            get { return diaChiNPP; }
            set { diaChiNPP = value; }
        }

    

        private string tenNPP;

        public string TenNPP
        {
            get { return tenNPP; }
            set { tenNPP = value; }
        }

      
        //ctrl +r+e
        private string maNpp;

        public string MaNpp
        {
            get { return maNpp; }
            set { maNpp = value; }
        }
    }
}
