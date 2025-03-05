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
                "/images/sample1.jpg",
                "/images/sample2.jpg",
                "/images/sample3.jpg"
            };
            return View(images);
        }
    }
}
