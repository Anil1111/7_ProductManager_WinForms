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

			PriceListAddBox.DataSource = new PriceListBLL().GetPriceLists();
			PriceListAddBox.DisplayMember = "Nazwa";
			PriceListAddBox.ValueMember = "Id";

			ProductAddBox.DataSource = new ProductBLL().GetProducts();
			ProductAddBox.DisplayMember = "Nazwa";
			ProductAddBox.ValueMember = "Id";

			if (cena != null)
			{
				AddButtonYes.Text = "Edytuj";

				//Wypełnienie komórek danymi z edytowanego obiektu
				PriceListAddBox.SelectedValue = cena.CennikId;
				ProductAddBox.SelectedValue = cena.TowarId;
				PriceAddBox.Text = cena.Cena.ToString();
				DiscountAddBox.Text = cena.Rabat.ToString();
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
				if (Decimal.Parse(DiscountAddBox.Text) == 0)
				{
					MessageBox.Show("Ustawiono Rabat = 0", "Komunikat", MessageBoxButtons.OK);
				}

				new PriceBLL().AddPrice(new Ceny
				{
					Cena = Decimal.Parse(PriceAddBox.Text),
					Rabat = Decimal.Parse(DiscountAddBox.Text),
					CennikId = Int32.Parse(PriceListAddBox.SelectedValue.ToString()),
					TowarId = Int32.Parse(ProductAddBox.SelectedValue.ToString())
				});
			}
			catch (FormatException)
			{
				MessageBox.Show("Zły format wprowadzonych danych, lub nie wypełniono wszystkich pól",
					"Błąd",
					MessageBoxButtons.OK);
			}
		}
		private void EditPrice()
		{
			_cena.CennikId = Int32.Parse(PriceListAddBox.SelectedValue.ToString());
			_cena.TowarId = Int32.Parse(ProductAddBox.SelectedValue.ToString());
			_cena.Cena = Decimal.Parse(PriceAddBox.Text);
			_cena.Rabat = Decimal.Parse(DiscountAddBox.Text);

			if (Decimal.Parse(DiscountAddBox.Text) == 0)
			{
				MessageBox.Show("Ustawiono Rabat = 0", "Komunikat", MessageBoxButtons.OK);
			}

			new PriceBLL().EditPrice(_cena);
		}
	}
}
