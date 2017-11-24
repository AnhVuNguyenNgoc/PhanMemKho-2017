using kho17.BLL;
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
    public partial class fThemKhachHang : Form
    {
        public fThemKhachHang()
        {
            InitializeComponent();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

       

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            string ten = txtten.Text;
            string diachi = txtdiachi.Text;
            string dt = txtdt.Text;
            string mail = txtmail.Text;
            bool a = themkhachhangBLL.Instance.Insertkhachhang(ma,ten,diachi,dt,mail);
        }
    }
}
