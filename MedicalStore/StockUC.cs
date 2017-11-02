﻿using System;
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

        #region Fields

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
        public static List<GET_StockDetails_Result> stockDetails;

        #endregion

        #region Constructor

        public StockUC()
        {
            InitializeComponent();
            txtIQuantity.Enabled = false;
            txtItemQuantity.Enabled = false;
            if (!LoginUC.isLogOut)
            {
                FillCompanyList();
                BindStocks();
                if (cboIName.Items.Count > 0 && cboItemName.Items.Count > 0)
                {
                    txtItemQuantity.Text = GetQuantity(Convert.ToInt32(cboItemName.SelectedValue.ToString())).ToString();
                    txtIQuantity.Text = GetQuantity(Convert.ToInt32(cboIName.SelectedValue.ToString())).ToString();
                }
            }
        }

        #endregion

        #region Events

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
                {
                    var result = context.INS_StockIn(txtSItem.Text, Constants.ADD, Convert.ToInt32(txtSQuantity.Text),
                        Convert.ToInt32(txtSPrice.Text), Convert.ToInt32(cmbCompanies.SelectedValue.ToString()), Convert.ToDateTime(dtEdate.Value.ToShortDateString()), Convert.ToDateTime(DateTime.Now), LoginUC.employeeName);
                    MessageBox.Show(Constants.STOCK_ADD);
                    ClearAddStockFields();
                    BindStocks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constants.STOCK_ADD_FAIL);
            }
        }

        private void cboIName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIQuantity.Text = GetQuantity(Convert.ToInt32(cboIName.SelectedValue.ToString())).ToString();
        }

        private void cboItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItemQuantity.Text = GetQuantity(Convert.ToInt32(cboItemName.SelectedValue.ToString())).ToString();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Constants.STOCK_UPDATE_WARNING);
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                var text = ((System.Collections.Generic.KeyValuePair<string, string>)cboIName.SelectedItem).Value;
                var result = context.UPD_StockIn(Convert.ToInt32(cboIName.SelectedValue.ToString()), text, Convert.ToInt32(txtItQuantity.Text), Convert.ToInt32(txtItPrice.Text)
                    , Constants.UPDATE, Convert.ToDateTime(DateTime.Now), LoginUC.employeeName);
            }
            MessageBox.Show(Constants.STOCK_UPDATE_SUCCESS);
            BindStocks();
            txtItQuantity.Clear();
            txtItPrice.Clear();
        }

        private void btnDelStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Constants.STOCK_DEL_WARNING);
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                var text = ((System.Collections.Generic.KeyValuePair<string, string>)cboItemName.SelectedItem).Value;
                var result = context.DEL_Stock(text, Constants.DELETE, Convert.ToDateTime(DateTime.Now), LoginUC.employeeName);
            }
            MessageBox.Show(Constants.STOCK_DEL_SUCCESS);
            BindStocks();
        }

        #endregion

        #region Methods

        private void FillCompanyList()
        {
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                var companyList = context.GET_Companies().ToList();
                if (companyList.Count > 0)
                {
                    Dictionary<string, string> item = new Dictionary<string, string>();
                    foreach (var c in companyList)
                    {
                        item.Add(c.Id.ToString(), c.CompanyName);
                    }
                    cmbCompanies.DataSource = new BindingSource(item, null);
                    cmbCompanies.DisplayMember = "Value";
                    cmbCompanies.ValueMember = "Key";
                }
                else
                {
                    dgViewStock.DataSource = null;
                    cmbCompanies.DataSource = null;
                    MessageBox.Show(Constants.COMPANY_NONE);
                }
            }
        }

        private void ClearAddStockFields()
        {
            txtSItem.Clear();
            txtSPrice.Clear();
            txtSQuantity.Clear();
            cmbCompanies.SelectedIndex = 0;
            dtEdate.ResetText();
        }

        private void BindStocks()
        {
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                stockDetails = context.GET_StockDetails().ToList();
                if (stockDetails.Count > 0)
                {
                    Dictionary<string, string> item = new Dictionary<string, string>();
                    foreach (var s in stockDetails)
                    {
                        item.Add(s.S_Id.ToString(), s.S_Name);
                    }
                    cboIName.DataSource = new BindingSource(item, null);
                    cboIName.DisplayMember = "Value";
                    cboIName.ValueMember = "Key";
                    cboItemName.DataSource = new BindingSource(item, null);
                    cboItemName.DisplayMember = "Value";
                    cboItemName.ValueMember = "Key";
                    this.cboIName.SelectedIndexChanged += new System.EventHandler(cboIName_SelectedIndexChanged);
                    this.cboItemName.SelectedIndexChanged += new System.EventHandler(cboItemName_SelectedIndexChanged);
                    dgViewStock.DataSource = stockDetails;
                    dgViewStock.Columns[0].Visible = false;
                }
                else
                {
                    dgViewStock.DataSource = null;
                    cboItemName.DataSource = null;
                    MessageBox.Show(Constants.COMPANY_NONE);
                }
            }
        }

        private int GetQuantity(int id)
        {
            return stockDetails.Where(x => x.S_Id == id).Select(x => x.S_AvailableQuantity).FirstOrDefault();
        }

        #endregion
        
    }
}
