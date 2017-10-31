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
        public static MasterFrom ParentFormName { get; set; }
        public static int? EMP_TYPE { get; set; }
        public static string Emp_Name { get; set; }
        private static LoginUC _instance;
        Control[] ct;

        public static LoginUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginUC();
                return _instance;
            }
        }
        public LoginUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medical_StoreEntities1 db = new Medical_StoreEntities1();
            var result = db.GET_ValidateLogin(textBox1.Text, textBox2.Text).FirstOrDefault();
            EMP_TYPE = result.Designation_Id;
            Emp_Name = result.FirstName;
            if (result == null)
            {
                MessageBox.Show("Invalid Login Details. Please try again");
            }
            else
            {
                label1.Text = "WELCOME";
                label4.Text = Emp_Name;
                //MasterFrom mf = new MasterFrom();
                MasterFrom mf   = (MasterFrom)this.Parent.Parent;
                if (ParentFormName == null)
                    return;
                else
                    ParentFormName = mf;
                Panel pp = mf.Controls["panel1"] as Panel;
                
                pp.Controls.Remove(LoginUC.Instance);
                if (!pp.Controls.Contains(HomePage.Instance))
                {
                    pp.Controls.Add(HomePage.Instance);
                    HomePage.Instance.BringToFront();
                }
                else
                    HomePage.Instance.BringToFront();

                BuildMenu(mf, EMP_TYPE);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void BuildMenu(MasterFrom mf,int? result)
        {
            MenuStrip menuStrip1 = mf.Controls["menuStrip1"] as MenuStrip;
            menuStrip1.Items.Clear();
            menuStrip1.Show();
            ToolStripMenuItem item, submenu, stock,company;

            submenu = new ToolStripMenuItem();
            submenu.Text = "Home";

            item = new ToolStripMenuItem();
            item.Text = "Log Out";
            item.Click += LogOut_Click;
            submenu.DropDownItems.Add(item);

            item = new ToolStripMenuItem();
            item.Click += new EventHandler(exitToolStripMenuItem_Click);
            item.Text = "Exit";
            submenu.DropDownItems.Add(item);

            stock = new ToolStripMenuItem();
            stock.Text = "Stock";

            item = new ToolStripMenuItem();
            item.Text = "New Stock";
            item.Click += Item_Click;
            stock.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Update Stock";
            item.Click += Item_Click;
            stock.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Delete Stock";
            item.Click += Item_Click;
            stock.DropDownItems.Add(item);

            company = new ToolStripMenuItem();
            company.Text = "Company";

            item = new ToolStripMenuItem();
            item.Text = "Add Company";
            item.Click += Item_Click;
            company.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "Remove Company";
            item.Click += Item_Click;
            company.DropDownItems.Add(item);
            item = new ToolStripMenuItem();
            item.Text = "View Companies";
            item.Click += Item_Click;
            company.DropDownItems.Add(item);

            if (result == 1)
            {
                item = new ToolStripMenuItem();
                item.Text = "Reports";
                item.Click += Item_Click;
                stock.DropDownItems.Add(item);
            }
            menuStrip1.Items.Add(submenu);
            menuStrip1.Items.Add(stock);
            menuStrip1.Items.Add(company);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            MasterFrom mf = ParentFormName;
            Panel pp = mf.Controls["panel1"] as Panel;
            MenuStrip menuStrip1 = mf.Controls["menuStrip1"] as MenuStrip;
            menuStrip1.Hide();
            pp.Controls.Remove(StockUC.Instance);
            pp.Controls.Remove(CompanyUC.Instance);
            if (!pp.Controls.Contains(LoginUC.Instance))
            {
                pp.Controls.Add(LoginUC.Instance);
                LoginUC.Instance.BringToFront();
            }
            else
                LoginUC.Instance.BringToFront();
            textBox1.Clear();
            textBox2.Clear();
        }
        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            if (mi.Text == "Add Company")
            {
                SelectCompanyTabs(0);
            }
            else if (mi.Text == "Remove Company")
            {
                SelectCompanyTabs(1);
            }
            else if(mi.Text == "View Companies")
            {
                SelectCompanyTabs(2);
            }
        }

        private void RemoveAllInstances()
        {
            MasterFrom mf = ParentFormName;
            Panel pp = mf.Controls["panel1"] as Panel;
            pp.Controls.Remove(StockUC.Instance);
            pp.Controls.Remove(HomePage.Instance);
            pp.Controls.Remove(CompanyUC.Instance);
        }

        private void SelectCompanyTabs(int index)
        {
            MasterFrom mf = ParentFormName;
            Panel pp = mf.Controls["panel1"] as Panel;
            RemoveAllInstances();
            if (!pp.Controls.Contains(CompanyUC.Instance))
            {
                pp.Controls.Add(CompanyUC.Instance);
                CompanyUC.Instance.BringToFront();
            }
            else
                CompanyUC.Instance.BringToFront();

            ControlCollection cc = pp.Controls;
            ct = cc[0].Controls.Find("tabcontrol1", true);
            TabControl tc = (TabControl)ct[0];
            TabPage t = tc.TabPages[index];
            tc.SelectTab(t);
        }

        private void LoginUC_Load(object sender, EventArgs e)
        {

        }
    }
}
