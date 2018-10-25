using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
			try
			{
				if (priceList.Data_Od <= priceList.Data_Do)
				{
					Adapter.CreateRecord(priceList);
				}
				else
				{
					MessageBox.Show("Data rozpoczęcia nie może byc wcześniej niż data późniejsza", "Błąd",
						MessageBoxButtons.OK);
				}
			}
			catch (DbEntityValidationException exception)
			{
				foreach (var e in exception.EntityValidationErrors)
				{
					foreach (var x in e.ValidationErrors)
					{
						MessageBox.Show(x.ErrorMessage, "Błąd", MessageBoxButtons.OK);
					}
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Nierozpoznany Błąd", "Błąd", MessageBoxButtons.OK);
			}
		}

		public void EditPriceList(Cenniki priceList)
		{
			try
			{
				Adapter.UpdateRecord(priceList);
			}
			catch (DbEntityValidationException exception)
			{
				foreach (var e in exception.EntityValidationErrors)
				{
					foreach (var x in e.ValidationErrors)
					{
						MessageBox.Show(x.ErrorMessage, "Błąd", MessageBoxButtons.OK);
					}
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Błąd", "Błąd", MessageBoxButtons.OK);

			}
		}

		public void DeletePriceList(Cenniki priceList)
		{
			try
			{
				Adapter.DeleteRecord(priceList);
			}
			catch (System.Data.Entity.Infrastructure.DbUpdateException)
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
