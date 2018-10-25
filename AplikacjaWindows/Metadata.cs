using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaWindows
{
	public class TowaryMetadata
	{
		[Required(ErrorMessage = "Kod jest wymagany")]
		[RegularExpression("[0-9][0-9][0-9]-[0-9][0-9][0-9]", ErrorMessage = "Zły kod. Prawidłowy Format kodu: XXX-XXX")]
		[MaxLength(7, ErrorMessage = "Maksymalna długość kodu: 7")]
		public string Kod { get; set; }
		[Required(ErrorMessage = "Nazwa jest wymagana")]
		[MaxLength(255, ErrorMessage = "Za długa nazwa. Maksymalna ilość znaków: 255")]
		public string Nazwa { get; set; }
		[Required(ErrorMessage = "Masa jest wymagana")]
		[Range(0, 10000000000000000000, ErrorMessage = "Masa musi być większa od 0")]
		public Nullable<decimal> Masa { get; set; }
		[Required(ErrorMessage = "Proszę wybrać JM")]
		public string JM { get; set; }
		[Required(ErrorMessage = "Data utworzenia jest wymagana")]
		public Nullable<System.DateTime> Data_Utworzenia { get; set; }
	}

	public class CenyMetadata
	{
		[Required(ErrorMessage = "Cennik jest wymagany")]
		public Nullable<int> CennikId { get; set; }
		[Required(ErrorMessage = "Towar jest wymagany")]
		public Nullable<int> TowarId { get; set; }
		[Required(ErrorMessage = "Cena jest wymagana")]
		[Range(0.01, 10000000000000000000)]
		public decimal Cena { get; set; }
		[Required(ErrorMessage = "Rabat jest wymagany")]
		[Range(0, 100)]
		public Nullable<decimal> Rabat { get; set; }
	}

	public class CennikiMetadata
	{
		[Required(ErrorMessage = "Nazwa jest wymagana")]
		public string Nazwa { get; set; }
		[Required(ErrorMessage = "Data Rozpoczęcia jest wymagana")]
		public Nullable<System.DateTime> Data_Od { get; set; }
		[Required(ErrorMessage = "Data Zakonczenia jest wymagana")]
		public Nullable<System.DateTime> Data_Do { get; set; }
	}

}
