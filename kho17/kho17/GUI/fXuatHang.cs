using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKho.DAO;
using kho17.GUI;


namespace kho17
{
    public partial class fXuatHang : DevExpress.XtraEditors.XtraForm
    {
        public fXuatHang()
        {
            InitializeComponent();
           // loadTable();
        }

    
        void loadTable()
        {

            string query = "exec sp_LoadStudentById @masv , @tensv";

            DataProvider provider = new DataProvider();

            dgvProduct.DataSource = provider.ExecuteQuery(query, new object[]{"sv001","anh vũ"});

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            fThemKhachHang fThemKH = new fThemKhachHang();
            fThemKH.Show();
        }

        private void btnNhaPhanPhoi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fThemKhachHang fThemKH = new fThemKhachHang();
            fThemKH.Show();
        }

     
    }
}