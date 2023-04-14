using Item_App.Data;
using Item_App.Models;
using Microsoft.AspNetCore.Mvc;


namespace Item_App.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDBContext _db;
        public ItemController(AppDBContext db) 
        {
            _db = db;
        }
        // get list of inventory

        public IActionResult Index()
        {
            List<Items> objItemList = _db.Items.ToList();
            return View(objItemList);
        }

		// create methods

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
        public IActionResult Create(Items obj)
        {
            if(ModelState.IsValid)
            {
				_db.Items.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
            return View();    
        }

		// Edit methods
		public IActionResult Edit(int? id)
		{
			if(id==null || id==0)
			{
				return NotFound();
			}

			var ItemFromDb = _db.Items.Find(id);

			if(ItemFromDb==null)
			{
				return NotFound();
			}
			return View(ItemFromDb);
		}

		[HttpPost]
		public IActionResult Edit(Items obj)
		{
			if (ModelState.IsValid)
			{
				_db.Items.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}

		// delete methods
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			Items? ItemFromDb = _db.Items.Find(id);
			if (ItemFromDb == null)
			{
				return NotFound();
			}
			return View(ItemFromDb);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePOST(int? id)
		{
			Items? obj = _db.Items.Find(id);
			if (obj == null)
			{
				return NotFound();
			}
			_db.Items.Remove(obj);
			_db.SaveChanges();
			TempData["success"] = "Category deleted successfully.";

			return RedirectToAction("Index", "Category");
		}






	}
}
