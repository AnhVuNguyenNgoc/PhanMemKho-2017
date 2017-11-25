using kho17.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kho17
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            if (fDangNhap.group_id == "gr001")
            {
                lbtest.Text = "admin";
            }
            else
            {
                brbtnPhanQuyen.Enabled=false;
                brbtnLichSuHT.Enabled = false;
                lbtest.Text = "user";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new fNhapHang();
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == form.Name)//kiểm tra tồn 
                    {
                        child.Activate();//
                        return;//trả về
                    }
                }
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var form = new fXuatHang();
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == form.Name)//kiểm tra tồn 
                    {
                        child.Activate();//
                        return;//trả về
                    }
                }
                form.MdiParent = this;
                form.Show();
            }
        
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new fKhoHang();
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == form.Name)//kiểm tra tồn 
                    {
                        child.Activate();//
                        return;//trả về
                    }
                }
                form.MdiParent = this;
                form.Show();
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new fBaoCao();
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == form.Name)//kiểm tra tồn 
                    {
                        child.Activate();//
                        return;//trả về
                    }
                }
                form.MdiParent = this;
                form.Show();
            }
        }

        private void brbtnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new fPhanQuyen();
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == form.Name)//kiểm tra tồn 
                    {
                        child.Activate();//
                        return;//trả về
                    }
                }
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new fKiemKe();
            {
                foreach (var child in MdiChildren)// tìm kiếm 
                {
                    if (child.Name == form.Name)//kiểm tra tồn 
                    {
                        child.Activate();//
                        return;//trả về
                    }
                }
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
