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
    public partial class TonNgayControl : UserControl
    {
        private static TonNgayControl _instance;

        public static TonNgayControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TonNgayControl();
                }
                return _instance;
            }

        }
        public TonNgayControl()
        {
            InitializeComponent();
        }
    }
}
