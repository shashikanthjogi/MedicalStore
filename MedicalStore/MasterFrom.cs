using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace MedicalStore
{
    public partial class MasterFrom : Form
    {
        #region Constructor

        public MasterFrom()
        {
            InitializeComponent();
            LoginUC.parentFormName = this;
            menuMain.Hide();
            lblUserName.Text = string.Empty;
            lblStoreName.Text = ConfigurationSettings.AppSettings["MedicalStoreName"];
            if (!pnlMaster.Controls.Contains(LoginUC.Instance))
            {
                pnlMaster.Controls.Add(LoginUC.Instance);
                LoginUC.Instance.BringToFront();
            }
            else
                LoginUC.Instance.BringToFront();
        }

        #endregion
    }
}
