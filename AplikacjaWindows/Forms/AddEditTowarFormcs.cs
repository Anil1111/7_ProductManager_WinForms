using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using AplikacjaWindows.Helpers;

namespace AplikacjaWindows.Forms
{
	public partial class AddEditTowarForm : Form
	{
		private readonly TowaryDBEntities _context;

		public AddEditTowarForm(Towary towar, TowaryDBEntities context)
		{
			InitializeComponent();
			_context = context;

			JmBox.DataSource = Enum.GetValues(typeof(JednostkiMasy));

			if (towar == null)
			{
				AddButtonYes.Text = "Dodaj nowy";
				towaryBindingSource.DataSource = new Towary();
				_context.Towaries.Add((Towary)towaryBindingSource.Current);
			}
			else
			{
				AddButtonYes.Text = "Edytuj";
				towaryBindingSource.DataSource = towar;
				_context.Towaries.Attach((Towary) towaryBindingSource.Current);
				towar.Data_Modyfikacji = DateTime.Now;
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

				_context.SaveChanges();
				
				e.Cancel = false;
			}

			e.Cancel = false;
		}
	}
}
