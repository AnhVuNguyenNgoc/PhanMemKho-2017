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
    public partial class fPhanQuyen : Form
    {
        public fPhanQuyen()
        {
            InitializeComponent();
            loadGrid();
            
        }

        void loadGrid() // load dữ liệu lên gridview
        {
            gcListUser.DataSource = UserBLL.Instance.getDataUsers();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
