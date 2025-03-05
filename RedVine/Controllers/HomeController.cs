using Microsoft.AspNetCore.Mvc;

namespace RedVine.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
