using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using AplikacjaWindows.Helpers;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditTowarForm : Form
	{
		private Towary _towar;

		private int _closeDisabler = 0;

		public AddEditTowarForm(Towary towar)
		{
			InitializeComponent();
			_towar = towar;

			JmBox.DataSource = Enum.GetValues(typeof(JednostkiMasy));

			CreateDate.Visible = false;
			EditDate.Visible = false;


			if (towar != null)
			{
				AddButtonYes.Text = "Edytuj";
				NameAddBox.Text = towar.Nazwa;
				KodAddBox.Text = towar.Kod;
				MasaAddBox.Text = towar.Masa.ToString();
				JmBox.Text = towar.JM;
				CreateDate.Text = towar.Data_Utworzenia.ToString();
				CreateDate.Enabled = false;
				EditDate.Text = DateTime.Now.ToString("d");
				EditDate.Enabled = false;
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
					Towary towar = new Towary();

					towar.Nazwa = NameAddBox.Text;
					towar.Kod = KodAddBox.Text;
					towar.Masa = Decimal.Parse(MasaAddBox.Text);
					towar.JM = JmBox.Text;
					towar.Data_Utworzenia = DateTime.Parse(CreateDate.Text = DateTime.Now.ToString("d"));
					towar.Data_Modyfikacji = null;
					towar.Cenies = null;

					using (TowaryDBEntities context = new TowaryDBEntities())
					{
						context.Towaries.Add(towar);
						context.SaveChanges();
					}
				}
				else if (AddButtonYes.Text == "Edytuj")
				{
					_towar.Nazwa = NameAddBox.Text;
					_towar.Kod = KodAddBox.Text;
					_towar.Masa = Decimal.Parse(MasaAddBox.Text);
					_towar.JM = JmBox.Text;
					_towar.Data_Utworzenia = DateTime.Parse(CreateDate.Text);
					_towar.Data_Modyfikacji = DateTime.Parse(EditDate.Text = DateTime.Now.ToString("d"));
					_towar.Cenies = null;

					using (TowaryDBEntities context = new TowaryDBEntities())
					{
						context.Towaries.AddOrUpdate(_towar);
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
				MessageBox.Show("Nieprawidłowy format pola Masa. Dopuszczalne tylko liczby ", "Błąd", MessageBoxButtons.OK);
				_closeDisabler = 1;
			}
		}

		private void AddEditTowarForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_closeDisabler == 1)
			{
				e.Cancel = true;
			}
			else e.Cancel = false;
		}

		private void CancelAddButton_Click(object sender, EventArgs e)
		{
			_closeDisabler = 0;
		}
	}
}
