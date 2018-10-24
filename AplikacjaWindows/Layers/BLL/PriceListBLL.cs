using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikacjaWindows.Layers.DAL;

namespace AplikacjaWindows.Layers.BLL
{
	public class PriceListBLL
	{
		private PriceListsTableAdapter _priceListsAdapter;

		protected PriceListsTableAdapter Adapter
		{
			get
			{
				if (_priceListsAdapter == null)
					_priceListsAdapter = new PriceListsTableAdapter();

				return _priceListsAdapter;
			}
		}

		public IEnumerable<Cenniki> GetPriceLists()
		{
			return Adapter.GetAllRecords();
		}

		public void AddPriceList(Cenniki priceList)
		{
			Adapter.CreateRecord(priceList);
		}

		public void EditPriceList(Cenniki priceList)
		{
			Adapter.UpdateRecord(priceList);
		}

		public void DeletePriceList(Cenniki priceList)
		{
			Adapter.DeleteRecord(priceList);
		}


	}
}
