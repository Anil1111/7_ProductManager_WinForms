//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplikacjaWindows
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ceny
    {
        public int Id { get; set; }
        public Nullable<int> CennikId { get; set; }
        public Nullable<int> TowarId { get; set; }
        public decimal Cena { get; set; }
        public Nullable<decimal> Rabat { get; set; }
    
        public virtual Cenniki Cenniki { get; set; }
        public virtual Towary Towary { get; set; }
    }
}
