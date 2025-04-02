using Microsoft.AspNetCore.Mvc;

namespace RedVine.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
