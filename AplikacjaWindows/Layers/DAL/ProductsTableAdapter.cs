using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;


namespace AplikacjaWindows.Layers.DAL
{
	public class ProductsTableAdapter
	{
		public IEnumerable<Towary> GetAllRecords()
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				return context.Towaries.ToList();
			}
		}

		public void CreateRecord(Towary product)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				try
				{
					context.Towaries.Add(product);
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

					MessageBox.Show("Nieprawidłowy format pola Masa. Dopuszczalne tylko liczby ", "Błąd", MessageBoxButtons.OK);
				}
			}
		}

		public void UpdateRecord(Towary product)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				try
				{
					context.Towaries.AddOrUpdate(product);
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
					MessageBox.Show("Nieprawidłowy format pola Masa. Dopuszczalne tylko liczby ", "Błąd", MessageBoxButtons.OK);

				}
			}
		}

		public void DeleteRecord(Towary product)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				context.Towaries.Attach(product);
				context.Towaries.Remove(product);
				context.SaveChanges();
			}
		}
	}
}
