using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
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
				DataOdPicker.Value = DateTime.Parse(cennik.Data_Od.ToString());
				DataDoPicker.Value = DateTime.Parse(cennik.Data_Do.ToString());
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
			catch (DbEntityValidationException exception)
			{
				MessageBox.Show("Nieprawidłowy format danych ", "Błąd", MessageBoxButtons.OK);
			}
			catch (FormatException exception)
			{
				MessageBox.Show("Zły format pola Danych" + exception.Message, "Błąd", MessageBoxButtons.OK);
			}
		}

		private void AddPriceList()
		{
			if (DataOdPicker.Value < DataDoPicker.Value)
			{
				new PriceListBLL().AddPriceList(new Cenniki
				{
					Nazwa = NameAddBox.Text,
					Data_Od = DataOdPicker.Value,
					Data_Do = DataDoPicker.Value

				});
			}
			else
			{
				MessageBox.Show("Data Rozpoczecia nie moze byc późniejsza od Daty Zakończenia", "Błąd",
					MessageBoxButtons.OK);
			}
		}
		private void EditPriceList()
		{
			_cennik.Nazwa = NameAddBox.Text;
			_cennik.Data_Od = DataOdPicker.Value;
			_cennik.Data_Do = DataDoPicker.Value;

			if (DataOdPicker.Value <= DataDoPicker.Value)
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
