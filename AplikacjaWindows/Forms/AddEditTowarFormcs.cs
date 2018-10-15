using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using AplikacjaWindows.Helpers;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditTowarForm : Form
	{
		private TowaryDBEntities towaryDbEntities;
		public AddEditTowarForm(Towary towar)
		{
			InitializeComponent();

			towaryDbEntities = new TowaryDBEntities();
			JmBox.DataSource = Enum.GetValues(typeof(JednostkiMasy));

			if (towar == null)
			{
				AddButtonYes.Text = "Dodaj nowy";
				towaryBindingSource.DataSource = new Towary();
				towaryDbEntities.Towaries.Add((Towary)towaryBindingSource.Current);
			}
			else
			{
				AddButtonYes.Text = "Edytuj";
				towaryBindingSource.DataSource = towar;
				towaryDbEntities.Towaries.Attach((Towary) towaryBindingSource.Current);
			}
		}

		private void AddTowarForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (DialogResult == DialogResult.Yes)
			{
				if (string.IsNullOrEmpty(KodAddBox.Text))
				{
					MessageBox.Show("Podaj Kod", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
					KodAddBox.Focus();
					e.Cancel = true;
				}

				towaryDbEntities.SaveChanges();

				e.Cancel = false;
			}
			e.Cancel = false;
		}
	}
}
