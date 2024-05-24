using Microsoft.AspNetCore.Mvc;
using pr37savichev.Data.Interfaces;

namespace pr37savichev.Controllers
{
    public class ItemsController : Controller
    {
        private IItems IAllItems;
        private ICategories IAllCategories;


        public ItemsController(IItems IAllItems, ICategories IAllCategories)
        {
            this.IAllItems = IAllItems;
            this.IAllCategories = IAllCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с предметами";
            var cars = IAllItems.AllItems;
            return View(cars);
        }
    }
}
