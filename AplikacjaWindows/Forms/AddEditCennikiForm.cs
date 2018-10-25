using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditCennikiForm : Form
	{
		private Cenniki _cennik;

		private int _closeDisabler = 0;
		public AddEditCennikiForm(Cenniki cennik)
		{
			InitializeComponent();

			_cennik = cennik;

			if (cennik != null)
			{
				AddButtonYes.Text = "Edytuj";

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
				_closeDisabler = 0;
				if (AddButtonYes.Text == "Dodaj")
				{
					Cenniki cennik = new Cenniki();

					cennik.Nazwa = NameAddBox.Text;
					cennik.Data_Od = DataOdPicker.Value;
					cennik.Data_Do = DataDoPicker.Value;

					using (TowaryDBEntities context = new TowaryDBEntities())
					{
						context.Cennikis.Add(cennik);
						context.SaveChanges();
					}
				}
				else if (AddButtonYes.Text == "Edytuj")
				{
					_cennik.Nazwa = NameAddBox.Text;
					_cennik.Data_Od = DataOdPicker.Value;
					_cennik.Data_Do = DataDoPicker.Value;


					using (TowaryDBEntities context = new TowaryDBEntities())
					{
						context.Cennikis.AddOrUpdate(_cennik);
						context.SaveChanges();
					}
				}
			}
			catch (DbEntityValidationException exception)
			{
				MessageBox.Show("Nieprawidłowy format danych ", "Błąd", MessageBoxButtons.OK);
				_closeDisabler = 1;
			}
			catch (FormatException exception)
			{
				MessageBox.Show("Zły format pola Danych" + exception.Message, "Błąd", MessageBoxButtons.OK);
				_closeDisabler = 1;
			}
		}

		private void CancelAddButton_Click(object sender, EventArgs e)
		{
			_closeDisabler = 0;
		}

		private void AddEditCennikiForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_closeDisabler == 1)
			{
				e.Cancel = true;
			}
			else e.Cancel = false;
		}
	}

}
