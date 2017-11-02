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

        #region Fields

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

        #endregion

        #region Constructor

        public CompanyUC()
        {
            InitializeComponent();
            if(!LoginUC.isLogOut)
                FillCompanyList();
        }

        #endregion

        #region Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string error = ValidateFields();
            if (string.IsNullOrEmpty(error))
            {
                using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
                {
                    try
                    {
                        var result = context.INS_Company(txtCompanyName.Text,
                            txtDealerName.Text,
                            txtAddress.Text,
                            Convert.ToInt64(txtMobile.Text)
                            );
                        FillCompanyList();
                        txtCompanyName.Clear();
                        txtAddress.Clear();
                        txtDealerName.Clear();
                        txtMobile.Clear();
                        MessageBox.Show(Constants.COMPANY_ADD_SUCCESS);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Constants.COMPANY_FAILURE);
                    }

                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (cmbCompanies.Items.Count > 0)
            {
                using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
                {
                    try
                    {
                        var result = context.DEL_Company(Convert.ToInt32(cmbCompanies.SelectedValue.ToString()));
                        FillCompanyList();
                        MessageBox.Show(Constants.COMPANY_DEL_SUCCESS);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Constants.COMPANY_FAILURE);
                    }
                }
            }
            else
            {
                MessageBox.Show(Constants.COMPANY_NONE);
            }
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
                    dgCompanyList.DataSource = companyList;
                    dgCompanyList.Columns[0].Visible = false;
                    dgCompanyList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

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
                    cmbCompanies.DataSource = null;
                    dgCompanyList.DataSource = null;
                }
            }
        }

        private string ValidateFields()
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrEmpty(txtDealerName.Text) || string.IsNullOrEmpty(txtMobile.Text) ||
                string.IsNullOrEmpty(txtAddress.Text))
            {
                return Constants.MANDATORY_FIELDS;
            }
            return ValidateMobile();
        }

        private string ValidateMobile()
        {
            if (!IsNumber(txtMobile.Text))
            {
                txtMobile.Focus();
                return Constants.INVALID_MOBILE;
            }
            if (txtMobile.Text.Length != 10)
            {
                txtMobile.Focus();
                return Constants.INVALID_MOBILE;
            }
            return string.Empty;
        }

        public static bool IsNumber(string s)
        {
            return s.All(char.IsDigit);
        }

        #endregion

    }
}
