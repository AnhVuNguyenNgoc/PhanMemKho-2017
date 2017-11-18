using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kho17.control
{
    public partial class TonHangHoaControl : UserControl
    {
        private static TonHangHoaControl _instance;

        public static TonHangHoaControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TonHangHoaControl();
                }
                return _instance;
            }

        }
        public TonHangHoaControl()
        {
            InitializeComponent();
        }
    }
}
