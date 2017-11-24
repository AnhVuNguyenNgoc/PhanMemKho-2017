using QuanLyKho.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kho17.DAO
{
   public class xuatkhoDAO
    {
        private static xuatkhoDAO instance;

        public static xuatkhoDAO Instance
        {
            get { if (instance == null) instance = new xuatkhoDAO(); return instance; }

            private set { xuatkhoDAO.instance = value; }
        }

        public object getHangHoaTheoMaHang(string mahang)
        {
            object data;
            data = DataProvider.Instance.ExecuteScalar("exec select_hanghoa @mahang", new object[] { mahang});
            return data;
            //cần truyền mã hàng vào 

            //lấy từ csdl lên là dataTable nha 

            //h code thôi 3 lớp luôn 

        }
    }
}
