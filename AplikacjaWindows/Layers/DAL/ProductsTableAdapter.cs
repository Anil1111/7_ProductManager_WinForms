using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using AplikacjaWindows.Interfaces;


namespace AplikacjaWindows.Layers.DAL
{
	public class ProductsTableAdapter : IDatabaseManager
	{
		public IEnumerable<Towary> GetProducts()
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				return context.Towaries.ToList();
			}
		}

		public void CreateRecord(object product)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				try
				{
					context.Towaries.Add((Towary)product);
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

		public void UpdateRecord(object product)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				try
				{
					context.Towaries.AddOrUpdate((Towary)product);
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

		public void DeleteRecord(object product)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				context.Towaries.Attach((Towary)product);
				context.Towaries.Remove((Towary)product);
				context.SaveChanges();
			}
		}
	}
}
