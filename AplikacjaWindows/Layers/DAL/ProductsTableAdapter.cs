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
				context.Towaries.Add(product);
				context.SaveChanges();
			}
		}

		public void UpdateRecord(Towary product)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				context.Towaries.AddOrUpdate(product);
				context.SaveChanges();
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
