using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AplikacjaWindows.Helpers;
using AplikacjaWindows.Layers.DAL;

namespace AplikacjaWindows.Layers.BLL
{
	public class ProductBLL
	{
		private ProductsTableAdapter _productsAdapter = null;

		protected ProductsTableAdapter Adapter
		{
			get
			{
				if (_productsAdapter == null)
					_productsAdapter = new ProductsTableAdapter(new TowaryDBEntities());

				return _productsAdapter;
			}
		}

		public IEnumerable<Towary> GetProducts()
		{
			return Adapter.GetProducts();
		}

		public IQueryable<Towary> GetProductByID(int id)
		{
			return Adapter.GetProductByID(id);
		}

		public void AddProduct(string kod, string nazwa, Decimal masa, string jm, DateTime data_utworzenia,
			DateTime? data_modyfikacji)
		{
			Towary product = new Towary();

			product.Kod = kod;
			product.Nazwa = nazwa;
			product.Masa = masa;
			product.JM = jm;
			product.Data_Utworzenia = data_utworzenia;
			product.Data_Modyfikacji = data_modyfikacji;
			product.Cenies = null;

			Adapter.CreateProductRecord(product);
		}

		public void EditProduct(string kod, string nazwa, Decimal masa, string jm, DateTime data_utworzenia,
			DateTime? data_modyfikacji, int productID)
		{
			Towary product = Adapter.GetProductByID(productID).FirstOrDefault();

			product.Kod = kod;
			product.Nazwa = nazwa;
			product.Masa = masa;
			product.JM = jm;
			product.Data_Utworzenia = data_utworzenia;
			product.Data_Modyfikacji = data_modyfikacji;

			Adapter.UpdateProductRecord(product);
		}

		public void EditProduct(Towary product)
		{
			Adapter.UpdateProductRecord(product);
		}

		public void DeleteProduct(int productID)
		{
			Adapter.DeleteProductRecord(productID);
		}

		public void DeleteProduct(Towary product)
		{
			Adapter.DeleteProductRecord(product);
		}



	}
}
