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
            //FillCompanyList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillCompanyList()
        {
            using (Medical_StoreEntities1 context=new Medical_StoreEntities1())
            {
                //var result = context.GET_ALL_VENDORS();
                //Dictionary<string, string> item = new Dictionary<string, string>();
                //foreach (var c in result)
                //{
                //    item.Add(c.Id.ToString(), c.Name);
                    
                //}
                //cmbCompanies.DataSource = new BindingSource(item, null);
                //cmbCompanies.DisplayMember = "Value";
                //cmbCompanies.ValueMember = "Key";
            }
        }
    }
}
