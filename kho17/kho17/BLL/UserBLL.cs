using kho17.DAO;
using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kho17.BLL
{
     public class UserBLL
    {
         UserDAO userDAO = new UserDAO();

        //1 lần tạo duy nhất và và && không ai dc set giá trị cho nó (không ai can thiệp  vào nó )
        private static UserBLL instance;

        public static UserBLL Instance
        {
            get { if (instance == null) instance = new UserBLL(); return instance; }

            private set {  UserBLL.instance = value; }
        }

        private UserBLL()
        {
        }

        public bool Login(string user, string pass)
        {
            return userDAO.Login(user, pass);
        }

        public string getGroupId(string username)
        {
            return userDAO.getGroupID(username);
        }

        public DataTable getDataUsers()
        {
            return userDAO.getDataUsers();
        }
    }
}
