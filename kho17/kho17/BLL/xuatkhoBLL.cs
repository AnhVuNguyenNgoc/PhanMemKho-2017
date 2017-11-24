using kho17.DAO;
using QuanLyKho.DAO;
using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kho17.BLL
{
    public class xuatkhoBLL
    {
        private static xuatkhoBLL instance;

        public static xuatkhoBLL Instance
        {
            get { if (instance == null) instance = new xuatkhoBLL(); return instance; }

            private set { xuatkhoBLL.instance = value; }
        }

        public bool Selecthanghoa(string ma)
        {
            xuatkhoDAO.Instance.getHangHoaTheoMaHang(ma);
            return true;
        }
        public bool insert_phieu (KhachHang kh, PhieuXuat px, ChiTietPhieuXuat ctx)
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string query1 = "exec PHIEUXUAT_INSERT @MAKH, @NGAY, @SOLUONG, @TONGTIEN";
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string query2 = "exec CHITIETPHIEUXUAT_INSERT @";
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            return true;
        }
       
    }  
}

// public string p = "exec PHIEUXUAT_INSERT @MAKH , @NGAY , @SOLUONG , @TONGTIEN";
//public string ctp = "exec CHITIETPHIEUXUAT_INSERT @";