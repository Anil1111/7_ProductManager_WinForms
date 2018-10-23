using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AplikacjaWindows.Helpers
{
	public static class GridFiller
	{
		public static void FillTowaryGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = false;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{

				grid.DataSource = context.Towaries.ToList();

				var index = 1;
				foreach (DataGridViewRow rows in grid.Rows)
				{
					rows.HeaderCell.Value = index++.ToString();
				}
			}
		}

		public static void FillCenyGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = false;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				grid.DataSource = context.Cenies.ToList();

				var index = 1;
				foreach (DataGridViewRow rows in grid.Rows)
				{
					rows.HeaderCell.Value = index++.ToString();
				}
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
				SqlConnection con =
					new SqlConnection(
						@"data source=PAT-LAPTOP\SQLEXPRESS;initial catalog=TowaryDB;integrated security=True");
				SqlDataAdapter sda =
					new SqlDataAdapter(
						@"SELECT * FROM CENY FULL OUTER JOIN Towary ON Ceny.TowarId = Towary.Id FULL OUTER JOIN Cenniki ON Ceny.CennikId = Cenniki.Id",
						con);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				grid.AutoGenerateColumns = false;
				grid.DataSource = dt;

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
						(1 - Convert.ToDouble(row.Cells[grid.Columns["RabatTowaru"].Index].Value) / 100) *
						Convert.ToDouble(row.Cells[grid.Columns["CenaTowaruX"].Index].Value);
				}
				catch (Exception exception)
				{
					continue;
				}
			}
		}
	}
}
