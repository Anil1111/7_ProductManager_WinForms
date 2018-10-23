using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaWindows.Interfaces
{
	public interface IDatabaseManager
	{

		void CreateRecord(object obj);
		void UpdateRecord(object obj);
		void DeleteRecord(object obj);

	}
}
