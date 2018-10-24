using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikacjaWindows.Layers.DAL;

namespace AplikacjaWindows.Layers.BLL
{
	public class PriceBLL
	{
		private PricesTableAdapter _pricesAdapter;

		protected PricesTableAdapter Adapter
		{
			get
			{
				if (_pricesAdapter == null)
					_pricesAdapter = new PricesTableAdapter();

				return _pricesAdapter;
			}
		}

		public IEnumerable<Ceny> GetPrices()
		{
			return Adapter.GetAllRecords();
		}

		public Ceny GetPriceByID(int id)
		{
			return Adapter.GetRecordByID(id);
		}

		public void AddPrice(Ceny cena)
		{
			Adapter.CreateRecord(cena);
		}

		public void EditPrice(Ceny cena)
		{
			Adapter.UpdateRecord(cena);
		}

		public void DeletePrice(Ceny cena)
		{
			Adapter.DeleteRecord(cena);
		}

	}
}
