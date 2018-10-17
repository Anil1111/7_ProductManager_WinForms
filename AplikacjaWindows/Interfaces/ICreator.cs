using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaWindows.Interfaces
{
	public interface ICreator
	{

		void Create();
		void Edit(object obj);
		void Delete(object obj);

	}
}
