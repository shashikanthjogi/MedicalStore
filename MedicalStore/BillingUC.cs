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
    public partial class BillingUC : UserControl
    {
        DataTable dt = new DataTable();
        public static List<GET_StockDetails_Result> stockdetails;
        private static BillingUC _instance;
        public static BillingUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BillingUC();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public BillingUC()
        {
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Mobile", typeof(int));
            dt.Columns.Add("TotalAmount", typeof(int));
            InitializeComponent();
            textBox5.Enabled = false;
            textBox1.Enabled = false;
            dataGridView1.Hide();
            if (!LoginUC.isLogOut)
            {
                BindStocks();
                GetQuantity(Convert.ToInt32(comboBox3.SelectedValue.ToString()));
                GetQuantity(Convert.ToInt32(comboBox3.SelectedValue.ToString()));
                button1.Enabled = false;
                label4.Text = "";
            }
        }

        private void BindStocks()
        {
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                stockdetails = context.GET_StockDetails().ToList();
                Dictionary<string, string> item = new Dictionary<string, string>();
                foreach (var c in stockdetails)
                {
                    item.Add(c.S_Id.ToString(), c.S_Name);
                }
                comboBox3.DataSource = new BindingSource(item, null);
                comboBox3.DisplayMember = "Value";
                comboBox3.ValueMember = "Key";
                this.comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_SelectedIndexChanged);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetQuantity(Convert.ToInt32(comboBox3.SelectedValue.ToString()));
        }

        private void GetQuantity(int id)
        {
            textBox5.Text = stockdetails.Where(x => x.S_Id == id).Select(x => x.S_AvailableQuantity).FirstOrDefault().ToString();
            textBox1.Text = stockdetails.Where(x => x.S_Id == id).Select(x => x.S_Price).FirstOrDefault().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text = ((System.Collections.Generic.KeyValuePair<string, string>)comboBox3.SelectedItem).Value;
            AddToDT(text, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), dt);
        }

        private void AddToDT(string itemname, int quantity, int price, string customername, int mobilenumber, DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr["ItemName"] = itemname;
            dr["Quantity"] = quantity;
            dr["Price"] = price;
            dr["Customer"] = customername;
            dr["Mobile"] = mobilenumber;
            dr["TotalAmount"] = quantity * price;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Show();
                button1.Enabled = true;
                BilledAmount(dt);
            }
            else
                dataGridView1.Hide();
        }

        private void BilledAmount(DataTable dt)
        {
            int total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                total += Convert.ToInt32(dr["TotalAmount"]);
            }
            label4.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Total amount to be paid is " + label4.Text);
        }
    }
}
