namespace AplikacjaWindows.ViewModels
{
	public class PricesViewModel
	{
		public int PriceId { get; set; }
		public decimal Price { get; set; }
		public decimal? Discount { get; set; }
		public string ProductName { get; set; }
		public string PriceListName { get; set; }
	}
}
