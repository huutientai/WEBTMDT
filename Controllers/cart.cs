using Microsoft.AspNetCore.Mvc;

namespace webTMDT.Controllers
{
    public class cart : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
