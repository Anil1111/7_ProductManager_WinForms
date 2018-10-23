using System;
using System.Windows.Forms;
using AplikacjaWindows.Helpers;
using AplikacjaWindows.Layers.BLL;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditTowarForm : Form
	{
		private readonly Towary _towar;

		public AddEditTowarForm(Towary towar)
		{
			InitializeComponent();

			_towar = towar;

			JmBox.DataSource = Enum.GetValues(typeof(JednostkiMasy)); //Pobranie do rozwijanej listy jednostek masy

			if (towar != null)
			{
				AddButtonYes.Text = "Edytuj";

				//Wypełnienie pól danymi edytowanego towaru
				NameAddBox.Text = towar.Nazwa;
				KodAddBox.Text = towar.Kod;
				MasaAddBox.Text = towar.Masa.ToString();
				JmBox.Text = towar.JM;
				CreateDate.Text = towar.Data_Utworzenia.ToString();
				EditDate.Text = DateTime.Now.ToString();
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
					Kod = KodAddBox.Text,
					Nazwa = NameAddBox.Text,
					Masa = decimal.Parse(MasaAddBox.Text),
					JM = JmBox.Text,
					Data_Utworzenia = DateTime.Now,
					Data_Modyfikacji = null
				});
			}
			catch (FormatException exception)
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
				_towar.Kod = KodAddBox.Text;
				_towar.Masa = decimal.Parse(MasaAddBox.Text);
				_towar.JM = JmBox.Text;
				_towar.Data_Utworzenia = DateTime.Parse(CreateDate.Text);
				_towar.Data_Modyfikacji = DateTime.Parse(EditDate.Text = DateTime.Now.ToString("d"));

				new ProductBLL().EditProduct(_towar);
			}
			catch (FormatException exception)
			{
				MessageBox.Show("Zły format danych, Kod: XXX-XXX, Masa: Liczby powyżej 0, Pola nie mogą być puste",
					"Błąd",
					MessageBoxButtons.OK);
			}
		}
	}
}
