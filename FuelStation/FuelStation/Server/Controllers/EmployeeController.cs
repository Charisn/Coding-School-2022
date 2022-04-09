using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
