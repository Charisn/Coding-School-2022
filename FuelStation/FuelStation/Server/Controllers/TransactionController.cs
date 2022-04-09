using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
