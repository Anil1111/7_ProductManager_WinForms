using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditCenyForm : Form
	{
		private Ceny _cena;

		private int _closeDisabler = 0;
		public AddEditCenyForm(Ceny cena)
		{
			InitializeComponent();

			_cena = cena;

			using (TowaryDBEntities context = new TowaryDBEntities())
			{

				CennikAddBox.DataSource = context.Cennikis.ToList();
				CennikAddBox.DisplayMember = "Nazwa";
				CennikAddBox.ValueMember = "Id";

				TowarAddBox.DataSource = context.Towaries.ToList();
				TowarAddBox.DisplayMember = "Nazwa";
				TowarAddBox.ValueMember = "Id";


				if (cena != null)
				{
					AddButtonYes.Text = "Edytuj";

					CennikAddBox.SelectedValue = cena.CennikId;
					TowarAddBox.SelectedValue = cena.TowarId;
					CenaAddBox.Text = cena.Cena.ToString();
					RabatAddBox.Text = cena.Rabat.ToString();
				}
				else
				{
					AddButtonYes.Text = "Dodaj";
				}
			}
		}

		private void AddButtonYes_Click(object sender, EventArgs e)
		{
			try
			{
				_closeDisabler = 0;
				if (AddButtonYes.Text == "Dodaj")
				{
					Ceny cena = new Ceny();

					cena.CennikId = Int32.Parse(CennikAddBox.SelectedValue.ToString());
					cena.TowarId = Int32.Parse(TowarAddBox.SelectedValue.ToString());
					cena.Cena = Decimal.Parse(CenaAddBox.Text);
					cena.Rabat = Decimal.Parse(RabatAddBox.Text);

					using (TowaryDBEntities context = new TowaryDBEntities())
					{
						context.Cenies.Add(cena);
						context.SaveChanges();
					}
				}
				else if (AddButtonYes.Text == "Edytuj")
				{
					_cena.CennikId = Int32.Parse(CennikAddBox.SelectedValue.ToString());
					_cena.TowarId = Int32.Parse(TowarAddBox.SelectedValue.ToString());
					_cena.Cena = Decimal.Parse(CenaAddBox.Text);
					_cena.Rabat = Decimal.Parse(RabatAddBox.Text);


					using (TowaryDBEntities context = new TowaryDBEntities())
					{
						context.Cenies.AddOrUpdate(_cena);
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
				MessageBox.Show("Zły format pola Rabat lub Cena. Dopuszczalne tylko liczby " + exception.Message, "Błąd", MessageBoxButtons.OK);
				_closeDisabler = 1;
			}
		}

		private void AddEditCenyForm_FormClosing(object sender, FormClosingEventArgs e)
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
