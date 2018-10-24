using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AplikacjaWindows.Helpers
{
	public class PdfCreator
	{

		public void CreatePdf(DataGridView dataGrid, string filename) 
		{
			BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
			PdfPTable pdftable = new PdfPTable(dataGrid.Columns.Count);
			pdftable.DefaultCell.Padding = 3;
			pdftable.WidthPercentage = 100;
			pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
			pdftable.DefaultCell.BorderWidth = 1;

			Font text = new Font(bf, 10, iTextSharp.text.Font.NORMAL);

			//Naglowek
			foreach (DataGridViewColumn column in dataGrid.Columns)
			{
				PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
				cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
				pdftable.AddCell(cell);
			}

			//Wiersze
			foreach (DataGridViewRow row in dataGrid.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					try
					{
						pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
					}
					catch (NullReferenceException)
					{
					continue;
					}
				}
			}

			var saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = filename;
			saveFileDialog.DefaultExt = ".pdf";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
					{
						Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0);
						PdfWriter.GetInstance(pdfDoc, stream);

						pdfDoc.Open();
						pdfDoc.Add(pdftable);
						pdfDoc.Close();
						stream.Close();
					}
				}
				catch (IOException exception)
				{
					MessageBox.Show("Plik jest obecnie w użyciu, zamknij plik i spróbuj ponownie", "Błąd",
						MessageBoxButtons.OK);
				}
			}
		}
	}
}
