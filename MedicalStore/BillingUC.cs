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
        public static List<GET_SalesDetails_Result> salesDetails;
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
                if (string.IsNullOrEmpty(txtBillingQuantity.Text))
                {
                    MessageBox.Show("Please enter the quantity to be sold");
                }
                else
                {
                    int billQuantity = Convert.ToInt32(txtBillingQuantity.Text);
                    int currQuantity = Convert.ToInt32(txtQuantity.Text);
                    if (billQuantity > currQuantity)
                    {
                        MessageBox.Show("Number of items in stock is less");
                        txtBillingQuantity.Clear();
                    }
                    else
                    {
                        var text = ((System.Collections.Generic.KeyValuePair<string, string>)cmbItemName.SelectedItem).Value;
                        int id = Convert.ToInt32(((System.Collections.Generic.KeyValuePair<string, string>)cmbItemName.SelectedItem).Key);
                        AddToDT(id, text, billQuantity, Convert.ToInt32(txtPrice.Text));
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCName.Text) || string.IsNullOrEmpty(txtMobile.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Customer name or mobile number is blank. Do you want to proceed", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Total amount to be paid is " + lblTotalAmountDisplay.Text);
                    PrintBill();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (!CommonHelper.IsNumber(txtMobile.Text))
                {
                    txtMobile.Focus();
                    MessageBox.Show(Constants.INVALID_MOBILE);
                }
                if (txtMobile.Text.Length != 10)
                {
                    txtMobile.Focus();
                    MessageBox.Show(Constants.INVALID_MOBILE);
                }
                PrintBill();
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
            BindSalesDetails();
        }

        private void GetQuantity(int id)
        {
            if (stockdetails.Count > 0)
            {
                string stockName = stockdetails.Where(x => x.S_Id == id).Select(x => x.S_Name).FirstOrDefault().ToString();
                string stockQuantity = stockdetails.Where(x => x.S_Id == id).Select(x => x.S_AvailableQuantity).FirstOrDefault().ToString();
                txtQuantity.Text = stockQuantity;
                txtPrice.Text = stockdetails.Where(x => x.S_Id == id).Select(x => x.S_Price).FirstOrDefault().ToString();
                txtBillingQuantity.Clear();
                int finalQuantity = Convert.ToInt32(stockQuantity);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if ((string)dr["StockName"] == stockName)
                        {
                            finalQuantity = finalQuantity - Convert.ToInt32(dr["Quantity"].ToString());
                        }
                    }
                    txtQuantity.Text = finalQuantity.ToString();
                }
            }
        }

        private void AddToDT(int id, string itemname, int quantity, int price)
        {

            DataRow dr = dt.NewRow();
            dr["CompanyId"] = GetCompanyByStockName(itemname);
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
                txtBillingQuantity.Clear();
                GetQuantity(id);
            }
            else
                dgAllBill.Hide();
        }

        private void BilledAmount(int itemprice)
        {

            total += itemprice;
            lblTotalAmountDisplay.Text = total.ToString();

        }

        private void PrintBill()
        {
            using (MedicalDBEntityModelConnection db = new MedicalDBEntityModelConnection())
            {
                var parameter = new SqlParameter("@Stocks", SqlDbType.Structured);
                parameter.Value = dt;
                parameter.TypeName = "dbo.SalesTable";
                int? mobile = null;
                if (string.IsNullOrEmpty(txtMobile.Text))
                    mobile = null;
                else
                    mobile = Convert.ToInt32(txtMobile.Text);
                var result = db.INS_Customer(txtCName.Text, mobile, obj, total);
                db.Database.ExecuteSqlCommand("exec dbo.INS_Sales @Stocks", parameter);

                obj = new Guid();
            }
            using (MedicalDBEntityModelConnection mainSales = new MedicalDBEntityModelConnection())
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var result = mainSales.UPD_MainStock(dr["StockName"].ToString(), Convert.ToInt32(dr["Quantity"].ToString()), Convert.ToInt32(dr["Price"].ToString()));
                }
            }
            dt.Rows.Clear();
            dgAllBill.DataSource = null;
            dgAllBill.Hide();
            BindStocks();
            if (cmbItemName.Items.Count > 0)
            {
                GetQuantity(Convert.ToInt32(cmbItemName.SelectedValue.ToString()));
            }
            txtCName.Clear();
            txtMobile.Clear();
            BindSalesDetails();
            MessageBox.Show("Bill generated successfully");
        }

        private int GetCompanyByStockName(string stockName)
        {
            using (MedicalDBEntityModelConnection db = new MedicalDBEntityModelConnection())
            {
                var companyResult = db.GET_CompanyByStockName(stockName).ToList();
                if (companyResult.Count > 0)
                {
                    return companyResult[0].Id;
                }
            }
            return 0;
        }

        private void BindSalesDetails()
        {
            using (MedicalDBEntityModelConnection db = new MedicalDBEntityModelConnection())
            {
                salesDetails = db.GET_SalesDetails().ToList();
                DataTable dtSales = new DataTable();
                dtSales.Columns.Add("StockName", typeof(string));
                dtSales.Columns.Add("Quantity", typeof(int));
                dtSales.Columns.Add("TotalBill", typeof(int));
                dtSales.Columns.Add("CustomerName", typeof(string));
                dtSales.Columns.Add("Mobile", typeof(int));
                dtSales.Columns.Add("OrderDate", typeof(string));
                dtSales.Columns.Add("SalesId", typeof(string));
                if (salesDetails.Count > 0)
                {
                    for(int i =0;i<salesDetails.Count;i++)
                    {
                        DataRow dr = dtSales.NewRow();
                        dr["StockName"] = salesDetails[i].O_StockName;
                        dr["Quantity"] = salesDetails[i].O_Quantity;
                        dr["TotalBill"] = salesDetails[i].TotalBill;
                        dr["CustomerName"] = salesDetails[i].CustomerName;
                        if (salesDetails[i].Mobile == null)
                            dr["Mobile"] = DBNull.Value;
                        else
                            dr["Mobile"] = salesDetails[i].Mobile;
                        dr["OrderDate"] = salesDetails[i].O_Date.ToString();
                        dr["SalesId"] = salesDetails[i].SalesId.ToString();
                        dtSales.Rows.Add(dr);
                    }
                    dgSales.DataSource = dtSales;
                }
            }
        }

        #endregion

    }
}
