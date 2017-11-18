using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.DAO
{
    class DataProvider
    {
        private string connectSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=HeQuanTri_SinhVien;Integrated Security=True";

        //dùng để lấy ra table trong sql
        public DataTable ExecuteQuery(string query,object[] parameters = null) //Có thể truyền n parameters vào cũng dc 
        {

            DataTable data = new DataTable();//trong using biến data ko hỉu

            using (SqlConnection connection = new SqlConnection(connectSTR))  //Tự giải phóng biến connection ->using
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);   //command.execute   ??? Tại sao không execute như thế này  KHÔNG LINH HOẠT AH 

                if (parameters != null)
                {
                    string[] listPa = query.Split(' '); //tách câu query theo khoảng trắng

                    int i = 0; //thứ tự parameter[i]

                    foreach (string item in listPa)
                    {

                        if (item.Contains('@')) //nếu chú kí tự @
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }

                    /*
                            ví dụ 
                      exec sp_LoadStudentById @masv 
                     
                     nhập vào [] parameters là sv002
                     
                     listPa={exec , sp_LoadStudentById , @masv}
                      nó sẽ addWithValue vào @masv là parameter[0]=sv002
                     
                     */
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);  //error  SelectCommand.Connection property has not been initialized.

                connection.Close();  //TRÁNH TRƯỜNG HỢP NHIỀU THẰNG CÙNG ĐỔ VỀ ??????????
                /*
                    NẾU MỞ HỘP CÁ RA MÀ KHÔNG ĐÓNG LẠI THÌ SAO 
             
                  -> CODE CŨNG NHƯ VẬY  connection.open() mà ko close là thua
                 */
            }

            return data;
        }

        //CHỈ DÙNG CHO INSERT ,UPDATE,DELETE THÔI NHÁ.
        //NÓ TRẢ RA SỐ DÒNG THÀNH CÔNG 
        public int ExecuteNonQuery(string query, object[] parameters = null) //Có thể truyền n parameters vào cũng dc 
        {

            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectSTR))  //Tự giải phóng biến connection ->using
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);   //command.execute   ??? Tại sao không execute như thế này  KHÔNG LINH HOẠT AH 

                if (parameters != null)
                {
                    string[] listPa = query.Split(' '); //tách câu query theo khoảng trắng

                    int i = 0; //thứ tự parameter[i]

                    foreach (string item in listPa)
                    {

                        if (item.Contains('@')) //nếu chú kí tự @
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }

                    /*
                            ví dụ 
                      exec sp_LoadStudentById @masv 
                     
                     nhập vào [] parameters là sv002
                     
                     listPa={exec , sp_LoadStudentById , @masv}
                      nó sẽ addWithValue vào @masv là parameter[0]=sv002
                     
                     */
                }

                data = command.ExecuteNonQuery();

                connection.Close();  //TRÁNH TRƯỜNG HỢP NHIỀU THẰNG CÙNG ĐỔ VỀ ??????????
                /*
                    NẾU MỞ HỘP CÁ RA MÀ KHÔNG ĐÓNG LẠI THÌ SAO 
             
                  -> CODE CŨNG NHƯ VẬY  connection.open() mà ko close là thua
                 */
            }

            return data;
        }

        //dùng trong những select count(*) => nó trả ra 1 ô ah 
        public object ExecuteScalar(string query, object[] parameters = null) //Có thể truyền n parameters vào cũng dc 
        {

            object data = 0;
            
            using (SqlConnection connection = new SqlConnection(connectSTR))  //Tự giải phóng biến connection ->using
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);   //command.execute   ??? Tại sao không execute như thế này  KHÔNG LINH HOẠT AH 

                if (parameters != null)
                {
                    string[] listPa = query.Split(' '); //tách câu query theo khoảng trắng

                    int i = 0; //thứ tự parameter[i]

                    foreach (string item in listPa)
                    {

                        if (item.Contains('@')) //nếu chú kí tự @
                        {
                            command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }

                    /*
                            ví dụ 
                      exec sp_LoadStudentById @masv 
                     
                     nhập vào [] parameters là sv002
                     
                     listPa={exec , sp_LoadStudentById , @masv}
                      nó sẽ addWithValue vào @masv là parameter[0]=sv002
                     
                     */
                }

                data = command.ExecuteScalar();

                connection.Close();  //TRÁNH TRƯỜNG HỢP NHIỀU THẰNG CÙNG ĐỔ VỀ ??????????
                /*
                    NẾU MỞ HỘP CÁ RA MÀ KHÔNG ĐÓNG LẠI THÌ SAO 
             
                  -> CODE CŨNG NHƯ VẬY  connection.open() mà ko close là thua
                 */
            }

            return data;
        }
    }
}
