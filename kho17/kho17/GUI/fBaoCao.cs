
using kho17.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kho17
{
    public partial class fBaoCao : Form
    {
      
        public fBaoCao()
        {
            InitializeComponent();
            showControl(TonSLControl.Instance);
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {
            //click vào ô thứ n ra panel thứ n 
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {
        }

        public void showControl(Control control)
        {
            if (!panel.Contains(control))
            {
                panel.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
            }
            else
            {
                control.BringToFront();
            }
        }

        private void nvbSoLuong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
            showControl(TonSLControl.Instance);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showControl(TonNhomHangControl.Instance);
        }

        private void nvbSLXuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showControl(TonNgayControl.Instance);
        }

        private void nvbHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            showControl(TonHangHoaControl.Instance);
        }

     

      
    }
}
