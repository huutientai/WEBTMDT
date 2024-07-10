using Microsoft.AspNetCore.Mvc;

namespace webTMDT.Controllers
{
    public class Shop : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
