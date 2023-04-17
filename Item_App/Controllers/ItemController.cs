using Item.DataAccess.Data;
using Item.DataAccess.Repository.IRepository;
using Item.Models;
using Microsoft.AspNetCore.Mvc;


namespace Item_App.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepo;
        public ItemController(IItemRepository db) 
        {
			_itemRepo = db;
        }
        // get list of inventory

        public IActionResult Index()
        {
            List<Items> objItemList = _itemRepo.GetAll().ToList();
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
				_itemRepo.Add(obj);
				_itemRepo.Save();
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

			Items? ItemFromDb = _itemRepo.Get(u => u.Id == id);

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
				_itemRepo.Update(obj);
				_itemRepo.Save();
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

			Items? ItemFromDb = _itemRepo.Get(u => u.Id == id);

			if (ItemFromDb == null)
			{
				return NotFound();
			}
			return View(ItemFromDb);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeletePOST(int? id)
		{

			Items? obj = _itemRepo.Get(u => u.Id == id);
			if (obj == null)
			{
				return NotFound();
			}
			_itemRepo.Remove(obj);
			_itemRepo.Save();
			return RedirectToAction("Index", "Item");
		}
	}
}
