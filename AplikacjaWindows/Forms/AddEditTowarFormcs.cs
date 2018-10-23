using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using AplikacjaWindows.Helpers;
using AplikacjaWindows.Layers.BLL;

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

			JmBox.DataSource = Enum.GetValues(typeof(JednostkiMasy));  //Pobranie do rozwijanej listy jednostek masy

			if (towar != null)
			{
				AddButtonYes.Text = "Edytuj";
				//Wypełnienie pól danymi edytowanego towaru
				NameAddBox.Text = towar.Nazwa;
				KodAddBox.Text = towar.Kod;
				MasaAddBox.Text = towar.Masa.ToString();
				JmBox.Text = towar.JM;
				CreateDate.Text = towar.Data_Utworzenia.ToString();
				EditDate.Text = DateTime.Now.ToString("d");
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
					var name = NameAddBox.Text;
					var kod = KodAddBox.Text;
					var masa = Decimal.Parse(MasaAddBox.Text);
					var jm = JmBox.Text;
					var dataUtworzenia = DateTime.Parse(CreateDate.Text = DateTime.Now.ToString("d"));
					DateTime? dataModyfikacji = null;

					ProductBLL addProduct = new ProductBLL();
					addProduct.AddProduct(kod,name,masa,jm,dataUtworzenia,dataModyfikacji);
				}
				else if (AddButtonYes.Text == "Edytuj")
				{
					//Zaktualizowanie wartości pól obiektu Towar
					_towar.Nazwa = NameAddBox.Text;
					_towar.Kod = KodAddBox.Text;
					_towar.Masa = Decimal.Parse(MasaAddBox.Text);
					_towar.JM = JmBox.Text;
					_towar.Data_Utworzenia = DateTime.Parse(CreateDate.Text);
					_towar.Data_Modyfikacji = DateTime.Parse(EditDate.Text = DateTime.Now.ToString("d"));

					ProductBLL editProduct = new ProductBLL();
					editProduct.EditProduct(_towar);
				}
			}
			catch (DbEntityValidationException exception)
			{
				MessageBox.Show("Nieprawidłowy format danych " + exception.Message, "Błąd", MessageBoxButtons.OK);
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
