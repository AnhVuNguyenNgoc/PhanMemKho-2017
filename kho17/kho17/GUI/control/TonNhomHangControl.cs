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
    public partial class TonNhomHangControl : UserControl
    {
        private static TonNhomHangControl _instance;

        public static TonNhomHangControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TonNhomHangControl();
                }
                return _instance;
            }

        }

        public TonNhomHangControl()
        {
            InitializeComponent();
        }
    }
}
