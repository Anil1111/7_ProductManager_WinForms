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
	public class PriceListsTableAdapter
	{
		public IEnumerable<Cenniki> GetAllRecords()
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				return context.Cennikis.ToList();
			}
		}

		public void CreateRecord(Cenniki priceList)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				try
				{
					context.Cennikis.Add(priceList);
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

		public void UpdateRecord(Cenniki priceList)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				try
				{
					context.Cennikis.AddOrUpdate(priceList);
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

		public void DeleteRecord(Cenniki priceList)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				context.Cennikis.Attach(priceList);
				context.Cennikis.Remove(priceList);
				context.SaveChanges();
			}
		}

	}
}
