using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AplikacjaWindows.Helpers;
using AplikacjaWindows.Layers.BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AplikacjaWindows.Forms
{
	public partial class Formularz : Form
	{
		public Formularz(TowaryDBEntities context)
		{
			InitializeComponent();
		}

		private void Formularz_Load(object sender, EventArgs e)
		{
			GridFiller.FillTowaryGrid(TowaryGrid);
			GridFiller.FillCenyGrid(CenyGrid);
			GridFiller.FillCennikiGrid(CennikiGrid);
			GridFiller.FillSummaryGrid(PodsumowanieGrid);
		}


		//@@@@@@@@ TOWARY @@@@@@@@@\\

		private void DodajTowarBtn_Click(object sender, EventArgs e)
		{
			using (var addform = new AddEditTowarForm(null))
			{
				if (addform.ShowDialog() == DialogResult.Yes)
				{
					GridFiller.FillTowaryGrid(TowaryGrid);
				}
			}
		}

		private void EdytujTowarBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (var addform = new AddEditTowarForm((Towary)TowaryGrid.CurrentRow.DataBoundItem))
				{
					if (addform.ShowDialog() == DialogResult.Yes)
					{
						GridFiller.FillTowaryGrid(TowaryGrid);
					}
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void UsunTowarBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var towarToDel = (Towary)TowaryGrid.CurrentRow.DataBoundItem;

				if (MessageBox.Show($"Jesteś pewien że chcesz usunąć towar: {towarToDel.Nazwa}", "Formularz Towarowy",
						MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					new ProductBLL().DeleteProduct(towarToDel);

					GridFiller.FillTowaryGrid(TowaryGrid);
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		//@@@@@@@@@@@@@@@ CENY @@@@@@@@@@@@@@@@@\\

		private void DodajCeneBtn_Click(object sender, EventArgs e)
		{
			using (var addform = new AddEditCenyForm(null))
			{
				if (addform.ShowDialog() == DialogResult.Yes)
				{
					GridFiller.FillCenyGrid(CenyGrid);
				}
			}
		}

		private void EdytujCeneBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var selectedPrice = GetSelectedPrice(); //Złapanie zaznaczonej ceny z DataGridView

				using (var addform = new AddEditCenyForm(selectedPrice))
				{
					if (addform.ShowDialog() == DialogResult.Yes)
					{
						GridFiller.FillCenyGrid(CenyGrid);
					}
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void UsunCeneBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var cenaToDel = (Ceny)CenyGrid.CurrentRow.DataBoundItem;

				if (MessageBox.Show($"Jesteś pewien że chcesz usunąć cenę: {cenaToDel.Cena}", "Formularz Towarowy",
						MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					using (TowaryDBEntities context = new TowaryDBEntities())
					{
						context.Cenies.Attach(cenaToDel);
						context.Cenies.Remove(cenaToDel);
						context.SaveChanges();
						GridFiller.FillCenyGrid(CenyGrid);
					}
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		// @@@@@@ CENNIKI @@@@@@ \\

		private void DodajCennikBtn_Click(object sender, EventArgs e)
		{
			using (var addform = new AddEditCennikiForm(null))
			{
				if (addform.ShowDialog() == DialogResult.Yes)
				{
					GridFiller.FillCennikiGrid(CennikiGrid);
				}
			}
		}

		private void EdytujCennikBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (var addform = new AddEditCennikiForm((Cenniki)CennikiGrid.CurrentRow.DataBoundItem/*, _context*/))
				{
					if (addform.ShowDialog() == DialogResult.Yes)
					{
						GridFiller.FillCennikiGrid(CennikiGrid);
					}
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void UsunCennikBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var cennikToDel = (Cenniki)CennikiGrid.CurrentRow.DataBoundItem;

				if (MessageBox.Show($"Jesteś pewien że chcesz usunąć Cennik: {cennikToDel.Nazwa}", "Formularz Towarowy",
						MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					using (TowaryDBEntities context = new TowaryDBEntities())
					{
						context.Cennikis.Attach(cennikToDel);
						context.Cennikis.Remove(cennikToDel);
						context.SaveChanges();
						GridFiller.FillCennikiGrid(CennikiGrid);
					}
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void Wydruk_Click(object sender, EventArgs e)
		{
			PdfCreator pdfCreator = new PdfCreator();

			pdfCreator.CreatePdf(PodsumowanieGrid, "Test");
		}

		private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			GridFiller.FillSummaryGrid(PodsumowanieGrid);
		}

		private Ceny GetSelectedPrice()
		{
			try
			{
				int priceID = Int32.Parse(CenyGrid.CurrentRow.Cells[0].Value.ToString());
				return new PriceBLL().GetPriceByID(priceID);
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Nieoczekiwany błąd", "Błąd", MessageBoxButtons.OK);
				return null;
			}
		}
	}
}
