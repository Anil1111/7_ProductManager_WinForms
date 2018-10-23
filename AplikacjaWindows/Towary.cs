//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;

namespace AplikacjaWindows
{
    using System;
    using System.Collections.Generic;
    
    public partial class Towary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Towary()
        {
            this.Cenies = new HashSet<Ceny>();
        }
    
        public int Id { get; set; }
	    [Required(ErrorMessage = "Kod jest wymagany")]
		[RegularExpression("[0-9][0-9][0-9]-[0-9][0-9][0-9]",ErrorMessage ="Z�y kod. Prawid�owy Format kodu: XXX-XXX")]
		[MaxLength(7, ErrorMessage = "Maksymalna d�ugo�� kodu: 7")]
        public string Kod { get; set; }
		[Required(ErrorMessage = "Nazwa jest wymagana")]
		[MaxLength(255, ErrorMessage="Za d�uga nazwa. Maksymalna ilo�� znak�w: 255")]
        public string Nazwa { get; set; }
	    [Required(ErrorMessage = "Masa wymagana")]
		[Range(0,10000000000000000000,ErrorMessage = "Masa musi by� wi�ksza od 0")]
		public Nullable<decimal> Masa { get; set; }
	    [Required(ErrorMessage = "Prosz� wybra� JM")]
		public string JM { get; set; }
	    [Required]
		public Nullable<System.DateTime> Data_Utworzenia { get; set; }
        public Nullable<System.DateTime> Data_Modyfikacji { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ceny> Cenies { get; set; }
    }
}
