using Microsoft.AspNetCore.Mvc;

namespace DotnetAuth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
