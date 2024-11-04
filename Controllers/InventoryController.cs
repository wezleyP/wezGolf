using Microsoft.AspNetCore.Mvc;

namespace wezGolf.Views.Inventory
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
