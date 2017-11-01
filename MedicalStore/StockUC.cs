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
        public static List<GET_StockDetails_Result> sd;
        public StockUC()
        {
            InitializeComponent();
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            FillCompanyList();
            BindStocks();
            textBox7.Text = GetQuantity(Convert.ToInt32(comboBox4.SelectedValue.ToString())).ToString();
            textBox5.Text = GetQuantity(Convert.ToInt32(comboBox3.SelectedValue.ToString())).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
                {
                    var result = context.INS_StockIn(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox4.Text),
                        Convert.ToInt32(textBox3.Text), Convert.ToInt32(cmbCompanies.SelectedValue.ToString()), Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString()), Convert.ToDateTime(DateTime.Now),LoginUC.Emp_Name);
                    MessageBox.Show("Stock Added Successfully");
                    ClearAddStockFields();
                    BindStocks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock Addition Failed");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FillCompanyList()
        {
            using (Medical_StoreEntitiy context =new Medical_StoreEntitiy())
            {
                var result = context.GET_Companies().ToList();
                Dictionary<string, string> item = new Dictionary<string, string>();
                foreach (var c in result)
                {
                    item.Add(c.C_Id.ToString(), c.CompanyName);
                }
                cmbCompanies.DataSource = new BindingSource(item, null);
                cmbCompanies.DisplayMember = "Value";
                cmbCompanies.ValueMember = "Key";
            }
        }

        private void ClearAddStockFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            cmbCompanies.SelectedIndex = 0;
            dateTimePicker2.ResetText();
        }

        private void BindStocks()
        {
            using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
            {
                sd = context.GET_StockDetails().ToList();
                Dictionary<string, string> item = new Dictionary<string, string>();
                foreach (var c in sd)
                {
                    item.Add(c.S_Id.ToString(), c.S_Name);
                }
                comboBox3.DataSource = new BindingSource(item, null);
                comboBox3.DisplayMember = "Value";
                comboBox3.ValueMember = "Key";
                comboBox4.DataSource = new BindingSource(item, null);
                comboBox4.DisplayMember = "Value";
                comboBox4.ValueMember = "Key";
                this.comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_SelectedIndexChanged);
                this.comboBox4.SelectedIndexChanged += new System.EventHandler(comboBox4_SelectedIndexChanged);
                dataGridView1.DataSource = sd;
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private int GetQuantity(int id)
        {
            return sd.Where(x => x.S_Id == id).Select(x => x.S_AvailableQuantity).FirstOrDefault();
        }

        

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text =  GetQuantity(Convert.ToInt32(comboBox3.SelectedValue.ToString())).ToString();
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text =  GetQuantity(Convert.ToInt32(comboBox4.SelectedValue.ToString())).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning!!!... This will update the existing stock quantity and price details for the item selected");
            using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
            {
                var text = ((System.Collections.Generic.KeyValuePair<string, string>)comboBox3.SelectedItem).Value;
                var result = context.UPD_StockIn(Convert.ToInt32(comboBox3.SelectedValue.ToString()), text, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox8.Text)
                    ,"UPDATE", Convert.ToDateTime(DateTime.Now), LoginUC.Emp_Name);
            }
            MessageBox.Show("Stock Details Updated Successfully");
            BindStocks();
            textBox6.Clear();
            textBox8.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning!!!... This will delete the existing stock");
            using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
            {
                var text = ((System.Collections.Generic.KeyValuePair<string, string>)comboBox4.SelectedItem).Value;
                var result = context.DEL_Stock(text, "DELETE STOCK", Convert.ToDateTime(DateTime.Now),LoginUC.Emp_Name);
            }
            MessageBox.Show("Stock deleted Successfully");
            BindStocks();
        }
    }
}
