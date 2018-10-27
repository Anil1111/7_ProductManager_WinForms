using System;
using System.Windows.Forms;
using AplikacjaWindows.Layers.BLL;
using AplikacjaWindows.Layers.BLL.Helpers;
using AplikacjaWindows.Layers.BLL.Validators;

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
				AddProduct();
			}
			else if (AddButtonYes.Text == "Edytuj")
			{
				EditProduct();
			}
		}


		//Eventy Walidacji
		private void NameAddBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Validators.NameValidator(errorProvider1,NameAddBox);
		}

		private void CodeAddBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Validators.CodeValidator(errorProvider1, CodeAddBox);
		}

		private void WeightAddBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Validators.WeightValidator(errorProvider1,WeightAddBox);
		}

		//Metody Logiki korzystające z obecnego formularza
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
				DialogResult = DialogResult.None;
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
				DialogResult = DialogResult.None;
			}
		}

	}
}
