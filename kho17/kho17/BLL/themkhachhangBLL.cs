using QuanLyKho.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kho17.BLL
{
    class themkhachhangBLL
    {
        private static themkhachhangBLL instance;
        public static themkhachhangBLL Instance
        {
            get { if (instance == null) instance = new themkhachhangBLL(); return instance; }

            private set { themkhachhangBLL.instance = value; }
        }
        public bool Insertkhachhang(string ma, string ten, string diachi, string sdt, string mail)
        {
            string query = "exec KHACHHANG_INSERT @MAKH , @TENKH , @DIACHI , @DIENTHOAI , @EMAIL";
            int a = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma, ten, diachi, sdt, mail });
            return a > 0;
        }
    }
}
