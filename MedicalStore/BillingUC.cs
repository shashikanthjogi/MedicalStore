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

        #region Fields

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

        #endregion

        #region Constructor

        public BillingUC()
        {
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Mobile", typeof(int));
            dt.Columns.Add("TotalAmount", typeof(int));
            InitializeComponent();
            txtQuantity.Enabled = false;
            txtPrice.Enabled = false;
            dgAllBill.Hide();
            if (!LoginUC.isLogOut)
            {
                BindStocks();
                if (cmbItemName.Items.Count > 0)
                {
                    GetQuantity(Convert.ToInt32(cmbItemName.SelectedValue.ToString()));
                    GetQuantity(Convert.ToInt32(cmbItemName.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show(Constants.NO_STOCK);
                }
                btnPrint.Enabled = false;
                lblTotalAmountDisplay.Text = string.Empty;
            }
        }

        #endregion

        #region Events

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItemName.Items.Count > 0)
            {
                GetQuantity(Convert.ToInt32(cmbItemName.SelectedValue.ToString()));
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            if (cmbItemName.Items.Count > 0)
            {
                var text = ((System.Collections.Generic.KeyValuePair<string, string>)cmbItemName.SelectedItem).Value;
                AddToDT(text, Convert.ToInt32(txtBillingQuantity.Text), Convert.ToInt32(txtPrice.Text), txtCName.Text, Convert.ToInt32(txtMobile.Text), dt);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total amount to be paid is " + lblTotalAmountDisplay.Text);
        }

        #endregion

        #region Methods

        private void BindStocks()
        {
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                stockdetails = context.GET_StockDetails().ToList();
                Dictionary<string, string> item = new Dictionary<string, string>();
                foreach (var s in stockdetails)
                {
                    item.Add(s.S_Id.ToString(), s.S_Name);
                }
                cmbItemName.DataSource = new BindingSource(item, null);
                cmbItemName.DisplayMember = "Value";
                cmbItemName.ValueMember = "Key";
                this.cmbItemName.SelectedIndexChanged += new System.EventHandler(cmbItemName_SelectedIndexChanged);
            }
        }

        private void GetQuantity(int id)
        {
            if (stockdetails.Count > 0)
            {
                txtQuantity.Text = stockdetails.Where(x => x.S_Id == id).Select(x => x.S_AvailableQuantity).FirstOrDefault().ToString();
                txtPrice.Text = stockdetails.Where(x => x.S_Id == id).Select(x => x.S_Price).FirstOrDefault().ToString();
            }
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
            dgAllBill.DataSource = dt;
            if (dgAllBill.Rows.Count > 0)
            {
                dgAllBill.Show();
                btnPrint.Enabled = true;
                BilledAmount(dt);
            }
            else
                dgAllBill.Hide();
        }

        private void BilledAmount(DataTable dt)
        {
            int total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                total += Convert.ToInt32(dr["TotalAmount"]);
            }
            lblTotalAmountDisplay.Text = total.ToString();
        }

        #endregion
        
    }
}
