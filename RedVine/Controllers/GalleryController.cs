using Microsoft.AspNetCore.Mvc;
using RedVine.Models;

namespace RedVine.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var images = new List<string>
            {
                "/assets/grandDad.png",
                "/assets/waltenr.png",
                "/assets/hhh.png"
            };
            return View(images);
        }
    }
}
