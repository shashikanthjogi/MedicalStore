using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MedicalStore
{
    public partial class BillingUC : UserControl
    {

        #region Fields

        DataTable dt = new DataTable();
        int total = 0;
        Guid obj = Guid.NewGuid();
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
            dt.Columns.Add("CompanyId", typeof(int));
            dt.Columns.Add("StockName", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("OrderDate", typeof(DateTime));
            dt.Columns.Add("OrderDescription", typeof(string));
            dt.Columns.Add("RemovedBy", typeof(string));
            dt.Columns.Add("SalesId", typeof(Guid));
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
                int id = Convert.ToInt32(((System.Collections.Generic.KeyValuePair<string, string>)cmbItemName.SelectedItem).Key);
                AddToDT(id, text, Convert.ToInt32(txtBillingQuantity.Text), Convert.ToInt32(txtPrice.Text), txtCName.Text, Convert.ToInt32(txtMobile.Text), dt);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Total amount to be paid is " + lblTotalAmountDisplay.Text);
            using (MedicalDBEntityModelConnection db = new MedicalDBEntityModelConnection())
            {
                var parameter = new SqlParameter("@Stocks", SqlDbType.Structured);
                parameter.Value = dt;
                parameter.TypeName = "dbo.SalesTable";
                var result = db.INS_Customer(txtCName.Text,Convert.ToInt32(txtMobile.Text),obj, total);
                db.Database.ExecuteSqlCommand("exec dbo.INS_Sales @Stocks", parameter);
                obj = new Guid();
                //var b = db.Database.ExecuteSqlCommand("exec dbo.INS_Salestest @Stocks", parameter);
            }
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

        private void AddToDT(int id, string itemname, int quantity, int price, string customername, int mobilenumber, DataTable dt)
        {

            DataRow dr = dt.NewRow();
            dr["CompanyId"] = 13;
            dr["StockName"] = itemname;
            dr["Quantity"] = quantity;
            dr["Price"] = price;
            dr["OrderDate"] = DateTime.Now.ToString();
            dr["OrderDescription"] = "SALES";
            dr["RemovedBy"] = LoginUC.employeeName;
            dr["SalesId"] = obj.ToString();
            dt.Rows.Add(dr);
            dgAllBill.DataSource = dt;
            if (dgAllBill.Rows.Count > 0)
            {
                dgAllBill.Show();
                btnPrint.Enabled = true;
                BilledAmount(quantity * price);
            }
            else
                dgAllBill.Hide();
        }

        private void BilledAmount(int itemprice)
        {

            total += itemprice;
            lblTotalAmountDisplay.Text = total.ToString();

        }

        #endregion

    }
}
