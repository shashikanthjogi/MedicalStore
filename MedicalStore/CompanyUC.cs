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
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                try
                {
                    var result = context.INS_Company(txtCompanyName.Text,
                        txtDealerName.Text,
                        txtAddress.Text,
                        Convert.ToInt32(txtMobile.Text)
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

        private void btnDel_Click(object sender, EventArgs e)
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
                    dgCompanyList.DataSource = null;
                    cmbCompanies.DataSource = null;
                    MessageBox.Show(Constants.COMPANY_NONE);
                }
            }
        }

        #endregion

        
    }
}
