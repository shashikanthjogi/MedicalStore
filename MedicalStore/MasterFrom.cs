using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStore
{
    public partial class MasterFrom : Form
    {
        public MasterFrom()
        {
            InitializeComponent();

            menuStrip1.Hide();
            if (!panel1.Controls.Contains(LoginUC.Instance))
            {
                panel1.Controls.Add(LoginUC.Instance);
                LoginUC.Instance.BringToFront();
            }
            else
                LoginUC.Instance.BringToFront();
        }
    }
}
