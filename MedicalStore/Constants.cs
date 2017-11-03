using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStore
{
    public static class Constants
    {

        #region Enumerations

        public enum EMPLOYEETYPE
        {
            ADMIN = 1,
            MANAGER = 2,
            STAFF = 3,
            TRAINEE = 4
        }

        #endregion

        #region Constants

        public const string INVALID_LOGIN = "Please enter valid credentials to login";
        public const string HOME = "Home";
        public const string LOG_OUT = "LogOut";
        public const string EXIT = "Exit";
        public const string STOCK = "Stock";
        public const string NEW_STOCK = "New Stock";
        public const string UPDATE_STOCK = "Update Stock";
        public const string DELETE_STOCK = "Delete Stock";
        public const string COMPANY = "Company";
        public const string ADD_COMPANY = "Add Company";
        public const string REMOVE_COMPANY = "Remove Company";
        public const string VIEW_COMPANIES = "View Companies";
        public const string REPORTS = "Reports";
        public const string SALES = "Sales";
        public const string NEW_BILL = "New Bill";
        public const string VIEW_BILLS = "View Bills";
        public const string ADD = "ADD";
        public const string UPDATE = "UPDATE";
        public const string DELETE = "DELETE";
        public const string WELCOME = "WELCOME";
        public const string REGISTRATION_FAILED = "Sorry!!! Registration Failed";
        public const string REGISTRATION_SUCCESS = "Registration Success";
        public const string LOGIN_ID = "Your Login ID is ";
        public const string PASSWORD = "Your password is ";
        public const string PASS = "Pass";
        public const string COMPANY_ADD_SUCCESS = "New company added successfully.";
        public const string COMPANY_DEL_SUCCESS = "Company removed successfully.";
        public const string COMPANY_FAILURE = "Sorry!! An error occured.";
        public const string COMPANY_NONE = "No companies are present. Please add and come back to view";
        public const string STOCK_ADD = "Stock Added Successfully";
        public const string STOCK_ADD_FAIL = "Stock Addition Failed";
        public const string STOCK_DEL_WARNING = "Warning!!!... This will delete the existing stock";
        public const string STOCK_DEL_SUCCESS = "Stock deleted Successfully";
        public const string STOCK_UPDATE_WARNING = "Warning!!!... This will update the existing stock quantity and price details for the item selected";
        public const string STOCK_UPDATE_SUCCESS = "Stock Details Updated Successfully";
        public const string NO_STOCK = "No Stock present at the moment";
        public const string MANDATORY_FIELDS = "Please fill all the fields. It's Mandatory";
        public const string INVALID_MOBILE = "Invalid mobile number";
        public const string INVALID_SALARY = "Invalid salary details";
        public const string HIGH_SALARY = "Sorry!! you are paid too much";
        public const string STOCK_QUANTITY_ERROR = "Invalid stock quantity";
        public const string STOCK_PRICE_ERROR = "Invalid stock price";

        #endregion

    }
}
