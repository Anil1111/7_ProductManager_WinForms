using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AplikacjaWindows.Helpers;
using AplikacjaWindows.Layers.BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rectangle = System.Drawing.Rectangle;

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
					GridFiller.FillCenyGrid(CenyGrid);
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
				var selectedPrice = GetSelectedPrice(); //Złapanie zaznaczonej ceny z DataGridView po ID

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
						new PriceBLL().DeletePrice(cenaToDel);
						GridFiller.FillCenyGrid(CenyGrid);
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
					new PriceListBLL().DeletePriceList(cennikToDel);

					GridFiller.FillCennikiGrid(CennikiGrid);
					GridFiller.FillCenyGrid(CenyGrid);
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
		private void PrintButton_Click(object sender, EventArgs e)
		{
			PrintSummary();
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

		public Bitmap bmp;
		private void PrintSummary()
		{
			int height = PodsumowanieGrid.Height;
			PodsumowanieGrid.Height = PodsumowanieGrid.RowCount * PodsumowanieGrid.RowTemplate.Height *2;
			bmp = new Bitmap(PodsumowanieGrid.Width, PodsumowanieGrid.Height);
			PodsumowanieGrid.DrawToBitmap(bmp, new Rectangle(0,0, PodsumowanieGrid.Width, PodsumowanieGrid.Height));
			PodsumowanieGrid.Height = height;
			printDocument1.DefaultPageSettings.Landscape = true;
			printPreviewDialog1.ShowDialog();

		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bmp, 0, 0);
		}
	}
}
