using Microsoft.AspNetCore.Mvc;
using RedVine.Areas.Identity.Data;

namespace RedVine.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var data = new RedVineUser { 
                Avatar = "/assets/temp.png", 
                DOB=DateTime.Now, 
                Created=DateTime.Now, 
                UsernameReal="Jawlessjman", 
                Likes = [], 
                Id=new Guid().ToString(),
                Email="test@gmail.com"
            };
            return View(data);
        }
    }
}
