using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MedicalStore
{
    public partial class HomePage : UserControl
    {

        #region Constructor

        public HomePage()
        {
            InitializeComponent();
            GetAllEmployees();
            GetAllEmployeeLookUpData();
            if (LoginUC.employeeType == (int)Constants.EMPLOYEETYPE.ADMIN || LoginUC.employeeType == (int)Constants.EMPLOYEETYPE.MANAGER)
                tbHome.Show();
            else
                tbHome.Hide();
        }

        #endregion

        #region Fields

        private static HomePage _instance;
        public static HomePage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomePage();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        #endregion

        #region Events

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string error = ValidateFields();
            if (string.IsNullOrEmpty(error))
            {
                try
                {
                    int employeeId = 0;
                    using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
                    {

                        System.Data.Entity.Core.Objects.ObjectParameter objParam = new System.Data.Entity.Core.Objects.ObjectParameter("eid", typeof(Int32));
                        var eid = context.INS_Employee(txtFName.Text, txtLName.Text, txtAddress.Text, Convert.ToInt64(txtMobile.Text), Convert.ToInt32(cmbDesignation.SelectedValue)
                            , Convert.ToInt32(txtSalary.Text), objParam);
                        employeeId = Convert.ToInt32(objParam.Value);

                    }
                    if (employeeId > 0)
                    {
                        using (MedicalDBEntityModelConnection loginContext = new MedicalDBEntityModelConnection())
                        {
                            string loginId = txtFName.Text + CommonHelper.GenerateRandomNo();
                            string password = Constants.PASS + CommonHelper.GenerateRandomNo();
                            var aaa = loginContext.INS_Login(loginId, password, employeeId);
                            MessageBox.Show(Constants.REGISTRATION_SUCCESS + Environment.NewLine +
                            Constants.LOGIN_ID + loginId + Environment.NewLine +
                            Constants.PASSWORD + password + Environment.NewLine);
                        }
                        GetAllEmployees();
                    }
                    else
                    {
                        MessageBox.Show(Constants.REGISTRATION_FAILED);
                    }
                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    ClearAllFields();
                    MessageBox.Show(Constants.REGISTRATION_FAILED);
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        #endregion

        #region Methods

        private void GetAllEmployees()
        {
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                var employeeList = context.GET_Employees().ToList();
                dgViewEmp.DataSource = employeeList;
                dgViewEmp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
        }

        public void GetAllEmployeeLookUpData()
        {
            using (MedicalDBEntityModelConnection context = new MedicalDBEntityModelConnection())
            {
                var employyeLookUp = context.GET_Employee_LookUp().ToList();

                Dictionary<string, string> item = new Dictionary<string, string>();
                foreach (var c in employyeLookUp)
                {
                    item.Add(c.Id.ToString(), c.Type);

                }
                cmbDesignation.DataSource = new BindingSource(item, null);
                cmbDesignation.DisplayMember = "Value";
                cmbDesignation.ValueMember = "Key";
            }
        }

        private void ClearAllFields()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtMobile.Clear();
            txtAddress.Clear();
            txtSalary.Clear();
            cmbDesignation.SelectedIndex = 0;
        }

        private string ValidateFields()
        {
            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(txtMobile.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtSalary.Text))
            {
                return Constants.MANDATORY_FIELDS;
            }
            return ValidateMobileAndSalary();
        }

        private string ValidateMobileAndSalary()
        {
            if (!CommonHelper.IsNumber(txtMobile.Text))
            {
                txtMobile.Focus();
                return Constants.INVALID_MOBILE;
            }
            if (txtMobile.Text.Length != 10)
            {
                txtMobile.Focus();
                return Constants.INVALID_MOBILE;
            }
            if (!CommonHelper.IsNumber(txtSalary.Text))
            {
                txtSalary.Focus();
                return Constants.INVALID_SALARY;
            }
            if (txtSalary.Text.Length > 5)
            {
                txtSalary.Focus();
                return Constants.HIGH_SALARY;
            }
            return string.Empty;
        }

        #endregion

    }
}
