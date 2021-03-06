﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalStore
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MedicalDBEntityModelConnection : DbContext
    {
        public MedicalDBEntityModelConnection()
            : base("name=MedicalDBEntityModelConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_LookUp> Employee_LookUp { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StockIn> StockIns { get; set; }
        public virtual DbSet<StockOut> StockOuts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    
        public virtual int DEL_Company(Nullable<int> companyId)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("CompanyId", companyId) :
                new ObjectParameter("CompanyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DEL_Company", companyIdParameter);
        }
    
        public virtual int DEL_Stock(string name, string description, Nullable<System.DateTime> c_Date, string createdBy)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var c_DateParameter = c_Date.HasValue ?
                new ObjectParameter("C_Date", c_Date) :
                new ObjectParameter("C_Date", typeof(System.DateTime));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DEL_Stock", nameParameter, descriptionParameter, c_DateParameter, createdByParameter);
        }
    
        public virtual ObjectResult<GET_Companies_Result> GET_Companies()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_Companies_Result>("GET_Companies");
        }
    
        public virtual ObjectResult<GET_Employee_LookUp_Result> GET_Employee_LookUp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_Employee_LookUp_Result>("GET_Employee_LookUp");
        }
    
        public virtual ObjectResult<GET_StockDetails_Result> GET_StockDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_StockDetails_Result>("GET_StockDetails");
        }
    
        public virtual ObjectResult<GET_ValidateLogin_Result> GET_ValidateLogin(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_ValidateLogin_Result>("GET_ValidateLogin", userNameParameter, passwordParameter);
        }
    
        public virtual int INS_Company(string companyName, string dealerName, string address, Nullable<long> mobile)
        {
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var dealerNameParameter = dealerName != null ?
                new ObjectParameter("DealerName", dealerName) :
                new ObjectParameter("DealerName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var mobileParameter = mobile.HasValue ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_Company", companyNameParameter, dealerNameParameter, addressParameter, mobileParameter);
        }
    
        public virtual int INS_Employee(string firstName, string lastName, string address, Nullable<long> mobile, Nullable<int> designation_Id, Nullable<int> salary, ObjectParameter eId)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var mobileParameter = mobile.HasValue ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(long));
    
            var designation_IdParameter = designation_Id.HasValue ?
                new ObjectParameter("Designation_Id", designation_Id) :
                new ObjectParameter("Designation_Id", typeof(int));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_Employee", firstNameParameter, lastNameParameter, addressParameter, mobileParameter, designation_IdParameter, salaryParameter, eId);
        }
    
        public virtual int INS_Login(string uName, string pass, Nullable<int> eId)
        {
            var uNameParameter = uName != null ?
                new ObjectParameter("UName", uName) :
                new ObjectParameter("UName", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("Pass", pass) :
                new ObjectParameter("Pass", typeof(string));
    
            var eIdParameter = eId.HasValue ?
                new ObjectParameter("EId", eId) :
                new ObjectParameter("EId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_Login", uNameParameter, passParameter, eIdParameter);
        }
    
        public virtual int INS_StockIn(string name, string description, Nullable<int> quantity, Nullable<int> price, Nullable<int> companyId, Nullable<System.DateTime> e_Date, Nullable<System.DateTime> c_Date, string createdBy)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("CompanyId", companyId) :
                new ObjectParameter("CompanyId", typeof(int));
    
            var e_DateParameter = e_Date.HasValue ?
                new ObjectParameter("E_Date", e_Date) :
                new ObjectParameter("E_Date", typeof(System.DateTime));
    
            var c_DateParameter = c_Date.HasValue ?
                new ObjectParameter("C_Date", c_Date) :
                new ObjectParameter("C_Date", typeof(System.DateTime));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_StockIn", nameParameter, descriptionParameter, quantityParameter, priceParameter, companyIdParameter, e_DateParameter, c_DateParameter, createdByParameter);
        }
    
        public virtual int UPD_StockIn(Nullable<int> sid, string name, Nullable<int> quantity, Nullable<int> price, string description, Nullable<System.DateTime> c_Date, string createdBy)
        {
            var sidParameter = sid.HasValue ?
                new ObjectParameter("Sid", sid) :
                new ObjectParameter("Sid", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var c_DateParameter = c_Date.HasValue ?
                new ObjectParameter("C_Date", c_Date) :
                new ObjectParameter("C_Date", typeof(System.DateTime));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPD_StockIn", sidParameter, nameParameter, quantityParameter, priceParameter, descriptionParameter, c_DateParameter, createdByParameter);
        }
    
        public virtual ObjectResult<GET_Employees_Result1> GET_Employees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_Employees_Result1>("GET_Employees");
        }
    
        public virtual int INS_Sales()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_Sales");
        }
    
        public virtual int INS_Salestest()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_Salestest");
        }
    
        public virtual int INS_Customer(string name, Nullable<long> mobile, Nullable<System.Guid> salesId, Nullable<int> totalBill)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var mobileParameter = mobile.HasValue ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(long));
    
            var salesIdParameter = salesId.HasValue ?
                new ObjectParameter("SalesId", salesId) :
                new ObjectParameter("SalesId", typeof(System.Guid));
    
            var totalBillParameter = totalBill.HasValue ?
                new ObjectParameter("TotalBill", totalBill) :
                new ObjectParameter("TotalBill", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INS_Customer", nameParameter, mobileParameter, salesIdParameter, totalBillParameter);
        }
    
        public virtual ObjectResult<GET_CompanyByStockName_Result> GET_CompanyByStockName(string stockName)
        {
            var stockNameParameter = stockName != null ?
                new ObjectParameter("StockName", stockName) :
                new ObjectParameter("StockName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_CompanyByStockName_Result>("GET_CompanyByStockName", stockNameParameter);
        }
    
        public virtual int UPD_MainStock(string name, Nullable<int> quantity, Nullable<int> price)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPD_MainStock", nameParameter, quantityParameter, priceParameter);
        }
    
        public virtual ObjectResult<GET_SalesDetails_Result> GET_SalesDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_SalesDetails_Result>("GET_SalesDetails");
        }
    
        public virtual ObjectResult<GET_SearchStock_Result> GET_SearchStock(string stockName)
        {
            var stockNameParameter = stockName != null ?
                new ObjectParameter("StockName", stockName) :
                new ObjectParameter("StockName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_SearchStock_Result>("GET_SearchStock", stockNameParameter);
        }
    }
}
