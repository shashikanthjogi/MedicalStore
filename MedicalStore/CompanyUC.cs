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
    public partial class CompanyUC : UserControl
    {
        private static CompanyUC _instance;
        public static CompanyUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CompanyUC();
                return _instance;
            }
        }
        public CompanyUC()
        {
            InitializeComponent();
            FillCompanyList();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
            {
                try
                {
                    var result = context.INS_Company(textBox1.Text,
                        textBox2.Text,
                        textBox3.Text,
                        Convert.ToInt32(textBox4.Text)
                        );
                    FillCompanyList();
                    MessageBox.Show("New company added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry!! An error occured during the addition.");
                }
                
            }
        }

        private void FillCompanyList()
        {
            using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
            {
                var result = context.GET_Companies().ToList();
                dataGridView1.DataSource = result;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

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

        private void button2_Click(object sender, EventArgs e)
        {
            using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
            {
                try
                {
                    var result = context.DEL_Company(Convert.ToInt32(cmbCompanies.SelectedValue.ToString()));
                    FillCompanyList();
                    MessageBox.Show("Company removed successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry!! An error occured during the deletion.");
                }
            }
        }
    }
}
