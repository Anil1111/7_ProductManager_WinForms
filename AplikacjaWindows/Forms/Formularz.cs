using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AplikacjaWindows.Forms
{
	public partial class Formularz : Form
	{
		public TowaryDBEntities _context;
		public Formularz(TowaryDBEntities context)
		{
			InitializeComponent();
			_context = context;
		}

		private void Formularz_Load(object sender, EventArgs e)
		{
			towaryBindingSource.DataSource = _context.Towaries.ToList();
		}

		private void DodajTowarBtn_Click(object sender, EventArgs e)
		{
			using (AddEditTowarForm addEditTowarForm = new AddEditTowarForm(null, _context))
			{
				if (addEditTowarForm.ShowDialog() == DialogResult.Yes)
				{
					towaryBindingSource.DataSource = _context.Towaries.ToList();
				}
			}
		}

		private void EdytujTowarBtn_Click(object sender, EventArgs e)
		{

			if (towaryBindingSource == null)
			{
				return;
			}
			using (AddEditTowarForm editEditTowarForm = new AddEditTowarForm((Towary)towaryBindingSource.Current, _context))
			{
				if (editEditTowarForm.ShowDialog() == DialogResult.Yes)
				{
					towaryBindingSource.DataSource = _context.Towaries.ToList();
				}

			}
		}

		private void UsunTowarBtn_Click(object sender, EventArgs e)
		{
			if (towaryBindingSource.Current != null)
			{
				if (MessageBox.Show("Jesteś pewien?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
					DialogResult.Yes)
				{
					_context.Towaries.Remove((Towary)towaryBindingSource.Current);
					_context.SaveChanges();
					towaryBindingSource.DataSource = _context.Towaries.ToList();
				}
			}
		}
	}
}
