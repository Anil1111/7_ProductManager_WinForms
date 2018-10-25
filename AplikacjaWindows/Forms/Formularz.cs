using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AplikacjaWindows.Layers.BLL;
using AplikacjaWindows.Layers.BLL.Helpers;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rectangle = System.Drawing.Rectangle;

namespace AplikacjaWindows.Forms
{
	public partial class MainForm : Form
	{
		public Bitmap Bmp;
		public MainForm()
		{
			InitializeComponent();
		}

		private void Formularz_Load(object sender, EventArgs e)
		{
			GridFiller.FillProductsGrid(ProductsGrid);
			GridFiller.FillPricesGrid(CenyGrid);
			GridFiller.FillPriceListsGrid(CennikiGrid);
			GridFiller.FillSummaryGrid(PodsumowanieGrid);
		}


		//@@@@@@@@ TOWARY @@@@@@@@@\\

		private void AddProductBtn_Click(object sender, EventArgs e)
		{
			using (var addform = new AddEditTowarForm(null))
			{
				if (addform.ShowDialog() == DialogResult.Yes)
				{
					GridFiller.FillProductsGrid(ProductsGrid);
				}
			}
		}

		private void EditProductBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (var addform = new AddEditTowarForm((Towary)ProductsGrid.CurrentRow.DataBoundItem))
				{
					if (addform.ShowDialog() == DialogResult.Yes)
					{
						GridFiller.FillProductsGrid(ProductsGrid);
					}
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void DeleteProductBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var towarToDel = (Towary)ProductsGrid.CurrentRow.DataBoundItem;

				if (MessageBox.Show($"Jesteś pewien że chcesz usunąć towar: {towarToDel.Nazwa}", "Formularz Towarowy",
						MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					new ProductBLL().DeleteProduct(towarToDel);

					GridFiller.FillProductsGrid(ProductsGrid);
					GridFiller.FillPricesGrid(CenyGrid);
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}

		}

		//@@@@@@@@@@@@@@@ CENY @@@@@@@@@@@@@@@@@\\

		private void AddPriceBtn_Click(object sender, EventArgs e)
		{
			using (var addform = new AddEditCenyForm(null))
			{
				if (addform.ShowDialog() == DialogResult.Yes)
				{
					GridFiller.FillPricesGrid(CenyGrid);
				}
			}
		}

		private void EditPriceBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var selectedPrice = GetSelectedPrice(); //Złapanie zaznaczonej ceny z DataGridView po ID

				using (var addform = new AddEditCenyForm(selectedPrice))
				{
					if (addform.ShowDialog() == DialogResult.Yes)
					{
						GridFiller.FillPricesGrid(CenyGrid);
					}
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void DeletePriceBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var cenaToDel = (Ceny)CenyGrid.CurrentRow.DataBoundItem;

				if (MessageBox.Show($"Jesteś pewien że chcesz usunąć cenę: {cenaToDel.Cena}", "Formularz Towarowy",
						MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					new PriceBLL().DeletePrice(cenaToDel);
					GridFiller.FillPricesGrid(CenyGrid);
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		// @@@@@@ CENNIKI @@@@@@ \\

		private void AddPriceListBtn_Click(object sender, EventArgs e)
		{
			using (var addform = new AddEditCennikiForm(null))
			{
				if (addform.ShowDialog() == DialogResult.Yes)
				{
					GridFiller.FillPriceListsGrid(CennikiGrid);
				}
			}
		}

		private void EditPriceListBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (var addform = new AddEditCennikiForm((Cenniki)CennikiGrid.CurrentRow.DataBoundItem))
				{
					if (addform.ShowDialog() == DialogResult.Yes)
					{
						GridFiller.FillPriceListsGrid(CennikiGrid);
					}
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void DeletePriceListBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var cennikToDel = (Cenniki)CennikiGrid.CurrentRow.DataBoundItem;

				if (MessageBox.Show($"Jesteś pewien że chcesz usunąć Cennik: {cennikToDel.Nazwa}", "Formularz Towarowy",
						MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					new PriceListBLL().DeletePriceList(cennikToDel);

					GridFiller.FillPriceListsGrid(CennikiGrid);
					GridFiller.FillPricesGrid(CenyGrid);
				}
			}
			catch (NullReferenceException exception)
			{
				MessageBox.Show(exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void ExportPDF_Click(object sender, EventArgs e)
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
			GridFiller.FillPricesGrid(CenyGrid);
			GridFiller.FillPriceListsGrid(CennikiGrid);
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

		private void PrintSummary()
		{
			Bmp = new Bitmap(PodsumowanieGrid.Width, PodsumowanieGrid.Height);
			PodsumowanieGrid.DrawToBitmap(Bmp, new Rectangle(0, 0, PodsumowanieGrid.Width, PodsumowanieGrid.Height));

			printSummaryGrid.DefaultPageSettings.Landscape = true;
			printPreview.ShowDialog();

		}

		private void printSummaryGrid_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(Bmp, 0, 0);
		}
	}
}
