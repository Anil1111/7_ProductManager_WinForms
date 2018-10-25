using System;
using System.Windows.Forms;
using AplikacjaWindows.Layers.BLL;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditCenyForm : Form
	{
		private Ceny _cena;

		public AddEditCenyForm(Ceny cena)
		{
			InitializeComponent();

			_cena = cena;

			CennikAddBox.DataSource = new PriceListBLL().GetPriceLists();
			CennikAddBox.DisplayMember = "Nazwa";
			CennikAddBox.ValueMember = "Id";

			TowarAddBox.DataSource = new ProductBLL().GetProducts();
			TowarAddBox.DisplayMember = "Nazwa";
			TowarAddBox.ValueMember = "Id";

			if (cena != null)
			{
				AddButtonYes.Text = "Edytuj";

				//Wypełnienie komórek danymi z edytowanego obiektu
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

		private void AddButtonYes_Click(object sender, EventArgs e)
		{
			if (AddButtonYes.Text == "Dodaj")
			{
				AddPrice();
			}
			else if (AddButtonYes.Text == "Edytuj")
			{
				EditPrice();
			}
		}

		private void AddPrice()
		{
			try
			{
				if (Decimal.Parse(RabatAddBox.Text) == 0)
				{
					MessageBox.Show("Ustawiono Rabat = 0", "Komunikat", MessageBoxButtons.OK);
				}

				new PriceBLL().AddPrice(new Ceny
				{
					Cena = Decimal.Parse(CenaAddBox.Text),
					Rabat = Decimal.Parse(RabatAddBox.Text),
					CennikId = Int32.Parse(CennikAddBox.SelectedValue.ToString()),
					TowarId = Int32.Parse(TowarAddBox.SelectedValue.ToString())
				});
			}
			catch (FormatException exception)
			{
				MessageBox.Show("Zły format danych, Pola nie mogą być puste",
					"Błąd",
					MessageBoxButtons.OK);
			}
		}
		private void EditPrice()
		{
			_cena.CennikId = Int32.Parse(CennikAddBox.SelectedValue.ToString());
			_cena.TowarId = Int32.Parse(TowarAddBox.SelectedValue.ToString());
			_cena.Cena = Decimal.Parse(CenaAddBox.Text);
			_cena.Rabat = Decimal.Parse(RabatAddBox.Text);

			if (Decimal.Parse(RabatAddBox.Text) == 0)
			{
				MessageBox.Show("Ustawiono Rabat = 0", "Komunikat", MessageBoxButtons.OK);
			}

			new PriceBLL().EditPrice(_cena);
		}
	}
}
