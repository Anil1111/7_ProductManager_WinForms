using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AplikacjaWindows.Layers.BLL;
using AplikacjaWindows.Layers.BLL.Helpers;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditTowarForm : Form
	{
		private readonly Towary _towar;

		public AddEditTowarForm(Towary towar)
		{
			InitializeComponent();

			_towar = towar;

			UnitWeightBox.DataSource = Enum.GetValues(typeof(UnitWeights)); //Pobranie do rozwijanej listy jednostek masy

			if (towar != null)
			{
				AddButtonYes.Text = "Edytuj";

				//Wypełnienie pól danymi edytowanego towaru
				NameAddBox.Text = towar.Nazwa;
				CodeAddBox.Text = towar.Kod;
				WeightAddBox.Text = towar.Masa.ToString();
				UnitWeightBox.Text = towar.JM;
				CreateDateBox.Text = towar.Data_Utworzenia.ToString();
				EditDateBox.Text = DateTime.Now.ToString();
			}
			else
			{
				AddButtonYes.Text = "Dodaj";
			}
		}

		private void AddButtonYes_Click(object sender, EventArgs e)
		{
			if (AddButtonYes.Text == "Dodaj")
			{
				AddProduct();
			}
			else if (AddButtonYes.Text == "Edytuj")
			{
				EditProduct();
			}
		}

		private void AddProduct()
		{
			try
			{
				new ProductBLL().AddProduct(new Towary
				{
					Kod = CodeAddBox.Text,
					Nazwa = NameAddBox.Text,
					Masa = decimal.Parse(WeightAddBox.Text),
					JM = UnitWeightBox.Text,
					Data_Utworzenia = DateTime.Now,
					Data_Modyfikacji = null
				});
			}
			catch (FormatException)
			{
				MessageBox.Show("Zły format danych, Kod: XXX-XXX, Masa: Liczby powyżej 0, Pola nie mogą być puste",
					"Błąd",
					MessageBoxButtons.OK);
			}
		}

		private void EditProduct()
		{
			try
			{
				//Zaktualizowanie wartości pól obiektu _towar
				_towar.Nazwa = NameAddBox.Text;
				_towar.Kod = CodeAddBox.Text;
				_towar.Masa = decimal.Parse(WeightAddBox.Text);
				_towar.JM = UnitWeightBox.Text;
				_towar.Data_Utworzenia = DateTime.Parse(CreateDateBox.Text);
				_towar.Data_Modyfikacji = DateTime.Parse(EditDateBox.Text = DateTime.Now.ToString());

				new ProductBLL().EditProduct(_towar);
			}
			catch (FormatException)
			{
				MessageBox.Show("Zły format danych, Kod: XXX-XXX, Masa: Liczby powyżej 0, Pola nie mogą być puste",
					"Błąd",
					MessageBoxButtons.OK);
			}
		}

		private void NameAddBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(NameAddBox.Text))
			{
				MessageBox.Show("Nazwa jest wymagana", "Błąd", MessageBoxButtons.OK);
			}

			if (NameAddBox.Text.Length > 255)
			{
				MessageBox.Show("Nazwa jest za długa - dopuszczalny limit 255 znakow", "Błąd", MessageBoxButtons.OK);
			}
		}

		private void CodeAddBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(CodeAddBox.Text))
			{
				MessageBox.Show("Kod jest wymagany", "Błąd", MessageBoxButtons.OK);
			}

			var regexPatern = "[0-9][0-9][0-9]-[0-9]";
			if (!Regex.IsMatch(CodeAddBox.Text, regexPatern))
			{
				MessageBox.Show("Format kodu: XXX-XXX, gdzie X-liczby od 0 do 9", "Błąd", MessageBoxButtons.OK);
			}
		}

		private void WeightAddBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			decimal d;
			if (!decimal.TryParse(WeightAddBox.Text,out d))
			{
				MessageBox.Show("Dopuszczalne liczby zmiennoprzecinkowe", "Błąd", MessageBoxButtons.OK);
			}
		}
	}
}
