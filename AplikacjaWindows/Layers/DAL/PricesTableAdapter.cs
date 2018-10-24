using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaWindows.Layers.DAL
{
	public class PricesTableAdapter
	{
		public IEnumerable<Ceny> GetAllRecords()
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				return context.Cenies.ToList();
			}
		}

		public void CreateRecord(Ceny price)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				try
				{
					context.Cenies.Add(price);
					context.SaveChanges();
				}
				catch (DbEntityValidationException exception)
				{
					foreach (var e in exception.EntityValidationErrors)
					{
						foreach (var x in e.ValidationErrors)
						{
							MessageBox.Show(x.ErrorMessage, "Błąd", MessageBoxButtons.OK);
						}
					}
				}
				catch (FormatException exception)
				{

					MessageBox.Show("Błąd", "Błąd", MessageBoxButtons.OK);
				}
			}
		}

		public void UpdateRecord(Ceny price)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				try
				{
					context.Cenies.AddOrUpdate(price);
					context.SaveChanges();
				}
				catch (DbEntityValidationException exception)
				{
					foreach (var e in exception.EntityValidationErrors)
					{
						foreach (var x in e.ValidationErrors)
						{
							MessageBox.Show(x.ErrorMessage, "Błąd", MessageBoxButtons.OK);
						}
					}
				}
				catch (FormatException exception)
				{
					MessageBox.Show("Błąd", "Błąd", MessageBoxButtons.OK);

				}
			}
		}

		public void DeleteRecord(Ceny price)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				context.Cenies.Attach(price);
				context.Cenies.Remove(price);
				context.SaveChanges();
			}
		}

	}
}
