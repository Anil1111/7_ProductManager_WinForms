using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using AplikacjaWindows.Layers.DAL;

namespace AplikacjaWindows.Layers.BLL
{
	public class ProductBLL
	{
		private ProductsTableAdapter _productsAdapter;

		protected ProductsTableAdapter Adapter
		{
			get
			{
				if (_productsAdapter == null)
					_productsAdapter = new ProductsTableAdapter();

				return _productsAdapter;
			}
		}

		public IEnumerable<Towary> GetProducts()
		{
			return Adapter.GetAllRecords();
		}

		public void AddProduct(Towary product)
		{
			try
			{
				Adapter.CreateRecord(product);
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

				MessageBox.Show("Nieprawidłowy format pola Masa. Dopuszczalne tylko liczby", "Błąd",
					MessageBoxButtons.OK);
			}
		}

		public void EditProduct(Towary product)
		{
			try
			{
				Adapter.UpdateRecord(product);
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
				MessageBox.Show("Nieprawidłowy format pola Masa. Dopuszczalne tylko liczby ", "Błąd", MessageBoxButtons.OK);

			}
		}

		public void DeleteProduct(Towary product)
		{
			try
			{
				Adapter.DeleteRecord(product);
			}
			catch (System.Data.Entity.Infrastructure.DbUpdateException)
			{
				if (MessageBox.Show(
						"Wybrany towar zawiera powiązanie w cennikach lub cenach. Kliknij OK, aby usunąć te powiązania i usunąć towar, Anuluj aby zakończyć proces usuwania",
						"Błąd", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					var prices = new PricesTableAdapter().GetAllRecords();
					var allPricesRelatedToProduct = prices.Where(x => x.TowarId == product.Id).Select(x => x);

					foreach (var element in allPricesRelatedToProduct)
					{
						new PricesTableAdapter().DeleteRecord(element);
					}
					Adapter.DeleteRecord(product);
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
