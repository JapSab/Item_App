using Item.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.DataAccess.Repository.IRepository
{
	public interface IItemRepository : IRepository<Items>
	{
		void Update(Items item);
		void Save();
	}
}
