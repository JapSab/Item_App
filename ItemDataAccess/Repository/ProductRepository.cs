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
	public class ProductRepository : Repository<Product>, IProductRepository 
	{
		private AppDBContext _db;

		public ProductRepository(AppDBContext db) : base(db)
		{
			_db = db;
		}

		
		public void Save()
		{
			_db.SaveChanges();
		}

		public void Update(Product item)
		{
			_db.Products.Update(item);
		}
	}
}
