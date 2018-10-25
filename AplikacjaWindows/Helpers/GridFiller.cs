using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using AplikacjaWindows.Layers.BLL;
using AplikacjaWindows.ViewModels;

namespace AplikacjaWindows.Helpers
{
	public static class GridFiller
	{
		public static void FillTowaryGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = false;

			grid.DataSource = new ProductBLL().GetProducts();

			var index = 1;
			foreach (DataGridViewRow rows in grid.Rows)
			{
				rows.HeaderCell.Value = index++.ToString();
			}
		}

		public static void FillCenyGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = false;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				var prices = (from a in context.Cenies

							  select new PricesViewModel
							  {
								  CenaId = a.Id,
								  Cena = a.Cena,
								  Rabat = a.Rabat,
								  CennikNazwa = a.Cenniki.Nazwa,
								  TowarNazwa = a.Towary.Nazwa
							  }).ToList();

				grid.DataSource = prices;
			}
			var index = 1;
			foreach (DataGridViewRow rows in grid.Rows)
			{
				rows.HeaderCell.Value = index++.ToString();
			}
		}

		public static void FillCennikiGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = false;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				grid.DataSource = context.Cennikis.ToList();

				var index = 1;
				foreach (DataGridViewRow rows in grid.Rows)
				{
					rows.HeaderCell.Value = index++.ToString();
				}
			}
		}

		public static void FillSummaryGrid(DataGridView grid)
		{
			try
			{
				using (TowaryDBEntities context = new TowaryDBEntities())
				{
					var result = (from a in context.Cenies

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
					grid.DataSource = result;
				}

				var index = 1;
				foreach (DataGridViewRow rows in grid.Rows)
				{
					rows.HeaderCell.Value = index++.ToString();
				}

			}
			catch (Exception exception)
			{
				MessageBox.Show("Błąd z polaczeniem do bazy danych", "Błąd", MessageBoxButtons.OK);
			}

			foreach (DataGridViewRow row in grid.Rows)
			{
				try
				{
					row.Cells[grid.Columns["CenaZRabatem"].Index].Value =
						(1 - Convert.ToDouble(row.Cells[grid.Columns["Discount"].Index].Value) / 100) *
						Convert.ToDouble(row.Cells[grid.Columns["ProductPrice"].Index].Value);
				}
				catch (Exception exception)
				{
					continue;
				}
			}
		}
	}
}
