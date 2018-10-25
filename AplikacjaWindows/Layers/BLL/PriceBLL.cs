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
			try
			{
				Adapter.CreateRecord(cena);
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
			catch (FormatException exception)
			{

				MessageBox.Show("Błąd", "Błąd", MessageBoxButtons.OK);
			}
		}

		public void EditPrice(Ceny cena)
		{
			try
			{
				Adapter.UpdateRecord(cena);
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
			catch (FormatException exception)
			{
				MessageBox.Show("Błąd", "Błąd", MessageBoxButtons.OK);

			}
		}

		public void DeletePrice(Ceny cena)
		{
			Adapter.DeleteRecord(cena);
		}

	}
}
