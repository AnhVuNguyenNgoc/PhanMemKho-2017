namespace kho17
{
    partial class fBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBaoCao));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvbSoLuong = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbNhomHang = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbNgay = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nvbSoLuong,
            this.nvbNhomHang,
            this.nvbNgay,
            this.nvbHangHoa});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 200;
            this.navBarControl1.Size = new System.Drawing.Size(200, 555);
            this.navBarControl1.TabIndex = 0;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Tồn kho";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbSoLuong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbNhomHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbNgay),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbHangHoa)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nvbSoLuong
            // 
            this.nvbSoLuong.Caption = "Tồn số lượng";
            this.nvbSoLuong.Name = "nvbSoLuong";
            this.nvbSoLuong.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbSoLuong.SmallImage")));
            this.nvbSoLuong.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbSoLuong_LinkClicked);
            // 
            // nvbNhomHang
            // 
            this.nvbNhomHang.Caption = "Tồn nhóm hàng";
            this.nvbNhomHang.Name = "nvbNhomHang";
            this.nvbNhomHang.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbNhomHang.SmallImage")));
            this.nvbNhomHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // nvbNgay
            // 
            this.nvbNgay.Caption = "Tồn theo ngày";
            this.nvbNgay.Name = "nvbNgay";
            this.nvbNgay.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbNgay.SmallImage")));
            this.nvbNgay.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbSLXuat_LinkClicked);
            // 
            // nvbHangHoa
            // 
            this.nvbHangHoa.Caption = "Tồn theo hàng hóa";
            this.nvbHangHoa.Name = "nvbHangHoa";
            this.nvbHangHoa.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbHangHoa.SmallImage")));
            this.nvbHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbHangHoa_LinkClicked);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(200, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(719, 555);
            this.panel.TabIndex = 1;
            // 
            // fBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 555);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.navBarControl1);
            this.Name = "fBaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.fBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nvbSoLuong;
        private DevExpress.XtraNavBar.NavBarItem nvbNhomHang;
        private DevExpress.XtraNavBar.NavBarItem nvbNgay;
        private DevExpress.XtraNavBar.NavBarItem nvbHangHoa;
        private DevExpress.XtraEditors.PanelControl panel;
    }
}