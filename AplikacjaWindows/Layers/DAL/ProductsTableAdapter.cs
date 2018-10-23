using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaWindows.Layers.DAL
{
	public class ProductsTableAdapter
	{
		private readonly TowaryDBEntities _context;

		public ProductsTableAdapter(TowaryDBEntities context)
		{
			_context = context;
		}

		public IEnumerable<Towary> GetProducts()
		{
			return _context.Towaries.ToList();
		}

		public IQueryable<Towary> GetProductByID(int id)
		{
			return _context.Towaries.Where(x => x.Id == id);
		}

		///TODO;
		 public IEnumerable<Towary> GetProductsByPriceList(int priceListID)
		 {
			 
			 return null;
		 }

		public void CreateProductRecord(Towary product)
		{
			_context.Towaries.Add(product);
			_context.SaveChanges();
		}

		public void UpdateProductRecord(Towary product)
		{
			_context.Towaries.AddOrUpdate(product);
			_context.SaveChanges();
		}

		public void DeleteProductRecord(Towary product)
		{
			_context.Towaries.Attach(product);
			_context.Towaries.Remove(product);
			_context.SaveChanges();
		}


	}
}
