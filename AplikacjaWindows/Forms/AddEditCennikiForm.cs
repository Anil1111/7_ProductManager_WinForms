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
				if (cennik.Data_Od != null && cennik.Data_Do != null)
				{
					StartDatePicker.Value = cennik.Data_Od.Value;
					EndDatePicker.Value = cennik.Data_Do.Value;
				}
				
			}
			else
			{
				AddButtonYes.Text = "Dodaj";
			}
		}

		private void AddButtonYes_Click(object sender, EventArgs e)
		{
			foreach (Control control in Controls)
			{
				control.Focus();

				if (!Validate())
				{
					DialogResult = DialogResult.None;
				}
			}

			if (AddButtonYes.Text == "Dodaj")
			{
				AddPriceList();
			}
			else if (AddButtonYes.Text == "Edytuj")
			{
				EditPriceList();
			}
		}

		private void AddPriceList()
		{
			var startDate = Convert.ToDateTime(StartDatePicker.Value.ToString("d"));
			var endDate = Convert.ToDateTime(EndDatePicker.Value.ToString("d"));

			if (startDate <= endDate)
			{
				new PriceListBLL().AddPriceList(new Cenniki
				{
					Nazwa = NameAddBox.Text,
					Data_Od = startDate,
					Data_Do = endDate

				});
			}
			else
			{
				MessageBox.Show("Data Rozpoczecia nie moze byc poźniejsza od Daty Zakończenia", "Błąd",
					MessageBoxButtons.OK);
				DialogResult = DialogResult.None;
			}


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
				MessageBox.Show("Data Rozpoczecia nie moze byc poźniejsza od Daty Zakończenia", "Błąd",
					MessageBoxButtons.OK);
				DialogResult = DialogResult.None;
			}
		}
	}
}
