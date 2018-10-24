using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaWindows.ViewModels
{
	public class SummaryViewModel
	{
		public string ProductName { get; set; }
		public string ProductCode { get; set; }
		public decimal ProductPrice { get; set; }
		public decimal? Discount { get; set; }
		public decimal? ProductWeight { get; set; }
		public string UnitWeight { get; set; }
		public string Promotion { get; set; }
		public DateTime? PromoStart { get; set; }
		public DateTime? PromoEnd { get; set; }
	}
}
