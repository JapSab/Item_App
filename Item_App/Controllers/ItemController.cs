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

        public IActionResult Index()
        {
            List<Items> objItemList = _db.Items.ToList();
            return View(objItemList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
