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
    
    public partial class Cenniki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cenniki()
        {
            this.Cenies = new HashSet<Ceny>();
        }
    
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public Nullable<System.DateTime> Data_Od { get; set; }
        public Nullable<System.DateTime> Data_Do { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ceny> Cenies { get; set; }
    }
}
