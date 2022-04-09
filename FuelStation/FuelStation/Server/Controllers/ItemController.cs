using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
