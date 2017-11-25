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
    public partial class fNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public fNhapHang()
        {
            InitializeComponent();
            //loadTable();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        void loadTable()
        {

            //string query = "exec sp_LoadStudentById @masv , @tensv";

            //DataProvider provider = new DataProvider();

            //dgvProduct.DataSource = provider.ExecuteQuery(query, new object[]{"sv001","anh vũ"});

           // txtNPP.Text=provider.ExecuteNonQuery(query, new object[] {"sv001","anh vũ" }).ToString();

        }

        //?? tại sao khi load ham nhanh hơn event Load 
        private void fNhapHang_Load(object sender, EventArgs e)
        {
            

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            fThemNhaPhanPhoi fThemNPP = new fThemNhaPhanPhoi();
            fThemNPP.Show();
        }

        private void btnNhaPhanPhoi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fThemNhaPhanPhoi fThemNPP = new fThemNhaPhanPhoi();
            fThemNPP.Show();
        }
    }
}