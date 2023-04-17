using Item.DataAccess.Data;
using Item.DataAccess.Repository.IRepository;
using Item.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Item.DataAccess.Repository
{
	public class ItemRepository : Repository<Items>, IItemRepository 
	{
		private AppDBContext _db;

		public ItemRepository(AppDBContext db) : base(db)
		{
			_db = db;
		}

		
		public void Save()
		{
			_db.SaveChanges();
		}

		public void Update(Items item)
		{
			_db.Items.Update(item);
		}
	}
}
