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
    public partial class LoginUC : UserControl
    {
        #region Fields

        public static MasterFrom parentFormName { get; set; }
        public static bool isLogOut = false;
        public static int? employeeType { get; set; }
        public static string employeeName { get; set; }
        private static LoginUC _instance;
        Control[] controls;
        public static LoginUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginUC();
                return _instance;
            }
        }

        #endregion

        #region Constructor
        public LoginUC()
        {
            InitializeComponent();
        }
        #endregion

        #region Events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUName.Text) || String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show(Constants.INVALID_LOGIN);
            }
            else
            {
                using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
                {
                    var loginResult = context.GET_ValidateLogin(txtUName.Text, txtPass.Text).FirstOrDefault();

                    if (loginResult == null)
                    {
                        MessageBox.Show(Constants.INVALID_LOGIN);
                    }
                    else
                    {
                        employeeType = loginResult.Designation_Id;
                        employeeName = loginResult.FirstName;
                        MasterFrom masterForm = (MasterFrom)this.Parent.Parent;
                        if (parentFormName == null)
                            return;
                        else
                            parentFormName = masterForm;
                        Panel panelMaster = masterForm.Controls["pnlMaster"] as Panel;

                        panelMaster.Controls.Remove(LoginUC.Instance);
                        if (!panelMaster.Controls.Contains(HomePage.Instance))
                        {
                            panelMaster.Controls.Add(HomePage.Instance);
                            HomePage.Instance.BringToFront();
                        }
                        else
                            HomePage.Instance.BringToFront();

                        BuildMenu(masterForm, employeeType);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUName.Clear();
            txtPass.Clear();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            isLogOut = true;
            MasterFrom mf = parentFormName;
            Panel pnlMaster = mf.Controls["pnlMaster"] as Panel;
            MenuStrip mainMenu = mf.Controls["menuMain"] as MenuStrip;
            mainMenu.Hide();
            pnlMaster.Controls.Remove(StockUC.Instance);
            pnlMaster.Controls.Remove(CompanyUC.Instance);
            pnlMaster.Controls.Remove(BillingUC.Instance);
            if (!pnlMaster.Controls.Contains(LoginUC.Instance))
            {
                pnlMaster.Controls.Add(LoginUC.Instance);
                LoginUC.Instance.BringToFront();
            }
            else
                LoginUC.Instance.BringToFront();
            txtUName.Clear();
            txtPass.Clear();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            switch (menuItem.Text)
            {
                case Constants.ADD_COMPANY:
                    SelectCompanyTabs(0);
                    break;
                case Constants.REMOVE_COMPANY:
                    SelectCompanyTabs(1);
                    break;
                case Constants.VIEW_COMPANIES:
                    SelectCompanyTabs(2);
                    break;
                case Constants.NEW_STOCK:
                    SelectStockTabs(0);
                    break;
                case Constants.UPDATE_STOCK:
                    SelectStockTabs(1);
                    break;
                case Constants.DELETE_STOCK:
                    SelectStockTabs(2);
                    break;
                case Constants.REPORTS:
                    SelectStockTabs(3);
                    break;
                case Constants.NEW_BILL:
                    SelectBilling(0);
                    break;
                case Constants.VIEW_BILLS:
                    SelectBilling(1);
                    break;
                default:
                    SelectCompanyTabs(0);
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void BuildMenu(MasterFrom masterForm, int? empType)
        {
            MenuStrip mainMenu = masterForm.Controls["menuMain"] as MenuStrip;
            mainMenu.Items.Clear();
            mainMenu.Show();
            ToolStripMenuItem item, submenu, stock, company, billing;

            submenu = new ToolStripMenuItem();
            submenu.Text = Constants.HOME;

            item = new ToolStripMenuItem();
            item.Text = Constants.LOG_OUT;
            item.Click += LogOut_Click;
            submenu.DropDownItems.Add(item);

            item = new ToolStripMenuItem();
            item.Click += new EventHandler(exitToolStripMenuItem_Click);
            item.Text = Constants.EXIT;
            submenu.DropDownItems.Add(item);

            stock = new ToolStripMenuItem();
            stock.Text = Constants.STOCK;

            item = new ToolStripMenuItem();
            item.Text = Constants.NEW_STOCK;
            item.Click += Item_Click;
            stock.DropDownItems.Add(item);

            item = new ToolStripMenuItem();
            item.Text = Constants.UPDATE_STOCK;
            item.Click += Item_Click;
            stock.DropDownItems.Add(item);

            item = new ToolStripMenuItem();
            item.Text = Constants.DELETE_STOCK;
            item.Click += Item_Click;
            stock.DropDownItems.Add(item);

            company = new ToolStripMenuItem();
            company.Text = Constants.COMPANY;

            item = new ToolStripMenuItem();
            item.Text = Constants.ADD_COMPANY;
            item.Click += Item_Click;
            company.DropDownItems.Add(item);

            item = new ToolStripMenuItem();
            item.Text = Constants.REMOVE_COMPANY;
            item.Click += Item_Click;
            company.DropDownItems.Add(item);

            item = new ToolStripMenuItem();
            item.Text = Constants.VIEW_COMPANIES;
            item.Click += Item_Click;
            company.DropDownItems.Add(item);

            mainMenu.Items.Add(submenu);
            mainMenu.Items.Add(stock);
            mainMenu.Items.Add(company);

            if (empType == (int)Constants.EMPLOYEETYPE.ADMIN || empType == (int)Constants.EMPLOYEETYPE.MANAGER)
            {
                item = new ToolStripMenuItem();
                item.Text = Constants.REPORTS;
                item.Click += Item_Click;
                stock.DropDownItems.Add(item);

                billing = new ToolStripMenuItem();
                billing.Text = Constants.SALES;

                item = new ToolStripMenuItem();
                item.Text = Constants.NEW_BILL;
                item.Click += Item_Click;
                billing.DropDownItems.Add(item);

                item = new ToolStripMenuItem();
                item.Text = Constants.VIEW_BILLS;
                item.Click += Item_Click;
                billing.DropDownItems.Add(item);
                mainMenu.Items.Add(billing);
            }
        }

        private void RemoveAllInstances()
        {
            MasterFrom mf = parentFormName;
            Panel panelMaster = mf.Controls["pnlMaster"] as Panel;
            panelMaster.Controls.Remove(StockUC.Instance);
            panelMaster.Controls.Remove(HomePage.Instance);
            panelMaster.Controls.Remove(CompanyUC.Instance);
            panelMaster.Controls.Remove(BillingUC.Instance);
        }

        private void SelectCompanyTabs(int index)
        {
            MasterFrom mf = parentFormName;
            Panel panelMaster = mf.Controls["pnlMaster"] as Panel;
            //RemoveAllInstances();
            if (!panelMaster.Controls.Contains(CompanyUC.Instance))
            {
                panelMaster.Controls.Add(CompanyUC.Instance);
                CompanyUC.Instance.BringToFront();
            }
            else
                CompanyUC.Instance.BringToFront();

            ControlCollection cc = panelMaster.Controls;
            controls = cc[0].Controls.Find("tbCompany", true);
            TabControl tc = (TabControl)controls[0];
            TabPage tp = tc.TabPages[index];
            tc.SelectTab(tp);
        }

        private void SelectStockTabs(int index)
        {
            MasterFrom mf = parentFormName;
            Panel panelMaster = mf.Controls["pnlMaster"] as Panel;
            //RemoveAllInstances();
            if (!panelMaster.Controls.Contains(StockUC.Instance))
            {
                panelMaster.Controls.Add(StockUC.Instance);
                StockUC.Instance.BringToFront();
            }
            else
                StockUC.Instance.BringToFront();

            ControlCollection cc = panelMaster.Controls;
            controls = cc[0].Controls.Find("tbStock", true);
            TabControl tc = (TabControl)controls[0];
            TabPage tp = tc.TabPages[index];
            TabPage reportsTab = tc.TabPages[3];
            tc.SelectTab(tp);
            if (employeeType == (int)Constants.EMPLOYEETYPE.STAFF || employeeType == (int)Constants.EMPLOYEETYPE.TRAINEE)
                tc.TabPages.Remove(reportsTab);
        }

        private void SelectBilling(int index)
        {

            MasterFrom mf = parentFormName;
            Panel panelMaster = mf.Controls["pnlMaster"] as Panel;
            RemoveAllInstances();
            BillingUC.Instance = null;
            if (!panelMaster.Controls.Contains(BillingUC.Instance))
            {
                panelMaster.Controls.Add(BillingUC.Instance);
                BillingUC.Instance.BringToFront();
            }
            else
                BillingUC.Instance.BringToFront();

            ControlCollection cc = panelMaster.Controls;
            controls = cc[0].Controls.Find("tbBilling", true);
            TabControl tc = (TabControl)controls[0];
            TabPage tp = tc.TabPages[index];
            tc.SelectTab(tp);
        }

        #endregion

    }
}
