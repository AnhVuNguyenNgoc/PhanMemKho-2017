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
    public partial class TonSLControl : UserControl
    {
        private static TonSLControl _instance;

        public static TonSLControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TonSLControl();
                }
                return _instance;
            }
       
        }

        public TonSLControl()
        {
            InitializeComponent();
        }
    }
}
