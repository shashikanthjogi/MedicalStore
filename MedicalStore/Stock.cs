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
    
    public partial class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int TotalQuantity { get; set; }
        public int SellQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int TotalPrice { get; set; }
        public int SellPrice { get; set; }
        public int AvailablePrice { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
