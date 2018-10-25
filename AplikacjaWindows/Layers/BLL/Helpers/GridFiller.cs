using System;
using System.Linq;
using System.Windows.Forms;
using AplikacjaWindows.ViewModels;

namespace AplikacjaWindows.Layers.BLL.Helpers
{
	public static class GridFiller
	{
		public static void FillProductsGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = false;

			grid.DataSource = new ProductBLL().GetProducts();

			var productIndex = 1;
			foreach (DataGridViewRow rows in grid.Rows)
			{
				rows.HeaderCell.Value = productIndex++.ToString();
			}
		}

		public static void FillPricesGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = false;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				var prices = (from a in context.Cenies

							  select new PricesViewModel
							  {
								  PriceId = a.Id,
								  Price = a.Cena,
								  Discount = a.Rabat,
								  PriceListName = a.Cenniki.Nazwa,
								  ProductName = a.Towary.Nazwa
							  }).ToList();

				grid.DataSource = prices;

				var priceIndex = 1;
				foreach (DataGridViewRow rows in grid.Rows)
				{
					rows.HeaderCell.Value = priceIndex++.ToString();
				}
			}

		}

		public static void FillPriceListsGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = false;

			grid.DataSource = new PriceListBLL().GetPriceLists();

			var priceListIndex = 1;
			foreach (DataGridViewRow rows in grid.Rows)
			{
				rows.HeaderCell.Value = priceListIndex++.ToString();
			}
		}

		public static void FillSummaryGrid(DataGridView grid)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				var summaryGrid = (from a in context.Cenies

								   select new SummaryViewModel()
								   {
									   ProductName = a.Towary.Nazwa,
									   ProductCode = a.Towary.Kod,
									   ProductPrice = a.Cena,
									   Discount = a.Rabat,
									   ProductWeight = a.Towary.Masa,
									   UnitWeight = a.Towary.JM,
									   Promotion = a.Cenniki.Nazwa,
									   PromoStart = a.Cenniki.Data_Od,
									   PromoEnd = a.Cenniki.Data_Do
								   }).ToList();

				grid.AutoGenerateColumns = false;

				grid.DataSource = summaryGrid;
			}

			var summaryIndex = 1;
			foreach (DataGridViewRow rows in grid.Rows)
			{
				rows.HeaderCell.Value = summaryIndex++.ToString();
			}

			//Obliczanie wartosci z uwzglednieniem rabatu
			foreach (DataGridViewRow row in grid.Rows)
			{
				try
				{
					row.Cells[grid.Columns["CenaZRabatem"].Index].Value =
						(1 - Convert.ToDouble(row.Cells[grid.Columns["Discount"].Index].Value) / 100) *
						Convert.ToDouble(row.Cells[grid.Columns["ProductPrice"].Index].Value);
				}
				catch (Exception)
				{
					continue;
				}
			}
		}
	}
}
