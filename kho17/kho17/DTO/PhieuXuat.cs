using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    public class PhieuXuat
    {
        private float tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private DateTime ngayXuat;

        public DateTime NgayXuat
        {
            get { return ngayXuat; }
            set { ngayXuat = value; }
        }

        private string soPhieuXuat;

        public string SoPhieuXuat
        {
            get { return soPhieuXuat; }
            set { soPhieuXuat = value; }
        }
    }
}
