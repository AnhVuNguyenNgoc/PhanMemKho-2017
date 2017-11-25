using kho17.BLL;
using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kho17.GUI
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        public static string group_id;

        bool Login(string username,string pass)
        {
            //gọi hàm bll ở đây nữa là xong !!
            return UserBLL.Instance.Login(username, pass);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtPassWord.Text;

            if (Login(username,pass))
            {
                //Đăng nhập thành công thì mình mới set PhanQuyen
                
                //gán giá trị biến static group_id khi thành công nè 
                //Nhằm qua form1 biết là admin hay user 

               group_id= UserBLL.Instance.getGroupId(username);

                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên mật khẩu hay tài khoản");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
