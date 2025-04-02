using Microsoft.AspNetCore.Mvc;
using RedVine.Areas.Identity.Data;

namespace RedVine.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var data = new RedVineUser { Avatar = "test", DOB=DateTime.Now, Created=DateTime.Now, UsernameReal="Temp", Likes = [], Id=new Guid().ToString() };
            return View(data);
        }
    }
}
