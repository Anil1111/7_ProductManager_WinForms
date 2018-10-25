using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Windows.Forms;
using AplikacjaWindows.Layers.BLL;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditCennikiForm : Form
	{
		private Cenniki _cennik;

		public AddEditCennikiForm(Cenniki cennik)
		{
			InitializeComponent();

			_cennik = cennik;

			if (cennik != null)
			{
				AddButtonYes.Text = "Edytuj";

				//Wypełnienie komórek edytowanym obiektem
				NameAddBox.Text = cennik.Nazwa;
				StartDatePicker.Value = DateTime.Parse(StartDatePicker.Value.ToShortDateString());
				EndDatePicker.Value = DateTime.Parse(EndDatePicker.Value.ToShortDateString());
			}
			else
			{
				AddButtonYes.Text = "Dodaj";
			}
		}

		private void AddButtonYes_Click(object sender, EventArgs e)
		{
			try
			{
				if (AddButtonYes.Text == "Dodaj")
				{
					AddPriceList();
				}
				else if (AddButtonYes.Text == "Edytuj")
				{
					EditPriceList();
				}
			}
			catch (FormatException exception)
			{
				MessageBox.Show("Zły format wprowadzonych danych" + exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void AddPriceList()
		{
			//if (StartDatePicker.Value <= EndDatePicker.Value)
			//{
				new PriceListBLL().AddPriceList(new Cenniki
				{
					Nazwa = NameAddBox.Text,
					Data_Od = DateTime.Parse(StartDatePicker.Value.ToString("d")),
					Data_Do = DateTime.Parse(EndDatePicker.Value.ToString("d"))

				});
			//}
			//else
			//{
			//	MessageBox.Show("Data Rozpoczecia nie moze byc późniejsza od Daty Zakończenia", "Błąd",
			//		MessageBoxButtons.OK);
			//}
		}
		private void EditPriceList()
		{
			//Aktualizacja tymczasowego obiektu
			_cennik.Nazwa = NameAddBox.Text;
			_cennik.Data_Od = StartDatePicker.Value;
			_cennik.Data_Do = EndDatePicker.Value;

			if (StartDatePicker.Value <= EndDatePicker.Value)
			{
				new PriceListBLL().EditPriceList(_cennik);
			}
			else
			{
				MessageBox.Show("Data Rozpoczecia nie moze byc późniejsza od Daty Zakończenia", "Błąd",
					MessageBoxButtons.OK);
			}
		}
	}
}
