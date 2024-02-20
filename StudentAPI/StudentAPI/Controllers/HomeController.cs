using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
