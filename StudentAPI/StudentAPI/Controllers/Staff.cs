using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    public class Staff : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
