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
        private static LoginUC _instance;
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
            int? result = db.GET_ValidateLogin(textBox1.Text, textBox2.Text).FirstOrDefault();
            if (result == null)
            {
                MessageBox.Show("Invalid Login Details. Please try again");
            }
            else
            {
                //MasterFrom mf = new MasterFrom();
                MasterFrom mf   = (MasterFrom)this.Parent.Parent;
                Panel pp = mf.Controls["panel1"] as Panel;
                MenuStrip menuStrip1 = mf.Controls["menuStrip1"] as MenuStrip;
                menuStrip1.Items.Clear();
                menuStrip1.Show();
                ToolStripMenuItem item, submenu, stock;

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

                if (result == 1)
                {
                    item = new ToolStripMenuItem();
                    item.Text = "Reports";
                    item.Click += Item_Click;
                    stock.DropDownItems.Add(item);
                }
                menuStrip1.Items.Add(submenu);
                menuStrip1.Items.Add(stock);
                pp.Controls.Remove(LoginUC.Instance);
                if (!pp.Controls.Contains(StockUC.Instance))
                {
                    pp.Controls.Add(StockUC.Instance);
                    StockUC.Instance.BringToFront();
                }
                else
                    StockUC.Instance.BringToFront();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Parent = new MasterFrom();
            Form mf = (this.Parent as Form);

            //MasterFrom mf = new MasterFrom();
            Panel pp = mf.Controls["panel1"] as Panel;
            MenuStrip menuStrip1 = mf.Controls["menuStrip1"] as MenuStrip;
            menuStrip1.Hide();
            pp.Controls.Remove(StockUC.Instance);
            if (!pp.Controls.Contains(LoginUC.Instance))
            {
                pp.Controls.Add(LoginUC.Instance);
                LoginUC.Instance.BringToFront();
            }
            else
                LoginUC.Instance.BringToFront();
        }
        private void Item_Click(object sender, EventArgs e)
        {
        }

    }
}
