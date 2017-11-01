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
    public partial class HomePage : UserControl
    {
        private static HomePage _instance;
        public static HomePage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomePage();
                return _instance;
            }
        }
        public HomePage()
        {
            InitializeComponent();
            GetAllEmployees();
            GetAllEmployeeLookUpData();
            if (LoginUC.EMP_TYPE == 1 || LoginUC.EMP_TYPE == 2)
            {
                tabControl1.Show();
            }
            else
            {
                tabControl1.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int e_id = 0;
                using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
                {

                    System.Data.Entity.Core.Objects.ObjectParameter objParam = new System.Data.Entity.Core.Objects.ObjectParameter("eid", typeof(Int32));
                    var eid = context.INS_Employee(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(comboBox1.SelectedValue)
                        , Convert.ToInt32(textBox5.Text), objParam);
                    e_id = Convert.ToInt32(objParam.Value);

                }
                if (e_id > 0)
                {
                    using (Medical_StoreEntitiy context1 = new Medical_StoreEntitiy())
                    {
                        string loginid = textBox1.Text + GenerateRandomNo();
                        string pass = "Pass" + GenerateRandomNo();
                        var aaa = context1.INS_Login(loginid, pass, e_id);
                        MessageBox.Show("Registration Success" + Environment.NewLine +
                        "Your Login ID is " + loginid + Environment.NewLine +
                        "Your password is " + pass + Environment.NewLine);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry!!! Registration Failed");
                }
                ClearAllFields();
            }
            catch (Exception ex)
            {
                ClearAllFields();
                MessageBox.Show("Sorry!!! Registration Failed");
            }
        }
        private void GetAllEmployees()
        {
            using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
            {
                var result = context.GET_Employees().ToList();
                dataGridView1.DataSource = result;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
        }

        public void GetAllEmployeeLookUpData()
        {
            using (Medical_StoreEntitiy context = new Medical_StoreEntitiy())
            {
                var result = context.GET_Employee_LookUp().ToList();

                Dictionary<string, string> item = new Dictionary<string, string>();
                foreach (var c in result)
                {
                    item.Add(c.Id.ToString(), c.Type);

                }
                comboBox1.DataSource = new BindingSource(item, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
            }
        }

        public int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private void ClearAllFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = 0;
        }
    }
}
