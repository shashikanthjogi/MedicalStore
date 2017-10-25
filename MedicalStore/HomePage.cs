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
    public partial class HomePage : UserControl
    {
        private static HomePage _instance;
        public static HomePage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomePage();
                return _instance;
            }
        }
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
