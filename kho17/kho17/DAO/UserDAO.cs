using QuanLyKho.DAO;
using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kho17.DAO
{
    class UserDAO
    {
        public bool Login(string username,string password)
        {
            //thay vì int check thì int check gán luôn cho tiện; 

            string query = "exec USER_CHECK @username , @matkhau";

            DataTable results = DataProvider.Instance.ExecuteQuery(query,new object[]{username,password});

            //thử executenonquery rầu nó ra -1 luôn mặc dù query đúng !! :))

            return results .Rows.Count > 0;
        }

        public string getGroupID(string username)
        {
            string query = "exec PHANQUYEN_SELECTGROUPID @username";

            string results = (string)DataProvider.Instance.ExecuteScalar(query,new object[]{username});

            return results;
        }

        public DataTable getDataUsers()
        {
            string query = "exec NGUOIDUNG_SELECT";

            DataTable results=DataProvider.Instance.ExecuteQuery(query);

            return results;
        }
    }
}
