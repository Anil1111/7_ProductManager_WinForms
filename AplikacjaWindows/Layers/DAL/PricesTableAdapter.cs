using System;
using System.Collections.Generic;
using System.Data.Entity;
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

		public Ceny GetRecordByID(int id)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				return context.Cenies.First(x => x.Id == id);
			}
		}

		public void CreateRecord(Ceny price)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				context.Cenies.Add(price);
				context.SaveChanges();
			}
		}

		public void UpdateRecord(Ceny price)
		{
			using (TowaryDBEntities context = new TowaryDBEntities())
			{
				context.Cenies.AddOrUpdate(price);
				context.SaveChanges();
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
