using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AplikacjaWindows.Forms
{
	public partial class Formularz : Form
	{
		private TowaryDBEntities _te = new TowaryDBEntities();
		public Formularz()
		{
			InitializeComponent();
		}

		private void Formularz_Load(object sender, EventArgs e)
		{
			towaryBindingSource.DataSource = _te.Towaries.AsNoTracking().ToList();
		}

		private void TowaryListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void DodajTowarBtn_Click(object sender, EventArgs e)
		{
			using (AddEditTowarForm addEditTowarForm = new AddEditTowarForm(null))
			{
				if (addEditTowarForm.ShowDialog() == DialogResult.Yes)
				{
					towaryBindingSource.DataSource = _te.Towaries.AsNoTracking().ToList();
				}
			}
		}

		private void EdytujTowarBtn_Click(object sender, EventArgs e)
		{
			if (towaryBindingSource == null)
			{
				return;
			}
			using (AddEditTowarForm editEditTowarForm = new AddEditTowarForm((Towary)towaryBindingSource.Current))
			{
				if (editEditTowarForm.ShowDialog() == DialogResult.Yes)
				{
					towaryBindingSource.DataSource = _te.Towaries.AsNoTracking().ToList();
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
					_te.Towaries.Remove((Towary) towaryBindingSource.Current);
					_te.SaveChanges();

					towaryBindingSource.DataSource = _te.Towaries.AsNoTracking().ToList();
				}
			}
		}
	}
}
