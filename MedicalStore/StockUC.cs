using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStore
{
    public partial class StockUC : UserControl
    {
        private static StockUC _instance;
        public static StockUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StockUC();
                return _instance;
            }
        }
        public StockUC()
        {
            InitializeComponent();
        }
    }
}
