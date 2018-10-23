using System.Collections.Generic;
using AplikacjaWindows.Layers.DAL;

namespace AplikacjaWindows.Layers.BLL
{
	public class ProductBLL
	{
		private ProductsTableAdapter _productsAdapter;

		protected ProductsTableAdapter Adapter
		{
			get
			{
				if (_productsAdapter == null)
					_productsAdapter = new ProductsTableAdapter();

				return _productsAdapter;
			}
		}

		public IEnumerable<Towary> GetProducts()
		{
			return Adapter.GetProducts();
		}

		public void AddProduct(Towary product)
		{
			Adapter.CreateRecord(product);
		}

		public void EditProduct(Towary product)
		{
			Adapter.UpdateRecord(product);
		}

		public void DeleteProduct(Towary product)
		{
			Adapter.DeleteRecord(product);
		}



	}
}
