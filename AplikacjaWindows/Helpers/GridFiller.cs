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
		public static void FillTowaryGrid(DataGridView towaryGrid)
		{
			towaryGrid.AutoGenerateColumns = false;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				towaryGrid.DataSource = context.Towaries.ToList();
			}
		}

		public static void FillCenyGrid(DataGridView cenyGrid)
		{
			cenyGrid.AutoGenerateColumns = false;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				cenyGrid.DataSource = context.Cenies.ToList();
			}
		}

		public static void FillCennikiGrid(DataGridView cennikiGrid)
		{
			cennikiGrid.AutoGenerateColumns = false;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				cennikiGrid.DataSource = context.Cennikis.ToList();
			}
		}

		public static void FillSummaryGrid(DataGridView summaryGrid)
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
				summaryGrid.AutoGenerateColumns = false;
				summaryGrid.DataSource = dt;
			}
			catch (Exception exception)
			{
				MessageBox.Show("Błąd z polaczeniem do bazy danych", "Błąd", MessageBoxButtons.OK);
			}

			foreach (DataGridViewRow row in summaryGrid.Rows)
			{
				try
				{
					row.Cells[summaryGrid.Columns["CenaZRabatem"].Index].Value =
						(1 - Convert.ToDouble(row.Cells[summaryGrid.Columns["RabatTowaru"].Index].Value) / 100) *
						Convert.ToDouble(row.Cells[summaryGrid.Columns["CenaTowaruX"].Index].Value);
				}
				catch (Exception exception)
				{
					continue;
				}
			}
		}
	}
}
