using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DTO
{
    class NguoiDung
    {
        public NguoiDung()
        {

        }
        public NguoiDung(string nhom_id, int dienThoai, string diaChiND, string tenND, string matKhau, string tenDangNhap)
        {
            this.Nhom_id = nhom_id;
            this.DienThoai = dienThoai;
            this.DiaChiND = diaChiND;
            this.MatKhau = matKhau;
            this.TenDangNhap = tenDangNhap;
            this.TenND = tenND;
        }

        public NguoiDung(DataRow row)
        {
            this.Nhom_id = row["GROUP_ID"].ToString();
            this.TenDangNhap = row["TENDANGNHAP"].ToString();
            this.TenND = row["TENND"].ToString();
            this.DiaChiND = row["DIACHIND"].ToString();
            this.DienThoai = (int)row["DIENTHOAI"];

        }
        private string nhom_id;

        public string Nhom_id
        {
            get { return nhom_id; }
            set { nhom_id = value; }
        }

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
