using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
			try
			{
				Adapter.DeleteRecord(priceList);
			}
			catch (System.Data.Entity.Infrastructure.DbUpdateException exception)
			{
				if (MessageBox.Show(
						"Wybrany Cennik zawiera powiązanie w cenach. Kliknij OK, aby usunąć te powiązania i usunąć Cennik, Anuluj aby zakończyć proces usuwania",
						"Błąd", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					var prices = new PricesTableAdapter().GetAllRecords();
					var allPricesRelatedToPriceList = prices.Where(x => x.CennikId == priceList.Id).Select(x => x);

					foreach (var element in allPricesRelatedToPriceList)
					{
						new PricesTableAdapter().DeleteRecord(element);
					}

					Adapter.DeleteRecord(priceList);
					MessageBox.Show("Usuwanie zakonczone pomyślnie", "Sukces", MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("Usuwanie zakonczone niepowodzeniem", "Niepowodzenie", MessageBoxButtons.OK);
				}
			}
		}
	}
}
