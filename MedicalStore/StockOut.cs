//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class StockOut
    {
        public int O_Id { get; set; }
        public int O_CompanyId { get; set; }
        public string O_StockName { get; set; }
        public int O_Quantity { get; set; }
        public int O_Price { get; set; }
        public System.DateTime O_Date { get; set; }
        public string O_Description { get; set; }
        public string O_RemoveBy { get; set; }
        public Nullable<System.Guid> O_SalesId { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
